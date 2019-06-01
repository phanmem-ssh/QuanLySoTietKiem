using System;
using System.Collections.Generic;
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
    }
}
