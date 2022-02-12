using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum, secondNum, result;
            string mathSymb;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("ПРОСТЕЙШИЙ КАЛЬКУЛЯТОР\n\n" +
                                "Введите первое число над которым будет произвдиться математическая операция");
                try
                {
                    firstNum = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Я хуй знает, по моему это не число");
                    Console.ReadLine();
                    continue;
                }
                

                Console.WriteLine();

                Console.WriteLine("Введите символ математической операции:\n" +
                    "-(минус) вычесть\n" +
                    "+(плюс) сложить\n" +
                    "/(делить) разделить\n" +
                    "*(умножить) умножить");
                mathSymb = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Введите второе число над которым будет произвдиться математическая операция");
                try
                {
                    secondNum = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Я хуй знает, по моему это не число");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine();

                switch (mathSymb)
                {
                    case "-":
                        result = firstNum - secondNum;
                        break;

                    case "+":
                        result = firstNum + secondNum;
                        break;

                    case "/":
                        if (secondNum == 0)
                        {
                            Console.WriteLine("Пошел нахуй, быдло, на ноль он блять делить собрался. Хатьфу");
                            Console.ReadLine();
                            continue;
                        }
                        result = firstNum / secondNum;
                        break;

                    case "*":
                        result = firstNum * secondNum;
                        break;

                    default:
                        Console.WriteLine("Вы ввели не верный символ, по этому автоматически был выбран +");
                        mathSymb = "+";
                        result = firstNum + secondNum;
                        break;
                }

                Console.WriteLine(firstNum + " " + mathSymb + " " + secondNum + " = " + result);
                Console.ReadLine();
            }




        }
    }
}
