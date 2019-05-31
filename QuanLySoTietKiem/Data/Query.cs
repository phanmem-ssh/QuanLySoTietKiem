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
        //Hàm static thêm khách hàng trả về 1 nếu thành công
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
        //Hàm truyền vào Mã chuỗi(Chung),Cột mã(Chung),Tên 2 bảng trả(bang2 chứa tên), Tên cần lấy
        //Trả về tên
        public static string TenTraVe(string Ma, string Cot, string bang1, string bang2, string tenCanLay)
        {
            string valu=null;
            SqlConnection cnn = Data.DataUtis.GetDBConnection();
            cnn.Open();
            try
            {
              // string sql = "select Top 1 "+tenCanLay+" from "+bang1+" , "+bang2+" where ( "+bang1+"."+Cot+" = "+ bang2 + "." + Cot + " and "+bang2+"."+Cot+" = "+ Ma +") ";
                string sql = "select Top 1 "+tenCanLay+ " from " + bang1 + ", " + bang2 + " where (" + bang1 + "." + Cot + " = " + bang2 + "." + Cot + " and " + bang2 + "." + Cot + "='" + Ma + "')";

                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = sql;
              // // cmd.Parameters.Add("@Ma", SqlDbType.VarChar).Value = Ma;
              //  cmd.Parameters.AddWithValue("@Ma", Ma);
              // // cmd.Parameters.Add("@Cot", SqlDbType.VarChar).Value = Cot;
              //  cmd.Parameters.AddWithValue("@Cot", Cot);
              // // cmd.Parameters.Add("@bang1", SqlDbType.VarChar).Value = bang1;
              //  cmd.Parameters.AddWithValue("@bang1", bang1);
              ////  cmd.Parameters.Add("@bang2", SqlDbType.VarChar).Value = bang2;
              //  cmd.Parameters.AddWithValue("@bang2", bang2);
              // // cmd.Parameters.Add("@tenCanLay", SqlDbType.VarChar).Value = tenCanLay;
              //  cmd.Parameters.AddWithValue("@tenCanLay", tenCanLay);

                valu = cmd.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi trả về: " + e);
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
                cnn = null;
            }
            

            return valu;
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
