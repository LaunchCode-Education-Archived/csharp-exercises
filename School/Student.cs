using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        public string Name { get; private set; } = "";
        public int StudentID { get; private set; } = 0;
        public int NumberOfCredits { get; private set; } = 0;
        public double GPA { get; private set; } = 0;

        public Student(int studentID, string name, int numberOfCredits)
        {
            StudentID = studentID;
            Name = name;
            NumberOfCredits = numberOfCredits;
        }
    }
}
