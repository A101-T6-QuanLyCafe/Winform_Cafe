using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page_Design_UI
{
    
    public partial class FqlNguyenLieu : Form
    {
        MaterialsBLL materialsBLL = new MaterialsBLL();
        TypeMaterialsBLL type = new TypeMaterialsBLL();
        SupplierBLL supplierBLL = new SupplierBLL();
        public FqlNguyenLieu()
        {
            InitializeComponent();
        }

        private void FqlNguyenLieu_Load(object sender, EventArgs e)
        {
            loadcbo();
            loadNL();
            loadCboNCC();
        }
        public void loadNL()
        {
            dtgNL.DataSource = materialsBLL.GetMaterialsNotISdelete();
        }
        public void loadcbo()
        {
            cboLoai.DataSource= type.GetAllTypeMaterials();
            cboLoai.DisplayMember = "TypeName";
            cboLoai.ValueMember = "TypeID";
        }
        public void loadCboNCC()
        {
            cboNCC.DataSource = supplierBLL.GetAllSuppliers();
            cboNCC.DisplayMember = "suplierName";
            cboNCC.ValueMember = "supplierID";
        }

        private void dtgNL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtgNL.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text= dtgNL.CurrentRow.Cells[0].Value.ToString();
            txtGia.Text= dtgNL.CurrentRow.Cells[0].Value.ToString(); 
            cboNCC.SelectedText= dtgNL.CurrentRow.Cells[0].Value.ToString();
            txtSL.Text= dtgNL.CurrentRow.Cells[0].Value.ToString();
            cboLoai.SelectedText= dtgNL.CurrentRow.Cells[0].Value.ToString();
            if (int.Parse(dtgNL.CurrentRow.Cells[0].Value.ToString()) == 1)
            {
                ckISdelete.Checked = true;
            }
            else
            {
                ckISdelete.Checked = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            material newMaterial = new material {
                Materials_Name = txtTen.Text,
                quantity=int.Parse(txtSL.Text),
                TypeID=int.Parse(cboLoai.SelectedValue.ToString()),
                supplieriD=int.Parse(cboNCC.SelectedValue.ToString())
            };
            try
            {
                materialsBLL.AddMaterial(newMaterial);
                MessageBox.Show("thanh cong");
                loadNL();
            }
            catch (Exception)
            {

                MessageBox.Show("that bai");
            }
       
        }

        private void btnXOa_Click(object sender, EventArgs e)
        {
            material newMaterial = new material
            {
                Materials_ID = int.Parse(txtID.Text),
                Materials_Name = txtTen.Text,
                quantity = int.Parse(txtSL.Text),
                TypeID = int.Parse(cboLoai.SelectedValue.ToString()),
                supplieriD = int.Parse(cboNCC.SelectedValue.ToString()),
                ISDELETE = 1
            };
            try
            {
                materialsBLL.UpdateMaterial(newMaterial);
                MessageBox.Show("thanh cong");
                loadNL();
            }
            catch (Exception)
            {

                MessageBox.Show("that bai");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            material newMaterial = new material
            {
                Materials_ID = int.Parse(txtID.Text),
                Materials_Name = txtTen.Text,
                quantity = int.Parse(txtSL.Text),
                TypeID = int.Parse(cboLoai.SelectedValue.ToString()),
                supplieriD = int.Parse(cboNCC.SelectedValue.ToString()),
               
            };
            try
            {
                materialsBLL.UpdateMaterial(newMaterial);
                MessageBox.Show("thanh cong");
                loadNL();
            }
            catch (Exception)
            {

                MessageBox.Show("that bai");
            }
        }
    }
}
