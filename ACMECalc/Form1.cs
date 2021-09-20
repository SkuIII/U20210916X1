using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACMECalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i, j;
            i = double.Parse(textBox1.Text);
            j = double.Parse(textBox2.Text);

            listBox1.Items.Add($"{i} + {j} = {i + j}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double i, j;
            i = double.Parse(textBox1.Text);
            j = double.Parse(textBox2.Text);

            listBox1.Items.Add($"{i} - {j} = {i - j}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double i, j;
            i = double.Parse(textBox1.Text);
            j = double.Parse(textBox2.Text);

            listBox1.Items.Add($"{i} / {j} = {i / j}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double i, j;
            i = double.Parse(textBox1.Text);
            j = double.Parse(textBox2.Text);

            listBox1.Items.Add($"{i} * {j} = {i * j}");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
