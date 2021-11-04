using System;
namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа в строчку, через пробел, первое должно быть меньше второго");
            string[] mass = Console.ReadLine().Split();
            int m = int.Parse(mass[0]), n = int.Parse(mass[1]);
            int chislo = m;
            while (m < n)
            {
                m *= chislo;
            }

            if (m == n)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}