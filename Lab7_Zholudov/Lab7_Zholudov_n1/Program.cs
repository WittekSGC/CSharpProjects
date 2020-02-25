using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Zholudov_n1
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;
            int sum = 0;

            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());

            string[] arr = new string[n];
            for (int i = 0; i<n; i++)
            {
                Console.Write("Enter a[{0}] = ", i + 1);
                arr[i] = Console.ReadLine();
                sum += int.Parse(arr[i]);
            }

            for (int i=0; i<n-1; i++)
            {
                bool f = false;
                for (int j = 0; j<n-i-1; j++)
                {
                    if (int.Parse(arr[j+1]) > int.Parse(arr[j]))
                    {
                        f = true;
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    } 
                }
                if (!f) break;
            }

            for (int i = 0; i<n; i++)
                Console.WriteLine(arr[i]);

            double sred = (double)sum / n;
            Console.WriteLine("average = {0}", sred);

            Console.WriteLine("max - min = {0}", int.Parse(arr[0]) - int.Parse(arr[n-1]));
            Console.ReadKey();
        }
    }
}
