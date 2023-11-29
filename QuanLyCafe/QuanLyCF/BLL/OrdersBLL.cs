using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrdersBLL
    {
        CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();
        public List<Order> getAllOrders()
        {
            var result= from order in db.Orders select order;
            return result.ToList();
        }
        public bool insert(Order newOrder)
        {
            try
            {
                db.Orders.InsertOnSubmit(newOrder);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool delete(int OrderID)
        {
            var order = db.Orders.Where(o => o.OrderID == OrderID).FirstOrDefault();
            if(order != null)
            {
                try
                {
                    db.Orders.DeleteOnSubmit(order);
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
        public bool update(Order oderUpdate)
        {
            var order= db.Orders.Where(o=>o.OrderID==oderUpdate.OrderID).FirstOrDefault();
            if (order != null)
            {
                try
                {
                    order.tablesT = oderUpdate.tablesT;
                    order.TotalAmount = oderUpdate.TotalAmount;
                    order.status = oderUpdate.status;
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
        public List<Order> GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
           
            
             
                return db.Orders
                    .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                    .ToList();
            
        }
        
    }
}
