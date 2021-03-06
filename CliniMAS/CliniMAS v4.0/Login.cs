﻿using System;
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
    public partial class SScreen : Form
    {
        doctorInterface Admin;
        //nurseInterface Nurse;
        //doctorInterface Doctor;
        //receptionistInterface Receptionist;
        public SScreen()
        {
            InitializeComponent();
            //Admin = new AdminI();

            MaximizeBox = false;
            MinimizeBox = false;

            UN.AutoSize = false;
            UN.AcceptsReturn = false;
            UN.Multiline = false;
            UN.Height = 25;
            UN.BorderStyle = BorderStyle.Fixed3D;
            UN.TextAlign = HorizontalAlignment.Center;
            UN.Text = "Username";
            UN.ForeColor = Color.Gray;
            UN.Font = new System.Drawing.Font("Monotype Corsiva",
                               9,
                               FontStyle.Italic);

            PW.AutoSize = false;
            PW.AcceptsReturn = false;
            PW.Multiline = false;
            PW.Height = 25;
            PW.UseSystemPasswordChar = false;
            PW.MaxLength = 64;
            PW.BorderStyle = BorderStyle.FixedSingle;
            PW.TextAlign = HorizontalAlignment.Center;
            PW.Text = "Password";
            PW.ForeColor = Color.Gray;
            PW.Font = new System.Drawing.Font("Monotype Corsiva",
                              9,
                              FontStyle.Italic);
        }

        private void SScreen_Load(object sender, EventArgs e)
        {
            //Initially the password character is not used to show normal text
            PW.UseSystemPasswordChar = false;
        }

        private void PW_TextChanged(object sender, EventArgs e)
        {
            //if the text in the password box is changed we have to use the password character
            PW.UseSystemPasswordChar = true;
        }

        private void UN_Click_1(object sender, EventArgs e)
        {
            if (UN.ForeColor == Color.Gray)
            {
                UN.Clear();
                UN.ForeColor = Color.Black;
            }
        }

        private void PW_Click_1(object sender, EventArgs e)
        {
            if (PW.Text == "Password")
            {
                PW.Clear();
                PW.ForeColor = Color.Black;
            }
            // if (PW.Text == "Password")
            //PW.UseSystemPasswordChar = false;
            //else PW.UseSystemPasswordChar = true;
        }

        private void UN_Leave(object sender, EventArgs e)
        {
            if (UN.Text == "")
            {
                UN.Text = "Username";
                UN.ForeColor = Color.Gray;
            }
        }

        private void PW_Leave(object sender, EventArgs e)
        {
            if (PW.Text == "")
            {
                PW.Text = "Password";
                PW.ForeColor = Color.Gray;
                PW.UseSystemPasswordChar = false;
            }
        }

        private void PW_Enter(object sender, EventArgs e)
        {
            if ((PW.Text != "" && PW.Text != "Password"))
            {
                PW.UseSystemPasswordChar = true;
                PW.Clear();
                PW.ForeColor = Color.Black;
            }
        }

        private void PW_EnabledChanged(object sender, EventArgs e)
        {
            //if (PW.Text != "" && PW.Text != "Password")
            //{
            //    PW.UseSystemPasswordChar = true;
            //    PW.Clear();
            //    PW.ForeColor = Color.Black;
            //}
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //if credentials are correct, we need to show new window depending on Control level
            Admin = new doctorInterface();
            Admin.Show();
            this.Hide();
            //Show main page if correct
            //Show admin page if admin
            //new MainP.Show();
            //else
            //{
            //    MessageBox.Show("Wrong Username or Password!");
            //}
        }

        private void SScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
