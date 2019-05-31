using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.Object
{
    class objPhanQuyen
    {
        public string MaNhomNguoiDung;
        public string TenNhomNguoiDung;
        public string MaQuyen;
        public string TenQuyen;
        public string MaNV;
        public string MatKhau;
        public string TenDangNhap;
        public string getManhom()
        {
            return MaNhomNguoiDung;
        }

        public void setMaNhom(string MaNhomNguoiDung)
        {
            this.MaNhomNguoiDung = MaNhomNguoiDung;
        }
        public string getTenNhom()
        {
            return TenNhomNguoiDung;
        }

        public void setTenNhom(string TenNhomNguoiDung)
        {
            this.TenNhomNguoiDung = TenNhomNguoiDung;
        }
        public string getMaQuyen()
        {
            return MaQuyen;
        }

        public void setMaQuyen(string MaQuyen)
        {
            this.MaQuyen = MaQuyen;
        }
        public string getTenQuyen()
        {
            return TenQuyen;
        }

        public void setTebQuyen(string TenQuyen)
        {
            this.TenQuyen = TenQuyen;
        }
        public string getMaNV()
        {
            return MaNV;
        }

        public void setMaNV(string MaNV)
        {
            this.MaNV = MaNV;
        }
        public string getMatKhau()
        {
            return MatKhau;
        }

        public void setMatKhau(string MatKhau)
        {
            this.MatKhau = MatKhau;
        }
        public string getTenDangNhap()
        {
            return TenDangNhap;
        }

        public void setTenDangNhap(string TenDangNhap)
        {
            this.TenDangNhap = TenDangNhap;
        }

    }
}
