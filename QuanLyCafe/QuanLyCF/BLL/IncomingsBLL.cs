using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class IncomingsBLL
    {
         CoffeeShopDBDataContext dbContext= new CoffeeShopDBDataContext();

       

        public List<Incoming> GetAllIncomings()
        {
            return dbContext.Incomings.ToList();
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
            dbContext.Refresh(RefreshMode.OverwriteCurrentValues, dbContext.Incomings.FirstOrDefault(i => i.IncomingID == incomingId));
            return dbContext.Incomings.FirstOrDefault(i => i.IncomingID == incomingId);
        }

    }
}
