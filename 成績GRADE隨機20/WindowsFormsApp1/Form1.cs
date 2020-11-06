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
    public partial class Form1 : Form
    {
        ArrayList lstScore = new ArrayList();
        private void btn_add_Click(object sender, EventArgs e)
        {
            stcScore Score;
            Score.studentName = txt_name.Text;
            Score.chinessScore = int.Parse(txt_chiness.Text);
            Score.englishScore = int.Parse(txt_english.Text);
            Score.mathScore = int.Parse(txt_math.Text);
            Score.totalScore= Score.chinessScore + Score.englishScore + Score.mathScore;
            Score.avgScore= (Score.chinessScore + Score.englishScore + Score.mathScore)/3;

            lstScore.Add(Score);

            



        }
    }
}



//stcEmployee emp;
//emp.EmployeeName = txtEmpName.Text;
//            emp.Age = int.Parse(txtAge.Text);
//emp.HireDate = DateTime.Now;
//            emp.EmployeeRole = myRole.User;

//            lsEmp.Add(emp);

//            labShow.Text = "員工";

//            for(int i = 0; i<lsEmp.Count; i++)
//            {
//                labShow.Text += $"\n------------" +
//                    $"\n員工姓名：{((stcEmployee)lsEmp[i]).EmployeeName}" +
//                    $"\n員工年齡：{((stcEmployee)lsEmp[i]).Age}";
//            }

//            labShow.Text += $"=====================\n員工人數：{lsEmp.Count} 人";