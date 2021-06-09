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
        private Student[] students = new Student[3];
        private int numberOfStudents = 0;

        public frmClassesAndMethods()
        {
            InitializeComponent();
            students[0] = AddStudent("James");
            AddStudent("Anthony");
            AddStudent("Noah");
            for (int i = 0; i < numberOfStudents; i++)
            {
                txbxStudentList.Text += students[i].GetStudentName();
            }
        }

        private void AddStudent(string name)
        {
            int coedeunt = 0;
            while (students[count] != null)
            {
                students[count] = new Student(name);
                count++;
            }
        }

        private void RemoveStudent(string name)
        {
            numberOfStudents--;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudent(txbxStudentName.Text);
        }
    }
}
