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
    public class repo_BaoCaoTon : Restful<BaoCaoTon>
    {
        SqlDataReader reader;
        SqlConnection sqlConnection;
        public repo_BaoCaoTon()
        {
            sqlConnection = Connection.GetSqlConnection;
        }
        
        public BaoCaoTon Find(BaoCaoTon record)
        {
            string errorMessage = null;
            try
            {
                
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullid_tblSach = record.id_tblSach != null ? true : false;
				bool iNullchiPhi = record.chiPhi != null ? true : false;
				bool iNullngay = record.ngay != null ? true : false;
				bool iNullmoTa = record.moTa != null ? true : false;
				
                
                SqlCommand command;
                BaoCaoTon result;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select t1.id, t1.id_tblSach, t2.tenSach, t1.moTa, t1.ngay, t1.chiPhi from BaoCaoTon t1, tblSach t2 where t1.id_tblSach = t2.id and t1.id = @id", sqlConnection);
                if(iNullid) command.Parameters.AddWithValue("@id", record.id);
				
                
                reader = command.ExecuteReader();
                result = new BaoCaoTon();
                
                if(reader.Read())
                {
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.id_tblSach = (reader["id_tblSach"] == null ? null : (int?)int.Parse(reader["id_tblSach"].ToString()));
						result.chiPhi = (reader["chiPhi"] == null ? null : (int?)int.Parse(reader["chiPhi"].ToString()));
						result.ngay = (reader["ngay"] == null ? null : (DateTime?)DateTime.Parse(reader["ngay"].ToString()));
						result.moTa = (reader["moTa"] == null ? null : (string)(reader["moTa"]));
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
        
        public IEnumerable<BaoCaoTon> FindAll()
        {
            string errorMessage = null;
            try
            {
                SqlCommand command;
                List<BaoCaoTon> lResult;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                command = new SqlCommand("select t1.id, t1.id_tblSach, t2.tenSach, t1.moTa, t1.ngay, t1.chiPhi from BaoCaoTon t1, tblSach t2 where t1.id_tblSach = t2.id", sqlConnection);
                
                reader = command.ExecuteReader();
                lResult = new List<BaoCaoTon>();
                
                while(reader.Read())
                {
                    BaoCaoTon result = new BaoCaoTon();
                    try
                    {
                        result.id = int.Parse(reader["id"].ToString());
						result.id_tblSach = (reader["id_tblSach"] == null ? null : (int?)int.Parse(reader["id_tblSach"].ToString()));
						result.chiPhi = (reader["chiPhi"] == null ? null : (int?)int.Parse(reader["chiPhi"].ToString()));
						result.ngay = (reader["ngay"] == null ? null : (DateTime?)DateTime.Parse(reader["ngay"].ToString()));
						result.moTa = (reader["moTa"] == null ? null : (string)(reader["moTa"]));
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
        
        public bool Create(BaoCaoTon record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullid_tblSach = record.id_tblSach != null ? true : false;
				bool iNullchiPhi = record.chiPhi != null ? true : false;
				bool iNullngay = record.ngay != null ? true : false;
				bool iNullmoTa = record.moTa != null ? true : false;
				
                
                // Đầu tiên phải kiểm tra xem cột giá trị có = null không, nếu bằng null thì loại bỏ khỏi lệnh insert

                string caulenhinsert = "insert into BaoCaoTon (#danhSachCot) values (#danhSachGiaTri)";
                List<string> danhSachCot = new List<string>();
                List<string> danhSachGiaTri = new List<string>();
                
                // khoá chính id tự sinh, chỉ chỉnh sửa nếu cần thiết
				
				// danhSachCot.Add(iNullid ? "id" : null);
				// danhSachGiaTri.Add(iNullid ? "@id" : null);
				
                // Normal key
				// gán danh sách cột
				// id_tblSach
				danhSachCot.Add(iNullid_tblSach ? "id_tblSach" : null);
				// chiPhi
				danhSachCot.Add(iNullchiPhi ? "chiPhi" : null);
				// ngay
				danhSachCot.Add(iNullngay ? "ngay" : null);
				// moTa
				danhSachCot.Add(iNullmoTa ? "moTa" : null);
				
                // gán danh sách giá trị
				// id_tblSach
				danhSachGiaTri.Add(iNullid_tblSach ? "@id_tblSach" : null);
				// chiPhi
				danhSachGiaTri.Add(iNullchiPhi ? "@chiPhi" : null);
				// ngay
				danhSachGiaTri.Add(iNullngay ? "@ngay" : null);
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
				
                if(iNullid_tblSach) command.Parameters.AddWithValue("@id_tblSach", record.id_tblSach);
				if(iNullchiPhi) command.Parameters.AddWithValue("@chiPhi", record.chiPhi);
				if(iNullngay) command.Parameters.AddWithValue("@ngay", record.ngay);
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
        
        public bool Update(BaoCaoTon record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullid_tblSach = record.id_tblSach != null ? true : false;
				bool iNullchiPhi = record.chiPhi != null ? true : false;
				bool iNullngay = record.ngay != null ? true : false;
				bool iNullmoTa = record.moTa != null ? true : false;
				
                
                // Đầu tiên phải kiểm tra xem cột giá trị có = null không, nếu bằng null thì loại bỏ khỏi lệnh update
                
                string caulenhupdate = "update BaoCaoTon set #danhSachCot where id = @id";
                string dsCotString = null;
                List<string> danhSachCot = new List<string>();
                
                // Normal key
				// gán danh sách cột
				// id_tblSach
				danhSachCot.Add(iNullid_tblSach ? "id_tblSach" : null);
				// chiPhi
				danhSachCot.Add(iNullchiPhi ? "chiPhi" : null);
				// ngay
				danhSachCot.Add(iNullngay ? "ngay" : null);
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
                
                if(iNullid_tblSach) command.Parameters.AddWithValue("@id_tblSach", record.id_tblSach);
				if(iNullchiPhi) command.Parameters.AddWithValue("@chiPhi", record.chiPhi);
				if(iNullngay) command.Parameters.AddWithValue("@ngay", record.ngay);
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
        
        public bool Delete(BaoCaoTon record)
        {
            try
            {
                bool iNullid = record.id != null ? true : false;
				// Nếu khoá chính truyền vào null thì sẽ trả về null hoặc false
				// if(!iNullid)
					// return null;
				
                bool iNullid_tblSach = record.id_tblSach != null ? true : false;
				bool iNullchiPhi = record.chiPhi != null ? true : false;
				bool iNullngay = record.ngay != null ? true : false;
				bool iNullmoTa = record.moTa != null ? true : false;
				
                
                SqlCommand command;
                
                if (sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();
                
                
                
                // chạy lệnh xoá bản ghi hiện tại
                command = new SqlCommand("delete BaoCaoTon where id = @id", sqlConnection);
                
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