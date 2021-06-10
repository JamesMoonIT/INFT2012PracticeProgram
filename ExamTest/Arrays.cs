using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExamTest
{
    public partial class frmArrays : Form
    {
        frmHome home = new frmHome();
        private const int limit = 99;
        private int[] iNumber = new int[limit];

        public frmArrays()
        {
            InitializeComponent();
            iNumber[0] = 566;
            iNumber[1] = 856;
            iNumber[2] = 346;
            iNumber[56] = 69;
            BuildList();
        }

        private void SortList()
        {
            int iBest = iNumber[0];
            int i = 1;
            while (i < iNumber.Length)
            {
                if (iNumber[i] < iBest) iBest = iNumber[i];
                i = i + 1;
            }
            int iAnswer = iBest;
            lblFeedback.Text = Convert.ToString(iAnswer);
        }

        private void BuildList()
        {
            textBox1.Text = "";
            int number = 0;
            for (int i = 0; i < limit; i++)
            {
                if (iNumber[i] != 0)
                {
                    number = iNumber[i];
                    textBox1.AppendText(Convert.ToString(number));
                    textBox1.AppendText(Environment.NewLine);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox2.Text);
            for (int i = 0; i < limit; i++)
            {
                if (iNumber[i] == 0)
                {
                    iNumber[i] = number;
                    break;
                }
            }
            BuildList();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox2.Text);
            for (int i = 0; i < limit; i++)
            {
                if (iNumber[i] == number)
                {
                    iNumber[i] = 0;
                    break;
                }
            }
            BuildList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SortList();
        }
    }
}
