using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class TypeMaterialsBLL
    {
       CoffeeShopDBDataContext db= new CoffeeShopDBDataContext();

       

        public List<TypeMaterial> GetAllTypeMaterials()
        {
            return db.TypeMaterials.ToList();
        }

        public void AddTypeMaterial(TypeMaterial newTypeMaterial)
        {
            if (newTypeMaterial != null)
            {
                db.TypeMaterials.InsertOnSubmit(newTypeMaterial);
                db.SubmitChanges();
            }
        }

        public void UpdateTypeMaterial(TypeMaterial updatedTypeMaterial)
        {
            if (updatedTypeMaterial != null)
            {
                var existingTypeMaterial = db.TypeMaterials.SingleOrDefault(t => t.TypeID == updatedTypeMaterial.TypeID);
                if (existingTypeMaterial != null)
                {
                    existingTypeMaterial.TypeName = updatedTypeMaterial.TypeName;

                    db.SubmitChanges();
                }
            }
        }

        public void DeleteTypeMaterial(int typeID)
        {
            var typeMaterialToDelete = db.TypeMaterials.SingleOrDefault(t => t.TypeID == typeID);
            if (typeMaterialToDelete != null)
            {
                db.TypeMaterials.DeleteOnSubmit(typeMaterialToDelete);
                db.SubmitChanges();
            }
        }

        public static List<TypeMaterial> GetAll()
        {
            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();
            return db.TypeMaterials.ToList();
        }

        public static Boolean Add(TypeMaterial tp)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            if (IsExists(tp.TypeName))
            {
                return false;
            }
            DB.TypeMaterials.InsertOnSubmit(tp);
            DB.SubmitChanges();
            return true;
        }

        public static Boolean IsExists(String name)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            return DB.TypeMaterials.Any(x => x.TypeName == name);
        }

        public static Boolean Edit(TypeMaterial tp)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            TypeMaterial pd = DB.TypeMaterials.FirstOrDefault(x => x.TypeID == tp.TypeID);
            pd.TypeName = tp.TypeName;
            DB.SubmitChanges();
            return true;
        }

        public static bool Remove(int v)
        {
            try
            {
                CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
                TypeMaterial pd = DB.TypeMaterials.FirstOrDefault(x => x.TypeID == v);
                DB.TypeMaterials.DeleteOnSubmit(pd);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
