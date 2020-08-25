using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaSach
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void MakeEmptyInput(bool focusUsername = true)
        {
            txtUsername.Text = null;
            txtPassword.Text = null;
            if (focusUsername) txtUsername.Focus();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chbRemeberMe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // check username + password ở đây
            string username = "admin";
            string password = "admin";

            // kiểm tra nếu rỗng thì báo lỗi
            if (txtUsername.Text.Length <= 0 || txtPassword.Text.Length <= 0)
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được phép để rỗng");
                return;
            }
            
            // check login
            if(txtUsername.Text == username && txtPassword.Text == password)
            {
                // đăng nhập thành công
                var form = new Main();
                form.Owner = this;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!\nXin hãy kiểm tra lại.");
                return;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MakeEmptyInput();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if(txtUsername.Text.Length <= 0)
            {
                this.picUsernameWarning.Image = global::QLNhaSach.Properties.Resources.warning;
            }
            else
            {
                this.picUsernameWarning.Image = null;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length <= 0)
            {
                this.picPasswordWarning.Image = global::QLNhaSach.Properties.Resources.warning;
            }
            else
            {
                this.picPasswordWarning.Image = null;
            }
        }
    }
}
