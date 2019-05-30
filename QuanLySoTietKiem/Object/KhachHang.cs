namespace QuanLySoTietKiem.Object
{
    public class KhachHang : Object.Nguoi
    {
        private string MaKH;

        public string getMaKH()
        {
            return MaKH;
        }
       
        public void setMaKH(string makh)
        {
            this.MaKH = makh;
        }

    }
}
