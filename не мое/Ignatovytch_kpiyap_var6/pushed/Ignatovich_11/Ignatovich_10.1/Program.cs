using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignatovich_11
{
    class Program
    {
        public abstract class Body
        {
            public double volume;
            public string name;
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
            public double first, second, third, angle;
            
            public Parallelepiped(double a, double b, double c, double d)
            {
                name = "Paralellepiped";
                first = a;
                second = b;
                third = c;
                angle = d;
                double h = third * Math.Sin(angle * Math.PI / 180);
                volume = first * second * h;
            }
            public override double GetVolume()
            {
                return volume;
            }

            public override double GetSquarePP()
            {
                return 2 * first * second + 2 * first * third + 2 * second * third;
            }
        }

        class Cone : Body
        {
            public double radius, heigth;

            public Cone(double r, double h)
            {
                name = "Cone";
                radius = r;
                heigth = h;
                volume = heigth / 3 * Math.PI * radius * radius;
            }

            public override double GetVolume()
            {
                return volume;
            }

            public override double GetSquarePP()
            {
                double l = Math.Sqrt(heigth * heigth + radius * radius);
                return Math.PI*l*radius+Math.PI*radius*radius;
            }
        }

        class Ball : Body
        {
            public double radius;
            public Ball(double r)
            {
                name = "Ball";
                radius = r;
                volume = 4 / 3 * Math.PI * radius * radius * radius;
            }

            public override double GetSquarePP()
            {
                return 4 * Math.PI * radius * radius;
            }

            public override double GetVolume()
            {
                return volume;
            }
        }

        public class Series : IComparer<Body>
        {
            Body[] bodies = new Body[3];
            List<Body> bodyList = new List<Body>();

            public Series()
            {
                Console.WriteLine("Введите длинну, ширину и высоту параллелепипеда, а так же его угол у основания");
                Parallelepiped par = new Parallelepiped(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                bodies[0] = par;
                bodyList.Add(bodies[0]);
                Console.WriteLine("Введите радиус и высоту конуса:");
                Cone cone = new Cone(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                bodies[1] = cone;
                bodyList.Add(bodies[1]);
                Console.WriteLine("Введите радиус шара:");
                Ball ball = new Ball(double.Parse(Console.ReadLine()));
                bodies[2] = ball;
                bodyList.Add(bodies[2]);

                bodyList.Sort(Compare);
            }

            public int Compare(Body x, Body y)
            {
                if (x.volume < y.volume)
                    return 1;
                else if (x.volume > y.volume)
                    return -1;
                else
                    return 0;
            }

            public void Print()
            {
                Console.WriteLine("Параллелепипед:\nОбъем: {0}, Площадь полной поверхности: {1}", bodies[0].GetVolume(), bodies[0].GetSquarePP());
                Console.WriteLine("Конус:\nОбъем: {0}, Площадь полной поверхности: {1}", bodies[1].GetVolume(), bodies[1].GetSquarePP());
                Console.WriteLine("Шар:\nОбъем: {0}, Площадь полной поверхности: {1}", bodies[2].GetVolume(), bodies[2].GetSquarePP());
            }

            public void SortPrint()
            {
                foreach (var bodyItem in bodyList)
                {
                    Console.WriteLine(bodyItem.name + " volume: " + bodyItem.volume);
                }
            }
        }
        static void Main(string[] args)
        {
            Series series = new Series();
            series.Print();
            series.SortPrint();
            Console.ReadKey();
        }
    }
}
