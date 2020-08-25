using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNhaSach.Models
{
    public class tblKhachHang
    {
        public int id { get; set; }
		public string tenKhachHang { get; set; }
		public string diaChi { get; set; }
		public string dienThoai { get; set; }
		public string email { get; set; }
		
    }
}