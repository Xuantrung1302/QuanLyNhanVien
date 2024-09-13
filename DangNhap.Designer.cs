namespace QuanLyNhanVien
{
    partial class DangNhap
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txbMatKhauDangNhap = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVaoDangKi = new System.Windows.Forms.Button();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnThoatDangNhap = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.Controls.Add(this.txbMatKhauDangNhap, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDangNhap, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txbTenDangNhap, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnVaoDangKi, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbDangNhap, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnThoatDangNhap, 4, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1030, 436);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txbMatKhauDangNhap
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txbMatKhauDangNhap, 3);
            this.txbMatKhauDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.txbMatKhauDangNhap.Location = new System.Drawing.Point(435, 198);
            this.txbMatKhauDangNhap.Multiline = true;
            this.txbMatKhauDangNhap.Name = "txbMatKhauDangNhap";
            this.txbMatKhauDangNhap.PasswordChar = '*';
            this.txbMatKhauDangNhap.Size = new System.Drawing.Size(303, 27);
            this.txbMatKhauDangNhap.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(435, 241);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(97, 37);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txbTenDangNhap
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txbTenDangNhap, 3);
            this.txbTenDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.txbTenDangNhap.Location = new System.Drawing.Point(435, 155);
            this.txbTenDangNhap.Multiline = true;
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(303, 27);
            this.txbTenDangNhap.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 43);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu:";
            // 
            // btnVaoDangKi
            // 
            this.btnVaoDangKi.BackColor = System.Drawing.Color.DarkGray;
            this.btnVaoDangKi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVaoDangKi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaoDangKi.Location = new System.Drawing.Point(538, 241);
            this.btnVaoDangKi.Name = "btnVaoDangKi";
            this.btnVaoDangKi.Size = new System.Drawing.Size(97, 37);
            this.btnVaoDangKi.TabIndex = 6;
            this.btnVaoDangKi.Text = "Đăng kí";
            this.btnVaoDangKi.UseVisualStyleBackColor = false;
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.SetColumnSpan(this.lbDangNhap, 4);
            this.lbDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDangNhap.Location = new System.Drawing.Point(291, 0);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(447, 98);
            this.lbDangNhap.TabIndex = 7;
            this.lbDangNhap.Text = "Đăng nhập";
            this.lbDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnThoatDangNhap
            // 
            this.btnThoatDangNhap.BackColor = System.Drawing.Color.DarkGray;
            this.btnThoatDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThoatDangNhap.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatDangNhap.Location = new System.Drawing.Point(641, 241);
            this.btnThoatDangNhap.Name = "btnThoatDangNhap";
            this.btnThoatDangNhap.Size = new System.Drawing.Size(97, 37);
            this.btnThoatDangNhap.TabIndex = 8;
            this.btnThoatDangNhap.Text = "Thoát";
            this.btnThoatDangNhap.UseVisualStyleBackColor = false;
            this.btnThoatDangNhap.Click += new System.EventHandler(this.btnThoatDangNhap_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 436);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangNhap_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txbMatKhauDangNhap;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVaoDangKi;
        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnThoatDangNhap;
    }
}