using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prima
{
    class Program
    {
        static void Main(string[] args)
        {
            int step = 4;

            int[,] matrix = new int[step, step]; ;
            int[] prohod = new int[step-1];
            int min = int.MaxValue, imin = -1, jmin = -1;

            //generate matrix
            for (int i = 0; i < step; i++)
            {
                for (int j = 0; j < step; j++)
                {
                    if (i != j)
                    {
                        matrix[i, j] = Math.Max(i,j)+1;
                    }
                    else
                        matrix[i, j] = 0;
                    Console.Write($"{matrix[i, j],3}");
                }
                Console.WriteLine(); 
            }

            
            for (int k = 0; k < step-1; k++) // number of repeat cyckles
            {
                //find min
                for (int i = 0; i < step; i++)
                {
                    for (int j = 0; j < step; j++)
                    {
                        if (min > matrix[i, j] && matrix[i,j] != 0)
                        {
                            min = matrix[i, j];
                            imin = i;
                            jmin = j;
                        }
                    }
                }

                //entrying '0'
                for (int count = 0; count < step; count++)
                {
                    matrix[imin, count] = 0;
                    matrix[jmin, count] = 0;
                }

                //memoring and clean;
                prohod[k] = min;
                min = int.MaxValue;
                imin = -1;
                jmin = -1;

                for (int i = 0; i < step; i++)
                {
                    for (int j = 0; j < step; j++)
                    {
                        Console.Write($"{matrix[i, j],3}");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                for (int i = 0; i < step-1; i++)
                {
                    Console.Write(prohod[i] + " ");
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}
