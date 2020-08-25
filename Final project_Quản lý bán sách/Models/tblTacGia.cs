using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNhaSach.Models
{
    public class tblTacGia
    {
        public int id { get; set; }
		public string ten { get; set; }
		public DateTime? ngaySinh { get; set; }
		public string moTa { get; set; }
		
    }
}