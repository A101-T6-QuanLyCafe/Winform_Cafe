using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page_Design_UI
{
    public partial class FQlNhanVien : Form
    {
        EmployeesBLL employeesBLL = new EmployeesBLL();
        public FQlNhanVien()
        {
            InitializeComponent();
        }
        public void LoadEmploy()
        {
            dtg_Employee.DataSource = employeesBLL.getAllEmployee();
        }
        private void FQlNhanVien_Load(object sender, EventArgs e)
        {
            LoadEmploy();
            cboGT.Items.Add("Nam");
            cboGT.Items.Add("Nữ");
            cboGT.Items.Add("khác");
        }

        private void ckISdelete_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtF_Name.Text.Length==0||txtLname.Text.Length==0) {
                MessageBox.Show("vui lòng nhập tên");
                txtF_Name.Focus();
            }else if (txtEmail.Text.Length==0){
                MessageBox.Show("vui lòng nhập email");
                txtEmail.Focus();
            }else if (txtPhone.Text.Length==0)
            {
                MessageBox.Show("vui lòng nhập điện thoại");
                txtPhone.Focus();

            }else if (txtUsername.Text.Length==0)
            {
                MessageBox.Show("vui lòng nhập username");
                txtUsername.Focus();
            }
            else if (txtRePW.Text != txtPW.Text || txtRePW.Text.Length == 0 || txtPW.Text.Length == 0)
            {
                MessageBox.Show("vui lòng kiểm tra lại mật khẩu");
                txtPW.Focus();
            }
            else
            {

            }
            Employee newEmployee = new Employee { FirstName = txtF_Name.Text,
                LastName = txtLname.Text,
                EMAIL = txtEmail.Text,
                PHONE = txtPhone.Text,
                USERNAME = txtUsername.Text,
                PASSWORD = txtRePW.Text,
                DOB = dtp_DOB.Value,
                SEX = cboGT.SelectedItem.ToString()
            };
            try
            {
                employeesBLL.Insert(newEmployee);
                MessageBox.Show("thêm thành công");
                LoadEmploy();
            }
            catch 
            {

                MessageBox.Show("thất bại");
            }
                
                
               
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Employee emP = employeesBLL.GetEmployeeById(int.Parse(txtID.Text));
            try
            {
                employeesBLL.Delete(emP.EmployeeID);
                MessageBox.Show("thành công");
                LoadEmploy();
            }
            catch
            {

                MessageBox.Show("thất bại");
            }
        }

        private void dtg_Employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtg_Employee.CurrentRow.Cells[0].Value.ToString();
            txtF_Name.Text = dtg_Employee.CurrentRow.Cells[1].Value.ToString();
            txtLname.Text = dtg_Employee.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dtg_Employee.CurrentRow.Cells[3].Value.ToString();
            txtPhone.Text = dtg_Employee.CurrentRow.Cells[4].Value.ToString();
            object cellValue = dtg_Employee.CurrentRow.Cells[5].Value.ToString();
            dtp_DOB.Value = Convert.ToDateTime(cellValue);
            cboGT.SelectedItem= dtg_Employee.CurrentRow.Cells[6].Value.ToString();
            txtUsername.Text= dtg_Employee.CurrentRow.Cells[7].Value.ToString();
            txtPW.Text= dtg_Employee.CurrentRow.Cells[8].Value.ToString();
            if (int.Parse(dtg_Employee.CurrentRow.Cells[9].Value.ToString()) == 1)
            {
                ckISdelete.Checked = true;
            }
            else
            {
                ckISdelete.Checked = false;
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee
            {
                FirstName = txtF_Name.Text,
                LastName = txtLname.Text,
                EMAIL = txtEmail.Text,
                PHONE = txtPhone.Text,
                USERNAME = txtUsername.Text,
                PASSWORD = txtRePW.Text,
                DOB = dtp_DOB.Value,
                SEX = cboGT.SelectedItem.ToString()
            };
            try
            {
                employeesBLL.Update(newEmployee);
                MessageBox.Show("thành công");
                LoadEmploy();
            }
            catch
            {

                MessageBox.Show("thất bại");
            }
        }

        private void btnCapLaiquyen_Click(object sender, EventArgs e)
        {
            Employee newEmplyee = employeesBLL.GetEmployeeById(int.Parse(txtID.Text));
            newEmplyee.ISDELETE = 0;
            try
            {
                employeesBLL.Update(newEmplyee);
                LoadEmploy();
            }
            catch
            {
                throw;
            }
        }

        private void ck_DaXoa_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_DaXoa.Checked == true)
            {
                dtg_Employee.DataSource= employeesBLL.GetDeletedEmployees();
            }
            else
            {
                LoadEmploy();
            }
        }
    }
}
