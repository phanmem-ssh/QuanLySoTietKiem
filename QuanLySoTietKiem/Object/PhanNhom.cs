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
    public class PhanNhom
    {
        string maNV;
        string maNhomNguoiDung;

        public string MaNV { get => maNV; set => maNV = value; }
        public string MaNhomNguoiDung { get => maNhomNguoiDung; set => maNhomNguoiDung = value; }

        public string getHoTen()
        {
            return Data.Query.TenTraVe(this.MaNV, "MaNV", "PHAN_NHOM", "NHAN_VIEN", "HoTen");

        }
        public string getNhomNguoiDung()
        {
            return Data.Query.TenTraVe(MaNhomNguoiDung, "MaNhomNguoiDung", "PHAN_NHOM", "NHOM_NGUOI_DUNG", "TenNhomNguoiDung");

        }
        public void XuatNhapLieu(ref TextBox MaNV, ref TextBox TenNV, ref ComboBox cbbNhomNguoiDung)
        {
            MaNV.Text = this.MaNV;
            TenNV.Text = this.getHoTen();
            cbbNhomNguoiDung.DataSource = Data.Query.LayDuLieu("NHOM_NGUOI_DUNG");
            cbbNhomNguoiDung.DisplayMember = "TenNhomNguoiDung";
            cbbNhomNguoiDung.ValueMember = "MaNhomNguoiDung";
            cbbNhomNguoiDung.SelectedValue = this.MaNhomNguoiDung;
        }
        public int ThemData()
        {
            int ok = -1;
            SqlConnection cnn = Data.DataUtis.GetDBConnection();
            cnn.Open();
            try
            {
                string sql = "Insert into PHAN_NHOM(MaNV,MaNhomNguoiDung) "
                + " values (@MaNV, @MaNhomNguoiDung) ";

                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = sql;


                // Thêm tham số @MaKH
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = MaNV;
                cmd.Parameters.Add("@MaNhomNguoiDung", SqlDbType.VarChar).Value = MaNhomNguoiDung;


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
                string sql = "UPDATE PHAN_NHOM SET MaNV = '" + MaNV + "'  WHERE MaNhomNguoiDung = '" + MaNhomNguoiDung + "'";

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
                string sql = "  DELETE FROM PHAN_NHOM WHERE MaNV = '" + MaNV + "' and  MaNhomNguoiDung = '" + MaNhomNguoiDung + "'";

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
