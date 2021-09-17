using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACMECalcIMPROVED
{
    public partial class Form1 : Form
    {
        CalculatorEngine MyEngine = new CalculatorEngine();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);

            double answer = MyEngine.Add(i, j);

            listBox1.Items.Add($"{i} + {j} = {answer}");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);
            
            double answer = MyEngine.Subtract(i, j);

            listBox1.Items.Add($"{i} - {j} = {answer}");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);

            double answer = MyEngine.Divide(i, j);

            listBox1.Items.Add($"{i} / {j} = {answer}");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);

            double answer = MyEngine.Multiply(i, j);

            listBox1.Items.Add($"{i} * {j} = {answer}");
        }
    }
}
