using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO; // required

namespace ExamTest
{
    public partial class frmIO : Form
    {
        public frmIO()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("import.txt");
            textBox2.Text = content;
        }

        private void btnCypher_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("export.txt");
            txt.Write(textBox1.Text);
            txt.Close();
        }
    }
}
