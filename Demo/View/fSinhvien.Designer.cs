namespace Demo.View
{
    partial class fSinhvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTenkhoa = new System.Windows.Forms.ComboBox();
            this.cbTimten = new System.Windows.Forms.ComboBox();
            this.cbTim = new System.Windows.Forms.ComboBox();
            this.cbMakhoa = new System.Windows.Forms.ComboBox();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtKhoahoc = new System.Windows.Forms.TextBox();
            this.txtNoisinh = new System.Windows.Forms.TextBox();
            this.txtGioitinh = new System.Windows.Forms.TextBox();
            this.txtMasinhvien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvSinhvien = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTenkhoa);
            this.panel1.Controls.Add(this.cbTimten);
            this.panel1.Controls.Add(this.cbTim);
            this.panel1.Controls.Add(this.cbMakhoa);
            this.panel1.Controls.Add(this.dtpNgaysinh);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.txtHo);
            this.panel1.Controls.Add(this.txtKhoahoc);
            this.panel1.Controls.Add(this.txtNoisinh);
            this.panel1.Controls.Add(this.txtGioitinh);
            this.panel1.Controls.Add(this.txtMasinhvien);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 195);
            this.panel1.TabIndex = 0;
            // 
            // cbTenkhoa
            // 
            this.cbTenkhoa.FormattingEnabled = true;
            this.cbTenkhoa.Location = new System.Drawing.Point(560, 165);
            this.cbTenkhoa.Name = "cbTenkhoa";
            this.cbTenkhoa.Size = new System.Drawing.Size(121, 21);
            this.cbTenkhoa.TabIndex = 3;
            // 
            // cbTimten
            // 
            this.cbTimten.FormattingEnabled = true;
            this.cbTimten.Location = new System.Drawing.Point(700, 165);
            this.cbTimten.Name = "cbTimten";
            this.cbTimten.Size = new System.Drawing.Size(121, 21);
            this.cbTimten.TabIndex = 3;
            this.cbTimten.SelectedIndexChanged += new System.EventHandler(this.cbTimten_SelectedIndexChanged);
            // 
            // cbTim
            // 
            this.cbTim.FormattingEnabled = true;
            this.cbTim.Location = new System.Drawing.Point(700, 128);
            this.cbTim.Name = "cbTim";
            this.cbTim.Size = new System.Drawing.Size(121, 21);
            this.cbTim.TabIndex = 3;
            this.cbTim.SelectedIndexChanged += new System.EventHandler(this.cbTim_SelectedIndexChanged);
            // 
            // cbMakhoa
            // 
            this.cbMakhoa.FormattingEnabled = true;
            this.cbMakhoa.Location = new System.Drawing.Point(560, 128);
            this.cbMakhoa.Name = "cbMakhoa";
            this.cbMakhoa.Size = new System.Drawing.Size(121, 21);
            this.cbMakhoa.TabIndex = 3;
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Location = new System.Drawing.Point(226, 130);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaysinh.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(239, 91);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(239, 54);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(100, 20);
            this.txtHo.TabIndex = 1;
            // 
            // txtKhoahoc
            // 
            this.txtKhoahoc.Location = new System.Drawing.Point(558, 91);
            this.txtKhoahoc.Name = "txtKhoahoc";
            this.txtKhoahoc.Size = new System.Drawing.Size(100, 20);
            this.txtKhoahoc.TabIndex = 1;
            // 
            // txtNoisinh
            // 
            this.txtNoisinh.Location = new System.Drawing.Point(558, 54);
            this.txtNoisinh.Name = "txtNoisinh";
            this.txtNoisinh.Size = new System.Drawing.Size(100, 20);
            this.txtNoisinh.TabIndex = 1;
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.Location = new System.Drawing.Point(558, 17);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(100, 20);
            this.txtGioitinh.TabIndex = 1;
            // 
            // txtMasinhvien
            // 
            this.txtMasinhvien.Location = new System.Drawing.Point(239, 17);
            this.txtMasinhvien.Name = "txtMasinhvien";
            this.txtMasinhvien.Size = new System.Drawing.Size(100, 20);
            this.txtMasinhvien.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(502, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên khoa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Khóa học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(502, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã khoa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nơi sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(179, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 38);
            this.panel2.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(426, 7);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(328, 8);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(230, 8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(132, 8);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(34, 7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvSinhvien);
            this.panel3.Location = new System.Drawing.Point(13, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(977, 282);
            this.panel3.TabIndex = 2;
            // 
            // dtgvSinhvien
            // 
            this.dtgvSinhvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.Ho,
            this.Ten,
            this.NgaySinh,
            this.GioiTinh,
            this.NoiSinh,
            this.KhoaHoc,
            this.MaKhoa,
            this.TenKhoa});
            this.dtgvSinhvien.Location = new System.Drawing.Point(0, 0);
            this.dtgvSinhvien.Name = "dtgvSinhvien";
            this.dtgvSinhvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSinhvien.Size = new System.Drawing.Size(974, 282);
            this.dtgvSinhvien.TabIndex = 0;
            this.dtgvSinhvien.DoubleClick += new System.EventHandler(this.dtgvSinhvien_DoubleClick);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.Name = "MaSV";
            // 
            // Ho
            // 
            this.Ho.DataPropertyName = "Ho";
            this.Ho.HeaderText = "Họ";
            this.Ho.Name = "Ho";
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NoiSinh
            // 
            this.NoiSinh.DataPropertyName = "NoiSinh";
            this.NoiSinh.HeaderText = "Nơi sinh";
            this.NoiSinh.Name = "NoiSinh";
            // 
            // KhoaHoc
            // 
            this.KhoaHoc.DataPropertyName = "KhoaHoc";
            this.KhoaHoc.HeaderText = "Khóa học";
            this.KhoaHoc.Name = "KhoaHoc";
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Mã khoa";
            this.MaKhoa.Name = "MaKhoa";
            // 
            // TenKhoa
            // 
            this.TenKhoa.DataPropertyName = "TenKhoa";
            this.TenKhoa.HeaderText = "Tên Khoa";
            this.TenKhoa.Name = "TenKhoa";
            // 
            // fSinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 552);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fSinhvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSinhvien";
            this.Load += new System.EventHandler(this.fSinhvien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSinhvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTenkhoa;
        private System.Windows.Forms.ComboBox cbTimten;
        private System.Windows.Forms.ComboBox cbTim;
        private System.Windows.Forms.ComboBox cbMakhoa;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtKhoahoc;
        private System.Windows.Forms.TextBox txtNoisinh;
        private System.Windows.Forms.TextBox txtGioitinh;
        private System.Windows.Forms.TextBox txtMasinhvien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvSinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
    }
}