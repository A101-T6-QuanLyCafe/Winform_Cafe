using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class EmployeesBLL
    {
        static CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();
        public List<Employee> getAllEmployee()
        {
            var dsEp = from Employee in db.Employees select Employee;
            return dsEp.ToList();
        }

        public bool Insert(Employee newE)
        {
            try
            {
                db.Employees.InsertOnSubmit(newE);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int Eid)
        {
            var deleteEmloy = db.Employees.SingleOrDefault(x => x.EmployeeID == Eid);
            if (deleteEmloy != null)
            {
                try
                {
                    db.Employees.DeleteOnSubmit(deleteEmloy);
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
        public bool Update(Employee EUpdate)
        {
            var updateItem = db.Employees.SingleOrDefault(x => x.EmployeeID == EUpdate.EmployeeID);
            if (updateItem != null)
            {
                try {
                    updateItem.Email = EUpdate.Email;
                  
                    updateItem.FirstName = EUpdate.FirstName;
                    updateItem.LastName = EUpdate.LastName;
                    updateItem.Password = EUpdate.Password;
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
