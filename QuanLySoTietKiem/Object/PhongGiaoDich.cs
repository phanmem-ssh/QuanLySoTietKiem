using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.Object
{
    class PhongGiaoDich
    {
        private string MaPGD;
        private string tenPGD;
        private string SDT;
        private string DiaDiem;

        public string getMaPGD()
        {
            return MaPGD;
        }
        public string getTenPGD()
        {
            return tenPGD;
        }
        public string getSDT()
        {
            return SDT;
        }
        public string getDiaDiem()
        {
            return DiaDiem;
        }
        
        public void setMaPGD(string MaPGD)
        {
            this.MaPGD=MaPGD;
        }
        public void setTenPGD(string TenPGD)
        {
            this.tenPGD=TenPGD;
        }
        public void setSDT(string SDT)
        {
            this.SDT=SDT;
        }
        public void setDiaDiem(string DiaDiem)
        {
            this.DiaDiem=DiaDiem;
        }
    }
}
