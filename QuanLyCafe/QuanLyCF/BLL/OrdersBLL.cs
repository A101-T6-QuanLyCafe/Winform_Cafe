﻿using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
           
            
             
               
            try
            {
                var materialsQuery = db.Orders
                    .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                    .ToList();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã hóa đơn", typeof(int));
                dataTable.Columns.Add("Ngày lập", typeof(string));
                dataTable.Columns.Add("Tổng tiền", typeof(float));
               
                dataTable.Columns.Add("Mã nhân viên", typeof(int));
                dataTable.Columns.Add("Bàn", typeof(int));
                dataTable.Columns.Add("Trạng thái", typeof(int));
                foreach (var incoming in materialsQuery)
                {
                    dataTable.Rows.Add(
                        incoming.OrderID,
                        incoming.EmployeeID,
                        incoming.TotalAmount,
                        incoming.EmployeeID,
                        incoming.TablesID,
                        incoming.status

                    );
                }

                return dataTable;
            }
            catch
            {
                return null;
            }

        }
        #region Hoang
        public static Order GetOrderFromActiveTable(int v)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            return DB.Orders.Where(x => x.TablesID == v && x.status == 0).FirstOrDefault();
        }

        public static Boolean CreateNewOrder(int empID, int currentTableID1)
        {
            Order order = new Order();
            order.EmployeeID = empID;
            order.TablesID = currentTableID1;
            order.status = 0;
            order.TotalAmount = 0;
            order.OrderDate = DateTime.Now;
            try
            {
                CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
                DB.Orders.InsertOnSubmit(order);
                DB.SubmitChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
            
        }

        public static void SetTotal(int orderID)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            Order order = DB.Orders.FirstOrDefault(x => x.OrderID == orderID);
            List<OrderDetail> orderDetails = OrderDetailBLL.GetOrderDetailByOrderID(orderID);
            float total = 0;
            foreach (OrderDetail detail in orderDetails)
            {
                total +=  detail.Quantity * detail.Product.Price;
            }
            order.TotalAmount = total;
            DB.SubmitChanges();
        }

        public static string GetTotal(int orderID)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            Order order = DB.Orders.FirstOrDefault(x => x.OrderID == orderID);
            return order.TotalAmount.ToString();
        }

        public static void ChangeTable(int currentTableID, int selected_table)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            Order order = DB.Orders.FirstOrDefault(x => x.TablesID == currentTableID && x.status == 0);
            order.TablesID = selected_table;
            DB.SubmitChanges();
        }

        public static void Payments(int currentTableID)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            Order order = DB.Orders.FirstOrDefault(x => x.TablesID == currentTableID && x.status == 0);
            order.status = 1;
            ExportBill(order);
            DB.SubmitChanges();
        }

        public static void ExportBill(Order order)
        {
            //
            List<OrderDetail> orderDetails = OrderDetailBLL.GetOrderDetailByOrderID(order.OrderID);
            System.Data.DataTable data = new System.Data.DataTable();
            float total = 0;
            data.Columns.Add("Tên sản phẩm");
            data.Columns.Add("Số lượng");
            data.Columns.Add("Đơn giá");
            data.Columns.Add("Thành tiền");
            foreach (OrderDetail detail in orderDetails)
            {
                float unitPrice = (detail.Quantity * detail.Price);
                data.Rows.Add(detail.Product.ProductName, detail.Quantity, detail.Price, unitPrice);
                total += unitPrice;
            }
            Employee employee = EmployeesBLL.GetEmpByID(order.EmployeeID);
            List<String> plus = new List<String>();
            plus.Add(DateTime.Now.ToShortDateString());
            plus.Add(order.TablesID.ToString());
            plus.Add(employee.EmployeeID.ToString());
            plus.Add(total.ToString());
            OtherServicesBLL.ExportFile(data, plus, "Bill", "Hoá Đơn");
        }

        public static bool CombineTable(int currentTableID, int selected_table)
        {
            CoffeeShopDBDataContext DB = new CoffeeShopDBDataContext();
            // lấy toàn bộ order detal của bàn cũ chuyển sang bàn mới 
            // xóa order cũ
            Order curOrder = DB.Orders.FirstOrDefault(x => x.TablesID ==  currentTableID && x.status == 0);
            if (curOrder == null) return false;
            Order endOrder = DB.Orders.FirstOrDefault(x => x.TablesID ==  selected_table && x.status == 0);
            if (endOrder == null) return false;
            if (curOrder == endOrder) return false;
            OrderDetailBLL.MoveToNewOrderID(curOrder.OrderID, endOrder.OrderID);
            DB.Orders.DeleteOnSubmit(curOrder);
            DB.SubmitChanges();
            TableTBLL.CombineTable(currentTableID);
            OrdersBLL.SetTotal(endOrder.OrderID);
            return true;
        }
        #endregion
    }
}
