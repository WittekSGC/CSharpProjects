using System;

namespace Lab2_Zholudov
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.297;
            double b = 0.5054;
            double x = 2.1212;
            double m = 3;
            double y = Math.Sqrt(a * Math.Sqrt(Math.PI) + Math.Pow(Math.E, b * x)) * (m * Math.Log10(a + (x / Math.Sin(x))));
            Console.WriteLine();
            Console.WriteLine("y = " + y);
            Console.ReadKey();Math.Log
        }

    }
}

