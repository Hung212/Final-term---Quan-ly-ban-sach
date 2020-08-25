using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNhaSach.Models
{
    public class ChiTietHoaDonBanSach
    {
        public int id { get; set; }
		public int? id_tblHoaDon { get; set; }
		public int? id_tblKhachHang { get; set; }
		public int? id_tblSach { get; set; }
		public int? soLuong { get; set; }
		
    }
}