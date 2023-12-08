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
    public partial class TypeManager : Form
    {
        public TypeManager()
        {
            InitializeComponent();
        }

        private void TypeManager_Load(object sender, EventArgs e)
        {
            LoadDatagridviewMaterial();
            LoadDatagridviewProduct();
        }

        private void LoadDatagridviewProduct()
        {
            dtgv_productType.DataSource =  TypeProductBLL.GetAllProductType().Select(x => new {x.typeProductID, x.typeProductName }).ToList();
        }

        private void LoadDatagridviewMaterial()
        {
            dtgv_materialType.DataSource  = TypeMaterialsBLL.GetAll().Select(x => new {x.TypeID, x.TypeName }).ToList();
        }

        private void dtgv_productType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dtgv_productType.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dtgv_productType.CurrentRow.Cells[1].Value.ToString();
            lb_select.Text = "Loại sản phẩm";
        }

        private void dtgv_materialType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dtgv_materialType.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dtgv_materialType.CurrentRow.Cells[1].Value.ToString();
            lb_select.Text = "Loại nguyên liệu";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(lb_select.Text.Equals("Loại sản phẩm"))
            {
                typeProduct tp = new typeProduct();
                tp.typeProductName = txt_name.Text;
                TypeProductBLL.Add(tp);
                LoadDatagridviewProduct();
            }
            if(lb_select.Text.Equals("Loại nguyên liệu"))
            {
                TypeMaterial tp = new TypeMaterial();
                tp.TypeName = txt_name.Text;
                TypeMaterialsBLL.Add(tp);
                LoadDatagridviewMaterial();
            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (lb_select.Text.Equals("Loại sản phẩm"))
            {
                typeProduct tp = new typeProduct();
                tp.typeProductName = txt_name.Text;
                tp.typeProductID = int.Parse(txt_id.Text);
                TypeProductBLL.Edit(tp);
                LoadDatagridviewProduct();
            }
            if (lb_select.Text.Equals("Loại nguyên liệu"))
            {
                TypeMaterial tp = new TypeMaterial();
                tp.TypeName = txt_name.Text;
                tp.TypeID = int.Parse(txt_id.Text);
                TypeMaterialsBLL.Edit(tp);
                LoadDatagridviewMaterial();
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (lb_select.Text.Equals("Loại sản phẩm"))
            {
                TypeProductBLL.Remove(int.Parse(txt_id.Text));
                LoadDatagridviewProduct();
            }
            if (lb_select.Text.Equals("Loại nguyên liệu"))
            {
                TypeMaterialsBLL.Remove(int.Parse(txt_id.Text));
                LoadDatagridviewMaterial();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }
    }
}
