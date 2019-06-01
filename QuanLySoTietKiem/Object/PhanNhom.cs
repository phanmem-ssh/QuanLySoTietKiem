using System;
using System.Collections.Generic;
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
          return  Data.Query.TenTraVe(this.MaNV, "MaNV", "PHAN_NHOM", "NHAN_VIEN", "HoTen");

        }
        public string getNhomNguoiDung()
        {
            return Data.Query.TenTraVe(MaNhomNguoiDung, "MaNhomNguoiDung", "PHAN_NHOM", "NHOM_NGUOI_DUNG", "TenNhomNguoiDung");

        }
        public void XuatNhapLieu(ref TextBox MaNV,ref TextBox TenNV,ref ComboBox cbbNhomNguoiDung)
        {
            MaNV.Text = this.MaNV;
            TenNV.Text = this.getHoTen();
            cbbNhomNguoiDung.DataSource = Data.Query.LayDuLieu("NHOM_NGUOI_DUNG");
            cbbNhomNguoiDung.DisplayMember = "TenNhomNguoiDung";
            cbbNhomNguoiDung.ValueMember = "MaNhomNguoiDung";
            cbbNhomNguoiDung.SelectedValue = this.MaNhomNguoiDung;
        }
    }
}
