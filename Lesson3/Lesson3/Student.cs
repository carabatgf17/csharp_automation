using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }

    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException()
        {

        }

        public InvalidStudentNameException(string name)
            : base(String.Format("Invalid Student Name: {0}", name))
        {

        }

    }

}
