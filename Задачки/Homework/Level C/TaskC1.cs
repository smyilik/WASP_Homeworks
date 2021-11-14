﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача C1.
    // Кол-во стингеров: 🔷
    //
    // В классе 6 столов. На первом столе 1 яблоко, на втором - 2 яблока, на третьем - 3 и так далее.
    // Дети входят в класс по одному. Они должны сесть за тот стол, за которым они получают больше всего шоколада.
    // Если есть выбор между двумя столами, они предпочтут сесть за стол, ближайший к двери
    // (первый стол - самый близкий, а шестой - самый дальний от двери).
    // Написать функцию AppleShare(int N), которая для заданного числа детей n вернет список, показывающий,
    // сколько детей сидит за каждым столом.
    //
    // Пример:
    // AppleShare(10) ==> [0, 1, 1, 2, 3, 3]
    // Ребенок 1 садится за стол 6 (6 яблок). Ребенок 2 садится за стол 5 (5 яблок).
    // Ребенок 3 садится за стол 4 (4 яблока). Ребенок 4 садится за стол 3 (3 яблока).
    // Ребенок 5 садится за стол 6 (двое по 3 яблока). Ребенок 6 садится за стол 5 (двое по 2.5 яблока).
    // Ребенок 7 садится за стол 2 (2 яблока). Ребенок 8 садится за стол 4 (двое по 2 яблока).
    // Ребенок 9 садится за стол 6 (трое по 2 яблока). Ребенок 10 садится за стол 5 (трое по 1 и 2/3 яблока).
    public static class TaskC1
    {
        public static int Min(List<double> mass)
        {
            int ind = 0;
            double min = double.MaxValue;
            for (int i = 0; i < mass.Count; i++)
            {
                if (mass[i] < min) { min = mass[i]; ind = i; }
            }
            return ind;
        }
        public static List<int> AppleShare(int N)
        {
            List<double> part = new List<double> { 1, 2, 3, 4, 5, 6 };
            List<double> uch = new List<double> { 0, 0, 0, 0, 0, 0 };
            int ind;
            for (int i = 0; i < N; i++)
            {
                ind = Min(part);
                uch[ind]++;
                part[ind] = Convert.ToDouble(ind) / uch[ind];
            }
            List<int> otv = new List<int>();
            foreach(double d in part)
            {
                otv.Add(Convert.ToInt32(d));
            }
            return otv;
        }
    }
}
