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
    
    public partial class AddRecipe : Form
    {
        Product pd;
        String transaction;
        Recipe rc;
        public AddRecipe(Product _pd, string transaction)
        {
            InitializeComponent();
            this.pd = _pd;
            this.transaction=transaction;
        }

        private void AddRecipe_Load(object sender, EventArgs e)
        {
            btn_addToRecipe.Enabled = false;
            btn_removeFromRecipe.Enabled = false;
            lb_pdName.Text = pd.ProductName;
            loadMaterialDatagridview();
            if(transaction == "Create")
            {
                RecipeBLL.Create(pd.ProductID);
                ProductsBLL.SetCraftable(pd.ProductID);
            }

            rc = RecipeBLL.GetRecipe(pd.ProductID);
            loadRecipeDatagridview();
        }

        private void loadRecipeDatagridview()
        {
            dtgv_recipe.DataSource = RecipeInfoBLL.GetByRecipeID(rc.RecipeID).Select(x => new { x.RecipeInfoID, x.material.Materials_Name, x.Quantity}).ToList();
        }

        private void loadMaterialDatagridview()
        {
            dtgv_material.DataSource  = MaterialsBLL.GetAll().Select(x => new { x.Materials_ID, x.Materials_Name, x.Unit }).ToList() ;
        }

       

        private void btn_addToRecipe_Click(object sender, EventArgs e)
        {
            if ((int)nud_value.Value <= 0) return;
            RecipeInfo nRecI = new RecipeInfo();
            nRecI.RecipeID = rc.RecipeID;
            nRecI.MaterialID = int.Parse(txt_materialID.Text);
            nRecI.Quantity = (int)nud_value.Value;
            RecipeInfoBLL.AddToRecipe(nRecI);
            btn_addToRecipe.Enabled = false;
            loadRecipeDatagridview();
        }

        private void btn_removeFromRecipe_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dtgv_recipe.CurrentRow.Cells[0].Value.ToString());
            RecipeInfoBLL.RemoveByID(id);
            loadRecipeDatagridview();
            btn_removeFromRecipe.Enabled = false;
        }

        private void dtgv_recipe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1) return;
            btn_removeFromRecipe.Enabled = true;
            btn_addToRecipe.Enabled = false;

        }
        private void dtgv_material_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            material Smaterial = MaterialsBLL.GetByID(int.Parse(dtgv_material.CurrentRow.Cells[0].Value.ToString()));
            txt_materialID.Text = Smaterial.Materials_ID.ToString();
            txt_materialName.Text = Smaterial.Materials_Name;
            txt_materialUnit.Text = Smaterial.Unit;
            if (Smaterial.Photo != null)
            {
                Byte[] data = Smaterial.Photo.ToArray();
                MemoryStream mem = new MemoryStream(data);
                pic_materialPhoto.Image = Image.FromStream(mem);
            }
            else
            {
                pic_materialPhoto.Image = null;
            }
            btn_addToRecipe.Enabled = true;
            btn_removeFromRecipe.Enabled = false;
        }
    }
}
