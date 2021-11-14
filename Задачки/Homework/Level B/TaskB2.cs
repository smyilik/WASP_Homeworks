using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B2.
    // Кол-во стингеров: 🔹
    //
    // Написать функцию OrderWeight(List<int> list), которая сортирует список положительных чисел.
    // Критерий сортировки - возрастание веса числа (сумма всех цифр числа).
    // Если два числа имеют одинаковый вес, сортировать их так, словно они строки.
    //
    // Пример:
    // [56, 65, 74, 100, 99, 68, 86, 180, 90] ==>
    // [100, 180, 90, 56, 65, 74, 68, 86, 99]
    public static class TaskB2
    {
        public static int Weight(int num)//пишем функцию по нахождению массы числа
        {
            if (num == 0){ return 0; }
            else if (num < 0) { num *= -1; }
            int kol = 0, a = num, sr = 0;
            while (a > 0)
            {
                a /= 10;
                kol++;
            }
            int ten = Convert.ToInt32(Math.Pow(10, kol - 1));
            for (int j = 0; j < kol; j++)
            {
                sr += num / ten;
                num %= ten;
                ten /= 10;
            }
            return sr;
        }
        public static List<int> OrderWeight(List<int> list)
        {
            // Здесь необходимо написать код.
            int minweight = int.MaxValue, len = list.Count, num = int.MaxValue, ind = 0;
            List<int> finls = new List<int>();
            for (int j = 0; j < len; j++)
            {
                for (int i = 0; i < len; i++)
                {
                    if (Weight(list[i]) < minweight)
                    {
                        minweight = Weight(list[i]);
                        num = list[i];
                        ind = i;
                    }
                    else if ((Weight(list[i]) == minweight) && (String.Compare(Convert.ToString(list[i]), Convert.ToString(num)) == -1))
                    {
                        minweight = Weight(list[i]);
                        num = list[i];
                        ind = i;
                    }
                }
                finls.Add(num);
                minweight = int.MaxValue;
                num = int.MaxValue;
                list[ind] = int.MaxValue;
            }
            return finls;
        }
    }
}