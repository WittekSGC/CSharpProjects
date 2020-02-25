using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshka_5._1
{
    class Conus
    {
        private double _radius;
        private double _heigth;
        private double _obraz;    //длинна образуюшей
        private double _square;   //боковая площадь
        private double _allsquare; //площадь полной поверхности
        private double _downsquare; //площадь окружности
        private string _classname;
        private double _capasity;

        public Conus(double r, double h)
        {
            _radius = r;
            _heigth = h;
            _obraz = Math.Sqrt(Math.Pow(_radius, 2) + Math.Pow(_heigth, 2));
            _downsquare = Math.PI * Math.Pow(_radius, 2);
            _square = Math.PI * _radius * _obraz;
            _allsquare = _square + _downsquare;
            _capasity = (1 / 3) * Math.PI * _heigth * Math.Pow(_radius, 2);
            _classname = "Conus";
        }

        public double GetObraz()
        {
            return _obraz;
        }

        public double GetDownSquare()
        {
            return _downsquare;
        }

        public double GetAllSquare()
        {
            return _allsquare;
        }

        public double GetCapacity()
        {
            return _capasity;
        }

        public void SetClassName(string name)
        {
            _classname = name;
        }

        public string GetClassName()
        {
            return _classname;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус : ");
            double rad = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту : ");
            double h = double.Parse(Console.ReadLine());

            Conus con = new Conus(rad, h);
            Console.Write("Образующая - ");
            Console.WriteLine(con.GetObraz());
            Console.Write("Объем - ");
            Console.WriteLine(con.GetCapacity());
            Console.Write("Пощадь окружности - ");
            Console.WriteLine(con.GetDownSquare());
            Console.Write("Площадь полной поверхности - ");
            Console.WriteLine(con.GetAllSquare());
            Console.Write("Введите имя класса - ");
            string name = Console.ReadLine();
            con.SetClassName(name);
        }
    }
}
