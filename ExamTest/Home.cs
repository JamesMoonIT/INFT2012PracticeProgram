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
        public frmHome()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmList lt = new frmList();
            lt.Show();
        }
    }
}
