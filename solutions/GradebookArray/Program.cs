using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradebookArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Allow for at most 30 students
            int maxStudents = 30;

            string[] students = new string[maxStudents];
            double[] grades = new double[maxStudents];

            string newStudent;
            int numStudents = 0;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    students[numStudents] = newStudent;
                    numStudents++;
                }
            }
            while (newStudent != "" && numStudents < maxStudents);

            // Get student grades
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine("Grade for " + students[i] + ": ");
                double newGrade = double.Parse(Console.ReadLine());
                grades[i] = newGrade;
            }

            // Print class roster, summing grades as we go
            Console.WriteLine("\nClass roster:");
            double sum = 0;

            for (int j = 0; j < numStudents; j++)
            {
                Console.WriteLine(students[j] + " (" + grades[j] + ")");
                sum += grades[j];
            }
            
            double avg = sum / numStudents;
            Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
        }
    }
}
