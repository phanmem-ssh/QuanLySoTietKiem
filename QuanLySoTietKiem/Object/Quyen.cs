using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySoTietKiem.Object
{
    class Quyen
    {
        string maQuyen;
        string tenQuyen;

        public string MaQuyen { get => maQuyen; set => maQuyen = value; }
        public string TenQuyen { get => tenQuyen; set => tenQuyen = value; }

        public void XuatNhapLieu(ref TextBox txtMaQuyen, ref TextBox txtTenQuyen)
        {
            txtMaQuyen.Text = this.maQuyen;
            txtTenQuyen.Text = this.tenQuyen;
        }
        public int ThemData()
        {
            int ok = -1;
            SqlConnection cnn = Data.DataUtis.GetDBConnection();
            cnn.Open();
            try
            {
                string sql = "Insert into QUYEN (MaQuyen,TenQuyen) "
                + " values (@MaQuyen, @TenQuyen) ";

                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = sql;

   
                // Thêm tham số @MaKH
                cmd.Parameters.Add("@MaQuyen", SqlDbType.VarChar).Value = MaQuyen;
                cmd.Parameters.Add("@TenQuyen", SqlDbType.NVarChar).Value = TenQuyen;
              

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
        public int SuaData()
        {
            int ok = -1;
            SqlConnection cnn = Data.DataUtis.GetDBConnection();
            cnn.Open();
            try
            {
                string sql = "UPDATE QUYEN SET TenQuyen = '"+TenQuyen+"'  WHERE MaQuyen = '"+MaQuyen+"'";

                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = sql;


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
        public int XoaData()
        {
            int ok = -1;
            SqlConnection cnn = Data.DataUtis.GetDBConnection();
            cnn.Open();
            try
            {
                string sql = "  DELETE FROM QUYEN WHERE MaQuyen = '" + MaQuyen + "'";

                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = sql;


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
