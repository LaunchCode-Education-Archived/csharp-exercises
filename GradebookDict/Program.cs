using System;
using System.Collections.Generic;
using System.Linq;

namespace GradebookDict
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            string newStudent;

            Console.WriteLine("Enter your students:");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's grade
                    Console.Write("grade: ");
                    double aGrade = double.Parse(Console.ReadLine());

                    students.Add(newStudent, aGrade);
                }
            }
            while (newStudent != "");

            // print roster
            Console.WriteLine("Student roster:");
            foreach (KeyValuePair<string, double> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }

            double sum = students.Values.Sum();
            double avg = sum / students.Count;
            Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
        }
    }
}
