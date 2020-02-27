using System;
using System.Collections.Generic;

namespace Roshka_11
{
    abstract class Solution
    {
        public double solute;
        public int number;
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
            number = 1;
            _b = b;
            _x = x;
            _k = k;
            solute = _k * _x + _b;
        }

        public override double GetSolute()
        {
            return solute;
        }
    }

    class Square : Solution
    {
        private double _b, _a, _x, _c;
        public Square(double a, double b, double c, double x)
        {
            number = 2;
            _a = a;
            _b = b;
            _c = c;
            _x = x;
            solute = _a * _x * _x + _b * _x + _c;
        }

        public override double GetSolute()
        {
            return solute;
        }
    }

    class Series : IComparer<Solution>
    {
        Solution[] solutions = new Solution[2];
        List<Solution> list = new List<Solution>();

        public Series()
        {
            Console.WriteLine("Введите данные для решения линейного уравнения:<коэфициент><Свободный член><параметр x>");
            Linear linear = new Linear(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            solutions[0] = linear;
            Console.WriteLine("Введите данные для решения rквадратного уравнения:<коэфициент а><коэфициент b><свободный член c><параметр x>");
            Square square = new Square(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            solutions[1] = square;
            for (int i = 0; i < solutions.Length; i++)
            {
                list.Add(solutions[i]);
            }
            list.Sort(Compare);
        }

        //comparer сортирует от большего к меньшему по рузельтату 
        public int Compare(Solution x, Solution y)
        {
            if (x.solute < y.solute) return 1;
            else if (x.solute > y.solute) return -1;
            else return 0;
        }

        public void PrintResult()
        {
            foreach (var a in list)
            {
                Console.WriteLine("Решением уравнения {0} является значение {1}", a.number, a.GetSolute());
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
