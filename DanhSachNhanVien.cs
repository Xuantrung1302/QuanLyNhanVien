using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhanVien
{
    public partial class DanhSachNhanVien : Form
    {
        
        CallAPI callAPI = new CallAPI();
        private string _url = "http://192.168.1.63:99/api/QuanLyNhanVien/";
        private int pageSize = 50;   // Số hàng trên mỗi trang
        private int currentPage = 1; // Trang hiện tại
        private int totalPage = 10;   // Tổng số trang
        DataTable dtsgv = new DataTable();

        public DanhSachNhanVien()
        {
            InitializeComponent();
        }
        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
            LoadComboBoxTenPhongBan();
            CheckRabTimKiem();
            Disabled();
        }
        private void Disabled()
        {
            btnThemNhanVien.Enabled = false;
            btnSuaNhanVien.Enabled = false;
            btnXoaNhanVien.Enabled=false;
        }
        private void Abled()
        {
            btnThemNhanVien.Enabled = true;
            btnSuaNhanVien.Enabled = true;
            btnXoaNhanVien.Enabled = true;
        }
        private void CheckRabTimKiem()
        {
            txbTimKiemMaNV.ReadOnly = !rabTimKiemMaNV.Checked;
            txbTimKiemTenNV.ReadOnly = rabTimKiemMaNV.Checked;
        }
        private async void LoadDataToGridView(string IdE = null, string employeeName= null,int pageNumber = 1)
        {
            string url = $"{_url}danhsachnhanvien?IdE={IdE}&employeeName={employeeName}&PageSize=50&PageNumber={pageNumber}";
            DataTable result = await callAPI.GetAPI(url);
            if(result.Rows.Count > 0)
            {
                dtgvDanhSachNhanVien.DataSource = result;
            }    

            if (result.Rows.Count < 50)
                btnNextPage.Enabled = false;
            else
            {
                btnNextPage.Enabled=true;
            }
            if (currentPage == 1)
            {
                btnPreviousPage.Enabled = false;
            }
            else
            {
                btnPreviousPage.Enabled = true;
            }
        }
        private async void LoadComboBoxTenPhongBan()
        {
            string url = "http://192.168.1.63:99/api/QuanLyPhongBan/danhsachphongban";
            DataTable result = await callAPI.GetAPI(url);
            DataTable result1 = result.Copy();
            // Thêm mục "New Item" vào DataTable
            DataRow newRow = result1.NewRow();
            newRow["DepartmentID"] = 0;  // Giá trị DepartmentID cho mục "New Item"
            newRow["DepartmentName"] = "Tất cả";  // Tên mục
            result1.Rows.InsertAt(newRow, 0);  // Chèn hàng vào vị trí đầu tiên

            // Gán DataSource cho ComboBox cbTenPhongBan
            cbTenPhongBan.DataSource = result;
            cbTenPhongBan.DisplayMember = "DepartmentName";
            cbTenPhongBan.ValueMember = "DepartmentID";

            //// Gán lại DataSource cho ComboBox cbSapXepNhanVien
            //cbSapXepNhanVien.DataSource = result1;
            //cbSapXepNhanVien.DisplayMember = "DepartmentName";
            //cbSapXepNhanVien.ValueMember = "DepartmentID";

            //// Đặt mục mặc định được chọn cho cbSapXepNhanVien là "New Item"
            //cbSapXepNhanVien.SelectedIndex = 0;
        }

        private async void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ form
            string firstName = txbTenDauNhanVien.Text;
            string lastName = txbTenCuoiNhanVien.Text;
            DateTime dob = dtpkNgaySinhNhanVien.Value; // Ngày sinh từ DateTimePicker
            string gender = rdbNamNhanVien.Checked ? "Nam" : "Nữ"; // Lấy giới tính từ RadioButton
            string address = txbDiaChiNhanVien.Text;
            string position = txbViTriNhanVien.Text;
            int departmentId = Convert.ToInt32(cbTenPhongBan.SelectedValue); // Chuyển chuỗi thành số nguyên

            // Tạo đối tượng JSON để gửi lên API
            var employeeData = new
            {
                FirstName = firstName,
                LastName = lastName,
                DOB = dob.ToString("yyyy-MM-dd"), // Chuyển ngày sinh thành định dạng chuỗi
                Gender = gender,
                Address = address,
                Position = position,
                DepartmentID = departmentId
            };

            // Chuyển đổi đối tượng thành JSON
            string jsonData = JsonConvert.SerializeObject(employeeData);    


            // Gọi API
            string url  = $"{_url}themnhanvien"; // Thay bằng URL API thực tế
            bool isSuccess = await callAPI.PostAPI(url, jsonData);

            // Kiểm tra kết quả
            if (isSuccess)
            {
                MessageBox.Show("Thêm nhân viên thành công!");
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại.");
            }
            LoadDataToGridView();
        }

        private async void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ form
            int EmployeeID = Convert.ToInt32(txbIDNhanVien.Text);
            string firstName = txbTenDauNhanVien.Text;
            string lastName = txbTenCuoiNhanVien.Text;
            DateTime dob = dtpkNgaySinhNhanVien.Value; // Ngày sinh từ DateTimePicker
            string gender = rdbNamNhanVien.Checked ? "Nam" : "Nữ"; // Lấy giới tính từ RadioButton
            string address = txbDiaChiNhanVien.Text;
            string position = txbViTriNhanVien.Text;
            int departmentId = Convert.ToInt32(cbTenPhongBan.SelectedValue); // Chuyển chuỗi thành số nguyên

            // Tạo đối tượng JSON để gửi lên API
            var employeeData = new
            {
                EmployeeID = EmployeeID,
                FirstName = firstName,
                LastName = lastName,
                DOB = dob.ToString("yyyy-MM-dd"), // Chuyển ngày sinh thành định dạng chuỗi
                Gender = gender,
                Address = address,
                Position = position,
                DepartmentID = departmentId
            };

            // Chuyển đổi đối tượng thành JSON
            string jsonData = JsonConvert.SerializeObject(employeeData);


            // Gọi API
            string url = $"{_url}suanhanvien"; // Thay bằng URL API thực tế
            bool isSuccess = await callAPI.PostAPI(url, jsonData);

            // Kiểm tra kết quả
            if (isSuccess)
            {
                MessageBox.Show("Sửa nhân viên thành công!");
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại.");
            }
            LoadDataToGridView();
        }

        private void btnTimKiemNhanVien_Click(object sender, EventArgs e)
        {
            LoadDataToGridView(txbTimKiemMaNV.Text.Trim(), txbTimKiemTenNV.Text.Trim());
        }

        private void dtgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || dtgvDanhSachNhanVien.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }
            Abled();
            txbTenDauNhanVien.Text = dtgvDanhSachNhanVien.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
            txbTenCuoiNhanVien.Text = dtgvDanhSachNhanVien.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
            txbDiaChiNhanVien.Text = dtgvDanhSachNhanVien.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            txbViTriNhanVien.Text = dtgvDanhSachNhanVien.Rows[e.RowIndex].Cells["Position"].Value.ToString();
            txbIDNhanVien.Text = dtgvDanhSachNhanVien.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
            // Cập nhật ComboBox cbTenPhongBan với DepartmentID
            int departmentId = Convert.ToInt32(dtgvDanhSachNhanVien.Rows[e.RowIndex].Cells["DepartmentID"].Value);
            cbTenPhongBan.SelectedValue = departmentId; // Giả sử ComboBox đã có danh sách phòng ban với ValueMember là DepartmentID

            // Cập nhật DateTimePicker dtpkNgaySinhNhanVien với ngày sinh (DOB)
            DateTime dob = Convert.ToDateTime(dtgvDanhSachNhanVien.Rows[e.RowIndex].Cells["DOB"].Value);
            dtpkNgaySinhNhanVien.Value = dob;

            // Cập nhật RadioButton rdbGioiTinhNhanVien với giới tính (Gender)
            string gender = dtgvDanhSachNhanVien.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
            if (gender == "Nam" || gender == "Male")
            {
                rdbNamNhanVien.Checked = true;
            }
            else if (gender == "Nữ" || gender == "Female")
            {
                rdbNuNhanVien.Checked = true;
            }
        }

        private async void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            string id = txbIDNhanVien.Text;
            string url = $"{_url}xoanhanvien?Id={id}"; // Thay bằng URL API thực tế
            bool isSuccess = await callAPI.PostAPI(url);

            // Kiểm tra kết quả
            if (isSuccess)
            {
                MessageBox.Show("Xóa nhân viên thành công!");
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại.");
            }
            LoadDataToGridView();
        }

        private void rabTimKiemMaNV_CheckedChanged(object sender, EventArgs e)
        {
            CheckRabTimKiem();
        }

        private void rabTimKiemTenNV_CheckedChanged(object sender, EventArgs e)
        {
            CheckRabTimKiem();
        }

        private void btnThoatNhanVien_Click(object sender, EventArgs e)
        {
            DangNhap formDangNhap = new DangNhap();
            formDangNhap.Show();
            this.Close();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            currentPage--;
            LoadDataToGridView(null, null, currentPage);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadDataToGridView(null, null, currentPage);
        }
    }
}
