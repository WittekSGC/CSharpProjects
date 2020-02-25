using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Zholudov_n3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text to coding");
            string text = Console.ReadLine();
            Console.Write("Enter number of language operaion (1 - english, 2 - russian): ");
            int menu = int.Parse(Console.ReadLine());
            string eng_abc = "1234567890abcdefghijklmnopqrstuvwxyz';_-:/";
            string rus_abc = "абвгдеёжзиклмнопрстуфхцчшщъыьэюя1234567890";
            string code ="";
            int n = text.Length;

            if (menu == 1) //english
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < eng_abc.Length; j++)
                    {
                        if (text[i] == eng_abc[j]) code += rus_abc[j];
                        else code += text[i];
                    }
                }
                Console.WriteLine("code text = {0}", code);
            }
            else if (menu == 2) //russian
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < rus_abc.Length; j++)
                    {
                        if (text[i] == rus_abc[j]) code += eng_abc[j];
                    }
                }
                Console.WriteLine("code text = {0}", code);
            }
            else //another inputing
            {
                Console.WriteLine("erroring input");
            }
            Console.ReadKey();
        }
    }
}
