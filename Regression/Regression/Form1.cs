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
            
            
            int a = 0;
            int b = 0;
            int ans = 0;

            try
            {
                int weight = Convert.ToInt32(inWieght.Text);
                int age = Convert.ToInt32(inAge.Text);
                if (age >= 40 && age <= 75)
                {

                    result.Text = ans.ToString();
                }
                else
                {
                    MessageBox.Show("Please Enter Age between 40 and 75", "Notice:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Enter Age And weight", "Error!:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
    }
}