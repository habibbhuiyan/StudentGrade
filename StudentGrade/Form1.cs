using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double math, science, english, total, avg;
            string grade;

            math = int.Parse(txtMath.Text);
            science = int.Parse(txtSci.Text);
            english = int.Parse(txtEng.Text);


            total = math + science + english;

            txtTotal.Text = total.ToString();

            avg = total / 3;

            txtAvg.Text = avg.ToString();

            if(avg >= 75)
            {
                grade = "A";
            }
            else if (avg >= 65)
            {
                grade = "B";
            }
            else if (avg >= 55)
            {
                grade = "C";
            }
            else if (avg >= 45)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }


            txtGrade.Text = grade;




        }

    }
}
