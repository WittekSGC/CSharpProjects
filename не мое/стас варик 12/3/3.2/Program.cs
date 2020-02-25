using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A, B, C:");
            Console.Write("A = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("B = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("C = ");
            double c = double.Parse(Console.ReadLine());

            if (a + b + c == 2)
            {
                double max = a, min = a; char imax = 'a', imin = 'a';
                if (b>max) { max = b; imax = 'b'; }
                if (c>max) { max = c; imax = 'c'; }
                if (b < min) { min = b; imin = 'b'; }
                if (c < min) { min = c; imin = 'c'; }

                double temp = 0;
                if (imax == 'a') { temp = a; a = min; }  
                if (imax == 'b') { temp = b; b = min; }
                if (imax == 'c') { temp = c; c = min; }
                if (imin == 'a') { a = temp; }
                if (imin == 'b') { b = temp; }
                if (imin == 'c') { c = temp; }
            }
            else if (a + b + c > 20)
            {
                a *= a;
                b *= b;
                c *= c;
            }
            else
            {
                double max = a; char imax = 'a';
                if (b > max) { max = b; imax = 'b'; }
                if (c > max) { max = c; imax = 'c'; }
                if (imax == 'a') a = 34;
                if (imax == 'b') b = 34;
                if (imax == 'c') c = 34;
            }

            Console.WriteLine("A = " + a + ", B = " + b + ", C = " + c);

            Console.ReadKey();
        }
    }
}
