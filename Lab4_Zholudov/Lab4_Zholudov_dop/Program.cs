using System;

namespace Lab4_Zholudov_dop
{
    class Program
    {
        static void Main(string[] args)
        {
            double xn, xk, dx, e, x, y = 0.0;
            int i = 1, n = 1;
            Console.Write("enter first x: xn = ");
            xn = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter last x: xk = ");
            xk = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter one step x: dx = ");
            dx = Convert.ToDouble(Console.ReadLine());
            e = 3;
            Console.WriteLine("accuracy number: e = {0}", e);
            Console.WriteLine();
            Console.WriteLine("|     x     |     y     |     n     |");
            Console.WriteLine("-------------------------------------");

            while (xn <= xk)
            {
                x = xn;
                y += (Math.Pow(x,i)/i)*Math.Pow(-1,i+1);
                Console.WriteLine($"|{x,-11}|{y,-11}|{n,-11}|");
                Console.WriteLine("-------------------------------------");
                xn += dx;
                n++;
            }
            Console.ReadKey();
        }
    }
}
