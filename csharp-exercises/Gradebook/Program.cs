using System;
using System.Collections.Generic;
using System.Linq;

namespace Gradebook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> students = new List<string>();
            List<double> grades = new List<double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            //Accept New Students
            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    //Populate new list of students
                    students.Add(newStudent);
                }
            }
            while (newStudent != "");

            // Get grades for each student
            foreach (string student in students)
            {
                Console.WriteLine("Grade for " + student + ": ");
                double newGrade = double.Parse(Console.ReadLine());
                grades.Add(newGrade);
            }

            // Print class roster
            // students list contain some count of name therefore is a definite list and for loop is used
            Console.WriteLine("\nClass roster:");
            for (int i = 0; i < students.Count; i++)
            {
                //Print out the zero index for student name and for student grades, until the final index
                Console.WriteLine(students[i] + " (" + grades[i] + ")");
            }

            double sum = grades.Sum();
            double avg = sum / grades.Count;
            Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
        }
    }
}
