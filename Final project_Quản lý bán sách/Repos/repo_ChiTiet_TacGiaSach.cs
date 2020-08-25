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
    public class repo_ChiTiet_TacGiaSach : Restful<ChiTiet_TacGiaSach>
    {
        SqlDataReader reader;
        SqlConnection sqlConnection;
        public repo_ChiTiet_TacGiaSach()
        {
            sqlConnection = Connection.GetSqlConnection;
        }
        
        public ChiTiet_TacGiaSach Find(ChiTiet_TacGiaSach record)
        {
            string errorMessage = null;
            try
            {
                
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullid_tblSach = record.id_tblSach != null ? true : false;
				bool iNullid_tblTacGia = record.id_tblTacGia != null ? true : false;
				bool iNullvaiTro = record.vaiTro != null ? true : false;
				
                
                SqlCommand command;
                ChiTiet_TacGiaSach result;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select t1.id, t1.id_tblSach, t1.id_tblTacGia, t2.ten as tenTacGia, t3.tenSach, t1.vaiTro from ChiTiet_TacGiaSach t1, tblTacGia t2, tblSach t3 where t1.id_tblSach = t3.id and t1.id_tblTacGia = t2.id and t1.id = @id", sqlConnection);
                if(iNullid) command.Parameters.AddWithValue("@id", record.id);
				
                
                reader = command.ExecuteReader();
                result = new ChiTiet_TacGiaSach();
                
                if(reader.Read())
                {
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.id_tblSach = (reader["id_tblSach"] == null ? null : (int?)int.Parse(reader["id_tblSach"].ToString()));
						result.id_tblTacGia = (reader["id_tblTacGia"] == null ? null : (int?)int.Parse(reader["id_tblTacGia"].ToString()));
						result.vaiTro = (reader["vaiTro"] == null ? null : (string)(reader["vaiTro"]));
						result.tenSach = (reader["tenSach"] == null ? null : (string)(reader["tenSach"]));
						result.tenTacGia = (reader["tenTacGia"] == null ? null : (string)(reader["tenTacGia"]));
						
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
        
        public IEnumerable<ChiTiet_TacGiaSach> FindAll()
        {
            string errorMessage = null;
            try
            {
                SqlCommand command;
                List<ChiTiet_TacGiaSach> lResult;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select t1.id, t1.id_tblSach, t1.id_tblTacGia, t2.ten as tenTacGia, t3.tenSach, t1.vaiTro from ChiTiet_TacGiaSach t1, tblTacGia t2, tblSach t3 where t1.id_tblSach = t3.id and t1.id_tblTacGia = t2.id", sqlConnection);
                
                reader = command.ExecuteReader();
                lResult = new List<ChiTiet_TacGiaSach>();
                
                while(reader.Read())
                {
                    ChiTiet_TacGiaSach result = new ChiTiet_TacGiaSach();
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.id_tblSach = (reader["id_tblSach"] == null ? null : (int?)int.Parse(reader["id_tblSach"].ToString()));
						result.id_tblTacGia = (reader["id_tblTacGia"] == null ? null : (int?)int.Parse(reader["id_tblTacGia"].ToString()));
						result.vaiTro = (reader["vaiTro"] == null ? null : (string)(reader["vaiTro"]));
                        result.tenSach = (reader["tenSach"] == null ? null : (string)(reader["tenSach"]));
                        result.tenTacGia = (reader["tenTacGia"] == null ? null : (string)(reader["tenTacGia"]));

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
        
        public bool Create(ChiTiet_TacGiaSach record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullid_tblSach = record.id_tblSach != null ? true : false;
				bool iNullid_tblTacGia = record.id_tblTacGia != null ? true : false;
				bool iNullvaiTro = record.vaiTro != null ? true : false;
				
                
                // Đầu tiên phải kiểm tra xem cột giá trị có = null không, nếu bằng null thì loại bỏ khỏi lệnh insert

                string caulenhinsert = "insert into ChiTiet_TacGiaSach (#danhSachCot) values (#danhSachGiaTri)";
                List<string> danhSachCot = new List<string>();
                List<string> danhSachGiaTri = new List<string>();
                
                // khoá chính id tự sinh, chỉ chỉnh sửa nếu cần thiết
				
				// danhSachCot.Add(iNullid ? "id" : null);
				// danhSachGiaTri.Add(iNullid ? "@id" : null);
				
                // Normal key
				// gán danh sách cột
				// id_tblSach
				danhSachCot.Add(iNullid_tblSach ? "id_tblSach" : null);
				// id_tblTacGia
				danhSachCot.Add(iNullid_tblTacGia ? "id_tblTacGia" : null);
				// vaiTro
				danhSachCot.Add(iNullvaiTro ? "vaiTro" : null);
				
                // gán danh sách giá trị
				// id_tblSach
				danhSachGiaTri.Add(iNullid_tblSach ? "@id_tblSach" : null);
				// id_tblTacGia
				danhSachGiaTri.Add(iNullid_tblTacGia ? "@id_tblTacGia" : null);
				// vaiTro
				danhSachGiaTri.Add(iNullvaiTro ? "@vaiTro" : null);
				
                
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
				
                if(iNullid_tblSach) command.Parameters.AddWithValue("@id_tblSach", record.id_tblSach);
				if(iNullid_tblTacGia) command.Parameters.AddWithValue("@id_tblTacGia", record.id_tblTacGia);
				if(iNullvaiTro) command.Parameters.AddWithValue("@vaiTro", record.vaiTro);
				

                // trả về true nếu thực hiện lệnh được. Các trường hợp khác, trả về false.
                bool result = command.ExecuteNonQuery() > 0 ? true : false;

                sqlConnection.Close();
                return result;
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close(); }
            
            return false;
        }
        
        public bool Update(ChiTiet_TacGiaSach record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullid_tblSach = record.id_tblSach != null ? true : false;
				bool iNullid_tblTacGia = record.id_tblTacGia != null ? true : false;
				bool iNullvaiTro = record.vaiTro != null ? true : false;
				
                
                // Đầu tiên phải kiểm tra xem cột giá trị có = null không, nếu bằng null thì loại bỏ khỏi lệnh update
                
                string caulenhupdate = "update ChiTiet_TacGiaSach set #danhSachCot where id = @id";
                string dsCotString = null;
                List<string> danhSachCot = new List<string>();
                
                // Normal key
				// gán danh sách cột
				// id_tblSach
				danhSachCot.Add(iNullid_tblSach ? "id_tblSach" : null);
				// id_tblTacGia
				danhSachCot.Add(iNullid_tblTacGia ? "id_tblTacGia" : null);
				// vaiTro
				danhSachCot.Add(iNullvaiTro ? "vaiTro" : null);
				
                
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
                
                if(iNullid_tblSach) command.Parameters.AddWithValue("@id_tblSach", record.id_tblSach);
				if(iNullid_tblTacGia) command.Parameters.AddWithValue("@id_tblTacGia", record.id_tblTacGia);
				if(iNullvaiTro) command.Parameters.AddWithValue("@vaiTro", record.vaiTro);
				
                if(iNullid) command.Parameters.AddWithValue("@id", record.id);
				
                
                bool result = command.ExecuteNonQuery() > 0 ? true : false;
                
                sqlConnection.Close();
                return result;
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close(); }
            return false;
        }
        
        public bool Delete(ChiTiet_TacGiaSach record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullid_tblSach = record.id_tblSach != null ? true : false;
				bool iNullid_tblTacGia = record.id_tblTacGia != null ? true : false;
				bool iNullvaiTro = record.vaiTro != null ? true : false;
				
                
                SqlCommand command;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                
                
                // chạy lệnh xoá bản ghi hiện tại
                command = new SqlCommand("delete ChiTiet_TacGiaSach where id = @id", sqlConnection);
                
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