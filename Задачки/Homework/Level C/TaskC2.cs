﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача C2.
    // Кол-во стингеров: 🔷
    //
    // Написать функцию ChangeCent(int money), которая принимает количество американской валюты в центах и
    // возвращает список из четырех значений, который показывает наименьшее количество монет, используемых для составления этой суммы. 
    // Рассматриваются только монетные номиналы: Pennie (1 цент), Nickel (5 центов), Dime (10 центов) and Quarter (25 центов).
    // Возвращаемый список должен быть формата [кол-во Pennie, кол-во Nickel, кол-во Dime, кол-во Quarter].
    // Если в функцию передается вещественное число, его значение сперва должно быть округлено в меньшую сторону.
    // 
    // Пример:
    // ChangeCent(56) ==> [1,1,0,2] --> 1 * 1 + 1 * 5 + 0 * 10 + 2 * 25.
    public static class TaskC2
    {
        public static List<int> ChangeCent(double money)
        {
            // Здесь необходимо написать код.
            int cents = Convert.ToInt32(money - (money % 1));
            List<int> listCents = new List<int>() { 0, 0, 0, 0 };
            while (cents > 0)
            {
                if (cents >= 25)
                {
                    listCents[3]++;
                    cents -= 25;
                }
                else if (cents >= 10) { listCents[2]++; cents -= 10; }
                else if (cents >= 5) { listCents[1]++; cents -= 5; }
                else if (cents >= 1) { listCents[0]++; cents -= 1; }
            }
            return listCents;
        }
    }
}
