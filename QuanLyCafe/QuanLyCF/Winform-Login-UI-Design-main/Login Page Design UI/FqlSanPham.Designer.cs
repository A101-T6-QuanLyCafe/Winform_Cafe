﻿namespace Login_Page_Design_UI
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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnMoBan = new System.Windows.Forms.Button();
            this.ckDaXoa = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_isDelete = new System.Windows.Forms.CheckBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanpham)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(525, 89);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(193, 24);
            this.cboLoai.TabIndex = 0;
            // 
            // dtgSanpham
            // 
            this.dtgSanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSanpham.Location = new System.Drawing.Point(3, 357);
            this.dtgSanpham.Name = "dtgSanpham";
            this.dtgSanpham.RowHeadersWidth = 51;
            this.dtgSanpham.RowTemplate.Height = 24;
            this.dtgSanpham.Size = new System.Drawing.Size(1057, 315);
            this.dtgSanpham.TabIndex = 1;
            this.dtgSanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSanpham_CellClick);
            this.dtgSanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSanpham_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sản phẩm";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(158, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(176, 22);
            this.txtID.TabIndex = 3;
            // 
            // txtTebSP
            // 
            this.txtTebSP.Location = new System.Drawing.Point(158, 84);
            this.txtTebSP.Name = "txtTebSP";
            this.txtTebSP.Size = new System.Drawing.Size(176, 22);
            this.txtTebSP.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "tên sản phẩm";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(525, 39);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(193, 22);
            this.txtGia.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá";
            // 
            // ckIsdelete
            // 
            this.ckIsdelete.AutoSize = true;
            this.ckIsdelete.Location = new System.Drawing.Point(286, 10);
            this.ckIsdelete.Name = "ckIsdelete";
            this.ckIsdelete.Size = new System.Drawing.Size(77, 20);
            this.ckIsdelete.TabIndex = 8;
            this.ckIsdelete.Text = "isdelete";
            this.ckIsdelete.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Loại sản phẩm";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(462, 225);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 30);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(687, 225);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 30);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnMoBan
            // 
            this.btnMoBan.Location = new System.Drawing.Point(916, 225);
            this.btnMoBan.Name = "btnMoBan";
            this.btnMoBan.Size = new System.Drawing.Size(104, 30);
            this.btnMoBan.TabIndex = 13;
            this.btnMoBan.Text = "mở bán lại";
            this.btnMoBan.UseVisualStyleBackColor = true;
            this.btnMoBan.Click += new System.EventHandler(this.btnMoBan_Click);
            // 
            // ckDaXoa
            // 
            this.ckDaXoa.AutoSize = true;
            this.ckDaXoa.Location = new System.Drawing.Point(286, 36);
            this.ckDaXoa.Name = "ckDaXoa";
            this.ckDaXoa.Size = new System.Drawing.Size(70, 20);
            this.ckDaXoa.TabIndex = 14;
            this.ckDaXoa.Text = "đã xóa";
            this.ckDaXoa.UseVisualStyleBackColor = true;
            this.ckDaXoa.CheckedChanged += new System.EventHandler(this.ckDaXoa_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb_isDelete);
            this.panel2.Controls.Add(this.ckDaXoa);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.txt_search);
            this.panel2.Controls.Add(this.ckIsdelete);
            this.panel2.Location = new System.Drawing.Point(-1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 59);
            this.panel2.TabIndex = 15;
            // 
            // cb_isDelete
            // 
            this.cb_isDelete.AutoSize = true;
            this.cb_isDelete.Location = new System.Drawing.Point(601, 21);
            this.cb_isDelete.Name = "cb_isDelete";
            this.cb_isDelete.Size = new System.Drawing.Size(70, 20);
            this.cb_isDelete.TabIndex = 7;
            this.cb_isDelete.Text = "đã xóa";
            this.cb_isDelete.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(963, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(726, 19);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(207, 22);
            this.txt_search.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btn_clear);
            this.panel3.Controls.Add(this.btnMoBan);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btn_add);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtGia);
            this.panel3.Controls.Add(this.cboLoai);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtTebSP);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(2, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1059, 285);
            this.panel3.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(811, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(18, 225);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(104, 30);
            this.btn_clear.TabIndex = 73;
            this.btn_clear.Text = "Làm mới";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(230, 225);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(104, 30);
            this.btn_add.TabIndex = 70;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FqlSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtgSanpham);
            this.Name = "FqlSanPham";
            this.Text = "FqlSanPham";
            this.Load += new System.EventHandler(this.FqlSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanpham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnMoBan;
        private System.Windows.Forms.CheckBox ckDaXoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cb_isDelete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_clear;
    }
}