using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Class2Prep
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Lists: Write a static method to find the sum of all the even numbers 
            in a list. Within Main, create a list with at least 10 integers and 
            call your method on the list.*/

            //Question 1: How to find an even number
            //Question 2: How to search a list
            //Question 4: How to call a method on a list
            //Question 5: How to sum numbers in a list

            List<int> numList = new List<int>();

            Console.WriteLine("Create a list with at least 10 integers and call your method on the list.");

            do
            {
                string newnum = Console.ReadLine();

                if (numList.Count != 10)
                {
                    int num = int.Parse(newnum);
                    numList.Add(num);
                }

            } while (numList.Count != 10);

            int evensum = 0;
            foreach (int even in numList)
            {
                if (even % 2 == 0)
                {
                    evensum += even;
                }
            }
            Console.WriteLine("The sum of even integers in numList: {0}", evensum);
            Console.ReadLine();

            //Lists and Strings: Write a static method to print out each word in a list that has exactly 5 letters.

            //TODO create a list, validate five chars, print valid strings

            List<string> listStrings = new List<string>();

            Console.WriteLine("Create a list of 10 strings for validation.");

            do
            {
                string newString = Console.ReadLine();

                listStrings.Add(newString);

            } while (listStrings.Count <= 9);

            Console.WriteLine("Items in list: {0}", listStrings.Count);

            foreach (string listString in listStrings)
            {
                if (listString.Length == 5)
                {
                    Console.WriteLine("{0} has exactly five characters", listString);
                }
            }
            Console.ReadLine();

            /*arrays: create and initialize in a single line an array with the following 
            values: 1, 1, 2, 3, 5, 8.then loop through the array and print out each value.*/

            //step 1
            int[] fibi = new int[] { 1, 1, 2, 3, 5, 8 };

            Console.WriteLine("the following are the first six integers in a fibinacci sequence.");

            //step 2
            foreach (int fib in fibi)
            {
                Console.WriteLine(fib);
            }
            Console.ReadLine();

            //Dictionaries: Make a program similar to GradebookDict, but which takes in students names
            //and ID numbers(as integers) instead of names and grades.In this case, however, the keys
            //should be integers(the IDs) and the values should be strings(the names). Modify the roster
            //printing code accordingly.

            /*

            Dictionary<int, string> enrollmentDict = new Dictionary<int, string>();
            string newStudentID;

            Console.WriteLine("Enter a roster of studentIDs paired with names.");

            do
            {
                Console.Write("StudentID: ");

                newStudentID = Console.ReadLine();
                if (newStudentID != "")
                {
                    // Get the student's name
                    Console.Write("name: ");
                    string newStudentName = Console.ReadLine();

                    enrollmentDict.Add(int.Parse(newStudentID), newStudentName);
                }
            } while (newStudentID != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> enrolled in enrollmentDict)
            {
                Console.WriteLine(enrolled.Key + " (" + enrolled.Value + ")");
            }

            Console.ReadLine();


            //Strings: In one of the Gradebook programs(it doesn't matter which), 
            //modify the code that prints out the class roster near the end of the program to use the StringBuilder class.

           */

            Dictionary<int, string> enrollmentDict = new Dictionary<int, string>();
            string newStudentID;

            Console.WriteLine("Enter a roster of studentIDs paired with names.");

            do
            {
                Console.Write("StudentID: ");
                newStudentID = Console.ReadLine();
                if (newStudentID != "")
                {
                    // Get the student's name
                    Console.Write("name: ");
                    string newStudentName = Console.ReadLine();

                    enrollmentDict.Add(int.Parse(newStudentID), newStudentName);
                }
            } while (newStudentID != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");

            StringBuilder myString = new StringBuilder();
            myString.Append(" (");
          
            foreach (KeyValuePair<int, string> enrolled in enrollmentDict)
            {
                Console.WriteLine(enrolled.Key + myString[1].ToString() + enrolled.Value + myString.")");
                myString.Append(enrolled.Key);
                myString.Append(enrolled.Value);
            }       
            Console.ReadLine();
           
        }
    }
}