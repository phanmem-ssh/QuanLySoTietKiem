using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.Object
{
   public class Nguoi
    {
        protected string ten;
        protected string cmnd;
        protected string ngaycap;
        protected string noicap;
        protected string diachi;
        protected string sdt;

        public string getTen()
        {
            return ten;
        }
        public string getCmnd()
        {
            return cmnd;
        }
        public string getNgayCap()
        {
            return ngaycap;
        }
        public string getNoiCap()
        {
            return noicap;
        }
        public string getDiaChi()
        {
            return diachi;
        }
        public string getSdt()
        {
            return sdt;
        }

        public void setTen(string ten)
        {
            this.ten = ten;
        }
        public void setCmnd(string cmnd)
        {
            this.cmnd = cmnd;
        }
        public void setNgayCap(string ngaycap)
        {
            this.ngaycap=ngaycap;
        }
        public void setNoiCap(string noicap)
        {
            this.noicap=noicap;
        }
        public void setDiaChi(string diachi)
        {
            this.diachi=diachi;
        }
        public void setSdt(string sdt)
        {
            this.sdt=sdt;
        }
    }
}
