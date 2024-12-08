-- Tạo cơ sở dữ liệu
CREATE DATABASE QLNhaHang;
GO

-- Sử dụng cơ sở dữ liệu
USE QLNhaHang;
GO

-- Tạo bảng NguoiDung
CREATE TABLE NguoiDung (
    ID_NguoiDung CHAR(8) PRIMARY KEY,
    TenNguoiDung NVARCHAR(50),
    Email NVARCHAR(100),
    MatKhau NVARCHAR(50) default 'admin1',
	LoaiTaiKhoan NVARCHAR(50)
);


-- Tạo bảng Ban
CREATE TABLE Ban (
    ID_Ban INT PRIMARY KEY IDENTITY(1,1),
    TenBan NVARCHAR(30),
    ViTri NVARCHAR(30),
    TrangThai NVARCHAR(50)
);

-- tao bang danh muc mon an
create table DanhMuc(
	ID_DanhMuc Int primary key Identity(1,1),
	TenDanhMuc Nvarchar(50)
);

-- Tạo bảng MonAn
CREATE TABLE MonAn (
    ID_MonAn INT PRIMARY KEY IDENTITY(1,1),
	ID_DanhMuc int ,
    TenMon NVARCHAR(50),
    DonGia int,
	foreign key (ID_DanhMuc) References DanhMuc(ID_DanhMuc)
);

-- Tạo bảng Voucher
CREATE TABLE Voucher (
    Code_Voucher VARCHAR(10) PRIMARY KEY,
    LoaiVoucher NVARCHAR(50),
    GiamGia INT,
    NguoiDungID CHAR(8) NULL,
    HanSuDung INT,
    GiaTriToiThieu DECIMAL(10,2)
);

-- Tạo bảng HoaDon
CREATE TABLE HoaDon (
    ID_HoaDon INT PRIMARY KEY IDENTITY(1,1),
    ID_Ban INT,
    NgayLap DATE DEFAULT getdate(),
	NgayCheckout Date DEFAULT null,
    MaVoucher VARCHAR(10) Default 'default',
    TrangThai NVARCHAR(20) default 'outsd',
	ThanhTien float default 0,
    FOREIGN KEY (ID_Ban) REFERENCES Ban(ID_Ban),
    FOREIGN KEY (MaVoucher) REFERENCES Voucher(Code_Voucher)
);

-- Tạo bảng CTHD (Chi tiết hóa đơn)
CREATE TABLE CTHD (
    ID_CTHD INT PRIMARY KEY IDENTITY(1,1),
    ID_HoaDon INT,
    ID_MonAn INT,
    SoLuong INT,
    FOREIGN KEY (ID_HoaDon) REFERENCES HoaDon(ID_HoaDon),
    FOREIGN KEY (ID_MonAn) REFERENCES MonAn(ID_MonAn)
);
GO

