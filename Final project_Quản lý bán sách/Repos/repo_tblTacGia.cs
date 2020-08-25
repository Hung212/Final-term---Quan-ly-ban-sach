using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLNhaSach.Models;
using QLNhaSach.Configs;

namespace QLNhaSach.Repos
{
    public class repo_tblTacGia : Restful<tblTacGia>
    {
        SqlDataReader reader;
        SqlConnection sqlConnection;
        public repo_tblTacGia()
        {
            sqlConnection = Connection.GetSqlConnection;
        }
        
        public tblTacGia Find(tblTacGia record)
        {
            string errorMessage = null;
            try
            {
                
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullten = record.ten != null ? true : false;
				bool iNullngaySinh = record.ngaySinh != null ? true : false;
				bool iNullmoTa = record.moTa != null ? true : false;
				
                
                SqlCommand command;
                tblTacGia result;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select top 1 * from tblTacGia where id = @id", sqlConnection);
                if(iNullid) command.Parameters.AddWithValue("@id", record.id);
				
                
                reader = command.ExecuteReader();
                result = new tblTacGia();
                
                if(reader.Read())
                {
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.ten = (reader["ten"] == null ? null : (string)(reader["ten"]));
						result.ngaySinh = (reader["ngaySinh"] == null ? null : (DateTime?)DateTime.Parse(reader["ngaySinh"].ToString()));
						result.moTa = (reader["moTa"] == null ? null : (string)(reader["moTa"]));
						
                    }
                    catch(Exception ex) { errorMessage += "\n- " + ex.Message; }
                }
                
                sqlConnection.Close();
                return result;
            }
            catch (Exception e) { Console.WriteLine(e.Message + errorMessage); }
            finally { if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close(); }
            return null;
        }
        
        public IEnumerable<tblTacGia> FindAll()
        {
            string errorMessage = null;
            try
            {
                SqlCommand command;
                List<tblTacGia> lResult;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select * from tblTacGia", sqlConnection);
                
                reader = command.ExecuteReader();
                lResult = new List<tblTacGia>();
                
                while(reader.Read())
                {
                    tblTacGia result = new tblTacGia();
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.ten = (reader["ten"] == null ? null : (string)(reader["ten"]));
						result.ngaySinh = (reader["ngaySinh"] == null ? null : (DateTime?)DateTime.Parse(reader["ngaySinh"].ToString()));
						result.moTa = (reader["moTa"] == null ? null : (string)(reader["moTa"]));
						
                    }
                    catch(Exception ex) { errorMessage += "\n- " + ex.Message; }
                    
                    lResult.Add(result);
                }
                
                sqlConnection.Close();
                return lResult;
            }
            catch (Exception e) { Console.WriteLine(e.Message + errorMessage); }
            finally { if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close(); }
            return null;
        }
        
        public bool Create(tblTacGia record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullten = record.ten != null ? true : false;
				bool iNullngaySinh = record.ngaySinh != null ? true : false;
				bool iNullmoTa = record.moTa != null ? true : false;
				
                
                // Đầu tiên phải kiểm tra xem cột giá trị có = null không, nếu bằng null thì loại bỏ khỏi lệnh insert

                string caulenhinsert = "insert into tblTacGia (#danhSachCot) values (#danhSachGiaTri)";
                List<string> danhSachCot = new List<string>();
                List<string> danhSachGiaTri = new List<string>();
                
                // khoá chính id tự sinh, chỉ chỉnh sửa nếu cần thiết
				
				// danhSachCot.Add(iNullid ? "id" : null);
				// danhSachGiaTri.Add(iNullid ? "@id" : null);
				
                // Normal key
				// gán danh sách cột
				// ten
				danhSachCot.Add(iNullten ? "ten" : null);
				// ngaySinh
				danhSachCot.Add(iNullngaySinh ? "ngaySinh" : null);
				// moTa
				danhSachCot.Add(iNullmoTa ? "moTa" : null);
				
                // gán danh sách giá trị
				// ten
				danhSachGiaTri.Add(iNullten ? "@ten" : null);
				// ngaySinh
				danhSachGiaTri.Add(iNullngaySinh ? "@ngaySinh" : null);
				// moTa
				danhSachGiaTri.Add(iNullmoTa ? "@moTa" : null);
				
                
                danhSachCot.RemoveAll(m => m == null);
                danhSachGiaTri.RemoveAll(m => m == null);

                // thay giá trị sau khi đã lọc giá trị = null
                caulenhinsert = caulenhinsert.Replace("#danhSachCot", string.Join(", ", danhSachCot));
                caulenhinsert = caulenhinsert.Replace("#danhSachGiaTri", string.Join(", ", danhSachGiaTri));

                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();

                SqlCommand command = new SqlCommand(caulenhinsert, sqlConnection);

                // thêm giá trị của biến
                if(iNullid) command.Parameters.AddWithValue("@id", record.id);
				
                if(iNullten) command.Parameters.AddWithValue("@ten", record.ten);
				if(iNullngaySinh) command.Parameters.AddWithValue("@ngaySinh", record.ngaySinh);
				if(iNullmoTa) command.Parameters.AddWithValue("@moTa", record.moTa);
				

                // trả về true nếu thực hiện lệnh được. Các trường hợp khác, trả về false.
                bool result = command.ExecuteNonQuery() > 0 ? true : false;

                sqlConnection.Close();
                return result;
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close(); }
            
            return false;
        }
        
        public bool Update(tblTacGia record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullten = record.ten != null ? true : false;
				bool iNullngaySinh = record.ngaySinh != null ? true : false;
				bool iNullmoTa = record.moTa != null ? true : false;
				
                
                // Đầu tiên phải kiểm tra xem cột giá trị có = null không, nếu bằng null thì loại bỏ khỏi lệnh update
                
                string caulenhupdate = "update tblTacGia set #danhSachCot where id = @id";
                string dsCotString = null;
                List<string> danhSachCot = new List<string>();
                
                // Normal key
				// gán danh sách cột
				// ten
				danhSachCot.Add(iNullten ? "ten" : null);
				// ngaySinh
				danhSachCot.Add(iNullngaySinh ? "ngaySinh" : null);
				// moTa
				danhSachCot.Add(iNullmoTa ? "moTa" : null);
				
                
                danhSachCot.RemoveAll(m => m == null);
                
                if(danhSachCot.Count <= 0)
                    return false;
                
                // thay giá trị sau khi đã lọc giá trị = null
                dsCotString += danhSachCot[0] + " = @" + danhSachCot[0];
                for(int i = 1; i < danhSachCot.Count; i++)
                {
                    dsCotString += ", " + danhSachCot[i] + " = @" + danhSachCot[i];
                }
                caulenhupdate = caulenhupdate.Replace("#danhSachCot", dsCotString);
                
                SqlCommand command;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand(caulenhupdate, sqlConnection);
                
                if(iNullten) command.Parameters.AddWithValue("@ten", record.ten);
				if(iNullngaySinh) command.Parameters.AddWithValue("@ngaySinh", record.ngaySinh);
				if(iNullmoTa) command.Parameters.AddWithValue("@moTa", record.moTa);
				
                if(iNullid) command.Parameters.AddWithValue("@id", record.id);
				
                
                bool result = command.ExecuteNonQuery() > 0 ? true : false;
                
                sqlConnection.Close();
                return result;
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close(); }
            return false;
        }
        
        public bool Delete(tblTacGia record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullten = record.ten != null ? true : false;
				bool iNullngaySinh = record.ngaySinh != null ? true : false;
				bool iNullmoTa = record.moTa != null ? true : false;
				
                
                SqlCommand command;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                // xoá các bảng liên kết đến cột hiện tại
				
				//xoá liên kết tại bảng ChiTiet_TacGiaSach
				command = new SqlCommand("delete ChiTiet_TacGiaSach where id_tblTacGia = @id", sqlConnection);
				command.Parameters.AddWithValue("@id", record.id);
				bool xoaLienKet1 = command.ExecuteNonQuery() > 0 ? true : false;
				sqlConnection.Close();
				
				if (sqlConnection.State != System.Data.ConnectionState.Open)
					sqlConnection.Open();
				
                
                // chạy lệnh xoá bản ghi hiện tại
                command = new SqlCommand("delete tblTacGia where id = @id", sqlConnection);
                
                if(iNullid) command.Parameters.AddWithValue("@id", record.id);
				
                
                bool result = command.ExecuteNonQuery() > 0 ? true : false;
                
                sqlConnection.Close();
                return result;
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close(); }
            return false;
        }
    }
}