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


            if (txtFirstNum.Text == "" || txtSecondNum.Text == "")
            {

                MessageBox.Show("Please enter both numbers");

            }
            
            else
            {

                SubtractOP sub = new SubtractOP();
                double num1;
                double num2;


                if (!double.TryParse(txtFirstNum.Text, out num1) || !double.TryParse(txtSecondNum.Text, out num2))
                {
                    MessageBox.Show("Invalid Input");
                    return;
                }
                else
                {
                    double result = sub.Sub(num1, num2);
                    
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

        }

        private void txtSecondNum_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNum.Clear();
            txtSecondNum.Clear();
            lblResult.Text = string.Empty;
        }
    }
}

