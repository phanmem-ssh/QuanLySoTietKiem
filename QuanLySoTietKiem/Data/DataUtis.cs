using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLySoTietKiem.Data
{
   public  class DataUtis
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"Data Source=DESKTOP-5K9Q97J;Initial Catalog=QuanLyTienTietKiem;Integrated Security=True";

         
            SqlConnection cnn = new SqlConnection(datasource);
            return cnn;
        }
    }
}
