using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.Data
{
    class ReadInfoData
    {
        private static string path = "Connection.xml";

        public static string StringData()
        {
            string r="";
            try
            {
                

                DataSet dataSet = new DataSet();
                dataSet.ReadXml(path);
                DataTable dt = new DataTable();
                dt = dataSet.Tables["config"];
               
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    r += dr["servername"].ToString();
                    r +=dr["username"].ToString();
  
                    i++;
                }
            }
            catch (Exception)
            {

            }

            return r;
        }
    }
}
