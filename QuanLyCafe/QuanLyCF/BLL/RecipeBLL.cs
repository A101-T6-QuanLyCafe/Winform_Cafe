using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RecipeBLL
    {
        public static void Create(int productID)
        {
            Recipe newrecipe = new Recipe();
            newrecipe.ProductID = productID;
            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();
            db.Recipes.InsertOnSubmit(newrecipe);
            db.SubmitChanges();
        }

        public static Recipe GetRecipe(int productID)
        {
            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();
            return db.Recipes.FirstOrDefault(x => x.ProductID == productID);
        }
    }
}
