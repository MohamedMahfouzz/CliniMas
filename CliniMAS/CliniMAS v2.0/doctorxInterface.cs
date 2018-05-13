using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CliniMAS_v2._0
{
    public partial class doctorxInterface : Form
    {
        SScreen login;

        //Flags for value checking
        private bool FNameF, MNameF, LNameF, GenF, SSNF, PnumberF, SalaryF, EmailF, PosF, TextF, ComboF;
        List<bool> boolList;

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

        public doctorxInterface()
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
            boolList = new List<bool>();

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
                Llist.Add(sendingTo);
                Blist.Add(back);
                Blist.Add(action1);
                Blist.Add(action2);
                boolList.Add(FNameF);
                boolList.Add(MNameF);
                boolList.Add(LNameF);
                boolList.Add(GenF);
                boolList.Add(SSNF);
                boolList.Add(PnumberF);
                boolList.Add(SalaryF);
                boolList.Add(EmailF);
                boolList.Add(PosF);
                boolList.Add(TextF);
                boolList.Add(ComboF);
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
                //Flags
                for (int i = 0; i < boolList.Count(); i++)
                {
                    boolList[i] = false;
                }
            }

            //Component info
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

        private void doctorxInterface_Load(object sender, EventArgs e)
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

        private void doctorxInterface_Resize(object sender, EventArgs e)
        {
            this.back.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.action1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.action2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
        }

        private void addDiagnosticToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.hideAll();
            //Buttons
            for (int i = 0; i < Blist.Count; i++)
            {
                Blist[i].Show();
            }
            sendingTo.Show();
            messageBox.Show();
            action1.Text = "Reset";
            action2.Text = "Add Diagnostic";
            sendingTo.Text = "Diagnostic";
        }

        private void addMedicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.hideAll();
            //Buttons
            for (int i = 0; i < Blist.Count; i++)
            {
                Blist[i].Show();
            }
            sendingTo.Show();
            messageBox.Show();
            action1.Text = "Reset";
            action2.Text = "Add Medication";
            sendingTo.Text = "Medication";
        }

        private void viewScheduleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.hideAll();
            this.showViewingInterface();
            action1.Text = "Save Edits";
            action2.Text = "Remove User";
        }

        private void requestMaterialsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.hideAll();
            //Buttons
            for (int i = 0; i < Blist.Count; i++)
            {
                Blist[i].Show();
            }
            sendingTo.Show();
            messageBox.Show();
            action1.Text = "Reset";
            action2.Text = "Send Request";
            sendingTo.Text = "Request Materials";
        }

        private void requestEmployeesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.hideAll();
            //Buttons
            for (int i = 0; i < Blist.Count; i++)
            {
                Blist[i].Show();
            }
            sendingTo.Show();
            messageBox.Show();
            action1.Text = "Reset";
            action2.Text = "Send Request";
            sendingTo.Text = "Request Employees";
        }

        private void sendToAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.hideAll();
            //Buttons
            for (int i = 0; i < Blist.Count; i++)
            {
                Blist[i].Show();
            }
            sendingTo.Show();
            messageBox.Show();
            action1.Text = "Reset";
            action2.Text = "Send Message";
            sendingTo.Text = "Sending to All Employees";
        }

        private void sendToNursesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.hideAll();
            //Buttons
            for (int i = 0; i < Blist.Count; i++)
            {
                Blist[i].Show();
            }
            sendingTo.Show();
            messageBox.Show();
            action1.Text = "Reset";
            action2.Text = "Send Message";
            sendingTo.Text = "Sending to Nurses";
        }

        private void sendToReceptionistsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.hideAll();
            //Buttons
            for (int i = 0; i < Blist.Count; i++)
            {
                Blist[i].Show();
            }
            sendingTo.Show();
            messageBox.Show();
            action1.Text = "Reset";
            action2.Text = "Send Message";
            sendingTo.Text = "Sending to Receptionists";
        }

        private void editAccountSettingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.hideAll();
            this.showAddUserItems();
            this.action1.Text = "Reset Changes";
            this.action2.Text = "Save Changes";
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void action1_Click(object sender, EventArgs e)
        {

        }

        private void action2_Click(object sender, EventArgs e)
        {

        }

        private void doctorxInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            this.hideAll();
            login = new SScreen();
            login.Show();
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
            for (int i = 0; i < Llist.Count - 1; i++)
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
            //Flags
            for (int i = 0; i < boolList.Count(); i++)
            {
                boolList[i] = false;
            }
            action1.ResetText();
            action2.ResetText();
            viewInterface.Hide();
            viewInterface.DataSource = null;
            viewInterface.Rows.Clear();
            messageBox.Hide();
            messageBox.ResetText();

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
            viewInterface.DataSource = null;
            viewInterface.Rows.Clear();
            messageBox.ResetText();
            //Flags
            for (int i = 0; i < boolList.Count(); i++)
            {
                boolList[i] = false;
            }
        }

        private bool checkInputs()
        {
            //Falsifies all inputs
            for (int i = 0; i < boolList.Count(); i++)
            {
                boolList[i] = false;
            }

            //Check if all inputs have values
            for (int i = 0; i < Tlist.Count(); i++)
            {
                if (string.IsNullOrWhiteSpace(Tlist[i].Text))
                {
                    TextF = true;
                    break;
                }
            }
            for (int i = 0; i < Clist.Count(); i++)
            {
                if (string.IsNullOrWhiteSpace(Clist[i].Text))
                {
                    ComboF = true;
                    break;
                }
            }

            //Checks certain inouts for valid values
            if (FnameT.Text.Any(Char.IsDigit))
                boolList[0] = true;
            if (MnameT.Text.Any(Char.IsDigit))
                boolList[1] = true;
            if (LnameT.Text.Any(Char.IsDigit))
                boolList[2] = true;
            if (GenderT.Text != "Male" && GenderT.Text != "Female")
                boolList[3] = true;
            if (PositionT.Text != "Doctor" && PositionT.Text != "Nurse" && PositionT.Text != "Receptionist"
                && PositionT.Text != "Worker" && PositionT.Text != "Intern")
                boolList[8] = true;
            if (SSNT.TextLength != 14 || SSNT.Text.Any(Char.IsLetter))
                boolList[4] = true;
            if (PhoneNumberT.TextLength != 11 || PhoneNumberT.Text.Any(Char.IsLetter))
                boolList[5] = true;
            if (int.TryParse(SalaryT.Text, out int n))
            {
                if (n < 0)
                    boolList[6] = true;
            }
            else
                boolList[6] = true;
            if (!IsValidEmail(EmailT.Text))
                boolList[7] = true;

            //Return true if any value is illegal
            for (int i = 0; i < boolList.Count(); i++)
            {
                if (boolList[i] == true)
                    return true;
            }
            return false;
        }

        private bool IsValidEmail(String email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
