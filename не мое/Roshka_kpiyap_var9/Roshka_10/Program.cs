using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshka_10
{
    abstract class Solution
    {
        public virtual double GetSolute()
        {
            return 0;
        }
    }

    class Linear : Solution
    {
        private double _b, _k, _x;
        public Linear(double k, double b, double x)
        {
            _b = b;
            _x = x;
            _k = k;
        }

        public override double GetSolute()
        {
            return _k * _x + _b;
        }
    }

    class Square : Solution
    {
        private double _b, _a, _x, _c;
        public Square(double a, double b, double c, double x)
        {
            _a = a;
            _b = b;
            _c = c;
            _x = x;
        }

        public override double GetSolute()
        {
            return _a * _x * _x + _b * _x + _c;
        }
    }

    class Series
    {
        Solution[] solutions = new Solution[2];

        public Series()
        {
            Console.WriteLine("Введите данные для решения линейного уравнения:<коэфициент><Свободный член><параметр x>");
            Linear linear = new Linear(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            solutions[0] = linear;
            Console.WriteLine("Введите данные для решения rквадратного уравнения:<коэфициент а><коэфициент b><свободный член c><параметр x>");
            Square square = new Square(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            solutions[1] = square;
        }

        public void PrintResult()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Решением уравнения {0} является значение {1}", i + 1, solutions[i].GetSolute());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Series series = new Series();
            series.PrintResult();
            Console.ReadKey();
        }
    }
}
