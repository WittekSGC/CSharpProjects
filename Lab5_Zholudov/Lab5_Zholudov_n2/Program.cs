using System;

namespace Lab5_Zholudov_n2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a,b");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(a,b);
            float perim = rect.GetPerimeter();
            Console.WriteLine(perim);
            Console.WriteLine(rect.GetSquare());
            Console.WriteLine(rect.GetLength());
        }
    }
}
