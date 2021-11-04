using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split();//вводим кол-во кегель и бросков
            int n = int.Parse(nk[0]), k = int.Parse(nk[1]);
            string[] mass = new string[n];//создаём массив, который мы потом выведем
            for (int i = 0; i < n; i++)//забиваем весь массив буквами "l"
            {
                mass[i] = "l";
            }
            string[] liri;
            int li, ri;
            for (int j = 0; j < k; j++)//вводим номера сбитых кегель
            {
                liri = Console.ReadLine().Split();
                li = int.Parse(liri[0]);
                ri = int.Parse(liri[1]);
                for (int z = li - 1; z < ri; z++)//меняем "l" на ".", где это нужно
                {
                    mass[z] = ".";
                }
            }

            foreach (string h in mass)
            {
                Console.Write(h);
            }
        }
    }
}