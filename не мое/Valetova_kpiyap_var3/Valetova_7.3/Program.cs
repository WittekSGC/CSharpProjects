using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valetova_7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string nocode = Console.ReadLine();
            string code = "";

            string low_register = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string high_register = low_register.ToUpper();

            int k = -1, l = -1; char temp;
            for (int i = 0; i < nocode.Length; i++)
            {
                temp = nocode[i];
                k = low_register.IndexOf(temp);
                l = high_register.IndexOf(temp);
                if (k != -1 || l != -1)
                {
                    if (k != -1) temp = low_register[Math.Abs(k - 33)];
                    if (l != -1) temp = high_register[Math.Abs(l - 33)];
                }
                code += temp;
                k = -1;
                l = -1;
            }

            Console.WriteLine(code);
            Console.ReadKey();
        }
    }
}
