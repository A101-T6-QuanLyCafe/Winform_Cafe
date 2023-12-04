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
    public partial class MyAccount : Form
    {
        Employee emp;
        public MyAccount(Employee _emp)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            emp = _emp;
            txt_password.PasswordChar = '*';
            PutDataToCBOGender();
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            txt_firstName.Text = emp.FirstName;
            txt_lastName.Text = emp.LastName;
            txt_email.Text = emp.EMAIL;
            txt_phone.Text = emp.PHONE;
            txt_username.Text = emp.USERNAME;
            txt_password.Text = emp.PASSWORD;
            dtpk_dob.Value = emp.DOB;
            cbo_gender.Text = emp.SEX;
            cbo_gender.SelectedIndex = cbo_gender.Items.IndexOf(emp.SEX);
        }

        private void btn_showPass_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '*')
                txt_password.PasswordChar = '\0';
            else
                txt_password.PasswordChar = '*';
        }

        private void PutDataToCBOGender()
        {
            List<String> genders = new List<String>();
            genders.Add("Nam");
            genders.Add("Nữ");
            genders.Add("Khác");
            cbo_gender.DataSource = genders;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            emp.DOB = dtpk_dob.Value;
            emp.SEX = cbo_gender.SelectedItem.ToString();
            emp.PASSWORD = txt_password.Text;
            EmployeesBLL.EditEmployee(emp);
        }
    }
}
