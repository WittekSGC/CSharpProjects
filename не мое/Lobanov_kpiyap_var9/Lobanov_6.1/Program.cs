using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lobanov_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива:\nn = ");
            int n = int.Parse(Console.ReadLine());

            double[] array = new double[n];
            double[] array2 = new double[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-10, 10);
                Console.Write("{0}  ", array[i]);
            }
            Console.WriteLine();

            double max = 0;
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(array[i]) > Math.Abs(max)) max = array[i];
            }

            int first = -1, second = -1;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    first = i;
                    for (int j = i+1; j < n; j++)
                    {
                        if (array[j] > 0)
                        {
                            second = j;
                            break;
                        }
                    }
                    break;
                }
            }
            double sum = 0;
            for (int i = first+1; i < second; i++)
            {
                sum += array[i];
            }

            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}\n", sum);

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] != 0)
                {
                    array2[count] = array[i];
                    count++;
                }
            }
            for (int i = count; i < n; i++)
            {
                array2[i] = 0;
            }
            array = array2;

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", array[i]);
            }
            Console.ReadKey();
        }
    }
}
