﻿using System;
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
        private Student[] students = new Student[studentlimit]; // default cos fuck it

        public frmClassesAndMethods()
        {
            InitializeComponent();
            students[0] = new Student("James");
            students[1] = new Student("Anthony");
            students[2] = new Student("Noah");
            BuildList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < studentlimit; i++)
            {
                if (students[i] == null)
                {
                    students[i] = new Student(txbxStudentName.Text);
                    break;
                }
            }
            BuildList();
            lblFeedback.Text = "Student added Successfully!";
        }

        private void BuildList()
        {
            txbxStudentList.Text = "";
            string name = "";
            for (int i = 0; i < studentlimit; i++)
            {
                if (students[i] != null)
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
                if (students[i].GetStudentName() == txbxStudentName.Text)
                {
                    students[i] = null;
                    break;
                }
            }
            BuildList();
            lblFeedback.Text = "Student removed Successfully!";
        }
    }
}
