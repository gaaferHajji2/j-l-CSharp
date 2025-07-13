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

            //checked
            //{
            //    byte number = 255;

            //    Console.WriteLine("The Number Is: " + number);

            //    //number += 1; // This Will Throw Exception
            //}
        }
    }
}
