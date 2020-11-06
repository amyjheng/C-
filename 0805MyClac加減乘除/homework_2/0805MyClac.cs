using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("請輸入數值!");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("請輸入數值!");
                return;
            }
            {
                int number1 = int.Parse(textBox1.Text);
                int number2 = int.Parse(textBox2.Text);
                int number3 = number1 + number2;
                //MessageBox.Show(number3.ToString());
                label4.Text = number3.ToString();
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("請輸入數值!");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("請輸入數值!");
                return;
            }
            {
                int number1 = int.Parse(textBox1.Text);
                int number2 = int.Parse(textBox2.Text);
                int number3 = number1 - number2;
                //MessageBox.Show(number3.ToString());
                label4.Text = number3.ToString();
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("請輸入數值!");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("請輸入數值!");
                return;
            }
            {
                int number1 = int.Parse(textBox1.Text);
                int number2 = int.Parse(textBox2.Text);
                int number3 = number1 * number2;
                //MessageBox.Show(number3.ToString());
                label4.Text = number3.ToString();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("請輸入數值!");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("請輸入數值!");
                return;
            }
            {
                int number1 = int.Parse(textBox1.Text);
                int number2 = int.Parse(textBox2.Text);
                int number3 = number1 / number2;
                //MessageBox.Show(number3.ToString());
                label4.Text = number3.ToString();
            }
        }
    }
}
