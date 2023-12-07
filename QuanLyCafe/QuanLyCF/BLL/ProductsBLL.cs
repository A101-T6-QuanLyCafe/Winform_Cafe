using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductsBLL
    {
        CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();
        public List<Product> getAllProducts()
        {
            var result = from product in db.Products select product;
            return result.ToList();
        }
        public bool insert(Product newProduct)
        {
            try
            {
                db.Products.InsertOnSubmit(newProduct);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool delete(int productID)
        {
            var deleteItem= db.Products.Where(x => x.ProductID == productID).FirstOrDefault();
            if(deleteItem != null)
            {
                try
                {
                    db.Products.DeleteOnSubmit(deleteItem);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        public bool update(Product pUpdate)
        {
            var updateItem= db.Products.Where(x => x.ProductID == pUpdate.ProductID).FirstOrDefault();
            if(updateItem != null)
            {
                try
                {
                    updateItem.ProductName = pUpdate.ProductName;
                    updateItem.Price=pUpdate.Price;
                    updateItem.typeProductID = pUpdate.typeProductID;
                    updateItem.ISDELETE = pUpdate.ISDELETE;
                    updateItem.photo = pUpdate.photo;
                    //updateItem.Craftable = pUpdate.Craftable;
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public Product GetProductById(int productID)
        {


            // Lấy thông tin sản phẩm theo ID
            return db.Products.FirstOrDefault(p => p.ProductID == productID);

        }
        public List<Product> GetDeletedproduct()
        {
            // Sử dụng LINQ để lọc những nhân viên có IsDelete bằng 1
            return db.Products.Where(e => e.ISDELETE == 1).ToList();
        }

        #region Hoang
        public static List<Product> GetAllProduct()
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            return DB.Products.Where(x => true).ToList();
        }

        public static List<Product> GetProductByTypeID(int id)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            return DB.Products.Where(x => x.typeProductID == id).ToList();
        }

        public static float GetPrice(int productID)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            return DB.Products.FirstOrDefault(x => x.ProductID == productID).Price;
        }

        public static Product GetProductByID(int productID)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            return DB.Products.FirstOrDefault(x => x.ProductID == productID);
        }

        public static void SetCraftable(int productID)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            DB.Products.FirstOrDefault(x => x.ProductID == productID).Craftable = 1;
            DB.SubmitChanges();
        }

        public static List<Product> GetByFillter(string text, bool checked1, bool checked2)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            var rs = DB.Products.Where(x => x.ProductName.Contains(text));
            if (checked1 == true)
                rs = rs.Where(x => x.ISDELETE == 1);
            else
                rs = rs.Where(x => x.ISDELETE == 0);
            if (checked2 == true)
                rs = rs.Where(x => x.Craftable == 1);
            else
                rs = rs.Where(x => x.Craftable == 0);
            return rs.ToList();
        }

        public static Boolean Craftable(int productID, int quantity)
        {
            Recipe rc = RecipeBLL.GetRecipe(productID);
            List<RecipeInfo> list = RecipeInfoBLL.GetByRecipeID(rc.RecipeID);
            foreach (RecipeInfo item in list)
            {
                material mt = MaterialsBLL.GetByID(item.MaterialID);
                if ((item.Quantity * quantity) > mt.quantity)
                    return false;
            }

            foreach (RecipeInfo item in list)
            {
                MaterialsBLL.MinusQuantity(item.MaterialID, (item.Quantity * quantity));
            }

            return true;
        }
        #endregion
    }
}
