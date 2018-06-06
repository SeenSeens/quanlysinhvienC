using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.View
{
    public partial class fmain : Form
    {
        public fmain()
        {
            InitializeComponent();
        }

        private void mnSinhvien_Click(object sender, EventArgs e)
        {
            fSinhvien sv = new fSinhvien();
            sv.ShowDialog();
        }

        private void mnKhoa_Click(object sender, EventArgs e)
        {
            fKhoa k = new fKhoa();
            k.ShowDialog();
        }
    }
}
