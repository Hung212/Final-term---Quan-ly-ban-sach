using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNhaSach.Models
{
    public class tblHoaDon
    {
        public int id { get; set; }
		public DateTime? ngayTao { get; set; }
		public string tenNhanVien { get; set; }
		public int? tongTien { get; set; }
		
    }
}