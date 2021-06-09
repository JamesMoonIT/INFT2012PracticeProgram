using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExamTest
{
    public partial class frmClassesAndMethods : Form
    {
        frmHome home = new frmHome();
        private const int studentlimit = 99;
        private Student[] students = new Student[studentlimit]; // stores 99 individual Student objects inside students

        public frmClassesAndMethods()
        {
            InitializeComponent();
            students[0] = new Student("James");                 // stores James as student 0
            students[1] = new Student("Anthony");               // stores Anthony as student 1
            students[2] = new Student("Noah");                  // stores Noah as Student 2
            BuildList();                                        // refreshes the left textbox
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < studentlimit; i++)
            {
                if (students[i] == null)
                {
                    students[i] = new Student(txbxStudentName.Text);    // stores the name in textbox to studentname
                    break;  // breaks the for loop
                }
            }
            BuildList();    // refreshes the left textbox
            lblFeedback.Text = "Student added Successfully!";
        }

        private void BuildList()
        {
            txbxStudentList.Text = "";  // resets the left textbox
            string name = "";
            for (int i = 0; i < studentlimit; i++)
            {
                if (students[i] != null)    // if student object doesnt exist
                {
                    name = students[i].GetStudentName();
                    txbxStudentList.AppendText(name);
                    txbxStudentList.AppendText(Environment.NewLine);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < studentlimit; i++)
            {
                if (students[i].GetStudentName() == txbxStudentName.Text)   // if student name matches the name in the textbox
                {
                    students[i] = null;     // removes Student from students (DOES NOT DELETE, ONLY REMOVES REFERENCE)
                    break;      // breaks for loop
                }
            }
            BuildList();    // refresh left textbox
            lblFeedback.Text = "Student removed Successfully!";
        }
    }
}
