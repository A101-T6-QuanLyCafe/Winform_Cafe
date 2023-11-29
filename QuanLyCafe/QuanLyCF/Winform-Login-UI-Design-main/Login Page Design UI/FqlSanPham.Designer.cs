namespace Login_Page_Design_UI
{
    partial class FqlSanPham
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
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.dtgSanpham = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTebSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckIsdelete = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnMoBan = new System.Windows.Forms.Button();
            this.ckDaXoa = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(358, 70);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(121, 24);
            this.cboLoai.TabIndex = 0;
            // 
            // dtgSanpham
            // 
            this.dtgSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSanpham.Location = new System.Drawing.Point(31, 134);
            this.dtgSanpham.Name = "dtgSanpham";
            this.dtgSanpham.RowHeadersWidth = 51;
            this.dtgSanpham.RowTemplate.Height = 24;
            this.dtgSanpham.Size = new System.Drawing.Size(628, 313);
            this.dtgSanpham.TabIndex = 1;
            this.dtgSanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSanpham_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(91, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(111, 22);
            this.txtID.TabIndex = 3;
            // 
            // txtTebSP
            // 
            this.txtTebSP.Location = new System.Drawing.Point(303, 23);
            this.txtTebSP.Name = "txtTebSP";
            this.txtTebSP.Size = new System.Drawing.Size(176, 22);
            this.txtTebSP.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "tên sản phẩm";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(91, 74);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(111, 22);
            this.txtGia.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "giá";
            // 
            // ckIsdelete
            // 
            this.ckIsdelete.AutoSize = true;
            this.ckIsdelete.Location = new System.Drawing.Point(217, 76);
            this.ckIsdelete.Name = "ckIsdelete";
            this.ckIsdelete.Size = new System.Drawing.Size(77, 20);
            this.ckIsdelete.TabIndex = 8;
            this.ckIsdelete.Text = "isdelete";
            this.ckIsdelete.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "loại";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(485, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(566, 20);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(485, 67);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnMoBan
            // 
            this.btnMoBan.Location = new System.Drawing.Point(566, 67);
            this.btnMoBan.Name = "btnMoBan";
            this.btnMoBan.Size = new System.Drawing.Size(75, 23);
            this.btnMoBan.TabIndex = 13;
            this.btnMoBan.Text = "mở bán lại";
            this.btnMoBan.UseVisualStyleBackColor = true;
            this.btnMoBan.Click += new System.EventHandler(this.btnMoBan_Click);
            // 
            // ckDaXoa
            // 
            this.ckDaXoa.AutoSize = true;
            this.ckDaXoa.Location = new System.Drawing.Point(217, 102);
            this.ckDaXoa.Name = "ckDaXoa";
            this.ckDaXoa.Size = new System.Drawing.Size(70, 20);
            this.ckDaXoa.TabIndex = 14;
            this.ckDaXoa.Text = "đã xóa";
            this.ckDaXoa.UseVisualStyleBackColor = true;
            this.ckDaXoa.CheckedChanged += new System.EventHandler(this.ckDaXoa_CheckedChanged);
            // 
            // FqlSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.ckDaXoa);
            this.Controls.Add(this.btnMoBan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckIsdelete);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTebSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgSanpham);
            this.Controls.Add(this.cboLoai);
            this.Name = "FqlSanPham";
            this.Text = "FqlSanPham";
            this.Load += new System.EventHandler(this.FqlSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.DataGridView dtgSanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTebSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckIsdelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnMoBan;
        private System.Windows.Forms.CheckBox ckDaXoa;
    }
}