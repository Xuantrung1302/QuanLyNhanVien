﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyNhanVien
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        CallAPI callAPI = new CallAPI();
        private string _url = "https://localhost:44396/api/QuanLyNhanVien/";

        //Ham kiem tra dang nhap
        private bool CheckDangNhap()
        {
            if (txbTenDangNhap.Text == "")
            {
                errorProvider1.SetError(txbTenDangNhap, "Bạn chưa nhập tên đăng nhập");
                return false;
            }
            else if (txbMatKhauDangNhap.Text == "")
            {
                errorProvider1.SetError(txbMatKhauDangNhap, "Bạn chưa nhập mật khẩu");
                return false;
            }
            return true;
        }
        private async void LoadDataToGridView(string IdAccount = null)
        {
            string url = $"{_url}danhsachnhanvien?IdE={IdAccount}";

            DataTable result = await callAPI.GetAPI(url);
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát",
                "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnThoatDangNhap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(CheckDangNhap())
            {
                string userName = txbTenDangNhap.Text;
                string passWord = txbMatKhauDangNhap.Text;
                //var loginData = new
                //{
                //    Username = userName,
                //    PasswordHash = passWord
                //};
                //string jsonData = JsonConvert.SerializeObject(loginData);


                // Gọi API
                string url = $"{_url}danhsachtaikhoan?userName={userName}&passWord={passWord}"; // Thay bằng URL API thực tế
                DataTable result = await callAPI.GetAPI(url);


                // Kiểm tra kết quả
                if (result.Rows.Count > 0)
                {

                    TrangChu formTrangChu = new TrangChu(result);
                    this.Hide();
                    formTrangChu.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại.");
                }
            }    
            
           
        }
        
    }
}
    
