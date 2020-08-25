using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QLNhaSach.Configs
{
    public class Connection
    {
        // Có thể dùng connectString này nếu không muốn lấy từ app.config
        public static string connectionString { get; private set; } = @"Data Source=.;Initial Catalog=dbQLCuaHangSach;Integrated Security=True";
        
        // connectString này lấy từ app.config
        // public static string connectionString { get; private set; } = System.Configuration.ConfigurationManager.ConnectionStrings["dbQLCuaHangSach"].ConnectionString;
        public static string dataSource { get; private set; } = ".";
        public static string nameDatabase { get; private set; } = "dbQLCuaHangSach";
        static bool iChangeConnection = false;
        
        static Connection()
        {
            iChangeConnection = true;
            Build();
        }
        
        public static bool Build()
        {
            if (iChangeConnection)
            {
                var builder = new System.Data.SqlClient.SqlConnectionStringBuilder(Connection.connectionString);

                dataSource = builder.DataSource;
                nameDatabase = builder.InitialCatalog;

                iChangeConnection = false;
            }

            return !iChangeConnection;
        }

        public static SqlConnection GetSqlConnection
        {
            get { return new SqlConnection(Connection.connectionString); }
        }

        public static void SetConnectionString(string connectionString)
        {
            iChangeConnection = true;
            Connection.connectionString = connectionString;
        }

        // Truyền lệnh vào biến command, truy xuất và trả về kết quả là DataTable
        public static DataTable ExecuteQuery(string command)
        {
            var connect = GetSqlConnection;

            if(connect.State != ConnectionState.Open) connect.Open();

            var adapter = new SqlDataAdapter(command, connect);
            var tableReturn = new DataTable();

            adapter.Fill(tableReturn);

            connect.Close();
            return tableReturn;
        }
    }
}