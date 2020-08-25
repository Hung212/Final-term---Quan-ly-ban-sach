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
    public partial class formTraCuu : Form
    {
        public string commandQuery { get; private set; }
        public formTraCuu(string commandQuery)
        {
            this.commandQuery = commandQuery;
            InitializeComponent();
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

        private void formtblDiem_Load(object sender, EventArgs e)
        {
            btnLamMoi_Click(sender, e);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            FunctionHelper.ExportExcel(ref this.dgvData, "tracuu");
        }

        private void chbTatMau_CheckedChanged(object sender, EventArgs e)
        {
            dgvData_Sorted(sender, e);
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
    }
}