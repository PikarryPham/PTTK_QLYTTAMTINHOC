﻿/*Xuat giay dang ky hoc phan*/

IF OBJECT_ID('LayGiayDangKyHocPhan','P') IS NOT NULL
	DROP PROC LayGiayDangKyHocPhan
GO
CREATE PROC LayGiayDangKyHocPhan
(
@CMND VARCHAR(20) = NULL,
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
)

AS

BEGIN TRANSACTION
	BEGIN TRY
		SELECT DKHP.DKHP_ID, DKHP.DKHP_NGAYDK, DKHP.DKHP_IDHOCVIEN, NDKT.NDKT_CMND, NDKT.NDKT_TEN, NDKT.NDKT_LOAI, HP.HP_TEN
		FROM DANGKYHOCPHAN DKHP join NGUOIDANGKYTHI NDKT on (DKHP.DKHP_IDHOCVIEN = NDKT.NDKT_ID) join HOCPHAN HP on (DKHP.DKHP_IDHP = HP.HP_ID)
		where NDKT.NDKT_CMND = @CMND;
	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS =  N'Có lỗi xảy ra'
		ROLLBACK TRANSACTION;
	END CATCH
COMMIT TRANSACTION

DECLARE @CODE INT, @MESS NVARCHAR(100)
EXEC LayGiayDangKyHocPhan @RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @MESS AS N'Thông báo';
GO

/*Xem ccqt da dang ky de huy*/

IF OBJECT_ID('XemCCQTDaDangKy','P') IS NOT NULL
	DROP PROC XemCCQTDaDangKy
GO
CREATE PROC XemCCQTDaDangKy
(
@CMND VARCHAR(20) = NULL,
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
)

AS

BEGIN TRANSACTION
	BEGIN TRY
		SELECT NDKT.NDKT_CMND, ndkt.NDKT_TEN, dkt.DKT_ID, dkt.DKT_NGAYDK, dkt.DKT_TTIEN, KTCCQT.KTQT_DIADIEM
		FROM NGUOIDANGKYTHI NDKT join DANGKYTHI DKT on (DKT.DKT_IDNDKT = NDKT.NDKT_ID) join KYTHICCQT KTCCQT on (DKT.DKT_IDKTQT = KTCCQT.KTQT_ID)
		where NDKT.NDKT_CMND = @CMND;

		
	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS =  N'Có lỗi xảy ra'
		ROLLBACK TRANSACTION;
	END CATCH
COMMIT TRANSACTION

DECLARE @CODE INT, @MESS NVARCHAR(100)
EXEC XemCCQTDaDangKy @RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @MESS AS N'Thông báo';
GO

/*Huy dang ky thi ccqt*/


IF OBJECT_ID('HuyDangKyThiCCQT','P') IS NOT NULL
	DROP PROC HuyDangKyThiCCQT
GO
CREATE PROC HuyDangKyThiCCQT
(
@DKTID INT = NULL,
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
)
AS
BEGIN TRANSACTION
	BEGIN TRY
		IF(NOT EXISTS (SELECT * FROM DANGKYTHI WHERE DANGKYTHI.DKT_ID = @DKTID))
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Không tồn tại kỳ thi CCQT này';
			ROLLBACK TRANSACTION;
			RETURN;
		END
		IF(@DKTID IS NOT NULL)
		BEGIN
			DELETE FROM DANGKYTHI 
			WHERE DANGKYTHI.DKT_ID = @DKTID
		END
		ELSE IF (@DKTID IS NULL)
		BEGIN
			SET @RETURNCODE  = 1;
			SET @RETURNMESS =  N'Mã Đăng ký thi không được phép bằng rỗng';
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
	SET @RETURNMESS =  N'Xóa kỳ thi CCQT thành công';
COMMIT TRANSACTION
DECLARE @CODE INT, @MESS NVARCHAR(100)
EXEC HuyDangKyThiCCQT @RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @MESS AS N'Thông báo';
GO


/*Dang ky thi ccqt*/

IF OBJECT_ID('DangKyThiCCQT','P') IS NOT NULL
	DROP PROC DangKyThiCCQT
GO
CREATE PROC DangKyThiCCQT
@CMND VARCHAR(20) = NULL,
@IDKTQT INT = NULL,
@IDHDCC INT = NULL,
@NGAYDK DATE = NULL,
@TTIEN MONEY,
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
AS
BEGIN TRANSACTION
	BEGIN TRY
		IF(@CMND IS NOT NULL and @IDKTQT is not null and @IDHDCC is not null)
		BEGIN
			DECLARE @ID_DKTCCQT INT = (SELECT COUNT(*) FROM NGUOIDANGKYTHI) + 1;
			DECLARE @IDNDK INT = (select NDKT.NDKT_ID from NGUOIDANGKYTHI NDKT where NDKT.NDKT_CMND = @CMND) 
			INSERT INTO DANGKYTHI VALUES(@ID_DKTCCQT,@IDNDK,@IDKTQT,@IDHDCC,@NGAYDK,@TTIEN)
			-- Thông tin ngày thi được tạo mới
			SELECT * FROM DANGKYTHI DKT where DKT.DKT_ID = @ID_DKTCCQT
		END
		
	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS =  N'Có lỗi xảy ra'
		ROLLBACK TRANSACTION;
		RETURN;
	END CATCH
	SET @RETURNCODE = 0;
	SET @RETURNMESS =  N'Đăng ký kỳ thi CCQT thành công';
COMMIT TRANSACTION

DECLARE @CODE INT, @MESS NVARCHAR(100)
EXEC @RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @MESS AS N'Thông báo';



/*Dang ky hoc phan*/

IF OBJECT_ID('DangKyHocPhanChoHocVien','P') IS NOT NULL
	DROP PROC DangKyHocPhanChoHocVien
GO
CREATE PROC DangKyHocPhanChoHocVien

@DKHP_DIEMHP FLOAT,
@DKHP_NGAYDK DATE = NULL,
@CMND VARCHAR(20) = NULL, 
@DKHP_IDHP INT = NULL,
@DKHP_IDHDHP INT = NULL,
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
AS
BEGIN TRANSACTION
	BEGIN TRY
		IF(@CMND IS NOT NULL and @DKHP_IDHP is not null and @DKHP_IDHDHP is not null)
		BEGIN
			DECLARE @ID_DKHP INT = (SELECT COUNT(*) FROM DANGKYHOCPHAN) + 1;
			DECLARE @IDNDK INT = (select NDKT.NDKT_ID from NGUOIDANGKYTHI NDKT where NDKT.NDKT_CMND = @CMND) 
			INSERT INTO DANGKYHOCPHAN VALUES(@ID_DKHP,@DKHP_DIEMHP,@DKHP_NGAYDK,@IDNDK ,@DKHP_IDHP,@DKHP_IDHDHP)
			-- Thông tin ngày thi được tạo mới
			SELECT * FROM DANGKYHOCPHAN DKHP where DKHP.DKHP_ID = @ID_DKHP
		END
		
	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS =  N'Có lỗi xảy ra'
		ROLLBACK TRANSACTION;
		RETURN;
	END CATCH
	SET @RETURNCODE = 0;
	SET @RETURNMESS =  N'Đăng ký học phần thành công';
COMMIT TRANSACTION

DECLARE @CODE INT, @MESS NVARCHAR(100)
EXEC @RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @MESS AS N'Thông báo';

/*Xu ly thanh toan ccqt - tao hoa don*/

IF OBJECT_ID('TaoHoaDonThiCCQT','P') IS NOT NULL
	DROP PROC TaoHoaDonThiCCQT
GO
CREATE PROC TaoHoaDonThiCCQT

@HDCC_HTTTOAN NVARCHAR(100) = NULL,
@HDCC_TTIEN MONEY = NULL,
@HDCC_NGAYLAP DATE = NULL,
@RETURNCODE INT OUTPUT, 
@RETURNMESS NVARCHAR(100) OUTPUT
AS
BEGIN TRANSACTION
	BEGIN TRY
		
		BEGIN
			DECLARE @ID_HoaDonThiCCQT INT = (SELECT COUNT(*) FROM HOADONCCQT) + 1;
			
			INSERT INTO HOADONCCQT VALUES(@ID_HoaDonThiCCQT,@HDCC_HTTTOAN,@HDCC_TTIEN,@HDCC_NGAYLAP)
			-- Thông tin ngày thi được tạo mới
			SELECT * FROM HOADONCCQT HDCCQT where HDCCQT.HDCC_ID = @ID_HoaDonThiCCQT
		END
		
	END TRY
	BEGIN CATCH
		SET @RETURNCODE = 1;
		SET @RETURNMESS =  N'Có lỗi xảy ra'
		ROLLBACK TRANSACTION;
		RETURN;
	END CATCH
	SET @RETURNCODE = 0;
	SET @RETURNMESS =  N'Tạo hóa đơn thi CCQT thành công';
COMMIT TRANSACTION

DECLARE @CODE INT, @MESS NVARCHAR(100)
EXEC @RETURNCODE = @CODE OUTPUT, @RETURNMESS = @MESS OUTPUT ; 
SELECT @MESS AS N'Thông báo';
