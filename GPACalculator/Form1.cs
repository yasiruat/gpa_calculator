namespace GPACalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            grade1.Text = "";
            grade2.Text = "";
            grade3.Text = "";
            grade4.Text = "";
            grade5.Text = "";
            grade6.Text = "";
            grade7.Text = "";
            grade8.Text = "";

            credit1.Text = null;
            credit2.Text = null;
            credit3.Text = null;
            credit4.Text = null;
            credit5.Text = null;
            credit6.Text = null;
            credit7.Text = null;
            credit8.Text = null;

            resultLabel.Text = null;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double[] gradeValues = new double[8];
            int[] creditValues = new int[8];
            int totalCredits = 0;
            double result = 0.0;
            double multiplication = 0.0;

            for (int i = 1; i <= 8; i++)
            {
                TextBox textBox = Controls.Find("grade" + i, true).FirstOrDefault() as TextBox;
                if (textBox.Text == "A+")
                {
                    gradeValues[i - 1] = 4.2;
                }
                else if (textBox.Text == "A")
                {
                    gradeValues[i - 1] = 4.0;
                }
                else if (textBox.Text == "A-")
                {
                    gradeValues[i - 1] = 3.7;
                }
                else if (textBox.Text == "B+")
                {
                    gradeValues[i - 1] = 3.3;
                }
                else if (textBox.Text == "B")
                {
                    gradeValues[i - 1] = 3.0;
                }
                else if (textBox.Text == "B-")
                {
                    gradeValues[i - 1] = 2.7;
                }
                else if (textBox.Text == "C+")
                {
                    gradeValues[i - 1] = 2.3;
                }
                else
                {
                    gradeValues[i - 1] = 0.0;
                }


                string selectedValue = Controls.Find("credit" + i, true).OfType<DomainUpDown>().FirstOrDefault()?.Text;
                int.TryParse(selectedValue, out creditValues[i - 1]);
                totalCredits += creditValues[i - 1];
            }

            for (int i = 0; i < 8; i++)
            {
                multiplication += (gradeValues[i] * creditValues[i]);
            }

            result = Math.Round((multiplication / totalCredits),2);

            resultLabel.Text = result.ToString();


        }
    }
}