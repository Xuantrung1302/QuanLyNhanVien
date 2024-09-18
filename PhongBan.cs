using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace QuanLyNhanVien
{
    public partial class PhongBan : Form
    {
        public PhongBan()
        {
            InitializeComponent();
        }

 
        CallAPI callAPI = new CallAPI();
        private string _url = "http://192.168.1.63:99/api/QuanLyNhanVien/";
        bool isExit = false;
        private void PhongBan_Load_1(object sender, EventArgs e)
        {
            LoadDataToGridView();
            //LoadComboBoxTenPhongBan();
            Disabled();
        }
        private void Disabled()
        {
            btnThemPhongBan.Enabled = false;
            btnSuaPhongBan.Enabled = false;
            btnXoaPhongBan.Enabled = false;
        }
        private void Abled()
        {
            btnThemPhongBan.Enabled = true;
            btnSuaPhongBan.Enabled = true;
            btnXoaPhongBan.Enabled = true;
        }
        private async void LoadDataToGridView(int? IdE = null, int? IdD = null)
        {
            string url = $"{_url}danhsachphongban?IdE={IdE}&IdD={IdD}";


            DataTable result = await callAPI.GetAPI(url);
            dtgvDanhSachPhongBan.DataSource = result;
        }

        private void dtgvDanhSachPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex == -1)
                {
                    return;
                }
                Abled();
                txbIDPhongBan.Text = dtgvDanhSachPhongBan.Rows[e.RowIndex].Cells["DepartmentID"].Value.ToString();
                txbTenPhongBan.Text = dtgvDanhSachPhongBan.Rows[e.RowIndex].Cells["DepartmentName"].Value.ToString();

        }

        private async void btnThemPhongBan_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ form
            
            string departmentName = txbTenPhongBan.Text;

            // Tạo đối tượng JSON để gửi lên API
            var employeeData = new
            {
                DepartmentName = departmentName,

            };

            // Chuyển đổi đối tượng thành JSON
            string jsonData = JsonConvert.SerializeObject(employeeData);


            // Gọi API
            string url = $"{_url}themphongban"; // Thay bằng URL API thực tế
            bool isSuccess = await callAPI.PostAPI(url, jsonData);

            // Kiểm tra kết quả
            if (isSuccess)
            {
                MessageBox.Show("Thêm phòng ban thành công!");
            }
            else
            {
                MessageBox.Show("Thêm phòng ban thất bại.");
            }
            LoadDataToGridView();
        }

        private async void btnSuaPhongBan_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ form
            string departmentID = txbIDPhongBan.Text;
            string departmentName = txbTenPhongBan.Text;

            // Tạo đối tượng JSON để gửi lên API
            var employeeData = new
            {
                DepartmentID = departmentID,
                DepartmentName = departmentName,
            };

            // Chuyển đổi đối tượng thành JSON
            string jsonData = JsonConvert.SerializeObject(employeeData);


            // Gọi API
            string url = $"{_url}suaphongban"; // Thay bằng URL API thực tế
            bool isSuccess = await callAPI.PostAPI(url, jsonData);

            // Kiểm tra kết quả
            if (isSuccess)
            {
                MessageBox.Show("Sửa phòng ban thành công!");
            }
            else
            {
                MessageBox.Show("Sửa phòng ban thất bại.");
            }
            LoadDataToGridView();
        }

        private async void btnXoaPhongBan_Click(object sender, EventArgs e)
        {
            string id = txbIDPhongBan.Text;
            string url = $"{_url}xoaphongban?Id={id}"; // Thay bằng URL API thực tế
            int isSuccess = await callAPI.PostIntAPI(url);

            // Kiểm tra kết quả
            if (isSuccess == 0)
            {
                MessageBox.Show("Xóa phòng ban thành công!");
            }
            else if (isSuccess == 1)
            {
                MessageBox.Show("Xóa thất bại! Có nhân viên trong phòng ban.");
            }    
            else
            {
                MessageBox.Show("Xóa phòng ban thất bại.");
            }
            LoadDataToGridView();
        }

    }
}

