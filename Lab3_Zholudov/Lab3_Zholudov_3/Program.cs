using System;

namespace Lab3_Zholudov_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 0;
            Console.Write("х = ");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    y = Math.Sqrt(Math.Pow(x+1,2)+5); break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    y = Math.Log10(x/2); break;
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                    y = Math.Tan(x); break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                    y = Math.Sqrt(x + (Math.PI / 2)); break;
            }
            Console.WriteLine("y = {0}",y);
        }
    }
}
