using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLNhaSach.Logics;

namespace QLNhaSach.Forms
{
    partial class formTraCuu
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
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grboxData = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.grboxSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grboxChucNang = new System.Windows.Forms.GroupBox();
            this.chbTatMau = new System.Windows.Forms.CheckBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.grboxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.grboxSearch.SuspendLayout();
            this.grboxChucNang.SuspendLayout();
            this.SuspendLayout();
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
            this.btnLamMoi.Location = new System.Drawing.Point(690, 16);
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
            this.btnTimKiem.Location = new System.Drawing.Point(579, 16);
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
            this.grboxData.Size = new System.Drawing.Size(830, 550);
            this.grboxData.TabIndex = 2;
            this.grboxData.TabStop = false;
            this.grboxData.Text = "Data";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(3, 120);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(824, 427);
            this.dgvData.TabIndex = 0;
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
            this.grboxSearch.Size = new System.Drawing.Size(824, 104);
            this.grboxSearch.TabIndex = 2;
            this.grboxSearch.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(560, 26);
            this.txtSearch.TabIndex = 3;
            // 
            // grboxChucNang
            // 
            this.grboxChucNang.Controls.Add(this.chbTatMau);
            this.grboxChucNang.Controls.Add(this.btnLuu);
            this.grboxChucNang.Dock = System.Windows.Forms.DockStyle.Right;
            this.grboxChucNang.Location = new System.Drawing.Point(830, 0);
            this.grboxChucNang.Name = "grboxChucNang";
            this.grboxChucNang.Size = new System.Drawing.Size(120, 550);
            this.grboxChucNang.TabIndex = 3;
            this.grboxChucNang.TabStop = false;
            this.grboxChucNang.Text = "Chức năng";
            // 
            // chbTatMau
            // 
            this.chbTatMau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chbTatMau.AutoSize = true;
            this.chbTatMau.Checked = true;
            this.chbTatMau.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTatMau.Location = new System.Drawing.Point(9, 515);
            this.chbTatMau.Name = "chbTatMau";
            this.chbTatMau.Size = new System.Drawing.Size(84, 17);
            this.chbTatMau.TabIndex = 13;
            this.chbTatMau.Text = "Màu hiển thị";
            this.chbTatMau.UseVisualStyleBackColor = true;
            this.chbTatMau.CheckedChanged += new System.EventHandler(this.chbTatMau_CheckedChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleDescription = "";
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Navy;
            this.btnLuu.Image = global::QLNhaSach.Properties.Resources.img__8_;
            this.btnLuu.Location = new System.Drawing.Point(9, 32);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(99, 72);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Xuất excel";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // formTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.grboxData);
            this.Controls.Add(this.grboxChucNang);
            this.Name = "formTraCuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chào mừng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formtblDiem_FormClosed);
            this.Load += new System.EventHandler(this.formtblDiem_Load);
            this.grboxData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.grboxSearch.ResumeLayout(false);
            this.grboxSearch.PerformLayout();
            this.grboxChucNang.ResumeLayout(false);
            this.grboxChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grboxData;
        private System.Windows.Forms.GroupBox grboxSearch;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtSearch;
        private GroupBox grboxChucNang;
        private CheckBox chbTatMau;
        private Button btnLuu;
    }
}