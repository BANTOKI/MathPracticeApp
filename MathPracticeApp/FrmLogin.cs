using System;
using System.Windows.Forms;

namespace MathPracticeApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                // Set a default date to avoid excessive scrolling in the date picker
                dtpDOB.Value = new DateTime(2017, 1, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during form load: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click1(object sender, EventArgs e)
        {
            try
            {
                // Read the birth date from the DateTimePicker
                DateTime dob = dtpDOB.Value;

                // Calculate the age
                int userAge = CalculateAge(dob);

                // Validate the age
                if (userAge < 4)
                {
                    MessageBox.Show("Oops! You are too young for this.",
                        "Age Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else if (userAge > 8)
                {
                    MessageBox.Show("Ooh, this is too basic for you.",
                        "Age Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    // Age is valid (between 4 and 8)
                    MessageBox.Show($"Welcome! Your age is {userAge}. Proceeding to the next step.",
                        "Login Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Load the FrmOperations form
                    FrmOperations operationsForm = new FrmOperations();
                    operationsForm.Show();

                    // Hide the current FrmLogin form
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //  method to calculate age from the date of birth
        private int CalculateAge(DateTime dob)
        {
            try
            {
                DateTime today = DateTime.Now;
                int age = today.Year - dob.Year;

                // Subtract 1 if the user's birthday has not occurred yet this year
                if (dob.Date > today.AddYears(-age))
                {
                    age--;
                }

                // Debugging step: Log age calculation
                MessageBox.Show($"You are  {age} years Old" , "Debug");
                return age;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating age: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
