using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
