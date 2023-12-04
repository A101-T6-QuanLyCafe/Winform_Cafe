using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
                    deleteEmloy.ISDELETE = 1;
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
                    updateItem.PHONE=EUpdate.PHONE;
                    updateItem.SEX = EUpdate.SEX;
                    updateItem.ISDELETE = EUpdate.ISDELETE;
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
        public Employee GetEmployeeById(int employeeId)
        {
           
            return db.Employees.SingleOrDefault(e => e.EmployeeID == employeeId);
        }
         public List<Employee> GetDeletedEmployees()
        {
           
            return db.Employees.Where(e => e.ISDELETE == 1).ToList();
        }


        #region Hoang
        public static List<Employee> getAllEmpFill(String txt_search, String field, bool showdelete)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            List<Employee> emps = new List<Employee>();
            switch (field)
            {
                case "USERNAME":
                    emps = DB.Employees.Where(x => x.USERNAME.Contains(txt_search)).ToList();
                    break;
                case "NAME":
                    emps = DB.Employees.Where(x => x.FirstName.Contains(txt_search) || x.LastName.Contains(txt_search)).ToList();
                    break;
                case "PHONE":
                    emps = DB.Employees.Where(x => x.PHONE.Contains(txt_search)).ToList();
                    break;
                default:
                    emps = DB.Employees.Where(x => true).ToList();
                    break;
            }
            if (showdelete)
            {
                return emps.Where(x => x.ISDELETE == 1).ToList();
            }
            else
                return emps.Where(x => x.ISDELETE == 0).ToList();
        }

        public static Employee GetEmpByID(int id)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            return DB.Employees.FirstOrDefault(x => x.EmployeeID == id);
        }

        public static String AddEmployee(Employee emp)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            String errString = "";
            if (ExistsEmail(emp.EMAIL))
                errString += "Email đã tồn tại \n";
            if (ExistsPhone(emp.PHONE))
                errString += "Số điện thoại đã tồn tại \n";
            if (ExistsUsername(emp.USERNAME))
                errString += "tên tài khoản đã tồn tại \n";
            if (errString.Length > 0)
            {
                return errString;
            }


            try
            {
                DB.Employees.InsertOnSubmit(emp);
                DB.SubmitChanges();

                return "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return "thêm thất bại";
            }

        }

        internal static Boolean ExistsEmail(String email)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            return DB.Employees.Where(x => x.EMAIL == email).FirstOrDefault() !=null;
        }
        internal static Boolean ExistsPhone(String phone)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            return DB.Employees.Where(x => x.PHONE == phone).FirstOrDefault() != null;
        }
        internal static Boolean ExistsUsername(String username)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            return DB.Employees.Where(x => x.USERNAME == username).FirstOrDefault() != null;

        }

        public static string EditEmployee(Employee emp)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            String errString = "";
            Employee cemp = DB.Employees.Where(x => x.EmployeeID == emp.EmployeeID).FirstOrDefault();
            cemp.FirstName = emp.FirstName;
            cemp.LastName = emp.LastName;
            if (cemp.EMAIL != emp.EMAIL)
            {
                if (ExistsEmail(emp.EMAIL))
                {
                    errString += "Email đã tồn tại \n";
                }
                else
                    cemp.EMAIL = emp.EMAIL;
            }
            if (cemp.PHONE != emp.PHONE)
            {
                if (ExistsPhone(emp.PHONE))
                {
                    errString += "Số điện thoại đã tồn tại \n";
                }
                else
                    cemp.PHONE = emp.PHONE;
            }
            if (cemp.USERNAME != emp.USERNAME)
            {
                if (ExistsUsername(emp.USERNAME))
                {
                    errString += "tên tài khoản đã tồn tại \n";
                }
                else
                    cemp.USERNAME = emp.USERNAME;
            }
            cemp.PASSWORD = emp.PASSWORD;
            cemp.DOB = emp.DOB;
            cemp.SEX = emp.SEX;
            if (errString.Length > 0)
            {

                return errString;
            }

            try
            {
                DB.SubmitChanges();
                return "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "sửa thất bại";
            }
        }

        public static Boolean RemoveEmployee(string empid)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            Employee cemp = DB.Employees.Where(x => x.EmployeeID == int.Parse(empid)).FirstOrDefault();
            cemp.ISDELETE = 1;
            try
            {
                DB.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static bool ActiveEmployee(string empid)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            Employee cemp = DB.Employees.Where(x => x.EmployeeID == int.Parse(empid)).FirstOrDefault();
            cemp.ISDELETE = 0;
            try
            {
                DB.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static Employee Login(string username, string password)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            return DB.Employees.FirstOrDefault(x => x.USERNAME.Equals(username) && x.PASSWORD.Equals(password));
        }
        #endregion
    }
}
