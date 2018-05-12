using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CliniMAS_v3._0
{
    public partial class userControlBase : UserControl
    {
        public userControlBase()
        {
            InitializeComponent();

            //Form Settings
            this.FindForm().FormBorderStyle = FormBorderStyle.Fixed3D;
            //this.MaximizeBox = false;
            this.Size = new Size(700, 400);

            //Hide buttons
            this.back.Hide();
            this.action1.Hide();
            this.action2.Hide();

            //Button specific properties
            {
                this.back.Size = new Size(80, 36);
                this.back.Font = new Font("Microsoft Sans Serif",
                               9,
                               FontStyle.Regular);
                this.back.Location = new Point(9, 311);
                this.back.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);

                this.action1.Size = new Size(106, 36);
                this.action1.Font = new Font("Microsoft Sans Serif",
                               9,
                               FontStyle.Regular);
                this.action1.Location = new Point(450, 311);

                this.action2.Size = new Size(106, 36);
                this.action2.Font = new Font("Microsoft Sans Serif",
                               9,
                               FontStyle.Regular);
                this.action2.Location = new Point(565, 311);
            }
        }

        private void userControlBase_Load(object sender, EventArgs e)
        {

        }
    }
}
