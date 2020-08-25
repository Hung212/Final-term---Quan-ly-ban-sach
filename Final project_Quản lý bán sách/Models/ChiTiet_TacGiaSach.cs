using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNhaSach.Models
{
    public class ChiTiet_TacGiaSach
    {
        public int id { get; set; }
		public int? id_tblSach { get; set; }
		public int? id_tblTacGia { get; set; }
        public string tenSach { get; set; }
        public string tenTacGia { get; set; }
		public string vaiTro { get; set; }
		
    }
}