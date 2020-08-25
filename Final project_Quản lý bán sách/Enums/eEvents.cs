using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNhaSach.Enums
{
    
    // Hàm này dùng để chỉ trạng thái của bản ghi khi người dùng thêm, sửa, xoá
    public enum myEvents
    {
        Insert,
        Update,
        Delete,
    }
    
}