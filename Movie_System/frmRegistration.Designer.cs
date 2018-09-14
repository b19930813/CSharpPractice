namespace Movie_System
{
    partial class frmRegistration
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
            this.Username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.PasswordConfirm = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.usermag = new System.Windows.Forms.Label();
            this.passmsg = new System.Windows.Forms.Label();
            this.passmsg1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(48, 29);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(53, 12);
            this.Username.TabIndex = 0;
            this.Username.Text = "ユーザー";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "パスワード";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "パスワード確認";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(103, 26);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(203, 22);
            this.txtuser.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(103, 88);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(203, 22);
            this.Password.TabIndex = 4;
            // 
            // PasswordConfirm
            // 
            this.PasswordConfirm.Location = new System.Drawing.Point(103, 145);
            this.PasswordConfirm.Name = "PasswordConfirm";
            this.PasswordConfirm.PasswordChar = '*';
            this.PasswordConfirm.Size = new System.Drawing.Size(203, 22);
            this.PasswordConfirm.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(60, 229);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "登録";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "前のインターフェース";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // usermag
            // 
            this.usermag.AutoSize = true;
            this.usermag.Location = new System.Drawing.Point(345, 36);
            this.usermag.Name = "usermag";
            this.usermag.Size = new System.Drawing.Size(0, 12);
            this.usermag.TabIndex = 8;
            // 
            // passmsg
            // 
            this.passmsg.AutoSize = true;
            this.passmsg.Location = new System.Drawing.Point(345, 97);
            this.passmsg.Name = "passmsg";
            this.passmsg.Size = new System.Drawing.Size(0, 12);
            this.passmsg.TabIndex = 9;
            // 
            // passmsg1
            // 
            this.passmsg1.AutoSize = true;
            this.passmsg1.Location = new System.Drawing.Point(345, 155);
            this.passmsg1.Name = "passmsg1";
            this.passmsg1.Size = new System.Drawing.Size(0, 12);
            this.passmsg1.TabIndex = 10;
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 317);
            this.Controls.Add(this.passmsg1);
            this.Controls.Add(this.passmsg);
            this.Controls.Add(this.usermag);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.PasswordConfirm);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.Name = "frmRegistration";
            this.Text = "frmRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox PasswordConfirm;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label usermag;
        private System.Windows.Forms.Label passmsg;
        private System.Windows.Forms.Label passmsg1;
    }
}