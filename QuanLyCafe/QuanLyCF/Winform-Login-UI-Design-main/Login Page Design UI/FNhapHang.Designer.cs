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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPNN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDaTra = new System.Windows.Forms.TextBox();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInhd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboNcc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_NguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_NguyenLieu
            // 
            this.dtg_NguyenLieu.AllowUserToAddRows = false;
            this.dtg_NguyenLieu.AllowUserToDeleteRows = false;
            this.dtg_NguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_NguyenLieu.Location = new System.Drawing.Point(0, 2);
            this.dtg_NguyenLieu.Name = "dtg_NguyenLieu";
            this.dtg_NguyenLieu.ReadOnly = true;
            this.dtg_NguyenLieu.RowHeadersWidth = 51;
            this.dtg_NguyenLieu.RowTemplate.Height = 24;
            this.dtg_NguyenLieu.Size = new System.Drawing.Size(533, 309);
            this.dtg_NguyenLieu.TabIndex = 0;
            // 
            // dtgGioHang
            // 
            this.dtgGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgGioHang.Location = new System.Drawing.Point(0, 382);
            this.dtgGioHang.Name = "dtgGioHang";
            this.dtgGioHang.RowHeadersWidth = 51;
            this.dtgGioHang.RowTemplate.Height = 24;
            this.dtgGioHang.Size = new System.Drawing.Size(533, 264);
            this.dtgGioHang.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(44, 326);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(303, 326);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.Location = new System.Drawing.Point(458, 326);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(75, 23);
            this.btnTaoHD.TabIndex = 4;
            this.btnTaoHD.Text = "Xác Nhận";
            this.btnTaoHD.UseVisualStyleBackColor = true;
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(742, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thông tin phiếu nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 6;
            // 
            // txtMaPNN
            // 
            this.txtMaPNN.Location = new System.Drawing.Point(728, 180);
            this.txtMaPNN.Name = "txtMaPNN";
            this.txtMaPNN.Size = new System.Drawing.Size(183, 22);
            this.txtMaPNN.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã PN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(654, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "tổng giá";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(728, 224);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(183, 22);
            this.txtGiaNhap.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(654, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "đã trả";
            // 
            // txtDaTra
            // 
            this.txtDaTra.Location = new System.Drawing.Point(728, 303);
            this.txtDaTra.Name = "txtDaTra";
            this.txtDaTra.Size = new System.Drawing.Size(183, 22);
            this.txtDaTra.TabIndex = 11;
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.Location = new System.Drawing.Point(728, 265);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(183, 22);
            this.dtp_NgayLap.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "ngày lập";
            // 
            // btnInhd
            // 
            this.btnInhd.Location = new System.Drawing.Point(652, 422);
            this.btnInhd.Name = "btnInhd";
            this.btnInhd.Size = new System.Drawing.Size(75, 23);
            this.btnInhd.TabIndex = 15;
            this.btnInhd.Text = "In phiếu nhập";
            this.btnInhd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(831, 422);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(745, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "In phiếu nhập";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tìm theo tên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(728, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 22);
            this.textBox1.TabIndex = 18;
            // 
            // cboNcc
            // 
            this.cboNcc.FormattingEnabled = true;
            this.cboNcc.Location = new System.Drawing.Point(728, 64);
            this.cboNcc.Name = "cboNcc";
            this.cboNcc.Size = new System.Drawing.Size(178, 24);
            this.cboNcc.TabIndex = 20;
            this.cboNcc.SelectedIndexChanged += new System.EventHandler(this.cboNcc_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(635, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "nhà cung cấp";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(920, 11);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(61, 23);
            this.btnReload.TabIndex = 22;
            this.btnReload.Text = "reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(162, 327);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(73, 22);
            this.numSL.TabIndex = 24;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(631, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "nhân viên lập";
            // 
            // txtNV
            // 
            this.txtNV.Location = new System.Drawing.Point(728, 349);
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(183, 22);
            this.txtNV.TabIndex = 25;
            this.txtNV.TextChanged += new System.EventHandler(this.txtNV_TextChanged);
            // 
            // FNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 639);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNV);
            this.Controls.Add(this.numSL);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboNcc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInhd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_NgayLap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDaTra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaPNN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_NguyenLieu;
        private System.Windows.Forms.DataGridView dtgGioHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPNN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDaTra;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInhd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboNcc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNV;
    }
}