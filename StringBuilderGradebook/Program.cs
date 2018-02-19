using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringBuilderGradebook
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's grade
                    Console.WriteLine("grade: ");
                    double newGrade = double.Parse(Console.ReadLine());

                    students.Add(newStudent, newGrade);
                }
            }
            while (newStudent != "");

            // Print class roster
            StringBuilder newStringBuilder = new StringBuilder("", 25);
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<string, double> student in students)
            {
                newStringBuilder.Append(student.Key + " (" + student.Value + ")");
                Console.WriteLine(newStringBuilder);
                newStringBuilder.Clear();
            }

            double sum = students.Values.Sum();
            double avg = sum / students.Count;
            Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
        }
    }
}
