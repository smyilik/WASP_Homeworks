using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А6.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию OddNumbers, которая получает на вход список целых чисел arr и целое число n и
    // возвращает список, состоящий из n последних вхождений нечетных чисел списка arr в том же порядке
    //
    // Пример:
    // ([1, 2, 3, 4, 5, 6, 7, 8, 9], 3) => [5, 7, 9]
    public static class TaskA6
    {
        public static List<int> OddNumbers(List<int> arr, int n)
        {
            List<int> ls = new List<int>();
            for (int i = arr.Count - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 1) { ls.Add(arr[i]); }
            }
            if (ls.Count > n)
            {
                while (ls.Count > n)
                {
                    ls.RemoveAt(ls.Count - 1);
                }
            }
            arr = new List<int>();
            for (int j = ls.Count - 1; j >= 0; j--)
            {
                arr.Add(ls[j]);
            }
            return arr;
        }
    }
}
