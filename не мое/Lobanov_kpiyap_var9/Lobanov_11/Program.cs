using System;
using System.Collections.Generic;

namespace Lobanov_10._1
{
    abstract class Solution
    {
        public double solutionValue;
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
            solutionValue = _k * _x + _b;
        }

        public override double GetSolute()
        {
            return solutionValue;
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
            solutionValue = _a * _x * _x + _b * _x + _c;
        }

        public override double GetSolute()
        {
            return solutionValue;
        }
    }

    class Series : IComparer<Solution>
    {
        Solution[] solutions = new Solution[2];
        List<Solution> solList = new List<Solution>();

        public Series()
        {
            Console.WriteLine("Введите данные для решения линейного уравнения:<коэфициент><Свободный член><параметр x>");
            Linear linear = new Linear(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            solutions[0] = linear;
            solList.Add(solutions[0]);

            Console.WriteLine("Введите данные для решения rквадратного уравнения:<коэфициент а><коэфициент b><свободный член c><параметр x>");
            Square square = new Square(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            solutions[1] = square;
            solList.Add(solutions[1]);

            solList.Sort(Compare);
        }

        public int Compare(Solution x, Solution y)
        {
            if (x.solutionValue < y.solutionValue)
                return -1;
            else
                if (x.solutionValue > y.solutionValue)
                return 1;
            else
                return 0;
        }

        public void PrintResult()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Решением уравнения {0} является значение {1}", i + 1, solutions[i].GetSolute());
            }
        }

        public void PrintSortResult()
        {
            int count = 0;
            foreach (Solution item in solList)
            {
                Console.WriteLine("solution value {0}: {1}", ++count, item.solutionValue);                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Series series = new Series();
            series.PrintResult();
            Console.WriteLine();
            Console.WriteLine("Sorting:");
            series.PrintSortResult();
            Console.ReadKey();
        }
    }
}
