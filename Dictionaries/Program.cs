using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;
            int ID;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            int x = 0;
            do
            {
                Console.Write("ID: ");
                try
                {
                    ID = int.Parse(Console.ReadLine());
                    if (ID != 0)
                    {
                        // Get the student's grade
                        Console.WriteLine("Name: ");
                        newStudent = Console.ReadLine();

                        students.Add(ID, newStudent);
                    }
                }
                catch (System.FormatException)
                {
                    x += 1;
                }
            }
            while (x == 0);

            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }
            Console.ReadLine();
        }
    }
}
