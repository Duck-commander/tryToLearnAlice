using System;

namespace ProverkaChislaNaChetnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Введите число");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 1)
            {
                Console.WriteLine("Это число не является чётным");
            }
            else
            {
                Console.WriteLine("Это число является чётным");
            }
        }
    }
}
