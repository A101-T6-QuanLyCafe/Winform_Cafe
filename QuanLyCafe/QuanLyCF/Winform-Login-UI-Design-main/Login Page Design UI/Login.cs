using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page_Design_UI
{
    public partial class Login : Form
    {
        Employee _employee;
        public Login()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*';
            this.StartPosition = FormStartPosition.CenterScreen;
            if (Properties.Settings.Default.RememberMe)
            {
                txt_username.Text = Properties.Settings.Default.Username;
                txt_password.Text = Properties.Settings.Default.Password;
                cb_remember.Checked = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            if (username.Length == 0 || password.Length == 0)
                return;

            // Kiểm tra thông tin đăng nhập
            _employee = EmployeesBLL.Login(username, password);

            if (_employee != null)
            {
                // Đăng nhập thành công

                if (cb_remember.Checked)
                {
                    // Nếu người dùng chọn "Nhớ tài khoản"
                    Properties.Settings.Default.Username = username;
                    Properties.Settings.Default.Password = password;
                    Properties.Settings.Default.RememberMe = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    // Nếu người dùng không chọn "Nhớ tài khoản"
                    Properties.Settings.Default.Username = string.Empty;
                    Properties.Settings.Default.Password = string.Empty;
                    Properties.Settings.Default.RememberMe = false;
                    Properties.Settings.Default.Save();
                }
                FMain fr = new FMain(_employee);
                this.Hide();
                fr.ShowDialog();
                this.Show();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại thông tin đăng nhập.");
                txt_username.Focus();
            }
        }

        private void btn_showPassword_Click(object sender, EventArgs e)
        {
            if(txt_password.PasswordChar == '*')
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát ?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if(DialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }

        }
    }
}
