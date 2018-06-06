using Demo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo.Controller;
using Demo.View;

namespace Demo.View
{
    public partial class fKhoa : Form
    {
        public fKhoa()
        {
            InitializeComponent();
        }
        bool ThemMoi = true;
        public void SetButton_open()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
        public void SetButton_close()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }
        public void SetNull()
        {
            txtMakhoa.Text = "";
            txtTenkhoa.Text = "";
            txtDiadiem.Text = "";
            txtDienthoai.Text = "";
            txtEmail.Text = "";
            txtTruongkhoa.Text = "";
        }


        mKhoa khoa = new mKhoa();
        private void fKhoa_Load(object sender, EventArgs e)
        {
            SetButton_open();
            dtgvKhoa.DataSource = khoa.Load_on();
        }

        private void dtgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = dtgvKhoa.CurrentRow.Index;
                txtMakhoa.Text = dtgvKhoa.Rows[i].Cells["MaKhoa"].Value.ToString();
                txtTenkhoa.Text = dtgvKhoa.Rows[i].Cells["TenKhoa"].Value.ToString();
                txtDiadiem.Text = dtgvKhoa.Rows[i].Cells["DiaDiem"].Value.ToString();
                txtDienthoai.Text = dtgvKhoa.Rows[i].Cells["DienThoai"].Value.ToString();
                txtEmail.Text = dtgvKhoa.Rows[i].Cells["Email"].Value.ToString();
                txtTruongkhoa.Text = dtgvKhoa.Rows[i].Cells["TruongKhoa"].Value.ToString();
            }
            catch
            {
                e.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SetNull();
            ThemMoi = true;
            SetButton_close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ThemMoi = false;
            SetButton_close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetButton_open();
            SetNull();
            fKhoa_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (khoa_1.Delete_Khoa(txtMakhoa.Text))
                {
                    MessageBox.Show("Chúc mừng bạn đã xóa thành công");
                }
                else
                {
                }
            }
            SetNull();
            SetButton_open();
            fKhoa_Load(sender, e);
        }

        cKhoa khoa_1 = new cKhoa();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ThemMoi == true)
            {
                if (txtMakhoa.Text == "" && txtTenkhoa.Text == "")
                {
                    MessageBox.Show("Bạn chưa thêm dữ liệu");
                }
                else
                {
                    if (khoa_1.Add_Khoa(txtMakhoa.Text, txtTenkhoa.Text, txtDiadiem.Text, txtDienthoai.Text, txtEmail.Text, txtTruongkhoa.Text))
                    {
                        MessageBox.Show("Bạn đã thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra!!!");
                    }
                }
            }
            else
            {
                if (khoa_1.ToFix(txtMakhoa.Text, txtTenkhoa.Text, txtDiadiem.Text, txtDienthoai.Text, txtEmail.Text, txtTruongkhoa.Text))
                {
                    MessageBox.Show("Bạn đã sửa thành công");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi không thể sửa được!!!");
                }
            }
            SetButton_open();
            fKhoa_Load(sender, e);
        }
    }
}
