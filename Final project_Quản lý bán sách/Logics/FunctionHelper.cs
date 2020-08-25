using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using System.Data;
using System.ComponentModel;

namespace QLNhaSach.Logics
{
    
    public static class FunctionHelper
    {
        // Hàm này sẽ giúp tìm kiếm một chuỗi trong datagridview, trả về ds các dòng có chứa từ khóa
        // strSearch = giá trị tìm kiếm, _Datagridview = nguồn cần tìm kiếm, _listColumnFind = Ds cột cần tìm
        public static bool Find(string strSearch, ref DataGridView _Datagridview, List<int> _listColumnFind = null)
        {
            bool bResult = false;
            strSearch = strSearch.ToUpper();
            List<int> lAllowList = new List<int>();
            for (int j = 0; j < _Datagridview.Columns.Count; ++j)
            {
                // nếu _listColumn khác tập rỗng và không chứa cột đang xét -> bỏ qua
                if (_listColumnFind != null && !_listColumnFind.Exists(m => m == j))
                {
                    continue;
                }
                int i = 0;
                // tìm trong tất cả các dòng
                for (i = _Datagridview.Rows.Count - 1; i >= 0; --i)
                {
                    if (!lAllowList.Exists(x => x == i))
                    {
                        if (_Datagridview.Rows[i].Cells[j].Value != null)
                        {
                            string strA = _Datagridview.Rows[i].Cells[j].Value.ToString();
                            strA = strA.ToUpper();

                            if (string.Equals(strSearch, strA) | strA.IndexOf(strSearch, 0) >= 0)
                            {
                                bResult = true;
                                lAllowList.Add(i);
                            }
                        }
                        else
                            bResult = false;
                    }
                }
            }
            lAllowList.Sort((x, y) => x.CompareTo(y.CompareTo(y)));
            for (int i = _Datagridview.Rows.Count - 1; i >= 0; i--)
            {
                try
                {
                    if (!lAllowList.Exists(m => m == i))
                        _Datagridview.Rows.RemoveAt(i);
                }
                catch
                {
                    continue;
                }
            }
            _Datagridview.Refresh();

            return bResult;
        }
        
        
        public static bool ExportExcel(ref DataGridView source, string name = "baocao")
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = string.Format("report {0}.xlsx", name);
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Title = "Save report";
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (ExcelEngine excelEngine = new ExcelEngine())
                    {
                        IApplication application = excelEngine.Excel;

                        //Create a workbook with single worksheet
                        IWorkbook workbook = application.Workbooks.Create(1);

                        IWorksheet worksheet = workbook.Worksheets[0];

                        //Import from DataGridView to worksheet
                        worksheet.ImportDataGridView(source, 1, 1, isImportHeader: true, isImportStyle: true);

                        worksheet.UsedRange.AutofitColumns();
                        workbook.SaveAs(saveFileDialog.FileName);
                        return true;
                    }
                }
                catch (Exception e) { MessageBox.Show($"Đã có lỗi xảy ra khi cố gắng lưu file, xin hãy kiểm tra lại trùng lặp!\nChi tiết lỗi: {e.Message}"); }
            }
            return false;
        }

        public static DataTable ToDataTable<T>(this IEnumerable<T> data)
        {
            var properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}