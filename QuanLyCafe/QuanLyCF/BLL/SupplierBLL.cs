using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SupplierBLL
    {
        private CoffeeShopDBDataContext dbContext = new CoffeeShopDBDataContext();



        public List<supplier> GetAllSuppliers()
        {
            return dbContext.suppliers.ToList();
        }

        public void AddSupplier(supplier newSupplier)
        {
            if (newSupplier != null)
            {
                dbContext.suppliers.InsertOnSubmit(newSupplier);
                dbContext.SubmitChanges();
            }
        }

        public void UpdateSupplier(supplier updatedSupplier)
        {
            if (updatedSupplier != null)
            {
                var existingSupplier = dbContext.suppliers.SingleOrDefault(s => s.supplierID == updatedSupplier.supplierID);
                if (existingSupplier != null)
                {
                    existingSupplier.suplierName = updatedSupplier.suplierName;
                    existingSupplier.email = updatedSupplier.email;
                    existingSupplier.address = updatedSupplier.address;
                    existingSupplier.phone = updatedSupplier.phone;

                    dbContext.SubmitChanges();
                }
            }
        }

        public void DeleteSupplier(int supplierID)
        {
            var supplierToDelete = dbContext.suppliers.SingleOrDefault(s => s.supplierID == supplierID);
            if (supplierToDelete != null)
            {
                dbContext.suppliers.DeleteOnSubmit(supplierToDelete);
                dbContext.SubmitChanges();
            }
        }
    }
}
