using HoteliersAssignment;
using HotelliersAssignment.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelliersAssignment
{
    public partial class Hoteliers : Form
    {
        ClientDatabase Cdatabase = ClientDatabase.GetInstance();
        private bool userClosing = false;
        bool expand = false;
        /// <summary>
        /// Total number of people selected
        /// </summary>
        int totalP = 0;
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

            Cdatabase.createFile();
            

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaffLoginBtn_Click(object sender, EventArgs e)
        {
            bool complete = false;
            while (complete == false)
            {
                if (string.IsNullOrEmpty(StaffUserInput.Text) || StaffUserInput.Text == "Username")
                {
                    UsernameErr.SetError(StaffUserInput, "Can't be null or empty");
                }
                if (string.IsNullOrEmpty(StaffPasswordInput.Text) || StaffPasswordInput.Text == "Password")
                {
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

        private void DropRoomBtn_Click(object sender, EventArgs e)
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
        int RoomNum = 1;
        int AdultNum = 1;
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

        private void IncDInfants_Click(object sender, EventArgs e)
        {
            InfantNum = int.Parse(InfantTxt.Text);
            InfantNum--;
            InfantNum = NumberValidation(InfantNum);
            InfantTxt.Text = InfantNum.ToString();
        }

        private void IncDAdult_Click(object sender, EventArgs e)
        {
            AdultNum = int.Parse(AdultTxt.Text);
            AdultNum--;
            AdultNum = RoomAdultValidation(AdultNum);
            AdultTxt.Text = AdultNum.ToString();
        }

        private void IncDChild_Click(object sender, EventArgs e)
        {
            ChildNum = int.Parse(ChildTxt.Text);
            ChildNum--;
            ChildNum = NumberValidation(ChildNum);
            ChildTxt.Text = ChildNum.ToString();
        }

        private void IncDRoom_Click(object sender, EventArgs e)
        {
            RoomNum = int.Parse(RoomTxt.Text);
            RoomNum--;
            RoomNum = RoomAdultValidation(RoomNum);
            RoomTxt.Text = RoomNum.ToString();
        }

        //To ensure variable doesnt go below 0
        private int NumberValidation(int input)
        {
            if (input < 0)
            {
                MessageBox.Show("You can not go below 0");
                return 0;
            }
            else
            {
                return input;
            }
        }
        private int RoomAdultValidation(int input)
        {
            if (input < 1)
            {
                MessageBox.Show("You can not go below 1");
                return 1;
            }
            else
            {
                return input;
            }
        }

        //Ensures that the numbers arent negative
        private bool NegativeValidation(string input)
        {
            if (input.Contains("-"))
            {
                MessageBox.Show("You can not go below 0");
                return true;
            }
            else
            {
                return false;
            }
        }

        //Handles the change of text in any of the room,adult, child and etc text boxes 
        private void RoomPersonCheck_Changed(object sender, EventArgs e)
        {
            StringBuilder BtnText = new StringBuilder();
            
            totalP = AdultNum + ChildNum + InfantNum;

            if (RoomNum > 0)
            {
                BtnText.Append(RoomTxt.Text + " Rooms | ");
            }
            else if (NegativeValidation(RoomTxt.Text))
            {
                RoomTxt.Text = NumberValidation(RoomNum + 1).ToString();
            }
            if (AdultNum > 0)
            {
                BtnText.Append(AdultTxt.Text + " Adults | ");
            }
            else if (NegativeValidation(AdultTxt.Text))
            {
                AdultTxt.Text = NumberValidation(AdultNum + 1).ToString();
            }
            if (ChildNum > 0) 
            {
                BtnText.Append(ChildTxt.Text + " Children | ");     
            }
            else if (NegativeValidation(ChildTxt.Text))
            {
                ChildTxt.Text = NumberValidation(ChildNum).ToString();
            }
            if (InfantNum > 0)
            {
                BtnText.Append(InfantTxt.Text + " Infants");
            }
            else if (NegativeValidation(InfantTxt.Text))
            {
                InfantTxt.Text = NumberValidation(InfantNum).ToString();
            }
            RoomPersonTxt.Text = BtnText.ToString();
        }

        private void RoomPerson_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!int.TryParse(textBox.Text, out _))
            {
                // Shows a MessageBox if the input is not an integer
                MessageBox.Show($"Please enter a valid integer in {textBox.Name}.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Text = "0";
            }
        }

        private void AddressStr_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != string.Empty & int.TryParse(textBox.Text, out _))
            {
                // Shows a MessageBox if the input is not an integer
                MessageBox.Show($"Please enter a valid string, containing no integers, in {textBox.Name}.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Text = string.Empty;
            }
        }

        private void AddressInt_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != string.Empty & !int.TryParse(textBox.Text, out _))
            {
                // Shows a MessageBox if the input is not an integer
                MessageBox.Show($"Please enter a valid integer in {textBox.Name}.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Text = string.Empty;
            }
        }

        /// <summary>
        /// Used by the submit button to provide and error to the user when a field is left empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void Address_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            //Discludes certain texts from the validation
            if (textBox == RoomPersonTxt || textBox == PrefIDTxt)
            {
                return;
            }

            // Validate length for a specific text box
            if (textBox == CustTxt)
            {
                if (textBox.Text.Length <= 5)
                {
                    AddressErrorProv.SetError(textBox, "Full name is prefered");
                    return;
                }
            }else if (textBox == PostcodeTxt)
            {
                if (!IsValidUKPostcode(textBox.Text))
                {
                    AddressErrorProv.SetError(textBox, "Use a proper postcode");
                    return;
                }
            }else if (textBox == StrNumTxt)
            {
                if (!IsValidStreetNumber(textBox.Text))
                {
                    AddressErrorProv.SetError(textBox, "Use a proper street number");
                    return;
                }
            }else if (textBox == StrTxt)
            {
                if (!IsValidStrCounty(textBox.Text) || textBox.Text.Length > 20)
                {
                    AddressErrorProv.SetError(textBox, "Use a proper street name");
                    return;
                }
            }else if (textBox == CountyTxt)
            {
                if (!IsValidStrCounty(textBox.Text) || textBox.Text.Length > 20)
                {
                    AddressErrorProv.SetError(textBox, "Use a proper county name");
                    return;
                }
            }else if (textBox == TelephoneTxt)
            {
                if (!IsValidUKPhoneNumber(textBox.Text))
                {
                    AddressErrorProv.SetError(textBox, "Use a proper phone number name");
                    return;
                }
            }

            // Check if the text box is empty
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                AddressErrorProv.SetError(textBox, "This field cannot be empty");
            }
            else
            {
                AddressErrorProv.SetError(textBox, ""); // Clear error
            }
        }

        /// <summary>
        /// Uses regex to make sure that the postcode entered is in the usual format ( AB12 9BU )
        /// </summary>
        /// <param name="postcode"></param>
        /// <returns></returns>
        static bool IsValidUKPostcode(string postcode)
        {
            // Regular expression for UK postcode format
            string pattern = @"^[A-Z]{1,2}\d[A-Z\d]? \d[A-Z]{2}$";

            // Use Regex.IsMatch to check if the input matches the pattern
            return Regex.IsMatch(postcode, pattern);
        }

        /// <summary>
        /// Checks if street number is positive using regex
        /// </summary>
        /// <param name="streetNumber"></param>
        /// <returns></returns>
        static bool IsValidStreetNumber(string streetNumber)
        {
            // Basic example: Street number must be a positive integer
            return Regex.IsMatch(streetNumber, @"^\d+$");
        }

        /// <summary>
        /// Checks if the street name or county name is a valid name
        /// </summary>
        /// <param name="streetName">String for the street name or county</param>
        /// <returns></returns>
        static bool IsValidStrCounty(string streetName)
        {
            // Basic example: Street name must start with an uppercase letter and can include letters, spaces, and hyphens
            return Regex.IsMatch(streetName, @"^[A-Z][A-Za-z\s\-]+$");
        }

        /// <summary>
        /// May look like gibberish but its a regex that will only allow phone numbers using the correct format
        /// </summary>
        /// <param name="phoneNumber">Number to be checked</param>
        /// <returns></returns>
        static bool IsValidUKPhoneNumber(string phoneNumber)
        {
            // Basic example: UK phone number format with or without spaces
            string pattern = @"^(?:(?:\+44)|(?:0))(?:\s?\d{5}\s?\d{5}|\s?\d{4}\s?\d{6}|\s?\d{3}\s?\d{7}|\s?\d{10})$";

            return Regex.IsMatch(phoneNumber, pattern);
        }

        /// <summary>
        /// Checks every text field on the page and checks to see if empty
        /// </summary>
        /// <param name="container">Tabcontrol1</param>
        /// <returns></returns>
        private bool ValidateAllTextFields(Control container)
        {
            bool allFieldsFilled = true;

            if (!userClosing)
            {
                foreach (Control control in container.Controls)
                {
                    if (control is TextBox textBox && (textBox != RoomPersonTxt && textBox != PrefIDTxt))
                    {
                        if (string.IsNullOrWhiteSpace(textBox.Text))
                        {
                            AddressErrorProv.SetError(textBox, "This field cannot be empty");
                            allFieldsFilled = false;
                        }
                        else
                        {
                            AddressErrorProv.SetError(textBox, ""); // Clear error
                        }
                    }
                }
            }

            return allFieldsFilled;
        }

        private void Hoteliers_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Set the flag indicating that the user is closing the form
                userClosing = true;
                MessageBox.Show("Hope you enjoyed using the application!", "Goodbye!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void ClientCreation()
        {
            MessageBox.Show("All text boxes are filled.", "Empty Text Box Check", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Address address1 = new Address(int.Parse(StrNumTxt.Text), StrTxt.Text, TownTxt.Text, CountyTxt.Text, PostcodeTxt.Text);

            if (String.IsNullOrEmpty(PrefIDTxt.Text))
            {
                string NoID = "null";
                Client client1 = new Client(NoID, CustTxt.Text, TelephoneTxt.Text, address1);
                Cdatabase.AddClient(client1);
            }
        }
        private void BookingCreation()
        {
            if (totalP > 5 * RoomNum)
            {
                MessageBox.Show("Too many people for the amount of rooms", "Reduce amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {

            }
        }

        private void BookingSubBtn_Click(object sender, EventArgs e)
        {
            // Trigger validation for the tab control
            if (ValidateAllTextFields(tabControl1.SelectedTab))
            {
                ClientCreation();
                BookingCreation();
            }
            else
            {
                MessageBox.Show("Please fill in all the required fields on the current tab.", "Empty Text Box Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
