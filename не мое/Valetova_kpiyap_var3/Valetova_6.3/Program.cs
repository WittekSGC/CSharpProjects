using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valetova_6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] monates = new string[12][]
            {
                new string[] {"Январь" },
                new string[] {"Февраль"},
                new string[] {"Март" },
                new string[] {"Апрель"},
                new string[] {"Май" },
                new string[] {"Июнь"},
                new string[] {"Июль" },
                new string[] {"Август"},
                new string[] {"Сентябрь" },
                new string[] {"Октябрь"},
                new string[] {"Ноябрь" },
                new string[] {"Декабрь"},
            };

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(monates[i][0]);
            }

            Console.ReadKey();
        }
    }
}
