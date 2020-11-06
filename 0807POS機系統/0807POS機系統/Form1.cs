using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0807POS機系統
{
    public partial class Form1 : Form
    {
        int count = 0;
        double total;
        string a;
        string b;
        string c;
        string d;
        string ee;
        int beer_count=0;
        int teqi_count = 0;
        int whis_count = 0;
        int wine_count= 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void beer_Click(object sender, EventArgs e)
        {
            count++;
            a = "\n啤酒Beer"+"x"+beer_count +"共NT$"+ (120 * beer_count);
            total += 120;
            txtPrice.Text = total.ToString();
            ee = a + b + c + d;
            lablist.Text = ee;
            
        }

        private void teqi_Click(object sender, EventArgs e)
        {
            count++;
            b = "\n龍舌蘭Tequila" + "x" + teqi_count + "共NT$" + (180 * teqi_count);
            total += 180;
            txtPrice.Text = total.ToString();
            ee = a + b + c + d;
            lablist.Text = ee;

        }

        private void whis_Click(object sender, EventArgs e)
        {
            count++;
            c = "\n威士忌Whisky" + "x" + whis_count + "共NT$" + (350 * whis_count);
            total += 350;
            txtPrice.Text = total.ToString();
            ee = a + b + c + d;
            lablist.Text = ee;

        }

        private void wine_Click(object sender, EventArgs e)
        {
            count++;
            d = "\n紅酒Wine" + "x" + wine_count + "共NT$" + (320 * wine_count);
            total += 320;
            txtPrice.Text = total.ToString();
            ee = a + b + c + d;
            lablist.Text = ee;
        }
        
        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach (var i in Controls)
            {
                TextBox tb = i as TextBox;
                if (tb != null) tb.Text = "NT$0";
            }
            
           int count = 0;
           lablist.Text = ("尚未點餐");
          beer_count = 0;
          teqi_count = 0;
          whis_count = 0;
          wine_count = 0;
          total = 0;
          a = "";
          b = "";
          c = "";
          d = "";
                      
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (total <= 0)
            {
                MessageBox.Show("您尚未點餐!", 
                    "提示訊息",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("總金額為:NT$"+ txtPrice.Text + "元","確認付款", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            }
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            if (total <= 0)
            {
                MessageBox.Show("您尚未點餐!",
                    "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double c = total * 0.9;
                MessageBox.Show("總金額為:NT$"+ txtPrice.Text + "元"+"\n 折扣後金額:NT$" + c , "確認付款",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            }
        }
    }
}
