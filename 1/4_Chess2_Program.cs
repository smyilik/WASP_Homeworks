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
            int d = int.Parse(Console.ReadLine());
            int raz = Math.Max(a, c) - Math.Min(a, c);
            int raz2 = Math.Max(b, d) - Math.Min(b, d);
            if ((raz > 1) || (raz2 > 1))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
            Console.ReadKey();
        }
    }
}
