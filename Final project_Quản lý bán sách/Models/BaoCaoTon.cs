using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNhaSach.Models
{
    public class BaoCaoTon
    {
        public int id { get; set; }
		public int? id_tblSach { get; set; }
		public string tenSach { get; set; }
		public int? chiPhi { get; set; }
		public DateTime? ngay { get; set; }
		public string moTa { get; set; }
		
    }
}