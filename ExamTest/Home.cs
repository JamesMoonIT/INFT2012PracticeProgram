using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExamTest
{
    public partial class frmHome : Form
    {
        frmIO io = new frmIO();
        frmList lt = new frmList();

        public frmHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            io.Show();
            this.Hide();
        }
    }
}
