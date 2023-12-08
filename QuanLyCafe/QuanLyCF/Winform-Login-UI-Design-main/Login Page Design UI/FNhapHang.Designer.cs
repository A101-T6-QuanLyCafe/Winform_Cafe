namespace Login_Page_Design_UI
{
    partial class FNhapHang
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
            this.dtg_NguyenLieu = new System.Windows.Forms.DataGridView();
            this.dtgGioHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboNcc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDaTra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPNN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_NguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_NguyenLieu
            // 
            this.dtg_NguyenLieu.AllowUserToAddRows = false;
            this.dtg_NguyenLieu.AllowUserToDeleteRows = false;
            this.dtg_NguyenLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_NguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_NguyenLieu.Location = new System.Drawing.Point(0, 2);
            this.dtg_NguyenLieu.Name = "dtg_NguyenLieu";
            this.dtg_NguyenLieu.ReadOnly = true;
            this.dtg_NguyenLieu.RowHeadersWidth = 51;
            this.dtg_NguyenLieu.RowTemplate.Height = 24;
            this.dtg_NguyenLieu.Size = new System.Drawing.Size(760, 309);
            this.dtg_NguyenLieu.TabIndex = 0;
            // 
            // dtgGioHang
            // 
            this.dtgGioHang.AllowUserToAddRows = false;
            this.dtgGioHang.AllowUserToDeleteRows = false;
            this.dtgGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgGioHang.Location = new System.Drawing.Point(0, 382);
            this.dtgGioHang.Name = "dtgGioHang";
            this.dtgGioHang.ReadOnly = true;
            this.dtgGioHang.RowHeadersWidth = 51;
            this.dtgGioHang.RowTemplate.Height = 24;
            this.dtgGioHang.Size = new System.Drawing.Size(760, 264);
            this.dtgGioHang.TabIndex = 1;
            this.dtgGioHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgGioHang_CellContentClick);
            this.dtgGioHang.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgGioHang_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã nguyên liệu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên nguyên liệu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(112, 333);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 32);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(371, 333);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 32);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.Location = new System.Drawing.Point(526, 333);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(142, 32);
            this.btnTaoHD.TabIndex = 4;
            this.btnTaoHD.Text = "Xác Nhận";
            this.btnTaoHD.UseVisualStyleBackColor = true;
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 6;
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(247, 339);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(94, 22);
            this.numSL.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtNV);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cboNcc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnXacNhan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtp_NgayLap);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDaTra);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtGiaNhap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaPNN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(781, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 659);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "Nhân viên lập:";
            // 
            // txtNV
            // 
            this.txtNV.Location = new System.Drawing.Point(162, 483);
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(276, 22);
            this.txtNV.TabIndex = 44;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(173, 560);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 41);
            this.btnReload.TabIndex = 43;
            this.btnReload.Text = "Làm mới";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Nhà cung cấp:";
            // 
            // cboNcc
            // 
            this.cboNcc.FormattingEnabled = true;
            this.cboNcc.Location = new System.Drawing.Point(162, 122);
            this.cboNcc.Name = "cboNcc";
            this.cboNcc.Size = new System.Drawing.Size(276, 24);
            this.cboNcc.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Tìm theo tên:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(162, 70);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(276, 22);
            this.txtTimKiem.TabIndex = 39;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 38;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(286, 560);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 43);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(36, 560);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(83, 41);
            this.btnXacNhan.TabIndex = 36;
            this.btnXacNhan.Text = "Xác nhận ";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Ngày lập;";
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.Location = new System.Drawing.Point(162, 356);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(276, 22);
            this.dtp_NgayLap.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Đã trả:";
            // 
            // txtDaTra
            // 
            this.txtDaTra.Location = new System.Drawing.Point(162, 418);
            this.txtDaTra.Name = "txtDaTra";
            this.txtDaTra.Size = new System.Drawing.Size(276, 22);
            this.txtDaTra.TabIndex = 32;
            this.txtDaTra.TextChanged += new System.EventHandler(this.txtDaTra_TextChanged);
            this.txtDaTra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDaTra_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tổng giá:";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(162, 296);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(276, 22);
            this.txtGiaNhap.TabIndex = 30;
            this.txtGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNhap_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mã phiếu nhập:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMaPNN
            // 
            this.txtMaPNN.Location = new System.Drawing.Point(162, 238);
            this.txtMaPNN.Name = "txtMaPNN";
            this.txtMaPNN.Size = new System.Drawing.Size(276, 22);
            this.txtMaPNN.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Thông tin phiếu nhập";
            // 
            // FNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numSL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTaoHD);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgGioHang);
            this.Controls.Add(this.dtg_NguyenLieu);
            this.Name = "FNhapHang";
            this.Text = "FNhapHang";
            this.Load += new System.EventHandler(this.FNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_NguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGioHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_NguyenLieu;
        private System.Windows.Forms.DataGridView dtgGioHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNV;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboNcc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDaTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPNN;
        private System.Windows.Forms.Label label1;
    }
}