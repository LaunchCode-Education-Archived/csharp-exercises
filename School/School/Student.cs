using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Student
    {

        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int numberOfCredits,
                        double gpa)
        {
            StudentId = nextStudentId++;
            Name = name;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name)
            : this(name, 0, 0) { }
    }

}

}
