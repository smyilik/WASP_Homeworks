using System;

namespace Academy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                Console.Write(number % 10);
                number /= 10;
            }
            Console.ReadKey();
        }
    }
}
