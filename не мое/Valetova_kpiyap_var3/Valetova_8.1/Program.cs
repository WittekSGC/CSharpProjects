using System;
using System.Text.RegularExpressions;

namespace Valetova_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = @"\d\d-\d\d\d-\d\d-\d\d";
            Regex regex = new Regex(a);
            Console.Write("Введите строку с номером телефона");
            string str = Console.ReadLine();
            MatchCollection math = regex.Matches(str);
            for (int i = 0; i < math.Count; i++)
            {
                Console.WriteLine("math №{0} = {1}", i, math[i].Value);
            }
            Console.ReadKey();
        }
    }
}
