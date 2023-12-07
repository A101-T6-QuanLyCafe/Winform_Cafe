using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
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
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FqlNguyenLieu_Load(object sender, EventArgs e)
        {
            loadcbo();
            loadNL();
            loadCboNCC();
        }
        public void loadNL()
        {
            dtgNL.DataSource = materialsBLL.GetAllMaterials();
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
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên nguyên liệu");
                txtTen.Focus();
            }
            else if (txtDVT.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính");
                txtDVT.Focus();
            }
            else if (txtGia.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập giá nhập");
                txtGia.Focus();
            }
            else if (txtSL.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                txtSL.Focus();
            }
            else
            {
                material newMaterial = new material
                {

                    Materials_Name = txtTen.Text,
                    quantity = int.Parse(txtSL.Text),
                    TypeID = int.Parse(cboLoai.SelectedValue.ToString()),
                    supplieriD = int.Parse(cboNCC.SelectedValue.ToString()),
                    Price = float.Parse(txtGia.Text.Trim()),
                    Unit = txtDVT.Text.Trim(),
                    ISDELETE = 0
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
                Price=float.Parse(txtGia.Text.Trim()),
                Unit= txtDVT.Text.Trim(),
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
                Price = float.Parse(txtGia.Text.Trim()),
                Unit = txtDVT.Text.Trim(),
               

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

        private void dtgNL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtgNL.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dtgNL.CurrentRow.Cells[1].Value.ToString();
            txtGia.Text = dtgNL.CurrentRow.Cells[2].Value.ToString();
            cboNCC.SelectedValue = dtgNL.CurrentRow.Cells[3].Value;
            txtSL.Text = dtgNL.CurrentRow.Cells[4].Value.ToString();
            txtDVT.Text = dtgNL.CurrentRow.Cells[5].Value.ToString();
            cboLoai.SelectedValue = dtgNL.CurrentRow.Cells[6].Value;
            
        }

        private void ckISdelete_CheckedChanged(object sender, EventArgs e)
        {
            if (ckISdelete.Checked)
            {
                dtgNL.DataSource = materialsBLL.GetMaterialsISdelete();
            }
            else
            {
                loadNL();
            }
        }

        private void btnMoBan_Click(object sender, EventArgs e)
        {
            material newMaterial = new material
            {
                Materials_ID = int.Parse(txtID.Text),
                Materials_Name = txtTen.Text,
                quantity = int.Parse(txtSL.Text),
                TypeID = int.Parse(cboLoai.SelectedValue.ToString()),
                supplieriD = int.Parse(cboNCC.SelectedValue.ToString()),
                Price = float.Parse(txtGia.Text.Trim()),
                Unit = txtDVT.Text.Trim(),
                ISDELETE = 0
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

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text.Length > 0)
            {
                dtgNL.DataSource = materialsBLL.SearchMaterialsByName(txt_search.Text.Trim());
            }
            else
            {
                loadNL();
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {

                e.Handled = true;
            }
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtDVT.Text = "";
            txtGia.Text = "";
            txtID.Text = "";
            txtSL.Text = "";
            txtTen.Text = "";
            txt_search.Text = "";
        }
    }
}
