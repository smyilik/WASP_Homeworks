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
            string str = "";
            int nol = 0;
            for (int i = 0; i < kol; i++){
                for (int j = 0; j < kol; j++){
                    if (mass[j] == mass[i]){
                        nol++;
                    }
                }
                if (nol == 1){
                    str += mass[i];
                    str += " ";
                }
                nol = 0;
            }
            Console.WriteLine(str.Trim(' '));
        }
    }
}