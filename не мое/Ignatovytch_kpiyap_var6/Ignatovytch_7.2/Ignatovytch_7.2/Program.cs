﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignatovytch_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp, kemp;

            Console.Write("Введите Ваше ФИО: ");
            string fio = Console.ReadLine();
            Console.WriteLine("Длинна строки - {0}", fio.Length);

            //вставить знак "-" между каждой буквой фамилии и имени
            int n = fio.IndexOf(' ');
            temp = fio;
            kemp = fio;
            temp = temp.Remove(n, 1);
            for (int i = 0; i < n - 1; i++)
            {
                fio = fio.Insert(2 * i + 1, "-");
            }
            int m = temp.IndexOf(' ');
            string o = temp.Remove(0, m + 1);
            for (int i = n; i <= m; i++)
            {
                fio = fio.Insert(2 * i - 1, "-");
            }
            fio = fio.Replace("- -", " ");
            Console.WriteLine(fio);

            //повысить регистр гласных букв фамилии
            string s1 = "аоуыэяёюеиeuioa";
            string s2 = s1.ToUpper();
            temp = o;
            for (int i = 0; i < o.Length; i++)
            {
                for (int j = 0; j < s1.Length; j++)
                {
                    if (o[i] == s1[j])
                    {
                        o = o.Replace(s1[j], s2[j]);
                    }
                }
            }
            fio = fio.Replace(temp, o);
            Console.WriteLine(fio);

            Console.WriteLine(fio + " - выполнил студент специальности 2-40 01 01, группа 3ПОБШ");

            n = kemp.IndexOf(' ');
            Console.WriteLine("Количество букв в фамилии: " + n);
            kemp = kemp.Remove(0, n+1);
            n = kemp.IndexOf(' ');
            kemp = kemp.Remove(n, kemp.Length-n);
            Console.WriteLine("Имя: " + kemp);

            Console.ReadKey();
        }
    }
}
