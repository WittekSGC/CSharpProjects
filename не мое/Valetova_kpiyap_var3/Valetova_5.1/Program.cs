using System;

namespace Valetova_5._1
{
    class Trapeziya
    {
        protected double _top;
        protected double _bot;
        protected double _left;
        protected double _rigth;
        protected double _heigth;
        protected double _square;
        protected double _midlane;
        protected string _class_name;

        public Trapeziya(double a, double b, double c, double d)
        {
            _class_name = "Trapeziya";
            _top = a;
            _bot = b;
            _left = c;
            _rigth = d;
            _heigth = Math.Sqrt(c * c - Math.Pow((Math.Pow((a - b), 2) + c * c - d * d) / (2 * (b - a)), 2));
            _square = _heigth * (a + b) / 2;
            _midlane = (a + b) / 2;
        }

        public double GetHeigth()
        {
            return _heigth;
        }

        public double GetSquare()
        {
            return _square;
        }

        public double GetMiddleLane()
        {
            return _midlane;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры трапеции в следующем порядке:");
            Console.WriteLine("Верхний, нижний, размер слева, размер справа ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            Trapeziya trap = new Trapeziya(a, b, c, d);
            Console.WriteLine("Высота = {0}", trap.GetHeigth());
            Console.WriteLine("Площадь = {0}", trap.GetSquare());
            Console.WriteLine("Средняя линия = {0}", trap.GetMiddleLane());

            Console.ReadKey();
        }
    }
}
