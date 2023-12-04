namespace Login_Page_Design_UI
{
    partial class MyAccount
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
            this.btn_showPass = new System.Windows.Forms.Button();
            this.dtpk_dob = new System.Windows.Forms.DateTimePicker();
            this.cbo_gender = new System.Windows.Forms.ComboBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_refrest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_lastName);
            this.panel1.Controls.Add(this.btn_showPass);
            this.panel1.Controls.Add(this.dtpk_dob);
            this.panel1.Controls.Add(this.cbo_gender);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_firstName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_phone);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(59, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 250);
            this.panel1.TabIndex = 17;
            // 
            // btn_showPass
            // 
            this.btn_showPass.Location = new System.Drawing.Point(633, 72);
            this.btn_showPass.Name = "btn_showPass";
            this.btn_showPass.Size = new System.Drawing.Size(24, 23);
            this.btn_showPass.TabIndex = 18;
            this.btn_showPass.Text = "V";
            this.btn_showPass.UseVisualStyleBackColor = true;
            this.btn_showPass.Click += new System.EventHandler(this.btn_showPass_Click);
            // 
            // dtpk_dob
            // 
            this.dtpk_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_dob.Location = new System.Drawing.Point(504, 126);
            this.dtpk_dob.Name = "dtpk_dob";
            this.dtpk_dob.Size = new System.Drawing.Size(153, 22);
            this.dtpk_dob.TabIndex = 17;
            // 
            // cbo_gender
            // 
            this.cbo_gender.FormattingEnabled = true;
            this.cbo_gender.Location = new System.Drawing.Point(504, 175);
            this.cbo_gender.Name = "cbo_gender";
            this.cbo_gender.Size = new System.Drawing.Size(153, 24);
            this.cbo_gender.TabIndex = 16;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(504, 25);
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            this.txt_username.Size = new System.Drawing.Size(153, 22);
            this.txt_username.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Giới tính";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(99, 22);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.ReadOnly = true;
            this.txt_firstName.Size = new System.Drawing.Size(153, 22);
            this.txt_firstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày sinh";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(99, 125);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(153, 22);
            this.txt_email.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(504, 72);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(127, 22);
            this.txt_password.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số DT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mật khẩu";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(99, 181);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.ReadOnly = true;
            this.txt_phone.Size = new System.Drawing.Size(153, 22);
            this.txt_phone.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tên tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(99, 72);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.ReadOnly = true;
            this.txt_lastName.Size = new System.Drawing.Size(153, 22);
            this.txt_lastName.TabIndex = 20;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(169, 350);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(119, 33);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_refrest
            // 
            this.btn_refrest.Location = new System.Drawing.Point(516, 350);
            this.btn_refrest.Name = "btn_refrest";
            this.btn_refrest.Size = new System.Drawing.Size(119, 33);
            this.btn_refrest.TabIndex = 19;
            this.btn_refrest.Text = "Làm mới";
            this.btn_refrest.UseVisualStyleBackColor = true;
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 433);
            this.Controls.Add(this.btn_refrest);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.panel1);
            this.Name = "MyAccount";
            this.Text = "MyAccount";
            this.Load += new System.EventHandler(this.MyAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_showPass;
        private System.Windows.Forms.DateTimePicker dtpk_dob;
        private System.Windows.Forms.ComboBox cbo_gender;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_refrest;
    }
}