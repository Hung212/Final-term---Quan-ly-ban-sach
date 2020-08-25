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
    public class repo_ChiTiet_HoaDonBanSach : Restful<ChiTiet_HoaDonBanSach>
    {
        SqlDataReader reader;
        SqlConnection sqlConnection;
        public repo_ChiTiet_HoaDonBanSach()
        {
            sqlConnection = Connection.GetSqlConnection;
        }
        
        public ChiTiet_HoaDonBanSach Find(ChiTiet_HoaDonBanSach record)
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
                ChiTiet_HoaDonBanSach result;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select t1.id, t1.id_tblHoaDon, t1.id_tblKhachHang, t1.id_tblSach, t1.soLuong, t2.tenKhachHang, t3.tenSach, t4.tenNhanVien, t4.tongTien from ChiTiet_HoaDonBanSach t1, tblKhachHang t2, tblSach t3, tblHoaDon t4 where t1.id_tblHoaDon = t4.id and t1.id_tblKhachHang = t2.id and t1.id_tblSach = t3.id and t1.id = @id", sqlConnection);
                if(iNullid) command.Parameters.AddWithValue("@id", record.id);
				
                
                reader = command.ExecuteReader();
                result = new ChiTiet_HoaDonBanSach();
                
                if(reader.Read())
                {
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.id_tblHoaDon = (reader["id_tblHoaDon"] == null ? null : (int?)int.Parse(reader["id_tblHoaDon"].ToString()));
						result.id_tblKhachHang = (reader["id_tblKhachHang"] == null ? null : (int?)int.Parse(reader["id_tblKhachHang"].ToString()));
						result.id_tblSach = (reader["id_tblSach"] == null ? null : (int?)int.Parse(reader["id_tblSach"].ToString()));
						result.soLuong = (reader["soLuong"] == null ? null : (int?)int.Parse(reader["soLuong"].ToString()));
						result.tongTien = (reader["tongTien"] == null ? null : (int?)int.Parse(reader["tongTien"].ToString()));
                        result.tenNhanVien = (reader["tenNhanVien"] == null ? null : (string)(reader["tenNhanVien"]));
                        result.tenKhachHang = (reader["tenKhachHang"] == null ? null : (string)(reader["tenKhachHang"]));
                        result.tenSach = (reader["tenSach"] == null ? null : (string)(reader["tenSach"]));

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
        
        public IEnumerable<ChiTiet_HoaDonBanSach> FindAll()
        {
            string errorMessage = null;
            try
            {
                SqlCommand command;
                List<ChiTiet_HoaDonBanSach> lResult;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select t1.id, t1.id_tblHoaDon, t1.id_tblKhachHang, t1.id_tblSach, t1.soLuong, t2.tenKhachHang, t3.tenSach, t4.tenNhanVien, t4.tongTien from ChiTiet_HoaDonBanSach t1, tblKhachHang t2, tblSach t3, tblHoaDon t4 where t1.id_tblHoaDon = t4.id and t1.id_tblKhachHang = t2.id and t1.id_tblSach = t3.id", sqlConnection);
                
                reader = command.ExecuteReader();
                lResult = new List<ChiTiet_HoaDonBanSach>();
                
                while(reader.Read())
                {
                    ChiTiet_HoaDonBanSach result = new ChiTiet_HoaDonBanSach();
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.id_tblHoaDon = (reader["id_tblHoaDon"] == null ? null : (int?)int.Parse(reader["id_tblHoaDon"].ToString()));
						result.id_tblKhachHang = (reader["id_tblKhachHang"] == null ? null : (int?)int.Parse(reader["id_tblKhachHang"].ToString()));
						result.id_tblSach = (reader["id_tblSach"] == null ? null : (int?)int.Parse(reader["id_tblSach"].ToString()));
						result.soLuong = (reader["soLuong"] == null ? null : (int?)int.Parse(reader["soLuong"].ToString()));
                        result.tongTien = (reader["tongTien"] == null ? null : (int?)int.Parse(reader["tongTien"].ToString()));
                        result.tenNhanVien = (reader["tenNhanVien"] == null ? null : (string)(reader["tenNhanVien"]));
                        result.tenKhachHang = (reader["tenKhachHang"] == null ? null : (string)(reader["tenKhachHang"]));
                        result.tenSach = (reader["tenSach"] == null ? null : (string)(reader["tenSach"]));
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
        
        public bool Create(ChiTiet_HoaDonBanSach record)
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

                string caulenhinsert = "insert into ChiTiet_HoaDonBanSach (#danhSachCot) values (#danhSachGiaTri)";
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
        
        public bool Update(ChiTiet_HoaDonBanSach record)
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
                
                string caulenhupdate = "update ChiTiet_HoaDonBanSach set #danhSachCot where id = @id";
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
        
        public bool Delete(ChiTiet_HoaDonBanSach record)
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
                command = new SqlCommand("delete ChiTiet_HoaDonBanSach where id = @id", sqlConnection);
                
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