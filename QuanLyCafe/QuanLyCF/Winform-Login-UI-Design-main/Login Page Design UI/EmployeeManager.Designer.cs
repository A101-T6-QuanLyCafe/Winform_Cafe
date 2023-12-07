namespace Login_Page_Design_UI
{
    partial class EmployeeManager
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
            this.cb_isDelete = new System.Windows.Forms.CheckBox();
            this.cbo_searchBy = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.rtxt_lastName = new InputTextBoxLib.OnlyStringTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_active = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.rtxt_phone = new InputTextBoxLib.RequireValueTextBox();
            this.etxt_email = new InputTextBoxLib.EmailTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sntxt_password = new InputTextBoxLib.StringAndNumberTextBox();
            this.sntxt_username = new InputTextBoxLib.StringAndNumberTextBox();
            this.btn_showPass = new System.Windows.Forms.Button();
            this.dtpk_dob = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rtxt_firstName = new InputTextBoxLib.OnlyStringTextBox();
            this.ntxt_ma = new InputTextBoxLib.OnlyNumberTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_gender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_isDelete
            // 
            this.cb_isDelete.AutoSize = true;
            this.cb_isDelete.Location = new System.Drawing.Point(388, 20);
            this.cb_isDelete.Name = "cb_isDelete";
            this.cb_isDelete.Size = new System.Drawing.Size(70, 20);
            this.cb_isDelete.TabIndex = 7;
            this.cb_isDelete.Text = "đã xóa";
            this.cb_isDelete.UseVisualStyleBackColor = true;
            this.cb_isDelete.CheckedChanged += new System.EventHandler(this.cb_isDelete_CheckedChanged);
            // 
            // cbo_searchBy
            // 
            this.cbo_searchBy.FormattingEnabled = true;
            this.cbo_searchBy.Location = new System.Drawing.Point(533, 17);
            this.cbo_searchBy.Name = "cbo_searchBy";
            this.cbo_searchBy.Size = new System.Drawing.Size(142, 24);
            this.cbo_searchBy.TabIndex = 6;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(726, 19);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(207, 22);
            this.txt_search.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb_isDelete);
            this.panel2.Controls.Add(this.cbo_searchBy);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.txt_search);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 59);
            this.panel2.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(963, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // rtxt_lastName
            // 
            this.rtxt_lastName.Location = new System.Drawing.Point(111, 89);
            this.rtxt_lastName.Name = "rtxt_lastName";
            this.rtxt_lastName.Size = new System.Drawing.Size(203, 22);
            this.rtxt_lastName.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 75;
            this.label8.Text = "Tên";
            // 
            // btn_active
            // 
            this.btn_active.Location = new System.Drawing.Point(916, 225);
            this.btn_active.Name = "btn_active";
            this.btn_active.Size = new System.Drawing.Size(104, 30);
            this.btn_active.TabIndex = 74;
            this.btn_active.Text = "kích hoạt";
            this.btn_active.UseVisualStyleBackColor = true;
            this.btn_active.Click += new System.EventHandler(this.btn_active_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(18, 225);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(104, 30);
            this.btn_clear.TabIndex = 73;
            this.btn_clear.Text = "Làm mới";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(679, 225);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(104, 30);
            this.btn_remove.TabIndex = 72;
            this.btn_remove.Text = "Xóa";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(463, 225);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(104, 30);
            this.btn_edit.TabIndex = 71;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(210, 225);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(104, 30);
            this.btn_add.TabIndex = 70;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // rtxt_phone
            // 
            this.rtxt_phone.Location = new System.Drawing.Point(820, 89);
            this.rtxt_phone.Name = "rtxt_phone";
            this.rtxt_phone.Size = new System.Drawing.Size(203, 22);
            this.rtxt_phone.TabIndex = 69;
            // 
            // etxt_email
            // 
            this.etxt_email.Location = new System.Drawing.Point(820, 37);
            this.etxt_email.Name = "etxt_email";
            this.etxt_email.Size = new System.Drawing.Size(200, 22);
            this.etxt_email.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(750, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "Số DT";
            // 
            // sntxt_password
            // 
            this.sntxt_password.Location = new System.Drawing.Point(518, 87);
            this.sntxt_password.Name = "sntxt_password";
            this.sntxt_password.Size = new System.Drawing.Size(174, 22);
            this.sntxt_password.TabIndex = 63;
            // 
            // sntxt_username
            // 
            this.sntxt_username.Location = new System.Drawing.Point(488, 37);
            this.sntxt_username.Name = "sntxt_username";
            this.sntxt_username.Size = new System.Drawing.Size(204, 22);
            this.sntxt_username.TabIndex = 62;
            // 
            // btn_showPass
            // 
            this.btn_showPass.Location = new System.Drawing.Point(489, 85);
            this.btn_showPass.Name = "btn_showPass";
            this.btn_showPass.Size = new System.Drawing.Size(24, 23);
            this.btn_showPass.TabIndex = 61;
            this.btn_showPass.Text = "O";
            this.btn_showPass.UseVisualStyleBackColor = true;
            this.btn_showPass.Click += new System.EventHandler(this.btn_showPass_Click);
            // 
            // dtpk_dob
            // 
            this.dtpk_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_dob.Location = new System.Drawing.Point(489, 134);
            this.dtpk_dob.Name = "dtpk_dob";
            this.dtpk_dob.Size = new System.Drawing.Size(204, 22);
            this.dtpk_dob.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 59;
            this.label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 58;
            this.label7.Text = "Mật khẩu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(377, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 57;
            this.label9.Text = "Tên tài khoản";
            // 
            // rtxt_firstName
            // 
            this.rtxt_firstName.Location = new System.Drawing.Point(111, 37);
            this.rtxt_firstName.Name = "rtxt_firstName";
            this.rtxt_firstName.Size = new System.Drawing.Size(203, 22);
            this.rtxt_firstName.TabIndex = 56;
            // 
            // ntxt_ma
            // 
            this.ntxt_ma.Location = new System.Drawing.Point(111, 138);
            this.ntxt_ma.Name = "ntxt_ma";
            this.ntxt_ma.ReadOnly = true;
            this.ntxt_ma.Size = new System.Drawing.Size(203, 22);
            this.ntxt_ma.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Mã NV";
            // 
            // cbo_gender
            // 
            this.cbo_gender.FormattingEnabled = true;
            this.cbo_gender.Location = new System.Drawing.Point(820, 137);
            this.cbo_gender.Name = "cbo_gender";
            this.cbo_gender.Size = new System.Drawing.Size(203, 24);
            this.cbo_gender.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Họ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(750, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Giới tính";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.rtxt_lastName);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btn_active);
            this.panel3.Controls.Add(this.btn_clear);
            this.panel3.Controls.Add(this.btn_remove);
            this.panel3.Controls.Add(this.btn_edit);
            this.panel3.Controls.Add(this.btn_add);
            this.panel3.Controls.Add(this.rtxt_phone);
            this.panel3.Controls.Add(this.etxt_email);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.sntxt_password);
            this.panel3.Controls.Add(this.sntxt_username);
            this.panel3.Controls.Add(this.btn_showPass);
            this.panel3.Controls.Add(this.dtpk_dob);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.rtxt_firstName);
            this.panel3.Controls.Add(this.ntxt_ma);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbo_gender);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(3, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1056, 285);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empID,
            this.FName,
            this.LastName,
            this.EMAIL,
            this.PHONE,
            this.USERNAME,
            this.DOB,
            this.SEX});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 311);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // empID
            // 
            this.empID.DataPropertyName = "EmployeeID";
            this.empID.HeaderText = "Mã nhân viên";
            this.empID.MinimumWidth = 6;
            this.empID.Name = "empID";
            // 
            // FName
            // 
            this.FName.DataPropertyName = "FirstName";
            this.FName.HeaderText = "Họ";
            this.FName.MinimumWidth = 6;
            this.FName.Name = "FName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Tên";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            // 
            // PHONE
            // 
            this.PHONE.DataPropertyName = "PHONE";
            this.PHONE.HeaderText = "Điện thoại";
            this.PHONE.MinimumWidth = 6;
            this.PHONE.Name = "PHONE";
            // 
            // USERNAME
            // 
            this.USERNAME.DataPropertyName = "USERNAME";
            this.USERNAME.HeaderText = "Tên đăng nhập";
            this.USERNAME.MinimumWidth = 6;
            this.USERNAME.Name = "USERNAME";
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DOB";
            this.DOB.HeaderText = "Ngày sinh";
            this.DOB.MinimumWidth = 6;
            this.DOB.Name = "DOB";
            // 
            // SEX
            // 
            this.SEX.DataPropertyName = "SEX";
            this.SEX.HeaderText = "Giới tính";
            this.SEX.MinimumWidth = 6;
            this.SEX.Name = "SEX";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(0, 359);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1062, 311);
            this.panel4.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 673);
            this.panel1.TabIndex = 1;
            // 
            // EmployeeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeManager";
            this.Text = "EmployeeManager";
            this.Load += new System.EventHandler(this.EmployeeManager_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_isDelete;
        private System.Windows.Forms.ComboBox cbo_searchBy;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_search;
        private InputTextBoxLib.OnlyStringTextBox rtxt_lastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_active;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private InputTextBoxLib.RequireValueTextBox rtxt_phone;
        private InputTextBoxLib.EmailTextBox etxt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private InputTextBoxLib.StringAndNumberTextBox sntxt_password;
        private InputTextBoxLib.StringAndNumberTextBox sntxt_username;
        private System.Windows.Forms.Button btn_showPass;
        private System.Windows.Forms.DateTimePicker dtpk_dob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private InputTextBoxLib.OnlyStringTextBox rtxt_firstName;
        private InputTextBoxLib.OnlyNumberTextBox ntxt_ma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_gender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEX;
    }
}