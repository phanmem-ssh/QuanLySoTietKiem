using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.Object
{
    class NhanVien:Nguoi
    {
        string MaNV;
        public string getMaNV()
        {
            return MaNV;
        }

        public void setMaNV(string manv)
        {
            this.MaNV = manv;
        }
    }
}
