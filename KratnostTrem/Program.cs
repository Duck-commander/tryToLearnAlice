using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KratnostTrem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num; // присваеваем переменной num целочисленный тип int


            Console.WriteLine("Введите любое число"); // выводим в консоль текст 
            num = int.Parse(Console.ReadLine()); // 
            if (num % 3 == 0) // если остаток от деления введенного пользователем числа на три равен нулю
            {
                if (num == 0) 
                {
                    Console.WriteLine("ЕРРЕР");
                }
                else
                {
                    Console.WriteLine("Это число кратно трём");
                }
                if (num < 0)
                {
                    Console.WriteLine("Нет, впиши положительное число");
                }
            }
            else
            {
                Console.WriteLine("Это число не кратно трём");
            }
        }
    }
}
