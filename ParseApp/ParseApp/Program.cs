using System;
using System.Linq;
using System.Collections.Generic;

namespace ParseApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            HelloWorld greeting = new HelloWorld();

            greeting.SayHello("Person");
            
        }
        public class HelloWorld
        {

            private String message = "Hello World";

            public void SayHello( string message  )
            {
                Console.WriteLine(message);

                Console.WriteLine(this.message);
                Console.ReadLine();
            }

        }
    }   
}
