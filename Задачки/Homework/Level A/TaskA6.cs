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
            List<int> ls2 = new List<int>();
            int i = arr.Count - 1;
            do
            {
                if ((arr[i] % 2 == 1) || (arr[i] % 2 == -1))
                {
                    ls.Add(arr[i]);
                }
                i--;
            } while (ls.Count < n);
            for (int j = n - 1; j >= 0; j--)
            {
                ls2.Add(ls[j]);
            }
            return ls2;
        }
    }
}
