using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLNhaSach.Logics;

namespace QLNhaSach.Forms
{
    partial class fSearchAndReturn
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
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grboxData = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.grboxSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.chbTatMau = new System.Windows.Forms.CheckBox();
            this.grboxChucNang.SuspendLayout();
            this.grboxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.grboxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grboxChucNang
            // 
            this.grboxChucNang.Controls.Add(this.chbTatMau);
            this.grboxChucNang.Controls.Add(this.btnHuyBo);
            this.grboxChucNang.Controls.Add(this.btnChon);
            this.grboxChucNang.Dock = System.Windows.Forms.DockStyle.Right;
            this.grboxChucNang.Location = new System.Drawing.Point(914, 0);
            this.grboxChucNang.Name = "grboxChucNang";
            this.grboxChucNang.Size = new System.Drawing.Size(120, 536);
            this.grboxChucNang.TabIndex = 0;
            this.grboxChucNang.TabStop = false;
            this.grboxChucNang.Text = "Chức năng";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.AccessibleDescription = "";
            this.btnHuyBo.BackColor = System.Drawing.Color.Transparent;
            this.btnHuyBo.FlatAppearance.BorderSize = 0;
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.ForeColor = System.Drawing.Color.Navy;
            this.btnHuyBo.Image = global::QLNhaSach.Properties.Resources.img__10_;
            this.btnHuyBo.Location = new System.Drawing.Point(9, 104);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(99, 72);
            this.btnHuyBo.TabIndex = 9;
            this.btnHuyBo.Text = "Huỷ bỏ";
            this.btnHuyBo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnChon
            // 
            this.btnChon.AccessibleDescription = "";
            this.btnChon.AccessibleName = "";
            this.btnChon.BackColor = System.Drawing.Color.Transparent;
            this.btnChon.FlatAppearance.BorderSize = 0;
            this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.ForeColor = System.Drawing.Color.Navy;
            this.btnChon.Image = global::QLNhaSach.Properties.Resources.img__4_;
            this.btnChon.Location = new System.Drawing.Point(9, 26);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(99, 72);
            this.btnChon.TabIndex = 6;
            this.btnChon.Text = "Chọn";
            this.btnChon.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
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
            this.btnLamMoi.Location = new System.Drawing.Point(794, 16);
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
            this.btnTimKiem.Location = new System.Drawing.Point(683, 16);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(111, 72);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // grboxData
            // 
            this.grboxData.Controls.Add(this.dgvData);
            this.grboxData.Controls.Add(this.grboxSearch);
            this.grboxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grboxData.Location = new System.Drawing.Point(0, 0);
            this.grboxData.Name = "grboxData";
            this.grboxData.Size = new System.Drawing.Size(914, 536);
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
            this.dgvData.Size = new System.Drawing.Size(908, 413);
            this.dgvData.TabIndex = 0;
            this.dgvData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_RowEnter);
            // 
            // grboxSearch
            // 
            this.grboxSearch.Controls.Add(this.txtSearch);
            this.grboxSearch.Controls.Add(this.btnLamMoi);
            this.grboxSearch.Controls.Add(this.btnTimKiem);
            this.grboxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grboxSearch.Location = new System.Drawing.Point(3, 16);
            this.grboxSearch.Name = "grboxSearch";
            this.grboxSearch.Size = new System.Drawing.Size(908, 104);
            this.grboxSearch.TabIndex = 2;
            this.grboxSearch.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(664, 26);
            this.txtSearch.TabIndex = 3;
            // 
            // chbTatMau
            // 
            this.chbTatMau.AutoSize = true;
            this.chbTatMau.Checked = true;
            this.chbTatMau.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTatMau.Location = new System.Drawing.Point(9, 507);
            this.chbTatMau.Name = "chbTatMau";
            this.chbTatMau.Size = new System.Drawing.Size(84, 17);
            this.chbTatMau.TabIndex = 14;
            this.chbTatMau.Text = "Màu hiển thị";
            this.chbTatMau.UseVisualStyleBackColor = true;
            this.chbTatMau.CheckedChanged += new System.EventHandler(this.chbTatMau_CheckedChanged);
            // 
            // fSearchAndReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1034, 536);
            this.Controls.Add(this.grboxData);
            this.Controls.Add(this.grboxChucNang);
            this.MinimumSize = new System.Drawing.Size(1050, 575);
            this.Name = "fSearchAndReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chào mừng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formtblDiem_FormClosed);
            this.Load += new System.EventHandler(this.formtblDiem_Load);
            this.grboxChucNang.ResumeLayout(false);
            this.grboxData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.grboxSearch.ResumeLayout(false);
            this.grboxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxChucNang;
        private System.Windows.Forms.GroupBox grboxData;
        private System.Windows.Forms.GroupBox grboxSearch;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chbTatMau;
    }
}