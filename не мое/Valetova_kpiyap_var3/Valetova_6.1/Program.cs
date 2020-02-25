using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valetova_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(-50, 100);
                Console.Write(" {0}  ", arr[i]);
            }
            Console.WriteLine();

            int umn = 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) umn *= arr[i];
            }

            int sum = 0;
            for (int i = 0; i<n; i++)
            {
                if (arr[i] == 0)
                for (int j = n-1; j>i; j--)
                {
                    if (j==0)
                    {
                        sum += arr[i];
                        break;
                    }                    
                }
                break;
            }

            int[] arr2 = new int[n];
            int first = 0, last = n-1;
            for (int i = 0; i<n; i++)
            {
                if (arr[i] < 0)
                {
                    arr2[first] = arr[i];
                    first++;
                }
                else
                {
                    arr2[last] = arr[i];
                    last--;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(" {0}  ", arr2[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Произведение = {0}", umn);
            Console.WriteLine("Сумма = {0}", sum);
            Console.ReadKey();
        }
    }
}
