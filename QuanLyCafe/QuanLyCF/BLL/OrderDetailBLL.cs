using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class OrderDetailBLL
    {
        #region Hoang
        public static void createOrderDetail(OrderDetail newODT)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            OrderDetail orderDetail = DB.OrderDetails.Where(x => x.OrderID == newODT.OrderID && x.ProductID == newODT.ProductID).FirstOrDefault();
            if (orderDetail == null)
            {
                if (newODT.Quantity < 0) return;
                DB.OrderDetails.InsertOnSubmit(newODT);
                DB.SubmitChanges();
            }
            else
            {
                orderDetail.Quantity += newODT.Quantity;
                if (orderDetail.Quantity <= 0)
                    DB.OrderDetails.DeleteOnSubmit(orderDetail);
                DB.SubmitChanges();
            }
        }

        public static List<OrderDetail> GetOrderDetailByOrderID(int orderID)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            return DB.OrderDetails.Where(x => x.OrderID == orderID).ToList();
        }
        #endregion
    }
}
