USE QLNhaHang;
GO

-- Dữ liệu bảng NguoiDung
INSERT INTO NguoiDung VALUES
('ND000001', N'Nguoi Dung 1', 'user1@example.com', 'password1'),
('ND000002', N'Nguoi Dung 2', 'user2@example.com', 'password2'),
('ND000003', N'Nguoi Dung 3', 'user3@example.com', 'password3');

-- Dữ liệu bảng NhanVien
INSERT INTO NhanVien VALUES
('NV000001', N'Nhan Vien 1', '2023-01-01', '0912345678', N'Quan Ly', 'ND000001', NULL, 'Active'),
('NV000002', N'Nhan Vien 2', '2023-02-01', '0987654321', N'Phuc Vu', 'ND000002', 'NV000001', 'Active');

-- Dữ liệu bảng KhachHang
INSERT INTO KhachHang VALUES
('KH000001', N'Khach Hang 1', 100, 'ND000003'),
('KH000002', N'Khach Hang 2', 200, NULL);

-- Dữ liệu bảng Ban
INSERT INTO Ban VALUES
(N'Bàn 1', N'Tầng 1', N'Trống'),
(N'Bàn 2', N'Tầng 2', N'Có người'),
(N'Bàn 3', N'Tầng 2', N'Đặt trước');

--du lieu bang danh muc
INSERT INTO DanhMuc VALUES
(N'Nước'),
(N'Hải sản'),
(N'Tráng miệng'),
(N'Ăn sáng');
select * from	monan
-- Dữ liệu bảng MonAn
INSERT INTO MonAn VALUES
(1,N'Pessi', 10000),
(4,N'Pho Bo', 50000),
(4,N'Bun Cha', 40000);

-- Dữ liệu bảng Voucher
INSERT INTO Voucher VALUES
('VOUCHER01', N'Giam gia', 10, NULL, 3, 1000),
('VOUCHER02', N'Giam gia', 20, NULL, 3, 1000);

-- Dữ liệu bảng HoaDon
INSERT INTO HoaDon(ID_Ban,NgayLap,NgayCheckout,MaVoucher,TrangThai) VALUES
( 1, '2023-11-25', '2023-11-25', 'VOUCHER01', 'Paid'),
( 2, '2023-11-25',null, NULL, 'outsd');

-- Dữ liệu bảng CTHD
INSERT INTO CTHD (ID_HoaDon, ID_MonAn, SoLuong)
VALUES
(1, 4, 2), -- 2 phần "Phở Bò"
(2, 3, 1), -- 1 phần "Bún Chả"
(2, 2, 2); -- 2 phần "Pessi"
GO
