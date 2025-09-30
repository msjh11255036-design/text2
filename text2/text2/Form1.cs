using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ans = 0;

            for (double i = 0.5; i <= 10; i = i + 0.5)
            {
                ans = ans + i;
                textBox1.Text = ans.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double ans = 0;

            for (double i = 0.5; i <= 10; i=i+0.5)
            {
                ans = ans + i;
                textBox1.Text = ans.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ans2 = 0;

            for (int s = 11; s >= 1; s -= 2)
            {
                ans2 = ans2 + s;
                textBox1.Text = ans2.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ans = 0;
            double star = double.Parse(textBox2.Text);
            double end = double.Parse(textBox3.Text);
            double interval = double.Parse(textBox4.Text);

            for (double i = star; i <= end; i = i + interval)
            {
                ans = ans + i;
                textBox1.Text = ans.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
