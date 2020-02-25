using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sechko_10._1
{
    abstract class Function
    {
        public virtual double GetY()
        {
            return 0;
        }
    }

    class Ellipse : Function
    {
        double a, b, x;

        public Ellipse(double aa, double bb, double xx)
        {
            a = aa;
            b = bb;
            x = xx;
        }

        public override double GetY()
        {
            return Math.Sqrt((1 - x * x / a / a) * b * b);
        }
    }

    class Hiperbola : Function
    {
        double a, b, x;

        public Hiperbola(double aa, double bb, double xx)
        {
            a = aa;
            b = bb;
            x = xx;
        }

        public override double GetY()
        {
            return Math.Sqrt((x * x / a / a - 1) * b * b);
        }
    }

    class Parabola : Function
    {
        double x, p;

        public Parabola(double xx, double pp)
        {
            x = xx;
            p = pp;
        }

        public override double GetY()
        {
            return Math.Sqrt(2*p*x) ;
        }
    }

    class Series
    {
        Function[] functions = new Function[3];

        public Series()
        {
            Console.WriteLine("Введите коэфициенты а и b, а также значение x для нахождения требуемой точки y эллипса");
            Ellipse ellipse = new Ellipse(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            functions[0] = ellipse;
            Console.WriteLine("Введите коэфициенты а и b, а также значение x для нахождения требуемой точки y гиперболы");
            Hiperbola hiperbola = new Hiperbola(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            functions[1] = hiperbola;
            Console.WriteLine("Введите коэфициент p, а также значение x для нахождения требуемой точки y параболы");
            Parabola parabola = new Parabola(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            functions[2] = parabola;
        }

        public void Print()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(functions[i].GetY());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Series series = new Series();
            series.Print();
            Console.ReadKey();
        }
    }
}
