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
    public partial class UCNhanVien : UserControl
    {
        public UCNhanVien()
        {
            InitializeComponent();

            DataTable data = Data.Query.LayDuLieu("NHAN_VIEN");
            MessageBox.Show(data.Rows[1].ItemArray[3].ToString());

            dataGridViewNhanVien.DataSource = Data.Query.LayDuLieu("NHAN_VIEN");
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
