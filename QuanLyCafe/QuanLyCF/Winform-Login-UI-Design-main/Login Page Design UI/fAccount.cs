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
    public partial class fAccount : Form
    {
        public fAccount()
        {
            InitializeComponent();

           

        }
        EmployeesBLL EmBLL = new EmployeesBLL();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            if (txtPw.Text != txt_Re_PW.Text)
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu chính xác !");
                txt_Re_PW.Focus();
            }
            else
            {
                int id = Int32.Parse(EmBLL.GetEmployeeIDByEmail(Properties.Settings.Default.Username).ToString());
                string firstname = txtF_Name.Text;
                string lastname = txtL_Name.Text;
                string email = txtEmail.Text;
                string pass = txt_Re_PW.Text;
                Employee employee = new Employee(id,firstname,lastname,email,pass);
                if (EmBLL.Update2(employee))
                {
                    MessageBox.Show("cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("cập nhật thất bại");
                }
               
            }
        }

        private void fAccount_Load(object sender, EventArgs e)
        {
            txtEmail.Enabled = false;
            Employee employee = new Employee();
            employee =EmBLL.GetEmployeeByEmail(Properties.Settings.Default.Username);
            txtF_Name.Text = employee.FirstName;
            txtL_Name.Text = employee.LastName;
            txtEmail.Text=employee.EMAIL;
            txtPw.Text = employee.PASSWORD;
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
