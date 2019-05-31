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
    public class Query
    {
        public static int ThemKhachHang(Object.KhachHang kh)
        {
            int ok = -1;
            SqlConnection cnn = Data.DataUtis.GetDBConnection();
            cnn.Open();
            try
            {
                string sql = "Insert into KHACH_HANG (MaKH, HoTen, CMND, NgayCap, NoiCap,DiaChi,DienThoai) "
                + " values (@MaKH, @HoTen, @CMND, @NgayCap, @NoiCap,@DiaChi,@DienThoai) ";
          
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = sql;
                
                DateTime myDate = DateTime.ParseExact(kh.getNgayCap(), "dd/MM/yyyy", null);

                // Thêm tham số @MaKH
                cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = kh.getMaKH();
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = kh.getTen();
                cmd.Parameters.Add("@CMND", SqlDbType.VarChar).Value = kh.getCmnd();
                cmd.Parameters.Add("@NgayCap", SqlDbType.DateTime).Value = myDate;
                cmd.Parameters.Add("@NoiCap", SqlDbType.NVarChar).Value = kh.getNoiCap();
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = kh.getDiaChi();
                cmd.Parameters.Add("@DienThoai", SqlDbType.VarChar).Value = kh.getSdt();

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
