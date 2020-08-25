use dbQLCuaHangSach
go

/*
select 
	tb2.id as N'Mã hoá đơn'
	, tb2.ngayTao as N'Ngày thanh toán'
	, tb2.tenNhanVien as N'Tên nhân viên thực hiện'
	, tb1.tenKhachHang as N'Tên khách hàng'
	, tb1.diaChi as N'Địa chỉ'
	, tb1.dienThoai as N'Số điện thoại'
	, tb1.email as N'Email'
	, tb3.soLuong as N'Số lượng'
	, tb4.tenSach as N'Tên sách'
	, tb2.tongTien as N'Tổng số tiền phải trả'
from tblKhachHang tb1
	, tblHoaDon tb2
	, ChiTiet_HoaDonBanSach tb3
	, tblSach tb4
where tb2.id = tb3.id_tblHoaDon
	and tb3.id_tblKhachHang = tb1.id
	and tb3.id_tblSach = tb4.id



select t1.tenSach as N'Tên sách'
		, t1.giaBan as N'Giá bán'
		, t1.soLuong as N'Số lượng còn lại'
		, t3.tenLoai as N'Tên thể loại'
		, t5.ten as N'Tên tác giả'
from tblSach t1 left join ChiTiet_TheLoaiSach t2 on t2.id_tblSach = t1.id
	left join tblLoaiSach t3 on t2.id_tblLoaiSach = t3.id
	left join ChiTiet_TacGiaSach t4 on t4.id_tblSach = t1.id
	left join tblTacGia t5 on t5.id = t4.id_tblTacGia

*/

create proc pCapNhatHoaDon as
begin
	update tblHoaDon
	set tongTien = 
		(select sum(tb1.soLuong * tb2.giaBan) 
		from ChiTiet_HoaDonBanSach tb1
			, tblSach tb2 
		where tb1.id_tblSach = tb2.id 
			and tblHoaDon.id = tb1.id_tblHoaDon)
	-- select * from tblHoaDon
end
go

-- exec pCapNhatHoaDon
-- drop proc pCapNhatHoaDon