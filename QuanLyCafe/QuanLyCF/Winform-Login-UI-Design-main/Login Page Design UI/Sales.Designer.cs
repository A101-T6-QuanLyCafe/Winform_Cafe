namespace Login_Page_Design_UI
{
    partial class Sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Table_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_currentTable = new System.Windows.Forms.Label();
            this.dtgv_orders = new System.Windows.Forms.DataGridView();
            this.nud_quantity = new System.Windows.Forms.NumericUpDown();
            this.btn_order = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_product = new System.Windows.Forms.ComboBox();
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.detail_panel = new System.Windows.Forms.Panel();
            this.btn_combineTable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_getTable = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.cbo_table = new System.Windows.Forms.ComboBox();
            this.btn_swapTable = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).BeginInit();
            this.detail_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table_panel
            // 
            this.Table_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Table_panel.Location = new System.Drawing.Point(3, 3);
            this.Table_panel.Name = "Table_panel";
            this.Table_panel.Size = new System.Drawing.Size(523, 667);
            this.Table_panel.TabIndex = 0;
            // 
            // lb_currentTable
            // 
            this.lb_currentTable.AutoSize = true;
            this.lb_currentTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_currentTable.Location = new System.Drawing.Point(157, 99);
            this.lb_currentTable.Name = "lb_currentTable";
            this.lb_currentTable.Size = new System.Drawing.Size(220, 46);
            this.lb_currentTable.TabIndex = 13;
            this.lb_currentTable.Text = "displaytext";
            // 
            // dtgv_orders
            // 
            this.dtgv_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_orders.Location = new System.Drawing.Point(3, 166);
            this.dtgv_orders.Name = "dtgv_orders";
            this.dtgv_orders.RowHeadersWidth = 51;
            this.dtgv_orders.RowTemplate.Height = 24;
            this.dtgv_orders.Size = new System.Drawing.Size(521, 349);
            this.dtgv_orders.TabIndex = 6;
            // 
            // nud_quantity
            // 
            this.nud_quantity.Location = new System.Drawing.Point(376, 12);
            this.nud_quantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nud_quantity.Name = "nud_quantity";
            this.nud_quantity.Size = new System.Drawing.Size(101, 22);
            this.nud_quantity.TabIndex = 5;
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(376, 47);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(101, 24);
            this.btn_order.TabIndex = 4;
            this.btn_order.Text = "Thêm món";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại sản phẩm";
            // 
            // cbo_product
            // 
            this.cbo_product.FormattingEnabled = true;
            this.cbo_product.Location = new System.Drawing.Point(138, 48);
            this.cbo_product.Name = "cbo_product";
            this.cbo_product.Size = new System.Drawing.Size(209, 24);
            this.cbo_product.TabIndex = 1;
            // 
            // cbo_type
            // 
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Location = new System.Drawing.Point(138, 9);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(209, 24);
            this.cbo_type.TabIndex = 0;
            this.cbo_type.SelectionChangeCommitted += new System.EventHandler(this.cbo_type_SelectionChangeCommitted);
            // 
            // detail_panel
            // 
            this.detail_panel.Controls.Add(this.btn_combineTable);
            this.detail_panel.Controls.Add(this.label3);
            this.detail_panel.Controls.Add(this.txt_total);
            this.detail_panel.Controls.Add(this.btn_getTable);
            this.detail_panel.Controls.Add(this.btn_submit);
            this.detail_panel.Controls.Add(this.cbo_table);
            this.detail_panel.Controls.Add(this.btn_swapTable);
            this.detail_panel.Controls.Add(this.lb_currentTable);
            this.detail_panel.Controls.Add(this.dtgv_orders);
            this.detail_panel.Controls.Add(this.nud_quantity);
            this.detail_panel.Controls.Add(this.btn_order);
            this.detail_panel.Controls.Add(this.label2);
            this.detail_panel.Controls.Add(this.label1);
            this.detail_panel.Controls.Add(this.cbo_product);
            this.detail_panel.Controls.Add(this.cbo_type);
            this.detail_panel.Location = new System.Drawing.Point(532, 3);
            this.detail_panel.Name = "detail_panel";
            this.detail_panel.Size = new System.Drawing.Size(527, 667);
            this.detail_panel.TabIndex = 1;
            // 
            // btn_combineTable
            // 
            this.btn_combineTable.Location = new System.Drawing.Point(35, 605);
            this.btn_combineTable.Name = "btn_combineTable";
            this.btn_combineTable.Size = new System.Drawing.Size(157, 25);
            this.btn_combineTable.TabIndex = 23;
            this.btn_combineTable.Text = "Gộp bàn";
            this.btn_combineTable.UseVisualStyleBackColor = true;
            this.btn_combineTable.Click += new System.EventHandler(this.btn_combineTable_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tổng tiền";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(353, 612);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(157, 22);
            this.txt_total.TabIndex = 21;
            // 
            // btn_getTable
            // 
            this.btn_getTable.Location = new System.Drawing.Point(353, 541);
            this.btn_getTable.Name = "btn_getTable";
            this.btn_getTable.Size = new System.Drawing.Size(157, 25);
            this.btn_getTable.TabIndex = 20;
            this.btn_getTable.Text = "Đặt bàn";
            this.btn_getTable.UseVisualStyleBackColor = true;
            this.btn_getTable.Click += new System.EventHandler(this.btn_getTable_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(353, 571);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(157, 25);
            this.btn_submit.TabIndex = 19;
            this.btn_submit.Text = "Thanh toán";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // cbo_table
            // 
            this.cbo_table.FormattingEnabled = true;
            this.cbo_table.Location = new System.Drawing.Point(35, 570);
            this.cbo_table.Name = "cbo_table";
            this.cbo_table.Size = new System.Drawing.Size(157, 24);
            this.cbo_table.TabIndex = 18;
            // 
            // btn_swapTable
            // 
            this.btn_swapTable.Location = new System.Drawing.Point(35, 541);
            this.btn_swapTable.Name = "btn_swapTable";
            this.btn_swapTable.Size = new System.Drawing.Size(157, 25);
            this.btn_swapTable.TabIndex = 17;
            this.btn_swapTable.Text = "Chuyển bàn";
            this.btn_swapTable.UseVisualStyleBackColor = true;
            this.btn_swapTable.Click += new System.EventHandler(this.btn_swapTable_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.detail_panel);
            this.panel1.Controls.Add(this.Table_panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 673);
            this.panel1.TabIndex = 1;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.panel1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).EndInit();
            this.detail_panel.ResumeLayout(false);
            this.detail_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Table_panel;
        private System.Windows.Forms.Label lb_currentTable;
        private System.Windows.Forms.DataGridView dtgv_orders;
        private System.Windows.Forms.NumericUpDown nud_quantity;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_product;
        private System.Windows.Forms.ComboBox cbo_type;
        private System.Windows.Forms.Panel detail_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_combineTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_getTable;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ComboBox cbo_table;
        private System.Windows.Forms.Button btn_swapTable;
    }
}