using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySoTietKiem
{
    public partial class UCKhachHang : UserControl
    {
        public UCKhachHang()
        {
            InitializeComponent();

            dataGridKhachhang.DataSource = Data.Query.LayDuLieu("KHACH_HANG");
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnThemKH_Click(object sender, EventArgs e)
        {
            Object.KhachHang KhachHangMoi = new Object.KhachHang();
            KhachHangMoi.setMaKH(txtMAKH.Text);
            KhachHangMoi.setDiaChi(txtDiaChi.Text);
            KhachHangMoi.setCmnd(txtCMND.Text);
            KhachHangMoi.setNoiCap(txtNoiCap.Text);
            KhachHangMoi.setNgayCap(dateNgayCap.Text.ToString());
            KhachHangMoi.setTen(txtHoten.Text);
            KhachHangMoi.setSdt(txtSDT.Text);

            MessageBox.Show(Data.Query.ThemKhachHang(KhachHangMoi).ToString());


            dataGridKhachhang.DataSource = Data.Query.LayDuLieu("KHACH_HANG");
            dataGridKhachhang.Refresh();
        }
    }
}
