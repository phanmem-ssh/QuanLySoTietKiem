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
    class QueryPhGD
    {
        public static int ThemPhongGiaoDich(Object.PhongGiaoDich pgd)
        {
            int ok = -1;
            SqlConnection cnn = Data.DataUtis.GetDBConnection();
            cnn.Open();
            try
            { 
                string sql = "Insert into PHONG_GIAO_DICH (MaPhongGiaoDich, TenPhong, DiaDiem, DienThoai) "
                + " values (@txtMaPhong, @txtTenPhong, @txtDiaDiem, @txtDienThoai) ";

                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = sql;

                // DateTime myDate = DateTime.ParseExact(pgd.getNgayCap(), "dd/MM/yyyy", null);

                // Thêm tham số @MaKH
                cmd.Parameters.Add("@txtMaPhong", SqlDbType.VarChar).Value = pgd.getMaPGD();
                cmd.Parameters.Add("@txtTenPhong", SqlDbType.NVarChar).Value = pgd.getTenPGD();
                cmd.Parameters.Add("@txtDiaDiem", SqlDbType.NVarChar).Value = pgd.getDiaDiem();
                cmd.Parameters.Add("@txtDienThoai", SqlDbType.VarChar).Value = pgd.getSDT();
                

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
        
    }
}
