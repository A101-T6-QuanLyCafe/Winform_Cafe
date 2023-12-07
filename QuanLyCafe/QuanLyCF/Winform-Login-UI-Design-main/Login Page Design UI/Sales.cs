using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page_Design_UI
{
    public partial class Sales : Form
    {
        tablesT currentTable;
        Employee employee;
        public Sales(Employee emp)
        {
            InitializeComponent();
            employee = emp;
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void Sales_Load(object sender, EventArgs e)
        {
            ChangeTableNameDisplay();
            LoadAllTable();
            LoadCboProductType();
            LoadCboTable();
        }

        private void LoadCboTable()
        {
            List<tablesT> tables = TableTBLL.GetAllTable();
            cbo_table.DataSource = tables;
            cbo_table.DisplayMember = "TableID";
            cbo_table.ValueMember = "TableID";
        }

        private void LoadCboProduct(int id)
        {
            //lấy dữ liệu về sản phẩm và đẩy lên combobox sản phẩm 
            List<Product> products = ProductsBLL.GetProductByTypeID(id).Where(x => x.Craftable == 1).ToList();
            cbo_product.DataSource = products;
            cbo_product.DisplayMember = "ProductName";
            cbo_product.ValueMember = "ProductID";

        }

        private void LoadCboProductType()
        {
            //lấy dữ liệu về Loại sản phẩm và đẩy lên combobox Loại sản phẩm 
            List<typeProduct> types = TypeProductBLL.GetAllProductType();
            cbo_type.DataSource = types;
            cbo_type.DisplayMember = "TypeProductName";
            cbo_type.ValueMember = "TypeProductID";
        }

        private void LoadAllTable()
        {
            //Làm trống panel hiển thị bàn
            ClearAllTable();
            // lấy ds bàn từ database
            List<tablesT> tables = TableTBLL.GetAllTable();
            foreach (tablesT table in tables)
            {
                // khởi tạo đối tượng hiển thị bàn và thêm đối tượng vào panel 
                Button btn = new Button();
                btn.Width = 100;
                btn.Height = 100;
                btn.Tag = table.TableID;
                btn.Click +=Btn_Click;

                if (table.status == 1)
                {
                    btn.BackColor = SystemColors.Info;
                    btn.Text = "Có người " + "\n" + "Tên : " + table.Name;
                }
                else
                {
                    btn.BackColor = SystemColors.Window;
                    btn.Text = "Trống "+ "\n" + "Tên : " + table.Name;
                }
                Table_panel.Controls.Add(btn);
            }
        }

        //phương thức Làm trống panel hiển thị bàn
        private void ClearAllTable()
        {

            List<Button> btns = Table_panel.Controls.OfType<Button>().ToList();
            foreach (Control control in btns)
            {
                Table_panel.Controls.Remove(control);
                control.Dispose();
            }
        }
        //sự kiện khi click vào bàn 
        private void Btn_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            currentTable = TableTBLL.GetByID(int.Parse(button.Tag.ToString()));
            lb_currentTable.Text = currentTable.Name;
            LoadOrderDetail();

        }

        // phương thức hiển thị chi tiết hóa đơn 
        private void LoadOrderDetail()
        {
            // lấy hóa đơn chưa thanh toán của bàn hiện tại 
            // nếu bàn hiện tại không có hóa đơn nào xóa dữ liệu trong datagridview 
            // nếu có thì load các thông tin hóa đơn đó lên datagridview
            Order order = OrdersBLL.GetOrderFromActiveTable(currentTable.TableID);
            if (order == null)
            {
                dtgv_orders.DataSource = null;
                return;
            }
            LoadOrderInfoByOrderID(order.OrderID);
        }

        private void LoadOrderInfoByOrderID(int orderID)
        {
            var orderDetails = OrderDetailBLL.GetOrderDetailByOrderID(orderID).Select(x => new { x.Product.ProductName, x.Quantity }).ToList();
            dtgv_orders.DataSource = orderDetails;
            txt_total.Text = OrdersBLL.GetTotal(orderID);

        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            // lấy hóa đơn chưa thanh toán của bàn được chọn  nếu không tồn tại hóa đơn hủy bỏ giao tác
            // nếu input không đủ hủy bỏ giao tác
            if (currentTable == null) return;
            Order order = OrdersBLL.GetOrderFromActiveTable(currentTable.TableID);
            if (order == null) return;
            if (cbo_product.SelectedIndex == -1) return;
            if (nud_quantity.Value == 0) return;

            // khởi tọa đối tượng chi tiết hóa đơn mới 
            OrderDetail newODT = new OrderDetail();
            newODT.OrderID = order.OrderID;
            newODT.ProductID = int.Parse(cbo_product.SelectedValue.ToString());
            newODT.Quantity = int.Parse(nud_quantity.Value.ToString());
            newODT.Price = ProductsBLL.GetPrice(newODT.ProductID);

            // thực hiện tính toán nguyên liệu có đủ để tạo ra sản phẩm hay không nếu không thông báo không đủ nguyên liệu và hủy bỏ tác vụ
            if(!ProductsBLL.Craftable(newODT.ProductID, newODT.Quantity))
            {
                MessageBox.Show("Nguyên liệu không đủ xin vui lòng chọn món khác");
                return;
            }
            //xửa lý việc thêm hoặc chi tiết hóa đơn 
            // cập nhật thành tiền 
            // hiển thị chi tiết hóa đơn lên datagridview

            OrderDetailBLL.createOrderDetail(newODT);
            OrdersBLL.SetTotal(order.OrderID);
            LoadOrderInfoByOrderID(order.OrderID);

        }


        private void cbo_type_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadCboProduct(int.Parse(cbo_type.SelectedValue.ToString()));
        }

        private void btn_getTable_Click(object sender, EventArgs e)
        {
            //kiểm tra bàn đã được đặt hay chưa nếu đã được đạt thì hủy giao tác
            if (currentTable == null) return;
            if (!TableTBLL.IsEmpty(currentTable.TableID))
            {
                MessageBox.Show("Bàn này đã được đặt rồi");
                return;
            }
            // nếu bàn chưa đuợc đặt chuyển bàn thành đã đặt đồng thời tạo hóa đơn tương ứng 
            // load loại chi tiết hóa đơn 
            if (OrdersBLL.CreateNewOrder(employee.EmployeeID, currentTable.TableID))
            {
                TableTBLL.BookTable(currentTable.TableID);
                LoadAllTable();
                LoadOrderDetail();
            }


        }

        private void btn_swapTable_Click(object sender, EventArgs e)
        {
            //kiểm tra xem bàn đã chọn có trống hay không 
            //nếu không hiển thị bàn không trống và kết thúc
            //nếu có thực hiện chuyển bàn
            if (currentTable == null) return;
            int selected_table = int.Parse(cbo_table.SelectedValue.ToString());
            if (!TableTBLL.IsEmpty(selected_table))
            {
                MessageBox.Show("Không thể chuyển sang bàn này");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Xác Nhận chuyển bàn", "Chuyển bàn", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            TableTBLL.ChangeTable(currentTable.TableID, selected_table);
            OrdersBLL.ChangeTable(currentTable.TableID, selected_table);
            LoadAllTable();
            LoadOrderDetail();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            // nếu bàn được chọn trống không thể thanh toán
            if (currentTable == null) return;
            if (TableTBLL.IsEmpty(currentTable.TableID))
                return;
            DialogResult dialogResult = MessageBox.Show("Xác Nhận thanh toán", "Thanh toán", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            OrdersBLL.Payments(currentTable.TableID);
            TableTBLL.Payments(currentTable.TableID);
            LoadAllTable();
            LoadOrderDetail();
            currentTable  = null;
            ChangeTableNameDisplay();
        }

        private void btn_combineTable_Click(object sender, EventArgs e)
        {
            if (currentTable == null) return;
            int selected_table = int.Parse(cbo_table.SelectedValue.ToString());
            if (currentTable.TableID == selected_table) return;
            if (TableTBLL.IsEmpty(selected_table))
            {
                MessageBox.Show("Không thể chuyển sang bàn này");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Xác Nhận gộp bàn", "Gộp bàn", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            Boolean temp = OrdersBLL.CombineTable(currentTable.TableID, selected_table);

            LoadAllTable();
            LoadOrderDetail();
        }

        private void ChangeTableNameDisplay()
        {
            lb_currentTable.Text = "Select a table";
        }

        private void btn_updateTable_Click(object sender, EventArgs e)
        {
            LoadAllTable();
        }
    }
}
