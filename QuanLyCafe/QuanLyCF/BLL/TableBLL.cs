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
    }
}
