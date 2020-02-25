using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Zholudov_n1
{
    interface Icomparer
    {
        
    }

    interface IComparable
    {

    }

    abstract class Figure
    {
        public virtual double Square()
        {
            return 0;
        }

        public virtual (double x, double y) Center()
        {
            return (0,0);
        }

        public virtual double Perimeter()
        {
            return 0;
        }
    }

    class Rectangle : Figure, Icomparer
    {
        double _a;
        double _b;
        public Rectangle(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public override double Square()
        {
            return _a * _b;
        }

        public override (double x, double y) Center()
        {
            return (_b/2, _a/2);
        }

        public override double Perimeter()
        {
            return 2 * _a + 2 * _b;
        }
    }

    class Circle : Figure, Icomparer
    {
        double _r, _x, _y;
        public Circle(double r, double x, double y)
        {
            _r = r;
            _x = x;
            _y = y;
        }

        public override double Perimeter()
        {
            return Math.PI*_r*2;
        }

        public override double Square()
        {
            return Math.PI*Math.Pow(_r,2);
        }

        public override (double x, double y) Center()
        {
            return (_x, _y);
        }
    }

    class Trapezium : Figure, Icomparer
    {
        double _a, _b, _c, _d;
        public Trapezium(double a, double b, double c, double d)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }

        public override double Perimeter()
        {
            return _a + _b + _c + _d;
        }

        public override double Square()                       
        {
            return ((_a + _b)/2)*Math.Sqrt(_c * _c - Math.Pow((Math.Pow(_b - _a, 2+_c*_c - _d * _d) + _c * _c - _d * _d)/(2*(_b-_a)),2));
        }

        public override (double x, double y) Center()
        {                       
            double h = Math.Sqrt(_c * _c - Math.Pow(((_b - _a)*(_b - _a)+_c * _c - _d * _d)/(2*(_b-_a)), 2));
            return (0, (h / 3) * ((2 * _b + _a) / (_a + _b)));
        }
    }

    class Picture
    {
        Figure[] figures = new Figure[3];
        public Picture()
        {
            Console.WriteLine("Введите стороны а и б прямоугольника");
            Rectangle rect = new Rectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine("Введите радиус и координаты точки центра окружности");
            Circle circ = new Circle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine("Введите стороны трапеции: сначала основания, затем боковые стороны");
            Trapezium trap = new Trapezium(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            figures[0] =  rect;
            figures[1] =  circ;
            figures[2] =  trap;
        }

        public void Print()
        {
            double x, y, a, b;

            for (int i = 0; i < 3; i++)
            {
                x = figures[i].Center().x;
                y = figures[i].Center().y;
                a = figures[i].Perimeter();
                b = figures[i].Square();
                Console.WriteLine("Периметр: {0} | Площадь: {1} | Центр тяжести: {2},{3}", a, b, x, y);
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Picture picture = new Picture();
            picture.Print();
            Console.ReadKey();
        }
    }
}
