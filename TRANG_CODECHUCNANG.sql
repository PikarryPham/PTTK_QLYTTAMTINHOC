﻿/*TRANG CODE */
/*QUAN LY KI THI CCQT */

USE QLTINHOC_PTTK
GO

--Ref: https://www.sqlservertutorial.net/sql-server-stored-procedures/stored-procedure-output-parameters/  

/*Ham kiem tra ket qua dang nhap*/
IF OBJECT_ID('PTTK_KiemTraThongTinDauVao','P') IS NOT NULL
	DROP PROC PTTK_KiemTraThongTinDauVao
GO
CREATE PROC PTTK_KiemTraThongTinDauVao
@USERNAME VARCHAR(100), 
@PASS VARCHAR(50),
@LOAINHANVIEN INT,
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
AS
BEGIN TRANSACTION
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM THONGTINTKNHANVIEN WHERE THONGTINTKNHANVIEN.TKNV_USERNAME = @USERNAME)
		BEGIN
			SET @RETURNCODE = 1;
			SET @RETURNMESS = N'Username không tồn tại';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF NOT EXISTS (SELECT * FROM THONGTINTKNHANVIEN WHERE THONGTINTKNHANVIEN.TKNV_LOAINHANVIEN = @LOAINHANVIEN)
		BEGIN
			SET @RETURNCODE = 1;
			SET @RETURNMESS = N'Không tồn tại loại nhân viên';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF NOT EXISTS (SELECT * FROM THONGTINTKNHANVIEN WHERE THONGTINTKNHANVIEN.TKNV_USERNAME = @USERNAME AND THONGTINTKNHANVIEN.TKNV_MATKHAU = @PASS)
		BEGIN
			SET @RETURNCODE = 1;
			SET @RETURNMESS = N'Sai mật khẩu';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF EXISTS (SELECT * FROM THONGTINTKNHANVIEN WHERE THONGTINTKNHANVIEN.TKNV_USERNAME = @USERNAME AND THONGTINTKNHANVIEN.TKNV_MATKHAU = @PASS AND THONGTINTKNHANVIEN.TKNV_LOAINHANVIEN != @LOAINHANVIEN)
		BEGIN
			SET @RETURNCODE = 1;
			SET @RETURNMESS = N'Sai loại nhân viên';
			ROLLBACK TRANSACTION;
			RETURN;
		END
	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS = N'Lỗi đăng nhập'
		ROLLBACK TRANSACTION;
	END CATCH
	SET @RETURNCODE = 0;
	SET @RETURNMESS = N'Đăng nhập thành công'
COMMIT TRANSACTION

DECLARE @CODE INT, @MESS NVARCHAR(100)
EXEC PTTK_KiemTraThongTinDauVao 'NVTN001','NVTN001',2,@RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT; 
SELECT @MESS AS N'Thông báo';

/*Hàm kiểm tra mã kì thi CCQT*/
IF OBJECT_ID('PTTK_KiemTraMaKiThiCCQT') IS NOT NULL
	DROP FUNCTION PTTK_KiemTraMaKiThiCCQT
GO
CREATE FUNCTION PTTK_KiemTraMaKiThiCCQT (@MAKITHICCQT INT = 1)
RETURNS INTEGER
AS
BEGIN
	DECLARE @CHECK INT = 1; --true
	IF(@MAKITHICCQT IS NULL)
	BEGIN
		SET @CHECK = 0;
	END
	IF(NOT EXISTS (SELECT * FROM KYTHICCQT WHERE KYTHICCQT.KTQT_ID = @MAKITHICCQT))
	BEGIN
		SET @CHECK = 0;
	END
	RETURN @CHECK
END
GO

/*Hàm kiểm tra tên kỳ thi CCQT*/
IF OBJECT_ID('PTTK_KiemTraTonTaiTenCCQT') IS NOT NULL
	DROP FUNCTION PTTK_KiemTraTonTaiTenCCQT
GO
CREATE FUNCTION PTTK_KiemTraTonTaiTenCCQT (@TENCCQT NVARCHAR(100))
RETURNS INTEGER
AS
BEGIN
	IF EXISTS (SELECT * FROM CCQT WHERE CCQT.CCQT_TEN = @TENCCQT)
		BEGIN
			RETURN 1;
		END
	RETURN 0;
END
GO



/*Tạo kỳ thi CCQT mới - trường ID là số tự tăng*/
IF OBJECT_ID('PTTK_TaoMoiVaHienThiKyThiCCQT','P') IS NOT NULL
	DROP PROC PTTK_TaoMoiVaHienThiKyThiCCQT
GO
CREATE PROC PTTK_TaoMoiVaHienThiKyThiCCQT
@NGAYTHI DATE = '2021-05-15', -- Khoi tao gia tri mac dinh
@DIADIEMTHI NVARCHAR(100) = N'227 Nguyen Van Cu Q.5 TP.HCM',
@TENCCQT NVARCHAR(100) = N'Chứng chỉ IREB (CPRE)',
@TGBD TIME = '12:00:00',
@TGLAMBAI INT = 1,
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
AS
BEGIN TRANSACTION
	BEGIN TRY
		DECLARE @ID_KYTHICCQT INT = (SELECT COUNT(*) FROM KYTHICCQT) + 1;
		IF(@NGAYTHI = '' OR @DIADIEMTHI = '' OR @TENCCQT = '' OR @TGBD = '' OR @TGLAMBAI = '')
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Vui lòng điền đầy đủ thông tin';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		-- Kiểm tra tên CCQT có tồn tại không?
		DECLARE @FLAGCCQT INT;
		SET @FLAGCCQT = (SELECT dbo.PTTK_KiemTraTonTaiTenCCQT (@TENCCQT))
		IF(@FLAGCCQT = 0)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không tồn tại tên CCQT này';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF(@TGLAMBAI <=0)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS = N'Thời gian làm bài phải lớn hơn 0. Vui lòng nhập lại';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		-- Tạo một kỳ thi CCQT mới
		DECLARE @ID_CCQT INT = (SELECT CCQT.CCQT_ID FROM CCQT WHERE CCQT.CCQT_TEN = @TENCCQT);
		INSERT INTO dbo.KYTHICCQT VALUES(@ID_KYTHICCQT,@DIADIEMTHI,@TGBD,@TGLAMBAI,@ID_CCQT);
		INSERT INTO dbo.NGAYTHIKYTHICCQT VALUES(@ID_KYTHICCQT,@NGAYTHI);
		-- In thong tin cua ky thi vua moi duoc tao
		SELECT KT.KTQT_ID,CCQT.CCQT_TEN,KT.KTQT_DIADIEM, NGAYTHIKYTHICCQT.NTKTQT_NGAY, KT.KTQT_TGBATDAU, KT.KTQT_TGLAMBAI FROM KYTHICCQT AS KT 
		JOIN CCQT ON CCQT.CCQT_ID = KT.KTQT_CCQT 
		JOIN NGAYTHIKYTHICCQT ON KT.KTQT_ID = NGAYTHIKYTHICCQT.KTQT_ID
		WHERE KT.KTQT_ID = @ID_KYTHICCQT
	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS =  N'Có lỗi xảy ra'
		ROLLBACK TRANSACTION;
	END CATCH
	SET @RETURNCODE = 0;
	SET @RETURNMESS =  N'Tạo thông tin kỳ thi CCQT mới thành công'
COMMIT TRANSACTION

DECLARE @CODE INT, @MESS NVARCHAR(100)
EXEC PTTK_TaoMoiVaHienThiKyThiCCQT '2021-05-15','123A NVC Q.5 TP.HCM',N'Chứng chỉ IREB (CPRE)','12:00:00',1,@RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @MESS AS N'Thông báo';
DELETE FROM KYTHICCQT WHERE KTQT_ID = 11;

SELECT * FROM KYTHICCQT

/*Xem danh sách các kỳ thi CCQT*/
IF OBJECT_ID('PTTK_LayDanhSachKyThiCCQT','P') IS NOT NULL
	DROP PROC PTTK_LayDanhSachKyThiCCQT
GO
CREATE PROC PTTK_LayDanhSachKyThiCCQT
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
AS
BEGIN TRANSACTION
	BEGIN TRY
		SELECT KYTHICCQT.*, CCQT.CCQT_TEN FROM KYTHICCQT JOIN CCQT ON CCQT.CCQT_ID = KYTHICCQT.KTQT_CCQT
	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS =  N'Có lỗi xảy ra'
		ROLLBACK TRANSACTION;
	END CATCH
COMMIT TRANSACTION

DECLARE @CODE INT, @MESS NVARCHAR(100)
EXEC PTTK_LayDanhSachKyThiCCQT @RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @MESS AS N'Thông báo';


/*Cập nhật kỳ thi CCQT*/
IF OBJECT_ID('PTTK_CapNhatVaHienThiThongTinMotKyThi','P') IS NOT NULL
	DROP PROC PTTK_CapNhatVaHienThiThongTinMotKyThi
GO
CREATE PROC PTTK_CapNhatVaHienThiThongTinMotKyThi
@MAKYTHICCQT INT,
@TENCCQT NVARCHAR(100) = NULL,
@DIADIEMTHI NVARCHAR(100) = NULL,
@TGBD TIME = NULL,
@TGLAMBAI INT = NULL,
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
AS
BEGIN TRANSACTION
	BEGIN TRY
		-- Kiểm tra tên CCQT có tồn tại không?
		DECLARE @FLAGCCQT INT;
		SET @FLAGCCQT = (SELECT dbo.PTTK_KiemTraTonTaiTenCCQT (@TENCCQT))
		IF(@FLAGCCQT = 0)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không tồn tại tên CCQT này';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		-- Kiểm tra mã kỳ thi CCQT
		DECLARE @FLAG INT = 1;
		SET @FLAG = (SELECT dbo.PTTK_KiemTraMaKiThiCCQT(@MAKYTHICCQT))
		IF(@FLAG = 0)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không tồn tại mã kỳ thi CCQT này';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		-- Cập nhật thông tin của kỳ thi CCQT đó
		IF(@DIADIEMTHI IS NOT NULL OR @DIADIEMTHI != '')
		BEGIN
			UPDATE KYTHICCQT
			SET KTQT_DIADIEM = @DIADIEMTHI
			WHERE KYTHICCQT.KTQT_ID = @MAKYTHICCQT
		END
		IF(@TGBD IS NOT NULL OR @TGBD != '')
		BEGIN
			UPDATE KYTHICCQT
			SET KTQT_TGBATDAU = @TGBD
			WHERE KYTHICCQT.KTQT_ID = @MAKYTHICCQT
		END
		IF(@TGLAMBAI IS NOT NULL OR LTRIM(RTRIM(@TGLAMBAI)) != '')
		BEGIN
			-- O day minh cho phep thoi gian lam bai nhap vao = 0 (trong Th nay, thoi gian lam bai = 0 ~ thoi gian lam bai la null --> k cap nhat thoi gian lam bai)
			IF(@TGLAMBAI >= 1)
			BEGIN
				UPDATE KYTHICCQT
				SET KTQT_TGLAMBAI = @TGLAMBAI
				WHERE KYTHICCQT.KTQT_ID = @MAKYTHICCQT
			END
		END
		DECLARE @ID_CCQT INT = (SELECT CCQT.CCQT_ID FROM CCQT WHERE CCQT.CCQT_TEN = @TENCCQT);
		IF(@TENCCQT IS NOT NULL OR @TENCCQT != '')
		BEGIN
			UPDATE KYTHICCQT
			SET KTQT_CCQT = @ID_CCQT
			WHERE KYTHICCQT.KTQT_ID = @MAKYTHICCQT
		END
		-- In thong tin cua ky thi vua moi duoc tao
		SELECT KT.KTQT_ID,CCQT.CCQT_TEN,KT.KTQT_DIADIEM, KT.KTQT_TGBATDAU, KT.KTQT_TGLAMBAI FROM KYTHICCQT AS KT 
		JOIN CCQT ON CCQT.CCQT_ID = KT.KTQT_CCQT 
		WHERE KT.KTQT_ID = @MAKYTHICCQT
	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS =  N'Có lỗi xảy ra'
		ROLLBACK TRANSACTION;
	END CATCH
	SET @RETURNCODE = 0;
	SET @RETURNMESS =  N'Cập nhật thông tin kỳ thi CCQT thành công'
COMMIT TRANSACTION

DECLARE @CODE INT, @MESS NVARCHAR(100)
EXEC PTTK_CapNhatVaHienThiThongTinMotKyThi 2,N'Chứng chỉ Security+',N'12A KTX Trần Hưng Đạo Q.5 TP.HCM','12:30:00',0,@RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @MESS AS N'Thông báo';

SELECT * FROM KYTHICCQT

/* Tìm danh sách các ngày thi của 1 kỳ thi CCQT */
IF OBJECT_ID('PTTK_LayDanhSachCacNgayThiCCQT','P') IS NOT NULL
	DROP PROC PTTK_LayDanhSachCacNgayThiCCQT
GO
CREATE PROC PTTK_LayDanhSachCacNgayThiCCQT
@MAKYTHICCQT INT,
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
AS
BEGIN TRANSACTION
	BEGIN TRY
		DECLARE @FLAG INT = 1;
		SET @FLAG = (SELECT dbo.PTTK_KiemTraMaKiThiCCQT(@MAKYTHICCQT))
		IF(@FLAG = 0)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không tồn tại mã kỳ thi CCQT này';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		DECLARE @CHECKTONTAI INT
		SET @CHECKTONTAI = (SELECT COUNT(*) FROM NGAYTHIKYTHICCQT WHERE NGAYTHIKYTHICCQT.KTQT_ID = @MAKYTHICCQT)
		IF(@CHECKTONTAI < 1)
		BEGIN
			SET @RETURNCODE = 1;
			SET @RETURNMESS =  N'Không có ngày thi cho kỳ thi CCQT này'
		END
		SELECT * FROM NGAYTHIKYTHICCQT WHERE NGAYTHIKYTHICCQT.KTQT_ID = @MAKYTHICCQT
	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS =  N'Có lỗi xảy ra'
		ROLLBACK TRANSACTION;
	END CATCH
COMMIT TRANSACTION

DECLARE @CODE INT, @MESS NVARCHAR(100)
EXEC PTTK_LayDanhSachCacNgayThiCCQT 6,@RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @MESS AS N'Thông báo';

/*Thêm ngày thi mới*/
IF OBJECT_ID('PTTK_ThemNgayThiMoi','P') IS NOT NULL
	DROP PROC PTTK_ThemNgayThiMoi
GO
CREATE PROC PTTK_ThemNgayThiMoi
@MAKYTHICCQT INT,
@NGAYTHIMOI DATE = '2021-05-15',
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
AS
BEGIN TRANSACTION
	BEGIN TRY
		DECLARE @FLAG INT = 1;
		SET @FLAG = (SELECT dbo.PTTK_KiemTraMaKiThiCCQT(@MAKYTHICCQT))
		IF(@FLAG = 0)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không tồn tại mã kỳ thi CCQT này';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF(EXISTS (SELECT * FROM NGAYTHIKYTHICCQT WHERE NGAYTHIKYTHICCQT.KTQT_ID = @MAKYTHICCQT AND NGAYTHIKYTHICCQT.NTKTQT_NGAY = @NGAYTHIMOI))
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Đã tồn tại ngày thi này rồi';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF(@NGAYTHIMOI IS NOT NULL)
		BEGIN
			INSERT INTO NGAYTHIKYTHICCQT VALUES(@MAKYTHICCQT,@NGAYTHIMOI)
			-- Thông tin ngày thi được tạo mới
			SELECT * FROM NGAYTHIKYTHICCQT WHERE NGAYTHIKYTHICCQT.KTQT_ID = @MAKYTHICCQT AND NGAYTHIKYTHICCQT.NTKTQT_NGAY = @NGAYTHIMOI
		END
		ELSE IF (@NGAYTHIMOI IS NULL)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Ngày thi không được phép bằng rỗng';
			ROLLBACK TRANSACTION;
			RETURN;
		END
	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS =  N'Có lỗi xảy ra'
		ROLLBACK TRANSACTION;
		RETURN;
	END CATCH
	SET @RETURNCODE = 0;
	SET @RETURNMESS =  N'Thêm một ngày thi mới cho kỳ thi CCQT thành công';
COMMIT TRANSACTION

DECLARE @CODE INT, @MESS NVARCHAR(100)
EXEC PTTK_ThemNgayThiMoi 9,'2021-10-10',@RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @MESS AS N'Thông báo';

/*Xóa ngày thi hiện tại*/
IF OBJECT_ID('PTTK_XoaNgayThiHienTai','P') IS NOT NULL
	DROP PROC PTTK_XoaNgayThiHienTai
GO
CREATE PROC PTTK_XoaNgayThiHienTai
@MAKYTHICCQT INT,
@NGAYTHIMOI DATE = '2021-05-15',
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
AS
BEGIN TRANSACTION
	BEGIN TRY
		DECLARE @FLAG INT = 1;
		SET @FLAG = (SELECT dbo.PTTK_KiemTraMaKiThiCCQT(@MAKYTHICCQT))
		IF(@FLAG = 0)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không tồn tại mã kỳ thi CCQT này';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF(NOT EXISTS (SELECT * FROM NGAYTHIKYTHICCQT WHERE NGAYTHIKYTHICCQT.KTQT_ID = @MAKYTHICCQT AND NGAYTHIKYTHICCQT.NTKTQT_NGAY = @NGAYTHIMOI ))
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không tồn tại thông tin ngày thi + kỳ thi CCQT này';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF(@NGAYTHIMOI IS NOT NULL)
		BEGIN
			DELETE FROM NGAYTHIKYTHICCQT
			WHERE NGAYTHIKYTHICCQT.KTQT_ID = @MAKYTHICCQT AND NGAYTHIKYTHICCQT.NTKTQT_NGAY = @NGAYTHIMOI
		END
		ELSE IF (@NGAYTHIMOI IS NULL)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Ngày thi không được phép bằng rỗng';
			ROLLBACK TRANSACTION;
			RETURN;
		END
	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS =  N'Có lỗi xảy ra'
		ROLLBACK TRANSACTION;
		RETURN;
	END CATCH
	SET @RETURNCODE = 0;
	SET @RETURNMESS =  N'Xóa một ngày thi cho kỳ thi CCQT thành công';
COMMIT TRANSACTION

DECLARE @CODE INT, @MESS NVARCHAR(100)
EXEC PTTK_XoaNgayThiHienTai 5,'2021-07-26',@RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @MESS AS N'Thông báo';



/*Cập nhật ngày thi hiện tại*/
IF OBJECT_ID('PTTK_CapNhatNgayThi','P') IS NOT NULL
	DROP PROC PTTK_CapNhatNgayThi
GO
CREATE PROC PTTK_CapNhatNgayThi
@MAKYTHICCQT INT,
@NGAYTHICU DATE = '2021-05-15',
@NGAYTHIMOI DATE = '2021-05-15',
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
AS
BEGIN TRANSACTION
	BEGIN TRY
		DECLARE @FLAG INT = 1;
		SET @FLAG = (SELECT dbo.PTTK_KiemTraMaKiThiCCQT(@MAKYTHICCQT))
		IF(@FLAG = 0)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không tồn tại mã kỳ thi CCQT này';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF(NOT EXISTS (SELECT * FROM NGAYTHIKYTHICCQT WHERE NGAYTHIKYTHICCQT.KTQT_ID = @MAKYTHICCQT AND NGAYTHIKYTHICCQT.NTKTQT_NGAY = @NGAYTHICU ))
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không tồn tại thông tin ngày thi + kỳ thi CCQT này';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF(@NGAYTHIMOI IS NOT NULL AND @NGAYTHICU IS NOT NULL)
		BEGIN
			UPDATE NGAYTHIKYTHICCQT
			SET NTKTQT_NGAY  = @NGAYTHIMOI
			WHERE KTQT_ID = @MAKYTHICCQT AND NTKTQT_NGAY = @NGAYTHICU
		END
		ELSE
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Ngày thi cũ/Ngày thi mới không được phép bằng rỗng';
			ROLLBACK TRANSACTION;
			RETURN;
		END
	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS =  N'Có lỗi xảy ra'
		ROLLBACK TRANSACTION;
		RETURN;
	END CATCH
	SET @RETURNCODE = 0;
	SET @RETURNMESS =  N'Cập nhật một ngày thi cho kỳ thi CCQT thành công';
COMMIT TRANSACTION

DECLARE @CODE INT, @MESS NVARCHAR(100)
EXEC PTTK_CapNhatNgayThi 9,'2021-06-15','2021-07-25',@RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @MESS AS N'Thông báo';


/*Kiểm tra tồn tại thông tin học viên*/
IF OBJECT_ID('PTTK_KiemTraThongTinTonTaiHV') IS NOT NULL
	DROP FUNCTION PTTK_KiemTraThongTinTonTaiHV
GO
CREATE FUNCTION PTTK_KiemTraThongTinTonTaiHV (@CMNDHOCVIEN VARCHAR(20))
RETURNS INTEGER
AS
BEGIN
	DECLARE @CHECK INT = 1; --true
	IF(@CMNDHOCVIEN IS NULL)
	BEGIN
		SET @CHECK = 0;
	END
	IF(NOT EXISTS (SELECT * FROM NGUOIDANGKYTHI WHERE NGUOIDANGKYTHI.NDKT_CMND = @CMNDHOCVIEN))
	BEGIN
		SET @CHECK = 0;
	END
	RETURN @CHECK
END
GO

/*Xem danh sách học viên của hệ thống*/
IF OBJECT_ID('PTTK_LayDSHocVien','P') IS NOT NULL
	DROP PROC PTTK_LayDSHocVien
GO
CREATE PROC PTTK_LayDSHocVien
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
AS
BEGIN TRANSACTION
	BEGIN TRY
		SELECT * FROM NGUOIDANGKYTHI;
	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS =  N'Có lỗi xảy ra'
		ROLLBACK TRANSACTION;
	END CATCH
	SET @RETURNCODE = 0;
	SET @RETURNMESS =  N'Tìm thông tin thành công'
COMMIT TRANSACTION

DECLARE @CODE INT, @MESS NVARCHAR(100)
EXEC PTTK_LayDSHocVien @RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @MESS AS N'Thông báo';

/*Xem thông tin đăng ký học phần*/
IF OBJECT_ID('PTTK_LayThongTinDKHocPhan','P') IS NOT NULL
	DROP PROC PTTK_LayThongTinDKHocPhan
GO
CREATE PROC PTTK_LayThongTinDKHocPhan
@CMNDHOCVIEN VARCHAR(20),
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
AS
BEGIN TRANSACTION
	BEGIN TRY
		DECLARE @FLAG INT = 1;
		SET @FLAG = (SELECT dbo.PTTK_KiemTraThongTinTonTaiHV(@CMNDHOCVIEN))
		IF(@FLAG = 0)
		BEGIN
			SET @RETURNCODE = 1;
			SET @RETURNMESS =  N'Không tồn tại thông tin học viên'
			ROLLBACK TRANSACTION;
			RETURN;
		END
		DECLARE @IDHOCVIEN INT 
		SET @IDHOCVIEN = (SELECT NDKT_ID FROM NGUOIDANGKYTHI WHERE NGUOIDANGKYTHI.NDKT_CMND = @CMNDHOCVIEN)
		-- Tìm tất cả thông tin đk của học viên đó
		SELECT * FROM DANGKYHOCPHAN WHERE DANGKYHOCPHAN.DKHP_IDHOCVIEN = @IDHOCVIEN
	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS =  N'Có lỗi xảy ra'
		ROLLBACK TRANSACTION;
	END CATCH
	SET @RETURNCODE = 0;
	SET @RETURNMESS =  N'Tìm kiếm thông tin đăng ký thành công'
COMMIT TRANSACTION

DECLARE @CODE INT, @MESS NVARCHAR(100)
EXEC PTTK_LayThongTinDKHocPhan '321743123',@RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @MESS AS N'Thông báo';


/*Ham kiem tra thông tin đầu vào*/
IF OBJECT_ID('PTTTK_KiemTraThongTinDauVao') IS NOT NULL
	DROP FUNCTION PTTTK_KiemTraThongTinDauVao
GO
CREATE FUNCTION PTTTK_KiemTraThongTinDauVao (@CMNDHOCVIEN VARCHAR(20),
@IDHOCPHAN INT = 1,
@THOIGIANDKHOCPHAN DATE = '2021-05-15')
RETURNS INTEGER
AS
BEGIN
		DECLARE @IDHOCVIEN INT 
		SET @IDHOCVIEN = (SELECT NDKT_ID FROM NGUOIDANGKYTHI WHERE NGUOIDANGKYTHI.NDKT_CMND = @CMNDHOCVIEN)
		IF(NOT EXISTS(SELECT * FROM DANGKYHOCPHAN AS DKHP WHERE DKHP.DKHP_IDHOCVIEN = @IDHOCVIEN AND DKHP.DKHP_NGAYDK = @THOIGIANDKHOCPHAN AND DKHP.DKHP_IDHP = @IDHOCPHAN))
		BEGIN
			RETURN 0; --N'Không có thông tin đk học phần này của học viên';
		END
		RETURN 1;
END
GO



/*Hủy thông tin đăng ký học phần*/
IF OBJECT_ID('PTTK_HuyDKHocPhan','P') IS NOT NULL
	DROP PROC PTTK_HuyDKHocPhan
GO
CREATE PROC PTTK_HuyDKHocPhan
@CMNDHOCVIEN VARCHAR(20),
@IDHOCPHAN INT = 1,
@THOIGIANDKHOCPHAN DATE = '2021-05-15',
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
AS
BEGIN TRANSACTION
	BEGIN TRY
		DECLARE @FLAG INT = 1;
		SET @FLAG = (SELECT dbo.PTTK_KiemTraThongTinTonTaiHV(@CMNDHOCVIEN))
		IF(@FLAG = 0)
		BEGIN
			SET @RETURNCODE = 1;
			SET @RETURNMESS =  N'Không tồn tại thông tin học viên'
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF(NOT EXISTS (SELECT * FROM HOCPHAN WHERE HOCPHAN.HP_ID = @IDHOCPHAN))
		BEGIN
			SET @RETURNCODE = 1;
			SET @RETURNMESS =  N'Không tồn tại học phần này'
			ROLLBACK TRANSACTION;
			RETURN;
		END
		DECLARE @IDHOCVIEN INT 
		SET @IDHOCVIEN = (SELECT NDKT_ID FROM NGUOIDANGKYTHI WHERE NGUOIDANGKYTHI.NDKT_CMND = @CMNDHOCVIEN)
		-- Kiểm tra xem học viên đó có đăng ký học phần đó tại thời điểm dk đó không
		DECLARE @CHECK INT = (SELECT DBO.PTTTK_KiemTraThongTinDauVao(@CMNDHOCVIEN, @IDHOCPHAN, @THOIGIANDKHOCPHAN));
		IF(@CHECK = 0)
		BEGIN
			SET @RETURNCODE = 1;
			SET @RETURNMESS = N'Không tồn tại thông tin đăng ký của học viên này';
			ROLLBACK TRANSACTION;
			RETURN;
		END;
		-- Hủy thông tin dk học phần
		DELETE FROM DANGKYHOCPHAN
		WHERE DANGKYHOCPHAN.DKHP_IDHP = @IDHOCPHAN AND DANGKYHOCPHAN.DKHP_IDHOCVIEN = @IDHOCVIEN AND DANGKYHOCPHAN.DKHP_NGAYDK = @THOIGIANDKHOCPHAN
	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS =  N'Có lỗi xảy ra'
		ROLLBACK TRANSACTION;
	END CATCH
	SET @RETURNCODE = 0;
	SET @RETURNMESS =  N'Hủy thông tin đăng ký thành công'
COMMIT TRANSACTION

DECLARE @CODE INT, @MESS NVARCHAR(100)
EXEC PTTK_HuyDKHocPhan '321743123',7,'2021-05-25',@RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @MESS AS N'Thông báo';

/*Kiểm tra điểm học phần*/
IF OBJECT_ID('PTTK_KiemTraDiemHocPhan') IS NOT NULL
	DROP FUNCTION PTTK_KiemTraDiemHocPhan
GO
CREATE FUNCTION PTTK_KiemTraDiemHocPhan (@IDHOCVIEN INT,@IDHOCPHAN INT,@THOIGIANDKHOCPHAN DATE)
RETURNS INTEGER
AS
BEGIN
	DECLARE @DIEMHP FLOAT = (SELECT DKHP.DKHP_DIEMHP FROM DANGKYHOCPHAN DKHP WHERE DKHP.DKHP_IDHOCVIEN = @IDHOCVIEN AND DKHP.DKHP_NGAYDK = @THOIGIANDKHOCPHAN AND DKHP.DKHP_IDHP = @IDHOCPHAN);
	IF (@DIEMHP >= 5)
	BEGIN
		RETURN 1; -- Đậu
	END
	RETURN 0;
END
GO

SELECT dbo.PTTK_KiemTraDiemHocPhan(1,1,'2021-01-05');



/*Tra cứu điểm kết quả học phần*/
IF OBJECT_ID('PTTK_ThongTinChiTietDKHocPhan','P') IS NOT NULL
	DROP PROC PTTK_ThongTinChiTietDKHocPhan
GO
CREATE PROC PTTK_ThongTinChiTietDKHocPhan
@CMNDHOCVIEN VARCHAR(20),
@IDHOCPHAN INT = 1,
@THOIGIANDKHOCPHAN DATE = '2021-05-15',
@THONGBAODAUHAYKHONG NVARCHAR(100) OUTPUT ,
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
AS
BEGIN TRANSACTION
	BEGIN TRY
		DECLARE @FLAG INT = 1;
		SET @FLAG = (SELECT dbo.PTTK_KiemTraThongTinTonTaiHV(@CMNDHOCVIEN))
		IF(@FLAG = 0)
		BEGIN
			SET @RETURNCODE = 1;
			SET @RETURNMESS =  N'Không tồn tại thông tin học viên'
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF(NOT EXISTS (SELECT * FROM HOCPHAN WHERE HOCPHAN.HP_ID = @IDHOCPHAN))
		BEGIN
			SET @RETURNCODE = 1;
			SET @RETURNMESS =  N'Không tồn tại học phần này'
			ROLLBACK TRANSACTION;
			RETURN;
		END
		-- Kiểm tra xem học viên đó có đăng ký học phần đó tại thời điểm dk đó không
		DECLARE @CHECK INT = (SELECT dbo.PTTTK_KiemTraThongTinDauVao(@CMNDHOCVIEN, @IDHOCPHAN, @THOIGIANDKHOCPHAN));
		IF(@CHECK = 0)
		BEGIN
			SET @RETURNCODE  = 1;
			--PRINT 'AHIHI';
			SET @RETURNMESS =  N'Không có thông tin đk học phần này của học viên';
			ROLLBACK TRANSACTION;
			RETURN;
		END;
		DECLARE @IDHOCVIEN INT;
		SET @IDHOCVIEN = (SELECT NDKT_ID FROM NGUOIDANGKYTHI WHERE NGUOIDANGKYTHI.NDKT_CMND = @CMNDHOCVIEN)
		-- Xem thông tin kết quả học phần
		SELECT HOCPHAN.HP_TEN, HOCPHAN.HP_THOIGIANBD, NGUOIDANGKYTHI.NDKT_TEN, DANGKYHOCPHAN.DKHP_DIEMHP, DANGKYHOCPHAN.DKHP_NGAYDK, HOCPHAN.HP_THOIGIANKT
		FROM HOCPHAN 
		JOIN DANGKYHOCPHAN 
		ON HOCPHAN.HP_ID = DANGKYHOCPHAN.DKHP_IDHP
		JOIN NGUOIDANGKYTHI
		ON NGUOIDANGKYTHI.NDKT_ID = DANGKYHOCPHAN.DKHP_IDHOCVIEN
		WHERE DANGKYHOCPHAN.DKHP_IDHOCVIEN = @IDHOCVIEN AND DANGKYHOCPHAN.DKHP_NGAYDK = @THOIGIANDKHOCPHAN AND DANGKYHOCPHAN.DKHP_IDHP = @IDHOCPHAN
		-- Thông báo đậu hay không
		DECLARE @TEMP INT = (SELECT dbo.PTTK_KiemTraDiemHocPhan(@IDHOCVIEN,@IDHOCPHAN,@THOIGIANDKHOCPHAN));
		PRINT @TEMP
		IF @TEMP = 1
		BEGIN
			SET @THONGBAODAUHAYKHONG = N'Chúc mừng bạn đã đậu học phần này';
		END
		ELSE
		BEGIN
			SET @THONGBAODAUHAYKHONG = N'Bạn không đủ điểm để đậu học phần này';
		END;
	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS =  N'Có lỗi xảy ra'
		ROLLBACK TRANSACTION;
	END CATCH
SET @RETURNCODE = 0;
SET @RETURNMESS =  N'Tra cứu điểm thành công'
COMMIT TRANSACTION

DECLARE @CODE INT, @MESS NVARCHAR(100), @THONGBAO NVARCHAR(100)
EXEC PTTK_ThongTinChiTietDKHocPhan '321743123',2,'2021-02-05',@THONGBAODAUHAYKHONG = @THONGBAO OUTPUT, @RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @MESS, @THONGBAO AS N'Thông báo đậu/rớt';


/*Thông tin cấp chứng chỉ*/
IF OBJECT_ID('PTTK_LayThongTinChungChi','P') IS NOT NULL
	DROP PROC PTTK_LayThongTinChungChi
GO
CREATE PROC  PTTK_LayThongTinChungChi
@CMNDHOCVIEN VARCHAR(20),
@IDHOCPHAN INT = 1,
@THOIGIANDKHOCPHAN DATE = '2021-05-15',
@TENCC NVARCHAR(100) OUTPUT,
@NGAYCAPCC NVARCHAR(100) OUTPUT,
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
AS
BEGIN TRANSACTION
	BEGIN TRY
		DECLARE @FLAG INT = 1;
		SET @FLAG = (SELECT dbo.PTTK_KiemTraThongTinTonTaiHV(@CMNDHOCVIEN))
		IF(@FLAG = 0)
		BEGIN
			SET @RETURNCODE = 1;
			SET @RETURNMESS =  N'Không tồn tại thông tin học viên'
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF(NOT EXISTS (SELECT * FROM HOCPHAN WHERE HOCPHAN.HP_ID = @IDHOCPHAN))
		BEGIN
			SET @RETURNCODE = 1;
			SET @RETURNMESS =  N'Không tồn tại học phần này'
			ROLLBACK TRANSACTION;
			RETURN;
		END
		DECLARE @IDHOCVIEN INT 
		SET @IDHOCVIEN = (SELECT NDKT_ID FROM NGUOIDANGKYTHI WHERE NGUOIDANGKYTHI.NDKT_CMND = @CMNDHOCVIEN)
		-- Kiểm tra xem học viên đó có đăng ký học phần đó tại thời điểm dk đó không
		-- Kiểm tra xem học viên đó có đăng ký học phần đó tại thời điểm dk đó không
		DECLARE @CHECK INT = (SELECT dbo.PTTTK_KiemTraThongTinDauVao(@CMNDHOCVIEN, @IDHOCPHAN, @THOIGIANDKHOCPHAN));
		IF(@CHECK = 0)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không có thông tin đk học phần này của học viên';
			ROLLBACK TRANSACTION;
			RETURN;
		END;
		-- Lấy ra id đăng ký học phần của học viên trước
		DECLARE @IDDKHOCPHAN INT = (SELECT DKHP.DKHP_ID FROM DANGKYHOCPHAN AS DKHP WHERE DKHP.DKHP_IDHOCVIEN = @IDHOCVIEN AND DKHP.DKHP_NGAYDK = @THOIGIANDKHOCPHAN AND DKHP.DKHP_IDHP = @IDHOCPHAN)
		-- Lấy thông tin cấp chứng chỉ
		SET @TENCC = (SELECT CHUNGCHIHOCPHAN.CC_TEN
		FROM CHUNGCHIHOCPHAN
		JOIN DANGKYHOCPHAN DKHP
		ON DKHP.DKHP_ID = CC_DKHOCPHAN
		WHERE DKHP.DKHP_ID = @IDDKHOCPHAN);

		SET @NGAYCAPCC = (SELECT CHUNGCHIHOCPHAN.CC_NGAYCAP
		FROM CHUNGCHIHOCPHAN
		JOIN DANGKYHOCPHAN DKHP
		ON DKHP.DKHP_ID = CC_DKHOCPHAN
		WHERE DKHP.DKHP_ID = @IDDKHOCPHAN);

	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS =  N'Có lỗi xảy ra'
		SELECT ERROR_MESSAGE() AS ErrorMessage;
		ROLLBACK TRANSACTION;
	END CATCH
SET @RETURNCODE = 0;
SET @RETURNMESS =  N'Lấy thông tin cấp chứng chỉ thành công';
COMMIT TRANSACTION

DECLARE @CODE INT, @MESS NVARCHAR(100), @TEN NVARCHAR(100), @NGAY NVARCHAR(100)
EXEC PTTK_LayThongTinChungChi '321743123',1,'2021-01-05',@TENCC = @TEN OUTPUT, @NGAYCAPCC = @NGAY OUTPUT, @RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @TEN AS N'Tên chứng chỉ',@NGAY AS N'Ngày cấp',@MESS AS N'Thông báo';

/*Xem thông tin khái quát của 1 đk học phần ở UI Thi lại + in kết quả*/
IF OBJECT_ID('PTTK_ThongTinKhaiQuatDKHocPhan','P') IS NOT NULL
	DROP PROC PTTK_ThongTinKhaiQuatDKHocPhan
GO
CREATE PROC PTTK_ThongTinKhaiQuatDKHocPhan
@CMNDHOCVIEN VARCHAR(20),
@IDHOCPHAN INT = 1,
@THOIGIANDKHOCPHAN DATE = '2021-05-15',
@TENHOCPHAN NVARCHAR(100) OUTPUT ,
@TGBD NVARCHAR(100) OUTPUT ,
@DIEMHP NVARCHAR(100) OUTPUT ,
@NGAYDK NVARCHAR(100) OUTPUT ,
@CMNDHV NVARCHAR(100) OUTPUT ,
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
AS
BEGIN TRANSACTION
	BEGIN TRY
		DECLARE @FLAG INT = 1;
		SET @FLAG = (SELECT dbo.PTTK_KiemTraThongTinTonTaiHV(@CMNDHOCVIEN))
		IF(@FLAG = 0)
		BEGIN
			SET @RETURNCODE = 1;
			SET @RETURNMESS =  N'Không tồn tại thông tin học viên'
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF(NOT EXISTS (SELECT * FROM HOCPHAN WHERE HOCPHAN.HP_ID = @IDHOCPHAN))
		BEGIN
			SET @RETURNCODE = 1;
			SET @RETURNMESS =  N'Không tồn tại học phần này'
			ROLLBACK TRANSACTION;
			RETURN;
		END
		DECLARE @IDHOCVIEN INT 
		SET @IDHOCVIEN = (SELECT NDKT_ID FROM NGUOIDANGKYTHI WHERE NGUOIDANGKYTHI.NDKT_CMND = @CMNDHOCVIEN)
		-- Kiểm tra xem học viên đó có đăng ký học phần đó tại thời điểm dk đó không
		DECLARE @CHECK INT = (SELECT dbo.PTTTK_KiemTraThongTinDauVao(@CMNDHOCVIEN, @IDHOCPHAN, @THOIGIANDKHOCPHAN));
		IF(@CHECK = 0)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không có thông tin đk học phần này của học viên';
			ROLLBACK TRANSACTION;
			RETURN;
		END;	
		-- Thông tin khái quát 1 học phần
		SET @CMNDHV = @CMNDHOCVIEN;
		SET @NGAYDK = @THOIGIANDKHOCPHAN;
		SET @TENHOCPHAN
		=(SELECT HOCPHAN.HP_TEN
		FROM HOCPHAN 
		JOIN DANGKYHOCPHAN 
		ON HOCPHAN.HP_ID = DANGKYHOCPHAN.DKHP_IDHP
		JOIN NGUOIDANGKYTHI
		ON NGUOIDANGKYTHI.NDKT_ID = DANGKYHOCPHAN.DKHP_IDHOCVIEN
		WHERE DANGKYHOCPHAN.DKHP_IDHOCVIEN = @IDHOCVIEN AND DANGKYHOCPHAN.DKHP_NGAYDK = @THOIGIANDKHOCPHAN AND DANGKYHOCPHAN.DKHP_IDHP = @IDHOCPHAN);
		
		SET @TGBD = (SELECT HOCPHAN.HP_THOIGIANBD
		FROM HOCPHAN 
		JOIN DANGKYHOCPHAN 
		ON HOCPHAN.HP_ID = DANGKYHOCPHAN.DKHP_IDHP
		JOIN NGUOIDANGKYTHI
		ON NGUOIDANGKYTHI.NDKT_ID = DANGKYHOCPHAN.DKHP_IDHOCVIEN
		WHERE DANGKYHOCPHAN.DKHP_IDHOCVIEN = @IDHOCVIEN AND DANGKYHOCPHAN.DKHP_NGAYDK = @THOIGIANDKHOCPHAN AND DANGKYHOCPHAN.DKHP_IDHP = @IDHOCPHAN);

		SET @DIEMHP = (SELECT DANGKYHOCPHAN.DKHP_DIEMHP
		FROM HOCPHAN 
		JOIN DANGKYHOCPHAN 
		ON HOCPHAN.HP_ID = DANGKYHOCPHAN.DKHP_IDHP
		JOIN NGUOIDANGKYTHI
		ON NGUOIDANGKYTHI.NDKT_ID = DANGKYHOCPHAN.DKHP_IDHOCVIEN
		WHERE DANGKYHOCPHAN.DKHP_IDHOCVIEN = @IDHOCVIEN AND DANGKYHOCPHAN.DKHP_NGAYDK = @THOIGIANDKHOCPHAN AND DANGKYHOCPHAN.DKHP_IDHP = @IDHOCPHAN);

	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS =  N'Có lỗi xảy ra'
		ROLLBACK TRANSACTION;
	END CATCH
	SET @RETURNCODE = 0;
	SET @RETURNMESS =  N'Xem thông tin dk học phần khái quát thành công'
COMMIT TRANSACTION

DECLARE @CODE INT, @MESS NVARCHAR(100), @TEN NVARCHAR(100), @BDAU NVARCHAR(100), @DIEM NVARCHAR(100), @NGAYDKHP NVARCHAR(100), @CHUNGMINHND NVARCHAR(100)
EXEC PTTK_ThongTinKhaiQuatDKHocPhan '321743123',1,'2021-01-05',@TENHOCPHAN = @TEN OUTPUT, @TGBD = @BDAU OUTPUT, @DIEMHP = @DIEM OUTPUT, @NGAYDK = @NGAYDKHP OUTPUT, @CMNDHV = @CHUNGMINHND OUTPUT,
@RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @TEN, @BDAU, @DIEM, @NGAYDKHP, @CHUNGMINHND;


/*Hàm kiểm tra có cho đăng ký thi lại không*/
IF OBJECT_ID('PTTK_KiemTraDuocThiLai') IS NOT NULL
	DROP FUNCTION PTTK_KiemTraDuocThiLai
GO
CREATE FUNCTION PTTK_KiemTraDuocThiLai (@IDDKHOCPHAN INT)
RETURNS INTEGER
AS
BEGIN
	DECLARE @DEMSOLANTHILAI INT = 0;
	SET @DEMSOLANTHILAI = (SELECT COUNT(*) FROM LICHTHILAI WHERE LICHTHILAI.LTL_DKHOCPHAN = @IDDKHOCPHAN);
	DECLARE @DIEMHOCPHAN FLOAT = (SELECT DANGKYHOCPHAN.DKHP_DIEMHP FROM DANGKYHOCPHAN WHERE DANGKYHOCPHAN.DKHP_ID = @IDDKHOCPHAN);
	IF(@DIEMHOCPHAN >= 5)
	BEGIN
		RETURN -1; --Chi cho phep thi lai khi diem thi < 5
	END;
	IF(@DEMSOLANTHILAI >= 3)
	BEGIN
		RETURN 0; --Khong duoc thi lai nua vi da qua han cho phep
	END;
	RETURN 1;
END
GO

/*Lấy thông tin lịch thi lại*/ -- Tạo thông tin lịch thi lại nếu ng đó muốn thi lại
IF OBJECT_ID('PTTK_GhiNhanThongTinLichThiLai','P') IS NOT NULL
	DROP PROC PTTK_GhiNhanThongTinLichThiLai
GO
CREATE PROC PTTK_GhiNhanThongTinLichThiLai
@IDDKHOCPHAN INT,
@NGAYTHILAI DATE  ,
@PHONGTHI NVARCHAR(100)  ,
@THOIGIANBD TIME  ,
@THGIANLAMBAI INT ,
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
AS
BEGIN TRANSACTION
	BEGIN TRY
		-- Kiểm tra có thông tin đk học phần này k?
		IF(NOT EXISTS(SELECT * FROM DANGKYHOCPHAN AS DKHP WHERE DKHP.DKHP_ID = @IDDKHOCPHAN))
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không có thông tin đk học phần này của học viên';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		DECLARE @FLAG INT = (SELECT dbo.PTTK_KiemTraDuocThiLai(@IDDKHOCPHAN));
		IF(@FLAG = 0)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không được đăng ký thi lại nữa. Học viên chỉ được thi lại tối đa 3 lần!';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF(@FLAG = -1)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Bạn chỉ được đăng ký thi lại khi điểm trung bình < 5';
			ROLLBACK TRANSACTION;
			RETURN;
		END;
		IF(@THGIANLAMBAI <= 1)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Thời gian làm bài phải >= 1';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		DECLARE @NGAYDKHOCPHAN DATE = (SELECT DKHP.DKHP_NGAYDK FROM DANGKYHOCPHAN DKHP WHERE DKHP.DKHP_ID = @IDDKHOCPHAN);
		IF(@NGAYDKHOCPHAN >= @NGAYTHILAI) --Ngày thi lại phải lớn hơn ngày đăng ký học phần
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Ngày thi lại phải lớn hơn ngày đăng ký học phần';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		-- Tạo lịch thi lại và đăng ký lịch thi lại cho học viên
		DECLARE @IDLICHTHILAI INT = (SELECT COUNT(*) FROM LICHTHILAI) + 1;
		INSERT INTO LICHTHILAI VALUES(@IDLICHTHILAI,@NGAYTHILAI,@PHONGTHI,@THOIGIANBD,@THGIANLAMBAI,@IDDKHOCPHAN);
		SET @RETURNCODE = 0;
		SET @RETURNMESS =  N'Tạo mới lịch thi lại và ghi nhận thông tin thi lại cho học viên thành công'
		SELECT * FROM LICHTHILAI WHERE LICHTHILAI.LTL_DKHOCPHAN = @IDDKHOCPHAN AND LICHTHILAI.LTL_ID = @IDLICHTHILAI
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS =  N'Có lỗi xảy ra'
		SELECT ERROR_MESSAGE() AS ERR;
		ROLLBACK TRANSACTION;
	END CATCH

DECLARE @CODE INT, @MESS NVARCHAR(100)
EXEC PTTK_GhiNhanThongTinLichThiLai 1,'2021-05-15','I32','14:20:00',3,@RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @MESS AS N'Thong bao';


