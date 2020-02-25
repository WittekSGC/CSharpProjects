using System;

namespace Lab6_Zholudov_n1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            double[] farr = new double[n];
            for (int i=0;i<n;i++)
            {
                farr[i] = rnd.NextDouble()*10.168*Math.Pow(-1,i);
            }
            Console.Write("Array = ");
            for (int i = 0; i < n; i++) Console.Write(" {0} ", farr[i]);
            Console.WriteLine();


            //сумма элементов с нечетным индексом
            double sum1 = 0;
            for (int i = 0;i < n ; i++)
            {
                if (i % 2 == 1) sum1 += farr[i];
            }


            //сумма элементов между первым и последним отрицательными
            int pos1=0, pos2=0;
            double sum2 = 0;
            for (int i=0; i<n; i++)
            {
                if (farr[i] < 0)
                {
                    pos1 = i;
                    for (int j = n - 1; j > pos1;j--)
                    {
                        if (farr[j]<0)
                        {
                            pos2 = j;
                            break;
                        }                    
                    }
                    break;                   
                }                
            }

            if (pos1 != 0 && pos2 != 0)
            {
                for (int i = pos1 + 1; i < pos2; i++)
                {
                    sum2 += farr[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("sum1 = {0},sum2 = {1}", sum1, sum2);
            Console.WriteLine();

            //удаление элементов, который по модулю меньше нуля
            for (int i = 0; i<n; i++)
            {
                if (farr[i]<1 && farr[i]>-1)
                {
                    for (int j = i+1; j<n; j++)
                    {
                        farr[j - 1] = farr[j];
                    }
                    farr[n - 1] = 0;
                }
            }
            for (int i = 0; i < n; i++) Console.Write("{0}, ", farr[i]);
        }
    }
}
