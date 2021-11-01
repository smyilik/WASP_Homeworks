using System;

namespace Academy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine()); int a = int.Parse(Console.ReadLine()); int b = int.Parse(Console.ReadLine());
            int schet = 0, i = 0;
            while (schet < h)
            {
                i++;
                schet += a;
                if (schet >= h)
                {
                    Console.WriteLine(i);
                    break;
                }
                schet -= b;
            }
            Console.ReadKey();
        }
    }
}
