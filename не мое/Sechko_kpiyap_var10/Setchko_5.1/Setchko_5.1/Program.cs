
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setchko_5._1
{
    class Cilindr
    {
        protected double _heigth;
        protected double _radius;
        protected double _s_pp;
        protected double _s_okr;
        protected double _s_bok;
        protected double _volume;
        protected string _class_name;

        public Cilindr(double h, double r)
        {
            _heigth = h;
            _radius = r;
            _class_name = "Cilindr";
        }

        public double GetSPP()
        {
            _s_okr = Math.PI * Math.Pow(_radius, 2);
            _s_bok = Math.PI * _heigth * 2 * _radius;
            _s_pp = _s_bok + _s_okr;
            return _s_pp;
        }

        public double GetVolume()
        {
            _volume = _s_okr * _heigth;
            return _volume;
        }

        public void SetHeigth(double h)
        {
            _heigth = h;
        }

        public void SetRadius(double r)
        {
            _radius = r;
        }

        public void SetClassName(string name)
        {
            _class_name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус и высоту цилиндра\nr = ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            double h = double.Parse(Console.ReadLine());

            Cilindr cilindr = new Cilindr(h, r);
            Console.WriteLine(cilindr.GetSPP() + " - SPP");
            Console.WriteLine(cilindr.GetVolume() + " - Volume");
            cilindr.SetHeigth(h + 2);
            Console.WriteLine(cilindr.GetSPP() + " - SPP");
            Console.WriteLine(cilindr.GetVolume() + " - Volume");
            cilindr.SetClassName("my_class");
            Console.ReadKey();
        }
    }
}
