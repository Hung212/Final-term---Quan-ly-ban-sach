using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNhaSach
{
    public interface Restful<T>
    {
        T Find(T record);
        IEnumerable<T> FindAll();
        bool Create(T record);
        bool Update(T record);
        bool Delete(T record);
    }
}