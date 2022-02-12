using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetNeChet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                int ans, number, numberIn, numberOut;
                int chet;
                int nechet;

                Console.WriteLine("ОПРЕДЕЛЕНИЕ КОЛИЧЕСТВА ЧЕТНЫХ И НЕЧЕТНЫХ ЧИСЕЛ\n");

                
                try
                {
                    Console.WriteLine("Введите целое число от:");
                    numberIn = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    Console.WriteLine("Введите целое число до:");
                    numberOut = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Что непонятного в словах целое и число, придурок?");
                    Console.ReadLine();
                    continue;
                }

                if (numberOut <= numberIn)
                {
                    Console.WriteLine("Число 'до' должно быть больше числа 'от'");
                    Console.ReadLine();

                    continue;
                }

                Console.Clear();

                number = numberOut - numberIn + 1;

                if (numberOut % 2 == 0 && numberIn % 2 == 0)
                {
                    nechet = number / 2;
                    chet = nechet + 1;
                }
                else if (numberOut % 2 == 1 && numberIn % 2 == 1)
                {
                    chet = number / 2;
                    nechet = chet + 1;
                }
                else
                {
                    chet = number / 2;
                    nechet = chet;
                }

                Console.WriteLine("Четных числел: " + chet + "\nНечетных чисел: " + nechet);

                Console.WriteLine("\nВключить вывод чисел от " + numberIn + " до " + numberOut + " ?\n" +
                    "1. Да\n" +
                    "2. Нет");
                ans = int.Parse(Console.ReadLine());

                Console.Clear();

                if (ans == 1)
                {
                    numberIn--;
                    while (numberIn < numberOut)
                    {
                        numberIn++;
                        Console.WriteLine(numberIn);
                    }

                }

                Console.ReadLine();

            }

        }
    }
}
