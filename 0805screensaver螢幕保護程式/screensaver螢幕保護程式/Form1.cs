using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screensaver螢幕保護程式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString(); 

            
            label1.Top = (this.Height - label1.Height) / 2 - label1.Height;
            label1.Left = (this.Width - label1.Width) / 2;
        }

        int moveX = 10;
        int moveY = 8;
        int t = 1;


        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            this.label1.Left += moveX;
            this.label1.Top += moveY;
            if (this.Width < this.label1.Left + this.label1.Width || this.label1.Left < 0)
            {
                moveX = -moveX;
                t = -t;
            }
            if (this.Height < this.label1.Top + this.label1.Height || this.label1.Top < 0)
            {
                moveY = -moveY;
                t = -t;
            }


            if (t == 1)
            { this.label1.Text = "2020"; }
            else
            { this.label1.Text = "???"; }
            this.label1.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));//设置字体颜色随时间随机改变

        }

        private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //   
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            Application.Exit();
        }

        private void timerShowtime_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
       




    }
}