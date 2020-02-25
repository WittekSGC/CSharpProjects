using System;

namespace Valetova_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размеры матрицы\nn = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rand.Next(-2, 8);
                    Console.Write($" {arr[i, j],4} ", arr[i, j]);
                }
                Console.WriteLine();
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] == 0)
                    {
                        count++;
                        break;
                    }
                }

            }
            Console.WriteLine("Строк с минимум одним нулем: {0}", count);

            //выбрать элемент -> запустить цикл до конца строки -> если след равен, каунт +1, иначе выйти из цикла, взять некст
            int temp,len = 0,ilen = 0;
            for (int i = 0; i < m; i++)
            {
                count = 0;
                for (int j = 0; j < n; j++)
                {
                    temp = arr[j, i];
                    for (int k = 0; k < n-j; k++)
                    {
                        if (temp == arr[k, i]) count++;
                        else break;
                    }
                }
                if (count > len)
                {
                    len = count;
                    ilen = i;
                }
            }
            Console.WriteLine("Длиннейшая серия в строке {0} из {1} элементов", ilen+1, len);

            Console.ReadKey();
        }
    }
}
