using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignatovytch_6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] belarus = new string[6][]
            {
                new string[] {"Брест"},
                new string[] {"Витебск"},
                new string[] {"Гомель"},
                new string[] {"Гродно"},
                new string[] {"Могилев"},
                new string[] {"Минск"},
            };

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(belarus[i][0]);
            }
            Console.ReadKey();
        }
    }
}
