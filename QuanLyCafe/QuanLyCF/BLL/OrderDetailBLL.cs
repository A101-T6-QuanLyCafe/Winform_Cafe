using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderDetailBLL
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

        internal static void MoveToNewOrderID(int oldOrderID, int newOrderID)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            // lần lượt lấy ra danh sách order detal bàn đầu vào bàn đich
            // duyệt qua mỗi order detal trong bàn đầu nếu trùng mã sản phẩm số lượng += sản phẩm
            // đồng thời xóa orderdetal đó 
            // nếu  không đổi orderID của orderdetail đó
            List<OrderDetail> oldlist = DB.OrderDetails.Where(x => x.OrderID == oldOrderID).ToList();
            List<OrderDetail> newlist = DB.OrderDetails.Where(x => x.OrderID == newOrderID).ToList();

            foreach (OrderDetail detail in oldlist)
            {
                OrderDetail temp = newlist.FirstOrDefault(x => x.ProductID == detail.ProductID);
                if (temp != null)
                {
                    temp.Quantity +=  detail.Quantity;
                    DB.OrderDetails.DeleteOnSubmit(detail);
                }
                else
                    detail.OrderID = newOrderID;
            }
            DB.SubmitChanges();
        }
        #endregion
    }
}
