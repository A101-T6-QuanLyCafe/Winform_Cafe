using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RecipeInfoBLL
    {
        public static void AddToRecipe(RecipeInfo nRecI)
        {
            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();
            RecipeInfo  recI =  db.RecipeInfos.Where(x => x.RecipeID == nRecI.RecipeID && x.MaterialID == nRecI.MaterialID).FirstOrDefault();
            if(recI == null)
            {
                db.RecipeInfos.InsertOnSubmit(nRecI);
            }
            else
            {
                recI.Quantity = nRecI.Quantity;
            }
            db.SubmitChanges();
        }

        public static List<RecipeInfo> GetByRecipeID(int recipeID)
        {
            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();
            return db.RecipeInfos.Where(x => x.RecipeID == recipeID).ToList();
        }

        public static void RemoveByID(int id)
        {
            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();
            RecipeInfo rf = db.RecipeInfos.FirstOrDefault(x => x.RecipeInfoID == id);
            db.RecipeInfos.DeleteOnSubmit(rf);
            db.SubmitChanges();
        }
    }
}
