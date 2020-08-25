
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaSach
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        
        private void bang_tblSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hàm này sẽ mở một formtblSach và hỗ trợ mở lại form main này khi formtblSach bị đóng
            var childForm = new Forms.formtblSach();
            childForm.Owner = this;
            childForm.Show();
            this.Hide();
        }
        
        
        private void bang_tblLoaiSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hàm này sẽ mở một formtblLoaiSach và hỗ trợ mở lại form main này khi formtblLoaiSach bị đóng
            var childForm = new Forms.formtblLoaiSach();
            childForm.Owner = this;
            childForm.Show();
            this.Hide();
        }
        
        
        private void bang_tblTacGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hàm này sẽ mở một formtblTacGia và hỗ trợ mở lại form main này khi formtblTacGia bị đóng
            var childForm = new Forms.formtblTacGia();
            childForm.Owner = this;
            childForm.Show();
            this.Hide();
        }
        
        
        private void bang_tblKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hàm này sẽ mở một formtblKhachHang và hỗ trợ mở lại form main này khi formtblKhachHang bị đóng
            var childForm = new Forms.formtblKhachHang();
            childForm.Owner = this;
            childForm.Show();
            this.Hide();
        }
        
        
        private void bang_tblHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hàm này sẽ mở một formtblHoaDon và hỗ trợ mở lại form main này khi formtblHoaDon bị đóng
            var childForm = new Forms.formtblHoaDon();
            childForm.Owner = this;
            childForm.Show();
            this.Hide();
        }
        
        
        private void bang_ChiTiet_TheLoaiSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hàm này sẽ mở một formChiTiet_TheLoaiSach và hỗ trợ mở lại form main này khi formChiTiet_TheLoaiSach bị đóng
            var childForm = new Forms.formChiTiet_TheLoaiSach();
            childForm.Owner = this;
            childForm.Show();
            this.Hide();
        }
        
        
        private void bang_ChiTiet_TacGiaSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hàm này sẽ mở một formChiTiet_TacGiaSach và hỗ trợ mở lại form main này khi formChiTiet_TacGiaSach bị đóng
            var childForm = new Forms.formChiTiet_TacGiaSach();
            childForm.Owner = this;
            childForm.Show();
            this.Hide();
        }
        
        
        private void bang_PhieuNhapSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hàm này sẽ mở một formPhieuNhapSach và hỗ trợ mở lại form main này khi formPhieuNhapSach bị đóng
            var childForm = new Forms.formPhieuNhapSach();
            childForm.Owner = this;
            childForm.Show();
            this.Hide();
        }
        
        
        private void bang_ChiTiet_HoaDonBanSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hàm này sẽ mở một formChiTiet_HoaDonBanSach và hỗ trợ mở lại form main này khi formChiTiet_HoaDonBanSach bị đóng
            var childForm = new Forms.formChiTiet_HoaDonBanSach();
            childForm.Owner = this;
            childForm.Show();
            this.Hide();
        }
        
        
        private void bang_BaoCaoTonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hàm này sẽ mở một formBaoCaoTon và hỗ trợ mở lại form main này khi formBaoCaoTon bị đóng
            var childForm = new Forms.formBaoCaoTon();
            childForm.Owner = this;
            childForm.Show();
            this.Hide();
        }
        
        
        private void bang_BaoCaoCongNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hàm này sẽ mở một formBaoCaoCongNo và hỗ trợ mở lại form main này khi formBaoCaoCongNo bị đóng
            var childForm = new Forms.formBaoCaoCongNo();
            childForm.Owner = this;
            childForm.Show();
            this.Hide();
        }
        
        
        
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (this.Owner != null)
                {
                    this.Owner.Show();
                    this.Owner.Enabled = true;
                    this.Owner = null;
                    this.Dispose();
                }
            }
            catch (Exception) { }
        }

        private void thốngKêTiềnBánSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var updateee = Configs.Connection.GetSqlConnection;
                var nonquery = new SqlCommand("exec pCapNhatHoaDon", updateee);
                updateee.Open();
                nonquery.ExecuteNonQuery();
                updateee.Close();
            }
            catch (Exception ex) { MessageBox.Show("Không thể thực hiện cập nhật csdl !\nChi tiết lỗi: " + ex.Message); }

            var childForm = new Forms.formTraCuu(@"select 
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
	and tb3.id_tblSach = tb4.id");
            childForm.Owner = this;
            childForm.Show();
            this.Hide();
        }

        private void thốngKêDanhSáchSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var childForm = new Forms.formTraCuu(@"select t1.tenSach as N'Tên sách'
		, t1.giaBan as N'Giá bán'
		, t1.soLuong as N'Số lượng còn lại'
		, t3.tenLoai as N'Tên thể loại'
		, t5.ten as N'Tên tác giả'
from tblSach t1 left join ChiTiet_TheLoaiSach t2 on t2.id_tblSach = t1.id
	left join tblLoaiSach t3 on t2.id_tblLoaiSach = t3.id
	left join ChiTiet_TacGiaSach t4 on t4.id_tblSach = t1.id
	left join tblTacGia t5 on t5.id = t4.id_tblTacGia");
            childForm.Owner = this;
            childForm.Show();
            this.Hide();
        }
    }
}
