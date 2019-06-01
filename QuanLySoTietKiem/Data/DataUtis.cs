using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySoTietKiem.Data
{
   public  class DataUtis
    {
        public static SqlConnection GetDBConnection()
        {
            // string datasource = @"Data Source=DESKTOP-KOVAAEG;Initial Catalog=QuanLyTienTietKiem;Integrated Security=True ";
            string datasource = @"Data Source=DESKTOP-B0GGMVC\SQLEXPRESS;Initial Catalog=QuanLyTienTietKiem;Integrated Security=True";

            SqlConnection cnn=null;
            try
            {
                cnn = new SqlConnection(datasource);
            }
            catch (Exception e)
            {
                MessageBox.Show("Loi ket noi data: " + e);
            }

        
            return cnn;
        }
    }
}
