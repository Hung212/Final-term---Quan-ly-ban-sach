using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNhaSach.Models
{
    public class BaoCaoCongNo
    {
        public int id { get; set; }
		public int? id_tblKhachHang { get; set; }
		public string tenKhachHang { get; set; }
		public string dienThoai { get; set; }
		public int? noTien { get; set; }
		public DateTime? ngayNo { get; set; }
		public string moTa { get; set; }
		
    }
}