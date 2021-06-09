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
        frmHome home = new frmHome();
        const string sUppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string sLowercase = "abcdefghijklmnopqrstuvwxyz";

        public frmIO()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText("../../../import.txt");
            textBox2.Text = content;
        }

        private void btnCypher_Click(object sender, EventArgs e)
        {
            string sPlain = textBox2.Text;
            string sCipher = "", sChar;
            while (sPlain != "")
            {
                sChar = sPlain.Substring(0, 1); // Extract the first character
                sPlain = sPlain.Substring(1); // Remove it from the string
                sCipher = sCipher + shiftCharacter(sChar, 12); // shift character over 12 spaces
            }

            textBox1.Text = sCipher;
        }

        private string shiftCharacter(string sChar, int iShift)
        {
            if (sUppercase.IndexOf(sChar) > -1) // It's an uppercase letter
            {
                return sUppercase.Substring((sUppercase.IndexOf(sChar) + iShift) % 26, 1);
            }
            else if (sLowercase.IndexOf(sChar) > -1) // It's a lowercase letter
            {
                return sLowercase.Substring((sLowercase.IndexOf(sChar) + iShift) % 26, 1);
            }
            else 
            {
                return sChar;  // It's not a letter
            }
        } // end shiftCharacter

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                TextWriter txt = new StreamWriter("../../../export.txt");
                txt.Write(textBox1.Text);
                txt.Close();
                lblFeedback.Text = "Exported Successfully!";
            }
            catch
            {
                lblFeedback.Text = "Could not export file";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Show();
        }
    }
}
