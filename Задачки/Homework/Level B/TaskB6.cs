using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B6.
    // Кол-во стингеров: ½🔷
    //
    // Написать функцию Reverser, которая меняет порядок букв в каждом слове заданного
    // предложения на противоположный, порядок слов, при этом, должен сохраниться.
    //
    // Пример:
    // Reverser("reverse letters") ==> "esrever srettel".
    public static class TaskB6
    {
        public static string Reverser(string s)
        {
            string str = "";
            string[] list = s.Split(' ');
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = list[i].Length - 1; j >= 0; j--)
                {
                    str += list[i][j];
                }
                if (i < list.Length - 1) { str += " "; }
            }
            if (str != "") { return str; }
            return s;
        }
    }
}
