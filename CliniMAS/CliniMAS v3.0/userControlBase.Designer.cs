namespace CliniMAS_v3._0
{
    partial class userControlBase
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userControlBase));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.back = new System.Windows.Forms.Button();
            this.action1 = new System.Windows.Forms.Button();
            this.action2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userActionsToolStripMenuItem,
            this.requestActionsToolStripMenuItem,
            this.messagesToolStripMenuItem,
            this.accountActionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userActionsToolStripMenuItem
            // 
            this.userActionsToolStripMenuItem.Name = "userActionsToolStripMenuItem";
            this.userActionsToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.userActionsToolStripMenuItem.Text = "User Actions";
            // 
            // requestActionsToolStripMenuItem
            // 
            this.requestActionsToolStripMenuItem.Name = "requestActionsToolStripMenuItem";
            this.requestActionsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.requestActionsToolStripMenuItem.Text = "Requests";
            // 
            // messagesToolStripMenuItem
            // 
            this.messagesToolStripMenuItem.Name = "messagesToolStripMenuItem";
            this.messagesToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.messagesToolStripMenuItem.Text = "Messaging";
            // 
            // accountActionsToolStripMenuItem
            // 
            this.accountActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountSettingsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountActionsToolStripMenuItem.Name = "accountActionsToolStripMenuItem";
            this.accountActionsToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.accountActionsToolStripMenuItem.Text = "Account Actions";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(23, 465);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(103, 40);
            this.back.TabIndex = 2;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            // 
            // action1
            // 
            this.action1.Location = new System.Drawing.Point(632, 455);
            this.action1.Name = "action1";
            this.action1.Size = new System.Drawing.Size(75, 23);
            this.action1.TabIndex = 3;
            this.action1.Text = "Action1";
            this.action1.UseVisualStyleBackColor = true;
            // 
            // action2
            // 
            this.action2.Location = new System.Drawing.Point(780, 465);
            this.action2.Name = "action2";
            this.action2.Size = new System.Drawing.Size(75, 23);
            this.action2.TabIndex = 4;
            this.action2.Text = "Action2";
            this.action2.UseVisualStyleBackColor = true;
            // 
            // userControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.action2);
            this.Controls.Add(this.action1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.menuStrip1);
            this.Name = "userControlBase";
            this.Size = new System.Drawing.Size(893, 521);
            this.Load += new System.EventHandler(this.userControlBase_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button action1;
        private System.Windows.Forms.Button action2;
    }
}
