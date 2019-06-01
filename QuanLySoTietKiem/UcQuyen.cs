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
    public partial class UCQuyen : UserControl
    {
        public UCQuyen()
        {
            InitializeComponent();

            dataGridQuyen.DataSource = Data.Query.LayDuLieu("QUYEN");
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
