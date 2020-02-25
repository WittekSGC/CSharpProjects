using System;

namespace Lab3_Zholudov_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp;
            Console.WriteLine("Enter a number 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a number 2:");
            double b = Convert.ToDouble(Console.ReadLine());

            if ((a > 0) && (b > 0) && (a + b < 15))
            {
                temp = a * b;
                a = temp;
                b = temp;
            }
            else
            {

                if ((a < -3) || (b < -3))
                {
                    a = 2 * a;
                    b = 2 * b;
                } else
                {
                    if (a>b)
                    {
                        a = Math.Pow(a, 2);
                        b = 0;
                    }
                    else
                    {
                        if (b>a)
                        {
                            b = Math.Pow(a, 2);
                            a = 0;
                        }
                    }
                }
            }
            Console.WriteLine("a = {0}  b = {1}",a,b);
        }
    }
}
