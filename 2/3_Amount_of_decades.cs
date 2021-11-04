using System;

namespace Academy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine((a / 10) % 10);
            Console.ReadKey();
        }
    }
}
