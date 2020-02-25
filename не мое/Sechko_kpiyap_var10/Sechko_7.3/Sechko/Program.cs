using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sechko
{
    class Program
    {
        static void Main(string[] args)
        {
            string eng_alphabet = "abcdefghijklmnopqrstuvwxyz";
            eng_alphabet += eng_alphabet.ToUpper();
            string rus_alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            rus_alphabet += rus_alphabet.ToUpper();

            Console.Write("Enter string: ");
            string stroke = Console.ReadLine();
            string oncode = "";

            for (int i = 0; i < stroke.Length; i++)
            {
                if (eng_alphabet.IndexOf(stroke[i]) != -1 && i % 2 == 0) oncode += stroke[i];
                if (rus_alphabet.IndexOf(stroke[i]) != -1 && i % 2 == 0) oncode += stroke[i];
            }
            for (int i = stroke.Length-1; i >= 0; i--)
            {
                if (eng_alphabet.IndexOf(stroke[i]) != -1 && i % 2 == 1) oncode += stroke[i];
                if (rus_alphabet.IndexOf(stroke[i]) != -1 && i % 2 == 1) oncode += stroke[i];
            }

            Console.WriteLine("Result: " + oncode);
            Console.ReadKey();
        }
    }
}
