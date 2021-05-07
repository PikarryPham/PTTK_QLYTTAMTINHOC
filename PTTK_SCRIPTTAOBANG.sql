﻿-- TẠO CSDL CHO HỆ THỐNG QUẢN LÝ TIN HỌC
USE master 
GO
IF DB_ID('QLTINHOC_PTTK') IS NOT NULL
	DROP DATABASE QLTINHOC_PTTK
GO
CREATE DATABASE QLTINHOC_PTTK
GO
USE QLTINHOC_PTTK
GO
/*
	Kiểm tra bảng có tồn tại? Xóa: Tạo mới
*/

IF OBJECT_ID(N'dbo.NGUOIDANGKYTHI', N'U') IS NOT NULL
BEGIN
    PRINT 'Table Exists';
	DROP TABLE dbo.NGUOIDANGKYTHI;
	PRINT 'Delete Table Successfully';
END
IF OBJECT_ID(N'dbo.GIANGVIEN', N'U') IS NOT NULL
BEGIN
    PRINT 'Table Exists';
	DROP TABLE dbo.GIANGVIEN;
	PRINT 'Delete Table Successfully';
END
IF OBJECT_ID(N'dbo.HOADONCCQT', N'U') IS NOT NULL
BEGIN
    PRINT 'Table Exists';
	DROP TABLE dbo.HOADONCCQT;
	PRINT 'Delete Table Successfully';
END
IF OBJECT_ID(N'dbo.KYTHICCQT', N'U') IS NOT NULL
BEGIN
    PRINT 'Table Exists';
	DROP TABLE dbo.KYTHICCQT;
	PRINT 'Delete Table Successfully';
END
IF OBJECT_ID(N'dbo.NGAYTHIKYTHICCQT', N'U') IS NOT NULL
BEGIN
    PRINT 'Table Exists';
	DROP TABLE dbo.NGAYTHIKYTHICCQT;
	PRINT 'Delete Table Successfully';
END
IF OBJECT_ID(N'dbo.CCQT', N'U') IS NOT NULL
BEGIN
    PRINT 'Table Exists';
	DROP TABLE dbo.CCQT;
	PRINT 'Delete Table Successfully';
END
IF OBJECT_ID(N'dbo.DANGKYTHI', N'U') IS NOT NULL
BEGIN
    PRINT 'Table Exists';
	DROP TABLE dbo.DANGKYTHI;
	PRINT 'Delete Table Successfully';
END
IF OBJECT_ID(N'dbo.THETHANHTOAN', N'U') IS NOT NULL
BEGIN
    PRINT 'Table Exists';
	DROP TABLE dbo.THETHANHTOAN;
	PRINT 'Delete Table Successfully';
END
IF OBJECT_ID(N'dbo.HOCPHAN', N'U') IS NOT NULL
BEGIN
    PRINT 'Table Exists';
	DROP TABLE dbo.HOCPHAN;
	PRINT 'Delete Table Successfully';
END
IF OBJECT_ID(N'dbo.HOCPHANBATBUOC', N'U') IS NOT NULL
BEGIN
    PRINT 'Table Exists';
	DROP TABLE dbo.HOCPHANBATBUOC;
	PRINT 'Delete Table Successfully';
END
IF OBJECT_ID(N'dbo.THOIKHOABIEU', N'U') IS NOT NULL
BEGIN
    PRINT 'Table Exists';
	DROP TABLE dbo.THOIKHOABIEU;
	PRINT 'Delete Table Successfully';
END
IF OBJECT_ID(N'dbo.CHUNGCHIHOCPHAN', N'U') IS NOT NULL
BEGIN
    PRINT 'Table Exists';
	DROP TABLE dbo.CHUNGCHIHOCPHAN;
	PRINT 'Delete Table Successfully';
END
IF OBJECT_ID(N'dbo.LICHTHILAI', N'U') IS NOT NULL
BEGIN
    PRINT 'Table Exists';
	DROP TABLE dbo.LICHTHILAI;
	PRINT 'Delete Table Successfully';
END
IF OBJECT_ID(N'dbo.HOADONHOCPHAN', N'U') IS NOT NULL
BEGIN
    PRINT 'Table Exists';
	DROP TABLE dbo.HOADONHOCPHAN;
	PRINT 'Delete Table Successfully';
END
IF OBJECT_ID(N'dbo.PHANCONGGIANGDAY', N'U') IS NOT NULL
BEGIN
    PRINT 'Table Exists';
	DROP TABLE dbo.PHANCONGGIANGDAY;
	PRINT 'Delete Table Successfully';
END
IF OBJECT_ID(N'dbo.DANGKYHOCPHAN', N'U') IS NOT NULL
BEGIN
    PRINT 'Table Exists';
	DROP TABLE dbo.DANGKYHOCPHAN;
	PRINT 'Delete Table Successfully';
END
IF OBJECT_ID(N'dbo.THONGTINTKNHANVIEN', N'U') IS NOT NULL
BEGIN
    PRINT 'Table Exists';
	DROP TABLE dbo.THONGTINTKNHANVIEN;
	PRINT 'Delete Table Successfully';
END


/* Tạo bảng mới */
CREATE TABLE NGUOIDANGKYTHI (
	 NDKT_ID INT NOT NULL,
	 NDKT_CMND VARCHAR(20) UNIQUE NOT NULL,
	 NDKT_TEN NVARCHAR(100) NOT NULL,
	 NDKT_DCHI NVARCHAR(100) NOT NULL,
	 NDKT_EMAIL VARCHAR(100) UNIQUE NOT NULL,
	 NDKT_GTINH NVARCHAR(20) NOT NULL,
	 check(NDKT_GTINH in (N'Nam', N'Nữ')),
	 NDKT_LOAI NVARCHAR(20) NOT NULL,
	 check(NDKT_LOAI in (N'Học Viên', N'Giảng viên',N'Người đăng ký thi')),
	 NDKT_SDT VARCHAR(20) NOT NULL

	CONSTRAINT PK_NGDANGKYTHI -- dat ten khoa chinh
	PRIMARY KEY (NDKT_ID)
);
GO
CREATE TABLE GIANGVIEN (
	 GV_IDNDKT INT NOT NULL,
	 GV_CHUCVU NVARCHAR(100),
	 GV_KHOA NVARCHAR(100) NOT NULL

	CONSTRAINT PK_GIANGVIEN -- dat ten khoa chinh
	PRIMARY KEY (GV_IDNDKT)
);
GO
CREATE TABLE HOADONCCQT (
	 HDCC_ID INT NOT NULL,
	 HDCC_HTTTOAN NVARCHAR(100) NOT NULL,
	 HDCC_TTIEN MONEY NOT NULL,
	 CHECK (HDCC_TTIEN >= 0),
	 HDCC_NGAYLAP DATE NOT NULL,

	CONSTRAINT PK_HOADONCCQT -- dat ten khoa chinh
	PRIMARY KEY (HDCC_ID)
);
GO
CREATE TABLE KYTHICCQT (
	 KTQT_ID INT NOT NULL,
	 KTQT_DIADIEM NVARCHAR(100) NOT NULL,
	 KTQT_TGBATDAU time NOT NULL,
	 KTQT_TGLAMBAI INT NOT NULL,
	 KTQT_CCQT INT NOT NULL -- Ref tới CCQT

	CONSTRAINT PK_KYTHICCQT -- dat ten khoa chinh
	PRIMARY KEY (KTQT_ID)
);
GO
CREATE TABLE NGAYTHIKYTHICCQT (
	 KTQT_ID INT NOT NULL,
	 NTKTQT_NGAY DATE 

	CONSTRAINT PK_NGAYTHIKYTHICCQT -- dat ten khoa chinh
	PRIMARY KEY (KTQT_ID, NTKTQT_NGAY)
);
GO
CREATE TABLE CCQT (
	 CCQT_ID INT NOT NULL,
	 CCQT_PHICAP MONEY NOT NULL,
	 CHECK (CCQT_PHICAP >= 0),
	 CCQT_PHIDK MONEY NOT NULL,
	 CHECK (CCQT_PHIDK >= 0),
	 CCQT_TEN NVARCHAR(100) NOT NULL

	CONSTRAINT PK_CCQT -- dat ten khoa chinh
	PRIMARY KEY (CCQT_ID)
);
GO
CREATE TABLE DANGKYTHI (
	DKT_ID INT NOT NULL,
	DKT_IDNDKT INT NOT NULL,
	DKT_IDKTQT INT NOT NULL,
	DKT_IDHDCC INT NOT NULL,
	DKT_NGAYDK DATE NOT NULL,
	DKT_TTIEN MONEY
	CHECK(DKT_TTIEN>=0),

	CONSTRAINT PK_DANGKYTHI -- dat ten khoa chinh
	PRIMARY KEY (DKT_ID)
);
GO
CREATE TABLE THETHANHTOAN (
	THE_ID INT NOT NULL,
	THE_CHINHANH NVARCHAR(100) NOT NULL,
	THE_NGANHANG NVARCHAR(100) NOT NULL,
	THE_STK NVARCHAR(20) NOT NULL,
	THE_TENCT NVARCHAR(100) NOT NULL,
	HOCVIEN_ID INT NOT NULL

	CONSTRAINT PK_THETHANHTOAN -- dat ten khoa chinh
	PRIMARY KEY (THE_ID)
);
GO
CREATE TABLE HOCPHAN (
	HP_ID INT NOT NULL,
	HP_MAHOCPHAN NVARCHAR(100) NOT NULL,
	HP_THOIGIANBD DATE NOT NULL,
	HP_LOAIHP NVARCHAR(100) NOT NULL,
	CHECK (HP_LOAIHP IN(N'Học phần bắt buộc', N'Học phần chuyên sâu')),
	HP_OPENCHECK INT NOT NULL,
	HP_SISO INT NOT NULL,
	CHECK (HP_SISO >= 0),
	HP_SOCHI INT NOT NULL,
	CHECK (HP_SOCHI >= 0),
	HP_TEN NVARCHAR(100) NOT NULL,
	HP_THOIGIANKT DATE

	CONSTRAINT PK_HOCPHAN-- dat ten khoa chinh
	PRIMARY KEY (HP_ID)
);
GO
CREATE TABLE HOCPHANBATBUOC(
	HP_IDCB NVARCHAR(100) NOT NULL,
	HP_IDCS NVARCHAR(100) NOT NULL,

	CONSTRAINT PK_HOCPHANBATBUOC-- dat ten khoa chinh
	PRIMARY KEY (HP_IDCB,HP_IDCS)
);
GO
CREATE TABLE THOIKHOABIEU
(
	TKB_ID INT NOT NULL,
	TKB_PHONG NVARCHAR(20),
	TKB_TGBD TIME,
	TKB_TGKT TIME,
	TKB_THU NVARCHAR(50),
	CHECK(TKB_THU IN (N'Thứ hai',N'Thứ ba',N'Thứ tư',N'Thứ năm',N'Thứ sáu',N'Thứ bảy',N'Chủ nhật')),
	TKB_IDHP INT NOT NULL

	CONSTRAINT PK_THOIKHOABIEU-- dat ten khoa chinh
	PRIMARY KEY (TKB_ID)
);
GO
CREATE TABLE CHUNGCHIHOCPHAN
(
	CC_ID NVARCHAR(50) NOT NULL,
	CC_NGAYCAP DATE,
	CC_TEN NVARCHAR(100) NOT NULL,
	CC_DKHOCPHAN INT

	CONSTRAINT PK_CHUNGCHIHOCPHAN-- dat ten khoa chinh
	PRIMARY KEY (CC_ID)
);
GO
CREATE TABLE LICHTHILAI
(
	LTL_ID INT NOT NULL,
	LTL_NGAY DATE NOT NULL,
	LTL_PHONG NVARCHAR(100) NOT NULL,
	LTL_TGBATDAU TIME NOT NULL,
	LTL_TGLAMBAI INT NOT NULL,
	LTL_DKHOCPHAN INT

	CONSTRAINT PK_LICHTHILAI-- dat ten khoa chinh
	PRIMARY KEY (LTL_ID)
);
GO
CREATE TABLE HOADONHOCPHAN
(
	HDHP_ID INT NOT NULL,
	HDHP_HTTTOAN NVARCHAR(100) NOT NULL,
	HDHP_HDCTY BIT NOT NULL,
	HDHP_NGAY DATE NOT NULL,
	HDHP_TONGTIEN MONEY NOT NULL

	CONSTRAINT PK_HOADONHOCPHAN -- dat ten khoa chinh
	PRIMARY KEY (HDHP_ID)
);
GO
CREATE TABLE PHANCONGGIANGDAY
(
	PCGD_IDGV INT NOT NULL,
	PCGD_IDHP INT NOT NULL

	CONSTRAINT PK_PCGD -- dat ten khoa chinh
	PRIMARY KEY (PCGD_IDGV,PCGD_IDHP)
);
GO
CREATE TABLE DANGKYHOCPHAN
(
	DKHP_ID INT NOT NULL,
	DKHP_DIEMHP FLOAT,
	CHECK(DKHP_DIEMHP >= 0),
	DKHP_NGAYDK DATE NOT NULL,
	DKHP_IDHOCVIEN INT NOT NULL,
	DKHP_IDHP INT NOT NULL,
	DKHP_IDHDHP INT NOT NULL

	CONSTRAINT PK_DKHOCPHAN -- dat ten khoa chinh
	PRIMARY KEY (DKHP_ID)
);
GO
CREATE TABLE THONGTINTKNHANVIEN (
	 TKNV_USERNAME VARCHAR(100) NOT NULL,
	 TKNV_MATKHAU VARCHAR(50) NOT NULL,
	 TKNV_LOAINHANVIEN INT NOT NULL

	CONSTRAINT PK_THONGTINNHANVIEN -- dat ten khoa chinh
	PRIMARY KEY (TKNV_USERNAME)
);
GO

-- Thêm khóa ngoại
ALTER TABLE DANGKYTHI
	ADD CONSTRAINT FK_DKYTHI_NGUOIDKTHI
	FOREIGN KEY (DKT_IDNDKT) REFERENCES NGUOIDANGKYTHI
	ON DELETE CASCADE;
ALTER TABLE DANGKYTHI
	ADD CONSTRAINT FK_DKYTHI_KYTHICCQT
	FOREIGN KEY (DKT_IDKTQT) REFERENCES KYTHICCQT
	ON DELETE CASCADE;
ALTER TABLE DANGKYTHI
	ADD CONSTRAINT FK_DKYTHI_HOADONCCQT
	FOREIGN KEY (DKT_IDHDCC) REFERENCES HOADONCCQT
	ON DELETE CASCADE;
ALTER TABLE GIANGVIEN
	ADD CONSTRAINT FK_GIANGVIEN
	FOREIGN KEY (GV_IDNDKT) REFERENCES NGUOIDANGKYTHI
	ON DELETE CASCADE;
ALTER TABLE KYTHICCQT
	ADD CONSTRAINT FK_KYTHICCQT
	FOREIGN KEY (KTQT_CCQT) REFERENCES CCQT
	ON DELETE CASCADE;
ALTER TABLE THETHANHTOAN
	ADD CONSTRAINT FK_THETT
	FOREIGN KEY (HOCVIEN_ID) REFERENCES NGUOIDANGKYTHI
	ON DELETE CASCADE;
ALTER TABLE LICHTHILAI
	ADD CONSTRAINT FK_LICHTHILAI
	FOREIGN KEY (LTL_DKHOCPHAN) REFERENCES DANGKYHOCPHAN
	ON DELETE CASCADE;
ALTER TABLE CHUNGCHIHOCPHAN
	ADD CONSTRAINT FK_CHUNGCHIHOCPHAN
	FOREIGN KEY (CC_DKHOCPHAN) REFERENCES DANGKYHOCPHAN
	ON DELETE CASCADE;
ALTER TABLE DANGKYHOCPHAN
	ADD CONSTRAINT FK_DKHP_HOCVIEN
	FOREIGN KEY (DKHP_IDHOCVIEN) REFERENCES NGUOIDANGKYTHI
	ON DELETE CASCADE;
ALTER TABLE DANGKYHOCPHAN
	ADD CONSTRAINT FK_DKHP_HOCPHAN
	FOREIGN KEY (DKHP_IDHP) REFERENCES HOCPHAN
	ON DELETE CASCADE;
ALTER TABLE DANGKYHOCPHAN
	ADD CONSTRAINT FK_DKHP_HDHP
	FOREIGN KEY (DKHP_IDHDHP) REFERENCES HOADONHOCPHAN
	ON DELETE CASCADE;
ALTER TABLE PHANCONGGIANGDAY
	ADD CONSTRAINT FK_PCGD_GIANGVIEN
	FOREIGN KEY (PCGD_IDGV) REFERENCES GIANGVIEN
	ON DELETE CASCADE;
ALTER TABLE PHANCONGGIANGDAY
	ADD CONSTRAINT FK_PCGD_HOCPHAN
	FOREIGN KEY (PCGD_IDHP) REFERENCES HOCPHAN
	ON DELETE CASCADE;
ALTER TABLE THOIKHOABIEU
	ADD CONSTRAINT FK_TKB
	FOREIGN KEY (TKB_IDHP) REFERENCES HOCPHAN
	ON DELETE CASCADE;
ALTER TABLE NGAYTHIKYTHICCQT
	ADD CONSTRAINT FK_NGAYTHIKITHICCQT
	FOREIGN KEY (KTQT_ID) REFERENCES KYTHICCQT
	ON DELETE CASCADE;

