using System;

namespace Basis
{
    class ValutConvert
    {
        static void Main(string[] args)
        {
            int dol, eu;
            string valuteIn = "P", valuteOut = "P";

            dol = 76;
            eu = 86;

            Console.WriteLine("Выберите валюту ИЗ которой хотите переводить:\n" +
                "1. Рубль\n" +
                "2. Доллар\n" +
                "3. Евро");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Выберите валюту В которою хотите переводить:\n" +
                "1. Рубль\n" +
                "2. Доллар\n" +
                "3. Евро");
            int b = int.Parse(Console.ReadLine());

            if (a == 2) { a = dol; valuteIn = "$"; }
            else if (a == 3) { a = eu; valuteIn = "Eu"; }

            if (b == 2) { b = dol; valuteOut = "$"; }
            else if (b == 3) { b = eu; valuteOut = "Eu"; }

            double mod = (double)a / b;

            Console.WriteLine("Какое количество валюты вы хотите конвертировать?(Только число)");
            double money = double.Parse(Console.ReadLine());

            Console.WriteLine("После перевода " + money + valuteIn + " у вас будет: " + money * mod + valuteOut);

            Console.ReadLine();
        }
    }
}