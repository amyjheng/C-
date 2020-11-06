using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class homework_hello : Form
    {
        public homework_hello()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = name1.Text;
            string englishname = englishname1.Text;
            string gender = gender1.Text;
            string starsign = starsign1.Text;
            MessageBox.Show("Hello!我是" + name + "\r\n" + "英文名字是" + englishname + "\r\n" + "性別是" + gender + "\r\n" + "星座是" + starsign + "\r\n"+"很高興認識你");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = name1.Text;
            string englishname = englishname1.Text;
            string gender = gender1.Text;
            string starsign = starsign1.Text;
            MessageBox.Show("Hello!我是" + name + "\r\n" + "英文名字是" + englishname + "\r\n" + "性別是" + gender + "\r\n" + "星座是" + starsign + "\r\n" + "很高興認識你");
        }
    }
}
