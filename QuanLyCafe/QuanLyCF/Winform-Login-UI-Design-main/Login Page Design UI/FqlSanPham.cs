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
    public partial class FqlSanPham : Form
    {
        TypeProductBLL typeProductBLL = new TypeProductBLL();
        ProductsBLL productsBLL = new ProductsBLL();
      
        public FqlSanPham()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product {
                ProductName = txtTebSP.Text,
                typeProductID = int.Parse(cboLoai.SelectedValue.ToString()),
                Price = float.Parse(txtGia.Text),
            };
            try
            {
                productsBLL.insert(newProduct);
                MessageBox.Show("thanh cong");
                LoadProduct();
            }
            catch (Exception)
            {

                MessageBox.Show("that bai");
            }
        }
        public void LoadProduct()
        {
            dtgSanpham.DataSource = productsBLL.getAllProducts();
        }
        public void loadcbo()
        {
            cboLoai.DataSource = typeProductBLL.GetAllTypeProducts();
            cboLoai.DisplayMember = "typeProductName";
            cboLoai.ValueMember = "typeProductID";
        }

        private void FqlSanPham_Load(object sender, EventArgs e)
        {
            loadcbo();
            LoadProduct();
        }

        private void dtgSanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtgSanpham.CurrentRow.Cells[0].Value.ToString();
            txtTebSP.Text = dtgSanpham.CurrentRow.Cells[1].Value.ToString(); 
            txtGia.Text = dtgSanpham.CurrentRow.Cells[2].Value.ToString();
            cboLoai.SelectedItem = dtgSanpham.CurrentRow.Cells[3].Value.ToString();
            if (int.Parse(dtgSanpham.CurrentRow.Cells[4].Value.ToString()) == 1)
            {
                ckIsdelete.Checked = true;
            }
            else
            {
                ckIsdelete.Checked=false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product
            {
                ProductID = int.Parse(txtID.Text),
                ProductName = txtTebSP.Text,
                typeProductID = int.Parse(cboLoai.SelectedValue.ToString()),
                Price = float.Parse(txtGia.Text),
            };
            try
            {
                productsBLL.update(newProduct);
                MessageBox.Show("thanh cong");
                LoadProduct();
            }
            catch (Exception)
            {

                MessageBox.Show("that bai");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Product newProduct = productsBLL.GetProductById(int.Parse(txtID.Text));
            newProduct.ISDELETE = 1;
            try
            {
                productsBLL.update(newProduct);
                MessageBox.Show("thanh cong");
                LoadProduct();
            }
            catch (Exception)
            {

                MessageBox.Show("that bai");
            }
            
        }

        private void ckDaXoa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDaXoa.Checked)
            {
                dtgSanpham.DataSource = productsBLL.GetDeletedproduct();
            }
        }

        private void btnMoBan_Click(object sender, EventArgs e)
        {
            Product newProduct = productsBLL.GetProductById(int.Parse(txtID.Text));
            newProduct.ISDELETE = 0;
            try
            {
                productsBLL.update(newProduct);
                MessageBox.Show("thanh cong");
                LoadProduct();
            }
            catch (Exception)
            {

                MessageBox.Show("that bai");
            }
        }
    }
}
