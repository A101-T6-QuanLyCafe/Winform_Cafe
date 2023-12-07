using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page_Design_UI
{
    public partial class FNhapHang : Form
    {
        MaterialsBLL materialsBLL = new MaterialsBLL();
        IncomingsBLL incomingsBLL = new IncomingsBLL();
        IncomingsDetailBLL incomingsDetailBLL = new IncomingsDetailBLL();
        SupplierBLL supplierBLL = new SupplierBLL();
        EmployeesBLL employeesBLL = new EmployeesBLL();
        Incoming INCOMINGCURRENT;
        public FNhapHang()
        {
            InitializeComponent();
            this.StartPosition= FormStartPosition.CenterScreen;
        }

        private void FNhapHang_Load(object sender, EventArgs e)
        {
            LoadNL();
            loadNCC();
        }
        public void LoadNL()
        {
            dtg_NguyenLieu.DataSource = materialsBLL.GetAllMaterials();
        }
        public void loadNCC()
        {
            cboNcc.DataSource = supplierBLL.GetAllSuppliers();
            cboNcc.DisplayMember = "suplierName";
            cboNcc.ValueMember = "supplierID";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dtg_NguyenLieu.SelectedRows.Count > 0)
            {
                // Có ít nhất một dòng được chọn
                DataGridViewRow selectedRow = dtg_NguyenLieu.SelectedRows[0];

                // Lấy giá trị của ô trong dòng được chọn
                string id=selectedRow.Cells[0].Value.ToString();
                string tenNguyenLieu = selectedRow.Cells[1].Value.ToString();
               

                
                if (numSL.Value == 0 || numSL.Value < 0)
                {
                    MessageBox.Show("vui lòng nhập số lượng lớn hơn 0");
                }
                else
                {
                    dtgGioHang.Rows.Add(id, tenNguyenLieu, numSL.Value);
                 
                }
            }
            else
            {
                // Không có dòng nào được chọn
                MessageBox.Show("Chưa chọn nguyen lieu!");
            }
            
        }

        private void cboNcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNcc.SelectedItem != null)
            {
                if (int.TryParse(cboNcc.SelectedValue.ToString(), out int supplierID))
                {
                    dtg_NguyenLieu.DataSource= materialsBLL.GetMaterialsBySupplierID(supplierID);
                }


            }
        }
        public void ClearTXT()
        {
            txtMaPNN.Text = "";
            txtGiaNhap.Text = "";
            txtDaTra.Text = "";
            txtNV.Text = "";
            txtTimKiem.Text = "";
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadNL();
            loadNCC();
            
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            Employee nv = employeesBLL.GetEmployeeByEmail(Properties.Settings.Default.Username);
            Incoming newIncoming = new Incoming
            {
                IncomingDate = DateTime.Now,
                total_Price = 0, // Sẽ cập nhật sau
                amount_paid = 0,
                EmployeeID= nv.EmployeeID
        };

            // Thêm Incomings mới vào cơ sở dữ liệu
            incomingsBLL.AddIncoming(newIncoming);

            // Bước 2: Tạo các Incomings_Detail cho từng sản phẩm trong giỏ hàng
            foreach (DataGridViewRow row in dtgGioHang.Rows)
            {
                // Lấy thông tin từ từng dòng trong DataGridView
                if(row.Cells[0].Value!=null && row.Cells[2].Value!=null) {
                    string materialsID = row.Cells[0].Value.ToString();
                    string quantity = row.Cells[2].Value.ToString();
                    Incomings_Detail newIncomingDetail = new Incomings_Detail
                    {
                        IncomingID = newIncoming.IncomingID,
                        Materials_ID = int.Parse(materialsID),
                        quantity = int.Parse(quantity),
                        price = 0 // Sẽ cập nhật sau

                    };
                    incomingsDetailBLL.AddIncomingsDetail(newIncomingDetail);
                }
                

               
               
            }
            MessageBox.Show("vui lòng kiểm tra thông tin phiếu nhập và cập nhật số tiền đã thanh toán cho nhà cung cấp");
            txtDaTra.Focus();



            // Lấy thông tin Incoming sau khi đã được cập nhật
            INCOMINGCURRENT = incomingsBLL.GetIncomingById(newIncoming.IncomingID);
            

            txtMaPNN.Text = INCOMINGCURRENT.IncomingID.ToString();
            txtGiaNhap.Text = INCOMINGCURRENT.total_Price.ToString();
            txtDaTra.Text = INCOMINGCURRENT.amount_paid.ToString();
            txtNV.Text=nv.FirstName+" "+nv.LastName;
        }

        private void txtNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                INCOMINGCURRENT.amount_paid = int.Parse(txtDaTra.Text.Trim());
                incomingsBLL.UpdateIncoming(INCOMINGCURRENT);
                ClearTXT();
                MessageBox.Show("nhập hàng thành công!");
            }
            catch 
            {

                MessageBox.Show("error");
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTXT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length > 0)
            {
                dtg_NguyenLieu.DataSource= materialsBLL.SearchMaterialsByName(txtTimKiem.Text.Trim());
            }
            if(txtTimKiem.Text.Length == 0)
            {
                LoadNL();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtgGioHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dtgGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDaTra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDaTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length > 0)
            {
                dtg_NguyenLieu.DataSource = materialsBLL.SearchMaterialsByName(txtTimKiem.Text.Trim());
            }
            if (txtTimKiem.Text.Length == 0)
            {
                LoadNL();
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearTXT();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {

                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
