using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignatovytch_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 8];
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    matrix[i, j] = random.Next(-5, 10 );
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }

            int[] temp = new int[8];
            bool yes;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    temp[j] = matrix[i, j];
                }
                yes = true;
                for (int j = 0; j < 8; j++)
                {
                    if (temp[j] != matrix[j, i])
                    {
                        yes = false;
                        break;
                    }
                }
                if (yes) Console.WriteLine(i);
            }

            bool minus;
            int sum = 0;
            for (int i = 0; i < 8; i++)
            {
                minus = false;
                for (int j = 0; j < 8; j++)
                {
                    if (matrix[i, j] < 0) minus = true;
                }
                if (minus)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
