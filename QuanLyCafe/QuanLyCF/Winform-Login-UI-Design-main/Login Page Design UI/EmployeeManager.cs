using BLL;
using InputTextBoxLib;
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
    public partial class EmployeeManager : Form
    {

        public EmployeeManager()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void EmployeeManager_Load(object sender, EventArgs e)
        {
            PutDataToCBOSearch();
            PutDataToCBOGender();
            btn_search.PerformClick();
        }

        private void PutDataToCBOSearch()
        {
            DataTable searcher = new DataTable();
            searcher.Columns.Add("key");
            searcher.Columns.Add("value");
            searcher.Rows.Add("NAME", "Họ tên");
            searcher.Rows.Add("PHONE", "số điện thoại");
            searcher.Rows.Add("USERNAME", "Tên tài khoản");

            cbo_searchBy.DataSource = searcher;
            cbo_searchBy.DisplayMember = "value";
            cbo_searchBy.ValueMember = "key";
        }

        private void PutDataToCBOGender()
        {
            List<String> genders = new List<String>();
            genders.Add("Nam");
            genders.Add("Nữ");
            genders.Add("Khác");
            cbo_gender.DataSource = genders;
            sntxt_password.PasswordChar = '*';
            btn_active.Enabled = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            List<Employee> emp = EmployeesBLL.getAllEmpFill(txt_search.Text, cbo_searchBy.SelectedValue.ToString(), cb_isDelete.Checked);
            dataGridView1.DataSource = emp.Select(x => new { x.EmployeeID, x.FirstName, x.LastName, x.EMAIL, x.PHONE, x.USERNAME, x.DOB, x.SEX }).ToList();
        }

        private void cb_isDelete_CheckedChanged(object sender, EventArgs e)
        {
            btn_active.Enabled = cb_isDelete.Checked;
            btn_remove.Enabled = !cb_isDelete.Checked;
            btn_add.Enabled = !cb_isDelete.Checked;
            btn_clear.PerformClick();
            btn_search.PerformClick();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rtxt_firstName.Text = "";
            rtxt_firstName.Text = "";
            cbo_gender.SelectedIndex = 0;
            ntxt_ma.Text = "";
            sntxt_username.Text = "";
            sntxt_password.Text = "";
            dtpk_dob.Value = DateTime.Parse("2000-01-01");
            etxt_email.Text ="";
            rtxt_phone.Text ="";
        }

        private void btn_showPass_Click(object sender, EventArgs e)
        {
            if (sntxt_password.PasswordChar == '*')
            {
                sntxt_password.PasswordChar = '\0';
            }
            else
            {
                sntxt_password.PasswordChar = '*';
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int empid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Employee emp = EmployeesBLL.GetEmpByID(empid);
            rtxt_firstName.Text = emp.FirstName;
            rtxt_lastName.Text = emp.LastName;
            cbo_gender.Text = emp.SEX;
            ntxt_ma.Text = emp.EmployeeID.ToString();
            sntxt_username.Text = emp.USERNAME;
            sntxt_password.Text = emp.PASSWORD;
            dtpk_dob.Value = emp.DOB;
            etxt_email.Text = emp.EMAIL;
            rtxt_phone.Text = emp.PHONE;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!IsValidate())
                return;

            //create new employee
            Employee emp = new Employee();
            emp.FirstName = rtxt_firstName.Text;
            emp.LastName = rtxt_lastName.Text;
            emp.SEX = cbo_gender.SelectedItem.ToString();
            emp.USERNAME = sntxt_username.Text;
            emp.PASSWORD = sntxt_password.Text;
            emp.EMAIL = etxt_email.Text;
            emp.DOB = dtpk_dob.Value;
            emp.EMAIL = etxt_email.Text;
            emp.PHONE = rtxt_phone.Text;

            //reload datagrdview if success
            String error = EmployeesBLL.AddEmployee(emp);
            if (error.Length <= 0)
                btn_search.PerformClick();
            else
                MessageBox.Show(error);
        }
        private Boolean IsValidate()
        {
            foreach (Control item in panel2.Controls)
            {
                if (!item.GetType().IsSubclassOf(typeof(RequireValueTextBox)))
                    continue;

                if ((item as RequireValueTextBox).errorProvider.GetError(item) != "")
                {
                    return false;
                }
            }
            return true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!IsValidate()) return;
            // create new employee
            Employee emp = new Employee();
            emp.EmployeeID = int.Parse(ntxt_ma.Text);
            emp.FirstName = rtxt_firstName.Text;
            emp.LastName = rtxt_lastName.Text;
            emp.SEX = cbo_gender.SelectedItem.ToString();
            emp.USERNAME = sntxt_username.Text;
            emp.PASSWORD = sntxt_password.Text;
            emp.EMAIL = etxt_email.Text;
            emp.DOB = dtpk_dob.Value;
            emp.EMAIL = etxt_email.Text;
            emp.PHONE = rtxt_phone.Text;
            // if success reload datagridview
            String error = EmployeesBLL.EditEmployee(emp);
            if (error.Length <= 0)
                btn_search.PerformClick();
            else
                MessageBox.Show(error);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (ntxt_ma.Text.Length == 0) return;
            EmployeesBLL.RemoveEmployee(ntxt_ma.Text);
            btn_search.PerformClick();
        }

        private void btn_active_Click(object sender, EventArgs e)
        {
            if (ntxt_ma.Text.Length == 0) return;
            EmployeesBLL.ActiveEmployee(ntxt_ma.Text);
            btn_search.PerformClick();
        }

       
    }
}
