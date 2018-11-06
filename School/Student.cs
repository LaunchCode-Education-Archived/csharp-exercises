using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        private Student(string name, int studentId,
                int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId) 
            : this(name, studentId, 0, 0) { }

        public Student(string name) : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public override String ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + 
                ", GPA: " + Gpa + ")";
        }

        public override bool Equals(Object o)
        {
            // Student studentObj = (Student) o;
            Student studentObj = o as Student;
            return StudentId == studentObj.StudentId;
        }
    }
}
