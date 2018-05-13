namespace CliniMAS_v2._0
{
    partial class nurseInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nurseInterface));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMedicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestVacationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToDoctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendingTo = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.viewInterface = new System.Windows.Forms.DataGridView();
            this.action2 = new System.Windows.Forms.Button();
            this.action1 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewInterface)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userActionsToolStripMenuItem,
            this.requestsToolStripMenuItem,
            this.messagingToolStripMenuItem,
            this.accountActionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userActionsToolStripMenuItem
            // 
            this.userActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPatientsToolStripMenuItem,
            this.updateMedicationsToolStripMenuItem});
            this.userActionsToolStripMenuItem.Name = "userActionsToolStripMenuItem";
            this.userActionsToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.userActionsToolStripMenuItem.Text = "User Actions";
            // 
            // viewPatientsToolStripMenuItem
            // 
            this.viewPatientsToolStripMenuItem.Name = "viewPatientsToolStripMenuItem";
            this.viewPatientsToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.viewPatientsToolStripMenuItem.Text = "View Patients";
            this.viewPatientsToolStripMenuItem.Click += new System.EventHandler(this.viewPatientsToolStripMenuItem_Click);
            // 
            // updateMedicationsToolStripMenuItem
            // 
            this.updateMedicationsToolStripMenuItem.Name = "updateMedicationsToolStripMenuItem";
            this.updateMedicationsToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.updateMedicationsToolStripMenuItem.Text = "Update Medications";
            this.updateMedicationsToolStripMenuItem.Click += new System.EventHandler(this.updateMedicationsToolStripMenuItem_Click);
            // 
            // requestsToolStripMenuItem
            // 
            this.requestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestMedicineToolStripMenuItem,
            this.requestVacationToolStripMenuItem});
            this.requestsToolStripMenuItem.Name = "requestsToolStripMenuItem";
            this.requestsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.requestsToolStripMenuItem.Text = "Requests";
            // 
            // requestMedicineToolStripMenuItem
            // 
            this.requestMedicineToolStripMenuItem.Name = "requestMedicineToolStripMenuItem";
            this.requestMedicineToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.requestMedicineToolStripMenuItem.Text = "Request Medicine";
            this.requestMedicineToolStripMenuItem.Click += new System.EventHandler(this.requestMedicineToolStripMenuItem_Click);
            // 
            // requestVacationToolStripMenuItem
            // 
            this.requestVacationToolStripMenuItem.Name = "requestVacationToolStripMenuItem";
            this.requestVacationToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.requestVacationToolStripMenuItem.Text = "Request Vacation";
            this.requestVacationToolStripMenuItem.Click += new System.EventHandler(this.requestVacationToolStripMenuItem_Click);
            // 
            // messagingToolStripMenuItem
            // 
            this.messagingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToAllToolStripMenuItem,
            this.sendToDoctorsToolStripMenuItem});
            this.messagingToolStripMenuItem.Name = "messagingToolStripMenuItem";
            this.messagingToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.messagingToolStripMenuItem.Text = "Messaging";
            // 
            // sendToAllToolStripMenuItem
            // 
            this.sendToAllToolStripMenuItem.Name = "sendToAllToolStripMenuItem";
            this.sendToAllToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.sendToAllToolStripMenuItem.Text = "Send to All";
            this.sendToAllToolStripMenuItem.Click += new System.EventHandler(this.sendToAllToolStripMenuItem_Click);
            // 
            // sendToDoctorsToolStripMenuItem
            // 
            this.sendToDoctorsToolStripMenuItem.Name = "sendToDoctorsToolStripMenuItem";
            this.sendToDoctorsToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.sendToDoctorsToolStripMenuItem.Text = "Send to Doctors";
            this.sendToDoctorsToolStripMenuItem.Click += new System.EventHandler(this.sendToDoctorsToolStripMenuItem_Click);
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
            // sendingTo
            // 
            this.sendingTo.AutoSize = true;
            this.sendingTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sendingTo.Location = new System.Drawing.Point(12, 45);
            this.sendingTo.Name = "sendingTo";
            this.sendingTo.Size = new System.Drawing.Size(88, 20);
            this.sendingTo.TabIndex = 16;
            this.sendingTo.Text = "Sending to";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(12, 76);
            this.messageBox.MaxLength = 1000;
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageBox.Size = new System.Drawing.Size(856, 312);
            this.messageBox.TabIndex = 15;
            // 
            // viewInterface
            // 
            this.viewInterface.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewInterface.Location = new System.Drawing.Point(12, 45);
            this.viewInterface.Name = "viewInterface";
            this.viewInterface.RowTemplate.Height = 24;
            this.viewInterface.Size = new System.Drawing.Size(856, 343);
            this.viewInterface.TabIndex = 14;
            // 
            // action2
            // 
            this.action2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.action2.Location = new System.Drawing.Point(642, 394);
            this.action2.Name = "action2";
            this.action2.Size = new System.Drawing.Size(113, 44);
            this.action2.TabIndex = 13;
            this.action2.Text = "Action2";
            this.action2.UseVisualStyleBackColor = true;
            // 
            // action1
            // 
            this.action1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.action1.Location = new System.Drawing.Point(508, 394);
            this.action1.Name = "action1";
            this.action1.Size = new System.Drawing.Size(113, 44);
            this.action1.TabIndex = 12;
            this.action1.Text = "Action1";
            this.action1.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(12, 394);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(113, 44);
            this.back.TabIndex = 11;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            // 
            // nurseInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 533);
            this.Controls.Add(this.sendingTo);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.viewInterface);
            this.Controls.Add(this.action2);
            this.Controls.Add(this.action1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "nurseInterface";
            this.Text = "nurseInterface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.nurseInterface_FormClosing);
            this.Load += new System.EventHandler(this.nurseInterface_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewInterface)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMedicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestMedicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestVacationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messagingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToDoctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label sendingTo;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.DataGridView viewInterface;
        private System.Windows.Forms.Button action2;
        private System.Windows.Forms.Button action1;
        private System.Windows.Forms.Button back;
    }
}