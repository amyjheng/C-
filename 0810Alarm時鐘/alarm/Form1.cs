using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hour;
        int min;
        int sec;
        Color col;

        private void timer1_Tick(object sender, EventArgs e)
        {
            hour = DateTime.Now.Hour;
            min = DateTime.Now.Minute;
            sec = DateTime.Now.Second;
            labTime.Text = $"{hour.ToString()}:{min.ToString()}:{sec.ToString()}";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string time = $"{hour}:{min}:{sec}";
            if (time == txtset.Text)
            {
                Task.Run(() =>
                {
                    col = System.Drawing.Color.Beige;
                    Task.Delay(200).Wait();

                }).ContinueWith((task) => {
                    col = System.Drawing.SystemColors.ActiveCaptionText;
                    Task.Delay(200).Wait();
                });

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            BackColor = col;
        }
    }
}
