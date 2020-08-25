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
    public class repo_BaoCaoCongNo : Restful<BaoCaoCongNo>
    {
        SqlDataReader reader;
        SqlConnection sqlConnection;
        public repo_BaoCaoCongNo()
        {
            sqlConnection = Connection.GetSqlConnection;
        }
        
        public BaoCaoCongNo Find(BaoCaoCongNo record)
        {
            string errorMessage = null;
            try
            {
                
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullid_tblKhachHang = record.id_tblKhachHang != null ? true : false;
				bool iNullnoTien = record.noTien != null ? true : false;
				bool iNullngayNo = record.ngayNo != null ? true : false;
				bool iNullmoTa = record.moTa != null ? true : false;
				
                
                SqlCommand command;
                BaoCaoCongNo result;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select t1.id, t1.id_tblKhachHang, t2.tenKhachHang, t2.dienThoai, t1.moTa, t1.noTien, t1.ngayNo from BaoCaoCongNo t1, tblKhachHang t2 where t1.id_tblKhachHang = t2.id and t1.id = @id", sqlConnection);
                if(iNullid) command.Parameters.AddWithValue("@id", record.id);
				
                
                reader = command.ExecuteReader();
                result = new BaoCaoCongNo();
                
                if(reader.Read())
                {
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.id_tblKhachHang = (reader["id_tblKhachHang"] == null ? null : (int?)int.Parse(reader["id_tblKhachHang"].ToString()));
						result.noTien = (reader["noTien"] == null ? null : (int?)int.Parse(reader["noTien"].ToString()));
						result.ngayNo = (reader["ngayNo"] == null ? null : (DateTime?)DateTime.Parse(reader["ngayNo"].ToString()));
						result.moTa = (reader["moTa"] == null ? null : (string)(reader["moTa"]));
						result.tenKhachHang = (reader["tenKhachHang"] == null ? null : (string)(reader["tenKhachHang"]));
						result.dienThoai = (reader["dienThoai"] == null ? null : (string)(reader["dienThoai"]));
						
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
        
        public IEnumerable<BaoCaoCongNo> FindAll()
        {
            string errorMessage = null;
            try
            {
                SqlCommand command;
                List<BaoCaoCongNo> lResult;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select t1.id, t1.id_tblKhachHang, t2.tenKhachHang, t2.dienThoai, t1.moTa, t1.noTien, t1.ngayNo from BaoCaoCongNo t1, tblKhachHang t2 where t1.id_tblKhachHang = t2.id", sqlConnection);
                
                reader = command.ExecuteReader();
                lResult = new List<BaoCaoCongNo>();
                
                while(reader.Read())
                {
                    BaoCaoCongNo result = new BaoCaoCongNo();
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.id_tblKhachHang = (reader["id_tblKhachHang"] == null ? null : (int?)int.Parse(reader["id_tblKhachHang"].ToString()));
						result.noTien = (reader["noTien"] == null ? null : (int?)int.Parse(reader["noTien"].ToString()));
						result.ngayNo = (reader["ngayNo"] == null ? null : (DateTime?)DateTime.Parse(reader["ngayNo"].ToString()));
						result.moTa = (reader["moTa"] == null ? null : (string)(reader["moTa"]));
                        result.tenKhachHang = (reader["tenKhachHang"] == null ? null : (string)(reader["tenKhachHang"]));
                        result.dienThoai = (reader["dienThoai"] == null ? null : (string)(reader["dienThoai"]));

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
        
        public bool Create(BaoCaoCongNo record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullid_tblKhachHang = record.id_tblKhachHang != null ? true : false;
				bool iNullnoTien = record.noTien != null ? true : false;
				bool iNullngayNo = record.ngayNo != null ? true : false;
				bool iNullmoTa = record.moTa != null ? true : false;
				
                
                // Đầu tiên phải kiểm tra xem cột giá trị có = null không, nếu bằng null thì loại bỏ khỏi lệnh insert

                string caulenhinsert = "insert into BaoCaoCongNo (#danhSachCot) values (#danhSachGiaTri)";
                List<string> danhSachCot = new List<string>();
                List<string> danhSachGiaTri = new List<string>();
                
                // khoá chính id tự sinh, chỉ chỉnh sửa nếu cần thiết
				
				// danhSachCot.Add(iNullid ? "id" : null);
				// danhSachGiaTri.Add(iNullid ? "@id" : null);
				
                // Normal key
				// gán danh sách cột
				// id_tblKhachHang
				danhSachCot.Add(iNullid_tblKhachHang ? "id_tblKhachHang" : null);
				// noTien
				danhSachCot.Add(iNullnoTien ? "noTien" : null);
				// ngayNo
				danhSachCot.Add(iNullngayNo ? "ngayNo" : null);
				// moTa
				danhSachCot.Add(iNullmoTa ? "moTa" : null);
				
                // gán danh sách giá trị
				// id_tblKhachHang
				danhSachGiaTri.Add(iNullid_tblKhachHang ? "@id_tblKhachHang" : null);
				// noTien
				danhSachGiaTri.Add(iNullnoTien ? "@noTien" : null);
				// ngayNo
				danhSachGiaTri.Add(iNullngayNo ? "@ngayNo" : null);
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
				
                if(iNullid_tblKhachHang) command.Parameters.AddWithValue("@id_tblKhachHang", record.id_tblKhachHang);
				if(iNullnoTien) command.Parameters.AddWithValue("@noTien", record.noTien);
				if(iNullngayNo) command.Parameters.AddWithValue("@ngayNo", record.ngayNo);
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
        
        public bool Update(BaoCaoCongNo record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullid_tblKhachHang = record.id_tblKhachHang != null ? true : false;
				bool iNullnoTien = record.noTien != null ? true : false;
				bool iNullngayNo = record.ngayNo != null ? true : false;
				bool iNullmoTa = record.moTa != null ? true : false;
				
                
                // Đầu tiên phải kiểm tra xem cột giá trị có = null không, nếu bằng null thì loại bỏ khỏi lệnh update
                
                string caulenhupdate = "update BaoCaoCongNo set #danhSachCot where id = @id";
                string dsCotString = null;
                List<string> danhSachCot = new List<string>();
                
                // Normal key
				// gán danh sách cột
				// id_tblKhachHang
				danhSachCot.Add(iNullid_tblKhachHang ? "id_tblKhachHang" : null);
				// noTien
				danhSachCot.Add(iNullnoTien ? "noTien" : null);
				// ngayNo
				danhSachCot.Add(iNullngayNo ? "ngayNo" : null);
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
                
                if(iNullid_tblKhachHang) command.Parameters.AddWithValue("@id_tblKhachHang", record.id_tblKhachHang);
				if(iNullnoTien) command.Parameters.AddWithValue("@noTien", record.noTien);
				if(iNullngayNo) command.Parameters.AddWithValue("@ngayNo", record.ngayNo);
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
        
        public bool Delete(BaoCaoCongNo record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullid_tblKhachHang = record.id_tblKhachHang != null ? true : false;
				bool iNullnoTien = record.noTien != null ? true : false;
				bool iNullngayNo = record.ngayNo != null ? true : false;
				bool iNullmoTa = record.moTa != null ? true : false;
				
                
                SqlCommand command;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                
                
                // chạy lệnh xoá bản ghi hiện tại
                command = new SqlCommand("delete BaoCaoCongNo where id = @id", sqlConnection);
                
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