using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshka_9
{
    struct Train
    {
        public string punkt_nazn, time_to_run;
        public int number;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите информацию о восьми поездах: номер поезда, пункт нзанчения и время отправления");
            Train[] trains = new Train[8];
            for (int i = 0; i < 8; i++)
            {
                trains[i].number = int.Parse(Console.ReadLine());
                trains[i].punkt_nazn = Console.ReadLine();
                trains[i].time_to_run = Console.ReadLine();
            }

            Train train = new Train();
            for (int i = 0; i < 7; i++)
            {
                for (int j = i + 1; j < 8; j++)
                {
                    if (trains[i].number > trains[i + 1].number)
                    {
                        train = trains[i];
                        trains[i] = trains[i + 1];
                        trains[i + 1] = train;
                    }
                }
            }

            Console.Write("Введите номер поезда для поиска: ");
            int time = int.Parse(Console.ReadLine()), count = 1;
            bool go = false;
            for (int i = 0; i < 8; i++)
            {
                if (time == trains[i].number)
                {
                    go = true;
                    break;
                }
            }
            if (go)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (time == trains[i].number)
                    {
                        Console.WriteLine("Совпадение {0}: Поезд номер {1} отправляется в пункт назначения {2} в {3}", count, time, trains[i].punkt_nazn, trains[i].time_to_run);
                        count++;
                    }
                }
            }
            else Console.WriteLine("Поезда с таким номером отсутствуют");
            Console.ReadKey();
        }
    }
}
