using System;

namespace Academy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            double checker1 = a / 2;
            double checker2 = b / 2;
            if (x > checker1)
            {
                x = a - x;
            }
            if (y > checker2)
            {
                y = b - y;
            }
            if (x <= y)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(y);
            }
            Console.ReadKey();
        }
    }
}
