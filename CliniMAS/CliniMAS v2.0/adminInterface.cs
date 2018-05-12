using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CliniMAS_v2._0
{
    public partial class adminInterface : Form
    {
        SScreen login;
        //Lists of items
        TextBox FnameT, LnameT, MnameT, AddressT, SSNT, UNT, PWT, PhoneNumberT, SalaryT
            , QualificationsT, EmailT;
        List<TextBox> Tlist;

        DateTimePicker BDateT, SDateT, EDateT;

        List<DateTimePicker> Dlist;

        ComboBox GenderT, PositionT;

        List<ComboBox> Clist;

        Label Fnamel, Lnamel, Mnamel, Addressl, SSNl, UNl, PWl, PhoneNumberl, Salaryl
            , Qualificationsl, BDatel, SDatel, EDatel, Genderl, Positionl, Emaill;

        List<Label> Llist;

        List<Button> Blist;

        public adminInterface()
        {
            InitializeComponent();

            //Form Size properties
            this.FindForm().FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Size = new Size(680, 420);

            //List initialization
            Tlist = new List<TextBox>();
            Dlist = new List<DateTimePicker>();
            Clist = new List<ComboBox>();
            Llist = new List<Label>();
            Blist = new List<Button>();

            //List filling
            {
                Tlist.Add(FnameT);
                Tlist.Add(MnameT);
                Tlist.Add(LnameT);
                Tlist.Add(AddressT);
                Tlist.Add(SSNT);
                Tlist.Add(UNT);
                Tlist.Add(PWT);
                Tlist.Add(PhoneNumberT);
                Tlist.Add(SalaryT);
                Tlist.Add(QualificationsT);
                Tlist.Add(EmailT);
                Dlist.Add(BDateT);
                Dlist.Add(SDateT);
                Dlist.Add(EDateT);
                Clist.Add(GenderT);
                Clist.Add(PositionT);
                Llist.Add(Fnamel);
                Llist.Add(Mnamel);
                Llist.Add(Lnamel);
                Llist.Add(Addressl);
                Llist.Add(SSNl);
                Llist.Add(UNl);
                Llist.Add(PWl);
                Llist.Add(PhoneNumberl);
                Llist.Add(Salaryl);
                Llist.Add(Qualificationsl);
                Llist.Add(BDatel);
                Llist.Add(SDatel);
                Llist.Add(EDatel);
                Llist.Add(Genderl);
                Llist.Add(Positionl);
                Llist.Add(Emaill);
                Blist.Add(back);
                Blist.Add(action1);
                Blist.Add(action2);
            }

            //Adding components to form in sequence
            {
                this.Controls.Add(FnameT);
                this.Controls.Add(MnameT);
                this.Controls.Add(LnameT);
                this.Controls.Add(GenderT);
                this.Controls.Add(BDateT);
                this.Controls.Add(SSNT);
                this.Controls.Add(PhoneNumberT);
                this.Controls.Add(AddressT);
                this.Controls.Add(QualificationsT);
                this.Controls.Add(PositionT);
                this.Controls.Add(SalaryT);
                this.Controls.Add(SDateT);
                this.Controls.Add(EDateT);
                this.Controls.Add(EmailT);
                this.Controls.Add(UNT);
                this.Controls.Add(PWT);
            }

            //Adding labels and hiding Components in form initially
            {
                //Textboxes
                for (int i = 0; i < Tlist.Count; i++)
                {
                    //this.Controls.Add(Tlist[i]);
                    Tlist[i].Hide();
                }
                //Datepickers
                for (int i = 0; i < Dlist.Count; i++)
                {
                    //this.Controls.Add(Dlist[i]);
                    Dlist[i].Hide();
                }
                //Comboboxes
                for (int i = 0; i < Clist.Count; i++)
                {
                    //this.Controls.Add(Clist[i]);
                    Clist[i].Hide();
                }
                //Labels
                for (int i = 0; i < Llist.Count; i++)
                {
                    this.Controls.Add(Llist[i]);
                    Llist[i].Hide();
                }
                for (int i = 0; i < Blist.Count; i++)
                {
                    Blist[i].Hide();
                }
                viewInterface.Hide();
                messageBox.Hide();
            }

            //Component info //add sending to
            {
                //Comboboxes
                GenderT.Items.AddRange(new object[] { "Male", "Female" });
                PositionT.Items.AddRange(new object[] { "Doctor", "Nurse", "Receptionist",
                    "Worker", "Intern"});
                //Sendtoc.Items.AddRange(new object[] { "Doctors", "Nurses", "Receptionists",
                  //  "Everyone"});

                //Labels
                Fnamel.Text = "First name";
                Mnamel.Text = "Middle name";
                Lnamel.Text = "Last name";
                Addressl.Text = "Address";
                SSNl.Text = "SSN";
                UNl.Text = "Username";
                PWl.Text = "Password";
                PhoneNumberl.Text = "Phone number";
                Salaryl.Text = "Salary";
                Qualificationsl.Text = "Qualifications";
                BDatel.Text = "Bithdate";
                SDatel.Text = "Start date";
                EDatel.Text = "End date";
                Genderl.Text = "Gender";
                Positionl.Text = "Position";
                Emaill.Text = "Email";
            }

            //Specific Component properties
            {
                AddressT.WordWrap = true;
                AddressT.Multiline = true;
                AddressT.Size = new Size(160, 35);

                QualificationsT.WordWrap = true;
                QualificationsT.Multiline = true;
                QualificationsT.Size = new Size(150, 35);

                PWT.UseSystemPasswordChar = true;
                
                for (int i = 0; i < Llist.Count; i++)
                {
                    Llist[i].BackColor = System.Drawing.Color.Transparent;
                }
            }
        }

        private void adminInterface_Load(object sender, EventArgs e)
        {
            //Component specific properties
            {
                //Buttons
                this.back.Size = new Size(80, 36);
                this.back.Font = new Font("Microsoft Sans Serif",
                               9,
                               FontStyle.Regular);
                this.back.Location = new Point(9, 330);

                this.action1.Size = new Size(106, 36);
                this.action1.Font = new Font("Microsoft Sans Serif",
                               9,
                               FontStyle.Regular);
                this.action1.Location = new Point(430, 330);

                this.action2.Size = new Size(106, 36);
                this.action2.Font = new Font("Microsoft Sans Serif",
                               9,
                               FontStyle.Regular);
                this.action2.Location = new Point(545, 330);

                //Textboxes
                this.FnameT.Location = new Point(40, 40);
                this.MnameT.Location = new Point(200, 40);
                this.LnameT.Location = new Point(360, 40);
                this.AddressT.Location = new Point(200, 135);
                this.PhoneNumberT.Location = new Point(40, 135);
                this.SSNT.Location = new Point(450, 85);
                this.UNT.Location = new Point(200, 300);
                this.PWT.Location = new Point(360, 300);
                this.SalaryT.Location = new Point(200, 200);
                this.QualificationsT.Location = new Point(420, 135);
                this.EmailT.Location = new Point(40, 300);

                ////Datepickers
                this.BDateT.Location = new Point(200, 85);
                this.SDateT.Location = new Point(40, 250);
                this.EDateT.Location = new Point(260, 250);

                ////Comboboxes
                this.GenderT.Location = new Point(40, 85);
                this.PositionT.Location = new Point(40, 200);

                ////Labels
                this.Fnamel.Location = new Point(40, 25);
                this.Mnamel.Location = new Point(200, 25);
                this.Lnamel.Location = new Point(360, 25);
                this.Addressl.Location = new Point(200, 120);
                this.PhoneNumberl.Location = new Point(40, 120);
                this.SSNl.Location = new Point(450, 70);
                this.UNl.Location = new Point(200, 285);
                this.PWl.Location = new Point(360, 285);
                this.Salaryl.Location = new Point(200, 185);
                this.Qualificationsl.Location = new Point(420, 120);
                this.BDatel.Location = new Point(200, 70);
                this.SDatel.Location = new Point(40, 235);
                this.EDatel.Location = new Point(260, 235);
                this.Genderl.Location = new Point(40, 70);
                this.Positionl.Location = new Point(40, 185);
                this.Emaill.Location = new Point(40, 285);
            }

        }

        private void adminInterface_Resize(object sender, EventArgs e)
        {
            //Component Initialiazation
            {
                FnameT = new TextBox();
                LnameT = new TextBox();
                MnameT = new TextBox();
                AddressT = new TextBox();
                PWT = new TextBox();
                UNT = new TextBox();
                SSNT = new TextBox();
                PhoneNumberT = new TextBox();
                SalaryT = new TextBox();
                QualificationsT = new TextBox();
                EmailT = new TextBox();
                BDateT = new DateTimePicker();
                SDateT = new DateTimePicker();
                EDateT = new DateTimePicker();
                GenderT = new ComboBox();
                PositionT = new ComboBox();
                Fnamel = new Label();
                Lnamel = new Label();
                Mnamel = new Label();
                Addressl = new Label();
                PWl = new Label();
                UNl = new Label();
                SSNl = new Label();
                PhoneNumberl = new Label();
                Salaryl = new Label();
                Qualificationsl = new Label();
                BDatel = new Label();
                SDatel = new Label();
                EDatel = new Label();
                Genderl = new Label();
                Positionl = new Label();
                Emaill = new Label();
            }

            this.back.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.action1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.action2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.hideAll();
            this.showAddUserItems();
            this.action1.Text = "Reset";
            this.action2.Text = "Add User";
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.hideAll();
            this.showViewingInterface();
            action1.Text = "Save Edits";
            action2.Text = "Remove User";
        }

        private void viewRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.hideAll();
            this.showViewingInterface();
            action1.Text = "Accept Request";
            action2.Text = "Decline Request";
        }

        private void acceptedRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.hideAll();
            this.viewInterface.Show();
            this.back.Show();
        }

        private void declinedRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.hideAll();
            this.viewInterface.Show();
            this.back.Show();
        }

        private void sendToAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.hideAll();
            //Buttons
            for (int i = 0; i < Blist.Count; i++)
            {
                Blist[i].Show();
            }
            messageBox.Show();
            action1.Text = "Reset";
            action2.Text = "Send Message";
        }

        private void sendToDoctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.hideAll();
            //Buttons
            for (int i = 0; i < Blist.Count; i++)
            {
                Blist[i].Show();
            }
            messageBox.Show();
            action1.Text = "Reset";
            action2.Text = "Send Message";
        }

        private void editAccountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.hideAll();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.hideAll();
            login = new SScreen();
            this.Close();
            login.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.hideAll();
        }

        private void adminInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void showAddUserItems()
        {
            //Textboxes
            for (int i = 0; i < Tlist.Count; i++)
            {
                Tlist[i].Show();
            }
            //Datepickers
            for (int i = 0; i < Dlist.Count; i++)
            {
                Dlist[i].Show();
            }
            //Comboboxes
            for (int i = 0; i < Clist.Count; i++)
            {
                Clist[i].Show();
            }
            //Labels
            for (int i = 0; i < Llist.Count; i++)
            {
                Llist[i].Show();
            }
            //Buttons
            for (int i = 0; i < Blist.Count; i++)
            {
                Blist[i].Show();
            }
        }

        private void showViewingInterface()
        {
            //Buttons
            for (int i = 0; i < Blist.Count; i++)
            {
                Blist[i].Show();
            }
            viewInterface.Show();
        }

        private void hideAll()
        {
            //Textboxes
            for (int i = 0; i < Tlist.Count; i++)
            {
                Tlist[i].Hide();
                Tlist[i].ResetText();
            }
            //Datepickers
            for (int i = 0; i < Dlist.Count; i++)
            {
                Dlist[i].Hide();
                Dlist[i].ResetText();
            }
            //Comboboxes
            for (int i = 0; i < Clist.Count; i++)
            {
                Clist[i].Hide();
                Clist[i].ResetText();
            }
            //Labels
            for (int i = 0; i < Llist.Count; i++)
            {
                Llist[i].Hide();
            }
            //buttons
            for (int i = 0; i < Blist.Count; i++)
            {
                Blist[i].Hide();
            }
            action1.ResetText();
            action2.ResetText();
            viewInterface.Hide();
            viewInterface.DataSource = null;
            viewInterface.Rows.Clear();
            messageBox.Hide();
            messageBox.ResetText();

        }
    }
}
