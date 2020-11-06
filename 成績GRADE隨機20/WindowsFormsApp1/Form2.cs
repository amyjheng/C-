using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ArrayList lstScore = new ArrayList();
        ListBox listBox = new ListBox();
        Random Rnd = new Random();
        int i = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {

            int price;
            bool isCovert = int.TryParse(txt_chiness.Text, out price);
            bool isCovert2 = int.TryParse(txt_english.Text, out price);
            bool isCovert3 = int.TryParse(txt_math.Text, out price);

            if (isCovert == false )
            {
                MessageBox.Show("國文成績請輸入正確的數字格式");
                txt_chiness.Clear();
                txt_chiness.Focus();
                return;
            }
            else if(isCovert2 == false)
            {
                MessageBox.Show("英文成績請輸入正確的數字格式");
                txt_english.Clear();
                txt_english.Focus();
                return;
            }
            else if(isCovert3 == false)
            {
                MessageBox.Show("數學成績請輸入正確的數字格式");
                txt_math.Clear();
                txt_math.Focus();
                return;

            }

            
            

            stcScore Score;
            Score.studentName = txt_name.Text;
            Score.chinessScore = double.Parse(txt_chiness.Text);
            Score.englishScore = double.Parse(txt_english.Text);
            Score.mathScore = double.Parse(txt_math.Text);
            Score.totalScore = Score.chinessScore + Score.englishScore + Score.mathScore;
            Score.avgScore = (Score.chinessScore + Score.englishScore + Score.mathScore) / 3;
            double avgScore2 = Math.Round(Score.avgScore, 2, MidpointRounding.AwayFromZero);
            lstScore.Add(Score);

            double[] scoreArr = new double[3] { Score.chinessScore, Score.englishScore, Score.mathScore };
            Array.Sort(scoreArr);
            //MessageBox.Show(scoreArr[0].ToString());
            if (scoreArr[0] == Score.chinessScore)
            {
                if (scoreArr[2] == Score.englishScore)
                {
                    listBox1.Items.Add("   " + Score.studentName + "         " + Score.chinessScore + "         "
                        + Score.englishScore
                + "        " + Score.mathScore + "          " + Score.totalScore + "         " + avgScore2
                + "  英文" + Score.englishScore + "  國文" + Score.chinessScore);
                }
                else if (scoreArr[2] == Score.mathScore)
                {
                    listBox1.Items.Add("   " + Score.studentName + "         " + Score.chinessScore + "         "
                                           + Score.englishScore
                                   + "        " + Score.mathScore + "          " + Score.totalScore + "         " + avgScore2
                                   + "  英文" + Score.mathScore + "  國文" + Score.chinessScore);
                }

            }
            else if (scoreArr[0] == Score.englishScore)
            {
                if (scoreArr[2] == Score.chinessScore)
                {
                    listBox1.Items.Add("   " + Score.studentName + "         " + Score.chinessScore + "         "
                                          + Score.englishScore
                                  + "        " + Score.mathScore + "          " + Score.totalScore + "         " + avgScore2
                                  + "  國文" + Score.chinessScore + "  英文" + Score.englishScore);
                }
                else if (scoreArr[2] == Score.mathScore)
                {
                    listBox1.Items.Add("   " + Score.studentName + "         " + Score.chinessScore + "         "
                                          + Score.englishScore
                                  + "        " + Score.mathScore + "          " + Score.totalScore + "         " + avgScore2
                                  + "  數學" + Score.mathScore + "  英文" + Score.englishScore);
                }
            }
            else if (scoreArr[0] == Score.mathScore)
            {

                if (scoreArr[2] == Score.chinessScore)
                {
                    listBox1.Items.Add("   " + Score.studentName + "         " + Score.chinessScore + "         "
                                          + Score.englishScore
                                  + "        " + Score.mathScore + "          " + Score.totalScore + "         " + avgScore2
                                  + "  國文" + Score.chinessScore + "  數學" + Score.mathScore);
                }
                else if (scoreArr[2] == Score.englishScore)
                {
                    listBox1.Items.Add("   " + Score.studentName + "         " + Score.chinessScore + "         "
                                          + Score.englishScore
                                  + "        " + Score.mathScore + "          " + Score.totalScore + "         " + avgScore2
                                  + "  英文" + Score.englishScore + "  數學" + Score.mathScore);
                }
            }
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            btn_cal.Enabled = true;
        }

        //listBox1.Items.Add("   " + Score.studentName + "         " + Score.chinessScore + "         " + Score.englishScore
        //    + "        " + Score.mathScore + "          " + Score.totalScore + "         " + avgScore2);

        

        

        private void btn_addRandom_Click(object sender, EventArgs e)
        {

            int itemFinal =listBox1.SelectedIndex;
            int itemFina2 = itemFinal + 1;
            //MessageBox.Show(itemFinal.ToString());

            stcScore Score;
            Score.studentName = itemFina2.ToString();
            Score.chinessScore = Rnd.Next(0, 100);
            Score.englishScore = Rnd.Next(0, 100);
            Score.mathScore = Rnd.Next(0, 100);
            Score.totalScore = Score.chinessScore + Score.englishScore + Score.mathScore;
            Score.avgScore = (Score.chinessScore + Score.englishScore + Score.mathScore) / 3;
            double avgScore2 = Math.Round(Score.avgScore, 2, MidpointRounding.AwayFromZero);
            lstScore.Add(Score);

            double[] scoreArr = new double[3] { Score.chinessScore, Score.englishScore, Score.mathScore };
            Array.Sort(scoreArr);
            //MessageBox.Show(scoreArr[0].ToString());
            if (scoreArr[0] == Score.chinessScore)
            {
                if (scoreArr[2] == Score.englishScore)
                {
                    listBox1.Items.Add("   " + Score.studentName + "         " + Score.chinessScore + "         "
                        + Score.englishScore
                + "        " + Score.mathScore + "          " + Score.totalScore + "         " + avgScore2
                + "  英文" + Score.englishScore + "  國文" + Score.chinessScore);
                }
                else if (scoreArr[2] == Score.mathScore)
                {
                    listBox1.Items.Add("   " + Score.studentName + "         " + Score.chinessScore + "         "
                                           + Score.englishScore
                                   + "        " + Score.mathScore + "          " + Score.totalScore + "         " + avgScore2
                                   + "  英文" + Score.mathScore + "  國文" + Score.chinessScore);
                }

            }
            else if (scoreArr[0] == Score.englishScore)
            {
                if (scoreArr[2] == Score.chinessScore)
                {
                    listBox1.Items.Add("   " + Score.studentName + "         " + Score.chinessScore + "         "
                                          + Score.englishScore
                                  + "        " + Score.mathScore + "          " + Score.totalScore + "         " + avgScore2
                                  + "  國文" + Score.chinessScore + "  英文" + Score.englishScore);
                }
                else if (scoreArr[2] == Score.mathScore)
                {
                    listBox1.Items.Add("   " + Score.studentName + "         " + Score.chinessScore + "         "
                                          + Score.englishScore
                                  + "        " + Score.mathScore + "          " + Score.totalScore + "         " + avgScore2
                                  + "  數學" + Score.mathScore + "  英文" + Score.englishScore);
                }
            }
            else if (scoreArr[0] == Score.mathScore)
            {

                if (scoreArr[2] == Score.chinessScore)
                {
                    listBox1.Items.Add("   " + Score.studentName + "         " + Score.chinessScore + "         "
                                          + Score.englishScore
                                  + "        " + Score.mathScore + "          " + Score.totalScore + "         " + avgScore2
                                  + "  國文" + Score.chinessScore + "  數學" + Score.mathScore);
                }
                else if (scoreArr[2] == Score.englishScore)
                {
                    listBox1.Items.Add("   " + Score.studentName + "         " + Score.chinessScore + "         "
                                          + Score.englishScore
                                  + "        " + Score.mathScore + "          " + Score.totalScore + "         " + avgScore2
                                  + "  英文" + Score.englishScore + "  數學" + Score.mathScore);
                }
            }
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            btn_cal.Enabled = true;
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            stcScore Score;
            Score.studentName = "";
            Score.chinessScore = 0;
            Score.englishScore = 0;
            Score.mathScore = 0;
            Score.totalScore = 0;
            Score.avgScore = 0;
            double avgScore2 = 0;
            listBox1.Items.Clear();
            lab_calAll.Text = "";

            btn_add.Enabled = true;
            btn_addRandom.Enabled = true;
            btn_twentyAdd.Enabled = true;
        }

        private void btn_twentyAdd_Click(object sender, EventArgs e)
        {
            for(int i=0; i<=20; i++)
            {
                int itemFinal = listBox1.SelectedIndex;
                int itemFina2 = itemFinal + 1;
                //MessageBox.Show(itemFinal.ToString());

                stcScore Score;
                Score.studentName = itemFina2.ToString();
                Score.chinessScore = Rnd.Next(0, 100);
                Score.englishScore = Rnd.Next(0, 100);
                Score.mathScore = Rnd.Next(0, 100);
                Score.totalScore = Score.chinessScore + Score.englishScore + Score.mathScore;
                Score.avgScore = (Score.chinessScore + Score.englishScore + Score.mathScore) / 3;
                double avgScore2 = Math.Round(Score.avgScore, 2, MidpointRounding.AwayFromZero);
                lstScore.Add(Score);

                double[] scoreArr = new double[3] { Score.chinessScore, Score.englishScore, Score.mathScore };
                Array.Sort(scoreArr);
                //MessageBox.Show(scoreArr[0].ToString());
                if (scoreArr[0] == Score.chinessScore)
                {
                    if (scoreArr[2] == Score.englishScore)
                    {
                        listBox1.Items.Add("   " + Score.studentName + "         " + Score.chinessScore + "         "
                            + Score.englishScore
                    + "        " + Score.mathScore + "          " + Score.totalScore + "         " + avgScore2
                    + "  英文" + Score.englishScore + "  國文" + Score.chinessScore);
                    }
                    else if (scoreArr[2] == Score.mathScore)
                    {
                        listBox1.Items.Add("   " + Score.studentName + "         " + Score.chinessScore + "         "
                                               + Score.englishScore
                                       + "        " + Score.mathScore + "          " + Score.totalScore + "         " + avgScore2
                                       + "  英文" + Score.mathScore + "  國文" + Score.chinessScore);
                    }

                }
                else if (scoreArr[0] == Score.englishScore)
                {
                    if (scoreArr[2] == Score.chinessScore)
                    {
                        listBox1.Items.Add("   " + Score.studentName + "         " + Score.chinessScore + "         "
                                              + Score.englishScore
                                      + "        " + Score.mathScore + "          " + Score.totalScore + "         " + avgScore2
                                      + "  國文" + Score.chinessScore + "  英文" + Score.englishScore);
                    }
                    else if (scoreArr[2] == Score.mathScore)
                    {
                        listBox1.Items.Add("   " + Score.studentName + "         " + Score.chinessScore + "         "
                                              + Score.englishScore
                                      + "        " + Score.mathScore + "          " + Score.totalScore + "         " + avgScore2
                                      + "  數學" + Score.mathScore + "  英文" + Score.englishScore);
                    }
                }
                else if (scoreArr[0] == Score.mathScore)
                {

                    if (scoreArr[2] == Score.chinessScore)
                    {
                        listBox1.Items.Add("   " + Score.studentName + "         " + Score.chinessScore + "         "
                                              + Score.englishScore
                                      + "        " + Score.mathScore + "          " + Score.totalScore + "         " + avgScore2
                                      + "  國文" + Score.chinessScore + "  數學" + Score.mathScore);
                    }
                    else if (scoreArr[2] == Score.englishScore)
                    {
                        listBox1.Items.Add("   " + Score.studentName + "         " + Score.chinessScore + "         "
                                              + Score.englishScore
                                      + "        " + Score.mathScore + "          " + Score.totalScore + "         " + avgScore2
                                      + "  英文" + Score.englishScore + "  數學" + Score.mathScore);
                    }
                }
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                btn_cal.Enabled = true;

            }
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
       
            int itemFinal = listBox1.SelectedIndex;
            int itemFina2 = itemFinal + 1;
            double englishTotal = 0;
            double chinessTotal = 0;
            double mathTotal = 0;
            double[] englishArr = new double[itemFina2];
            double[] chinesshArr = new double[itemFina2];
            double[] mathArr = new double[itemFina2];



            for (int i=0; i< itemFina2; i++)
            { 
                englishTotal += ((stcScore)lstScore[i]).englishScore;
                englishArr[i] +=((stcScore)lstScore[i]).englishScore;
                chinessTotal += ((stcScore)lstScore[i]).chinessScore;
                chinesshArr[i] += ((stcScore)lstScore[i]).chinessScore;
                mathTotal += ((stcScore)lstScore[i]).mathScore;
                mathArr[i] += ((stcScore)lstScore[i]).mathScore;

            }
            double englishAvg = Math.Round(englishTotal / itemFina2, 2, MidpointRounding.AwayFromZero); ;
            double chinessAvg = Math.Round(chinessTotal / itemFina2, 2, MidpointRounding.AwayFromZero); ;
            double mathAvg = Math.Round(mathTotal / itemFina2, 2, MidpointRounding.AwayFromZero); ;

            Array.Sort(englishArr);
            Array.Sort(chinesshArr);
            Array.Sort(mathArr);

            lab_calAll.Text = $"總分: {englishTotal}   {chinessTotal}   {mathTotal}" +
                $"\n平均: {englishAvg}   {chinessAvg}   {mathAvg}" +
                $"\n最高分: {englishArr[itemFinal]}   {chinesshArr[itemFinal]}   {mathArr[itemFinal]}" +
                $"\n最低分:{englishArr[0]}   {chinesshArr[0]}   {mathArr[0]}";

            //MessageBox.Show(englishArr[0].ToString());
            btn_add.Enabled = false;
            btn_addRandom.Enabled = false;
            btn_cal.Enabled = false;
            btn_twentyAdd.Enabled = false;
        }

        
    }
}

