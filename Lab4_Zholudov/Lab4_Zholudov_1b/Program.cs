using System;

namespace Lab4_Zholudov_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double k = 3.0;
            double sum = -1 / k;
            Console.Write("-1/3 ");
            int i = 1;
            while (i<n) 
            {
                Console.Write(" + 1/{0} ", k);
                sum += 1 / k;
                k = Math.Abs(k) + 2;
                i++;
            }
            Console.WriteLine("= {0}", sum);
            Console.ReadKey();
        }
    }
}