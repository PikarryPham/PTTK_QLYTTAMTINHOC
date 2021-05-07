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
			SET @RETURNMESS = N'Sai loại nhân viên';
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
		IF NOT EXISTS (SELECT * FROM THONGTINTKNHANVIEN WHERE THONGTINTKNHANVIEN.TKNV_USERNAME = @USERNAME AND THONGTINTKNHANVIEN.TKNV_MATKHAU = @PASS AND THONGTINTKNHANVIEN.TKNV_LOAINHANVIEN = @LOAINHANVIEN)
		BEGIN
			SET @RETURNCODE = 1;
			SET @RETURNMESS = N'Không tồn tại nhân viên này';
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
EXEC PTTK_KiemTraThongTinDauVao 'trangpham','123',1,@RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT; 
SELECT @MESS AS N'Thông báo';

/*Hàm tự generate mã kỳ thi CCQT mới*/
IF OBJECT_ID('GENERATE_KYTHICCQT') IS NOT NULL
	DROP FUNCTION dbo.GENERATE_KYTHICCQT
GO
CREATE FUNCTION GENERATE_KYTHICCQT ()
RETURNS CHAR(5)
AS
BEGIN
	DECLARE @MACN CHAR(5);
	DECLARE @INDEX INT = 2;
	SET @MACN = 'CN001';
	WHILE(EXISTS (SELECT KYTHICCQT.KTQT_ID FROM KYTHICCQT WHERE KYTHICCQT.KTQT_ID = @MACN)) 
		BEGIN
			IF (@INDEX < 10)
			BEGIN
				SET @MACN = 'CN00' + CONVERT(CHAR(5),@INDEX)
			END
			ELSE IF (@INDEX >= 10 AND @INDEX < 100)
			BEGIN
				SET @MACN = 'CN0' + CONVERT(CHAR(5),@INDEX)
			END
			ELSE IF (@INDEX >= 100 AND @INDEX < 1000)
			BEGIN
				SET @MACN = 'CN' + CONVERT(CHAR(5),@INDEX)
			END
			SET @INDEX = @INDEX + 1
		END
	RETURN @MACN
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
		IF(NOT EXISTS (SELECT * FROM KYTHICCQT JOIN CCQT ON KYTHICCQT.KTQT_CCQT = CCQT.CCQT_ID WHERE CCQT.CCQT_TEN = @TENCCQT))
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không tồn tại tên chứng chỉ quốc tế này';
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
DELETE FROM KYTHICCQT WHERE KTQT_ID = 9;

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
		IF(@MAKYTHICCQT = '' OR @MAKYTHICCQT IS NULL)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Vui lòng điền vào mã kỳ thi CCQT';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF(NOT EXISTS (SELECT * FROM KYTHICCQT WHERE KYTHICCQT.KTQT_ID = @MAKYTHICCQT))
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không tồn tại mã ID chứng chỉ quốc tế này';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF(NOT EXISTS (SELECT * FROM KYTHICCQT JOIN CCQT ON KYTHICCQT.KTQT_CCQT = CCQT.CCQT_ID WHERE CCQT.CCQT_TEN = @TENCCQT))
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không tồn tại tên chứng chỉ quốc tế này';
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
			IF(@TGLAMBAI <= 0)
			BEGIN
				SET @RETURNCODE  = 1;
				SET @RETURNMESS = N'Thời gian làm bài phải lớn hơn 0. Vui lòng nhập lại';
				ROLLBACK TRANSACTION;
				RETURN;
			END
			ELSE 
			UPDATE KYTHICCQT
			SET KTQT_TGLAMBAI = @TGLAMBAI
			WHERE KYTHICCQT.KTQT_ID = @MAKYTHICCQT
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
EXEC PTTK_CapNhatVaHienThiThongTinMotKyThi 2,N'Chứng chỉ Security+',N'12A KTX Trần Hưng Đạo Q.5 TP.HCM','12:30:00',3,@RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @MESS AS N'Thông báo';

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
		IF(@MAKYTHICCQT = '' OR @MAKYTHICCQT IS NULL)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Vui lòng điền vào mã kỳ thi CCQT';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF(NOT EXISTS (SELECT * FROM KYTHICCQT WHERE KYTHICCQT.KTQT_ID = @MAKYTHICCQT))
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không tồn tại mã ID chứng chỉ quốc tế này';
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
		IF(@MAKYTHICCQT = '' OR @MAKYTHICCQT IS NULL)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Vui lòng điền vào mã kỳ thi CCQT';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF(NOT EXISTS (SELECT * FROM KYTHICCQT WHERE KYTHICCQT.KTQT_ID = @MAKYTHICCQT))
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không tồn tại mã ID chứng chỉ quốc tế này';
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
	DROP PROC PTTK_XoaNgayeThiHienTai
GO
CREATE PROC PTTK_XoaNgayThiHienTai
@MAKYTHICCQT INT,
@NGAYTHIMOI DATE = '2021-05-15',
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
AS
BEGIN TRANSACTION
	BEGIN TRY
		IF(@MAKYTHICCQT = '' OR @MAKYTHICCQT IS NULL)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Vui lòng điền vào mã kỳ thi CCQT';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF(NOT EXISTS (SELECT * FROM KYTHICCQT WHERE KYTHICCQT.KTQT_ID = @MAKYTHICCQT))
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không tồn tại mã ID chứng chỉ quốc tế này';
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
EXEC PTTK_XoaNgayThiHienTai 9,'2021-07-07',@RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
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
		IF(@MAKYTHICCQT = '' OR @MAKYTHICCQT IS NULL)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Vui lòng điền vào mã kỳ thi CCQT';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF(NOT EXISTS (SELECT * FROM KYTHICCQT WHERE KYTHICCQT.KTQT_ID = @MAKYTHICCQT))
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không tồn tại mã ID chứng chỉ quốc tế này';
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
	ROLLBACK TRANSACTION;
COMMIT TRANSACTION