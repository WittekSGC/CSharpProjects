using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Zholudov_n1
{
    class Program
    {
        struct Aeroflot
        {
            public string _name, _type;    //пункт назначения, тип самолета
            public int _number;            //номер рейса
        }

        static void Main(string[] args)
        {
            int n = 7;
            Aeroflot[] aeroflots = new Aeroflot[n];

            Console.WriteLine("Введите пункт назначения(string), номер рейса(int) и тип самолета(string)");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Авиарейс {0}: ", i + 1);
                aeroflots[i]._name = Console.ReadLine();
                aeroflots[i]._number = int.Parse(Console.ReadLine());
                aeroflots[i]._type = Console.ReadLine();
            }

            Aeroflot temp = new Aeroflot();
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n-1; i++)
                {
                    if (aeroflots[i]._number > aeroflots[i+1]._number )
                    {
                        temp = aeroflots[i];
                        aeroflots[i] = aeroflots[i + 1];
                        aeroflots[i + 1] = temp;
                    }
                }
            }

            Console.Write("Введите название пункта назначения: ");
            string punkt = Console.ReadLine();
            bool find = false;
            int count = 1;
            for (int i = 0; i < n; i++)
            {
                if (aeroflots[i]._name == punkt)
                {
                    find = true;
                    break;
                }
            }
            if (find)
            {
                for (int i = 0; i < n; i++)
                {
                    if (aeroflots[i]._name == punkt) Console.WriteLine("{2}: Рейс в пункт назначения {0} находится под номером {1}", punkt, aeroflots[i]._number, count);
                    count++;
                }
            }
            else Console.WriteLine("Рейсы с заданным пунктом назначения отсутствуют");

            Console.ReadKey();
        }
    }
}
