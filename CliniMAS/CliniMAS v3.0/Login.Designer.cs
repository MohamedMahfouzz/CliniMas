namespace CliniMAS_v3._0
{
    partial class SScreen
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
            this.Login = new System.Windows.Forms.Button();
            this.UN = new System.Windows.Forms.TextBox();
            this.PW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(97, 123);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(91, 28);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // UN
            // 
            this.UN.Location = new System.Drawing.Point(78, 58);
            this.UN.Name = "UN";
            this.UN.Size = new System.Drawing.Size(133, 22);
            this.UN.TabIndex = 1;
            this.UN.Click += new System.EventHandler(this.UN_Click_1);
            this.UN.Leave += new System.EventHandler(this.UN_Leave);
            // 
            // PW
            // 
            this.PW.Location = new System.Drawing.Point(78, 86);
            this.PW.Name = "PW";
            this.PW.Size = new System.Drawing.Size(133, 22);
            this.PW.TabIndex = 2;
            this.PW.Click += new System.EventHandler(this.PW_Click_1);
            this.PW.EnabledChanged += new System.EventHandler(this.PW_EnabledChanged);
            this.PW.TextChanged += new System.EventHandler(this.PW_TextChanged);
            this.PW.Enter += new System.EventHandler(this.PW_Enter);
            this.PW.Leave += new System.EventHandler(this.PW_Leave);
            // 
            // SScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 206);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.UN);
            this.Controls.Add(this.Login);
            this.Name = "SScreen";
            this.Text = "CliniMAS";
            this.Load += new System.EventHandler(this.SScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox UN;
        private System.Windows.Forms.TextBox PW;
    }
}

