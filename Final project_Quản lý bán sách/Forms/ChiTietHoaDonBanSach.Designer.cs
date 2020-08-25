using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNhaSach.Forms
{
        partial class formChiTietHoaDonBanSach
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

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.grboxChucNang = new System.Windows.Forms.GroupBox();
            this.chbNocation = new System.Windows.Forms.CheckBox();
            this.chbTatMau = new System.Windows.Forms.CheckBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamTrong = new System.Windows.Forms.Button();
            this.grboxChiTiet = new System.Windows.Forms.GroupBox();
            this.lbMessageError = new System.Windows.Forms.Label();
            this.grboxData = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.grboxSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
			
			this.lbid = new System.Windows.Forms.Label();
			this.numbid = new System.Windows.Forms.NumericUpDown();
			this.lbid_tblHoaDon = new System.Windows.Forms.Label();
			this.numbid_tblHoaDon = new System.Windows.Forms.NumericUpDown();
			this.btnfid_tblHoaDon = new System.Windows.Forms.Button();
			this.lbid_tblKhachHang = new System.Windows.Forms.Label();
			this.numbid_tblKhachHang = new System.Windows.Forms.NumericUpDown();
			this.btnfid_tblKhachHang = new System.Windows.Forms.Button();
			this.lbid_tblSach = new System.Windows.Forms.Label();
			this.numbid_tblSach = new System.Windows.Forms.NumericUpDown();
			this.btnfid_tblSach = new System.Windows.Forms.Button();
			this.lbsoLuong = new System.Windows.Forms.Label();
			this.numbsoLuong = new System.Windows.Forms.NumericUpDown();
            this.grboxChucNang.SuspendLayout();
            this.grboxChiTiet.SuspendLayout();
            this.grboxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.grboxSearch.SuspendLayout();
			
			((System.ComponentModel.ISupportInitialize)(this.numbid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numbid_tblHoaDon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numbid_tblKhachHang)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numbid_tblSach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numbsoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // grboxChucNang
            // 
            this.grboxChucNang.Controls.Add(this.chbNocation);
            this.grboxChucNang.Controls.Add(this.chbTatMau);
            this.grboxChucNang.Controls.Add(this.btnLuu);
            this.grboxChucNang.Controls.Add(this.btnHoanTac);
            this.grboxChucNang.Controls.Add(this.btnThem);
            this.grboxChucNang.Controls.Add(this.btnSua);
            this.grboxChucNang.Controls.Add(this.btnXoa);
            this.grboxChucNang.Controls.Add(this.btnLamTrong);
            this.grboxChucNang.Dock = System.Windows.Forms.DockStyle.Right;
            this.grboxChucNang.Location = new System.Drawing.Point(914, 0);
            this.grboxChucNang.Name = "grboxChucNang";
            this.grboxChucNang.Size = new System.Drawing.Size(120, 536);
            this.grboxChucNang.TabIndex = 0;
            this.grboxChucNang.TabStop = false;
            this.grboxChucNang.Text = "Chức năng";
            // 
            // chbNocation
            // 
            this.chbNocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.chbNocation.AutoSize = true;
            this.chbNocation.Checked = true;
            this.chbNocation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbNocation.Enabled = true;
            this.chbNocation.Location = new System.Drawing.Point(9, 500);
            this.chbNocation.Name = "chbNocation";
            this.chbNocation.Size = new System.Drawing.Size(99, 17);
            this.chbNocation.TabIndex = 12;
            this.chbNocation.Text = "Hiện thông báo";
            this.chbNocation.UseVisualStyleBackColor = true;
            this.chbNocation.CheckedChanged += new System.EventHandler(this.chbNocation_CheckedChanged);
            // 
            // chbTatMau
            // 
            this.chbTatMau.AutoSize = true;
            this.chbTatMau.Checked = true;
            this.chbTatMau.Location = new System.Drawing.Point(9, 523);
            this.chbTatMau.Name = "chbTatMau";
            this.chbTatMau.Size = new System.Drawing.Size(102, 17);
            this.chbTatMau.TabIndex = 13;
            this.chbTatMau.Text = "Màu hiển thị";
            this.chbTatMau.UseVisualStyleBackColor = true;
            this.chbTatMau.CheckedChanged += new System.EventHandler(this.chbTatMau_CheckedChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleDescription = "";
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Navy;
            this.btnLuu.Image = global::QLNhaSach.Properties.Resources.img__8_;
            this.btnLuu.Location = new System.Drawing.Point(9, 416);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(99, 72);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.AccessibleDescription = "";
            this.btnHoanTac.BackColor = System.Drawing.Color.Transparent;
            this.btnHoanTac.FlatAppearance.BorderSize = 0;
            this.btnHoanTac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanTac.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTac.ForeColor = System.Drawing.Color.Navy;
            this.btnHoanTac.Image = global::QLNhaSach.Properties.Resources.img__15_;
            this.btnHoanTac.Location = new System.Drawing.Point(9, 338);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(99, 72);
            this.btnHoanTac.TabIndex = 10;
            this.btnHoanTac.Text = "Hoàn tác";
            this.btnHoanTac.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnHoanTac.UseVisualStyleBackColor = false;
            this.btnHoanTac.Click += new System.EventHandler(this.btnHoanTac_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleDescription = "";
            this.btnThem.AccessibleName = "";
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Navy;
            this.btnThem.Image = global::QLNhaSach.Properties.Resources.img__7_;
            this.btnThem.Location = new System.Drawing.Point(9, 104);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 72);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleDescription = "";
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Navy;
            this.btnSua.Image = global::QLNhaSach.Properties.Resources.img__13_;
            this.btnSua.Location = new System.Drawing.Point(9, 182);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 72);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleDescription = "";
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Navy;
            this.btnXoa.Image = global::QLNhaSach.Properties.Resources.img__10_;
            this.btnXoa.Location = new System.Drawing.Point(9, 260);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 72);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AccessibleDescription = "";
            this.btnLamMoi.AccessibleName = "";
            this.btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Navy;
            this.btnLamMoi.Image = global::QLNhaSach.Properties.Resources.img__14_;
            this.btnLamMoi.Location = new System.Drawing.Point(478, 16);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(111, 72);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleDescription = "";
            this.btnTimKiem.AccessibleName = "";
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Navy;
            this.btnTimKiem.Image = global::QLNhaSach.Properties.Resources.img__1_;
            this.btnTimKiem.Location = new System.Drawing.Point(367, 16);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(111, 72);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamTrong
            // 
            this.btnLamTrong.AccessibleDescription = "";
            this.btnLamTrong.AccessibleName = "";
            this.btnLamTrong.BackColor = System.Drawing.Color.Transparent;
            this.btnLamTrong.FlatAppearance.BorderSize = 0;
            this.btnLamTrong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamTrong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamTrong.ForeColor = System.Drawing.Color.Navy;
            this.btnLamTrong.Image = global::QLNhaSach.Properties.Resources.img__4_;
            this.btnLamTrong.Location = new System.Drawing.Point(9, 26);
            this.btnLamTrong.Name = "btnLamTrong";
            this.btnLamTrong.Size = new System.Drawing.Size(99, 72);
            this.btnLamTrong.TabIndex = 6;
            this.btnLamTrong.Text = "Xoá ds nhập";
            this.btnLamTrong.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLamTrong.UseVisualStyleBackColor = false;
            this.btnLamTrong.Click += new System.EventHandler(this.btnLamTrong_Click);
            // 
            // grboxChiTiet
            // 
            this.grboxChiTiet.Controls.Add(this.lbMessageError);
			
			this.grboxChiTiet.Controls.Add(this.lbid);
			this.grboxChiTiet.Controls.Add(this.numbid);
			this.grboxChiTiet.Controls.Add(this.lbid_tblHoaDon);
			this.grboxChiTiet.Controls.Add(this.numbid_tblHoaDon);
			this.grboxChiTiet.Controls.Add(this.btnfid_tblHoaDon);
			this.grboxChiTiet.Controls.Add(this.lbid_tblKhachHang);
			this.grboxChiTiet.Controls.Add(this.numbid_tblKhachHang);
			this.grboxChiTiet.Controls.Add(this.btnfid_tblKhachHang);
			this.grboxChiTiet.Controls.Add(this.lbid_tblSach);
			this.grboxChiTiet.Controls.Add(this.numbid_tblSach);
			this.grboxChiTiet.Controls.Add(this.btnfid_tblSach);
			this.grboxChiTiet.Controls.Add(this.lbsoLuong);
			this.grboxChiTiet.Controls.Add(this.numbsoLuong);
            this.grboxChiTiet.Dock = System.Windows.Forms.DockStyle.Right;
            this.grboxChiTiet.Location = new System.Drawing.Point(608, 0);
            this.grboxChiTiet.Name = "grboxChiTiet";
            this.grboxChiTiet.Size = new System.Drawing.Size(306, 536);
            this.grboxChiTiet.TabIndex = 1;
            this.grboxChiTiet.TabStop = false;
            this.grboxChiTiet.Text = "Chi tiết";
            // 
            // lbMessageError
            // 
            this.lbMessageError.AutoSize = true;
            this.lbMessageError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbMessageError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessageError.Location = new System.Drawing.Point(3, 520);
            this.lbMessageError.Name = "lbMessageError";
            this.lbMessageError.Size = new System.Drawing.Size(10, 13);
            this.lbMessageError.TabIndex = 1;
            this.lbMessageError.Text = ":";
            // 
            // grboxData
            // 
            this.grboxData.Controls.Add(this.dgvData);
            this.grboxData.Controls.Add(this.grboxSearch);
            this.grboxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grboxData.Location = new System.Drawing.Point(0, 0);
            this.grboxData.Name = "grboxData";
            this.grboxData.Size = new System.Drawing.Size(608, 536);
            this.grboxData.TabIndex = 2;
            this.grboxData.TabStop = false;
            this.grboxData.Text = "Data";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(3, 120);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(602, 413);
            this.dgvData.TabIndex = 0;
            this.dgvData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_RowEnter);
            this.dgvData.Sorted += new System.EventHandler(this.dgvData_Sorted);
            // 
            // grboxSearch
            // 
            this.grboxSearch.Controls.Add(this.txtSearch);
            this.grboxSearch.Controls.Add(this.btnLamMoi);
            this.grboxSearch.Controls.Add(this.btnTimKiem);
            this.grboxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grboxSearch.Location = new System.Drawing.Point(3, 16);
            this.grboxSearch.Name = "grboxSearch";
            this.grboxSearch.Size = new System.Drawing.Size(602, 104);
            this.grboxSearch.TabIndex = 2;
            this.grboxSearch.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(348, 26);
            this.txtSearch.TabIndex = 3;
			
            
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(6, 42);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(72, 13);
            this.lbid.Text = "(*) Cột id (Mã tự tăng)";
            
            // 
            // lbid_tblHoaDon
            // 
            this.lbid_tblHoaDon.AutoSize = true;
            this.lbid_tblHoaDon.Location = new System.Drawing.Point(6, 89);
            this.lbid_tblHoaDon.Name = "lbid_tblHoaDon";
            this.lbid_tblHoaDon.Size = new System.Drawing.Size(72, 13);
            this.lbid_tblHoaDon.Text = "Cột id_tblHoaDon";
            
            // 
            // lbid_tblKhachHang
            // 
            this.lbid_tblKhachHang.AutoSize = true;
            this.lbid_tblKhachHang.Location = new System.Drawing.Point(6, 136);
            this.lbid_tblKhachHang.Name = "lbid_tblKhachHang";
            this.lbid_tblKhachHang.Size = new System.Drawing.Size(72, 13);
            this.lbid_tblKhachHang.Text = "Cột id_tblKhachHang";
            
            // 
            // lbid_tblSach
            // 
            this.lbid_tblSach.AutoSize = true;
            this.lbid_tblSach.Location = new System.Drawing.Point(6, 183);
            this.lbid_tblSach.Name = "lbid_tblSach";
            this.lbid_tblSach.Size = new System.Drawing.Size(72, 13);
            this.lbid_tblSach.Text = "Cột id_tblSach";
            
            // 
            // lbsoLuong
            // 
            this.lbsoLuong.AutoSize = true;
            this.lbsoLuong.Location = new System.Drawing.Point(6, 230);
            this.lbsoLuong.Name = "lbsoLuong";
            this.lbsoLuong.Size = new System.Drawing.Size(72, 13);
            this.lbsoLuong.Text = "Cột soLuong";
			
            
            // 
            // numbid
            // 
            this.numbid.Location = new System.Drawing.Point(50, 63);
            this.numbid.Name = "numbid";
            this.numbid.Size = new System.Drawing.Size(225, 20);
            this.numbid.Maximum = new decimal(new int[] {
            int.MaxValue,int.MinValue,
            0,
            0});
            this.numbid.TabIndex = 2;
			this.numbid.Enabled = false;
            
            // 
            // numbid_tblHoaDon
            // 
            this.numbid_tblHoaDon.Location = new System.Drawing.Point(50, 110);
            this.numbid_tblHoaDon.Name = "numbid_tblHoaDon";
            this.numbid_tblHoaDon.Size = new System.Drawing.Size(142, 20);
            this.numbid_tblHoaDon.Maximum = new decimal(new int[] {
            int.MaxValue,int.MinValue,
            0,
            0});
            this.numbid_tblHoaDon.TabIndex = 2;
            // 
            // btnfid_tblHoaDon
            // 
            this.btnfid_tblHoaDon.Location = new System.Drawing.Point(200, 110);
            this.btnfid_tblHoaDon.Name = "btnfid_tblHoaDon";
            this.btnfid_tblHoaDon.Size = new System.Drawing.Size(75, 21);
            this.btnfid_tblHoaDon.TabIndex = 2;
            this.btnfid_tblHoaDon.Text = "Chọn";
            this.btnfid_tblHoaDon.UseVisualStyleBackColor = true;
            this.btnfid_tblHoaDon.Click += new System.EventHandler(this.btnfid_tblHoaDon_Click);
            
            // 
            // numbid_tblKhachHang
            // 
            this.numbid_tblKhachHang.Location = new System.Drawing.Point(50, 157);
            this.numbid_tblKhachHang.Name = "numbid_tblKhachHang";
            this.numbid_tblKhachHang.Size = new System.Drawing.Size(142, 20);
            this.numbid_tblKhachHang.Maximum = new decimal(new int[] {
            int.MaxValue,int.MinValue,
            0,
            0});
            this.numbid_tblKhachHang.TabIndex = 2;
            // 
            // btnfid_tblKhachHang
            // 
            this.btnfid_tblKhachHang.Location = new System.Drawing.Point(200, 157);
            this.btnfid_tblKhachHang.Name = "btnfid_tblKhachHang";
            this.btnfid_tblKhachHang.Size = new System.Drawing.Size(75, 21);
            this.btnfid_tblKhachHang.TabIndex = 2;
            this.btnfid_tblKhachHang.Text = "Chọn";
            this.btnfid_tblKhachHang.UseVisualStyleBackColor = true;
            this.btnfid_tblKhachHang.Click += new System.EventHandler(this.btnfid_tblKhachHang_Click);
            
            // 
            // numbid_tblSach
            // 
            this.numbid_tblSach.Location = new System.Drawing.Point(50, 204);
            this.numbid_tblSach.Name = "numbid_tblSach";
            this.numbid_tblSach.Size = new System.Drawing.Size(142, 20);
            this.numbid_tblSach.Maximum = new decimal(new int[] {
            int.MaxValue,int.MinValue,
            0,
            0});
            this.numbid_tblSach.TabIndex = 2;
            // 
            // btnfid_tblSach
            // 
            this.btnfid_tblSach.Location = new System.Drawing.Point(200, 204);
            this.btnfid_tblSach.Name = "btnfid_tblSach";
            this.btnfid_tblSach.Size = new System.Drawing.Size(75, 21);
            this.btnfid_tblSach.TabIndex = 2;
            this.btnfid_tblSach.Text = "Chọn";
            this.btnfid_tblSach.UseVisualStyleBackColor = true;
            this.btnfid_tblSach.Click += new System.EventHandler(this.btnfid_tblSach_Click);
            
            // 
            // numbsoLuong
            // 
            this.numbsoLuong.Location = new System.Drawing.Point(50, 251);
            this.numbsoLuong.Name = "numbsoLuong";
            this.numbsoLuong.Size = new System.Drawing.Size(225, 20);
            this.numbsoLuong.Maximum = new decimal(new int[] {
            int.MaxValue,int.MinValue,
            0,
            0});
            this.numbsoLuong.TabIndex = 2;
            // 
            // formChiTietHoaDonBanSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.grboxData);
            this.Controls.Add(this.grboxChiTiet);
            this.Controls.Add(this.grboxChucNang);
            this.MinimumSize = new System.Drawing.Size(1050, 600);
            this.Name = "formChiTietHoaDonBanSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chào mừng, quản lý bảng ChiTietHoaDonBanSach";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formChiTietHoaDonBanSach_FormClosed);
            this.Load += new System.EventHandler(this.formChiTietHoaDonBanSach_Load);
            this.grboxChucNang.ResumeLayout(false);
            this.grboxChiTiet.ResumeLayout(false);
            this.grboxChiTiet.PerformLayout();
            this.grboxData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.grboxSearch.ResumeLayout(false);
            this.grboxSearch.PerformLayout();
			
			((System.ComponentModel.ISupportInitialize)(this.numbid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numbid_tblHoaDon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numbid_tblKhachHang)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numbid_tblSach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numbsoLuong)).EndInit();
            this.EnabledChanged += new System.EventHandler(this.formChiTietHoaDonBanSach_EnabledChanged);
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxChucNang;
        private System.Windows.Forms.GroupBox grboxChiTiet;
        private System.Windows.Forms.GroupBox grboxData;
        private System.Windows.Forms.GroupBox grboxSearch;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamTrong;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbMessageError;
        private System.Windows.Forms.CheckBox chbNocation;
        private System.Windows.Forms.CheckBox chbTatMau;
		
		private System.Windows.Forms.Label lbid;
		private System.Windows.Forms.Label lbid_tblHoaDon;
		private System.Windows.Forms.Label lbid_tblKhachHang;
		private System.Windows.Forms.Label lbid_tblSach;
		private System.Windows.Forms.Label lbsoLuong;
		
		private System.Windows.Forms.NumericUpDown numbid;
		private System.Windows.Forms.NumericUpDown numbid_tblHoaDon;
		private System.Windows.Forms.Button btnfid_tblHoaDon;
		private System.Windows.Forms.NumericUpDown numbid_tblKhachHang;
		private System.Windows.Forms.Button btnfid_tblKhachHang;
		private System.Windows.Forms.NumericUpDown numbid_tblSach;
		private System.Windows.Forms.Button btnfid_tblSach;
		private System.Windows.Forms.NumericUpDown numbsoLuong;
    }
}