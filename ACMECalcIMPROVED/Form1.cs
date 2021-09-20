using System;
using System.Windows.Forms;

namespace ACMECalcIMPROVED
{
    public partial class Form1 : Form
    {
        CalculatorEngine MyEngine = new CalculatorEngine();
        public Form1()
        {
            InitializeComponent();

            // Instantiate new events
            btnAdd.Click += new EventHandler(CalculationHandler);
            btnSubtract.Click += new EventHandler(CalculationHandler);
            btnDivision.Click += new EventHandler(CalculationHandler);
            btnMultiply.Click += new EventHandler(CalculationHandler);

            textBox1.KeyPress += new KeyPressEventHandler(KeyPressControl);
            textBox2.KeyPress += new KeyPressEventHandler(KeyPressControl);

        }
        private void KeyPressControl(object sender, KeyPressEventArgs e)
        {
            // If key is not 0-9 or backspace don't let it through
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (((short)e.KeyChar) != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void CalculationHandler(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);

            string operation = btn.Text;
            double answer = 0;

            // Commented out try catch statement
            // Double has an infinite value that outputs instead of an exception
            // when something is divided by 0

            //try
            //{
            switch (operation)
            {
                case "+":
                    answer = MyEngine.Add(i, j);
                    break;
                case "-":
                    answer = MyEngine.Subtract(i, j);
                    break;
                case "/":
                    answer = MyEngine.Divide(i, j);
                    break;
                case "*":
                    answer = MyEngine.Multiply(i, j);
                    break;
            }

            PresentResult(i, j, answer, operation);
            //}
            //catch (DivideByZeroException)
            //{
            //    MessageBox.Show("Oops! You can't divide anything with 0");
            //    textBox2.Focus();
            //}
        }

        private void PresentResult(double i, double j, double answer, string operation)
        {
            listBox1.Items.Add($"{i} {operation} {j} = {answer}");
        }
    }
}