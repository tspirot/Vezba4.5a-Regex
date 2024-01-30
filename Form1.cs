using System.Text.RegularExpressions;

namespace Vezba4._5a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // provera da li su TextBox-ovi prazni   
            if (textBoxLast.Text == "" || textBoxFirst.Text == ""
                || textBoxAdress.Text == "" || textBoxCity.Text == ""
                || textBoxState.Text == "" || textBoxZIP.Text == "" || textBoxPhone.Text == "")
            {
                // prikazivanje upozorenja   
                MessageBox.Show("Please fill in all fields", 
                    "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error); 
                textBoxFirst.Focus();
                // set focus to firstNameTextBox          
                return;
            }   
            if (!Regex.IsMatch(textBoxFirst.Text, "^[A-Z][a-zA-Z]*$"))
            {
                // first name was incorrect   
                MessageBox.Show("Invalid first name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFirst.Focus();
                return;
            }
            // if last name format invalid show message
            if (!Regex.Match(textBoxLast.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // last name was incorrect
                MessageBox.Show("Invalid last name", "Message", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                textBoxLast.Focus();
                return;
            }
            // end if
            // if address format invalid show message
            if (!Regex.Match(textBoxAdress.Text, @"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zAZ]+)$").Success)
            {
                // address was incorrect
                MessageBox.Show("Invalid address", "Message", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                textBoxAdress.Focus();
                return;
            }
            // end if
            // if city format invalid show message
            if (!Regex.Match(textBoxCity.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                // city was incorrect
                MessageBox.Show("Invalid city", "Message", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                textBoxCity.Focus();
                return;
            }
            // end if
            // if state format invalid show message
            if (!Regex.Match(textBoxState.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                // state was incorrect
                MessageBox.Show("Invalid state", "Message", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                textBoxState.Focus();
                return;
            }
            // end if
            // if zip code format invalid show message
            if (!Regex.Match(textBoxZIP.Text, @"^\d{5}$").Success)
            {
                // zip was incorrect
                MessageBox.Show("Invalid zip code", "Message", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                textBoxZIP.Focus();
                return;
            }
            // end if
            // if phone number format invalid show message
            if (!Regex.Match(textBoxPhone.Text, @"^[1-9]{2}-[1-9]{2}-\d{4}$").Success)
            {
                // phone number was incorrect
                MessageBox.Show("Invalid phone number", "Message", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                textBoxPhone.Focus();
                return;
            }
            // end if
            // information is valid, signal user and exit application
            this.Hide(); // hide main window while MessageBox displays
            MessageBox.Show("Thank You!", "Information Correct", MessageBoxButtons.OK,
           MessageBoxIcon.Information);
        }
    }
}
