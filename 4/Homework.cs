using System;
using System.Collections.Generic;
using System.IO;

namespace Academy
{
    class MainClass
    {
        static string[] inp_mass1()
        {
            Console.WriteLine("Вводите элементы одномерного массива через '%' в одну строчку");
            string[] mass = Console.ReadLine().Split('%');
            return mass;
        }
        static string[,] inp_mass2()
        {
            Console.WriteLine("Введите количество строк и количество столбцов через пробел");
            int stro = 0, stolb = 0;
            string[] strolb;
            do
            {
                strolb = Console.ReadLine().Split();
                if (strolb.Length == 2)
                {
                    int.TryParse(strolb[0], out stro);
                    int.TryParse(strolb[1], out stolb);
                }
                if (((stro <= 0) || (stolb <= 0)) || (strolb.Length < 2))
                {
                    Console.WriteLine("Введите корректные числа");
                }
            } while ((stro <= 0) || (stolb <= 0));
            string[,] mass = new string[stro, stolb];
            Console.WriteLine("Вводите элементы своего двумерного массива, каждый с новой строки");
            for (int i = 0; i < stro; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    mass[i, j] = Console.ReadLine();
                }
            }
            return mass;
        }
        static string[][] inp_mass3()
        {
            Console.WriteLine("Введите количество массивов, которые нужно поместить в массив");
            int kol = 0;
            do
            {
                int.TryParse(Console.ReadLine(), out kol);
                if (kol <= 0)
                {
                    Console.WriteLine("Введите корректное число");
                }
            } while (kol <= 0);
            string[][] mass = new string[kol][];
            string[] vvod;
            Console.WriteLine("Вводите каждый массив с новой строки, при этом элементы массивов разделяйте с помощью '%'");
            for (int i = 0; i < kol; i++)
            {
                vvod = Console.ReadLine().Split('%');
                mass[i] = vvod;
            }
            return mass;
        }
        static void inp_mass_write()//1
        {
            Console.WriteLine("Выбирите тип элементов:");
            Console.WriteLine("1 - одномерный массив");
            Console.WriteLine("2 - двумерный массив");
            Console.WriteLine("3 - массив массивов");
            int type = 0;
            do
            {
                int.TryParse(Console.ReadLine(), out type);
                if (!(type == 1) && !(type == 2) && !(type == 3))
                {
                    Console.WriteLine("Введите корректное число");
                }
            } while (!(type == 1) && !(type == 2) && !(type == 3));

            if (type == 1)
            {
                string[] mass = inp_mass1();
                Console.WriteLine("Ваш массив:");
                foreach (string j in mass)
                {
                    if (!(j == mass[mass.Length - 1]))
                    {
                        Console.Write("'" + j + "' , ");
                    }
                    else
                    {
                        Console.Write("'" + j + "'");
                    }
                }
            }
            else if (type == 2)
            {
                string[,] mass = inp_mass2();
                int y = 1, stolb = mass.GetLength(0);
                Console.WriteLine("Ваш двумерный массив:");
                foreach (string h in mass)
                {
                    if (y == stolb)
                    {
                        Console.Write(h);
                        Console.WriteLine("");
                        y = 0;
                    }
                    else
                    {
                        Console.Write(h + " ");
                    }
                    y++;
                }
            }
            else
            {
                string[][] mass = inp_mass3();
                int len, kol = mass.Length, y = 1;
                Console.WriteLine("Ваши массивы в массиве");
                for (int j = 0; j < kol; j++)
                {
                    len = mass[j].Length;
                    foreach (string h in mass[j])
                    {
                        if (y == len)
                        {
                            Console.Write("'" + h + "'");
                            Console.WriteLine("");
                            y = 0;
                        }
                        else
                        {
                            Console.Write("'" + h + "' , ");
                        }
                        y++;
                    }
                }
            }
        }
        static void max_count_mass()//2
        {
            Console.WriteLine("Выбирите тип массива:");
            Console.WriteLine("1 - одномерный");
            Console.WriteLine("2 - двумерный");
            int type = 0;
            do
            {
                int.TryParse(Console.ReadLine(), out type);
                if ((type != 1) && (type != 2))
                {
                    Console.WriteLine("Введите корректное число");
                }
            } while ((type != 1) && (type != 2));

            if (type == 1)
            {
                Console.WriteLine("Вводите элементы массива через '%'");
                string[] mass = Console.ReadLine().Split('%');
                int len = mass.Length, max = -2, check = -2, count = 0;
                while (max == -2)
                {
                    for (int i = 0; i < len; i++)
                    {
                        int.TryParse(mass[i], out max);
                        if (max > 0)
                        {
                            max = -1;
                            break;
                        }
                    }
                    if (max == -2)
                    {
                        Console.WriteLine("Введите массив с хотябы одним числом больше нуля");
                        mass = Console.ReadLine().Split('%');
                    }
                }
                for (int i = 0; i < len; i++)
                {
                    int.TryParse(mass[i], out check);
                    if (check > max)
                    {
                        max = check;
                    }
                    check = -2;
                }
                for (int j = 0; j < len; j++)
                {
                    int.TryParse(mass[j], out check);
                    if (check == max)
                    {
                        count++;
                    }
                    check = -2;
                }
                Console.WriteLine("Максимальное число - " + max);
                Console.WriteLine("Оно встретилось " + count + " раз");
            }//одномерный массив
            if (type == 2)
            {
                Console.WriteLine("Введите количество строк и столбов через пробел");
                string[] kol;
                int stro, stolb, count = -1, max = -1, check = -1;
                do
                {
                    kol = Console.ReadLine().Split();
                    if ((kol.Length != 2) || !(int.TryParse(kol[0], out stro)) || !(int.TryParse(kol[1], out stolb)))
                    {
                        Console.WriteLine("Вводите количества больше нуля");
                    }
                    else
                    {
                        int.TryParse(kol[0], out stro);
                        int.TryParse(kol[1], out stolb);
                        if ((stro <= 0) || (stolb <= 0))
                        {
                            Console.WriteLine("Вводите количества больше нуля");
                            kol = Console.ReadLine().Split();
                        }
                        else
                        {
                            count = 0;
                        }
                    }
                } while (count != 0);//кол-во строк и столбов
                stro = int.Parse(kol[0]);
                stolb = int.Parse(kol[1]);
                string[,] mass = new string [stro, stolb];
                Console.WriteLine("Вводите элементы двумерного массива, каждый с новой строки");
                do
                {
                    for (int i = 0; i < stro; i++)
                    {
                        for (int j = 0; j < stolb; j++)
                        {
                            mass[i, j] = Console.ReadLine();
                        }
                    }
                    for (int i = 0; i < stro; i++)
                    {
                        for (int j = 0; j < stolb; j++)
                        {
                            int.TryParse(mass[i, j], out check);
                            if ((int.TryParse(mass[i, j], out check)) && (check > 0))
                            {
                                check = -2;
                                break;
                            }
                        }
                        if (check == -2)
                        {
                            break;
                        }
                    }
                    if (check != -2){
                        Console.WriteLine("Попробуйте ввести массив с хотябы одним число больше нуля");
                    }
                } while (check != -2);//ввод массива
                for (int z = 0; z < stro; z++)
                {
                    for (int x = 0; x < stolb; x++)
                    {
                        int.TryParse(mass[z, x], out check);
                        if (check > max)
                        {
                            max = check;
                        }
                        check = -2;
                    }
                }//max
                for (int z = 0; z < stro; z++)
                {
                    for (int x = 0; x < stolb; x++)
                    {
                        int.TryParse(mass[z, x], out check);
                        if (check == max)
                        {
                            count++;
                        }
                        check = -1;
                    }
                }//count
                Console.WriteLine("Максимальное число - " + max);
                Console.WriteLine("Оно встретилось " + count + " раз");
            }//двумерный массив
        }
        static void add_masses()//3
        {
            Console.WriteLine("Выбирите тип элементов:");
            Console.WriteLine("1 - одномерный массив");
            Console.WriteLine("2 - двумерный массив");
            int type1 = 0, type2 = 0;
            string[] types;
            do
            {
                types = Console.ReadLine().Split();
                if (types.Length == 2)
                {
                    int.TryParse(Console.ReadLine(), out type1);
                    int.TryParse(Console.ReadLine(), out type2);
                }
                if ((types.Length != 2) || !(type1 == 1) && !(type1 == 2) && !(type2 == 1) && !(type2 == 2))
                {
                    Console.WriteLine("Введите корректное число");
                }
            } while ((types.Length != 2) || !(type1 == 1) && !(type1 == 2) && !(type2 == 1) && !(type2 == 2));
            /*if ((type1 == 1) && (type2 == 1))
            {
                (string[], string[]) mass1 = (inp_mass1(), inp_mass1());
                return mass1;
            }
            else if ((type1 == 2) && (type2 == 1))
            {
                (string[,], string[]) mass1 = (inp_mass2(), inp_mass1());
                return mass1;
            }
            else if ((type1 == 1) && (type2 == 2))
            {
                (string[], string[,]) mass1 = (inp_mass1(), inp_mass2());
                return mass1;
            }
            else if ((type1 == 2) && (type2 == 2))
            {
                (string[,], string[,]) mass1 = (inp_mass2(), inp_mass2());
                return mass1;
            }*/
        }
        static double mass_percent()//6
        {
            string[] mass1 = inp_mass1(), mass2 = inp_mass1();
            int min = Math.Min(mass1.Length, mass2.Length) - 1, nol = 0;
            Console.WriteLine(min);
            for (int i = 0; i < min; i++)
            {
                if (mass1[i] == mass2[i])
                {
                    nol++;
                }
                Console.WriteLine(i + nol);
            }
            double a = nol / min;
            Console.WriteLine(a);
            return (a * 100);
        }

        static void Main()
        {
            //inp_mass_write();//1 задание
            //max_count_mass();//2 задание

            //Задания, которые я пытался решить, но не получилось, код находится выше
            //add_masses();//3 задание, хотел сделать return кортежа, но потом понял, что не могу изменить тип функции внутри функции
            //Console.WriteLine(mass_percent());//6 задание не успел разобраться
            Console.ReadKey();
        }
    }
}
