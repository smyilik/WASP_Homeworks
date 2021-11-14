using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B5.
    // Кол-во стингеров: ½🔷
    //
    // Написать функцию Frame(string text, char symbol), которая заключает
    // список строк text в рамку из символов char и возвращает данную строку.
    //
    // Пример:
    // frame(['Create', 'a', 'frame'], '+') ==>
    // ++++++++++
    // + Create +
    // + a      +
    // + frame  +
    // ++++++++++
    public static class TaskB5
    {
        public static string Frame(List<string> text, char symbol)
        {
            int max = -1;
            foreach(string h in text)
            {
                if (h.Length > max) { max = h.Length; }
            }
            string str = "";
            for (int i = 0; i < text.Count + 2; i++)
            {
                if ((i == 0) || (i == text.Count + 1))
                {
                    for (int j = 0; j < max + 4; j++) { str += symbol; }
                    if (i == 0) { str += '\n'; }
                }
                else
                {
                    str += symbol + " " + text[i - 1];
                    if (text[i - 1].Length < max)
                    {
                        for (int j = 0; j < max - text[i - 1].Length; j++)
                        {
                            str += " ";
                        }
                    }
                    str += " " + symbol + '\n';
                }
            }
            return str;
        }
    }
}
