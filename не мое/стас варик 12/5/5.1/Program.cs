using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class Program
    {
        class ThreePrizm
        {
            double a { get; set; }
            double b { get; set; }
            double c { get; set; }
            double h { get; set; }
            public string classname { get; set; } = "ThreePrizm";

            public ThreePrizm()
            {
                Console.Write("a = "); a = double.Parse(Console.ReadLine());
                Console.Write("b = "); b = double.Parse(Console.ReadLine());
                Console.Write("c = "); c = double.Parse(Console.ReadLine());
                Console.Write("h = "); h = double.Parse(Console.ReadLine());
            }

            public double BaseSquare()
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }

            public (double a, double b, double c, double h) ReturnParameters()
            {
                return (a, b, c, h);
            }

            public double Volume()
            {
                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s * h;
            }


        }
        static void Main(string[] args)
        {
            ThreePrizm prizm = new ThreePrizm();
            Console.WriteLine("Площадь основания: " + prizm.BaseSquare());
            Console.WriteLine("Объем: " + prizm.Volume());
            Console.WriteLine("Имя класса: " + prizm.classname);
            Console.Write("Введите новое название класса: ");
            prizm.classname = Console.ReadLine();
            Console.WriteLine("Имя класса: " + prizm.classname);
            Console.ReadKey();
        }
    }
}
