using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B4.
    // Кол-во стингеров: 🔷
    //
    // Написать функцию CheckBrackets(string s), которая определяет,
    // правильно ли расставлены скобки () {} [] <> в предложении.
    //
    // Примеры:
    // CheckBrackets("(abc)[]{0:1}") ==> true;
    // CheckBrackets("(abc)]{0:1}[") ==> false.
    public static class TaskB4
    {
        public static bool CheckBrackets(string s)
        {
            // Здесь необходимо написать код.
            int len = s.Length;
            int check = 0;
            bool b = true;
            for (int i = 0; i < len; i++)
            {
                switch (s[i])
                {
                    case '(':
                        for (int j = i; j < len; j++)
                        {
                            if (s[j] == ')')
                            {
                                check = 1;
                                //s.Remove(j, 1);
                                //len--;
                                break;
                            }
                        }
                        if (check == 0)
                        {
                            b = false;
                        }
                        check = 0;
                        break;
                    case '[':
                        for (int j = i; j < len; j++)
                        {
                            if (s[j] == ']')
                            {
                                check = 1;
                                //s.Remove(j, 1);
                                //len--;
                                break;
                            }
                        }
                        if (check == 0)
                        {
                            b = false;
                        }
                        check = 0;
                        break;
                    case '{':
                        for (int j = i; j < len; j++)
                        {
                            if (s[j] == '}')
                            {
                                check = 1;
                                //s.Remove(j, 1);
                                //len--;
                                break;
                            }
                        }
                        if (check == 0)
                        {
                            b = false;
                        }
                        check = 0;
                        break;
                    case '<':
                        for (int j = i; j < len; j++)
                        {
                            if (s[j] == '>')
                            {
                                check = 1;
                                //s.Remove(j, 1);
                                //len--;
                                break;
                            }
                        }
                        if (check == 0)
                        {
                            b = false;
                        }
                        check = 0;
                        break;
                }
            }
            return b;
        }
    }
}
