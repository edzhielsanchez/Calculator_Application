using System.Security.Cryptography.X509Certificates;

namespace Calculator_Application
{
    public partial class Form1 : Form
    {
        double number1, number2;
        CalculatorClass cal;

        public Form1()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtBoxInput1.Text);
            number2 = Convert.ToDouble(txtBoxInput2.Text);

            if (cbOperator.Text == "+")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetSum);
                lblDisplayTotal.Text = cal.GetSum(number1, number2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetSum);
            }
            if (cbOperator.Text == "-")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                lblDisplayTotal.Text = cal.GetDifference(number1, number2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
            }
            if (cbOperator.Text == "*")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                lblDisplayTotal.Text = cal.GetProduct(number1, number2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
            }
            if (cbOperator.Text == "/")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                lblDisplayTotal.Text = cal.GetQuotient(number1, number2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
            }
        }
    }
}