using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("L = ");
            int l = int.Parse(Console.ReadLine());
            int k; double w = 0;
            if (l % 7 == 0) k = 1;
            else if (l % 7 == 2 || l % 7 == 3) k = 2;
            else if (l % 7 == 5) k = 3;
            else k = 4;
            switch (k)
            {
                case 1: w = Math.PI * Math.Pow(l, 2) + Math.Sqrt(l); break;
                case 2: w = Math.Pow(l, 5) / (l + 2); break;
                case 3: w = Math.Pow(Math.E, l * Math.Sin(l)) / (1 + l * Math.Log10(l)); break;
                case 4: w = 75.3; break;
            }

            Console.WriteLine("W = " + w);
            Console.ReadKey();
        }
    }
}
