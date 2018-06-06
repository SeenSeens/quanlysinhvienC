using Demo.Controller;
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

namespace Demo.View
{
    public partial class fSinhvien : Form
    {
        public fSinhvien()
        {
            InitializeComponent();
        }

        public DataGridView get()
        {
            return this.dtgvSinhvien;
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
        public void setnull()
        {
            txtMasinhvien.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            dtpNgaysinh.Text = "";
            txtGioitinh.Text = "";
            txtNoisinh.Text = "";
            txtKhoahoc.Text = "";
            cbMakhoa.Text = "";
            cbTenkhoa.Text = "";
            cbMakhoa.Enabled = false;
            cbTimten.Enabled = true;
            cbTenkhoa.Enabled = false;
            cbTim.Enabled = true;
        }

        /*public void setclose()
        {
            txtMasinhvien.Enabled = false;
            txtHo.Enabled = false;
            txtTen.Enabled = false;
            dtpNgaysinh.Enabled = false;
            txtGioitinh.Enabled = false;
            txtNoisinh.Enabled = false;
            txtKhoahoc.Enabled = false;
            cbMakhoa.Enabled = false;
            cbTenkhoa.Enabled = false;
            cbMakhoa.Enabled = false;
            cbTimten.Enabled = false;
            cbTenkhoa.Enabled = false;
            cbTim.Enabled = false;
        }*/

        /*public void setopen()
        {
            txtMasinhvien.Enabled = true;
            txtHo.Enabled = true;
            txtTen.Enabled = true;
            dtpNgaysinh.Enabled = true;
            txtGioitinh.Enabled = true;
            txtNoisinh.Enabled = true;
            txtKhoahoc.Enabled = true;
            cbMakhoa.Enabled = true;
            cbTenkhoa.Enabled = true;
            cbMakhoa.Enabled = false;
            cbTimten.Enabled = false;
            cbTenkhoa.Enabled = false;
            cbTim.Enabled = false;
        }*/


        mSinhvien msv = new mSinhvien();
        cSinhvien csv = new cSinhvien();

        public void load_data()
        {
            dtgvSinhvien.DataSource = msv.Load_on();
        }

        private void fSinhvien_Load(object sender, EventArgs e)
        {
            //setclose();
            dtgvSinhvien.DataSource = msv.Load_on();
            
            DataGridView dg = this.get();
            if (dg.SelectedRows.Count > 0)
            {
                load_cb_khoa();
                load_cb_tim();
                cbTim.Text = "Chọn mã";
                cbTimten.Text = "Hiển thị";


                txtMasinhvien.Text = dg.SelectedRows[0].Cells[0].Value.ToString();
                txtHo.Text = dg.SelectedRows[0].Cells[1].Value.ToString();
                txtTen.Text = dg.SelectedRows[0].Cells[2].Value.ToString();
                dtpNgaysinh.Text = dg.SelectedRows[0].Cells[3].Value.ToString();
                txtGioitinh.Text = dg.SelectedRows[0].Cells[4].Value.ToString();
                txtNoisinh.Text = dg.SelectedRows[0].Cells[5].Value.ToString();
                txtKhoahoc.Text = dg.SelectedRows[0].Cells[6].Value.ToString();
                cbTenkhoa.Text = dg.SelectedRows[0].Cells[7].Value.ToString();
                if (dg.CurrentCell.ColumnIndex == 7)
                {
                    txtMasinhvien.Enabled = false;
                    cbTimten.Enabled = false;
                    txtNoisinh.Enabled = false;
                    txtKhoahoc.Enabled = false;
                }
            }
            //setopen();
        }

        mXuly xl = new mXuly();
        public void load_cb_khoa()
        {
            DataTable dt;
            DataGridView dg = this.get();
            dt = msv.Load_on_Khoa(dg.CurrentRow.Cells[0].Value.ToString());
            cbMakhoa.DataSource = dt;
            cbMakhoa.DisplayMember = "TenKhoa";
            cbMakhoa.ValueMember = "MaKhoa";
            if (cbMakhoa.Items.Count > 0)
            {
                cbMakhoa.SelectedIndex = 0; 
            }
        }

        public void load_cb_tim()
        {
            DataTable dt;
            dt = msv.Load_on_tim();
            cbTim.DataSource = dt;
            cbTim.DisplayMember = "TenKhoa";
            cbTim.ValueMember = "MaKhoa";
            if (cbTim.Items.Count > 0)
            {
                cbTim.SelectedIndex = 0;
            }
        }

        private void cbTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTimten.DataSource = msv.timkiem(cbTim.Text);
            cbTimten.DisplayMember = "TenKhoa";
            if (cbTimten.Items.Count > 0)
            {
                cbTimten.SelectedIndex = 0;
            }
        }

        private void cbTimten_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void dtgvSinhvien_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //fSinhvien fsv = new fSinhvien();
                if (dtgvSinhvien.CurrentCell.ColumnIndex == 0)
                {
                    MessageBox.Show("Không thể sữa được");
                }
                else
                {

                }
            }
            catch
            {
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //fSinhvien fsv = new fSinhvien();
            //fsv.Show();
            //fsv.setnull();
            setnull();
            ThemMoi = true;
            SetButton_close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String ngay = String.Format("{0:yyyy/MM/dd}", dtpNgaysinh.Value);
            if (txtMasinhvien.Text == "" && txtHo.Text == "" && txtTen.Text == "" && txtGioitinh.Text == "")
            {
                MessageBox.Show("Không thể thêm nếu không có dữ liệu");
            }
            else
            {
                if (csv.Add_SinhVien(txtMasinhvien.Text, txtHo.Text, txtTen.Text, ngay, txtGioitinh.Text, txtNoisinh.Text, txtKhoahoc.Text, cbTim.Text))
                {
                    MessageBox.Show("Chúc mừng bạn đã thêm thành công");
                    load_data();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Đáng tiết đã có lỗi xảy ra");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView dg = this.get();
                String ngay = String.Format("{0:yyyy/MM/dd}", dtpNgaysinh.Value);
                if (dg.CurrentCell.ColumnIndex == 7)
                {
                    if (csv.ToFix_SinhVien(txtMasinhvien.Text, txtHo.Text, txtTen.Text, ngay, txtGioitinh.Text, txtNoisinh.Text, txtKhoahoc.Text, cbTim.Text))
                    {
                        MessageBox.Show("Chúc mừng bạn đã thêm thành công");
                        this.load_data();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                else
                {
                    csv.ToFix_SinhVien(txtMasinhvien.Text, txtHo.Text, txtTen.Text, ngay, txtGioitinh.Text, txtNoisinh.Text, txtKhoahoc.Text, cbMakhoa.Text);
                    MessageBox.Show("Chúc mừng bạn đã cập nhật thành công");
                    this.load_data();
                    this.Close();
                }
            }
            catch
            {
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn chắc chắn có muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                for (int i = 0; i < dtgvSinhvien.SelectedRows.Count; i++)
                {
                    csv.Delete_SinhVien(dtgvSinhvien.Rows[i].Cells[0].Value.ToString());
                    MessageBox.Show("Chúc mừng bạn đã xóa thành công");
                    load_data();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetButton_open();
            setnull();
            fSinhvien_Load(sender, e);
        }


        /*private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn chắc chắn có muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                for (int i = 0; i < dtgvSinhvien.SelectedRows.Count; i++)
                {
                    csv.Delete_SinhVien(dtgvSinhvien.Rows[i].Cells[0].Value.ToString());
                    MessageBox.Show("Chức mừng bạn đã xóa thành công");
                    load_data();
                }
            }
            else
            {

            }
        }*/
    }
}
