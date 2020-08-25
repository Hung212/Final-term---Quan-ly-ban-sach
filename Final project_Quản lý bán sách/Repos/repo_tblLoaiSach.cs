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
    public class repo_tblLoaiSach : Restful<tblLoaiSach>
    {
        SqlDataReader reader;
        SqlConnection sqlConnection;
        public repo_tblLoaiSach()
        {
            sqlConnection = Connection.GetSqlConnection;
        }
        
        public tblLoaiSach Find(tblLoaiSach record)
        {
            string errorMessage = null;
            try
            {
                
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNulltenLoai = record.tenLoai != null ? true : false;
				
                
                SqlCommand command;
                tblLoaiSach result;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select top 1 * from tblLoaiSach where id = @id", sqlConnection);
                if(iNullid) command.Parameters.AddWithValue("@id", record.id);
				
                
                reader = command.ExecuteReader();
                result = new tblLoaiSach();
                
                if(reader.Read())
                {
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.tenLoai = (reader["tenLoai"] == null ? null : (string)(reader["tenLoai"]));
						
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
        
        public IEnumerable<tblLoaiSach> FindAll()
        {
            string errorMessage = null;
            try
            {
                SqlCommand command;
                List<tblLoaiSach> lResult;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select * from tblLoaiSach", sqlConnection);
                
                reader = command.ExecuteReader();
                lResult = new List<tblLoaiSach>();
                
                while(reader.Read())
                {
                    tblLoaiSach result = new tblLoaiSach();
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.tenLoai = (reader["tenLoai"] == null ? null : (string)(reader["tenLoai"]));
						
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
        
        public bool Create(tblLoaiSach record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNulltenLoai = record.tenLoai != null ? true : false;
				
                
                // Đầu tiên phải kiểm tra xem cột giá trị có = null không, nếu bằng null thì loại bỏ khỏi lệnh insert

                string caulenhinsert = "insert into tblLoaiSach (#danhSachCot) values (#danhSachGiaTri)";
                List<string> danhSachCot = new List<string>();
                List<string> danhSachGiaTri = new List<string>();
                
                // khoá chính id tự sinh, chỉ chỉnh sửa nếu cần thiết
				
				// danhSachCot.Add(iNullid ? "id" : null);
				// danhSachGiaTri.Add(iNullid ? "@id" : null);
				
                // Normal key
				// gán danh sách cột
				// tenLoai
				danhSachCot.Add(iNulltenLoai ? "tenLoai" : null);
				
                // gán danh sách giá trị
				// tenLoai
				danhSachGiaTri.Add(iNulltenLoai ? "@tenLoai" : null);
				
                
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
				
                if(iNulltenLoai) command.Parameters.AddWithValue("@tenLoai", record.tenLoai);
				

                // trả về true nếu thực hiện lệnh được. Các trường hợp khác, trả về false.
                bool result = command.ExecuteNonQuery() > 0 ? true : false;

                sqlConnection.Close();
                return result;
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close(); }
            
            return false;
        }
        
        public bool Update(tblLoaiSach record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNulltenLoai = record.tenLoai != null ? true : false;
				
                
                // Đầu tiên phải kiểm tra xem cột giá trị có = null không, nếu bằng null thì loại bỏ khỏi lệnh update
                
                string caulenhupdate = "update tblLoaiSach set #danhSachCot where id = @id";
                string dsCotString = null;
                List<string> danhSachCot = new List<string>();
                
                // Normal key
				// gán danh sách cột
				// tenLoai
				danhSachCot.Add(iNulltenLoai ? "tenLoai" : null);
				
                
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
                
                if(iNulltenLoai) command.Parameters.AddWithValue("@tenLoai", record.tenLoai);
				
                if(iNullid) command.Parameters.AddWithValue("@id", record.id);
				
                
                bool result = command.ExecuteNonQuery() > 0 ? true : false;
                
                sqlConnection.Close();
                return result;
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close(); }
            return false;
        }
        
        public bool Delete(tblLoaiSach record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNulltenLoai = record.tenLoai != null ? true : false;
				
                
                SqlCommand command;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                // xoá các bảng liên kết đến cột hiện tại
				
				//xoá liên kết tại bảng ChiTiet_TheLoaiSach
				command = new SqlCommand("delete ChiTiet_TheLoaiSach where id_tblLoaiSach = @id", sqlConnection);
				command.Parameters.AddWithValue("@id", record.id);
				bool xoaLienKet1 = command.ExecuteNonQuery() > 0 ? true : false;
				sqlConnection.Close();
				
				if (sqlConnection.State != System.Data.ConnectionState.Open)
					sqlConnection.Open();
				
                
                // chạy lệnh xoá bản ghi hiện tại
                command = new SqlCommand("delete tblLoaiSach where id = @id", sqlConnection);
                
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