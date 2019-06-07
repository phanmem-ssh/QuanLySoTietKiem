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
    class NhomNguoiDung
    {
        string maNhomNguoiDung;
        string tenNhomNguoiDung;

        public string MaNhomNguoiDung { get => maNhomNguoiDung; set => maNhomNguoiDung = value; }
        public string TenNhomNguoiDung { get => tenNhomNguoiDung; set => tenNhomNguoiDung = value; }

        public void XuatNhapLieu(ref TextBox txtMaNhom, ref TextBox txtTenNhomNguoiDung)
        {
            txtMaNhom.Text = MaNhomNguoiDung;
            txtTenNhomNguoiDung.Text = TenNhomNguoiDung;
        }
        public int ThemData()
        {
            int ok = -1;
            SqlConnection cnn = Data.DataUtis.GetDBConnection();
            cnn.Open();
            try
            {
                string sql = "Insert into NHOM_NGUOI_DUNG(MaNhomNguoiDung,TenNhomNguoiDung) "
                + " values (@MaNhomNguoiDung, @TenNhomNguoiDung) ";

                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = sql;


                // Thêm tham số @MaKH
                cmd.Parameters.Add("@MaNhomNguoiDung", SqlDbType.VarChar).Value = MaNhomNguoiDung;
                cmd.Parameters.Add("@TenNhomNguoiDung", SqlDbType.NVarChar).Value = TenNhomNguoiDung;


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
                string sql = "UPDATE NHOM_NGUOI_DUNG SET TenNhomNguoiDung = '" + TenNhomNguoiDung + "'  WHERE MaNhomNguoiDung = '" + MaNhomNguoiDung + "'";

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
                string sql = "  DELETE FROM NHOM_NGUOI_DUNG WHERE  MaNhomNguoiDung = '" + MaNhomNguoiDung + "'";

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
