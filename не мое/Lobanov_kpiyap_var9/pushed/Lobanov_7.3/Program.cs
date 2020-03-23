using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lobanov_7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string s1 = Console.ReadLine();
            string s2 = "";

            for (int i = 0; i < s1.Length; i++)
            {
                if (i % 2 == 0)
                {
                    s2 += s1[i];
                }
            }
            for (int i = 0; i < s1.Length; i++)
            {
                if (i % 2 == 1)
                {
                    s2 += s1[i];
                }
            }

            Console.WriteLine("Зашифрованная строка: " + s2);
            Console.ReadKey();
        }
    }
}
