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
    public class repo_tblSach : Restful<tblSach>
    {
        SqlDataReader reader;
        SqlConnection sqlConnection;
        public repo_tblSach()
        {
            sqlConnection = Connection.GetSqlConnection;
        }
        
        public tblSach Find(tblSach record)
        {
            string errorMessage = null;
            try
            {
                
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNulltenSach = record.tenSach != null ? true : false;
				bool iNullgiaBan = record.giaBan != null ? true : false;
				bool iNullsoLuong = record.soLuong != null ? true : false;
				
                
                SqlCommand command;
                tblSach result;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select top 1 * from tblSach where id = @id", sqlConnection);
                if(iNullid) command.Parameters.AddWithValue("@id", record.id);
				
                
                reader = command.ExecuteReader();
                result = new tblSach();
                
                if(reader.Read())
                {
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.tenSach = (reader["tenSach"] == null ? null : (string)(reader["tenSach"]));
						result.giaBan = (reader["giaBan"] == null ? null : (int?)int.Parse(reader["giaBan"].ToString()));
						result.soLuong = (reader["soLuong"] == null ? null : (int?)int.Parse(reader["soLuong"].ToString()));
						
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
        
        public IEnumerable<tblSach> FindAll()
        {
            string errorMessage = null;
            try
            {
                SqlCommand command;
                List<tblSach> lResult;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select * from tblSach", sqlConnection);
                
                reader = command.ExecuteReader();
                lResult = new List<tblSach>();
                
                while(reader.Read())
                {
                    tblSach result = new tblSach();
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.tenSach = (reader["tenSach"] == null ? null : (string)(reader["tenSach"]));
						result.giaBan = (reader["giaBan"] == null ? null : (int?)int.Parse(reader["giaBan"].ToString()));
						result.soLuong = (reader["soLuong"] == null ? null : (int?)int.Parse(reader["soLuong"].ToString()));
						
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
        
        public bool Create(tblSach record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNulltenSach = record.tenSach != null ? true : false;
				bool iNullgiaBan = record.giaBan != null ? true : false;
				bool iNullsoLuong = record.soLuong != null ? true : false;
				
                
                // Đầu tiên phải kiểm tra xem cột giá trị có = null không, nếu bằng null thì loại bỏ khỏi lệnh insert

                string caulenhinsert = "insert into tblSach (#danhSachCot) values (#danhSachGiaTri)";
                List<string> danhSachCot = new List<string>();
                List<string> danhSachGiaTri = new List<string>();
                
                // khoá chính id tự sinh, chỉ chỉnh sửa nếu cần thiết
				
				// danhSachCot.Add(iNullid ? "id" : null);
				// danhSachGiaTri.Add(iNullid ? "@id" : null);
				
                // Normal key
				// gán danh sách cột
				// tenSach
				danhSachCot.Add(iNulltenSach ? "tenSach" : null);
				// giaBan
				danhSachCot.Add(iNullgiaBan ? "giaBan" : null);
				// soLuong
				danhSachCot.Add(iNullsoLuong ? "soLuong" : null);
				
                // gán danh sách giá trị
				// tenSach
				danhSachGiaTri.Add(iNulltenSach ? "@tenSach" : null);
				// giaBan
				danhSachGiaTri.Add(iNullgiaBan ? "@giaBan" : null);
				// soLuong
				danhSachGiaTri.Add(iNullsoLuong ? "@soLuong" : null);
				
                
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
				
                if(iNulltenSach) command.Parameters.AddWithValue("@tenSach", record.tenSach);
				if(iNullgiaBan) command.Parameters.AddWithValue("@giaBan", record.giaBan);
				if(iNullsoLuong) command.Parameters.AddWithValue("@soLuong", record.soLuong);
				

                // trả về true nếu thực hiện lệnh được. Các trường hợp khác, trả về false.
                bool result = command.ExecuteNonQuery() > 0 ? true : false;

                sqlConnection.Close();
                return result;
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close(); }
            
            return false;
        }
        
        public bool Update(tblSach record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNulltenSach = record.tenSach != null ? true : false;
				bool iNullgiaBan = record.giaBan != null ? true : false;
				bool iNullsoLuong = record.soLuong != null ? true : false;
				
                
                // Đầu tiên phải kiểm tra xem cột giá trị có = null không, nếu bằng null thì loại bỏ khỏi lệnh update
                
                string caulenhupdate = "update tblSach set #danhSachCot where id = @id";
                string dsCotString = null;
                List<string> danhSachCot = new List<string>();
                
                // Normal key
				// gán danh sách cột
				// tenSach
				danhSachCot.Add(iNulltenSach ? "tenSach" : null);
				// giaBan
				danhSachCot.Add(iNullgiaBan ? "giaBan" : null);
				// soLuong
				danhSachCot.Add(iNullsoLuong ? "soLuong" : null);
				
                
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
                
                if(iNulltenSach) command.Parameters.AddWithValue("@tenSach", record.tenSach);
				if(iNullgiaBan) command.Parameters.AddWithValue("@giaBan", record.giaBan);
				if(iNullsoLuong) command.Parameters.AddWithValue("@soLuong", record.soLuong);
				
                if(iNullid) command.Parameters.AddWithValue("@id", record.id);
				
                
                bool result = command.ExecuteNonQuery() > 0 ? true : false;
                
                sqlConnection.Close();
                return result;
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close(); }
            return false;
        }
        
        public bool Delete(tblSach record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNulltenSach = record.tenSach != null ? true : false;
				bool iNullgiaBan = record.giaBan != null ? true : false;
				bool iNullsoLuong = record.soLuong != null ? true : false;
				
                
                SqlCommand command;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                // xoá các bảng liên kết đến cột hiện tại
				
				//xoá liên kết tại bảng ChiTiet_TheLoaiSach
				command = new SqlCommand("delete ChiTiet_TheLoaiSach where id_tblSach = @id", sqlConnection);
				command.Parameters.AddWithValue("@id", record.id);
				bool xoaLienKet1 = command.ExecuteNonQuery() > 0 ? true : false;
				sqlConnection.Close();
				
				if (sqlConnection.State != System.Data.ConnectionState.Open)
					sqlConnection.Open();
				
				//xoá liên kết tại bảng ChiTiet_TacGiaSach
				command = new SqlCommand("delete ChiTiet_TacGiaSach where id_tblSach = @id", sqlConnection);
				command.Parameters.AddWithValue("@id", record.id);
				bool xoaLienKet2 = command.ExecuteNonQuery() > 0 ? true : false;
				sqlConnection.Close();
				
				if (sqlConnection.State != System.Data.ConnectionState.Open)
					sqlConnection.Open();
				
				//xoá liên kết tại bảng PhieuNhapSach
				command = new SqlCommand("delete PhieuNhapSach where id_tblSach = @id", sqlConnection);
				command.Parameters.AddWithValue("@id", record.id);
				bool xoaLienKet3 = command.ExecuteNonQuery() > 0 ? true : false;
				sqlConnection.Close();
				
				if (sqlConnection.State != System.Data.ConnectionState.Open)
					sqlConnection.Open();
				
				//xoá liên kết tại bảng ChiTiet_HoaDonBanSach
				command = new SqlCommand("delete ChiTiet_HoaDonBanSach where id_tblSach = @id", sqlConnection);
				command.Parameters.AddWithValue("@id", record.id);
				bool xoaLienKet4 = command.ExecuteNonQuery() > 0 ? true : false;
				sqlConnection.Close();
				
				if (sqlConnection.State != System.Data.ConnectionState.Open)
					sqlConnection.Open();
				
				//xoá liên kết tại bảng BaoCaoTon
				command = new SqlCommand("delete BaoCaoTon where id_tblSach = @id", sqlConnection);
				command.Parameters.AddWithValue("@id", record.id);
				bool xoaLienKet5 = command.ExecuteNonQuery() > 0 ? true : false;
				sqlConnection.Close();
				
				if (sqlConnection.State != System.Data.ConnectionState.Open)
					sqlConnection.Open();
				
                
                // chạy lệnh xoá bản ghi hiện tại
                command = new SqlCommand("delete tblSach where id = @id", sqlConnection);
                
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