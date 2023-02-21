namespace Regression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            TextBox inAge = (TextBox)ageIn;
            TextBox inWieght = (TextBox)weightIn;

            // Independent variables (x1, x2)
            double weight = Double.Parse(inWieght.Text);
            double age = Double.Parse(inAge.Text);

            // Intercept
            double a = 30.99410295;

            double b1 = 0.861414686;
            double b2 = 0.334859197;

            double ans = a + ((b1 * age) + (b2 * weight));

            try
            {

                if (age >= 40 && age <= 75)
                {

                    result.Text = ans.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter age between 40 and 75.", "Notice:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter Age And weight", "Error!:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}