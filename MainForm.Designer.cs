using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5001103027_TrinhMinhHuy_Lab05
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpThongTinHocVien = new System.Windows.Forms.GroupBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.chkNhanEmail = new System.Windows.Forms.CheckBox();

            this.grpThongTinKhoaHoc = new System.Windows.Forms.GroupBox();
            this.lblKhoaHoc = new System.Windows.Forms.Label();
            this.cboKhoaHoc = new System.Windows.Forms.ComboBox();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.radOnline = new System.Windows.Forms.RadioButton();
            this.radOffline = new System.Windows.Forms.RadioButton();
            this.lblSoThang = new System.Windows.Forms.Label();
            this.numSoThang = new System.Windows.Forms.NumericUpDown();
            this.lblTieuDeTongTien = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();

            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            this.grpThongTinHocVien.SuspendLayout();
            this.grpThongTinKhoaHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).BeginInit();
            this.SuspendLayout();

            // grpThongTinHocVien
            this.grpThongTinHocVien.Controls.Add(this.lblHoTen);
            this.grpThongTinHocVien.Controls.Add(this.txtHoTen);
            this.grpThongTinHocVien.Controls.Add(this.lblSoDienThoai);
            this.grpThongTinHocVien.Controls.Add(this.txtSoDienThoai);
            this.grpThongTinHocVien.Controls.Add(this.lblNgaySinh);
            this.grpThongTinHocVien.Controls.Add(this.dtpNgaySinh);
            this.grpThongTinHocVien.Controls.Add(this.chkNhanEmail);
            this.grpThongTinHocVien.Location = new System.Drawing.Point(20, 15);
            this.grpThongTinHocVien.Name = "grpThongTinHocVien";
            this.grpThongTinHocVien.Size = new System.Drawing.Size(440, 165);
            this.grpThongTinHocVien.TabIndex = 0;
            this.grpThongTinHocVien.TabStop = false;
            this.grpThongTinHocVien.Text = "Thông tin học viên";

            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(20, 30);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Text = "Họ và tên:";
            this.txtHoTen.Location = new System.Drawing.Point(130, 27);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(280, 23);
            this.txtHoTen.TabIndex = 0;

            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(20, 65);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Text = "Số điện thoại:";
            this.txtSoDienThoai.Location = new System.Drawing.Point(130, 62);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(280, 23);
            this.txtSoDienThoai.TabIndex = 1;

            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 100);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Text = "Ngày sinh:";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(130, 97);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(280, 23);
            this.dtpNgaySinh.TabIndex = 2;

            this.chkNhanEmail.AutoSize = true;
            this.chkNhanEmail.Location = new System.Drawing.Point(130, 132);
            this.chkNhanEmail.Name = "chkNhanEmail";
            this.chkNhanEmail.Text = "Nhận email thông báo";
            this.chkNhanEmail.TabIndex = 3;

            this.grpThongTinKhoaHoc.Controls.Add(this.lblKhoaHoc);
            this.grpThongTinKhoaHoc.Controls.Add(this.cboKhoaHoc);
            this.grpThongTinKhoaHoc.Controls.Add(this.lblHinhThuc);
            this.grpThongTinKhoaHoc.Controls.Add(this.radOnline);
            this.grpThongTinKhoaHoc.Controls.Add(this.radOffline);
            this.grpThongTinKhoaHoc.Controls.Add(this.lblSoThang);
            this.grpThongTinKhoaHoc.Controls.Add(this.numSoThang);
            this.grpThongTinKhoaHoc.Controls.Add(this.lblTieuDeTongTien);
            this.grpThongTinKhoaHoc.Controls.Add(this.lblTongTien);
            this.grpThongTinKhoaHoc.Location = new System.Drawing.Point(20, 195);
            this.grpThongTinKhoaHoc.Name = "grpThongTinKhoaHoc";
            this.grpThongTinKhoaHoc.Size = new System.Drawing.Size(440, 175);
            this.grpThongTinKhoaHoc.TabIndex = 1;
            this.grpThongTinKhoaHoc.TabStop = false;
            this.grpThongTinKhoaHoc.Text = "Thông tin khóa học";

            this.lblKhoaHoc.AutoSize = true;
            this.lblKhoaHoc.Location = new System.Drawing.Point(20, 30);
            this.lblKhoaHoc.Name = "lblKhoaHoc";
            this.lblKhoaHoc.Text = "Khóa học:";
            this.cboKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaHoc.Location = new System.Drawing.Point(130, 27);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(280, 23);
            this.cboKhoaHoc.TabIndex = 0;
            this.cboKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cboKhoaHoc_SelectedIndexChanged);

            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Location = new System.Drawing.Point(20, 65);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Text = "Hình thức học:";
            this.radOnline.AutoSize = true;
            this.radOnline.Location = new System.Drawing.Point(130, 63);
            this.radOnline.Name = "radOnline";
            this.radOnline.Text = "Online";
            this.radOnline.TabIndex = 1;
            this.radOffline.AutoSize = true;
            this.radOffline.Location = new System.Drawing.Point(240, 63);
            this.radOffline.Name = "radOffline";
            this.radOffline.Text = "Trực tiếp";
            this.radOffline.TabIndex = 2;

            this.lblSoThang.AutoSize = true;
            this.lblSoThang.Location = new System.Drawing.Point(20, 100);
            this.lblSoThang.Name = "lblSoThang";
            this.lblSoThang.Text = "Số tháng:";
            this.numSoThang.Location = new System.Drawing.Point(130, 98);
            this.numSoThang.Name = "numSoThang";
            this.numSoThang.Size = new System.Drawing.Size(120, 23);
            this.numSoThang.TabIndex = 3;
            this.numSoThang.ValueChanged += new System.EventHandler(this.numSoThang_ValueChanged);

            this.lblTieuDeTongTien.AutoSize = true;
            this.lblTieuDeTongTien.Location = new System.Drawing.Point(20, 138);
            this.lblTieuDeTongTien.Name = "lblTieuDeTongTien";
            this.lblTieuDeTongTien.Text = "Tổng học phí:";
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(130, 136);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Text = "0 VNĐ";

            this.btnDangKy.Location = new System.Drawing.Point(75, 385);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(100, 35);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);

            this.btnLamMoi.Location = new System.Drawing.Point(190, 385);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            this.btnThoat.Location = new System.Drawing.Point(305, 385);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 35);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            this.ClientSize = new System.Drawing.Size(480, 440);
            this.Controls.Add(this.grpThongTinHocVien);
            this.Controls.Add(this.grpThongTinKhoaHoc);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG KÝ KHÓA HỌC";
            this.Load += new System.EventHandler(this.MainForm_Load);

            this.grpThongTinHocVien.ResumeLayout(false);
            this.grpThongTinHocVien.PerformLayout();
            this.grpThongTinKhoaHoc.ResumeLayout(false);
            this.grpThongTinKhoaHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpThongTinHocVien;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.CheckBox chkNhanEmail;
        private System.Windows.Forms.GroupBox grpThongTinKhoaHoc;
        private System.Windows.Forms.Label lblKhoaHoc;
        private System.Windows.Forms.ComboBox cboKhoaHoc;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.RadioButton radOnline;
        private System.Windows.Forms.RadioButton radOffline;
        private System.Windows.Forms.Label lblSoThang;
        private System.Windows.Forms.NumericUpDown numSoThang;
        private System.Windows.Forms.Label lblTieuDeTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
    }
}