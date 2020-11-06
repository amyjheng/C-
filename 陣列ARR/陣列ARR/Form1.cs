using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 陣列ARR
{
    public partial class Form1 : Form
    {
        public int[] arr0711 { get; }
        public string[] arr0711_str { get; }
        public Form1()
        {
            arr0711 = new int[10] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 588 };
            arr0711_str = new string[8] { "teacher張", "Emma", "李知恩", "J40", "Candy", "Cindy", "Coco", "MickyCover" };
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            bool b = int.TryParse(txtNumber.Text, out int number);
            switch (b)
            {
                case false:
                    MessageBox.Show("請輸入數值");
                    break;
                case true:
                    if (number % 2 == 0)
                    {
                        labResult.Text = $"輸入的數{number}為偶數";
                    }
                    else
                    {
                        labResult.Text = $"輸入的數{number}為奇數";
                    }
                    break;
            }
        }

        private void btnArrtotal_Click(object sender, EventArgs e)
        {
            int odd = 0;
            int even = 0;
            foreach (int arr in arr0711)
            {
                if (arr % 2 == 0)
                {
                    even += 1;
                }
                else
                {
                    odd += 1;
                }
            }
            labResult.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 588 ]\n" +
                $"奇數共{odd}\n" +
                $"偶數共{even}";
        }

        private void btnLongname_Click(object sender, EventArgs e)
        {
            int max = arr0711_str[0].Length;
            int index = 0;

            for (int i = 0; i < arr0711_str.Length; i++)
            {
                if (max < arr0711_str[i].Length)
                {
                    max = arr0711_str[i].Length;
                    index = i;
                }
            }

            string name = arr0711_str[index];
            labResult.Text = $"陣列arr0711_str [teacher張,Emma,李知恩,J40,Candy,Cindy,Coco,MickyCover]\n" +
                $"{name}";
        }

        private void btArrXueC_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (string str in arr0711_str)
            {
                if (str.Contains("c") == true || str.Contains("C") == true)
                {
                    count += 1;
                }
            }

            labResult.Text = $"陣列arr0711_str [teacher張,Emma,李知恩,J40,Candy," +
                $"Cindy,Coco,MickyCover]\n" +
                $"有 C 及 c 的名字共有{count}個";
        }

        private void btntwoArrayside1_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];
            labResult.Text = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i > 0 && j > 0 && i < 9 && j < 9)
                    {
                        arr[i, j] = 0;
                    }
                    else
                    {
                        arr[i, j] = 1;
                    }
                    labResult.Text += $"{arr[i, j]}";
                }
                labResult.Text += $"\n";
            }
        }

        private void btntwoArrayside0_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];
            labResult.Text = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i > 0 && j > 0 && i < 9 && j < 9)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }
                    labResult.Text += $"{arr[i, j]}";
                }
                labResult.Text += $"\n";

            }
        }

        private void btnArr0711MaxMin_Click(object sender, EventArgs e)
        {
            int max = arr0711.Max();
            int min = arr0711.Min();

            labResult.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 588 ]\n" +
                             $"最大值為{max}\n" +
                             $"最小值為{min}";
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int n1 = 100;
            int n2 = 200;
            int n3 = 0;
            n1 = n3;
            n2 = n1;
            n1 = n2;

           
            labResult.Text = $"換位前n1=100,n2=200\n" +
                $"換位後n1={n1},n2={n2}";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int SU = arr0711.Sum();
            labResult.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 588 ]\n" +
                $"加總為{SU}";

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int MA = arr0711.Max();
            labResult.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 588 ]\n" +
                $"最大值為{MA}";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int MI = arr0711.Min();
            labResult.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 588 ]\n" +
                $"最小值為{MI}";
        }

        private void btn1010_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];
            labResult.Text = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = 1;
                    if (j > 0 && arr[i, j - 1] == 0)
                    {
                        arr[i, j] = 1;
                    }
                    else if (j > 0 && arr[i, j - 1] == 1)
                    {
                        arr[i, j] = 0;
                    }

                    if (i > 0 && arr[i - 1, j] == 0)
                    {
                        arr[i, j] = 1;
                    }
                    else if (i > 0 && arr[i - 1, j] == 1)
                    {
                        arr[i, j] = 0;
                    }
                    labResult.Text += $"{arr[i, j]}";
                }
                labResult.Text += $"\n";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labResult.Text = "";
        }
    }
}

