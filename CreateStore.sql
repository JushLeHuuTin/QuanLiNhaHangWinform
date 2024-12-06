USE QLNhaHang;
GO


-- Xóa các Stored Procedure cũ (nếu có)
IF OBJECT_ID('sp_DanhSachBan', 'P') IS NOT NULL DROP PROC sp_DanhSachBan;
IF OBJECT_ID('sp_ThemBan', 'P') IS NOT NULL DROP PROC sp_ThemBan;
IF OBJECT_ID('sp_SuaBan', 'P') IS NOT NULL DROP PROC sp_SuaBan;
IF OBJECT_ID('sp_SuaTrangThaiBan', 'P') IS NOT NULL DROP PROC sp_SuaTrangThaiBan;
IF OBJECT_ID('sp_XoaBan', 'P') IS NOT NULL DROP PROC sp_XoaBan;
IF OBJECT_ID('sp_TongSoBan', 'P') IS NOT NULL DROP PROC sp_TongSoBan;
IF OBJECT_ID('sp_DSMonAn', 'P') IS NOT NULL DROP PROC sp_DSMonAn;
IF OBJECT_ID('sp_ThemMonAn', 'P') IS NOT NULL DROP PROC sp_ThemMonAn;
IF OBJECT_ID('sp_XoaMon', 'P') IS NOT NULL DROP PROC sp_XoaMon;
IF OBJECT_ID('sp_SuaMon', 'P') IS NOT NULL DROP PROC sp_SuaMon;
IF OBJECT_ID('sp_HienThiChiTietHoaDonTuIdBan', 'P') IS NOT NULL DROP PROC sp_HienThiChiTietHoaDonTuIdBan;
IF OBJECT_ID('sp_TimKiemVoucher', 'P') IS NOT NULL DROP PROC sp_TimKiemVoucher;
GO

-- 1. Hiển thị danh sách bàn
CREATE PROC sp_DanhSachBan
AS
BEGIN
    SELECT * FROM Ban;
END;
GO

-- 2. Thêm bàn mới
CREATE PROC sp_ThemBan
    @TenBan NVARCHAR(30),
    @ViTri NVARCHAR(30),
    @TrangThai NVARCHAR(50)
AS
BEGIN
    INSERT INTO Ban (TenBan, ViTri, TrangThai)
    VALUES (@TenBan, @ViTri, @TrangThai);
END;
GO

-- 3. Sửa bàn
CREATE PROC sp_SuaBan
    @MaBan INT,
    @TenBan NVARCHAR(30),
    @ViTri NVARCHAR(30),
    @TrangThai NVARCHAR(50)
AS
BEGIN
    UPDATE Ban
    SET TenBan = @TenBan, ViTri = @ViTri, TrangThai = @TrangThai
    WHERE ID_Ban = @MaBan;
END;
GO

-- 4. Sửa trạng thái bàn
CREATE PROC sp_SuaTrangThaiBan
    @MaBan INT,
    @TrangThai NVARCHAR(50)
AS
BEGIN
    UPDATE Ban
    SET TrangThai = @TrangThai
    WHERE ID_Ban = @MaBan;
END;
GO

-- 5. Xóa bàn
CREATE PROC sp_XoaBan
    @MaBan INT
AS
BEGIN
    DELETE FROM Ban
    WHERE ID_Ban = @MaBan;
END;
GO

-- 7. Danh sách món ăn
CREATE PROC sp_DSMonAn
AS
BEGIN
    SELECT m.ID_MonAn, dm.TenDanhMuc,m.TenMon,m.DonGia FROM MonAn as m inner join DanhMuc as dm on m.ID_DanhMuc = dm.ID_DanhMuc;
END;
GO

--hien thi mon an theo danh muc
create proc sp_HienThiMonAnTuDanhMuc
@MaDanhMuc int
as 
 select ID_MonAn , CONCAT(TenMon , ' - ',DonGia) as name from MonAn where ID_DanhMuc = @MaDanhMuc
 go
-- 8. Thêm món ăn
CREATE PROC sp_ThemMonAn
	@DanhMuc int,
    @TenMon NVARCHAR(50),
    @DonGia DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO MonAn (ID_DanhMuc ,TenMon, DonGia)
    VALUES (@DanhMuc, @TenMon, @DonGia);
END;
GO

-- 9. Xóa món ăn
CREATE PROC sp_XoaMon
    @MaMon INT
AS
BEGIN
    DELETE FROM MonAn
    WHERE ID_MonAn = @MaMon;
END;
GO

-- 10. Sửa món ăn
CREATE PROC sp_SuaMon
    @MaMon INT,
  	@DanhMuc int,
    @TenMon NVARCHAR(50),
    @DonGia DECIMAL(10, 2)
AS
BEGIN
    UPDATE MonAn
    SET ID_DanhMuc = @DanhMuc,TenMon = @TenMon, DonGia = @DonGia
    WHERE ID_MonAn = @MaMon;
END;
GO

-- 11. Hiển thị chi tiết hóa đơn từ ID bàn
CREATE PROC sp_HienThiChiTietHoaDonTuIdBan
    @MaBan INT
AS
BEGIN
    SELECT 
        m.TenMon,
        cthd.SoLuong,
        m.DonGia,
        m.DonGia * cthd.SoLuong AS TongTien
    FROM MonAn AS m
    INNER JOIN CTHD AS cthd ON m.ID_MonAn = cthd.ID_MonAn
    INNER JOIN HoaDon AS hd ON hd.ID_HoaDon = cthd.ID_HoaDon
    WHERE hd.ID_Ban = @MaBan AND hd.TrangThai = 'outsd';
END;
GO
-- 12. Tìm kiếm voucher
CREATE PROC sp_TimKiemVoucher
    @Code VARCHAR(10)
AS
BEGIN
    SELECT * FROM Voucher WHERE Code_Voucher = @Code;
END;
GO

--tao hoa don
create proc sp_TaoHoaDon (@MaBan int)
as
insert into HoaDon values 
(@MaBan,GETDATE(),null,null,'outsd')

select * from hoadon
select * from Ban


--load danh muc
create proc sp_HienThiDanhMuc
as
select * from DanhMuc
delete hoadon where id_ban  = 1 AND TRANGTHAI =  'outsd'
-- 13 Them hoa don
--kiem tra hoa don
create proc sp_KiemTraHoaDon @MaBan int
as
select * from HoaDon where ID_Ban = @MaBan and TrangThai = 'outsd'
go
-- thanh toan hoa don
create proc sp_ThanhToan( @MaHD INT)
AS
update HoaDon set TrangThai = 'Paid',NgayCheckout = GETDATE() where ID_HoaDon = @MaHD
go
--tao chi tiet hoa don
create proc sp_ThemCTHD(@MaHD int,@MaMonAn int, @SoLuong int) 
as
	declare @number int = 0
	declare @isCTHD int = 0
	select @isCTHD = ID_CTHD, @number = SoLuong from CTHD where ID_MonAn = @MaMonAn and ID_HoaDon = @MaHD
	DECLARE @tong int = @number + @SoLuong 
	if(@isCTHD != 0)
		if(@tong > 0)
			update cthd set SoLuong =  @tong where ID_HoaDon = @MaHD and ID_MonAn = @MaMonAn
		else 
			delete from CTHD where ID_HoaDon = @MaHD and ID_MonAn = @MaMonAn
	else 
		if(@SoLuong > 0)
		insert into CTHD(ID_HoaDon,ID_MonAn,SoLuong) values(@MaHD,@MaMonAn,@SoLuong)

delete  from cthd


delete from ban
delete from hoadon
delete from cthd
