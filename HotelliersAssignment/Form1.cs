﻿using HotelliersAssignment.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelliersAssignment
{
    public partial class Hoteliers : Form
    {
        bool expand = false;
        String resourceValue = Resources.Test;
        public Hoteliers()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(StaffTab);
            StaffUserInput.Text = "Username";
            StaffUserInput.ForeColor = Color.LightGray;
            StaffPasswordInput.Text = "Password";
            StaffPasswordInput.ForeColor = Color.LightGray;

            BookStartDate.MinDate = DateTime.UtcNow;
            BookEndDate.MinDate = DateTime.UtcNow.AddDays(1);
            MessageBox.Show(resourceValue);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaffLoginBtn_Click(object sender, EventArgs e)
        {
            bool complete = false;
            while (complete == false)
            {
                if (string.IsNullOrEmpty(StaffUserInput.Text) || StaffUserInput.Text == "Username")
                {
                    complete = false;
                    UsernameErr.SetError(StaffUserInput, "Can't be null or empty");
                }
                if (string.IsNullOrEmpty(StaffPasswordInput.Text) || StaffPasswordInput.Text == "Password")
                {
                    complete = false;
                    PasswordErr.SetError(StaffPasswordInput, "Can't be null or empty");
                }
                if (StaffPasswordInput.Text.Equals("Password123") & StaffUserInput.Text.Equals("Kaiden"))
                {
                    complete = true;
                    tabControl1.TabPages.Add(StaffTab);
                    tabControl1.TabPages.Remove(StaffLogTab);
                    tabControl1.SelectTab(StaffTab);
                }
                //Add implementation of csv usernames
                else
                {
                    PasswordErr.SetError(StaffPasswordInput, "Incorrect username or password");
                }
                break;
            }
        }
        private void StaffUserInput_Enter(Object sender, EventArgs e)
        {
            if (StaffUserInput.Text == "Username")
            {
                StaffUserInput.Text = "";
                StaffUserInput.ForeColor = Color.Black;
            }
        }
        private void StaffPasswordInput_Enter(Object sender, EventArgs e)
        {
            if (StaffPasswordInput.Text == "Password")
            {
                StaffPasswordInput.UseSystemPasswordChar = true;
                StaffPasswordInput.Text = "";
                StaffPasswordInput.ForeColor = Color.Black;
            }
        }

        private void StaffPasswordInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StaffPasswordInput.Text))
            {
                StaffPasswordInput.UseSystemPasswordChar = false;
                StaffPasswordInput.Text = "Password";
                StaffPasswordInput.ForeColor = Color.LightGray;
            }
        }

        private void StaffUserInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StaffUserInput.Text))
            {
                StaffUserInput.Text = "Username";
                StaffUserInput.ForeColor = Color.LightGray;
            }
        }

        private void dropRoomBtn_Click(object sender, EventArgs e)
        {
            DropTimer.Start();
        }

        private void DropTimer_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                dropDownPanel.Height += 15;
                if (dropDownPanel.Height >= dropDownPanel.MaximumSize.Height)
                {
                    DropTimer.Stop();
                    expand = true;
                }
            }
            else if (expand == true)
            {
                dropDownPanel.Height -= 15;
                if (dropDownPanel.Height <= dropDownPanel.MinimumSize.Height)
                {
                    DropTimer.Stop();
                    expand = false;
                }
            }
        }

        //Room number and person numbers
        int RoomNum;
        int AdultNum;
        int ChildNum;
        int InfantNum;

        private void IncARoom_Click(object sender, EventArgs e)
        {
            RoomNum = int.Parse(RoomTxt.Text);
            RoomNum++;
            RoomTxt.Text = RoomNum.ToString();
            
        }

        private void IncAAdult_Click(object sender, EventArgs e)
        {
            AdultNum = int.Parse(AdultTxt.Text);
            AdultNum++;
            AdultTxt.Text = AdultNum.ToString();
        }
        private void IncAChild_Click(object sender, EventArgs e)
        {
            ChildNum = int.Parse(ChildTxt.Text);
            ChildNum++;
            ChildTxt.Text = ChildNum.ToString();
        }
        private void IncAInfant_Click(object sender, EventArgs e)
        {
            InfantNum = int.Parse(InfantTxt.Text);
            InfantNum++;
            InfantTxt.Text = InfantNum.ToString();
        }

    }
}