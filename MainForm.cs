using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5001103027_TrinhMinhHuy_Lab05
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<KhoaHoc> danhSachKhoaHoc = new List<KhoaHoc>
            {
                new KhoaHoc("C# WinForms cơ bản", 800000),
                new KhoaHoc("SQL Server cơ bản", 700000),
                new KhoaHoc("Web Frontend cơ bản", 750000),
                new KhoaHoc("Lập trình Python cơ bản", 650000)
            };

            cboKhoaHoc.Items.Clear();
            foreach (var kh in danhSachKhoaHoc)
            {
                cboKhoaHoc.Items.Add(kh);
            }

            numSoThang.Minimum = 1;
            numSoThang.Maximum = 12;
            numSoThang.Value = 1;

            cboKhoaHoc.SelectedIndex = 0;
            radOnline.Checked = true;

            TinhHocPhi();
        }

        private decimal LayHocPhiMotThang()
        {
            if (cboKhoaHoc.SelectedItem is KhoaHoc kh)
            {
                return kh.HocPhiMotThang;
            }
            return 0;
        }

        private void TinhHocPhi()
        {
            decimal hocPhiMotThang = LayHocPhiMotThang();
            int soThang = (int)numSoThang.Value;
            decimal tongTien = hocPhiMotThang * soThang;

            lblTongTien.Text = string.Format("{0:N0} VNĐ", tongTien);
        }

        private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhHocPhi();
        }

        private void numSoThang_ValueChanged(object sender, EventArgs e)
        {
            TinhHocPhi();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên học viên!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            string sdt = txtSoDienThoai.Text.Trim();
            if (string.IsNullOrWhiteSpace(sdt) || !sdt.All(char.IsDigit) || sdt.Length < 9 || sdt.Length > 11)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ (từ 9 đến 11 chữ số)!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }

            // 3. Kiểm tra phải chọn khóa học
            if (cboKhoaHoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn khóa học!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKhoaHoc.Focus();
                return;
            }

            decimal tongTien = LayHocPhiMotThang() * (int)numSoThang.Value;
            string hinhThuc = radOnline.Checked ? "Online" : "Trực tiếp";
            string nhanEmail = chkNhanEmail.Checked ? "Có" : "Không";

            string thongTinPhieu =
                "=== PHIẾU ĐĂNG KÝ KHÓA HỌC ===\n\n" +
                $"Họ và tên: {txtHoTen.Text.Trim()}\n" +
                $"Số điện thoại: {sdt}\n" +
                $"Ngày sinh: {dtpNgaySinh.Value:dd/MM/yyyy}\n" +
                $"Khóa học: {cboKhoaHoc.Text}\n" +
                $"Hình thức học: {hinhThuc}\n" +
                $"Số tháng đăng ký: {numSoThang.Value} tháng\n" +
                $"Tổng học phí: {tongTien:N0} VNĐ\n" +
                $"Nhận email thông báo: {nhanEmail}";

            MessageBox.Show(thongTinPhieu, "Đăng ký thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn làm mới (xóa) dữ liệu đang nhập không?",
                "Xác nhận làm mới",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtHoTen.Clear();
                txtSoDienThoai.Clear();
                dtpNgaySinh.Value = DateTime.Now;
                chkNhanEmail.Checked = false;
                if (cboKhoaHoc.Items.Count > 0)
                    cboKhoaHoc.SelectedIndex = 0;
                radOnline.Checked = true;
                numSoThang.Value = 1;
                TinhHocPhi();
                txtHoTen.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}