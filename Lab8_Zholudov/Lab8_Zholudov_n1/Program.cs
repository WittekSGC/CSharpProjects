using System;
using System.Text.RegularExpressions;

namespace Lab8_Zholudov_n1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"<[^<]+>";
            Regex regex = new Regex(pattern);

            Console.WriteLine("enter string: ");
            string stroke = Console.ReadLine();

            MatchCollection mathes = regex.Matches(stroke);
            string collect;
            for (int i = 0; i<mathes.Count; i++)
            {
                collect = mathes[i].Value;
                collect = collect.Replace("<", "");
                collect = collect.Replace(">", "");
                Console.WriteLine("math №{0} = " + collect, i+1);
            }
            Console.ReadKey();
        }
    }
}
