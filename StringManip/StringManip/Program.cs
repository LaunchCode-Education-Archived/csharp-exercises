using System;
using System.Text;

namespace StringManip
{
    class Program
    {
        static void Main(string[] args)
        {
            //string mystring = "My \"so-called\" life";
            //string mystring = "What if I need a \nnew line";
            //string mystring = "Go to your c:\\ drive";
            //string myString = @"Go to your c:\ drive";


            //string myString = String.Format("{0:C}", 123.45);

            //string myString = string.Format("{0:N}", 30989584848737);

            //string myString = string.Format("{0:(###) ### ####}", 3054560567);

            //string myString = string.Format("Percentage: {0:P}", .435);

            //string myString = "  That summer we took threes acroos the board  ";
            //myString = myString.Substring(6,12);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);
            /* myString = String.Format("Length before: {0} -- Length after: {1}",
                 myString.Length, myString.Trim().Length);
                 */
            /*
            string myString = "";

            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            StringBuilder myString = new StringBuilder();
            
            for (int i = 0; i < 100; i++)
            {
                myString.Append("---");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
