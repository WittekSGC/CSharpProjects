using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valetova_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива строк\nn = ");
            int n = int.Parse(Console.ReadLine());
            string[] mass = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("mass[{0}] = ", i);
                mass[i] = Console.ReadLine();
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (int.Parse(mass[i]) % 2 == 0) sum += int.Parse(mass[i]);
            }
            Console.WriteLine("Сумма четных элементов = {0}", sum);
            Console.ReadKey();
        }
    }
}
