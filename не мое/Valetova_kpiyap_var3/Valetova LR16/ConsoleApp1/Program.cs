using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату по типу dd.mm.yyyy: ");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());

            MyData.MyData data = new MyData.MyData(dateTime);
            Console.WriteLine("день {0}", data.GetDay());
            Console.WriteLine("месяц {0}", data.GetMonth());
            Console.WriteLine("год {0}", data.GetYears());

            Console.ReadKey();
        }
    }
}
