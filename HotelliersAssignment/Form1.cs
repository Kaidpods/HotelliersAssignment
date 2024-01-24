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
        public Hoteliers()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(StaffTab);
            StaffUserInput.Text = "Username";
            StaffUserInput.ForeColor = Color.LightGray;
            StaffPasswordInput.Text = "Password";
            StaffPasswordInput.ForeColor = Color.LightGray;

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
                    usernameError.SetError(StaffUserInput, "Can't be null or empty");
                }
                if (string.IsNullOrEmpty(StaffPasswordInput.Text) || StaffPasswordInput.Text == "Password")
                {
                    complete = false;
                    passwordError.SetError(StaffPasswordInput, "Can't be null or empty");
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
                    passwordError.SetError(StaffPasswordInput, "Can't be null or empty");
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
    }
}
