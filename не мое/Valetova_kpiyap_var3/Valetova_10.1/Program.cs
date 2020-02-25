using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valetova_10._1
{
    abstract class Vehicle
    {
        public double price, max_speed, weigth; //цена, максимальная скорость, вес
        public int year, vh_count;  //год выпуска, количество колес <- кста самое тупое, что я мог придумать в час ночи

        public virtual void PrintInfo() 
        {
            Console.Write("Цена: {0}, Максимальная скорость: {1}, Вес: {2}, Год выпуска: {3}, количество колес {4}", price, max_speed, weigth, year, vh_count);
        }
    }

    class Car : Vehicle
    {
        public double value;
        public Car()
        {
            Console.WriteLine("Введите цену, максимальную скорость, вес авто, а так же год выпуска");
            Console.Write("Цена: "); price = double.Parse(Console.ReadLine());
            Console.Write("Максимальная скорость: "); max_speed = double.Parse(Console.ReadLine());
            Console.Write("Вес: "); weigth = double.Parse(Console.ReadLine());
            Console.Write("Год выпуска: "); year = int.Parse(Console.ReadLine());
            Console.Write("Объем двигателя: "); value = double.Parse(Console.ReadLine());
            vh_count = 4;
            Console.WriteLine();
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine(" , Объем двигателя: {0}", value);
        }
    }

    class Bicycle : Vehicle
    {
        public string type;
        public Bicycle()
        {
            Console.WriteLine("Введите цену, максимальную скорость, вес авто, а так же год выпуска");
            Console.Write("Цена: "); price = double.Parse(Console.ReadLine());
            Console.Write("Максимальная скорость: "); max_speed = double.Parse(Console.ReadLine());
            Console.Write("Вес: "); weigth = double.Parse(Console.ReadLine());
            Console.Write("Год выпуска: "); year = int.Parse(Console.ReadLine());
            Console.Write("Тип рамы: "); type = Console.ReadLine();
            vh_count = 2;
            Console.WriteLine();
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine(" , Тип рамы: {0}", type);
        }
    }

    class Lorry : Vehicle
    {
        public double length;

        public Lorry()
        {
            Console.WriteLine("Введите цену, максимальную скорость, вес авто, а так же год выпуска");
            Console.Write("Цена: "); price = double.Parse(Console.ReadLine());
            Console.Write("Максимальная скорость: "); max_speed = double.Parse(Console.ReadLine());
            Console.Write("Вес: "); weigth = double.Parse(Console.ReadLine());
            Console.Write("Год выпуска: "); year = int.Parse(Console.ReadLine());
            Console.Write("Длинна бункера: "); length = double.Parse(Console.ReadLine());
            Console.Write("Количество колес: "); vh_count = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine(" , Длинна бункера: {0}", length);
        }
    }

    class Garage
    {
        Vehicle[] vehicles = new Vehicle[3];
        public Garage()
        {
            vehicles[0] = new Car();
            vehicles[1] = new Bicycle();
            vehicles[2] = new Lorry();
            Printing();
        }

        public void Printing()
        {
            vehicles[0].PrintInfo();
            vehicles[1].PrintInfo();
            vehicles[2].PrintInfo();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            Console.ReadKey();
        }
    }
}
