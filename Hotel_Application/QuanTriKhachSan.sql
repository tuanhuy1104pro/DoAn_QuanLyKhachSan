create database QLKS
use QLKS
go 
--Nhân Viên - Lương - Chức Vụ
create table ChucVu
(
	MaCV int identity(1,1) primary key,
	TenCV nvarchar(25) not null,
	PhuCap float default null
);
alter table ChucVu
add constraint Unique_TenCV unique(TenCV)
create table NhanVien
(
	MaNV int identity(1,1) not null,
	TenNV nvarchar(50) not null,
	SDT bigint not null,
	EmailNV varchar(120) not null,
	GioiTinh nvarchar(50) not null,
	TaiKhoan varchar(150) not null,
	MatKhau varchar(150) not null,
	NgaySinh datetime check (Year(GETDATE()) - Year(NgaySinh) >= 18) not null,
	--TuoiNV tinyint check(TuoiNV >= 18 and TuoiNV <= 60) not null,
	NgayVaoLam datetime not null,
	MaCV int foreign key references ChucVu,
	constraint PK_NhanVien primary key (MaNV)
)

alter table NhanVien
add constraint Unique_SDT unique(SDT)

create table Luong
(
	SoNgayNghi int null, 
	TienLuong float,
	MaNV int foreign key references NhanVien primary key
)
create table LoaiPhong
(
	MaLoaiPhong int identity(1,1) primary key,
	TenLoaiPhong nvarchar(50),
	Gia float
)
create table Phong
(
	MaPhong int identity(1,1) primary key,
	TenPhong varchar(50) unique,
	MaLoaiPhong int foreign key references LoaiPhong,
)
-- Tên phòng - 3 loại phòng : Phòng đơn : Tên phòng sẽ bắt đầu bằng chữ D - Phòng Đôi là C - Phòng Vip: V

--DỊch vụ
create table LoaiDichVu
(
	MaLoaiDichVu int identity(1,1) primary key,
	TenLoaiDichVu nvarchar(50)
)
go
create table DichVu
(
	MaDichVu int identity(1,1) primary key,
	TenDichVu nvarchar(50),
	GiaTien float,
	MaLoaiDichVu int constraint FK_Key_DichVu_MLDichVu_LoaiDichVu foreign key references LoaiDichVu
)
go
Create table GoiDichVu
(
	MaGoi int identity(1,1) primary key,
	TenGoi nvarchar (50),
	KhuyenMai float
)

create table ChiTietGoi
(
	MaGoi int constraint FK_CTGoi_MaGoi foreign key  references GoiDichVu,
	MaDichVu int constraint FK_CTGoi_MaDichVu foreign key  references DichVu,
	GhiChu nvarchar(50)
)
-- Làm một Method về tổng tiền. ĐƯợc tính bằng các dịch vụ có trong chi tiết gói
--Khách Hàng
Create table KhachHang
(
	MaKhachHang int identity(1,1) primary key,
	HoTen nvarchar(50), --
	DiaChi nvarchar(50),
	SoDienThoai varchar(30) unique,--
	Email varchar(50) not null,--
	TaiKhoan varchar(50) unique not null,
	MatKhau varchar(50) not null
)--Bắt buộc phải có Email, họ tên - địa chỉ
create table HoaDon
(
	MaHoaDon int identity(1,1),
	NgayThue datetime,--
	NgayTra datetime,--
	TongTien float null, --
	MaNV int foreign key references NhanVien, -- 
	MaKhachHang int foreign key references KhachHang,--
	MaPhong int foreign key references Phong,--
	constraint PK_HD primary key (MaHoaDon)
)
-- Ma phong chi duoc them khi Ngay thue ngay tra cua nhung hoa don khac da het han: vd ngay tra 22/11/2023 maphong 2 thi neu tao hoadon thi hoa don do phai co ngay thue > ngay tra cua nhung hoa don khac co ma la 2. gan nhat 1 tuan  
Create table ChiTietHoaDon
(
	MaHoaDon int,
	MaGoi int
	constraint FK_CTHD1 foreign key (MaHoaDon) References HoaDon,
	constraint FK_CTHD2 foreign key (MaGoi) References GoiDichVu,
	Tien float
)

go
DBCC CHECKIDENT('LoaiDichVu', RESEED,1)
INSERT INTO LoaiDichVu VALUES(N'Đồ Ăn'),
							(N'	Masage'),
							(N'Bạn cùng phòng'),
							(N'Tham quan')
SELECT * FROM LoaiDichVu

--
delete LoaiDichVu where TenLoaiDichVu = N'Tham quan'
DBCC CHECKIDENT('LoaiDichVu', RESEED,2)

INSERT INTO LoaiDichVu VALUES(N'Tham quan')
--

DBCC CHECKIDENT('DichVu', RESEED, 1)
INSERT INTO DichVu (TenDichVu,GiaTien,MaLoaiDichVu)  VALUES(N'Dọn dẹp',50,1),
						(N'Tổ chức tiệc và dọn dẹp',100,2),
						(N'Nấu ăn tổ chức tiệc và dọn dẹp',200,3)
SELECT * FROM DichVu
Delete from DichVu
--
DBCC CHECKIDENT('GoiDichVu', RESEED, 0)
INSERT INTO GoiDichVu values (N'Xuân',0.5),
							 (N'Hạ',0.3),
							 (N'Thu',0.4),
							 (N'Đông',0.6)
SELECT * FROM GoiDichVu

INSERT INTO ChiTietGoi  VALUES(1,1,N'Khuyến mãi mùa xuân'),
									(2,2,N'Khuyến mãi mùa hạ'),
									(3,3,N'Khuyến mãi mùa thu'),
									(4,1,N'Khuyến mãi mùa đông')
SELECT * FROM ChiTietGoi

DBCC CHECKIDENT('LoaiPhong', RESEED, 0)
INSERT INTO LoaiPhong VALUES (N'Đơn',100),
							(N'Đôi',200),
							(N'VIP',300)
SELECT * FROM LoaiPhong
delete from LoaiPhong
--
DBCC CHECKIDENT('Phong', RESEED, 0)
INSERT INTO Phong (TenPhong,MaLoaiPhong) VALUES('PH01',1),
														('PH02',2),
														('PH03',3)
SELECT * FROM Phong
DELETE from Phong
--
DBCC CHECKIDENT('KhachHang', RESEED, 0)
INSERT INTO KhachHang VALUES (N'Nguyễn Thị Linh','TP.HCM',0316243505,'Linh@gmail.com','Linh123','Linh123'),
							(N'Nguyễn Văn Toàn',N'Hà Nội',0316987505,'Toan@gmail.com','Toan123','Toan123'),
							(N'Nguyễn Thị Yến','TP.HCM',0917689205,'Yen@gmail.com','Yen123','Yen123')
SELECT * FROM KhachHang
delete from KhachHang
--
--Nhân viên
INSERT INTO ChucVu VALUES (N'Nhân viên',2.5),
						(N'Đầu bếp',3.0),
						(N'Lao công',2.0)
SELECT * FROM ChucVu

DBCC CHECKIDENT('NhanVien', RESEED, 0)
set dateformat dmy
INSERT INTO  NhanVien VALUES(N'Nguyễn Trần Tuấn Huy',0816243565,'Huy@gmail.com','Nam','Admin','sa',11/4/2003,10/10/2023,1),
					(N'Nguyễn Văn An',0816243567,'An@gmail.com','Nam','An123','An123',5/3/1999,10/10/2023,1),
					  (N'Nguyễn Thành Lợi',0819062568,'Loi@gmail.com','Nam','Loi123','Loi123',5/3/1999,10/10/2015,2),
					   (N'Lê Thị Bích',0866223569,'Bich@gmail.com',N'Nữ','Bich123','Bich123',5/3/1999,10/10/2000,3)

SELECT * FROM NhanVien



INSERT INTO Luong VALUES (5,10000000,1),
						(4,15000000,2),
						(null,5000000,3)
SELECT * FROM Luong

DBCC CHECKIDENT('HoaDon', RESEED, 0)
SET DATEFORMAT DMY
INSERT INTO HoaDon (NgayThue,NgayTra,TongTien,MaKhachHang,MaNV,MaPhong) VALUES ('19/11/2023','23/11/2023',450,1,1,2),
													('20/11/2023','24/11/2023',500,2,2,1),
													('21/11/2023','26/11/2023',600,3,3,2)
SELECT * FROM HoaDon
DELETE from HoaDon

INSERT INTO ChiTietHoaDon VALUES (1,2,100),
								(2,3,100),
								(1,4,200)
SELECT * FROM ChiTietHoaDon
DELETE ChiTietHoaDon

select * from HoaDon
inner join KhachHang on HoaDon.MaKhachHang = KhachHang.MaKhachHang

select * from HoaDon
where HoaDon.MaHoaDon = '4'

select*from HoaDon
where MaKhachHang in (
select MaKhachHang from KhachHang
where KhachHang.HoTen = N'Nguyễn Thị Yến'
) or  HoaDon.MaHoaDon ='1'

--Lê Đức Tú
-- Ràng buộc dữ liệu - Mặc định khuyến mãi là 0%.
ALTER TABLE GoiDichVu
ADD CONSTRAINT DF_DV DEFAULT '0' FOR KhuyenMai 
SELECT * FROM GoiDichVu

----Tạo thủ tục để kiểm tra mật khẩu đã được sử dụng rồi hay chưa khi thực hiện thêm mới khách hàng
GO
CREATE PROC KT_MKKH
@HoTen nvarchar(50),@DiaChi nvarchar(50),@SoDienThoai varchar(30),@Email varchar(50),@TaiKhoan varchar(50),@MatKhau varchar(50)
AS
BEGIN
	IF EXISTS (SELECT * FROM KhachHang WHERE MatKhau = @MatKhau)
		BEGIN
			PRINT N'Mật khẩu: ' + @MatKhau + N' Đã tồn tại'
			RETURN -1
		END
	INSERT INTO KhachHang VALUES(@HoTen,@DiaChi,@SoDienThoai,@Email,@TaiKhoan,@MatKhaU)
END
DROP PROC KT_MKKH
EXEC KT_MKKH N'Nguyễn Thị Linh','TP.HCM',0316243505,'Linh@gmail.com','Linh123','Linh123'
SELECT * FROM KhachHang

--Tạo thủ tục để kiểm tra tài khoản đã sử dụng rồi hay chưa khi thực hiện thêm mới khách hàng
GO
CREATE PROC KT_TKKH
@HoTen nvarchar(50),@DiaChi nvarchar(50),@SoDienThoai varchar(30),@Email varchar(50),@TaiKhoan varchar(50),@MatKhau varchar(50)
AS
BEGIN
	IF EXISTS (SELECT * FROM KhachHang WHERE TaiKhoan = @TaiKhoan)
		BEGIN
			PRINT N'Tài khoản: ' + @Taikhoan + N' Đã tồn tại'
			RETURN -1
		END
	INSERT INTO KhachHang VALUES(@HoTen,@DiaChi,@SoDienThoai,@Email,@TaiKhoan,@MatKhaU)
END	
EXEC KT_TKKH N'Nguyễn Trần Tuấn Huy','TP.HCM',0316243505,'Huy@gmail.com','Huy123','Huy123'
SELECT * FROM KhachHang	
					
--Tạo hàm tìm kiếm nhân viên
GO
CREATE FUNCTION TIMKIEM (@MaNV char(10))
RETURNS NVARCHAR(20)
AS
BEGIN
	DECLARE @TenNV nvarchar(50)
	SET @TenNV = (SELECT TenNV FROM NhanVien WHERE MaNV = @MaNV)
	RETURN @TenNV
END
GO
DECLARE @HOTEN NVARCHAR(20)
SET @HOTEN = dbo.TIMKIEM('NV001')
PRINT @HOTEN

--Hàm tính tongtien (HoaDon) = Tong Tat ca tien co ma hoa don (ChitietHoaDon) + Gia Tien (LoaiPhong)
SELECT * FROM HoaDon
SELECT * FROM LoaiPhong
SELECT * FROM Phong
GO
CREATE FUNCTION TINHTONGTIEN (@MAHD int)
RETURNS FLOAT
AS
	BEGIN
		DECLARE @Tien FLOAT
		SET @Tien = (SELECT GiaTien * KhuyenMai 
					FROM DichVu,GoiDichVu,ChiTietGoi,ChiTietHoaDon 
					WHERE ChiTietHoaDon.MaGoi = GoiDichVu.MaGoi AND DichVu.MaDichVu = ChiTietGoi.MaDichVu AND ChiTietGoi.MaGoi = ChiTietHoaDon.MaGoi AND @MAHD = MaHoaDon)
		DECLARE @TONGTIEN FLOAT
		SET @TONGTIEN = @TIEN + (SELECT Gia FROM Phong,LoaiPhong,HoaDon WHERE Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong AND HoaDon.MaPhong = Phong.MaPhong AND @MAHD = MaHoaDon)
		RETURN @TONGTIEN
	END
GO
DROP FUNCTION TINHTONGTIEN
DECLARE @TongTien FLOAT
SET @TongTien = dbo.TINHTONGTIEN(2)
PRINT @TongTien

--Tạo trigger kiểm tra ngày thuê phải bé hơn ngày trả
GO
CREATE TRIGGER KT_NGAY
ON HoaDon
FOR INSERT,UPDATE
AS
	IF (SELECT NgayThue from inserted) > (SELECT NgayTra from inserted)
		ROLLBACK TRAN

DROP TRIGGER KT_NGAY
INSERT INTO HoaDon (NgayThue,NgayTra,TongTien,MaKhachHang) VALUES ('24/11/2023','23/11/2023',450,1)
SELECT * FROM HoaDon


--Tạo trigger xóa nhân viên có số tuổi vượt quá quy định
GO
CREATE TRIGGER XOA_NV ON NhanVien
FOR DELETE
AS
IF(SELECT TuoiNV FROM DELETED) > 60
	ROLLBACK TRAN
DELETE FROM NhanVien WHERE MaNV = 'NV005'
SELECT * FROM NhanVien



													
--Nguyễn Trần Tuấn Huy
-- Tên Dịch vụ và gói dịch dụ là duy nhất
ALTER TABLE DichVu
ADD UNIQUE (TenDichVu)

ALTER TABLE GoiDichVu
ADD UNIQUE (TenGoi)


--Tạo thủ tục để kiểm tra mật khẩu đã được sử dụng rồi hay chưa khi thực hiện thêm mới nhân viên
GO
CREATE PROC KT_MK
@TenNV nvarchar(50),@SDT bigint,@EmailNV varchar(120),@GioiTinh nvarchar(50),@TaiKhoan varchar(150),@MatKhau varchar(150),@TuoiNV tinyint,@NgayVaoLam datetime,@MaCV char(10)
AS
BEGIN
	IF EXISTS (SELECT * FROM NhanVien WHERE MatKhau = @MatKhau)
		BEGIN
			PRINT N'Mật khẩu: ' + @MatKhau + N' Đã tồn tại'
			RETURN -1
		END
	INSERT INTO NhanVien VALUES(@TenNV ,@SDT,@EmailNV,@GioiTinH,@TaiKhoan,@MatKhaU,@TuoiNV,@NgayVaoLam,@MaCV)
END
DROP PROC KT_MK
SELECT * FROM NhanVien
EXEC KT_MK N'Nguyễn Văn An',0816243565,'An@gmail.com','Nam','An123','An123',19,'10/10/2023',1


--Tạo thủ tục để kiểm tra tài khoản đã được sử dụng rồi hay chưa khi thực hiện thêm mới nhân viên
GO
CREATE PROC KT_TK
 @TenNV nvarchar(50),@SDT bigint,@EmailNV varchar(120),@GioiTinh nvarchar(50),@TaiKhoan varchar(150),@MatKhau varchar(150),@TuoiNV tinyint,@NgayVaoLam datetime,@MaCV char(10)
AS
BEGIN
	IF EXISTS (SELECT * FROM NhanVien WHERE TaiKhoan = @TaiKhoan)
		BEGIN
			PRINT N'Tài khoản ' + @TaiKhoan + N' Đã tồn tại'
			RETURN -1
		END
	INSERT INTO NhanVien VALUES(@TenNV ,@SDT,@EmailNV,@GioiTinH,@TaiKhoan,@MatKhaU,@TuoiNV,@NgayVaoLam,@MaCV)
END
DROP PROC KT_TK
SELECT * FROM NhanVien
EXEC KT_TK N'Nguyễn Văn An',0816243565,'An@gmail.com','Nam','An123','An123',19,'10/10/2023',1


--Tạo hàm tìm kiếm khách hàng
GO
CREATE FUNCTION TIMKIEMKH (@MaKH char(10))
RETURNS NVARCHAR(20)
AS
BEGIN
	DECLARE @TenKH nvarchar(50)
	SET @TenKH = (SELECT HoTen FROM KhachHang WHERE MaKhachHang = @MaKH)
	RETURN @TenKH
END
GO
DECLARE @HOTEN NVARCHAR(20)
SET @HOTEN = dbo.TIMKIEMKH(1)
PRINT @HOTEN

--Tạo hàm tình tien ChiTietHoaDon
SELECT * FROM ChiTietHoaDon
GO
CREATE FUNCTION TINHTIEN (@MAHD int)
RETURNS FLOAT
AS
	BEGIN
		DECLARE @Tien FLOAT
		SET @Tien = (SELECT GiaTien * KhuyenMai 
					FROM DichVu,GoiDichVu,ChiTietGoi,ChiTietHoaDon 
					WHERE ChiTietHoaDon.MaGoi = GoiDichVu.MaGoi AND DichVu.MaDichVu = ChiTietGoi.MaDichVu AND ChiTietGoi.MaGoi = ChiTietHoaDon.MaGoi AND @MAHD = MaHoaDon)
		RETURN @Tien
	END
GO
DROP FUNCTION TINHTIEN
DECLARE @Tien FLOAT
SET @Tien = dbo.TINHTIEN(2)
PRINT @Tien

--Tạo trigger giá không được để số âm
GO
CREATE TRIGGER KT_GIA
ON LoaiPhong
FOR INSERT,UPDATE
AS
	IF (SELECT Gia from inserted) < 0
		ROLLBACK TRAN
INSERT INTO LoaiPhong VALUES (N'Đơn',-200)


-- Tạo trigger số ngày nghỉ không được quá 10 ngày
GO
CREATE TRIGGER KT_NgayNghi
ON Luong
FOR INSERT,UPDATE
AS
	IF (SELECT SoNgayNghi from inserted) > 10
		ROLLBACK TRAN

INSERT INTO Luong VALUES (12,10000000,'NV001')
												