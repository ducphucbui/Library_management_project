using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DoAn_QuanLyThuVien
{
    internal class connection
    {
        private static string stringconnection = @"Data Source=LAPTOP-QG6FDKJC;Initial Catalog=ton;Integrated Security=True;TrustServerCertificate=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringconnection);
        }
    }
}
