using System;

namespace _3._1.b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            if (n == 1) Console.WriteLine("One");
            if (n == 2) Console.WriteLine("Two");
            if (n == 3) Console.WriteLine("Three");
            if (n == 4) Console.WriteLine("Four");
            if (n == 5) Console.WriteLine("Five");

            Console.ReadKey();
        }
    }
}
