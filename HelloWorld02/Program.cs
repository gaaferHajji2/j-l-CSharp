using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!"); // This come from System-namespace

            string firstName = "Jafar";
            string lastName = "Loka";

            Console.WriteLine("My name is: " + firstName + " " + lastName);

            var myName = "Jafar Loka";

            Console.WriteLine("My Name using var is: " + myName);

            Console.WriteLine("{0}, {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("My Name is: {0} {1}", "Jafar", "Loka");

            // All types have minValue && maxValue
            Console.WriteLine("Float: {0}, {1}", float.MinValue, float.MaxValue);

            //checked
            //{
            //    byte number = 255;

            //    Console.WriteLine("The Number Is: " + number);

            //    //number += 1; // This Will Throw Exception
            //}
        }
    }
}
