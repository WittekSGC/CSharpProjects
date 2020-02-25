using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valetova_5._2
{
    class Triangle
    {
        public int _a { get; set; }
        public int _b { get; set; }
        public int _c { get; set; }
        protected int _perimeter { get; set; }
        protected double _square { get; set; }
        protected bool _tryining { get; set; }

        public Triangle(int a, int b, int c)
        {
            if (a+b<c || a+c<b || b+c<a)
            {
                _tryining = false;
                _a = 0;
                _b = 0;
                _c = 0;
                _perimeter = 0;
                _square = 0;
            }
            else
            {
                _tryining = true;
                _a = a;
                _b = b;
                _c = c;
                _perimeter = a + b + c;
                _square = Math.Sqrt(_perimeter / 2 * (_perimeter / 2 - a) * (_perimeter / 2 - b) * (_perimeter / 2 - c));
            }
        }

        public int GetSide(char n)   //вводишь нужную сторону на англ - получаешь в ответ длинну стороны
        {
            if (n == 'a') return _a;
            else if (n == 'b') return _b;
            else if (n == 'c') return _c;
            else return 0;
        }

        public int GetPerimeter()
        {
            return _perimeter;
        }

        public double GetSquare()
        {
            return _square;
        }

        public bool GetTryining()
        {
            return _tryining;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 3 стороны треугольника \na = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(a, b, c);
            if (triangle.GetTryining() == false) Console.WriteLine("Такого треугольника не существует");
            else
            {
                Console.WriteLine("сторона b = {0}", triangle.GetSide('b'));
                Console.WriteLine("периметр треугольника = {0}", triangle.GetPerimeter()); ;
                Console.WriteLine("площадь треугольника = {0}", triangle.GetSquare()); ;
            }
            Console.ReadKey();
        }
    }
}
