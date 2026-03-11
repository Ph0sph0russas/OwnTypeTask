namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void Calculate()
        {
            try
            {
                var a1XValue = double.Parse(a1X.Text);
                var a2YValue = double.Parse(a2Y.Text);
                var a3ZValue = double.Parse(a3Z.Text);

                var xResult = 0.0;
                var yResult = 0.0;
                var zResult = 0.0;

                var b1XValue=double.Parse(b1X.Text);
                var b2YValue=double.Parse(b2Y.Text);
                var b3ZValue=double.Parse(b3Z.Text);

               
            }
            catch (FormatException)
            {
                // если тип преобразовать не смогли
            }
        }

    }
}
