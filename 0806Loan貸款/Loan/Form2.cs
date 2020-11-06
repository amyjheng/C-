using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        Form3 fr3;
        public Form2()
        {
            InitializeComponent();
        }
        public double monthprice;
        public double totalprice;
        public double monthRate;
        public double per;
        public double perrate;
        public double MonthPer;
        public double money;
        public double year;
        public double price;
        public double pricemoney;
        public double Month;


        private void btn_total_Click(object sender, EventArgs e)
        {
            money = int.Parse(txt_firstMoney.Text);
            year = int.Parse(txt_year.Text);
            per = int.Parse(txt_per.Text);
            perrate = per / 100;
            price = int.Parse(txt_price.Text);
            pricemoney = price - money;
            MonthPer = perrate / 12;
            Month = 12*year;


            monthRate = (Math.Pow(1 + MonthPer, Month) * MonthPer) / ((Math.Pow(1 + MonthPer, Month)) - 1);
            monthprice = (int)Convert.ToInt16(pricemoney * monthRate);
            totalprice = (int)((monthprice * Month));
            MessageBox.Show("總付款額: "+totalprice.ToString());

        }

        private void btn_montth_Click(object sender, EventArgs e)
        {
            money = int.Parse(txt_firstMoney.Text);
            year = int.Parse(txt_year.Text);
            per = int.Parse(txt_per.Text);
            perrate = per / 100;
            price = int.Parse(txt_price.Text);
            pricemoney = price - money;
            MonthPer = perrate / 12;
            Month = 12 * year;


            monthRate = (Math.Pow(1 + MonthPer, Month) * MonthPer) / ((Math.Pow(1 + MonthPer, Month)) - 1);
            monthprice = (int)Convert.ToInt16(pricemoney * monthRate);
            MessageBox.Show("月付款額"+monthprice.ToString());
        }




        private void bnt_report_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Showdata(txt_price.Text, txt_year.Text, txt_per.Text, monthprice.ToString(), totalprice.ToString());
            fr3.Show();
        }

        //private void bnt_report_Click(object sender, EventArgs e)
        //{
        //    fr3 = new Form3();
        //    fr3.Showdata(txt_price.Text, txt_year.Text, txt_per.Text, monthprice.ToString(), totalprice.ToString());
        //    fr3.Showdata();

        //}
    }
}
