using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1.b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0; int i = 1;
            while (i != n)
            {
                sum += Math.Sin(i);
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
