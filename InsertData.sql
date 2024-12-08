USE QLNhaHang;
GO

-- Dữ liệu bảng NguoiDung
INSERT INTO NguoiDung VALUES
('ND000008', N'Lê Hữu Tín', 'tin@gmail.com', 'lehuutin','Admin'),
('ND000006', N'Nguoi Dung 2', 'admin@gmail.com', 'admin1','Nhân viên'),
('ND000004', N'Nguoi Dung 4', 'user1@example.com', 'password1','Admin'),
('ND000002', N'Nguoi Dung 2', 'user2@example.com', 'password2','Khách hàng'),
('ND000003', N'Nguoi Dung 3', 'user3@example.com', 'password3','Khách hàng');


-- Dữ liệu bảng Ban
INSERT INTO Ban VALUES
(N'Bàn 1', N'Tầng 1', N'Trống'),
(N'Bàn 2', N'Tầng 2', N'Có người'),
(N'Bàn 3', N'Tầng 2', N'Đặt trước'),
(N'Bàn 4', N'Tầng 1', N'Trống'),
(N'Bàn 5', N'Tầng 1', N'Trống'),
(N'Bàn 6', N'Tầng 1', N'Trống'),
(N'Bàn 7', N'Tầng 1', N'Trống'),
(N'Bàn 8', N'Tầng 1', N'Trống'),
(N'Bàn 9', N'Tầng 1', N'Trống'),
(N'Bàn 10', N'Tầng 2', N'Trống'),
(N'Bàn 11', N'Tầng 2', N'Trống'),
(N'Bàn 12', N'Tầng 2', N'Trống'),
(N'Bàn 13', N'Tầng 2', N'Trống'),
(N'Bàn 14', N'Tầng 3', N'Trống'),
(N'Bàn 15', N'Tầng 3', N'Trống'),
(N'Bàn 16', N'Tầng 3', N'Trống'),
(N'Bàn 17', N'Tầng 3', N'Trống'),
(N'Bàn 18', N'Tầng 3', N'Trống'),
(N'Bàn 19', N'Tầng 4', N'Trống'),
(N'Bàn 20', N'Tầng 4', N'Trống'),
(N'Bàn 21', N'Tầng 4', N'Trống'),
(N'Bàn 22', N'Tầng 4', N'Trống'),
(N'Bàn 23', N'Tầng 5', N'Trống');


--du lieu bang danh muc
INSERT INTO DanhMuc VALUES
(N'Nước'),
(N'Hải sản'),
(N'Tráng miệng'),
(N'Ăn sáng');

-- Thêm món ăn cho danh mục "Nước"
INSERT INTO MonAn (ID_DanhMuc, TenMon, DonGia) 
VALUES 
(1, N'Nước cam', 10000),
(1, N'Nước dừa', 15000),
(1, N'Nước lọc', 5000),
(1, N'Nước ép táo', 20000),
(1, N'Nước chanh', 12000);

-- Thêm món ăn cho danh mục "Hải sản"
INSERT INTO MonAn (ID_DanhMuc, TenMon, DonGia) 
VALUES 
(2, N'Tôm hùm', 500000),
(2, N'Cua biển', 300000),
(2, N'Sò điệp', 200000),
(2, N'Hàu nướng', 150000),
(2, N'Chả cá', 100000);

-- Thêm món ăn cho danh mục "Tráng miệng"
INSERT INTO MonAn (ID_DanhMuc, TenMon, DonGia) 
VALUES 
(3, N'Bánh flan', 20000),
(3, N'Tiramisu', 25000),
(3, N'Kem sữa', 15000),
(3, N'Panna cotta', 22000),
(3, N'Mousse sô cô la', 18000);

-- Thêm món ăn cho danh mục "Ăn sáng"
INSERT INTO MonAn (ID_DanhMuc, TenMon, DonGia) 
VALUES 
(4, N'Phở', 30000),
(4, N'Bánh mì', 15000),
(4, N'Xôi', 20000),
(4, N'Bánh cuốn', 25000),
(4, N'Cháo', 18000);



-- Dữ liệu bảng Voucher
INSERT INTO Voucher VALUES
('VOUCHER01', N'Giam gia', 0, NULL, 3, 1000),
('default', N'Giam gia', 10, NULL, 3, 1000),
('VOUCHER02', N'Giam gia', 20, NULL, 3, 1000);

-- Dữ liệu bảng HoaDon
INSERT INTO HoaDon(ID_Ban,NgayLap,NgayCheckout,MaVoucher,TrangThai,ThanhTien) VALUES
( 1, '2023-11-25', '2023-11-25', 'VOUCHER01', 'Paid',0),
( 2, '2023-11-25',null, 'default', 'outsd',0);

-- Dữ liệu bảng CTHD
INSERT INTO CTHD (ID_HoaDon, ID_MonAn, SoLuong)
VALUES
(1, 1, 2), -- 2 phần "Phở Bò"
(2, 3, 1), -- 1 phần "Bún Chả"
(2, 2, 2); -- 2 phần "Pessi"
GO


select * from monan