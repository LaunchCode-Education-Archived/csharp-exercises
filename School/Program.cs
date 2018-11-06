using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student("Jack", 2);
            Student student2 = new Student("John", 2);

            Console.WriteLine(student1);
            Console.WriteLine(student2);

            Console.WriteLine(student1.Equals(student2));

            Console.ReadLine();

            
        }

    }
}
