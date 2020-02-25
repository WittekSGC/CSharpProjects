using System;

namespace Lab5_Zholudov_n1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(1, 1, 10, 10);
            double perimeter;
            perimeter = rect.GetPerimeter();
            string className;
            className = Rectangle.GetClassName();
            Console.WriteLine(perimeter);
            Console.WriteLine(className);
            rect.SetRectanglePosition(15, 15);
            double s = rect.GetWeight();
            Console.WriteLine("{0}", Convert.ToString(s));
            Console.ReadKey();
        }
    }
}
