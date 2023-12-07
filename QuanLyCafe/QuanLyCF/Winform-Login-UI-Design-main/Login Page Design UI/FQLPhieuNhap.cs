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
    public partial class FQLPhieuNhap : Form
    {
        IncomingsBLL incomingsBLL= new IncomingsBLL();
        EmployeesBLL employeesBLL= new EmployeesBLL();  
        Employee emp;
        public FQLPhieuNhap()
        {
            InitializeComponent();
        }

        private void FQLPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadPN();
        }
        public void LoadPN()
        {
            dtgPN.DataSource = incomingsBLL.GetAllIncomings();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtgPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPN.Text = dtgPN.CurrentRow.Cells[0].Value.ToString();
            dtpNgayLap.Value = DateTime.Parse(dtgPN.CurrentRow.Cells[1].Value.ToString());
            txtTongTien.Text = dtgPN.CurrentRow.Cells[2].Value.ToString();
            txtDaTra.Text = dtgPN.CurrentRow.Cells[3].Value.ToString();
            emp = employeesBLL.GetEmployeeById(int.Parse(dtgPN.CurrentRow.Cells[4].Value.ToString()));
            txtNV.Text = emp.FirstName + " " + emp.LastName;
            txtCongNo.Text = (float.Parse(txtTongTien.Text) - float.Parse(txtDaTra.Text)).ToString();
            textBox1.Text = emp.EmployeeID.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Incoming incoming = new Incoming {
                IncomingID = int.Parse(txtMaPN.Text),
                IncomingDate = dtpNgayLap.Value,
                total_Price=float.Parse(txtTongTien.Text),
                amount_paid=float.Parse(txtDaTra.Text)
              
            };
            try
            {
                incomingsBLL.UpdateIncoming(incoming);
                LoadPN();
            }
            catch (Exception)
            {

                MessageBox.Show("That bai");
            }

        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dtgPN.RowCount; i++)
            {
                Incoming incoming = new Incoming {
                IncomingID = int.Parse(dtgPN.CurrentRow.Cells[0].Value.ToString()),
                IncomingDate = DateTime.Parse(dtgPN.CurrentRow.Cells[1].Value.ToString()),
                total_Price =float.Parse( dtgPN.CurrentRow.Cells[2].Value.ToString()),
                amount_paid = float.Parse(dtgPN.CurrentRow.Cells[3].Value.ToString())

               
            };
                try
                {
                    incomingsBLL.UpdateIncoming(incoming);
                }
                catch (Exception)
                {

                    throw;
                }
                
               
               
            }
            LoadPN();
        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
