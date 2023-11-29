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
        CoffeeShopDBDataContext dbcontext=new CoffeeShopDBDataContext();
        MaterialsBLL materialsBLL = new MaterialsBLL();
        TypeMaterialsBLL typeMaterialsBLL = new TypeMaterialsBLL();
        IncomingsBLL incomingsBLL = new IncomingsBLL();
        IncomingsDetailBLL incomingsDetailBLL = new IncomingsDetailBLL();
        SupplierBLL supplierBLL = new SupplierBLL();
        EmployeesBLL employeesBLL = new EmployeesBLL();
        public FNhapHang()
        {
            InitializeComponent();
        }

        private void FNhapHang_Load(object sender, EventArgs e)
        {
            LoadNL();
            loadNCC();
            Incoming incoming = incomingsBLL.GetIncomingById(8);


            txtMaPNN.Text = incoming.IncomingID.ToString();
            txtGiaNhap.Text = incoming.total_Price.ToString();
            txtDaTra.Text = incoming.amount_paid.ToString();
           
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
                string id=selectedRow.Cells["Materials_ID"].Value.ToString();
                string tenNguyenLieu = selectedRow.Cells["Materials_Name"].Value.ToString();
               

                
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
                EmployeeID= employeesBLL.GetEmployeeIDByEmail(Properties.Settings.Default.Username)
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


            

            // Lấy thông tin Incoming sau khi đã được cập nhật
            Incoming incoming = incomingsBLL.GetIncomingById(newIncoming.IncomingID);
            

            txtMaPNN.Text = incoming.IncomingID.ToString();
            txtGiaNhap.Text = incoming.total_Price.ToString();
            txtDaTra.Text = incoming.amount_paid.ToString();
            txtNV.Text=nv.FirstName+" "+nv.LastName;
        }

        private void txtNV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
