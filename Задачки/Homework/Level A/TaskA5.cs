using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А5.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию ArrayOfTiers(int number), которая принимает число и возвращает список чисел, 
    // последовательно отсеченных по одному разряду.
    //
    // Пример:
    // ArrayOfTiers(420) ==> [4, 42, 420]
    // ArrayOfTiers(2021) ==> [2, 20, 202, 2021]
    public static class TaskA5
    {
        public static List<int> ArrayOfTiers(int number)
        {
            // Здесь необходимо написать код.
            int n = number, kol = 0, kol1;
            List<int> ls = new List<int>();
            while (n > 0)
            {
                n /= 10;
                kol++;
            }

            kol1 = kol;
            kol--;
            for (int i = 0; i < kol1; i++)
            {
                ls.Add(number / Convert.ToInt32(Math.Pow(10, kol)));
                kol--;
            }
            return ls;
        }
    }
}
