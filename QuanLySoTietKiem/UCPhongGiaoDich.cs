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
    public partial class UCPhongGiaoDich : UserControl
    {
        public UCPhongGiaoDich()
        {
            InitializeComponent();

            dataGridPGD.DataSource = Data.Query.LayDuLieu("PHONG_GIAO_DICH");
        }
    }
}
