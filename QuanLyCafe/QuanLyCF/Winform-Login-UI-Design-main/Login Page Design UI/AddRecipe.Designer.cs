namespace Login_Page_Design_UI
{
    partial class AddRecipe
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgv_material = new System.Windows.Forms.DataGridView();
            this.dtgv_recipe = new System.Windows.Forms.DataGridView();
            this.lb_pdName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_materialID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_materialName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_materialUnit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_addToRecipe = new System.Windows.Forms.Button();
            this.btn_removeFromRecipe = new System.Windows.Forms.Button();
            this.pic_materialPhoto = new System.Windows.Forms.PictureBox();
            this.nud_value = new System.Windows.Forms.NumericUpDown();
            this.Materials_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materials_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecipeInfoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materials_Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_material)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_recipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_materialPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_value)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 671);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lb_pdName);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1253, 61);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.nud_value);
            this.panel3.Controls.Add(this.pic_materialPhoto);
            this.panel3.Controls.Add(this.txt_materialUnit);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_materialName);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_materialID);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(3, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1253, 201);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btn_removeFromRecipe);
            this.panel4.Controls.Add(this.btn_addToRecipe);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dtgv_recipe);
            this.panel4.Controls.Add(this.dtgv_material);
            this.panel4.Location = new System.Drawing.Point(3, 277);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1253, 391);
            this.panel4.TabIndex = 2;
            // 
            // dtgv_material
            // 
            this.dtgv_material.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_material.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materials_ID,
            this.Materials_Name,
            this.Unit});
            this.dtgv_material.Location = new System.Drawing.Point(7, 55);
            this.dtgv_material.Name = "dtgv_material";
            this.dtgv_material.RowHeadersWidth = 51;
            this.dtgv_material.RowTemplate.Height = 24;
            this.dtgv_material.Size = new System.Drawing.Size(547, 329);
            this.dtgv_material.TabIndex = 0;
            this.dtgv_material.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_material_CellClick);
            // 
            // dtgv_recipe
            // 
            this.dtgv_recipe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_recipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_recipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecipeInfoID,
            this.Materials_Nam,
            this.Quantity});
            this.dtgv_recipe.Location = new System.Drawing.Point(705, 55);
            this.dtgv_recipe.Name = "dtgv_recipe";
            this.dtgv_recipe.RowHeadersWidth = 51;
            this.dtgv_recipe.RowTemplate.Height = 24;
            this.dtgv_recipe.Size = new System.Drawing.Size(547, 329);
            this.dtgv_recipe.TabIndex = 1;
            this.dtgv_recipe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_recipe_CellClick);
            // 
            // lb_pdName
            // 
            this.lb_pdName.AutoSize = true;
            this.lb_pdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_pdName.Location = new System.Drawing.Point(544, 22);
            this.lb_pdName.Name = "lb_pdName";
            this.lb_pdName.Size = new System.Drawing.Size(178, 29);
            this.lb_pdName.TabIndex = 0;
            this.lb_pdName.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(189, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nguyên liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(946, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Công thức";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Nguyên liệu";
            // 
            // txt_materialID
            // 
            this.txt_materialID.Enabled = false;
            this.txt_materialID.Location = new System.Drawing.Point(280, 36);
            this.txt_materialID.Name = "txt_materialID";
            this.txt_materialID.Size = new System.Drawing.Size(182, 22);
            this.txt_materialID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giá trị";
            // 
            // txt_materialName
            // 
            this.txt_materialName.Enabled = false;
            this.txt_materialName.Location = new System.Drawing.Point(665, 36);
            this.txt_materialName.Name = "txt_materialName";
            this.txt_materialName.Size = new System.Drawing.Size(182, 22);
            this.txt_materialName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên nguyên liệu ";
            // 
            // txt_materialUnit
            // 
            this.txt_materialUnit.Enabled = false;
            this.txt_materialUnit.Location = new System.Drawing.Point(280, 88);
            this.txt_materialUnit.Name = "txt_materialUnit";
            this.txt_materialUnit.Size = new System.Drawing.Size(182, 22);
            this.txt_materialUnit.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn vị tính";
            // 
            // btn_addToRecipe
            // 
            this.btn_addToRecipe.Location = new System.Drawing.Point(584, 183);
            this.btn_addToRecipe.Name = "btn_addToRecipe";
            this.btn_addToRecipe.Size = new System.Drawing.Size(105, 23);
            this.btn_addToRecipe.TabIndex = 3;
            this.btn_addToRecipe.Text = "Thêm -->";
            this.btn_addToRecipe.UseVisualStyleBackColor = true;
            this.btn_addToRecipe.Click += new System.EventHandler(this.btn_addToRecipe_Click);
            // 
            // btn_removeFromRecipe
            // 
            this.btn_removeFromRecipe.Location = new System.Drawing.Point(584, 225);
            this.btn_removeFromRecipe.Name = "btn_removeFromRecipe";
            this.btn_removeFromRecipe.Size = new System.Drawing.Size(105, 23);
            this.btn_removeFromRecipe.TabIndex = 4;
            this.btn_removeFromRecipe.Text = "<-- Xóa";
            this.btn_removeFromRecipe.UseVisualStyleBackColor = true;
            this.btn_removeFromRecipe.Click += new System.EventHandler(this.btn_removeFromRecipe_Click);
            // 
            // pic_materialPhoto
            // 
            this.pic_materialPhoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pic_materialPhoto.Location = new System.Drawing.Point(962, 14);
            this.pic_materialPhoto.Name = "pic_materialPhoto";
            this.pic_materialPhoto.Size = new System.Drawing.Size(209, 167);
            this.pic_materialPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_materialPhoto.TabIndex = 75;
            this.pic_materialPhoto.TabStop = false;
            // 
            // nud_value
            // 
            this.nud_value.Location = new System.Drawing.Point(665, 89);
            this.nud_value.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_value.Name = "nud_value";
            this.nud_value.Size = new System.Drawing.Size(182, 22);
            this.nud_value.TabIndex = 76;
            // 
            // Materials_ID
            // 
            this.Materials_ID.DataPropertyName = "Materials_ID";
            this.Materials_ID.HeaderText = "Mã nguyên liệu";
            this.Materials_ID.MinimumWidth = 6;
            this.Materials_ID.Name = "Materials_ID";
            // 
            // Materials_Name
            // 
            this.Materials_Name.DataPropertyName = "Materials_Name";
            this.Materials_Name.HeaderText = "Tên nguyên liệu";
            this.Materials_Name.MinimumWidth = 6;
            this.Materials_Name.Name = "Materials_Name";
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Đơn vị tính";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            // 
            // RecipeInfoID
            // 
            this.RecipeInfoID.DataPropertyName = "RecipeInfoID";
            this.RecipeInfoID.HeaderText = "Mã nhận dạng";
            this.RecipeInfoID.MinimumWidth = 6;
            this.RecipeInfoID.Name = "RecipeInfoID";
            // 
            // Materials_Nam
            // 
            this.Materials_Nam.DataPropertyName = "Materials_Name";
            this.Materials_Nam.HeaderText = "Tên nguyên liệu";
            this.Materials_Nam.MinimumWidth = 6;
            this.Materials_Nam.Name = "Materials_Nam";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel1);
            this.Name = "AddRecipe";
            this.Text = "AddRecipe";
            this.Load += new System.EventHandler(this.AddRecipe_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_material)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_recipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_materialPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_value)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgv_material;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_removeFromRecipe;
        private System.Windows.Forms.Button btn_addToRecipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgv_recipe;
        private System.Windows.Forms.TextBox txt_materialUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_materialName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_materialID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_pdName;
        private System.Windows.Forms.PictureBox pic_materialPhoto;
        private System.Windows.Forms.NumericUpDown nud_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materials_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materials_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipeInfoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materials_Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}