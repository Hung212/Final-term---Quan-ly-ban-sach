USE [dbQLCuaHangSach]
GO
SET IDENTITY_INSERT [dbo].[tblSach] ON 

INSERT [dbo].[tblSach] ([id], [tenSach], [giaBan], [soLuong]) VALUES (1, N'Sách bóng hồng', 240000, 30)
INSERT [dbo].[tblSach] ([id], [tenSach], [giaBan], [soLuong]) VALUES (2, N'Sách bóng cả', 210000, 31)
INSERT [dbo].[tblSach] ([id], [tenSach], [giaBan], [soLuong]) VALUES (3, N'Sách bóng bẩy', 220000, 32)
INSERT [dbo].[tblSach] ([id], [tenSach], [giaBan], [soLuong]) VALUES (4, N'Sách công phượng', 230000, 33)
INSERT [dbo].[tblSach] ([id], [tenSach], [giaBan], [soLuong]) VALUES (5, N'Sách quang hải', 240000, 34)
INSERT [dbo].[tblSach] ([id], [tenSach], [giaBan], [soLuong]) VALUES (6, N'Sách con ếch', 240000, 35)
INSERT [dbo].[tblSach] ([id], [tenSach], [giaBan], [soLuong]) VALUES (7, N'Sách con cua', 240000, 37)
SET IDENTITY_INSERT [dbo].[tblSach] OFF
SET IDENTITY_INSERT [dbo].[tblLoaiSach] ON 

INSERT [dbo].[tblLoaiSach] ([id], [tenLoai]) VALUES (1, N'Trinh thám')
INSERT [dbo].[tblLoaiSach] ([id], [tenLoai]) VALUES (2, N'Phiêu lưu')
INSERT [dbo].[tblLoaiSach] ([id], [tenLoai]) VALUES (3, N'Chiến thần')
INSERT [dbo].[tblLoaiSach] ([id], [tenLoai]) VALUES (4, N'Chiến thuật')
INSERT [dbo].[tblLoaiSach] ([id], [tenLoai]) VALUES (5, N'Công thành')
INSERT [dbo].[tblLoaiSach] ([id], [tenLoai]) VALUES (6, N'Self help')
INSERT [dbo].[tblLoaiSach] ([id], [tenLoai]) VALUES (7, N'Khoa học')
INSERT [dbo].[tblLoaiSach] ([id], [tenLoai]) VALUES (8, N'Lập trình')
INSERT [dbo].[tblLoaiSach] ([id], [tenLoai]) VALUES (9, N'Tiểu học')
INSERT [dbo].[tblLoaiSach] ([id], [tenLoai]) VALUES (10, N'Trung học')
SET IDENTITY_INSERT [dbo].[tblLoaiSach] OFF
SET IDENTITY_INSERT [dbo].[ChiTiet_TheLoaiSach] ON 

INSERT [dbo].[ChiTiet_TheLoaiSach] ([id], [id_tblSach], [id_tblLoaiSach]) VALUES (1, 1, 2)
INSERT [dbo].[ChiTiet_TheLoaiSach] ([id], [id_tblSach], [id_tblLoaiSach]) VALUES (2, 2, 7)
INSERT [dbo].[ChiTiet_TheLoaiSach] ([id], [id_tblSach], [id_tblLoaiSach]) VALUES (3, 3, 7)
INSERT [dbo].[ChiTiet_TheLoaiSach] ([id], [id_tblSach], [id_tblLoaiSach]) VALUES (4, 3, 6)
SET IDENTITY_INSERT [dbo].[ChiTiet_TheLoaiSach] OFF
SET IDENTITY_INSERT [dbo].[PhieuNhapSach] ON 

INSERT [dbo].[PhieuNhapSach] ([id], [id_tblSach], [soLuong], [ngay]) VALUES (1, 2, 20, CAST(N'2020-08-12 00:47:43.343' AS DateTime))
INSERT [dbo].[PhieuNhapSach] ([id], [id_tblSach], [soLuong], [ngay]) VALUES (2, 1, 11, CAST(N'2020-08-12 00:47:43.343' AS DateTime))
INSERT [dbo].[PhieuNhapSach] ([id], [id_tblSach], [soLuong], [ngay]) VALUES (3, 4, 15, CAST(N'2020-08-12 00:47:43.343' AS DateTime))
INSERT [dbo].[PhieuNhapSach] ([id], [id_tblSach], [soLuong], [ngay]) VALUES (4, 3, 15, CAST(N'2020-08-12 00:47:43.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[PhieuNhapSach] OFF
SET IDENTITY_INSERT [dbo].[tblKhachHang] ON 

INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (1, N'Huỳnh Tiến Hiếu', N'Số 853 Xã Hiên Vân, Quận Hồng Bàng, Tỉnh Long An', N'034 5344 811', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (2, N'Khai Tiến Khải', N'Số 932 Phường Tân Quý, Huyện Bát Xát, Tỉnh Bắc Ninh', N'034 4007 667', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (3, N'Cáp Nhật Dũng', N'Số 476 Xã Trùng Khánh, Huyện Hàm Thuận Bắc, Tỉnh Vĩnh Long', N'034 5574 684', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (4, N'Tào Anh Linh', N'Số 226 Xã Đông Cứu, Huyện KBang, Tỉnh Đồng Tháp', N'034 4645 451', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (5, N'Giáp Dương Phúc', N'Số 859 Xã Đắk Kơ Ning, Huyện Thanh Sơn, Tỉnh Bến Tre', N'034 9084 661', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (6, N'Đào Minh Trường', N'Số 612 Thị trấn Vĩnh Bảo, Quận Bình Tân, Tỉnh Thanh Hóa', N'034 1835 379', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (7, N'Khà Hiếu Dũng', N'Số 940 Xã Thiệu Lý, Huyện A Lưới, Tỉnh Đồng Tháp', N'034 3560 854', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (8, N'Uông Hữu Quang', N'Số 334 Xã Tiên Thắng, Huyện Nậm Pồ, Tỉnh Nam Định', N'034 5100 441', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (9, N'Vương Hoàng Hoàng', N'Số 854 Xã Vân Hồ, Thị xã Bình Minh, Tỉnh Hưng Yên', N'034 7093 605', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (10, N'Dương Bình Dũng', N'Số 744 Xã Nghĩa Phúc, Huyện Văn Quan, Tỉnh Hải Dương', N'034 9220 963', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (11, N'Lại Huy Thịnh', N'Số 61 Xã Tân Thành, Quận Lê Chân, Tỉnh Đắk Lắk', N'034 7483 150', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (12, N'Lều Bảo Anh', N'Số 23 Xã Cảnh Hưng, Huyện Đồng Phú, Thành phố Hải Phòng', N'034 0755 064', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (13, N'Vương Khôi Đại', N'Số 103 Xã Giao An, Huyện Thiệu Hóa, Thành phố Đà Nẵng', N'034 9742 204', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (14, N'Phù Chấn Trung', N'Số 513 Xã Diễn Liên, Huyện Văn Bàn, Tỉnh Lạng Sơn', N'034 8326 634', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (15, N'Lỗ Uy Thành', N'Số 335 Xã Phú Lễ, Huyện Phú Bình, Tỉnh Nam Định', N'034 3498 807', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (16, N'Nhữ Từ Hiệp', N'Số 99 Xã Tân Hương, Huyện Đông Hưng, Tỉnh Phú Yên', N'034 6172 806', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (17, N'Tuấn Họa An', N'Số 439 Xã Quảng Điền, Huyện Tiên Phước, Thành phố Hải Phòng', N'034 2486 319', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (18, N'Ứng Túy Nữ', N'Số 532 Xã Hưng Đạo, Huyện Mê Linh, Tỉnh Bắc Kạn', N'034 4787 599', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (19, N'Ngô Cát Dân', N'Số 59 Xã Trung Thạnh, Huyện Bạch Thông, Tỉnh Hậu Giang', N'034 0664 257', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (20, N'Ninh Nghi Quân', N'Số 763 Xã Nậm Manh, Huyện Tiền Hải, Tỉnh Hải Dương', N'034 3561 663', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (21, N'Ngô Chi Ðình', N'Số 956 Xã Hợp Thịnh, Thành phố Trà Vinh, Thành phố Đà Nẵng', N'034 5694 975', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (22, N'Anh Hiền Vọng', N'Số 57 Phường Cẩm An, Huyện Bình Xuyên, Tỉnh Long An', N'034 9303 248', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (23, N'Đinh Trầm Dung', N'Số 975 Xã Vạn Khánh, Quận 7, Tỉnh Sóc Trăng', N'034 6112 186', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (24, N'Lục Huệ Giao', N'Số 580 Phường 8, Huyện Châu Thành, Tỉnh Quảng Ngãi', N'034 5186 499', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (25, N'Thôi Thơ Nhi', N'Số 784 Xã Ia Nan, Huyện Ba Tơ, Tỉnh Tiền Giang', N'034 9147 469', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (26, N'Hướng Kiều Cát', N'Số 411 Xã Văn Xá, Huyện Long Hồ, Tỉnh Lâm Đồng', N'034 0926 131', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (27, N'Châu Họa Hạnh', N'Số 448 Phường Hoàng Văn Thụ, Huyện Long Phú, Tỉnh Sơn La', N'034 2509 186', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (28, N'Hình Duyên Oanh', N'Số 556 Xã Tô Mậu, Thành phố Sơn La, Tỉnh Nam Định', N'034 3584 870', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (29, N'Nhan Nhất Tâm', N'Số 353 Xã Đại Hòa Lộc, Huyện Ninh Hải, Tỉnh Yên Bái', N'034 5074 860', N'email1@gmail.com')
INSERT [dbo].[tblKhachHang] ([id], [tenKhachHang], [diaChi], [dienThoai], [email]) VALUES (30, N'Ung Minh Oanh', N'Số 979 Phường 28, Huyện Bắc Bình, Tỉnh Thừa Thiên Huế', N'034 2567 786', N'email1@gmail.com')
SET IDENTITY_INSERT [dbo].[tblKhachHang] OFF
SET IDENTITY_INSERT [dbo].[tblHoaDon] ON 

INSERT [dbo].[tblHoaDon] ([id], [ngayTao], [tenNhanVien], [tongTien]) VALUES (1, CAST(N'2020-08-12 00:48:11.233' AS DateTime), N'Nguyễn Như Nguyệt', 315)
INSERT [dbo].[tblHoaDon] ([id], [ngayTao], [tenNhanVien], [tongTien]) VALUES (2, CAST(N'2020-08-12 00:48:11.000' AS DateTime), N'Nguyễn Ánh Liên', 241)
INSERT [dbo].[tblHoaDon] ([id], [ngayTao], [tenNhanVien], [tongTien]) VALUES (3, CAST(N'2020-08-12 00:48:11.233' AS DateTime), N'Nguyễn Ánh Lý', 315)
INSERT [dbo].[tblHoaDon] ([id], [ngayTao], [tenNhanVien], [tongTien]) VALUES (4, CAST(N'2020-08-12 00:48:11.000' AS DateTime), N'Nguyễn Minh Anh', 468)
SET IDENTITY_INSERT [dbo].[tblHoaDon] OFF
SET IDENTITY_INSERT [dbo].[ChiTiet_HoaDonBanSach] ON 

INSERT [dbo].[ChiTiet_HoaDonBanSach] ([id], [id_tblHoaDon], [id_tblKhachHang], [id_tblSach], [soLuong]) VALUES (2, 2, 1, 2, 2)
INSERT [dbo].[ChiTiet_HoaDonBanSach] ([id], [id_tblHoaDon], [id_tblKhachHang], [id_tblSach], [soLuong]) VALUES (3, 2, 1, 6, 1)
SET IDENTITY_INSERT [dbo].[ChiTiet_HoaDonBanSach] OFF
SET IDENTITY_INSERT [dbo].[BaoCaoTon] ON 

INSERT [dbo].[BaoCaoTon] ([id], [id_tblSach], [chiPhi], [ngay], [moTa]) VALUES (1, 1, 52, CAST(N'2020-08-12 00:49:39.043' AS DateTime), N'Sửa chữa bìa hỏng')
INSERT [dbo].[BaoCaoTon] ([id], [id_tblSach], [chiPhi], [ngay], [moTa]) VALUES (2, 4, 78, CAST(N'2020-08-12 00:49:39.043' AS DateTime), N'Sửa chữa lề nát')
INSERT [dbo].[BaoCaoTon] ([id], [id_tblSach], [chiPhi], [ngay], [moTa]) VALUES (3, 7, 40, CAST(N'2020-08-12 00:49:39.043' AS DateTime), N'Quăn góc')
SET IDENTITY_INSERT [dbo].[BaoCaoTon] OFF
SET IDENTITY_INSERT [dbo].[BaoCaoCongNo] ON 

INSERT [dbo].[BaoCaoCongNo] ([id], [id_tblKhachHang], [noTien], [ngayNo], [moTa]) VALUES (1, 10, 26, CAST(N'2020-08-12 00:50:25.443' AS DateTime), N'')
INSERT [dbo].[BaoCaoCongNo] ([id], [id_tblKhachHang], [noTien], [ngayNo], [moTa]) VALUES (2, 24, 14, CAST(N'2020-08-12 00:50:25.443' AS DateTime), N'')
INSERT [dbo].[BaoCaoCongNo] ([id], [id_tblKhachHang], [noTien], [ngayNo], [moTa]) VALUES (4, 16, 14, CAST(N'2020-08-12 00:50:25.443' AS DateTime), N'Mang nhầm thẻ')
SET IDENTITY_INSERT [dbo].[BaoCaoCongNo] OFF
SET IDENTITY_INSERT [dbo].[tblTacGia] ON 

INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (1, N'Nguyễn Ái Quốc', CAST(N'1890-08-12' AS Date), N'')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (2, N'Nguyễn Trung Quân', CAST(N'1894-11-24' AS Date), N'')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (3, N'Nguyễn Trung Hiếu', CAST(N'1896-08-21' AS Date), N'')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (4, N'Vũ Công Hậu', CAST(N'1896-08-21' AS Date), N'')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (5, N'Vũ Công Ánh', CAST(N'1896-08-21' AS Date), N'')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (6, N'Đặng Trâm', CAST(N'1896-08-21' AS Date), N'')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (7, N'Vạn Trí Nhân', CAST(N'1967-11-04' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (8, N'Hi Thiên Giáp', CAST(N'1975-12-24' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (9, N'Thân Hạnh Lâm', CAST(N'1981-03-12' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (10, N'Cao Phúc Điền', CAST(N'1961-10-20' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (11, N'Công Minh Khang', CAST(N'2012-10-20' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (12, N'Khoa Phú Hiếu', CAST(N'1981-10-05' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (13, N'Tòng Tấn Tuấn', CAST(N'2006-09-20' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (14, N'Thào Tùng Minh', CAST(N'1952-10-24' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (15, N'Đầu Khánh Lâm', CAST(N'1961-03-17' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (16, N'Cai Chấn Cường', CAST(N'2020-05-21' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (17, N'Đào Hiếu Nhân', CAST(N'2015-02-12' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (18, N'Thi Tấn Huy', CAST(N'1970-04-07' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (19, N'Thào Dương Thảo', CAST(N'2014-04-24' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (20, N'Tán Chấn Thịnh', CAST(N'1992-09-27' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (21, N'Khai Sơn Trung', CAST(N'1978-10-22' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (22, N'Trác Hạo Hùng', CAST(N'2020-01-22' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (23, N'Hề Đại Liêm', CAST(N'2011-05-15' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (24, N'Sơn Khánh Thắng', CAST(N'2000-05-06' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (25, N'Tán Thiên Phương', CAST(N'1961-07-25' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (26, N'Ong Huy Long', CAST(N'1955-04-27' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (27, N'Thế Mạnh Long', CAST(N'1970-09-27' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (28, N'Bùi Trung Minh', CAST(N'1995-06-04' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (29, N'Lạc Quốc Linh', CAST(N'1968-03-25' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (30, N'Lưu Hiếu Trung', CAST(N'1967-11-04' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (31, N'Hồ Đăng Đăng', CAST(N'1978-06-16' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (32, N'Mẫn Hoàng Vân', CAST(N'1978-09-16' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (33, N'Đầu Lâm Tú', CAST(N'1970-09-08' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (34, N'Ưng Thuần Thy', CAST(N'1982-05-21' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (35, N'Nghị Nguyên Thắm', CAST(N'2009-08-28' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (36, N'Dư Bội Ðoan', CAST(N'2007-05-07' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (37, N'Ao Ðan Trà', CAST(N'1976-02-23' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (38, N'Lạc Vi Du', CAST(N'1972-08-15' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (39, N'Mạnh Lưu Mi', CAST(N'1995-05-18' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (40, N'Thịnh Kiều Phương', CAST(N'1990-01-21' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (41, N'Nhan Tố Mẫn', CAST(N'1970-01-29' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (42, N'Ân Thiều Thùy', CAST(N'1983-12-04' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (43, N'Cáp Diên Nữ', CAST(N'1988-03-02' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (44, N'Hứa Lâm Trung', CAST(N'1982-05-24' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (45, N'Tăng Tuệ Dân', CAST(N'1956-12-16' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (46, N'Châu Khánh Hảo', CAST(N'1966-08-21' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (47, N'Kiểu Hảo Hạnh', CAST(N'1994-12-14' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (48, N'Bồ Ngân Ðường', CAST(N'2005-10-11' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (49, N'Phó Nghi Trang', CAST(N'1993-03-09' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (50, N'Khu Anh Khánh', CAST(N'1978-01-09' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (51, N'Liễu Lục Nhi', CAST(N'1964-08-13' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (52, N'Giàng Hoài Ngôn', CAST(N'2001-02-06' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (53, N'Cầm Phụng Thuận', CAST(N'1957-05-23' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (54, N'Tô Dạ Thêu', CAST(N'1984-02-02' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (55, N'Bàn Sao Diệu', CAST(N'1996-11-14' AS Date), N'Cực giỏi')
INSERT [dbo].[tblTacGia] ([id], [ten], [ngaySinh], [moTa]) VALUES (56, N'Lều Thu Hằng', CAST(N'1992-09-06' AS Date), N'Cực giỏi')
SET IDENTITY_INSERT [dbo].[tblTacGia] OFF
