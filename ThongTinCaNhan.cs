using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyNhanVien
{
    public partial class ThongTinCaNhan : Form
    {
        private DataTable _user = new DataTable();
        CallAPI callAPI = new CallAPI();
        private string _url = "http://192.168.1.63:99/api/QuanLyNhanVien/";

        public ThongTinCaNhan(DataTable userInfo)
        {
            InitializeComponent();
            this._user = userInfo;
        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            DataRow row = _user.Rows[0]; // Lấy dòng đầu tiên, hoặc thay đổi chỉ số dòng nếu cần

            // Gán dữ liệu vào các TextBox
            txbTenDangNhapInfo.Text = row["Username"].ToString();
            txbTenHienThiInfo.Text = row["DisplayName"].ToString();
        }
        private void Refesh()
        {
            txbMatKhauInfo.Clear();
            txbNhapLaiMatKhauInfo.Clear();
            txbMatKhauMoiInfo.Clear();
        }
        private async void btnSuaInfo_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ form
            string tenDangNhap = txbTenDangNhapInfo.Text;
            string tenHienThi = txbTenHienThiInfo.Text;
            string passWord = txbMatKhauInfo.Text;
            string newPassWord = txbMatKhauMoiInfo.Text;
            string newPassWord2 = txbNhapLaiMatKhauInfo.Text;
            if(newPassWord == newPassWord2 && passWord != newPassWord )
            {
                // Tạo đối tượng JSON để gửi lên API
                var employeeData = new
                {
                    Username = tenDangNhap,
                    PasswordHash = newPassWord,
                    DisplayName = tenHienThi,
                    OldPassword = passWord
                };

                // Chuyển đổi đối tượng thành JSON
                string jsonData = JsonConvert.SerializeObject(employeeData);
                // Gọi API
                string url = $"{_url}suataikhoan"; // Thay bằng URL API thực tế
                bool isSuccess = await callAPI.PostAPI(url, jsonData);
                // Kiểm tra kết quả
                if (isSuccess)
                {
                    Refesh();
                    MessageBox.Show("Sửa tài khoản thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa tài khoản thất bại.");
                    Refesh();
                }
            }
            else
            {
                MessageBox.Show("Nhập lại mật khẩu mới");
                Refesh();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
