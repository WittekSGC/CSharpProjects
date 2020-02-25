using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sechko_9._1
{
    class Program
    {
        struct Marsh
        {
            public string start;
            public string finish;
            public int number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите 8 маршрутов:");
            Marsh[] marshes = new Marsh[8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Начальный пункт: ");
                marshes[i].start = Console.ReadLine();
                Console.Write("Конечный пункт: ");
                marshes[i].finish = Console.ReadLine();
                Console.Write("Номер маршрута: ");
                marshes[i].number = int.Parse(Console.ReadLine());
            }

            Marsh temp = new Marsh();
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (marshes[i].number > marshes[i+1].number)
                    {
                        temp = marshes[i];
                        marshes[i] = marshes[i+1];
                        marshes[i+1] = temp;
                    }
                }
            }

            Console.Write("Введите номер маршрута: ");
            int numb = int.Parse(Console.ReadLine());
            bool find = false;
            int count = 1;
            for (int i = 0; i < 7; i++)
            {
                if (marshes[i].number == numb)
                {
                    find = true;
                    break;
                }
            }
            if (find)
            {
                for (int i = 0; i < 7; i++)
                {
                    if (marshes[i].number == numb) Console.WriteLine("{0}: Маршрут №{1}: Точка начала - {2}, Точка окончания - {3}",count,numb,marshes[i].start, marshes[i].finish);
                    count++;
                }
            }
            else Console.WriteLine("Маршруты с таким номером отсутствуют");

            Console.ReadKey();
        }
    }
}
