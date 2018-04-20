namespace CliniMAS
{
    partial class AdminI
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
            this.AUser = new System.Windows.Forms.Button();
            this.VUser = new System.Windows.Forms.Button();
            this.EUser = new System.Windows.Forms.Button();
            this.RUser = new System.Windows.Forms.Button();
            this.VRequest = new System.Windows.Forms.Button();
            this.SNotice = new System.Windows.Forms.Button();
            this.SHControls = new System.Windows.Forms.Button();
            this.Action = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.ViewUsersRequests = new System.Windows.Forms.DataGridView();
            this.Sendtoc = new System.Windows.Forms.ComboBox();
            this.Sendtol = new System.Windows.Forms.Label();
            this.SendNotice = new System.Windows.Forms.Button();
            this.noticeInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ViewUsersRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // AUser
            // 
            this.AUser.Location = new System.Drawing.Point(85, 58);
            this.AUser.Name = "AUser";
            this.AUser.Size = new System.Drawing.Size(129, 44);
            this.AUser.TabIndex = 0;
            this.AUser.Text = "Add User";
            this.AUser.UseVisualStyleBackColor = true;
            this.AUser.Click += new System.EventHandler(this.AUser_Click);
            // 
            // VUser
            // 
            this.VUser.Location = new System.Drawing.Point(291, 58);
            this.VUser.Name = "VUser";
            this.VUser.Size = new System.Drawing.Size(129, 44);
            this.VUser.TabIndex = 1;
            this.VUser.Text = "View Users";
            this.VUser.UseVisualStyleBackColor = true;
            this.VUser.Click += new System.EventHandler(this.VUser_Click);
            // 
            // EUser
            // 
            this.EUser.Location = new System.Drawing.Point(85, 142);
            this.EUser.Name = "EUser";
            this.EUser.Size = new System.Drawing.Size(129, 44);
            this.EUser.TabIndex = 2;
            this.EUser.Text = "Edit User";
            this.EUser.UseVisualStyleBackColor = true;
            this.EUser.Click += new System.EventHandler(this.EUser_Click);
            // 
            // RUser
            // 
            this.RUser.Location = new System.Drawing.Point(291, 142);
            this.RUser.Name = "RUser";
            this.RUser.Size = new System.Drawing.Size(129, 44);
            this.RUser.TabIndex = 3;
            this.RUser.Text = "Remove User";
            this.RUser.UseVisualStyleBackColor = true;
            this.RUser.Click += new System.EventHandler(this.RUser_Click);
            // 
            // VRequest
            // 
            this.VRequest.Location = new System.Drawing.Point(85, 226);
            this.VRequest.Name = "VRequest";
            this.VRequest.Size = new System.Drawing.Size(129, 44);
            this.VRequest.TabIndex = 4;
            this.VRequest.Text = "View Requests";
            this.VRequest.UseVisualStyleBackColor = true;
            this.VRequest.Click += new System.EventHandler(this.VRequest_Click);
            // 
            // SNotice
            // 
            this.SNotice.Location = new System.Drawing.Point(291, 226);
            this.SNotice.Name = "SNotice";
            this.SNotice.Size = new System.Drawing.Size(129, 44);
            this.SNotice.TabIndex = 5;
            this.SNotice.Text = "Send Announcements";
            this.SNotice.UseVisualStyleBackColor = true;
            this.SNotice.Click += new System.EventHandler(this.SNotice_Click);
            // 
            // SHControls
            // 
            this.SHControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHControls.Location = new System.Drawing.Point(12, 321);
            this.SHControls.Name = "SHControls";
            this.SHControls.Size = new System.Drawing.Size(75, 31);
            this.SHControls.TabIndex = 6;
            this.SHControls.Text = "Log Out";
            this.SHControls.UseVisualStyleBackColor = true;
            this.SHControls.Click += new System.EventHandler(this.button7_Click);
            this.SHControls.MouseHover += new System.EventHandler(this.SHControls_MouseHover);
            // 
            // Action
            // 
            this.Action.Location = new System.Drawing.Point(324, 384);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(75, 23);
            this.Action.TabIndex = 7;
            this.Action.Text = "Action";
            this.Action.UseVisualStyleBackColor = true;
            this.Action.Click += new System.EventHandler(this.Action_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(449, 384);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 8;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ViewUsersRequests
            // 
            this.ViewUsersRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewUsersRequests.Location = new System.Drawing.Point(26, 27);
            this.ViewUsersRequests.Name = "ViewUsersRequests";
            this.ViewUsersRequests.RowTemplate.Height = 24;
            this.ViewUsersRequests.Size = new System.Drawing.Size(616, 418);
            this.ViewUsersRequests.TabIndex = 9;
            // 
            // Sendtoc
            // 
            this.Sendtoc.FormattingEnabled = true;
            this.Sendtoc.Location = new System.Drawing.Point(204, 27);
            this.Sendtoc.Name = "Sendtoc";
            this.Sendtoc.Size = new System.Drawing.Size(162, 24);
            this.Sendtoc.TabIndex = 10;
            // 
            // Sendtol
            // 
            this.Sendtol.AutoSize = true;
            this.Sendtol.Location = new System.Drawing.Point(96, 30);
            this.Sendtol.Name = "Sendtol";
            this.Sendtol.Size = new System.Drawing.Size(57, 17);
            this.Sendtol.TabIndex = 11;
            this.Sendtol.Text = "Send to";
            // 
            // SendNotice
            // 
            this.SendNotice.Location = new System.Drawing.Point(265, 475);
            this.SendNotice.Name = "SendNotice";
            this.SendNotice.Size = new System.Drawing.Size(129, 44);
            this.SendNotice.TabIndex = 12;
            this.SendNotice.Text = "Send Announcement";
            this.SendNotice.UseVisualStyleBackColor = true;
            // 
            // noticeInfo
            // 
            this.noticeInfo.AcceptsReturn = true;
            this.noticeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeInfo.Location = new System.Drawing.Point(37, 69);
            this.noticeInfo.MaxLength = 1000;
            this.noticeInfo.Multiline = true;
            this.noticeInfo.Name = "noticeInfo";
            this.noticeInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.noticeInfo.Size = new System.Drawing.Size(595, 375);
            this.noticeInfo.TabIndex = 13;
            // 
            // AdminI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 557);
            this.Controls.Add(this.SendNotice);
            this.Controls.Add(this.Sendtol);
            this.Controls.Add(this.Sendtoc);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.SHControls);
            this.Controls.Add(this.SNotice);
            this.Controls.Add(this.VRequest);
            this.Controls.Add(this.RUser);
            this.Controls.Add(this.AUser);
            this.Controls.Add(this.VUser);
            this.Controls.Add(this.EUser);
            this.Controls.Add(this.noticeInfo);
            this.Controls.Add(this.ViewUsersRequests);
            this.Name = "AdminI";
            this.Text = "CliniMas";
            this.Load += new System.EventHandler(this.AdminI_Load);
            this.SizeChanged += new System.EventHandler(this.AdminI_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ViewUsersRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AUser;
        private System.Windows.Forms.Button VUser;
        private System.Windows.Forms.Button EUser;
        private System.Windows.Forms.Button RUser;
        private System.Windows.Forms.Button VRequest;
        private System.Windows.Forms.Button SNotice;
        private System.Windows.Forms.Button SHControls;
        private System.Windows.Forms.Button Action;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.DataGridView ViewUsersRequests;
        private System.Windows.Forms.ComboBox Sendtoc;
        private System.Windows.Forms.Label Sendtol;
        private System.Windows.Forms.Button SendNotice;
        private System.Windows.Forms.TextBox noticeInfo;
    }
}