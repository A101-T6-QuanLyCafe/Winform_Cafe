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
    public partial class flogin : Form
    {
        CoffeeShopDBDataContext Database = new CoffeeShopDBDataContext();
        public flogin()
        {
           
            InitializeComponent();
            
            if (Properties.Settings.Default.RememberMe)
            {
                txtEmail.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password; 
                chkRememberMe.Checked = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
                string enteredEmail = txtEmail.Text;
                string enteredPassword = txtPassword.Text;

            // Kiểm tra thông tin đăng nhập
            var user = Database.Employees.SingleOrDefault(emp => emp.USERNAME == enteredEmail && emp.PASSWORD == enteredPassword && emp.ISDELETE==0);

                if (user != null)
                {
                    // Đăng nhập thành công
                 MessageBox.Show("Đăng nhập thành công!");

                if (chkRememberMe.Checked)
                {
                    // Nếu người dùng chọn "Nhớ tài khoản"
                    Properties.Settings.Default.Username = enteredEmail;
                    Properties.Settings.Default.Password = enteredPassword;
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
                FMain fr = new FMain();
                fr.ShowDialog();
                }
                else
                {
                    // Đăng nhập thất bại
                    MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại thông tin đăng nhập.");
                    txtEmail.Focus();
                }
            
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
