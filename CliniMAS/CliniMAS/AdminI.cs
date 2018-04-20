using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CliniMAS
{
    public partial class AdminI : Form
    {
        bool ControlsFlag;
        SScreen login;

        TextBox FnameT, LnameT, MnameT, AddressT, SSNT, UNT, PWT, PhoneNumberT, SalaryT, QualificationsT;
        List<TextBox> Tlist;

        DateTimePicker BDateT, SDateT, EDateT;
        List<DateTimePicker> Dlist;

        ComboBox GenderT, PositionT;
        List<ComboBox> Clist;

        Label Fnamel, Lnamel, Mnamel, Addressl, SSNl, UNl, PWl, PhoneNumberl, Salaryl, Qualificationsl
            , BDatel, SDatel, EDatel, Genderl, Positionl;
        List<Label> Llist;

        List<Button> Blist;

        public AdminI()
        {
            InitializeComponent();

            this.Size = new Size(520, 470);
            //Flag to control visibility of buttons
            ControlsFlag = true;
            
            //Disable manual resize of form
            this.FindForm().FormBorderStyle = FormBorderStyle.Fixed3D;

            //lists of components to initialize
            Tlist = new List<TextBox>();
            Dlist = new List<DateTimePicker>();
            Clist = new List<ComboBox>();
            Llist = new List<Label>();
            Blist = new List<Button>();

            //Addition to lists
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
                Blist.Add(AUser);
                Blist.Add(VUser);
                Blist.Add(EUser);
                Blist.Add(RUser);
                Blist.Add(VRequest);
                Blist.Add(SNotice);
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
                this.Controls.Add(UNT);
                this.Controls.Add(PWT);
            }

            //Adding Components to form
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
            }

            //Component info
            {
                //Comboboxes
                GenderT.Items.AddRange(new object[] { "Male", "Female" });
                PositionT.Items.AddRange(new object[] { "Doctor", "Nurse", "Receptionist",
                    "Worker", "Intern"});
                Sendtoc.Items.AddRange(new object[] { "Doctors", "Nurses", "Receptionists",
                    "Everyone"});

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
            }

        }

        private void AdminI_Load(object sender, EventArgs e)
        {
            Action.Hide();
            Reset.Hide();
            ViewUsersRequests.Hide();
            Sendtoc.Hide();
            Sendtol.Hide();
            SendNotice.Hide();
            noticeInfo.Hide();
        }

        private void AUser_Click(object sender, EventArgs e)
        {
            showinputs();
            hidebuttons();
            Action.Text = "Add User";
            Reset.Text = "Reset";
            Action.Show();
            Reset.Show();
        }

        private void SNotice_Click(object sender, EventArgs e)
        {
            hidebuttons();
            Sendtoc.Show();
            Sendtol.Show();
            SendNotice.Show();
            noticeInfo.Show();
        }

        private void VRequest_Click(object sender, EventArgs e)
        {
            ViewUsersRequests.Show();
            hidebuttons();
            Action.Text = "Accept Request";
            Reset.Text = "Decline Request";
            Action.Show();
            Reset.Show();

            //Shoof ht3mlaha hide ezay lama tedoos 3ala el buttons ely m3aha
            //hena w fi view users
        }

        private void RUser_Click(object sender, EventArgs e)
        {
            showinputs();
            hidebuttons();
            disableinputs();
            Action.Text = "Remove User";
            Reset.Text = "Reset";
            Action.Show();
        }

        private void EUser_Click(object sender, EventArgs e)
        {
            showinputs();
            hidebuttons();
            Action.Text = "Save Changes";
            Reset.Text = "Reset Changes";
            Action.Show();
            Reset.Show();
        }

        private void VUser_Click(object sender, EventArgs e)
        {
            ViewUsersRequests.Show();
            hidebuttons();
            Action.Text = "Remove User";
            Reset.Text = "Edit User";
            Action.Show();
            Reset.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            login = new SScreen();
            {
                //if (this.WindowState == FormWindowState.Maximized)
                //{
                //    SHControls.Text = "Log Out";
                //    AUser.Show();
                //    VUser.Show();
                //    EUser.Show();
                //    RUser.Show();
                //    VRequest.Show();
                //    SNotice.Show();
                //    ControlsFlag = true;
                //}
                //else
                //{
                //    if (ControlsFlag)
                //    {
                //        SHControls.Text = "Back";
                //        AUser.Hide();
                //        VUser.Hide();
                //        EUser.Hide();
                //        RUser.Hide();
                //        VRequest.Hide();
                //        SNotice.Hide();
                //        ControlsFlag = false;
                //    }
                //    else
                //    {
                //        SHControls.Text = "Log Out";
                //        AUser.Show();
                //        VUser.Show();
                //        EUser.Show();
                //        RUser.Show();
                //        VRequest.Show();
                //        SNotice.Show();
                //        ControlsFlag = true;
                //    }
                //}
            }

            if (SHControls.Text == "Log Out")
            {
                this.Close();
                login.Show();
            }
            else if (SHControls.Text == "Back")
            {
                reset();
                enableinputs();
                ViewUsersRequests.Hide();
                Sendtoc.Hide();
                Sendtol.Hide();
                SendNotice.Hide();
                noticeInfo.Hide();
                backbutton();
                SHControls.Text = "Log Out";
                Action.Hide();
                Reset.Hide();
            }
            //add back control
        }

        private void SHControls_MouseHover(object sender, EventArgs e)
        {
            //System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            //if (ControlsFlag)
            //{
            //    ToolTip1.SetToolTip(this.SHControls, "Log Out of this account");
            //}
            //else
            //{
            //    ToolTip1.SetToolTip(this.SHControls, "Back to main menu");
            //}
        }

        private void AdminI_SizeChanged(object sender, EventArgs e)
        {
             //Initialization of components
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
            }

            if (this.WindowState == FormWindowState.Maximized)
            {
                //Size, Font, and location
                {
                    this.AUser.Size = new Size(194, 72);
                    this.AUser.Font = new Font("Microsoft Sans Serif",
                                   (float)16.5,
                                   FontStyle.Regular);
                    this.AUser.Location = new Point(64, 80);

                    this.VUser.Size = new Size(194, 72);
                    this.VUser.Font = new Font("Microsoft Sans Serif",
                                   (float)16.5,
                                   FontStyle.Regular);
                    this.VUser.Location = new Point(64, 180);

                    this.EUser.Size = new Size(194, 72);
                    this.EUser.Font = new Font("Microsoft Sans Serif",
                                   (float)16.5,
                                   FontStyle.Regular);
                    this.EUser.Location = new Point(64, 280);

                    this.RUser.Size = new Size(194, 72);
                    this.RUser.Font = new Font("Microsoft Sans Serif",
                                   (float)16.5,
                                   FontStyle.Regular);
                    this.RUser.Location = new Point(64, 380);

                    this.VRequest.Size = new Size(194, 72);
                    this.VRequest.Font = new Font("Microsoft Sans Serif",
                                   (float)16.5,
                                   FontStyle.Regular);
                    this.VRequest.Location = new Point(64, 480);

                    this.SNotice.Size = new Size(194, 72);
                    this.SNotice.Font = new Font("Microsoft Sans Serif",
                                   (float)16.5,
                                   FontStyle.Regular);
                    this.SNotice.Location = new Point(64, 580);

                    this.SHControls.Size = new Size(112, 50);
                    this.SHControls.Font = new Font("Microsoft Sans Serif",
                                   14,
                                   FontStyle.Regular);
                    this.SHControls.Location = new Point(15, 730);
                }
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                //Button properties
                {
                    this.AUser.Size = new Size(171, 64);
                    this.AUser.Font = new Font("Microsoft Sans Serif",
                                   (float)14,
                                   FontStyle.Regular);
                    this.AUser.Location = new Point(45, 47);

                    this.VUser.Size = new Size(171, 64);
                    this.VUser.Font = new Font("Microsoft Sans Serif",
                                   (float)14,
                                   FontStyle.Regular);
                    this.VUser.Location = new Point(280, 47);

                    this.EUser.Size = new Size(171, 64);
                    this.EUser.Font = new Font("Microsoft Sans Serif",
                                   (float)14,
                                   FontStyle.Regular);
                    this.EUser.Location = new Point(45, 155);

                    this.RUser.Size = new Size(171, 64);
                    this.RUser.Font = new Font("Microsoft Sans Serif",
                                   (float)14,
                                   FontStyle.Regular);
                    this.RUser.Location = new Point(280, 155);

                    this.VRequest.Size = new Size(171, 64);
                    this.VRequest.Font = new Font("Microsoft Sans Serif",
                                   (float)14,
                                   FontStyle.Regular);
                    this.VRequest.Location = new Point(45, 265);

                    this.SNotice.Size = new Size(171, 64);
                    this.SNotice.Font = new Font("Microsoft Sans Serif",
                                   (float)14,
                                   FontStyle.Regular);
                    this.SNotice.Location = new Point(280, 265);

                    this.SHControls.Size = new Size(80, 36);
                    this.SHControls.Font = new Font("Microsoft Sans Serif",
                                   9,
                                   FontStyle.Regular);
                    this.SHControls.Location = new Point(9, 386);

                    this.Reset.Size = new Size(106, 36);
                    this.Reset.Font = new Font("Microsoft Sans Serif",
                                   9,
                                   FontStyle.Regular);
                    this.Reset.Location = new Point(275, 386);

                    this.Action.Size = new Size(106, 36);
                    this.Action.Font = new Font("Microsoft Sans Serif",
                                   9,
                                   FontStyle.Regular);
                    this.Action.Location = new Point(390, 386);
                }

                //Other component locations
                {
                    //Textboxes
                    this.FnameT.Location = new Point(40, 40);
                    this.MnameT.Location = new Point(200, 40);
                    this.LnameT.Location = new Point(360, 40);
                    this.AddressT.Location = new Point(40, 185);
                    this.PhoneNumberT.Location = new Point(200, 135);
                    this.SSNT.Location = new Point(40, 135);
                    this.UNT.Location = new Point(40, 345);
                    this.PWT.Location = new Point(200, 345);
                    this.SalaryT.Location = new Point(200, 250);
                    this.QualificationsT.Location = new Point(260, 185);

                    ////Datepickers
                    this.BDateT.Location = new Point(200, 85);
                    this.SDateT.Location = new Point(40, 300);
                    this.EDateT.Location = new Point(260, 300);

                    ////Comboboxes
                    this.GenderT.Location = new Point(40, 85);
                    this.PositionT.Location = new Point(40, 250);

                    ////Labels
                    this.Fnamel.Location = new Point(40, 25);
                    this.Mnamel.Location = new Point(200, 25);
                    this.Lnamel.Location = new Point(360, 25);
                    this.Addressl.Location = new Point(40, 170);
                    this.PhoneNumberl.Location = new Point(200, 120);
                    this.SSNl.Location = new Point(40, 120);
                    this.UNl.Location = new Point(40, 330);
                    this.PWl.Location = new Point(200, 330);
                    this.Salaryl.Location = new Point(200, 235);
                    this.Qualificationsl.Location = new Point(260, 170);
                    this.BDatel.Location = new Point(200, 70);
                    this.SDatel.Location = new Point(40, 285);
                    this.EDatel.Location = new Point(260, 285);
                    this.Genderl.Location = new Point(40, 70);
                    this.Positionl.Location = new Point(40, 235);
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (Reset.Text == "Edit User")
            {
                //Take info of chosen user and open edit screen
            }
            else if (Reset.Text == "Reset")
            {
                reset();
            }
            else if (Reset.Text == "Reset Changes")
            {
                resetinfo();
            }
            else if (Reset.Text == "Decline Request")
            {
                //Change request state in database (pending, accepted, declined)
                //Optional: send notice to user regarding request denial
                //then call Main screen
            }
        }

        private void Action_Click(object sender, EventArgs e)
        {
            if (Action.Text == "Add User")
            {
                //Try adding in database, return result in message box, then call main screen
            }
            else if (Action.Text == "Save Changes")
            {
                //Try editing in database, return result in message box, then call main screen
            }
            else if (Action.Text == "Remove User")
            {
                string username = "Mohamed"; //Username will be taken from database
                string message = "Are you sure you want to remove " + username;
                var prompt = MessageBox.Show(message, "Remove User",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning);
                if (prompt == DialogResult.Yes)
                {
                    //remove user from database and call reset and enableinputs
                    Mainscreen();
                }
            }
            else if (Action.Text == "Accept Request")
            {
                //Change request state in database (pending, accepted, declined)
                //Optional: send notice to user regarding request acceptance
                //then call main Screen
            }
        }

        private void reset()
        {
            //Textboxes
            for (int i = 0; i < Tlist.Count; i++)
            {
                Tlist[i].ResetText();
            }
            //Datepickers
            for (int i = 0; i < Dlist.Count; i++)
            {
                Dlist[i].ResetText();
            }
            //Comboboxes
            for (int i = 0; i < Clist.Count; i++)
            {
                Clist[i].ResetText();
            }
        }

        private void resetinfo() //called for edit user to reset any changes made
        {

        }

        private void enableinputs()
        {
            for (int i = 0; i < Tlist.Count; i++)
            {
                Tlist[i].Enabled = true;
            }
            //Datepickers
            for (int i = 0; i < Dlist.Count; i++)
            {
                Dlist[i].Enabled = true;
            }
            //Comboboxes
            for (int i = 0; i < Clist.Count; i++)
            {
                Clist[i].Enabled = true;
            }
        }

        private void disableinputs()
        {
            for (int i = 0; i < Tlist.Count; i++)
            {
                Tlist[i].Enabled = false;
            }
            //Datepickers
            for (int i = 0; i < Dlist.Count; i++)
            {
                Dlist[i].Enabled = false;
            }
            //Comboboxes
            for (int i = 0; i < Clist.Count; i++)
            {
                Clist[i].Enabled = false;
            }
        }

        private void showinputs()
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
        }

        private void hidebuttons()
        {
            //Buttons
            for (int i = 0; i < Blist.Count; i++)
            {
                Blist[i].Hide();
            }
            SHControls.Text = "Back";
        }

        private void backbutton()
        {
            //Textboxes
            for (int i = 0; i < Tlist.Count; i++)
            {
                Tlist[i].Hide();
            }
            //Datepickers
            for (int i = 0; i < Dlist.Count; i++)
            {
                Dlist[i].Hide();
            }
            //Comboboxes
            for (int i = 0; i < Clist.Count; i++)
            {
                Clist[i].Hide();
            }
            //Labels
            for (int i = 0; i < Llist.Count; i++)
            {
                Llist[i].Hide();
            }
            //Buttons
            for (int i = 0; i < Blist.Count; i++)
            {
                Blist[i].Show();
            }
            Action.Text = "";
            Reset.Text = "";
        }

        private void Mainscreen()
        {
            backbutton();
            reset();
            enableinputs();
            Action.Hide();
            Reset.Hide();
            ViewUsersRequests.Hide();
            Sendtoc.Hide();
            Sendtol.Hide();
            SendNotice.Hide();
            noticeInfo.Hide();
            SHControls.Text = "Log Out";
        }
    }
}
