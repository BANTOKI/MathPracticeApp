using System;
using System.Windows.Forms;

namespace MathPracticeApp
{
    public partial class FrmOperations : Form
    {
        private int trials = 0;
        private double correctAnswer = 0;

        public FrmOperations()
        {
            InitializeComponent();
        }

        private void FrmOperations_Load(object sender, EventArgs e)
        {
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            trials = 0;
            txtOperator.Clear();
            txtAnswer.Clear();
            lblQuestion.Text = "";

            if (cboGrade.SelectedItem == null)
            {
                MessageBox.Show("Please select a grade first.");
                return;
            }

            Random rand = new Random();
            int num1 = 0;
            int num2 = 0;

            if (cboGrade.SelectedItem.ToString() == "Grade 1")
            {
                num1 = rand.Next(0, 10);
                num2 = rand.Next(0, 10);
            }
            else if (cboGrade.SelectedItem.ToString() == "Grade 2")
            {
                num1 = rand.Next(10, 100);
                num2 = rand.Next(10, 100);
            }
            else if (cboGrade.SelectedItem.ToString() == "Grade 3")
            {
                num1 = rand.Next(10, 100);
                num2 = rand.Next(10, 100);
            }
            else
            {
                MessageBox.Show("Invalid grade selected.");
                return;
            }

            lblNum1.Text = num1.ToString();
            lblNum2.Text = num2.ToString();
            lblQuestion.Text = $"Numbers generated: {lblNum1.Text} and {lblNum2.Text}. Please input operator and answer.";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblNum1.Text) || string.IsNullOrWhiteSpace(lblNum2.Text))
            {
                MessageBox.Show("Please click 'Generate Random Numbers' first.");
                return;
            }

            if (cboGrade.SelectedItem == null)
            {
                MessageBox.Show("Please select a grade first.");
                return;
            }

            var grade = cboGrade.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(txtOperator.Text))
            {
                MessageBox.Show("Operator cannot be empty.");
                return;
            }

            string op = txtOperator.Text.Trim();

            if (IsOperatorValidForGrade(op, grade))
            {
                if (!double.TryParse(txtAnswer.Text, out double userAnswer))
                {
                    MessageBox.Show("Please enter a valid numeric answer.");
                    return;
                }

                lblQuestion.Text = $"What is {lblNum1.Text} {op} {lblNum2.Text}?";

                double n1 = double.Parse(lblNum1.Text);
                double n2 = double.Parse(lblNum2.Text);
                correctAnswer = CalculateAnswer(n1, n2, op);

                trials++;
                if (Math.Abs(userAnswer - correctAnswer) < 0.000001)
                {
                    MessageBox.Show("Correct!");
                    trials = 0;
                }
                else
                {
                    if (trials < 5)
                    {
                        MessageBox.Show("Incorrect. Try again.");
                    }
                    else
                    {
                        MessageBox.Show($"Exceeded number of trials. The correct answer is {correctAnswer}.");
                        trials = 0;
                    }
                }
            }
            else
            {
                MessageBox.Show($"Invalid operator '{op}' for {grade}.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to quit?",
                                                 "Exit",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private bool IsOperatorValidForGrade(string op, string grade)
        {
            switch (grade)
            {
                case "Grade 1":
                    return op == "+";
                case "Grade 2":
                    return (op == "+" || op == "-");
                case "Grade 3":
                    return (op == "+" || op == "-" || op == "*" || op == "/");
                default:
                    return false;
            }
        }

        private double CalculateAnswer(double n1, double n2, string op)
        {
            switch (op)
            {
                case "+": return n1 + n2;
                case "-": return n1 - n2;
                case "*": return n1 * n2;
                case "/":
                    if (Math.Abs(n2) < 0.000001)
                    {
                        MessageBox.Show("Cannot divide by zero. Please generate new numbers.");
                        return 0;
                    }
                    return n1 / n2;
                default:
                    return 0;
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void lblNum1_Click(object sender, EventArgs e) { }
        private void lblNum2_Click(object sender, EventArgs e) { }
        private void lblOperator_Click(object sender, EventArgs e) { }
    }
}
