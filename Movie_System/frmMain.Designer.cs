namespace Movie_System
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnManage = new System.Windows.Forms.ToolStripButton();
            this.btnRegistration = new System.Windows.Forms.ToolStripButton();
            this.btnPasswordChange = new System.Windows.Forms.ToolStripButton();
            this.btnLog = new System.Windows.Forms.ToolStripButton();
            this.btnRelogin = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnManage,
            this.btnRegistration,
            this.btnPasswordChange,
            this.btnLog,
            this.btnRelogin,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(702, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnManage
            // 
            this.btnManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnManage.Image = ((System.Drawing.Image)(resources.GetObject("btnManage.Image")));
            this.btnManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(59, 22);
            this.btnManage.Text = "映画管理";
            this.btnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRegistration.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistration.Image")));
            this.btnRegistration.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(83, 22);
            this.btnRegistration.Text = "ユーザー登録";
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnPasswordChange
            // 
            this.btnPasswordChange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPasswordChange.Image = ((System.Drawing.Image)(resources.GetObject("btnPasswordChange.Image")));
            this.btnPasswordChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPasswordChange.Name = "btnPasswordChange";
            this.btnPasswordChange.Size = new System.Drawing.Size(95, 22);
            this.btnPasswordChange.Text = "パスワード改正";
            this.btnPasswordChange.Click += new System.EventHandler(this.btnPasswordChange_Click);
            // 
            // btnLog
            // 
            this.btnLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLog.Image = ((System.Drawing.Image)(resources.GetObject("btnLog.Image")));
            this.btnLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(158, 22);
            this.btnLog.Text = "ログインとログアウト状態 ";
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnRelogin
            // 
            this.btnRelogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRelogin.Image = ((System.Drawing.Image)(resources.GetObject("btnRelogin.Image")));
            this.btnRelogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelogin.Name = "btnRelogin";
            this.btnRelogin.Size = new System.Drawing.Size(71, 22);
            this.btnRelogin.Text = "再ログイン";
            this.btnRelogin.Click += new System.EventHandler(this.btnRelogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 22);
            this.btnExit.Text = "システム退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(58, 312);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(33, 12);
            this.lblCurrentUser.TabIndex = 1;
            this.lblCurrentUser.Text = "label1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 374);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnManage;
        private System.Windows.Forms.ToolStripButton btnPasswordChange;
        private System.Windows.Forms.ToolStripButton btnRelogin;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnLog;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.ToolStripButton btnRegistration;
    }
}