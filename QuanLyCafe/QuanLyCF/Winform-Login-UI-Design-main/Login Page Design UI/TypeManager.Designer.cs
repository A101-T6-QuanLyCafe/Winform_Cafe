namespace Login_Page_Design_UI
{
    partial class TypeManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgv_productType = new System.Windows.Forms.DataGridView();
            this.dtgv_materialType = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_select = new System.Windows.Forms.Label();
            this.typeProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_productType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_materialType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 670);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lb_select);
            this.panel3.Controls.Add(this.txt_name);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_id);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btn_clear);
            this.panel3.Controls.Add(this.btn_remove);
            this.panel3.Controls.Add(this.btn_edit);
            this.panel3.Controls.Add(this.btn_add);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1056, 285);
            this.panel3.TabIndex = 2;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(151, 226);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(104, 30);
            this.btn_clear.TabIndex = 73;
            this.btn_clear.Text = "Làm mới";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(812, 226);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(104, 30);
            this.btn_remove.TabIndex = 72;
            this.btn_remove.Text = "Xóa";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(596, 226);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(104, 30);
            this.btn_edit.TabIndex = 71;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(343, 226);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(104, 30);
            this.btn_add.TabIndex = 70;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgv_productType);
            this.panel2.Location = new System.Drawing.Point(3, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 373);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgv_materialType);
            this.panel4.Location = new System.Drawing.Point(558, 297);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(498, 373);
            this.panel4.TabIndex = 4;
            // 
            // dtgv_productType
            // 
            this.dtgv_productType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_productType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_productType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeProductID,
            this.typeProductName});
            this.dtgv_productType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_productType.Location = new System.Drawing.Point(0, 0);
            this.dtgv_productType.Name = "dtgv_productType";
            this.dtgv_productType.RowHeadersWidth = 51;
            this.dtgv_productType.RowTemplate.Height = 24;
            this.dtgv_productType.Size = new System.Drawing.Size(498, 373);
            this.dtgv_productType.TabIndex = 0;
            this.dtgv_productType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_productType_CellClick);
            // 
            // dtgv_materialType
            // 
            this.dtgv_materialType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_materialType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_materialType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeID,
            this.TypeName});
            this.dtgv_materialType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_materialType.Location = new System.Drawing.Point(0, 0);
            this.dtgv_materialType.Name = "dtgv_materialType";
            this.dtgv_materialType.RowHeadersWidth = 51;
            this.dtgv_materialType.RowTemplate.Height = 24;
            this.dtgv_materialType.Size = new System.Drawing.Size(498, 373);
            this.dtgv_materialType.TabIndex = 1;
            this.dtgv_materialType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_materialType_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 75;
            this.label1.Text = "Mã loại";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(267, 44);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(206, 22);
            this.txt_id.TabIndex = 76;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(267, 109);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(206, 22);
            this.txt_name.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "Tên loại";
            // 
            // lb_select
            // 
            this.lb_select.AutoSize = true;
            this.lb_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_select.Location = new System.Drawing.Point(729, 47);
            this.lb_select.Name = "lb_select";
            this.lb_select.Size = new System.Drawing.Size(170, 25);
            this.lb_select.TabIndex = 79;
            this.lb_select.Text = "Chọn loại để thêm";
            // 
            // typeProductID
            // 
            this.typeProductID.DataPropertyName = "typeProductID";
            this.typeProductID.HeaderText = "Mã loại";
            this.typeProductID.MinimumWidth = 6;
            this.typeProductID.Name = "typeProductID";
            // 
            // typeProductName
            // 
            this.typeProductName.DataPropertyName = "typeProductName";
            this.typeProductName.HeaderText = "Tên loại";
            this.typeProductName.MinimumWidth = 6;
            this.typeProductName.Name = "typeProductName";
            // 
            // TypeID
            // 
            this.TypeID.DataPropertyName = "TypeID";
            this.TypeID.HeaderText = "Mã loại";
            this.TypeID.MinimumWidth = 6;
            this.TypeID.Name = "TypeID";
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "Tên loại";
            this.TypeName.MinimumWidth = 6;
            this.TypeName.Name = "TypeName";
            // 
            // TypeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.panel1);
            this.Name = "TypeManager";
            this.Text = "TypeManager";
            this.Load += new System.EventHandler(this.TypeManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_productType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_materialType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgv_materialType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgv_productType;
        private System.Windows.Forms.Label lb_select;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
    }
}