using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 5;
            string a = "45,6";

            Console.WriteLine(a + b); // = 45,65
            Console.WriteLine(b + a); // = 545,6
            Console.WriteLine(b + float.Parse(a)); // = 50,6

            a = Console.ReadLine();
            b = 15;

            Console.WriteLine(a + b);
            Console.WriteLine(b + a);
            Console.WriteLine(b + int.Parse(a));

            int c = 10;
            b = 5;

            Console.WriteLine(c / b); // 2
            Console.WriteLine(Convert.ToSingle(b) / c); // 0,5

        }
    }
}
