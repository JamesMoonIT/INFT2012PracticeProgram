using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamTest
{
    public partial class frmList : Form
    {
        List<string> myList = new List<string>();

        public frmList()
        {
            InitializeComponent();
            myList.Add("John");
            myList.Add("Ann");
            myList.Add("Noah");
            myList.Add("Anthony");
            myList.Add("James");
            BuildList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myList.Add(txbxNewValue.Text);
            BuildList();
        }

        private void BuildList()
        {
            txbxList.Text = null;
            string name = "";
            for (int i = 0; i < myList.Count; i++)
            {
                name = myList[i];
                txbxList.AppendText(name);
                txbxList.AppendText(Environment.NewLine);
            }
            int listLen = myList.Count();
            lblListSize.Text = "List Size: " + Convert.ToString(listLen);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            myList.Remove(txbxNewValue.Text);
            BuildList();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            myList.Sort();
            BuildList();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            myList.Reverse();
            BuildList();
        }
    }
}
