namespace CliniMAS_v2._0
{
    partial class receptionistInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(receptionistInterface));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestVacationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToDoctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToNursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(876, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userActionsToolStripMenuItem
            // 
            this.userActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPatientToolStripMenuItem,
            this.viewPatientsToolStripMenuItem,
            this.viewScheduleToolStripMenuItem,
            this.reserveAppointmentToolStripMenuItem});
            this.userActionsToolStripMenuItem.Name = "userActionsToolStripMenuItem";
            this.userActionsToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.userActionsToolStripMenuItem.Text = "User Actions";
            // 
            // addPatientToolStripMenuItem
            // 
            this.addPatientToolStripMenuItem.Name = "addPatientToolStripMenuItem";
            this.addPatientToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.addPatientToolStripMenuItem.Text = "Add Patient";
            this.addPatientToolStripMenuItem.Click += new System.EventHandler(this.addPatientToolStripMenuItem_Click);
            // 
            // viewPatientsToolStripMenuItem
            // 
            this.viewPatientsToolStripMenuItem.Name = "viewPatientsToolStripMenuItem";
            this.viewPatientsToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.viewPatientsToolStripMenuItem.Text = "View Patients";
            this.viewPatientsToolStripMenuItem.Click += new System.EventHandler(this.viewPatientsToolStripMenuItem_Click);
            // 
            // viewScheduleToolStripMenuItem
            // 
            this.viewScheduleToolStripMenuItem.Name = "viewScheduleToolStripMenuItem";
            this.viewScheduleToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.viewScheduleToolStripMenuItem.Text = "View Schedule";
            this.viewScheduleToolStripMenuItem.Click += new System.EventHandler(this.viewScheduleToolStripMenuItem_Click);
            // 
            // reserveAppointmentToolStripMenuItem
            // 
            this.reserveAppointmentToolStripMenuItem.Name = "reserveAppointmentToolStripMenuItem";
            this.reserveAppointmentToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.reserveAppointmentToolStripMenuItem.Text = "Reserve Appointment";
            this.reserveAppointmentToolStripMenuItem.Click += new System.EventHandler(this.reserveAppointmentToolStripMenuItem_Click);
            // 
            // requestsToolStripMenuItem
            // 
            this.requestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestVacationToolStripMenuItem});
            this.requestsToolStripMenuItem.Name = "requestsToolStripMenuItem";
            this.requestsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.requestsToolStripMenuItem.Text = "Requests";
            // 
            // requestVacationToolStripMenuItem
            // 
            this.requestVacationToolStripMenuItem.Name = "requestVacationToolStripMenuItem";
            this.requestVacationToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.requestVacationToolStripMenuItem.Text = "Request Vacation";
            this.requestVacationToolStripMenuItem.Click += new System.EventHandler(this.requestVacationToolStripMenuItem_Click);
            // 
            // messagingToolStripMenuItem
            // 
            this.messagingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToAllToolStripMenuItem,
            this.sendToDoctorsToolStripMenuItem,
            this.sendToNursesToolStripMenuItem});
            this.messagingToolStripMenuItem.Name = "messagingToolStripMenuItem";
            this.messagingToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.messagingToolStripMenuItem.Text = "Messaging";
            // 
            // sendToAllToolStripMenuItem
            // 
            this.sendToAllToolStripMenuItem.Name = "sendToAllToolStripMenuItem";
            this.sendToAllToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.sendToAllToolStripMenuItem.Text = "Send to All";
            this.sendToAllToolStripMenuItem.Click += new System.EventHandler(this.sendToAllToolStripMenuItem_Click_1);
            // 
            // sendToDoctorsToolStripMenuItem
            // 
            this.sendToDoctorsToolStripMenuItem.Name = "sendToDoctorsToolStripMenuItem";
            this.sendToDoctorsToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.sendToDoctorsToolStripMenuItem.Text = "Send to Doctors";
            this.sendToDoctorsToolStripMenuItem.Click += new System.EventHandler(this.sendToDoctorsToolStripMenuItem_Click_1);
            // 
            // sendToNursesToolStripMenuItem
            // 
            this.sendToNursesToolStripMenuItem.Name = "sendToNursesToolStripMenuItem";
            this.sendToNursesToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.sendToNursesToolStripMenuItem.Text = "Send to Nurses";
            this.sendToNursesToolStripMenuItem.Click += new System.EventHandler(this.sendToNursesToolStripMenuItem_Click);
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
            this.sendingTo.Location = new System.Drawing.Point(8, 38);
            this.sendingTo.Name = "sendingTo";
            this.sendingTo.Size = new System.Drawing.Size(88, 20);
            this.sendingTo.TabIndex = 23;
            this.sendingTo.Text = "Sending to";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(8, 69);
            this.messageBox.MaxLength = 1000;
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageBox.Size = new System.Drawing.Size(856, 312);
            this.messageBox.TabIndex = 22;
            // 
            // viewInterface
            // 
            this.viewInterface.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewInterface.Location = new System.Drawing.Point(8, 38);
            this.viewInterface.Name = "viewInterface";
            this.viewInterface.RowTemplate.Height = 24;
            this.viewInterface.Size = new System.Drawing.Size(856, 343);
            this.viewInterface.TabIndex = 21;
            // 
            // action2
            // 
            this.action2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.action2.Location = new System.Drawing.Point(638, 387);
            this.action2.Name = "action2";
            this.action2.Size = new System.Drawing.Size(113, 44);
            this.action2.TabIndex = 20;
            this.action2.Text = "Action2";
            this.action2.UseVisualStyleBackColor = true;
            // 
            // action1
            // 
            this.action1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.action1.Location = new System.Drawing.Point(504, 387);
            this.action1.Name = "action1";
            this.action1.Size = new System.Drawing.Size(113, 44);
            this.action1.TabIndex = 19;
            this.action1.Text = "Action1";
            this.action1.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(8, 387);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(113, 44);
            this.back.TabIndex = 18;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            // 
            // receptionistInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 451);
            this.Controls.Add(this.sendingTo);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.viewInterface);
            this.Controls.Add(this.action2);
            this.Controls.Add(this.action1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "receptionistInterface";
            this.Text = "CliniMAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.receptionistInterface_FormClosing);
            this.Load += new System.EventHandler(this.receptionistInterface_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewInterface)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label sendingTo;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.DataGridView viewInterface;
        private System.Windows.Forms.Button action2;
        private System.Windows.Forms.Button action1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ToolStripMenuItem userActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserveAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestVacationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messagingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToDoctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToNursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}