using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignatovytch_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            string[] n = s.Split(' ');
            int[] m = new int[n.Length];
            int count = 0;
            for (int i = 0; i < n.Length; i++)
            {
                m[i] = int.Parse(n[i]);
                if (m[i] % 5 == 0) count++;
            }
            Console.WriteLine("Количество слов в введенной строке: " + n.Length);
            Console.WriteLine("Количество слов, кратные 5: " + count);
            Console.ReadKey();

        }
    }
}
