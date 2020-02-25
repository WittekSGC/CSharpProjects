using System;

namespace Lab3_Zholudov_dop
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 0;
            Console.Write("x = ");
            int X = int.Parse(Console.ReadLine());
            double x = X;

            if (x > -10 && x <= 0)
            {
                y = -3 - (x / 2);
            }

            if (x > 0 && x <= 3)
            {
                y = -Math.Sqrt(9 - Math.Pow(x, 2));
            }

            if (x>3 && x<=6)
            {
                y = Math.Sqrt(12 * x - Math.Pow(x, 2) - 27);
            }

            if (y == 0) Console.WriteLine("not in a range of function");
            else Console.WriteLine("y = {0}", y);

        }
    }
}
