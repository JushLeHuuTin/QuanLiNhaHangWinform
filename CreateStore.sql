USE QLNhaHang;
GO




-- 1. Xóa tất cả các stored procedure
DROP PROCEDURE IF EXISTS sp_DanhSachBan;
DROP PROCEDURE IF EXISTS sp_ThemBan;
DROP PROCEDURE IF EXISTS sp_SuaBan;
DROP PROCEDURE IF EXISTS sp_SuaTrangThaiBan;
DROP PROCEDURE IF EXISTS sp_XoaBan;
DROP PROCEDURE IF EXISTS sp_DSMonAn;
DROP PROCEDURE IF EXISTS sp_HienThiMonAnTuDanhMuc;
DROP PROCEDURE IF EXISTS sp_ThemMonAn;
DROP PROCEDURE IF EXISTS sp_XoaMon;
DROP PROCEDURE IF EXISTS sp_SuaMon;
DROP PROCEDURE IF EXISTS sp_HienThiChiTietHoaDonTuIdBan;
DROP PROCEDURE IF EXISTS sp_TimKiemVoucher;
DROP PROCEDURE IF EXISTS sp_TaoHoaDon;
DROP PROCEDURE IF EXISTS sp_HienThiDanhMuc;
DROP PROCEDURE IF EXISTS sp_KiemTraHoaDon;
DROP PROCEDURE IF EXISTS sp_ThanhToan;
DROP PROCEDURE IF EXISTS sp_HuyHoaDon;
DROP PROCEDURE IF EXISTS sp_ThemCTHD;
DROP PROCEDURE IF EXISTS sp_ChuyenBan;
DROP PROCEDURE IF EXISTS sp_InHoaDon;
DROP PROCEDURE IF EXISTS sp_ThongKeHoaDon;

GO

-- 1. Hiển thị danh sách bàn
create PROC sp_DanhSachBan
AS
BEGIN
    SELECT ID_Ban as 'Mã Bàn', TenBan as 'Tên bàn', ViTri as 'Vị trí',TrangThai as 'Trạng thái'  FROM Ban;
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
    SELECT m.ID_MonAn as 'Mã món', dm.TenDanhMuc as 'Danh mục',m.TenMon as 'Tên món',m.DonGia as 'Đơn giá' FROM MonAn as m inner join DanhMuc as dm on m.ID_DanhMuc = dm.ID_DanhMuc;
END;
GO

CREATE PROC sp_TimKiemMonAn
@name nvarchar(50)
AS
BEGIN
 declare @key nvarchar(50) = '%' + @name + '%'
    SELECT m.ID_MonAn as 'Mã món', dm.TenDanhMuc as 'Danh mục',m.TenMon as 'Tên món',m.DonGia as 'Đơn giá' FROM MonAn as m inner join DanhMuc as dm on m.ID_DanhMuc = dm.ID_DanhMuc
	where m.TenMon like @key
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
create PROC sp_HienThiChiTietHoaDonTuIdBan
    @MaBan INT
AS
BEGIN
    SELECT 
        m.TenMon,
		dm.TenDanhMuc ,
        cthd.SoLuong,
        m.DonGia,
        m.DonGia * cthd.SoLuong AS TongTien
    FROM MonAn AS m
    INNER JOIN CTHD AS cthd ON m.ID_MonAn = cthd.ID_MonAn
    INNER JOIN HoaDon AS hd ON hd.ID_HoaDon = cthd.ID_HoaDon
	INNER JOIN DanhMuc as dm ON dm.ID_DanhMuc = m.ID_DanhMuc
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
(@MaBan,GETDATE(),null,'default','outsd',0)

go

--load danh muc
create proc sp_HienThiDanhMuc
as
select * from DanhMuc
delete hoadon where id_ban  = 1 AND TRANGTHAI =  'outsd'
go
-- 13 Them hoa don
--kiem tra hoa don
create proc sp_KiemTraHoaDon @MaBan int
as
select * from HoaDon where ID_Ban = @MaBan and TrangThai = 'outsd'
go
-- thanh toan hoa don
create proc sp_ThanhToan( @MaHD INT,@ThanhTien float,@voucher varchar(10))
AS
if(@voucher ='null')
update HoaDon set TrangThai = 'Paid',NgayCheckout = GETDATE(), ThanhTien = @ThanhTien where ID_HoaDon = @MaHD
else
update HoaDon set TrangThai = 'Paid',NgayCheckout = GETDATE(),MaVoucher = @Voucher, ThanhTien = @ThanhTien where ID_HoaDon = @MaHD

go



create proc sp_HuyHoaDon( @MaHD INT)
AS
delete from HoaDon where ID_HoaDon = @MaHD
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


go
--chuyen ban
create proc sp_ChuyenBan(@MaBanMot int, @MaBanHai int)
as
	declare @idHD1 int
	declare @idHD2 int

	select @idHD1 = ID_HoaDon from HoaDon where ID_Ban = @MaBanMot and TrangThai = 'outsd'
	select @idHD2 = ID_HoaDon from HoaDon where ID_Ban = @MaBanHai and TrangThai = 'outsd'
	 
	if(@idHD1 is null)
		insert into HoaDon(ID_Ban) values (@MaBanMot)
		select @idHD1 = ID_HoaDon from HoaDon where ID_Ban = @MaBanMot and TrangThai = 'outsd'
	if(@idHD2 is null)
		insert into HoaDon(ID_Ban) values (@MaBanHai)
		select @idHD2 = ID_HoaDon from HoaDon where ID_Ban = @MaBanHai and TrangThai = 'outsd'

	select ID_CTHD into BanChuyen from CTHD where ID_HoaDon = @idHD1

	update CTHD set ID_HoaDon = @idHD1 where ID_HoaDon = @idHD2

	declare @TrangThaiBan nvarchar(50)
	Select @TrangThaiBan =  TrangThai from Ban where ID_Ban = @MaBanMot

	update Ban set TrangThai =  (sELECT TrangThai from Ban where ID_Ban = @MaBanHai) where ID_Ban = @MaBanMot
	update CTHD set ID_HoaDon = @idHD2 where ID_CTHD IN (Select * from BanChuyen)
	update Ban set TrangThai =  @TrangThaiBan where ID_Ban = @MaBanHai
	
	DROP TABLE BanChuyen

	go 
create proc sp_InHoaDon 
@idBan int
as
declare @idHoaDon int = 0
select TOP 1 @idHoaDon = ID_HoaDon from HoaDon where ID_Ban = @idBan and TrangThai = 'Paid' order by (ID_HoaDon) DESC
select *, cthd.SoLuong * m.DonGia as tongtien, hd.ThanhTien as thanhtien from CTHD as cthd 
INNER JOIN MonAn as m on cthd.ID_MonAn = m.ID_MonAn Inner JOIN HoaDon as hd  ON HD.ID_HoaDon = cthd.ID_HoaDon 
Inner JOIN Voucher as vc on vc.Code_Voucher = hd.MaVoucher
INNER JOIN Ban as b on b.ID_Ban = hd.ID_Ban where hd.ID_HoaDon = @idHoaDon 

go 
create proc sp_ThongKeHoaDon
@DateStart Date, @DateEnd Date
as
select b.TenBan as 'Tên bàn',hd.ThanhTien as 'Thành tiền',hd.NgayLap as 'Ngày vào',hd.NgayCheckout as 'Ngày ra',v.GiamGia as 'Giảm giá' from HoaDon as hd Inner JOIN Ban as b on hd.ID_Ban = b.ID_Ban 
	Inner JOIN Voucher as v on hd.MaVoucher = v.Code_Voucher
	where hd.TrangThai = 'paid' and hd.NgayLap >= @DateStart and hd.NgayCheckout <= @DateEnd

	go
	---phan quyền theo loai tai khoản
CREATE PROC sp_upLoaiTaiKhoan
    @Email NVARCHAR(100),
    @LoaiTaiKhoan NVARCHAR(50)
AS
BEGIN
    UPDATE NguoiDung
    SET LoaiTaikhoan = @LoaiTaiKhoan
    WHERE Email = @Email;
END;
GO


CREATE PROCEDURE sp_checkPassword
    @user NVARCHAR(100),
    @pass NVARCHAR(50)
AS
BEGIN
    -- Kiểm tra xem có người dùng nào với tên và mật khẩu đã cho không
    IF EXISTS (SELECT * FROM NguoiDung WHERE Email = @user AND MatKhau = @pass)
    BEGIN
        -- Nếu mật khẩu cũ đúng, trả về mật khẩu (hoặc bất kỳ thông tin gì bạn muốn)
        SELECT  @pass AS Password, @user AS UserName; -- Trả về mật khẩu và tên người dùng
    END
    ELSE
    BEGIN
        -- Nếu mật khẩu sai, trả về một thông báo lỗi hoặc mã lỗi
        SELECT NULL AS Password;
    END
END;

go
CREATE PROC sp_moimatkhau
    @user NVARCHAR(100),
    @newpass NVARCHAR(50)
AS
BEGIN
    UPDATE NguoiDung
    SET MatKhau = @newpass
    WHERE  Email= @user;
END;
go
CREATE PROC sp_login
    @user NVARCHAR(50),
    @pass NVARCHAR(50)
AS
BEGIN
    SELECT Email , MatKhau
    FROM NguoiDung
    WHERE Email = @user AND MatKhau = @pass;
END;
GO

--14. Đăng ký
CREATE PROC sp_singin
    @ID_NguoiDung CHAR(8),
    @TenNguoiDung NVARCHAR(50),
    @Email NVARCHAR(100),
    @MatKhau NVARCHAR(50),
    @LoaiTaiKhoan NVARCHAR(50)
AS
BEGIN
    -- Kiểm tra xem email đã tồn tại hay chưa
    IF EXISTS (SELECT 1 FROM NguoiDung WHERE Email = @Email)
    BEGIN
        -- Trả về thông báo lỗi nếu email đã tồn tại
        SELECT 'Email đã tồn tại!' AS ErrorMessage;
        RETURN;
    END

    -- Thêm người dùng mới vào bảng NguoiDung
    INSERT INTO NguoiDung (ID_NguoiDung, TenNguoiDung, Email, MatKhau, LoaiTaiKhoan)
    VALUES (@ID_NguoiDung, @TenNguoiDung, @Email, @MatKhau, @LoaiTaiKhoan);

    -- Trả về thông báo thành công
    SELECT 'Đăng ký thành công!' AS SuccessMessage;
END
GO

CREATE PROC sp_getLoaiTaiKhoan
    @Email NVARCHAR(100)
AS
BEGIN
    SELECT LoaiTaiKhoan, TenNguoiDung
    FROM NguoiDung
	where Email = @Email
	end
go

--19 Danh sách Tài khoản 
CREATE PROC sp_DSTaiKhoan
AS
BEGIN
    SELECT m.ID_NguoiDung as 'Tên người dùng', m.TenNguoiDung as 'Tên hiển thị',m.Email ,m.LoaiTaiKhoan as 'Loại'
    FROM NguoiDung AS m 
END;
GO
--20 Thêm tài khoản
CREATE PROC sp_ThemTaiKhoan(
    @ID_NguoiDung char(8),
    @TenNguoiDung NVARCHAR(50),
    @Email nvarchar(100),
	@ChucVu nvarchar(30))
AS
BEGIN
    INSERT INTO NguoiDung(ID_NguoiDung, TenNguoiDung, Email,LoaiTaiKhoan)
    VALUES (@ID_NguoiDung, @TenNguoiDung, @Email,@ChucVu);
END;
Go
--21 Sửa tài khoản
CREATE PROC sp_SuaTaiKhoan
    @Id_ND char(8),
	@TenND nvarchar(50),
	@Email nvarchar(100),
	@ChucVu nvarchar(30)
AS
BEGIN
    UPDATE NguoiDung
    SET TenNguoiDung = @TenND, Email = @Email, LoaiTaiKhoan = @ChucVu
    WHERE ID_NguoiDung = @Id_ND;
END;
GO
--22 Xóa tài khoản
CREATE PROC sp_XoaTaiKhoan
	@Id_ND char(8)
AS
BEGIN
	DELETE FROM NguoiDung
	WHERE ID_NguoiDung = @Id_ND
END;
--23 Đặt lại mật khẩu tài khoản
GO
create PROC sp_DatLaiMatKhau
	@Id_ND char(8)
AS
BEGIN
	UPDATE NguoiDung
	SET MatKhau = 'admin1'
	WHERE ID_NguoiDung = @Id_ND
END;

go
create proc sp_ThongKeHoaDonChoBaoCao
@DateStart Date, @DateEnd Date
as
select b.TenBan ,hd.ThanhTien ,hd.NgayLap ,hd.NgayCheckout ,v.GiamGia from HoaDon as hd Inner JOIN Ban as b on hd.ID_Ban = b.ID_Ban 
	Inner JOIN Voucher as v on hd.MaVoucher = v.Code_Voucher
	where hd.TrangThai = 'paid' and hd.NgayLap >= @DateStart and hd.NgayCheckout <= @DateEnd

	go
	CREATE PROC sp_DSMonAnchoBaoCao
AS
BEGIN
    SELECT m.ID_MonAn , dm.TenDanhMuc ,m.TenMon ,m.DonGia FROM MonAn as m inner join DanhMuc as dm on m.ID_DanhMuc = dm.ID_DanhMuc;
END;
GO



