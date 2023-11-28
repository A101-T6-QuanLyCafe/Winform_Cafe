using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class IncomingsDetailBLL
    {
         CoffeeShopDBDataContext dbContext= new CoffeeShopDBDataContext();

       
        public List<Incomings_Detail> GetAllIncomingsDetails()
        {
            return dbContext.Incomings_Details.ToList();
        }

        public void AddIncomingsDetail(Incomings_Detail newIncomingsDetail)
        {
            if (newIncomingsDetail != null)
            {
                dbContext.Incomings_Details.InsertOnSubmit(newIncomingsDetail);
                dbContext.SubmitChanges();
            }
        }

        public void UpdateIncomingsDetail(Incomings_Detail updatedIncomingsDetail)
        {
            if (updatedIncomingsDetail != null)
            {
                var existingIncomingsDetail = dbContext.Incomings_Details.SingleOrDefault(i => i.Incomings_Detail_ID == updatedIncomingsDetail.Incomings_Detail_ID);
                if (existingIncomingsDetail != null)
                {
                    existingIncomingsDetail.IncomingID = updatedIncomingsDetail.IncomingID;
                    existingIncomingsDetail.Materials_ID = updatedIncomingsDetail.Materials_ID;
                    existingIncomingsDetail.quantity = updatedIncomingsDetail.quantity;
                    existingIncomingsDetail.price = updatedIncomingsDetail.price;

                    dbContext.SubmitChanges();
                }
            }
        }

        public void DeleteIncomingsDetail(int incomingsDetailID)
        {
            var incomingsDetailToDelete = dbContext.Incomings_Details.SingleOrDefault(i => i.Incomings_Detail_ID == incomingsDetailID);
            if (incomingsDetailToDelete != null)
            {
                dbContext.Incomings_Details.DeleteOnSubmit(incomingsDetailToDelete);
                dbContext.SubmitChanges();
            }
        }
    }
}
