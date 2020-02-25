using System;

namespace Lab6_Zholudov_n2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matr = new int[n, n];
            Random rnd = new Random();

            for (int i = 0;i<n; i++)
            {
                for (int j=0;j<n;j++)
                {
                    matr[i, j] = rnd.Next(-2, 10);
                    Console.Write($"{matr[i, j],4}");
                }
                Console.WriteLine();
            }

            bool go= true;
            double pr = 1;
            for (int i = 0; i < n; i++)
            {
                go = true;
                for (int j = 0; j < n; j++)
                {
                    if (matr[i, j] < 0) go = false;
                }

                if (go)
                {
                    for (int fk=0; fk<n ; fk++)
                    {
                        pr *= matr[i, fk];
                    }                    
                }
            }
            Console.WriteLine("pr = {0}", pr);

            int k,i1,j1,sum = 0, maxsum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) continue;
                    if (i != 0 && j != 0) continue;
                    k = n - (i + j);
                    i1 = i; j1 = j;
                    for (int l = 1; l <= k; l++)
                    {
                        sum += matr[i1, j1];
                        i1++;
                        j1++;
                    }
                    if (sum > maxsum) maxsum = sum;
                    sum = 0;
                }
            }
            Console.WriteLine("maxsum of parallel main diagonals = {0}", maxsum);
        }
    }
}
