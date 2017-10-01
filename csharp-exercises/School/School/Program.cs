using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class Design: In Visual Studio, create a new console 
            //project named School in the csharp-exercises solution 
            //that has the class Student that was discussed in the 
            //reading for this class. Add the properties that we 
            //looked at, and think about the access level each should 
            //have.Reduce the access level of at least one setter to 
            //less than public. Make sure you can defend the 
            //reasoning behind your choice.

            Student steven = new Student("Steven" , 103217);
            Console.WriteLine(steven.Name);
            Console.WriteLine(steven.StudentId);
            steven.Gpa = 3.5;
            steven.NumberOfCredits = 65;
            Console.WriteLine(steven.NumberOfCredits);
            Console.WriteLine(steven.Gpa);
            Console.ReadLine();
        }
        
    }

    public class Student
    {
     public string Name { get; set; }
     public int StudentId { get; set; }
     public int NumberOfCredits { get; internal set; }
     public double Gpa { get; set; }

            public Student(string name, int studentId,
                int numberOfCredits, double gpa)
            {
                Name = name;
                StudentId = studentId;
                NumberOfCredits = numberOfCredits;
                Gpa = gpa;
            }

            public Student(string name, int studentId)
            :this(name,studentId,0,0.0) {}
    }

    //More class design : In the School project, create a class 
    //named Course with at least three properties.Before diving 
    //into Visual Studio, use pen and paper to work through what 
    //these might be, including the data type, access level, and 
    //whether it makes sense for any of them to be readonly or 
    //constants.At least one of your fields should be a List or 
    //Dictionary, and you should use your Student class.

    public class Course
    {
        // Three properties : Course Name, Number and Confirmed Registration
        // Course Name and Number can be constants therefore capital and underlined
        // Confirmed Registration should be a boolean

        public string CourseName { get; internal set; }
        public int CourseNumber { get; internal set; }
        private Dictionary<Student,bool> Registered = new Dictionary<Student, bool>(); 
            
            public Course(string coursename, int coursenumber, Dictionary<Student,bool> registered)
        {
            CourseName = coursename;
            CourseNumber = coursenumber;
            Registered = registered;
        }

    }
}
