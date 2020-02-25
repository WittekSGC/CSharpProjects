using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Point
    {
        public double x1 { get; set; }
        public double x2 { get; set; }
        public double y1 { get; set; }
        public double y2 { get; set; }
    }

    class Line : Point
    {
        double x3 { get; set; }
        double x4 { get; set; }
        double y3 { get; set; }
        double y4 { get; set; }

        public Line()
        {
            base.x1 = double.Parse(Console.ReadLine());
            base.x2 = double.Parse(Console.ReadLine());
            base.y1 = double.Parse(Console.ReadLine());
            base.y2 = double.Parse(Console.ReadLine());
            x3 = double.Parse(Console.ReadLine());
            x4 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());
            y4 = double.Parse(Console.ReadLine());
        }

        public (double x1, double x2, double y1, double y2, double x3, double x4, double y3, double y4) GetPoints()
        {
            return (x1, x2, y1, y2, x3, x4, y3, y4);
        }
    }

    class ColoredPoint : Point
    {
        double x3 { get; set; }
        double x4 { get; set; }
        double y3 { get; set; }
        double y4 { get; set; }
        string colore { get; set; }
        public ColoredPoint()
        {
            base.x1 = double.Parse(Console.ReadLine());
            base.x2 = double.Parse(Console.ReadLine());
            base.y1 = double.Parse(Console.ReadLine());
            base.y2 = double.Parse(Console.ReadLine());
            x3 = double.Parse(Console.ReadLine());
            x4 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());
            y4 = double.Parse(Console.ReadLine());
        }

        public (double x1, double x2, double y1, double y2, double x3, double x4, double y3, double y4, string color) GetPoints()
        {
            return (x1, x2, y1, y2, x3, x4, y3, y4, colore);
        }
    }

    class ColoredLine : Line
    {
        double x3 { get; set; }
        double x4 { get; set; }
        double y3 { get; set; }
        double y4 { get; set; }
        string colore { get; set; }
        public ColoredLine()
        {
            base.x1 = double.Parse(Console.ReadLine());
            base.x2 = double.Parse(Console.ReadLine());
            base.y1 = double.Parse(Console.ReadLine());
            base.y2 = double.Parse(Console.ReadLine());
            x3 = double.Parse(Console.ReadLine());
            x4 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());
            y4 = double.Parse(Console.ReadLine());
        }

        public (double x1, double x2, double y1, double y2, double x3, double x4, double y3, double y4, string color) GetPoints()
        {
            return (x1, x2, y1, y2, x3, x4, y3, y4, colore);
        }
    }

    class PolyLine : Line
    {
        int n { get; set; }
        public PolyLine()
        {
            n = int.Parse(Console.ReadLine());
            Line[] lines = new Line[n];
            for (int i = 0; i < n-1; i++)
            {
                lines[i] = new Line();
            }
        }

        public int GetNumberLines()
        {
            return n;
        }
    }

    class Picture
    {
        public Picture()
        {
            Point[] pict = new Point[4];
            pict[0] = new Line();
            pict[1] = new ColoredPoint();
            pict[2] = new ColoredLine();
            pict[3] = new PolyLine();
            Console.WriteLine(pict[0]);
            Console.WriteLine(pict[1]);
            Console.WriteLine(pict[2]);
            Console.WriteLine(pict[3]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
