namespace Demo.View
{
    partial class fmain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnSinhvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSinhvien,
            this.mnKhoa});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnSinhvien
            // 
            this.mnSinhvien.Name = "mnSinhvien";
            this.mnSinhvien.Size = new System.Drawing.Size(65, 20);
            this.mnSinhvien.Text = "SinhVien";
            this.mnSinhvien.Click += new System.EventHandler(this.mnSinhvien_Click);
            // 
            // mnKhoa
            // 
            this.mnKhoa.Name = "mnKhoa";
            this.mnKhoa.Size = new System.Drawing.Size(46, 20);
            this.mnKhoa.Text = "Khoa";
            this.mnKhoa.Click += new System.EventHandler(this.mnKhoa_Click);
            // 
            // fmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 302);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fmain";
            this.Text = "fmain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnSinhvien;
        private System.Windows.Forms.ToolStripMenuItem mnKhoa;
    }
}