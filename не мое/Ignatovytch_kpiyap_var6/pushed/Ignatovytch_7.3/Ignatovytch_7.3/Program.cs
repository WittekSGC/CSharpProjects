using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignatovytch_7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кодируемую строку↓");
            string nocode = Console.ReadLine();
            string code = "";
            int n = 3;

            string chars_rus1 = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ";
            string chars_rus2 = chars_rus1.ToLower();
            string rus = chars_rus1 + chars_rus2;
            string chars_eng1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";
            string chars_eng2 = chars_eng1.ToLower();
            string eng = chars_eng1 + chars_eng2;

            for (int i = 0; i < nocode.Length; i++)
            {
                if (rus.IndexOf(nocode[i]) != -1) code += rus[(rus.IndexOf(nocode[i]) + n) % rus.Length];
                if (eng.IndexOf(nocode[i]) != -1) code += eng[(eng.IndexOf(nocode[i]) + n) % eng.Length];
            }

            Console.WriteLine(code);
            Console.ReadKey();
        }
    }
}
