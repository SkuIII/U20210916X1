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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double i, j;
            i = double.Parse(textBox1.Text);
            j = double.Parse(textBox2.Text);

            listBox1.Items.Add($"{i} + {j} = {i + j}");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double i, j;
            i = double.Parse(textBox1.Text);
            j = double.Parse(textBox2.Text);

            listBox1.Items.Add($"{i} - {j} = {i - j}");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double i, j;
            i = double.Parse(textBox1.Text);
            j = double.Parse(textBox2.Text);

            listBox1.Items.Add($"{i} / {j} = {i / j}");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double i, j;
            i = double.Parse(textBox1.Text);
            j = double.Parse(textBox2.Text);

            listBox1.Items.Add($"{i} * {j} = {i * j}");
        }
    }
}
