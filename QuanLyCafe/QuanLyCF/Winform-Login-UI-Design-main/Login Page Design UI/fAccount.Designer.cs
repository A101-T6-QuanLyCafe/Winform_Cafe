namespace Login_Page_Design_UI
{
    partial class fAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtF_Name = new System.Windows.Forms.TextBox();
            this.txtL_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Re_PW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // txtF_Name
            // 
            this.txtF_Name.Location = new System.Drawing.Point(90, 19);
            this.txtF_Name.Name = "txtF_Name";
            this.txtF_Name.Size = new System.Drawing.Size(246, 22);
            this.txtF_Name.TabIndex = 1;
            // 
            // txtL_Name
            // 
            this.txtL_Name.Location = new System.Drawing.Point(90, 59);
            this.txtL_Name.Name = "txtL_Name";
            this.txtL_Name.Size = new System.Drawing.Size(246, 22);
            this.txtL_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(90, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(90, 134);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(246, 22);
            this.txtPw.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // txt_Re_PW
            // 
            this.txt_Re_PW.Location = new System.Drawing.Point(90, 171);
            this.txt_Re_PW.Name = "txt_Re_PW";
            this.txt_Re_PW.Size = new System.Drawing.Size(246, 22);
            this.txt_Re_PW.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "re-enter PW";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(73, 215);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 40);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExits
            // 
            this.btnExits.Location = new System.Drawing.Point(217, 215);
            this.btnExits.Name = "btnExits";
            this.btnExits.Size = new System.Drawing.Size(75, 40);
            this.btnExits.TabIndex = 11;
            this.btnExits.Text = "Thoát";
            this.btnExits.UseVisualStyleBackColor = true;
            this.btnExits.Click += new System.EventHandler(this.btnExits_Click);
            // 
            // fAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 279);
            this.Controls.Add(this.btnExits);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txt_Re_PW);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtL_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtF_Name);
            this.Controls.Add(this.label1);
            this.Name = "fAccount";
            this.Text = "fAccount";
            this.Load += new System.EventHandler(this.fAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtF_Name;
        private System.Windows.Forms.TextBox txtL_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Re_PW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExits;
    }
}