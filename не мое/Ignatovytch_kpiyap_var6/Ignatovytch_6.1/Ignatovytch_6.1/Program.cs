using System;

namespace Ignatovytch_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну массива");
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            double[] arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(-1,10) * 0.03423423423;
                Console.WriteLine($"{arr[i],15}");
            }
            Console.WriteLine();

            double min = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            Console.WriteLine("min = " + min);

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i]>0)
                {
                    for (int j = n-1; j > i; j--)
                    {
                        if (arr[j] > 0)
                        {
                            for (int k = i; k < j; k++)
                            {
                                sum += arr[j];
                            }
                            break;
                        }
                    }
                    break;
                }
            }
            Console.WriteLine("sum = " + sum);

            double[] rec = new double[n];
            int count = n-1;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    rec[count] = arr[i];
                    count--;
                }
            }
            arr = rec;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadKey();
        }
    }
}
