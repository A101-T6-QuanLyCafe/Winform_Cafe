using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TableTBLL
    {
        CoffeeShopDBDataContext _context= new CoffeeShopDBDataContext();

      

        // Phương thức lấy tất cả các bàn
        public List<tablesT> GetAllTables()
        {
            return _context.tablesTs.ToList();
        }

        

        // Phương thức cập nhật thông tin bàn
        public void UpdateTable(tablesT table)
        {
            var existingTable = _context.tablesTs.SingleOrDefault(t => t.TableID == table.TableID);

            if (existingTable != null)
            {
                // Cập nhật thông tin bàn
                existingTable.ISDELETE = table.ISDELETE;
                existingTable.status = table.status;

                _context.SubmitChanges();
            }
        }

        // Phương thức xóa bàn
        public void DeleteTable(int tableID)
        {
            var tableToDelete = _context.tablesTs.SingleOrDefault(t => t.TableID == tableID);

            if (tableToDelete != null)
            {
                _context.tablesTs.DeleteOnSubmit(tableToDelete);
                _context.SubmitChanges();
            }
        }


        #region Hoang

        // Phương thức thêm bàn mới
        
        public static void BookTable(int currentTableID)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            tablesT table = DB.tablesTs.Where(x => x.TableID == currentTableID).FirstOrDefault();
            table.status = 1;
            DB.SubmitChanges();
        }

        public static Boolean IsEmpty(int ID)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            return DB.tablesTs.Where(x => x.TableID ==  ID && x.status == 0).Any();
        }

        public static List<tablesT> GetAllTable()
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            return DB.tablesTs.Where(x => true).ToList();
        }

        public static void ChangeTable(int currentTableID, int selected_table)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            tablesT start = DB.tablesTs.FirstOrDefault(x => x.TableID == currentTableID);
            tablesT end = DB.tablesTs.FirstOrDefault(x => x.TableID == selected_table);
            start.status = 0;
            end.status = 1;
            DB.SubmitChanges();
        }

        public static void Payments(int currentTableID)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            tablesT start = DB.tablesTs.FirstOrDefault(x => x.TableID == currentTableID);
            start.status = 0;
            DB.SubmitChanges();
        }

        internal static void CombineTable(int currentTableID)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            tablesT start = DB.tablesTs.FirstOrDefault(x => x.TableID == currentTableID);
            start.status = 0;
            DB.SubmitChanges();
        }
        public static Boolean IsExists(String tableName)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            return DB.tablesTs.Any(x => x.Name.Equals(tableName));
        }
        public static String AddTable(tablesT newTable)
        {
            string error = "";
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            if (IsExists(newTable.Name))
                error += "Tên bàn đã tồn tại \n";
            else
            {
                DB.tablesTs.InsertOnSubmit(newTable);
                DB.SubmitChanges();
            }
            return error;
        }
        public static String EditTable(tablesT newTable)
        {
            string error = "";
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            tablesT old = DB.tablesTs.FirstOrDefault(x => x.TableID ==  newTable.TableID);
            if(old.Name != newTable.Name)
            {
                if (IsExists(newTable.Name))
                    error += "Tên bàn đã tồn tại \n";
                else
                    old.Name = newTable.Name;

            }
            old.Note = newTable.Note;
            DB.SubmitChanges();
            return error;
        }

        public static string RemoveTable(int tableID)
        {
            string error = "";
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            tablesT old = DB.tablesTs.FirstOrDefault(x => x.TableID ==  tableID);
            if(old.status == 1)
            {
                error = "Bàn đang có khách \n";

            }
            else
            {
                old.ISDELETE = 1;
                DB.SubmitChanges();
                
            }
            return error;
        }

        public static string ActiveTable(int tableID)
        {
            string error = "";
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            tablesT old = DB.tablesTs.FirstOrDefault(x => x.TableID ==  tableID);
            old.ISDELETE = 0;
            DB.SubmitChanges();
            return error;
        }
        #endregion
    }
}
