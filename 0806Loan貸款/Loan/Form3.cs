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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

  

        internal void Showdata(String price, String year, String rate, String monpay, String total)
        {
            txt_money3.Text = price.ToString();
            txt_monthprice3.Text = monpay.ToString();
            txt_rate3.Text = rate.ToString();
            txt_total.Text = total.ToString();
            txt_year3.Text = year.ToString();


        }

        
    }
}
