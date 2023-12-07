using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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


        public void LoadProduct()
        {
            dtgSanpham.DataSource = ProductsBLL.GetByFillter(txt_search.Text, cb_isDelete.Checked, cb_craftable.Checked).Select(x => new { x.ProductID, x.ProductName, x.Price, x.typeProductID }).ToList();
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
            btn_addRecipe.Enabled = false;
            btn_editRecipe.Enabled = false;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {

            Product newProduct = new Product();
            newProduct.ProductID = int.Parse(txtID.Text);
            newProduct.ProductName = txtTebSP.Text;
            newProduct.typeProductID = int.Parse(cboLoai.SelectedValue.ToString());
            newProduct.Price = float.Parse(txtGia.Text);
            if (pictureBox1.Image != null)
                newProduct.photo = getPhoto();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFile.FileName);
            }
        }

        private void dtgSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int productID = int.Parse(dtgSanpham.CurrentRow.Cells[0].Value.ToString());
            Product pd = ProductsBLL.GetProductByID(productID);
            txtID.Text = pd.ProductID.ToString();
            txtTebSP.Text = pd.ProductName;
            txtGia.Text = pd.Price.ToString();
            cboLoai.SelectedValue = pd.typeProductID;
            if (pd.photo != null)
            {
                Byte[] data = pd.photo.ToArray();
                MemoryStream mem = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(mem);
            }
            else
            {
                pictureBox1.Image = null;
            }
            if(pd.Craftable == 1)
            {
                btn_editRecipe.Enabled = true;
                btn_addRecipe.Enabled = false;
            }    
            else
            {
                btn_editRecipe.Enabled = false;
                btn_addRecipe.Enabled = true;
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            newProduct.ProductName = txtTebSP.Text;
            newProduct.typeProductID = int.Parse(cboLoai.SelectedValue.ToString());
            newProduct.Price = float.Parse(txtGia.Text);
            if (pictureBox1.Image != null)
                newProduct.photo = getPhoto();
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

        private byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
            return stream.GetBuffer();
        }

        private void btn_addRecipe_Click(object sender, EventArgs e)
        {
            showRecipeForm("Create");
            btn_addRecipe.Enabled = false;
        }

        private void btn_editRecipe_Click(object sender, EventArgs e)
        {
            showRecipeForm("Edit");
        }

        private void showRecipeForm(string tran)
        {
            Product pd = productsBLL.GetProductById(int.Parse(txtID.Text));
            AddRecipe f = new AddRecipe(pd, tran);
            f.ShowDialog();
            LoadProduct();
        }

        private void cb_craftable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

   
    }
}
