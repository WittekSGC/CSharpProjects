using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignatovytch_9._1
{
    class Program
    {
        struct Worker
        {
            public string fam, initials, post;
            public int god;

            public void PrintFindet(int stage)
            {
                bool find = false; int count = 1;
                if (god == stage)
                    {
                        find = true;
                    }
                if (find)
                {
                    Console.WriteLine("Найденные работники: ");
                    if (god == stage) Console.WriteLine("№{0}: Фамилия - {1} {2}, стаж: {3}", count, fam, initials, stage);
                        count++;
                }
                else Console.WriteLine("Работники с таким стажем отсутствуют");
            }
        }
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[10];
            Console.WriteLine("Введите информацию о 10 работниках: Фамилия, инициалы, должность, стаж работы");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Фамилия: ");
                workers[i].fam = Console.ReadLine();
                Console.Write("Инициалы: ");
                workers[i].initials = Console.ReadLine();
                Console.Write("Должность: ");
                workers[i].post = Console.ReadLine();
                Console.Write("Стаж работы: ");
                workers[i].god = int.Parse(Console.ReadLine());
            }

            Worker temp = new Worker();
            for (int g = 0; g < 10; g++)
            {
                for (int i = g+1; i < 10; i++)
                {
                    if (workers[g].fam[0] > workers[i].fam[0])
                    {
                        temp = workers[i];
                        workers[i] = workers[g];
                        workers[g] = temp;
                    }
                }
            }

            int stage = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                workers[i].PrintFindet(stage);
            }

            Console.ReadKey();
        }
    }
}
