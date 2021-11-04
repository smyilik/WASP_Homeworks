using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<double> ls = new List<double>();
            string a = Console.ReadLine();
            int ln = 0;
            while (double.Parse(a) != 0)//вводим в список т.к. не знаем кол-во элементов
            {
                ls.Add(double.Parse(a));
                a = Console.ReadLine();
                ln++;
            }

            double srar = 0, srot = 0;
            for (int i = 0; i < ln; i++)//считаем среднее арифметическое
            {
                srar += ls[i];
            }
            srar /= ln;
            for (int j = 0; j < ln; j++)//считаем среднее отклонение
            {
                srot += (ls[j] - srar) * (ls[j] - srar);
            }

            srot /= ln - 1;
            Console.WriteLine(Math.Sqrt(srot));
        }
    }
}