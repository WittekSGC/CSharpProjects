using System;

namespace Lab3_Zholuov_dop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter r = ");
            double r = Convert.ToDouble(Console.ReadLine());

            if (((Math.Pow(x, 2) + Math.Pow(y, 2) == Math.Pow(r, 2)) && (y>=0)) || ((x >= y) && (x <= 0) && (y <= 0) && (y >= -r) && (x >= -r)))
                Console.WriteLine("yes");
            else Console.WriteLine("no");
            

        }
    }
}
