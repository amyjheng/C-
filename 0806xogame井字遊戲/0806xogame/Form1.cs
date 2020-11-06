using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0806xogame
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        public int player = 2;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;


        private void btnExit_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "";
        }

        private void btnclick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (player % 2 == 0)
            {
                button.Text = "X";
                player++;
                turns++;
            }
            else
            {
                button.Text = "O";
                player++;
                turns++;
            }
            if (CheckDraw() == true)
            {
                MessageBox.Show("平手!按下確認重新開始!");
                sd++;
                NewGame();
            }
            if (CheckWinner() == true)
            {
                if (button.Text == "X")
                {
                    MessageBox.Show("X手獲勝!");
                    s1++;
                    NewGame();
               
                }
                else
                {
                    MessageBox.Show("O手獲勝!");
                    s2++;
                    NewGame();
                }
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Xwin.Text = "X:" + s1;
            Owin.Text = "O:" + s2;
            Draw.Text = "Draws:" + sd;

        }
        void NewGame()
        {
            player = 2;
            turns = 0;
            A00.Text = A01.Text = A02.Text = A10.Text
                = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            Xwin.Text = "X:" + s1;
            Owin.Text = "O:" + s2;
            Draw.Text = "Draws:" + sd;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();

        }
        bool CheckDraw()
        {
            if ((turns == 9)&&CheckWinner()==false)
                return true;
            else
                return false;

        }
        bool CheckWinner()
        {
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && A00.Text != "")
                return true;
            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && A10.Text != "")
                return true;
            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && A20.Text != "")
                return true;

            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && A00.Text != "")
                return true;
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
                return true;
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && A02.Text != "")
                return true;

            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && A00.Text != "")
                return true;
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
                return true;
            else
                return false;
        }

    }
}
