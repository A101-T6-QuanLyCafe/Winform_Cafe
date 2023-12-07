using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class IncomingsBLL
    {
         CoffeeShopDBDataContext dbContext= new CoffeeShopDBDataContext();

       

        public DataTable GetAllIncomings()
        {

           
            try
            {
                var materialsQuery = dbContext.Incomings.ToList();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã phiếu nhập", typeof(int));
                dataTable.Columns.Add("Ngày lập", typeof(string));
                dataTable.Columns.Add("Tổng tiền", typeof(float));
                dataTable.Columns.Add("Đã trả", typeof(int));
                dataTable.Columns.Add("Mã nhân viên", typeof(int));
               

                foreach (var incoming in materialsQuery)
                {
                    dataTable.Rows.Add(
                        incoming.IncomingID,
                        incoming.IncomingDate,
                        incoming.total_Price,
                        incoming.amount_paid,
                        incoming.EmployeeID
                       
                    );
                }

                return dataTable;
            }
            catch
            {
                return null;
            }
        }

        public void AddIncoming(Incoming newIncoming)
        {
            if (newIncoming != null)
            {
                dbContext.Incomings.InsertOnSubmit(newIncoming);
                dbContext.SubmitChanges();
            }
        }

        public void UpdateIncoming(Incoming updatedIncoming)
        {
            if (updatedIncoming != null)
            {
                var existingIncoming = dbContext.Incomings.SingleOrDefault(i => i.IncomingID == updatedIncoming.IncomingID);
                if (existingIncoming != null)
                {
                    existingIncoming.IncomingDate = updatedIncoming.IncomingDate;
                    existingIncoming.total_Price = updatedIncoming.total_Price;
                    existingIncoming.amount_paid = updatedIncoming.amount_paid;

                    dbContext.SubmitChanges();
                }
            }
        }

        public void DeleteIncoming(int incomingID)
        {
            var incomingToDelete = dbContext.Incomings.SingleOrDefault(i => i.IncomingID == incomingID);
            if (incomingToDelete != null)
            {
                dbContext.Incomings.DeleteOnSubmit(incomingToDelete);
                dbContext.SubmitChanges();
            }
        }
        public Incoming GetIncomingById(int incomingId)
        {
            dbContext = new CoffeeShopDBDataContext();
            return dbContext.Incomings.FirstOrDefault(i => i.IncomingID == incomingId);
        }

    }
}
