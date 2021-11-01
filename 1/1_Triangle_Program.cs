using System;

namespace Academy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int nol = 1;
            if (a == b)
            {
                nol++;
            }
            if (a == c)
            {
                nol++;
            }
            if (b == c)
            {
                nol++;
            }
            if (nol == 1 || nol == 4)
            {
                Console.WriteLine(nol - 1);
            }
            else
            {
                Console.WriteLine(nol);
            }
            Console.ReadKey();
        }
    }
}
