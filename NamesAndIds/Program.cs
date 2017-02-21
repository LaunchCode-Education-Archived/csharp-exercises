using System;
using System.Collections.Generic;
using System.Linq;

namespace GradebookDict
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            string newStudent;

            Console.WriteLine("Enter your students name and hit enter (or hit ENTER twice to finish):");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's Id
                    Console.Write("ID: ");
                     string newId = (Console.ReadLine());

                    students.Add(newStudent, int.Parse(newId));
                }
            }
            while (newStudent != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<string, int> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }

            Console.ReadLine();
        }
    }
}