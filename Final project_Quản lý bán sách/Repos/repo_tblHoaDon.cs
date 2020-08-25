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
    public class repo_tblHoaDon : Restful<tblHoaDon>
    {
        SqlDataReader reader;
        SqlConnection sqlConnection;
        public repo_tblHoaDon()
        {
            sqlConnection = Connection.GetSqlConnection;
        }
        
        public tblHoaDon Find(tblHoaDon record)
        {
            string errorMessage = null;
            try
            {
                
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullngayTao = record.ngayTao != null ? true : false;
				bool iNulltenNhanVien = record.tenNhanVien != null ? true : false;
				bool iNulltongTien = record.tongTien != null ? true : false;
				
                
                SqlCommand command;
                tblHoaDon result;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select top 1 * from tblHoaDon where id = @id", sqlConnection);
                if(iNullid) command.Parameters.AddWithValue("@id", record.id);
				
                
                reader = command.ExecuteReader();
                result = new tblHoaDon();
                
                if(reader.Read())
                {
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.ngayTao = (reader["ngayTao"] == null ? null : (DateTime?)DateTime.Parse(reader["ngayTao"].ToString()));
						result.tenNhanVien = (reader["tenNhanVien"] == null ? null : (string)(reader["tenNhanVien"]));
						result.tongTien = (reader["tongTien"] == null ? null : (int?)int.Parse(reader["tongTien"].ToString()));
						
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
        
        public IEnumerable<tblHoaDon> FindAll()
        {
            string errorMessage = null;
            try
            {
                SqlCommand command;
                List<tblHoaDon> lResult;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select * from tblHoaDon", sqlConnection);
                
                reader = command.ExecuteReader();
                lResult = new List<tblHoaDon>();
                
                while(reader.Read())
                {
                    tblHoaDon result = new tblHoaDon();
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.ngayTao = (reader["ngayTao"] == null ? null : (DateTime?)DateTime.Parse(reader["ngayTao"].ToString()));
						result.tenNhanVien = (reader["tenNhanVien"] == null ? null : (string)(reader["tenNhanVien"]));
						result.tongTien = (reader["tongTien"] == null ? null : (int?)int.Parse(reader["tongTien"].ToString()));
						
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
        
        public bool Create(tblHoaDon record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullngayTao = record.ngayTao != null ? true : false;
				bool iNulltenNhanVien = record.tenNhanVien != null ? true : false;
				bool iNulltongTien = record.tongTien != null ? true : false;
				
                
                // Đầu tiên phải kiểm tra xem cột giá trị có = null không, nếu bằng null thì loại bỏ khỏi lệnh insert

                string caulenhinsert = "insert into tblHoaDon (#danhSachCot) values (#danhSachGiaTri)";
                List<string> danhSachCot = new List<string>();
                List<string> danhSachGiaTri = new List<string>();
                
                // khoá chính id tự sinh, chỉ chỉnh sửa nếu cần thiết
				
				// danhSachCot.Add(iNullid ? "id" : null);
				// danhSachGiaTri.Add(iNullid ? "@id" : null);
				
                // Normal key
				// gán danh sách cột
				// ngayTao
				danhSachCot.Add(iNullngayTao ? "ngayTao" : null);
				// tenNhanVien
				danhSachCot.Add(iNulltenNhanVien ? "tenNhanVien" : null);
				// tongTien
				danhSachCot.Add(iNulltongTien ? "tongTien" : null);
				
                // gán danh sách giá trị
				// ngayTao
				danhSachGiaTri.Add(iNullngayTao ? "@ngayTao" : null);
				// tenNhanVien
				danhSachGiaTri.Add(iNulltenNhanVien ? "@tenNhanVien" : null);
				// tongTien
				danhSachGiaTri.Add(iNulltongTien ? "@tongTien" : null);
				
                
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
				
                if(iNullngayTao) command.Parameters.AddWithValue("@ngayTao", record.ngayTao);
				if(iNulltenNhanVien) command.Parameters.AddWithValue("@tenNhanVien", record.tenNhanVien);
				if(iNulltongTien) command.Parameters.AddWithValue("@tongTien", record.tongTien);
				

                // trả về true nếu thực hiện lệnh được. Các trường hợp khác, trả về false.
                bool result = command.ExecuteNonQuery() > 0 ? true : false;

                sqlConnection.Close();
                return result;
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close(); }
            
            return false;
        }
        
        public bool Update(tblHoaDon record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullngayTao = record.ngayTao != null ? true : false;
				bool iNulltenNhanVien = record.tenNhanVien != null ? true : false;
				bool iNulltongTien = record.tongTien != null ? true : false;
				
                
                // Đầu tiên phải kiểm tra xem cột giá trị có = null không, nếu bằng null thì loại bỏ khỏi lệnh update
                
                string caulenhupdate = "update tblHoaDon set #danhSachCot where id = @id";
                string dsCotString = null;
                List<string> danhSachCot = new List<string>();
                
                // Normal key
				// gán danh sách cột
				// ngayTao
				danhSachCot.Add(iNullngayTao ? "ngayTao" : null);
				// tenNhanVien
				danhSachCot.Add(iNulltenNhanVien ? "tenNhanVien" : null);
				// tongTien
				danhSachCot.Add(iNulltongTien ? "tongTien" : null);
				
                
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
                
                if(iNullngayTao) command.Parameters.AddWithValue("@ngayTao", record.ngayTao);
				if(iNulltenNhanVien) command.Parameters.AddWithValue("@tenNhanVien", record.tenNhanVien);
				if(iNulltongTien) command.Parameters.AddWithValue("@tongTien", record.tongTien);
				
                if(iNullid) command.Parameters.AddWithValue("@id", record.id);
				
                
                bool result = command.ExecuteNonQuery() > 0 ? true : false;
                
                sqlConnection.Close();
                return result;
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close(); }
            return false;
        }
        
        public bool Delete(tblHoaDon record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullngayTao = record.ngayTao != null ? true : false;
				bool iNulltenNhanVien = record.tenNhanVien != null ? true : false;
				bool iNulltongTien = record.tongTien != null ? true : false;
				
                
                SqlCommand command;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                // xoá các bảng liên kết đến cột hiện tại
				
				//xoá liên kết tại bảng ChiTiet_HoaDonBanSach
				command = new SqlCommand("delete ChiTiet_HoaDonBanSach where id_tblHoaDon = @id", sqlConnection);
				command.Parameters.AddWithValue("@id", record.id);
				bool xoaLienKet1 = command.ExecuteNonQuery() > 0 ? true : false;
				sqlConnection.Close();
				
				if (sqlConnection.State != System.Data.ConnectionState.Open)
					sqlConnection.Open();
				
                
                // chạy lệnh xoá bản ghi hiện tại
                command = new SqlCommand("delete tblHoaDon where id = @id", sqlConnection);
                
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