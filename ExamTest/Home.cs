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
            frmList ListForm = new frmList();
            ListForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmIO IOForm = new frmIO();
            IOForm.Show();
            this.Hide();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            frmClassesAndMethods FormCAM = new frmClassesAndMethods();
            FormCAM.Show();
            this.Hide();
        }
    }
}
