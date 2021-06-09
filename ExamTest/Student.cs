using System;
using System.Collections.Generic;
using System.Text;

namespace ExamTest
{
    class Student
    {
        public int studentNumber;
        private string studentName;

        public Student(string name)
        {
            studentName = name;
            studentNumber = studentNumber++;
        }
        
        public string GetStudentName()
        {
            return studentName;
        }
    }
}
