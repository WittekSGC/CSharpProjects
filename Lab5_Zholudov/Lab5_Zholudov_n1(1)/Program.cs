using System;

namespace Lab5_Zholudov_n1_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle trin = new Triangle(1, 3, 3, 1, 1, 1);
            double l = trin.GetLength(1);
            Console.WriteLine(trin.GetPositions());
            Console.WriteLine("----------------");
            Console.WriteLine(l);
            l= trin.GetLength(2);
            Console.WriteLine(l);
            l = trin.GetLength(3);
            Console.WriteLine(l);
            Console.WriteLine("----------------");
            Console.WriteLine(trin.GetPerimeter());
            trin.ChangePositions(1, 4, 4, 1, 1, 1);
            Console.WriteLine("----------------");
            Console.WriteLine(trin.GetPositions());
            /*Console.WriteLine(trin.GetAngle(1));
            Console.WriteLine(trin.GetAngle(2));
            Console.WriteLine(trin.GetAngle(3));*/
        }
    }
}
