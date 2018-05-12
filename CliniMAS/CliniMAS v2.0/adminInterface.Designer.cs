namespace CliniMAS_v2._0
{
    partial class adminInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminInterface));
            this.back = new System.Windows.Forms.Button();
            this.action1 = new System.Windows.Forms.Button();
            this.action2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.announcementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToDoctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requetActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acceptedRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.declinedRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInterface = new System.Windows.Forms.DataGridView();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewInterface)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(12, 391);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(113, 44);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // action1
            // 
            this.action1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.action1.Location = new System.Drawing.Point(508, 391);
            this.action1.Name = "action1";
            this.action1.Size = new System.Drawing.Size(113, 44);
            this.action1.TabIndex = 5;
            this.action1.Text = "Action1";
            this.action1.UseVisualStyleBackColor = true;
            // 
            // action2
            // 
            this.action2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.action2.Location = new System.Drawing.Point(642, 391);
            this.action2.Name = "action2";
            this.action2.Size = new System.Drawing.Size(113, 44);
            this.action2.TabIndex = 6;
            this.action2.Text = "Action2";
            this.action2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userActionsToolStripMenuItem,
            this.requetActionsToolStripMenuItem,
            this.announcementsToolStripMenuItem,
            this.accountActionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userActionsToolStripMenuItem
            // 
            this.userActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.viewUsersToolStripMenuItem});
            this.userActionsToolStripMenuItem.Name = "userActionsToolStripMenuItem";
            this.userActionsToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.userActionsToolStripMenuItem.Text = "User Actions";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // viewUsersToolStripMenuItem
            // 
            this.viewUsersToolStripMenuItem.Name = "viewUsersToolStripMenuItem";
            this.viewUsersToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.viewUsersToolStripMenuItem.Text = "View Users";
            this.viewUsersToolStripMenuItem.Click += new System.EventHandler(this.viewUsersToolStripMenuItem_Click);
            // 
            // announcementsToolStripMenuItem
            // 
            this.announcementsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToAllToolStripMenuItem,
            this.sendToDoctorsToolStripMenuItem});
            this.announcementsToolStripMenuItem.Name = "announcementsToolStripMenuItem";
            this.announcementsToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.announcementsToolStripMenuItem.Text = "Messaging";
            // 
            // sendToAllToolStripMenuItem
            // 
            this.sendToAllToolStripMenuItem.Name = "sendToAllToolStripMenuItem";
            this.sendToAllToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.sendToAllToolStripMenuItem.Text = "Send to all";
            this.sendToAllToolStripMenuItem.Click += new System.EventHandler(this.sendToAllToolStripMenuItem_Click);
            // 
            // sendToDoctorsToolStripMenuItem
            // 
            this.sendToDoctorsToolStripMenuItem.Name = "sendToDoctorsToolStripMenuItem";
            this.sendToDoctorsToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.sendToDoctorsToolStripMenuItem.Text = "Send to Doctors";
            this.sendToDoctorsToolStripMenuItem.Click += new System.EventHandler(this.sendToDoctorsToolStripMenuItem_Click);
            // 
            // requetActionsToolStripMenuItem
            // 
            this.requetActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewRequestsToolStripMenuItem,
            this.acceptedRequestsToolStripMenuItem,
            this.declinedRequestsToolStripMenuItem});
            this.requetActionsToolStripMenuItem.Name = "requetActionsToolStripMenuItem";
            this.requetActionsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.requetActionsToolStripMenuItem.Text = "Requests";
            // 
            // viewRequestsToolStripMenuItem
            // 
            this.viewRequestsToolStripMenuItem.Name = "viewRequestsToolStripMenuItem";
            this.viewRequestsToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.viewRequestsToolStripMenuItem.Text = "View Requests";
            this.viewRequestsToolStripMenuItem.Click += new System.EventHandler(this.viewRequestsToolStripMenuItem_Click);
            // 
            // acceptedRequestsToolStripMenuItem
            // 
            this.acceptedRequestsToolStripMenuItem.Name = "acceptedRequestsToolStripMenuItem";
            this.acceptedRequestsToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.acceptedRequestsToolStripMenuItem.Text = "Accepted Requests";
            this.acceptedRequestsToolStripMenuItem.Click += new System.EventHandler(this.acceptedRequestsToolStripMenuItem_Click);
            // 
            // declinedRequestsToolStripMenuItem
            // 
            this.declinedRequestsToolStripMenuItem.Name = "declinedRequestsToolStripMenuItem";
            this.declinedRequestsToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.declinedRequestsToolStripMenuItem.Text = "Declined Requests";
            this.declinedRequestsToolStripMenuItem.Click += new System.EventHandler(this.declinedRequestsToolStripMenuItem_Click);
            // 
            // accountActionsToolStripMenuItem
            // 
            this.accountActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAccountSettingsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountActionsToolStripMenuItem.Name = "accountActionsToolStripMenuItem";
            this.accountActionsToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.accountActionsToolStripMenuItem.Text = "Account Actions";
            // 
            // editAccountSettingsToolStripMenuItem
            // 
            this.editAccountSettingsToolStripMenuItem.Name = "editAccountSettingsToolStripMenuItem";
            this.editAccountSettingsToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.editAccountSettingsToolStripMenuItem.Text = "Edit Account Settings";
            this.editAccountSettingsToolStripMenuItem.Click += new System.EventHandler(this.editAccountSettingsToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // viewInterface
            // 
            this.viewInterface.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewInterface.Location = new System.Drawing.Point(12, 42);
            this.viewInterface.Name = "viewInterface";
            this.viewInterface.RowTemplate.Height = 24;
            this.viewInterface.Size = new System.Drawing.Size(856, 343);
            this.viewInterface.TabIndex = 8;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(12, 42);
            this.messageBox.MaxLength = 1000;
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageBox.Size = new System.Drawing.Size(856, 312);
            this.messageBox.TabIndex = 9;
            // 
            // adminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 447);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.viewInterface);
            this.Controls.Add(this.action2);
            this.Controls.Add(this.action1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "adminInterface";
            this.Text = "CliniMAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adminInterface_FormClosing);
            this.Load += new System.EventHandler(this.adminInterface_Load);
            this.Resize += new System.EventHandler(this.adminInterface_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewInterface)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button action1;
        private System.Windows.Forms.Button action2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requetActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem announcementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToDoctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acceptedRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem declinedRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.DataGridView viewInterface;
        private System.Windows.Forms.TextBox messageBox;
    }
}

