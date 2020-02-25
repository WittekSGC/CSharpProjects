using System;

namespace Lab2_Zholudov__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double D = -1 * Math.Pow( Math.E, -1 * Math.Cos(Math.Sqrt(x + 5 / 3))) - 1.7 * Math.Atan((x/5)-(3*4))*Math.Sin(1.7*x);
            Console.WriteLine();
            Console.WriteLine("D = {0}", D);
            Console.ReadKey();
        }
    }
}
