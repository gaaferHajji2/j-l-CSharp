using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            b = 3;
            Console.WriteLine(b);
            Console.WriteLine(i);

            i = 350;
            b = (byte)i;
            Console.WriteLine(b);

            char c = 'A';
            //string name = (string) c; // compile error

            char j1 = '1';
            int t1 = Convert.ToInt32(j1); // in this way we will get the ascii-code 49
            Console.WriteLine(t1);
            Console.WriteLine(c);

            string number = "123";
            t1 = Convert.ToInt32(number);
            Console.WriteLine(t1);
        }
    }
}
