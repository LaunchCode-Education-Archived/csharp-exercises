using System;
using System.Collections.Generic;
namespace MagicApp
{
    class Program
    {
        static void Main(string[] args)
        { 
            Wizard student1 = new Wizard("Harry Potter");

            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.StudentId);
            
            Console.WriteLine(student1.Greet());
            
            Console.ReadLine();

        }
    }

    public class Wizard
    {


        public string Name { get; set; }
        public int StudentId { get; set; }
        public string message = "Hello my name is ";


        public Wizard(string name, int studentId)
        {
            this.Name = name;
            this.StudentId = studentId;
        }

        public Wizard(string name)
        : this(name, 1) {}
        

        public string Greet()
        {
            return message + this.Name;
        }
    }
}
