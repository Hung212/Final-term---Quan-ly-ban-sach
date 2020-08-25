using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNhaSach.Models
{
    public class TheLoaiSach
    {
        public int id { get; set; }
		public int? id_tblSach { get; set; }
		public int? id_tblLoaiSach { get; set; }
		
    }
}