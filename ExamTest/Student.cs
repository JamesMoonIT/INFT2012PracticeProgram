using System;
using System.Collections.Generic;
using System.Text;

namespace ExamTest
{
    class Student
    {

        private string studentName;

        public Student(string name)
        {
            studentName = name;
        }
        
        public string GetStudentName()
        {
            return studentName;
        }
    }
}
