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

                

                var b1XValue=double.Parse(b1X.Text);
                var b2YValue=double.Parse(b2Y.Text);
                var b3ZValue=double.Parse(b3Z.Text);

                var lengthA = 0.0;
                var lengthB = 0.0;

                var xResult = 0.0;
                var yResult = 0.0;
                var zResult = 0.0;
                switch (operationBox.Text)
                {
                    case "+":
                        xResult = a1XValue + b1XValue;
                        yResult=a2YValue + b2YValue;
                        zResult=a3ZValue + b3ZValue;

                        resultsBoxX.Text = xResult.ToString();
                        resultsBoxY.Text = yResult.ToString();
                        resultsBoxZ.Text = zResult.ToString();

                        break;
                    case "-":
                        xResult = a1XValue - b1XValue;
                        yResult = a2YValue - b2YValue;
                        zResult = a3ZValue - b3ZValue;

                        resultsBoxX.Text = xResult.ToString();
                        resultsBoxY.Text = yResult.ToString();
                        resultsBoxZ.Text = zResult.ToString();
                        break;
                    case "Scalar":
                        xResult = a1XValue * b1XValue;
                        yResult=a2YValue * b2YValue;
                        zResult= a3ZValue * b3ZValue;
                        resultsBoxX.Text = (xResult + yResult + zResult).ToString();
                        break;
                    case "Cross":
                        xResult = ((a2YValue * b3ZValue)-(a3ZValue*b2YValue));
                        yResult = -1 * ((a1XValue * b3ZValue)-(a3ZValue*b1XValue));
                        zResult = ((a1XValue * b2YValue) - (a2YValue * b1XValue));
                        resultsBoxX.Text = xResult.ToString();
                        resultsBoxY.Text = yResult.ToString();
                        resultsBoxZ.Text = zResult.ToString();
                        break;
                }
                lengthA = Math.Sqrt((a1XValue * a1XValue) + (a2YValue * a2YValue) + (a3ZValue * a3ZValue));
                lengthB = Math.Sqrt((b1XValue * b1XValue) + (b2YValue * b2YValue) + (b3ZValue * b3ZValue));
                lengthABox.Text=lengthA.ToString();
                lengthBBox.Text=lengthB.ToString();
                
            }
            catch (FormatException)
            {
                // если тип преобразовать не смогли
            }
        }

    }
}
