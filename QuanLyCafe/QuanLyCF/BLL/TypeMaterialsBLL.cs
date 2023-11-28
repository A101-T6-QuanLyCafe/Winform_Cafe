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
    }
}
