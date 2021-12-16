namespace tempCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            string input = textBoxC.Text;

            double c = Convert.ToDouble(input);
            double f = c * 9 / 5 + 32;

            textBoxF.Text = f.ToString();
        }

        private void buttonConvert2_Click(object sender, EventArgs e)
        {
            string input = textBoxF.Text;

            double f = Convert.ToDouble(input);
            double c = (f - 32) * 5 / 9;

            textBoxC.Text = c.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxC.Text = "";
            textBoxF.Text = "";
        }
    }
}