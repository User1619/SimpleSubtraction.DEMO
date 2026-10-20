namespace YearCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtFirstNum.Text);
            double num2 = Convert.ToDouble(txtSecondNum.Text);
            double result;

            SubtractOP sub = new SubtractOP();
            result = sub.Sub(num1, num2);

            lblResult.Text = result.ToString();

        }
    }
}
