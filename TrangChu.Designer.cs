namespace QuanLyNhanVien
{
    partial class TrangChu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbcTrangchu = new System.Windows.Forms.TabControl();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.tabPhongBan = new System.Windows.Forms.TabPage();
            this.tabTinhLuong = new System.Windows.Forms.TabPage();
            this.tabChamCong = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tstmDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.lbHienTenDangNhap = new System.Windows.Forms.Label();
            this.lbDangXuatTrangChu = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbcTrangchu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.tbcTrangchu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbHienTenDangNhap, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbDangXuatTrangChu, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1018, 555);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbcTrangchu
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbcTrangchu, 3);
            this.tbcTrangchu.Controls.Add(this.tabNhanVien);
            this.tbcTrangchu.Controls.Add(this.tabPhongBan);
            this.tbcTrangchu.Controls.Add(this.tabTinhLuong);
            this.tbcTrangchu.Controls.Add(this.tabChamCong);
            this.tbcTrangchu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcTrangchu.Location = new System.Drawing.Point(3, 36);
            this.tbcTrangchu.Name = "tbcTrangchu";
            this.tbcTrangchu.SelectedIndex = 0;
            this.tbcTrangchu.Size = new System.Drawing.Size(1012, 516);
            this.tbcTrangchu.TabIndex = 5;
            this.tbcTrangchu.SelectedIndexChanged += new System.EventHandler(this.tbcTrangchu_SelectedIndexChanged_1);
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Location = new System.Drawing.Point(4, 25);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(1004, 487);
            this.tabNhanVien.TabIndex = 1;
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // tabPhongBan
            // 
            this.tabPhongBan.Location = new System.Drawing.Point(4, 25);
            this.tabPhongBan.Name = "tabPhongBan";
            this.tabPhongBan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhongBan.Size = new System.Drawing.Size(1004, 487);
            this.tabPhongBan.TabIndex = 2;
            this.tabPhongBan.Text = "Phòng ban";
            this.tabPhongBan.UseVisualStyleBackColor = true;
            // 
            // tabTinhLuong
            // 
            this.tabTinhLuong.Location = new System.Drawing.Point(4, 25);
            this.tabTinhLuong.Name = "tabTinhLuong";
            this.tabTinhLuong.Padding = new System.Windows.Forms.Padding(3);
            this.tabTinhLuong.Size = new System.Drawing.Size(1004, 487);
            this.tabTinhLuong.TabIndex = 3;
            this.tabTinhLuong.Text = "Lương";
            this.tabTinhLuong.UseVisualStyleBackColor = true;
            // 
            // tabChamCong
            // 
            this.tabChamCong.Location = new System.Drawing.Point(4, 25);
            this.tabChamCong.Name = "tabChamCong";
            this.tabChamCong.Padding = new System.Windows.Forms.Padding(3);
            this.tabChamCong.Size = new System.Drawing.Size(1004, 487);
            this.tabChamCong.TabIndex = 4;
            this.tabChamCong.Text = "Chấm công";
            this.tabChamCong.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem1,
            this.tstmDangXuat});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem1
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem1.Name = "thôngTinTàiKhoảnToolStripMenuItem1";
            this.thôngTinTàiKhoảnToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.thôngTinTàiKhoảnToolStripMenuItem1.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem1_Click);
            // 
            // tstmDangXuat
            // 
            this.tstmDangXuat.Name = "tstmDangXuat";
            this.tstmDangXuat.Size = new System.Drawing.Size(220, 26);
            this.tstmDangXuat.Text = "Đăng xuất";
            this.tstmDangXuat.Click += new System.EventHandler(this.tstmDangXuat_Click);
            // 
            // lbHienTenDangNhap
            // 
            this.lbHienTenDangNhap.Location = new System.Drawing.Point(817, 0);
            this.lbHienTenDangNhap.Name = "lbHienTenDangNhap";
            this.lbHienTenDangNhap.Size = new System.Drawing.Size(95, 23);
            this.lbHienTenDangNhap.TabIndex = 1;
            this.lbHienTenDangNhap.Text = "label1";
            // 
            // lbDangXuatTrangChu
            // 
            this.lbDangXuatTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangXuatTrangChu.Location = new System.Drawing.Point(918, 0);
            this.lbDangXuatTrangChu.Name = "lbDangXuatTrangChu";
            this.lbDangXuatTrangChu.Size = new System.Drawing.Size(97, 23);
            this.lbDangXuatTrangChu.TabIndex = 2;
            this.lbDangXuatTrangChu.Text = "Đăng xuất";
            this.lbDangXuatTrangChu.Click += new System.EventHandler(this.lbDangXuatTrangChu_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 555);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tbcTrangchu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tstmDangXuat;
        private System.Windows.Forms.Label lbHienTenDangNhap;
        private System.Windows.Forms.Label lbDangXuatTrangChu;
        private System.Windows.Forms.TabControl tbcTrangchu;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.TabPage tabPhongBan;
        private System.Windows.Forms.TabPage tabTinhLuong;
        private System.Windows.Forms.TabPage tabChamCong;
    }
}