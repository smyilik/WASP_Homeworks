using System;
namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int kol;
            Console.WriteLine("Введите количество элементов");
            kol = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите элементы массива через пробел");
            string[] mass = Console.ReadLine().Split();
            int[] mass1 = new int[kol];
            int min = int.MaxValue, pars, ind = 0;
            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < kol; j++)//находим наимешьший элемент массива и его индекс
                {
                    pars = int.Parse(mass[j]);
                    if (pars < min)
                    {
                        min = pars;
                        ind = j;
                    }
                }
                mass[ind] = Convert.ToString(int.MaxValue);
                mass1[i] = min;
                min = int.MaxValue;
            }
            Console.WriteLine("Ваши элементы");
            string stro = "";
            for (int h = 0; h < kol; h++)
            {
                stro += mass1[h];
                stro += " ";
            }
            Console.WriteLine(stro.Trim(' '));
        }
    }
}