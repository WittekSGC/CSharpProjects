using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sechko_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для проверки:");
            string proof = Console.ReadLine();
            string palindrom = "";
            for (int i = proof.Length-1; i >= 0; i--)
            {
                palindrom += proof[i];
            }
            if (proof == palindrom) Console.WriteLine("строка является палиндромом");
            else Console.WriteLine("Строка не является палиндромом");
            Console.ReadKey();
        }
    }
}
