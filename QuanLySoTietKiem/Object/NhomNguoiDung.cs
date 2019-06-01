using System;
using System.Collections.Generic;
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
    }
}
