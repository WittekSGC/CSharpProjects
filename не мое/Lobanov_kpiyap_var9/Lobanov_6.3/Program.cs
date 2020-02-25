using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lobanov_6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] location = new string[10][]
                {
                    new string[] { "Беларусь" },
                    new string[] { "Болгария" },
                    new string[] { "Венгрия" },
                    new string[] { "Молдавия" },
                    new string[] { "Польша" },
                    new string[] { "Россия" },
                    new string[] { "Румыния" },
                    new string[] { "Словакия" },
                    new string[] { "Украина" },
                    new string[] { "Чехия" },
                };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(location[i][0]);
            }
            Console.ReadKey();
        }
    }
}
