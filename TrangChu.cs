using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class TrangChu : Form
    {
        private DataTable _user =  new DataTable() ;
        public TrangChu(DataTable inforUser)
        {
            InitializeComponent();
            this._user = inforUser;
        }
        private bool isFormNhanVienLoaded = false;
        private void TrangChu_Load(object sender, EventArgs e)
        {
            DanhSachNhanVien formNhanVien = new DanhSachNhanVien();
            LoadTenHienThi();
            // Gọi hàm AddFormToTabPage để load form con vào TabPage
            AddFormToTabPage(formNhanVien, tabNhanVien);
            //isFormNhanVienLoaded = true;

        }

        // Đây là hàm để thêm form con vào một TabPage
        private void AddFormToTabPage(Form form, TabPage tabPage)
        {
            // Cài đặt form con thành các điều khiển của TabPage
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Thêm form con vào TabPage
            tabPage.Controls.Add(form);

            // Hiển thị form con
            form.Show();
        }
        private void tstmDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbDangXuatTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbcTrangchu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Kiểm tra nếu tab hiện tại là tabNhanVien
            if (tbcTrangchu.SelectedTab == tabNhanVien)
            {
                // Tạo form con
                DanhSachNhanVien formNhanVien = new DanhSachNhanVien();

                // Gọi hàm AddFormToTabPage để load form con vào TabPage
                AddFormToTabPage(formNhanVien, tabNhanVien);
                isFormNhanVienLoaded = true;
            }
            else if (tbcTrangchu.SelectedTab == tabPhongBan)
            {
                // Tương tự cho form PhongBan
                PhongBan formPhongBan = new PhongBan();
                AddFormToTabPage(formPhongBan, tabPhongBan);
            }
        }

        private void thôngTinTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan formThongTinCaNhan = new ThongTinCaNhan(_user);
            formThongTinCaNhan.ShowDialog();
        }
        private void LoadTenHienThi()
        {
            if (_user.Rows.Count > 0)
            {
                // Lấy giá trị từ cột "TenDangNhap" của dòng đầu tiên
                lbHienTenDangNhap.Text = _user.Rows[0]["DisplayName"].ToString();
            }
            else
            {
                lbHienTenDangNhap.Text = "Không có tên hiển th";
            }
        }
    }
}
