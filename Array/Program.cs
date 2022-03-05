using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        public static int[] SortInt32 (int[] Array)
        {
            int[] sort = new int[Array.Length];
            int[] id = new int[Array.Length];
            int max, min, repeat;

            max = Array[0];

            for (int i = 0; i < Array.Length; i++)
            {
                id[i] = -1;
                max = max < Array[i] ? Array[i] : max;
            }

            for (int i = 0; i < sort.Length; i++)
            {
                min = max;
                for (int j = 0; j < Array.Length; j++)
                {
                    repeat = 0;
                    for (int k = 0; k < id.Length; k++)
                    {
                        if (j == id[k])
                        {
                            repeat = 1;
                            break;
                        }
                    }
                    if (repeat == 1)
                    {
                        continue;
                    }
                    if (Array[j] < min)
                    {
                        min = Array[j];
                        id[i] = j;
                    }
                }
                sort[i] = min;
            }

            return sort;
        }

        static void Main(string[] args)
        {
            int[] Array;
            int length;
            int evenSum = 0;
            int smallestNum = 0;

            while (true)
            {

                try
                {
                    Console.Write("Введите длину массива: ");
                    length = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Солид Снейк был расскрыт. Миссия провалена");
                    Console.ReadLine();
                    Console.Clear();

                    continue;
                }
            }

            Array = new int[length];

            for (int i = 0; i < length; i++)
            {
                while (true)
                {
                    Console.Clear();
                    Console.Write("Введите " + (i + 1) + " эллемент массива: ");
                    try
                    {
                        Array[i] = int.Parse(Console.ReadLine());
                        smallestNum = i == 0 ? Array[0] : Array[i] < smallestNum ? Array[i] : smallestNum;
                        evenSum += Array[i] % 2 == 0 ? Array[i] : 0;
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ты что-то сделал не так");
                        Console.ReadLine();
                        continue;
                    }
                }
            }
            Console.Clear();

            Console.Write("Массив: ");

            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("Наименьшее число в массиве: " + smallestNum);
            Console.WriteLine("Сумма четных чисел массива: " + evenSum);
            Console.Write("Массив в обратном порядке: ");

            for (int i = Array.Length - 1; i >= 0; i--)
            {
                Console.Write(Array[i] + ", ");
            }
            Console.WriteLine();

            Console.Write("Отсортированный массив: ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(SortInt32(Array)[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
