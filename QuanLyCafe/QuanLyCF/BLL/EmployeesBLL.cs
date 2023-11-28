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
                    updateItem.EMAIL = EUpdate.EMAIL;
                  
                    updateItem.FirstName = EUpdate.FirstName;
                    updateItem.LastName = EUpdate.LastName;
                    updateItem.PASSWORD = EUpdate.PASSWORD;
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
        public bool Update2(Employee EUpdate)
        {
            var updateItem = db.Employees.SingleOrDefault(x => x.EMAIL == EUpdate.EMAIL);
            if (updateItem != null)
            {
                try
                {
                    

                    updateItem.FirstName = EUpdate.FirstName;
                    updateItem.LastName = EUpdate.LastName;
                    updateItem.PASSWORD = EUpdate.PASSWORD;
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
        public int GetEmployeeIDByEmail(string userName)
        {
            
            var employee = db.Employees.FirstOrDefault(e => e.USERNAME == userName);

            if (employee != null)
            {
                return employee.EmployeeID;
            }
            else
            {
                
                return -1;// khong tim thay
            }
        }
        public Employee GetEmployeeByEmail(string userName)
        {
           
            var employee = db.Employees.FirstOrDefault(e => e.USERNAME== userName);

            return employee;
        }
    }
}
