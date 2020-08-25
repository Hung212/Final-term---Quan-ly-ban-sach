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
    public class repo_ChiTietHoaDonBanSach : Restful<ChiTietHoaDonBanSach>
    {
        SqlDataReader reader;
        SqlConnection sqlConnection;
        public repo_ChiTietHoaDonBanSach()
        {
            sqlConnection = Connection.GetSqlConnection;
        }
        
        public ChiTietHoaDonBanSach Find(ChiTietHoaDonBanSach record)
        {
            string errorMessage = null;
            try
            {
                
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullid_tblHoaDon = record.id_tblHoaDon != null ? true : false;
				bool iNullid_tblKhachHang = record.id_tblKhachHang != null ? true : false;
				bool iNullid_tblSach = record.id_tblSach != null ? true : false;
				bool iNullsoLuong = record.soLuong != null ? true : false;
				
                
                SqlCommand command;
                ChiTietHoaDonBanSach result;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select top 1 * from ChiTietHoaDonBanSach where id = @id", sqlConnection);
                if(iNullid) command.Parameters.AddWithValue("@id", record.id);
				
                
                reader = command.ExecuteReader();
                result = new ChiTietHoaDonBanSach();
                
                if(reader.Read())
                {
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.id_tblHoaDon = (reader["id_tblHoaDon"] == null ? null : (int?)int.Parse(reader["id_tblHoaDon"].ToString()));
						result.id_tblKhachHang = (reader["id_tblKhachHang"] == null ? null : (int?)int.Parse(reader["id_tblKhachHang"].ToString()));
						result.id_tblSach = (reader["id_tblSach"] == null ? null : (int?)int.Parse(reader["id_tblSach"].ToString()));
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
        
        public IEnumerable<ChiTietHoaDonBanSach> FindAll()
        {
            string errorMessage = null;
            try
            {
                SqlCommand command;
                List<ChiTietHoaDonBanSach> lResult;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select * from ChiTietHoaDonBanSach", sqlConnection);
                
                reader = command.ExecuteReader();
                lResult = new List<ChiTietHoaDonBanSach>();
                
                while(reader.Read())
                {
                    ChiTietHoaDonBanSach result = new ChiTietHoaDonBanSach();
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.id_tblHoaDon = (reader["id_tblHoaDon"] == null ? null : (int?)int.Parse(reader["id_tblHoaDon"].ToString()));
						result.id_tblKhachHang = (reader["id_tblKhachHang"] == null ? null : (int?)int.Parse(reader["id_tblKhachHang"].ToString()));
						result.id_tblSach = (reader["id_tblSach"] == null ? null : (int?)int.Parse(reader["id_tblSach"].ToString()));
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
        
        public bool Create(ChiTietHoaDonBanSach record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullid_tblHoaDon = record.id_tblHoaDon != null ? true : false;
				bool iNullid_tblKhachHang = record.id_tblKhachHang != null ? true : false;
				bool iNullid_tblSach = record.id_tblSach != null ? true : false;
				bool iNullsoLuong = record.soLuong != null ? true : false;
				
                
                // Đầu tiên phải kiểm tra xem cột giá trị có = null không, nếu bằng null thì loại bỏ khỏi lệnh insert

                string caulenhinsert = "insert into ChiTietHoaDonBanSach (#danhSachCot) values (#danhSachGiaTri)";
                List<string> danhSachCot = new List<string>();
                List<string> danhSachGiaTri = new List<string>();
                
                // khoá chính id tự sinh, chỉ chỉnh sửa nếu cần thiết
				
				// danhSachCot.Add(iNullid ? "id" : null);
				// danhSachGiaTri.Add(iNullid ? "@id" : null);
				
                // Normal key
				// gán danh sách cột
				// id_tblHoaDon
				danhSachCot.Add(iNullid_tblHoaDon ? "id_tblHoaDon" : null);
				// id_tblKhachHang
				danhSachCot.Add(iNullid_tblKhachHang ? "id_tblKhachHang" : null);
				// id_tblSach
				danhSachCot.Add(iNullid_tblSach ? "id_tblSach" : null);
				// soLuong
				danhSachCot.Add(iNullsoLuong ? "soLuong" : null);
				
                // gán danh sách giá trị
				// id_tblHoaDon
				danhSachGiaTri.Add(iNullid_tblHoaDon ? "@id_tblHoaDon" : null);
				// id_tblKhachHang
				danhSachGiaTri.Add(iNullid_tblKhachHang ? "@id_tblKhachHang" : null);
				// id_tblSach
				danhSachGiaTri.Add(iNullid_tblSach ? "@id_tblSach" : null);
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
				
                if(iNullid_tblHoaDon) command.Parameters.AddWithValue("@id_tblHoaDon", record.id_tblHoaDon);
				if(iNullid_tblKhachHang) command.Parameters.AddWithValue("@id_tblKhachHang", record.id_tblKhachHang);
				if(iNullid_tblSach) command.Parameters.AddWithValue("@id_tblSach", record.id_tblSach);
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
        
        public bool Update(ChiTietHoaDonBanSach record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullid_tblHoaDon = record.id_tblHoaDon != null ? true : false;
				bool iNullid_tblKhachHang = record.id_tblKhachHang != null ? true : false;
				bool iNullid_tblSach = record.id_tblSach != null ? true : false;
				bool iNullsoLuong = record.soLuong != null ? true : false;
				
                
                // Đầu tiên phải kiểm tra xem cột giá trị có = null không, nếu bằng null thì loại bỏ khỏi lệnh update
                
                string caulenhupdate = "update ChiTietHoaDonBanSach set #danhSachCot where id = @id";
                string dsCotString = null;
                List<string> danhSachCot = new List<string>();
                
                // Normal key
				// gán danh sách cột
				// id_tblHoaDon
				danhSachCot.Add(iNullid_tblHoaDon ? "id_tblHoaDon" : null);
				// id_tblKhachHang
				danhSachCot.Add(iNullid_tblKhachHang ? "id_tblKhachHang" : null);
				// id_tblSach
				danhSachCot.Add(iNullid_tblSach ? "id_tblSach" : null);
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
                
                if(iNullid_tblHoaDon) command.Parameters.AddWithValue("@id_tblHoaDon", record.id_tblHoaDon);
				if(iNullid_tblKhachHang) command.Parameters.AddWithValue("@id_tblKhachHang", record.id_tblKhachHang);
				if(iNullid_tblSach) command.Parameters.AddWithValue("@id_tblSach", record.id_tblSach);
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
        
        public bool Delete(ChiTietHoaDonBanSach record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullid_tblHoaDon = record.id_tblHoaDon != null ? true : false;
				bool iNullid_tblKhachHang = record.id_tblKhachHang != null ? true : false;
				bool iNullid_tblSach = record.id_tblSach != null ? true : false;
				bool iNullsoLuong = record.soLuong != null ? true : false;
				
                
                SqlCommand command;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                
                
                // chạy lệnh xoá bản ghi hiện tại
                command = new SqlCommand("delete ChiTietHoaDonBanSach where id = @id", sqlConnection);
                
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