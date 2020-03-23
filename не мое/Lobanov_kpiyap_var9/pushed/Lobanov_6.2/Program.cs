using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lobanov_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размеры матрицы\nn = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Исходная матрица:");
            int[,] matr = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matr[i, j] = random.Next(-10, 10);
                    Console.Write($"{matr[i, j],4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Преобразование матрицы:");
            Console.Write("Введите направление(1 - вниз, 2 - вправо): ");
            int running = int.Parse(Console.ReadLine());
            Console.Write("Введите количество сдвигов: ");
            int count = int.Parse(Console.ReadLine());

            int[] temp = new int[m]; int tek = 0; int[,] lost = new int[n, m];
            if (running != 1 && running != 2) Console.WriteLine("Ошибка ввода!");
            else
            {
                if (running == 1) //если вниз
                {
                    if (count > n) count %= n;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            tek = (i + count) % n;
                            lost[tek, j] = matr[i, j];
                        }
                    }
                }

                if (running == 2) //если вправо
                {
                    if (count > m) count %= m;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            tek = (j + count) % m;
                            lost[i, tek] = matr[i, j];
                        }
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{lost[i, j],4}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
