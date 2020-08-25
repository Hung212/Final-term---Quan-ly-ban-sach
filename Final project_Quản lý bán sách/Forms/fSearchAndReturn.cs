using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using QLNhaSach.Configs;
using QLNhaSach.Logics;

namespace QLNhaSach.Forms
{
    public partial class fSearchAndReturn : Form
    {
        object[] valueReturn;
        public string[] columnName { get; private set; }
        public string commandQuery { get; private set; }
        public fSearchAndReturn()
        {
            InitializeComponent();
        }
        public fSearchAndReturn(string commandQuery, params string[] columnName)
        {
            this.columnName = columnName;
            this.commandQuery = commandQuery;
            InitializeComponent();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            formtblDiem_FormClosed(sender, new FormClosedEventArgs(CloseReason.UserClosing));
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
			this.dgvData.DataSource = Connection.ExecuteQuery(commandQuery);
            dgvData_Sorted(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(this.txtSearch.Text != null)
            {
                FunctionHelper.Find(this.txtSearch.Text, ref this.dgvData);
            }
        }

        private void dgvData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            List<object> result = new List<object>();
            try
            {
                if(e.RowIndex < this.dgvData.Rows.Count)
                {
                    
                    foreach (string item in columnName)
                    {
                        var columnValue = this.dgvData.Rows[e.RowIndex].Cells[item].Value;
                        if (columnValue != null)
                            result.Add(columnValue);
                    }
                }
            }
            catch (Exception) { }
            valueReturn = result.ToArray();
        }

        private void formtblDiem_Load(object sender, EventArgs e)
        {
            btnLamMoi_Click(sender, e);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Owner != null)
                {
                    this.Owner.Tag = valueReturn;
                    formtblDiem_FormClosed(sender, new FormClosedEventArgs(CloseReason.UserClosing));
                }
            }
            catch (Exception) { }
        }

        private void formtblDiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (this.Owner != null)
                {
                    this.Owner.Show();
                    this.Owner.Enabled = true;
                    this.Owner = null;
                    this.Dispose();
                }
            }
            catch (Exception) { }
        }

        private void dgvData_Sorted(object sender, EventArgs e)
        {
            if (!this.chbTatMau.Checked)
                return;

            bool bluebackgroud = false;
            foreach (DataGridViewRow item in this.dgvData.Rows)
            {
                if (bluebackgroud)
                {
                    item.DefaultCellStyle.BackColor = Color.SkyBlue;
                    bluebackgroud = false;
                }
                else
                    bluebackgroud = true;
            }
        }

        private void chbTatMau_CheckedChanged(object sender, EventArgs e)
        {
            btnLamMoi_Click(sender, e);
        }
    }
}