using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Love
{
    internal class Program
    {

        public static bool Color(double weight, double height, double maxweight)
        {
            if ((weight == (maxweight / 4 + 0.5) || weight == (maxweight * 3 / 4 + 0.5)) && height <= maxweight - ((maxweight / 2 - 1) / 2))
            {
                return true;
            }
            if (weight > (maxweight / 4 + 0.5) - height && weight < (maxweight / 4 + 0.5) + height && height <= (maxweight / 2 - 1) / 2)
            {
                return true;
            }
            if (weight > (maxweight * 3 / 4 + 0.5) - height && weight < (maxweight * 3 / 4 + 0.5) + height && height <= (maxweight / 2 - 1) / 2)
            {
                return true;
            }
            if (height > (maxweight / 2 - 1) / 2 && height <= ((maxweight / 2 - 1) / 2) + (maxweight / 2 - 2))
            {
                return true;
            }
            if (height > (maxweight / 2 - 1) / 2 + (maxweight / 2 - 2) && (weight > ((height + (((maxweight / 2 - 1) / 2 + (maxweight / 2 - 2)) % 1)) - ((maxweight / 2 - 1) / 2 + (maxweight / 2 - 2)))) && weight <= (maxweight - (height - ((maxweight / 2 - 1) / 2 + (maxweight / 2 - 2)))) )
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            Console.Title = "Любооооооооооооооофь";

            double height, weight;

            while (true)
            {
                Console.Clear();

                try
                {
                    Console.Write("Задайте ширину квадрата(советую от 7 и больше): ");
                    weight = int.Parse(Console.ReadLine());
                    height = weight;
                }
                catch (Exception)
                {
                    continue;
                }
                
                for (int i = 1; i <= height; i++)
                {
                    for (int j = 1; j <= weight; j++)
                    {
                        if (Color(j, i, weight))
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                        }
                        Console.Write("  ");
                    }

                    Console.WriteLine();
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Love you <3");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
            }
            

            
        }
    }
}
