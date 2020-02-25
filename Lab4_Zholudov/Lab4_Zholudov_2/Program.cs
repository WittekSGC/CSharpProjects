using System;

namespace Lab4_Zholudov_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x0 = 5.3");
            Console.WriteLine("xn = 10.3");
            Console.WriteLine("dx = 0.25");
            Console.WriteLine("a = 1.35");
            Console.WriteLine("b = -6.25");
            Console.WriteLine();

            double a = 1.35, b = -6.25, i = 5.3, x, y;

            while (i<=10.3)
            {
                x = i;
                y = a * Math.Pow(x, 3) + Math.Pow(Math.Cos(Math.Pow(x,3)-b),2); 
                i += 0.25;
                Console.WriteLine("x = {0}   y = {1}", x, y);
            }
            Console.ReadKey();
        }
    }
}
