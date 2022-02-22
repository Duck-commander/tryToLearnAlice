using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetNeChet
{
    internal class Program
    {

        public static double Module(double number)
        {
            if (number < 0)
            {
                number = number * -1;
            }

            return number;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                double ans, number, numberIn, numberOut;
                double chet;
                double nechet;
                double sumevennumberIn, sumevennumberOut;
                double sumoddnumberIn, sumoddnumberOut;

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

                number = numberOut - numberIn;

                // number of even and odd numbers

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

                // summ all even & all odd num

                if (numberIn < 0)
                {
                    if (numberIn % 2 == -1)
                    {
                        sumoddnumberIn = ((Module(numberIn) + 1) / 2) * ((Module(numberIn) + 1) / 2);
                        sumevennumberIn = (Module(numberIn) - 1) * (0.5 + (Module(numberIn) - 1) / 4);
                    }
                    else
                    {
                        sumoddnumberIn = (Module(numberIn) / 2) * (Module(numberIn) / 2);
                        sumevennumberIn = Module(numberIn) * (0.5 + Module(numberIn) / 4);
                    }
                }
                else
                {
                    if (numberIn % 2 == 1)
                    {
                        sumoddnumberIn = ((numberIn - 1) / 2) * ((numberIn - 1) / 2);
                        sumevennumberIn = (numberIn - 1) * (0.5 + (numberIn - 1) / 4);
                    }
                    else
                    {
                        sumoddnumberIn = ((numberIn) / 2) * ((numberIn) / 2);
                        sumevennumberIn = (numberIn - 2) * (0.5 + (numberIn - 2) / 4);
                    }
                }

                if (numberOut < 0)
                {
                    if (numberOut % 2 == -1)
                    {
                        sumoddnumberOut = ((Module(numberOut) - 1) / 2) * ((Module(numberOut) - 1) / 2);
                        sumevennumberOut = (Module(numberOut) - 1) * (0.5 + (Module(numberOut) - 1) / 4);
                    }
                    else
                    {
                        sumoddnumberOut = ((Module(numberOut)) / 2) * ((Module(numberOut)) / 2);
                        sumevennumberOut = (Module(numberOut) - 2) * (0.5 + (Module(numberOut) - 2) / 4);
                    }
                }
                else
                {
                    if (numberOut % 2 == 1)
                    {
                        sumoddnumberOut = ((numberOut + 1) / 2) * ((numberOut + 1) / 2);
                        sumevennumberOut = (numberOut - 1) * (0.5 + (numberOut - 1) / 4);
                    }
                    else
                    {
                        sumoddnumberOut = (numberOut / 2) * (numberOut / 2);
                        sumevennumberOut = numberOut * (0.5 + numberOut / 4);
                    }
                }

                while (true)
                {
                    Console.WriteLine("Четных числел: " + chet + "\nНечетных чисел: " + nechet);

                    Console.WriteLine();

                    Console.WriteLine("Сумма четных чисел: " + (sumevennumberOut - sumevennumberIn));
                    Console.WriteLine("Сумма нечетных чисел: " + (sumoddnumberOut - sumoddnumberIn));

                    try
                    {
                        Console.WriteLine("\nВключить вывод чисел от " + numberIn + " до " + numberOut + " ?\n" +
                        "1. Да\n" +
                        "2. Нет");
                        ans = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Не, ты чего-то не понял");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                }
                
                

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
                else
                {
                    continue;
                }

                Console.ReadLine();

            }

        }
    }
}
