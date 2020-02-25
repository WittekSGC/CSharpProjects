using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setchko_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            Random ran = new Random();
            int[,] matr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matr[i, j] = ran.Next(-10, 10);
                    Console.Write($"{matr[i,j],5}");
                }
                Console.WriteLine();
            }
            
            bool find = false;
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (matr[i,j] == 0)
                    {
                        Console.WriteLine("Столбец с первым встретившимся нулем: {0}", j+1);
                        find = true;
                        break;                        
                    }
                }
                if (find) break;
            }

            int[] charact = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matr[i, j] < 0 && matr[i, j] % 2 == 0) charact[i] += matr[i, j];
                }
            }

            int min = charact[0], imin = 0;
            int[,] temp = new int[n, m];

            for (int count = 0; count < n; count++)
            {
                for (int l = 0; l < n; l++)
                {
                    if (min > charact[l])
                    {
                        min = charact[l];
                        imin = l;
                    }
                }
                charact[imin] = 1;
                min = 1;
                for (int j = 0; j < m; j++)
                {
                    temp[count, j] = matr[imin, j];
                }                
            }

            Console.WriteLine("Преобразование матрицы по параметру: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{temp[i, j],5}"); 
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
