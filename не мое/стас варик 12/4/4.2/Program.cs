using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x0 = 1, xk = 2.2, dx = 0.2, b = 3.2, y = 0;
            Console.WriteLine("parameters: x0 = {0}, xk = {1}, dx = {2}", x0, xk, dx);
            Console.WriteLine("  x  |  y  "); bool finish = true;
            while (finish)
            {
                y = 9 * (Math.Pow(x0, 3) + Math.Pow(b, 3)) * Math.Tan(x0);
                x0 += dx;
                Console.WriteLine($"{x0,5}|{y,5}");
                if (x0 >= xk-dx) finish = false;
            }
            Console.ReadKey();
        }
    }
}
