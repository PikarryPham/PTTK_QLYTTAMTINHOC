USE QLTINHOC_PTTK
GO
--Bảng HOCPHAN
DELETE FROM HOCPHAN;
INSERT INTO HOCPHAN
	VALUES (1, 'B-ORA', '2021-01-24', N'Học phần bắt buộc', 1, 2, 4, N'ORACLE cơ bản', '2021-04-01'),
	(2, 'B-ORA', '2021-06-01', N'Học phần bắt buộc', 0, 0, 4, N'ORACLE cơ bản', '2021-08-14'),
	(3, 'A-ORA', '2021-05-01', N'Học phần chuyên sâu', 1, 2, 4, N'ORACLE chuyên sâu', '2021-07-14'),
	(4, 'B-MSSQL', '2021-02-12', N'Học phần bắt buộc', 1, 1, 4, N'Microsoft SQL server cơ bản', '2021-04-30'),
	(5, 'A-MSSQL', '2021-05-24', N'Học phần chuyên sâu', 0, 0, 4, N'Microsoft SQL server chuyên sâu', '2021-07-01'),
	(6, 'B-CSDL', '2020-12-24', N'Học phần bắt buộc', 1, 2, 4, N'Cơ sở dữ liệu', '2021-02-01'),
	(7, 'A-CSDL', '2021-06-01', N'Học phần chuyên sâu', 0, 2, 4, N'Cơ sở dữ liệu nâng cao', '2021-08-14')
--Bảng HOCPHANBATBUOC
DELETE FROM HOCPHANBATBUOC;
INSERT INTO HOCPHANBATBUOC
	VALUES ('B-ORA', 'A-ORA'),
	('B-MSSQL','A-MSSQL'),
	('B-CSDL','B-MSSQL'),
	('B-CSDL','B-ORA'),
	('B-CSDL','A-CSDL'),
	('B-MSSQL','A-CSDL')
--BẢNG THOIKHOABIEU
DELETE FROM THOIKHOABIEU
INSERT INTO THOIKHOABIEU
	VALUES (1, 'I01', '7:30:00', '11:00:00', N'Thứ hai', 1),
	(2, 'I01', '7:30:00', '11:00:00', N'Thứ tư', 1),
	(3, 'I02', '7:30:00', '11:00:00', N'Thứ hai', 2),
	(4, 'I03', '7:30:00', '11:00:00', N'Thứ ba', 2),
	(5, 'I01', '13:30:00', '17:00:00', N'Thứ hai', 3),
	(6, 'I04', '7:30:00', '11:00:00', N'Thứ hai', 3),
	(7, 'I02', '7:30:00', '11:00:00', N'Thứ năm', 4),
	(8, 'I03', '7:30:00', '11:00:00', N'Thứ sáu', 4),
	(9, 'I05', '15:30:00', '17:00:00', N'Thứ bảy', 5),
	(10, 'I04', '13:30:00', '17:00:00', N'Thứ hai', 5),
	(11, 'I01', '7:30:00', '11:00:00', N'Chủ nhật', 6),
	(12, 'I01', '7:30:00', '11:00:00', N'Thứ bảy', 7)
-- Bảng NGƯỜI ĐĂNG KÝ THI
DELETE FROM dbo.NGUOIDANGKYTHI
INSERT INTO dbo.NGUOIDANGKYTHI(NDKT_ID, NDKT_CMND, NDKT_TEN, NDKT_DCHI, NDKT_EMAIL, NDKT_GTINH, NDKT_LOAI, NDKT_SDT)
VALUES(1,'321743123',N'Nguyễn Thị Lệ Thu',N'25/3 Lạc Long Quân, Q.10, TPHCM','ntlthu@gmail.com',N'Nữ',N'Giảng viên','0903123321'),
	  (2,'321742654',N'Nguyễn Hoài An',N'222 Lý Tự Trọng, Q.1, TPHCM','nhan@gmail.com',N'Nam',N'Giảng viên','0903123123'), 
	  (3,'215195342',N'Trần Bạch Tuyết',N'22/5 Nguyễn Xí, Q.Bình Thạnh, TPHCM','tbtuyet@gmail.com',N'Nữ',N'Giảng viên','0937888888'),
	  (4,'251167421',N'Trần Trà Hương',N'221 Hùng Vương, Q.5, TPHCM','tthuong@gmail.com',N'Nữ',N'Giảng viên','0903656565'),
	  (5,'391365498',N'Phạm Nam Thanh',N'215 Lý Thường Kiệt,Q.11, TPHCM','pnthanh@gmail.com',N'Nam',N'Giảng viên','0323232323'),
	  (6,'312501499',N'Lý Hoàng Hà',N'125 Trần Hưng Đạo, Q.1, TPHCM','lhha@gmail.com',N'Nam',N'Học Viên','0388912112'),
	  (7,'215145652',N'Trần Trung Hiếu',N'22 Lý Thường Kiệt, Q.5, TPHCM','tthieu@gmail.com',N'Nam',N'Học Viên','0931256943'),
	  (8,'321170123',N'Ngô Uyển Ân',N'221 Lê Trọng Tấn, Q.Tân Phú, TPHCM','nuan@gmail.com',N'Nữ',N'Học Viên','0931256931'),
	  (9,'321831953',N'Huỳnh Trí Lâm',N'321 Nguyễn Đình Chiểu, Quận 3, TPHCM','htlam@gmail.com',N'Nam',N'Học Viên','0963416541'),
	  (10,'321314531',N'Trần Văn Minh',N'4 Nguyễn Bỉnh Khiêm, Quận 1, TPHCM','tvminh@gmail.com',N'Nam',N'Học Viên','0911213574'),
	  (11,'321731641',N'Hoàng Ly Ly',N'122 Đường số 37, Phường Tân Quy, Quận 7, TPHCM','hlly@gmail.com',N'Nữ',N'Học Viên','0934125612'),
	  (12,'321415411',N'Trịnh Văn Lâm',N'94 Trần Hưng Đạo, Q.1, TPHCM','tvlam@gmail.com',N'Nam',N'Học Viên','0916141124'),
	  (13,'312461512',N'Nguyễn Văn Phú',N'14 Trần Bình Trọng, Q.5, TPHCM','nvphu@gmail.com',N'Nam',N'Học Viên','0913412561'),
	  (14,'321517990',N'Nguyễn Lam Linh',N'41 Quách Vũ, Quận Tân Phú, TPHCM','nllinh@gmail.com',N'Nữ',N'Người đăng ký thi','0941455123'),
	  (15,'321742631',N'Hồ Nguyễn Trúc Huỳnh',N'69 Bùi Văn Ba, Q.7, TPHCM','hnthuynh@gmail.com',N'Nữ',N'Người đăng ký thi','0386755424')
-- Bảng GIẢNG VIÊN
DELETE FROM dbo.GIANGVIEN
INSERT INTO dbo.GIANGVIEN(GV_IDNDKT, GV_CHUCVU, GV_KHOA)
VALUES (1,N'Thạc sĩ',N'Công nghệ phần mềm'),
	   (2,N'Thạc sĩ',N'Công nghệ phần mềm'),
	   (3,N'Tiến sĩ',N'Hệ thống thông tin'),
	   (4,N'Tiến sĩ',N'Khoa học máy tính'),
	   (5,N'Thạc sĩ',N'Khoa học máy tính')
-- Bảng PHÂN CÔNG GIẢNG DẠY (cần để khóa ngoại ID_HP phù hợp)
DELETE FROM dbo.PHANCONGGIANGDAY
INSERT INTO dbo.PHANCONGGIANGDAY(PCGD_IDGV, PCGD_IDHP)
VALUES (1,1),	
	   (1,2),
	   (2,3),
	   (3,4),
	   (4,5),
	   (4,6),
	   (5,7)	    
-- Bảng THẺ THANH TOÁN
DELETE FROM dbo.THETHANHTOAN
INSERT INTO dbo.THETHANHTOAN(THE_ID, THE_CHINHANH, THE_NGANHANG, THE_STK, THE_TENCT, HOCVIEN_ID)
VALUES (1,N'Bình Thạnh',N'Agribank','6380205572041', N'LY HOANG HA',6),
	   (2,N'Gò Vấp',N'Techcombank','19623659634585', N'TRAN TRUNG HIEU',7),
	   (3,N'Phú Nhuận',N'MB Bank','600104346666', N'NGO UYEN AN',8),
	   (4,N'Bình Thạnh',N'Agribank','6380205572345', N'HUYNH TRI LAM',9),
	   (5,N'Quận 5',N'Vietcombank','8888123456', N'TRINH VAN LAM',12),
	   (6,N'Bình Thạnh',N'Agribank','6380205572999', N'NGUYEN VAN PHU',13)	    
--Bảng HOADONHOCPHAN
DELETE FROM dbo.HOADONHOCPHAN
INSERT INTO dbo.HOADONHOCPHAN
VALUES
(1,'Tiền mặt',0,'2021-03-25',3600000),
(2,'Chuyển khoản',0,'2021-03-25',3600000),
(3,'Tiền mặt',1,'2021-07-10',3600000),
(4,'Chuyển khoản',0,'2021-07-10',3600000),
(5,'Tiền mặt',1,'2021-04-25',3600000),
(6,'Tiền mặt',1,'2021-01-28',3600000),
(7,'Tiền mặt',0,'2021-01-28',3600000),
(8,'Chuyển khoản',0,'2021-08-14',3600000),
(9,'Chuyển khoản',0,'2021-08-14',3600000)
--Bảng DANGKYHOCPHAN
DELETE dbo.DANGKYHOCPHAN
INSERT INTO dbo.DANGKYHOCPHAN
VALUES
(1,8.5,'2021-01-05',1,1,1),
(2,4.5,'2021-01-05',2,1,2),
(3,null,'2021-04-20',3,3,3),
(4,null,'2021-04-20',4,3,4),
(5,5.5,'2021-02-05',5,4,5),
(6,7.5,'2020-12-15',6,6,6),
(7,4.5,'2020-12-15',3,6,7),
(8,null,'2021-05-25',1,7,8),
(9,null,'2021-05-25',2,7,9)

INSERT INTO dbo.DANGKYHOCPHAN
VALUES (10,4.8,'2021-06-07',1,3,1);

SELECT * FROM DANGKYHOCPHAN;
--Bảng LICHTHILAI

DELETE FROM dbo.LICHTHILAI
INSERT INTO dbo.LICHTHILAI
VALUES
(1,'2021-04-15','I42','7:30:00',2,1),
(2,'2021-02-15','I42','7:30:00',2,1)
--BẢNG CHUNGCHIHOCPHAN
DELETE FROM CHUNGCHIHOCPHAN;
INSERT INTO CHUNGCHIHOCPHAN
	VALUES (1, '2021-04-15', N'Chứng nhận đạt học phần: ORACLE cơ bản', 1),
	(2, '2021-05-07', N'Chứng nhận đạt học phần: Microsoft SQL server cơ bản', 5),
	(3, '2021-02-15', N'Chứng nhận đạt học phần: Cơ sở dữ liệu', 6)
-- Bảng CCQT
DELETE FROM dbo.CCQT;
INSERT INTO dbo.CCQT
VALUES(1,10000,200000,N'Chứng chỉ IELTS'),
(2,20000,400000,N'Chứng chỉ IREB (CPRE)'),
(3,5000,670000,N'Chứng chỉ ECBA'),
(4,10000,560000,N'Chứng chỉ MCITP'),
(5,15000,150000,N'Chứng chỉ Security+'),
(6,30000,300000,N'Chứng chỉ MCSE')
-- Bảng kỳ thi CCQT
DELETE FROM dbo.KYTHICCQT
INSERT INTO dbo.KYTHICCQT
VALUES(1, N'227 Nguyễn Văn Cừ, Q.5, TPHCM','15:00:00',3,1),
(2, N'138 Nam Kỳ Khởi Nghĩa, Q.1, TPHCM','14:00:00',2,2),
(3, N'436 Nguyễn Thị Thập, Q.7, TP. HCM','10:00:00',1,3),
(4, N'74/7C Hai Bà Trưng, Q.1, TPHCM','09:00:00',1,4),
(5, N'16 Lê Quý Đôn, Q.3, TPHCM','08:30:00',1.5,5),
(6, N'18 Bà Huyện Thanh Quan, Q.3, TPHCM','14:15:00',2.5,5),
(7, N'267 Lý Tự Trọng, Q.1, TPHCM','15:30:00',3.5,6),
(8, N'125 Cộng Hoà, Q.TB, TP.HCM','13:30:00',1,6)
--- Ngày thi kỳ thi CCQT
DELETE FROM dbo.NGAYTHIKYTHICCQT
INSERT INTO dbo.NGAYTHIKYTHICCQT VALUES
(1,'2021-09-05'),
(1,'2021-10-21'),
(2,'2021-11-20'),
(3,'2021-12-12'),
(3,'2021-08-10'),
(5,'2021-07-26'),
(5,'2021-01-19'),
(5,'2021-12-26')
--Bảng HOADONCCQT
DELETE FROM dbo.HOADONCCQT
INSERT INTO dbo.HOADONCCQT
VALUES 
(1,'Tiền mặt',210000,'2021-09-05'),
(2,'Tiền mặt',210000,'2021-09-05'),
(3,'Chuyển khoản',675000,'2021-09-30'),
(4,'Chuyển khoản',675000,'2021-09-29'),
(5,'Tiền mặt',735000,'2021-09-29'),
(6,'Tiền mặt',420000,'2021-11-10'),
(7,'Chuyển khoản',420000,'2021-11-11')
--Bảng DANGKYTHI
DELETE FROM dbo.DANGKYTHI
INSERT INTO dbo.DANGKYTHI(DKT_ID, DKT_IDNDKT, DKT_IDKTQT, DKT_IDHDCC, DKT_NGAYDK, DKT_TTIEN)
VALUES (1,1,1,1,'2021-09-05',210000),
	   (2,5,1,2,'2021-09-05',210000),	
	   (3,7,3,3,'2021-09-28',675000),	
	   (4,8,3,4,'2021-09-29',675000), 
	   (5,3,4,5,'2021-09-24',570000), 
	   (6,3,5,5,'2021-09-24',165000),  
	   (7,10,2,6,'2021-11-10',420000),  
	   (8,12,2,7,'2021-11-11',420000)
--- Bảng thông tin tk nhân viên
DELETE FROM dbo.THONGTINTKNHANVIEN;
INSERT INTO dbo.THONGTINTKNHANVIEN 
VALUES('QL001','QL001',1),
('QL002','QL002',1),
('QL003','QL003',1),
('NVTN001','NVTN001',2),
('NVTN002','NVTN002',2),
('NVTN003','NVTN003',2),
('NVKT001','NVKT001',3),
('NVKT002','NVKT002',3),
('BPVP001','BPVP001',4),
('BPVP002','BPVP002',4) 