using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valetova_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;
            char b;

            Console.Write("Введите Ваше ФИО: ");
            string fio = Console.ReadLine();
            Console.WriteLine("Длинна строки - {0}", fio.Length);

            //вставить знак "-" между каждой буквой фамилии и имени
            int n = fio.IndexOf(' ');
            temp = fio;
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

            Console.WriteLine(fio + " - выполнила студентка специальности 2-40 01 01, группа 3ПОБШ");

            temp = fio;
            string initials = "";
            initials += temp[0];
            initials += ".";
            n = temp.IndexOf(' ');
            initials += temp[n + 1];
            initials += ".";
            initials += o[0];
            initials += ".";
            Console.WriteLine(initials);
            Console.ReadKey();
        }
    }
}
