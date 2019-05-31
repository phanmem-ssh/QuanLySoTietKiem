using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace QuanLySoTietKiem.Data
{
    class QueryPhanQuyen
    {
        public static int ThemNhomNguoiDung(Object.objPhanQuyen pq)
        {
            int ok = -1;
            SqlConnection cnn = Data.DataUtis.GetDBConnection();
            cnn.Open();
            try
            {
                string sql = "Insert into NHOM_NGUOI_DUNG (MaNhomNguoiDung, TenNhomNguoiDung) "
                + " values () ";

                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = sql;

                //DateTime myDate = DateTime.ParseExact(kh.getNgayCap(), "dd/MM/yyyy", null);

                // Thêm tham số @MaKH
                cmd.Parameters.Add("@MaNhomNguoiDung", SqlDbType.VarChar).Value = pq.getManhom();
                cmd.Parameters.Add("@TenNhomNguoiDung", SqlDbType.NVarChar).Value = pq.getTenNhom();
                

                // Thực thi Command (Dùng cho delete, insert, update).
                ok = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e);
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
                cnn = null;
            }
            return ok;
        }
        public static void ThemNhanVien(string Bang, string Item)
        {

        }
        public static void Sua()
        {

        }
        public static DataTable LayDuLieu(string Bang)
        {
            SqlConnection cnn = Data.DataUtis.GetDBConnection();
            cnn.Open();
            string sql = "select * from " + Bang;
            SqlCommand com = new SqlCommand(sql, cnn);
            com.CommandType = System.Data.CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public static void Xoa()
        {

        }
    }
}
}
