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
            double num1;
            double num2;

            if (txtFirstNum.Text == "" || txtSecondNum.Text == "")
            {

                MessageBox.Show("Please enter both numbers");

            }

            else
            {
                if (!double.TryParse(txtFirstNum.Text, out num1) || !double.TryParse(txtSecondNum.Text, out num2))
                {

                    MessageBox.Show("Invalid Input");
                    
                }
                else
                {
                    SubtractOP sub = new SubtractOP();
                    double result = sub.Subtract(num1, num2);

                    if (result <= 0)
                    {
                        txtFirstNum.Clear();
                        txtSecondNum.Clear();
                        lblResult.Text = string.Empty;
                        MessageBox.Show("Negative Result");
                    }
                    else
                    {
                        lblResult.Text = result.ToString();

                    }

                }

            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtFirstNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            //{
            //    e.Handled = true;
            //}

            //// Allow only one decimal point
            //TextBox txt = (TextBox)sender;

            //if (e.KeyChar == '.' && txt.Text.Contains("."))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtSecondNum_KeyPress(object sender, KeyPressEventArgs e)
        {
      //      if (!char.IsControl(e.KeyChar) &&
      //!char.IsDigit(e.KeyChar) &&
      //e.KeyChar != '.')
      //      {
      //          e.Handled = true;
      //      }

      //      // Allow only one decimal point
      //      TextBox txt = (TextBox)sender;

      //      if (e.KeyChar == '.' && txt.Text.Contains("."))
      //      {
      //          e.Handled = true;
      //      }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNum.Clear();
            txtSecondNum.Clear();
            lblResult.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

