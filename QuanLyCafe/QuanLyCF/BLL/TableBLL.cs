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

        // Phương thức thêm bàn mới
        public void AddTable(tablesT newTable)
        {
            _context.tablesTs.InsertOnSubmit(newTable);
            _context.SubmitChanges();
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
        #endregion
    }
}
