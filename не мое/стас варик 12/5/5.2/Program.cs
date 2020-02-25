using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    class Trapeze
    {
        int a { get; set; }
        int b { get; set; }
        int c, d;

        public Trapeze(int aa, int bb, int cc, int dd)
        {
            a = aa;//меньшая параллель
            b = bb;//большая параллель
            c = cc;//боковая 1
            d = dd;//боковая 2
        }

        public (int a, int b, int c, int d) GetLengths()
        {
            return (a, b, c, d);
        }

        public int GetPerimeter()
        {
            return a + b + c + d;
        }

        public double GetSquare()
        {
            return (a + b) / 2 * Math.Sqrt(c * c - (c * c - d * d + (b - a) * (b - a)) / (2 * (b - a)));
        }

        public bool Ravnost()
        {
            if (c == d) return true;
            else return false;
        }

        public void SetLength()
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сначала две параллели(меньшую, затем большую), а после две боковые стороны");
            Trapeze trapeze = new Trapeze(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("Периметр: " + trapeze.GetPerimeter());
            Console.WriteLine("Стороны: " + trapeze.GetLengths());
            Console.WriteLine("Площадь: " + trapeze.GetSquare());
            if (trapeze.Ravnost()) Console.WriteLine("Трапеция равнобедренная");
            else Console.WriteLine("Трапеция неравнобедренная");

            Console.ReadKey();
        }
    }
}
