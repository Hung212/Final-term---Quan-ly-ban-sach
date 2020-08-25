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
    public class repo_tblKhachHang : Restful<tblKhachHang>
    {
        SqlDataReader reader;
        SqlConnection sqlConnection;
        public repo_tblKhachHang()
        {
            sqlConnection = Connection.GetSqlConnection;
        }
        
        public tblKhachHang Find(tblKhachHang record)
        {
            string errorMessage = null;
            try
            {
                
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNulltenKhachHang = record.tenKhachHang != null ? true : false;
				bool iNulldiaChi = record.diaChi != null ? true : false;
				bool iNulldienThoai = record.dienThoai != null ? true : false;
				bool iNullemail = record.email != null ? true : false;
				
                
                SqlCommand command;
                tblKhachHang result;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select top 1 * from tblKhachHang where id = @id", sqlConnection);
                if(iNullid) command.Parameters.AddWithValue("@id", record.id);
				
                
                reader = command.ExecuteReader();
                result = new tblKhachHang();
                
                if(reader.Read())
                {
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.tenKhachHang = (reader["tenKhachHang"] == null ? null : (string)(reader["tenKhachHang"]));
						result.diaChi = (reader["diaChi"] == null ? null : (string)(reader["diaChi"]));
						result.dienThoai = (reader["dienThoai"] == null ? null : (string)(reader["dienThoai"]));
						result.email = (reader["email"] == null ? null : (string)(reader["email"]));
						
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
        
        public IEnumerable<tblKhachHang> FindAll()
        {
            string errorMessage = null;
            try
            {
                SqlCommand command;
                List<tblKhachHang> lResult;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select * from tblKhachHang", sqlConnection);
                
                reader = command.ExecuteReader();
                lResult = new List<tblKhachHang>();
                
                while(reader.Read())
                {
                    tblKhachHang result = new tblKhachHang();
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.tenKhachHang = (reader["tenKhachHang"] == null ? null : (string)(reader["tenKhachHang"]));
						result.diaChi = (reader["diaChi"] == null ? null : (string)(reader["diaChi"]));
						result.dienThoai = (reader["dienThoai"] == null ? null : (string)(reader["dienThoai"]));
						result.email = (reader["email"] == null ? null : (string)(reader["email"]));
						
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
        
        public bool Create(tblKhachHang record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNulltenKhachHang = record.tenKhachHang != null ? true : false;
				bool iNulldiaChi = record.diaChi != null ? true : false;
				bool iNulldienThoai = record.dienThoai != null ? true : false;
				bool iNullemail = record.email != null ? true : false;
				
                
                // Đầu tiên phải kiểm tra xem cột giá trị có = null không, nếu bằng null thì loại bỏ khỏi lệnh insert

                string caulenhinsert = "insert into tblKhachHang (#danhSachCot) values (#danhSachGiaTri)";
                List<string> danhSachCot = new List<string>();
                List<string> danhSachGiaTri = new List<string>();
                
                // khoá chính id tự sinh, chỉ chỉnh sửa nếu cần thiết
				
				// danhSachCot.Add(iNullid ? "id" : null);
				// danhSachGiaTri.Add(iNullid ? "@id" : null);
				
                // Normal key
				// gán danh sách cột
				// tenKhachHang
				danhSachCot.Add(iNulltenKhachHang ? "tenKhachHang" : null);
				// diaChi
				danhSachCot.Add(iNulldiaChi ? "diaChi" : null);
				// dienThoai
				danhSachCot.Add(iNulldienThoai ? "dienThoai" : null);
				// email
				danhSachCot.Add(iNullemail ? "email" : null);
				
                // gán danh sách giá trị
				// tenKhachHang
				danhSachGiaTri.Add(iNulltenKhachHang ? "@tenKhachHang" : null);
				// diaChi
				danhSachGiaTri.Add(iNulldiaChi ? "@diaChi" : null);
				// dienThoai
				danhSachGiaTri.Add(iNulldienThoai ? "@dienThoai" : null);
				// email
				danhSachGiaTri.Add(iNullemail ? "@email" : null);
				
                
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
				
                if(iNulltenKhachHang) command.Parameters.AddWithValue("@tenKhachHang", record.tenKhachHang);
				if(iNulldiaChi) command.Parameters.AddWithValue("@diaChi", record.diaChi);
				if(iNulldienThoai) command.Parameters.AddWithValue("@dienThoai", record.dienThoai);
				if(iNullemail) command.Parameters.AddWithValue("@email", record.email);
				

                // trả về true nếu thực hiện lệnh được. Các trường hợp khác, trả về false.
                bool result = command.ExecuteNonQuery() > 0 ? true : false;

                sqlConnection.Close();
                return result;
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close(); }
            
            return false;
        }
        
        public bool Update(tblKhachHang record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNulltenKhachHang = record.tenKhachHang != null ? true : false;
				bool iNulldiaChi = record.diaChi != null ? true : false;
				bool iNulldienThoai = record.dienThoai != null ? true : false;
				bool iNullemail = record.email != null ? true : false;
				
                
                // Đầu tiên phải kiểm tra xem cột giá trị có = null không, nếu bằng null thì loại bỏ khỏi lệnh update
                
                string caulenhupdate = "update tblKhachHang set #danhSachCot where id = @id";
                string dsCotString = null;
                List<string> danhSachCot = new List<string>();
                
                // Normal key
				// gán danh sách cột
				// tenKhachHang
				danhSachCot.Add(iNulltenKhachHang ? "tenKhachHang" : null);
				// diaChi
				danhSachCot.Add(iNulldiaChi ? "diaChi" : null);
				// dienThoai
				danhSachCot.Add(iNulldienThoai ? "dienThoai" : null);
				// email
				danhSachCot.Add(iNullemail ? "email" : null);
				
                
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
                
                if(iNulltenKhachHang) command.Parameters.AddWithValue("@tenKhachHang", record.tenKhachHang);
				if(iNulldiaChi) command.Parameters.AddWithValue("@diaChi", record.diaChi);
				if(iNulldienThoai) command.Parameters.AddWithValue("@dienThoai", record.dienThoai);
				if(iNullemail) command.Parameters.AddWithValue("@email", record.email);
				
                if(iNullid) command.Parameters.AddWithValue("@id", record.id);
				
                
                bool result = command.ExecuteNonQuery() > 0 ? true : false;
                
                sqlConnection.Close();
                return result;
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close(); }
            return false;
        }
        
        public bool Delete(tblKhachHang record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNulltenKhachHang = record.tenKhachHang != null ? true : false;
				bool iNulldiaChi = record.diaChi != null ? true : false;
				bool iNulldienThoai = record.dienThoai != null ? true : false;
				bool iNullemail = record.email != null ? true : false;
				
                
                SqlCommand command;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                // xoá các bảng liên kết đến cột hiện tại
				
				//xoá liên kết tại bảng ChiTiet_HoaDonBanSach
				command = new SqlCommand("delete ChiTiet_HoaDonBanSach where id_tblKhachHang = @id", sqlConnection);
				command.Parameters.AddWithValue("@id", record.id);
				bool xoaLienKet1 = command.ExecuteNonQuery() > 0 ? true : false;
				sqlConnection.Close();
				
				if (sqlConnection.State != System.Data.ConnectionState.Open)
					sqlConnection.Open();
				
				//xoá liên kết tại bảng BaoCaoCongNo
				command = new SqlCommand("delete BaoCaoCongNo where id_tblKhachHang = @id", sqlConnection);
				command.Parameters.AddWithValue("@id", record.id);
				bool xoaLienKet2 = command.ExecuteNonQuery() > 0 ? true : false;
				sqlConnection.Close();
				
				if (sqlConnection.State != System.Data.ConnectionState.Open)
					sqlConnection.Open();
				
                
                // chạy lệnh xoá bản ghi hiện tại
                command = new SqlCommand("delete tblKhachHang where id = @id", sqlConnection);
                
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