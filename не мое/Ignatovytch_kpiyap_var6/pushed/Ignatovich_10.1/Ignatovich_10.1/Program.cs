using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignatovich_10._1
{
    class Program
    {
        abstract class Body
        {
            public virtual double GetVolume()
            {
                return 0;
            }

            public virtual double GetSquarePP()
            {
                return 0;
            }
        }

        class Parallelepiped : Body
        {
            double first, second, third, angle;
            public Parallelepiped(double a, double b, double c, double d)
            {
                first = a;
                second = b;
                third = c;
                angle = d;
            }
            public override double GetVolume()
            {
                double h = third * Math.Sin(angle * Math.PI / 180);
                return first * second * h;
            }

            public override double GetSquarePP()
            {
                return 2 * first * second + 2 * first * third + 2 * second * third;
            }
        }

        class Cone : Body
        {
            double radius, heigth;

            public Cone(double r, double h)
            {
                radius = r;
                heigth = h;
            }

            public override double GetVolume()
            {
                return heigth/3*Math.PI*radius*radius;
            }

            public override double GetSquarePP()
            {
                double l = Math.Sqrt(heigth * heigth + radius * radius);
                return Math.PI*l*radius+Math.PI*radius*radius;
            }
        }

        class Ball : Body
        {
            double radius;
            public Ball(double r)
            {
                radius = r;
            }

            public override double GetSquarePP()
            {
                return 4*Math.PI*radius*radius;
            }

            public override double GetVolume()
            {
                return 4/3*Math.PI*radius*radius*radius;
            }
        }

        class Series
        {
            Body[] bodies = new Body[3];

            public Series()
            {
                Console.WriteLine("Введите длинну, ширину и высоту параллелепипеда, а так же его угол у основания");
                Parallelepiped par = new Parallelepiped(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                bodies[0] = par;
                Console.WriteLine("Введите радиус и высоту конуса:");
                Cone cone = new Cone(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                bodies[1] = cone;
                Console.WriteLine("Введите радиус шара:");
                Ball ball = new Ball(double.Parse(Console.ReadLine()));
                bodies[2] = ball;
            }

            public void Print()
            {
                Console.WriteLine("Параллелепипед:\nОбъем: {0}, Площадь полной поверхности: {1}", bodies[0].GetVolume(), bodies[0].GetSquarePP());
                Console.WriteLine("Конус:\nОбъем: {0}, Площадь полной поверхности: {1}", bodies[1].GetVolume(), bodies[1].GetSquarePP());
                Console.WriteLine("Шар:\nОбъем: {0}, Площадь полной поверхности: {1}", bodies[2].GetVolume(), bodies[2].GetSquarePP());
            }
        }
        static void Main(string[] args)
        {
            Series series = new Series();
            series.Print();
            Console.ReadKey();
        }
    }
}
