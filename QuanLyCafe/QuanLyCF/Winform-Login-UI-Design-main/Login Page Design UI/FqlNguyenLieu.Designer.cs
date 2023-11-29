namespace Login_Page_Design_UI
{
    partial class FqlNguyenLieu
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
            this.dtgNL = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.ckISdelete = new System.Windows.Forms.CheckBox();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXOa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNL)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgNL
            // 
            this.dtgNL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNL.Location = new System.Drawing.Point(12, 140);
            this.dtgNL.Name = "dtgNL";
            this.dtgNL.RowHeadersWidth = 51;
            this.dtgNL.RowTemplate.Height = 24;
            this.dtgNL.Size = new System.Drawing.Size(668, 317);
            this.dtgNL.TabIndex = 0;
            this.dtgNL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNL_CellContentClick);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(75, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "mã ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "gia";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(75, 53);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 22);
            this.txtGia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "tên nguyên liệu";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(287, 15);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 22);
            this.txtTen.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "số lượng";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(287, 56);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(100, 22);
            this.txtSL.TabIndex = 7;
            // 
            // ckISdelete
            // 
            this.ckISdelete.AutoSize = true;
            this.ckISdelete.Location = new System.Drawing.Point(420, 14);
            this.ckISdelete.Name = "ckISdelete";
            this.ckISdelete.Size = new System.Drawing.Size(79, 20);
            this.ckISdelete.TabIndex = 10;
            this.ckISdelete.Text = "IsDelete";
            this.ckISdelete.UseVisualStyleBackColor = true;
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(467, 53);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(121, 24);
            this.cboLoai.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Loại";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(62, 111);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXOa
            // 
            this.btnXOa.Location = new System.Drawing.Point(287, 111);
            this.btnXOa.Name = "btnXOa";
            this.btnXOa.Size = new System.Drawing.Size(75, 23);
            this.btnXOa.TabIndex = 14;
            this.btnXOa.Text = "xóa";
            this.btnXOa.UseVisualStyleBackColor = true;
            this.btnXOa.Click += new System.EventHandler(this.btnXOa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(513, 111);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nha cung cap";
            // 
            // cboNCC
            // 
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(287, 84);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(245, 24);
            this.cboNCC.TabIndex = 16;
            // 
            // FqlNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboNCC);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXOa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.ckISdelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dtgNL);
            this.Name = "FqlNguyenLieu";
            this.Text = "FqlNguyenLieu";
            this.Load += new System.EventHandler(this.FqlNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgNL;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.CheckBox ckISdelete;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXOa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboNCC;
    }
}