using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Roshka_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\d{4})(\-\d{4})*";
            Regex regex = new Regex(pattern);

            Console.WriteLine("enter string: ");
            string stroke = Console.ReadLine();

            MatchCollection mathes = regex.Matches(stroke);
            string collect;
            for (int i = 0; i < mathes.Count; i++)
            {
                collect = mathes[i].Value;
                collect = collect.Replace("<", "");
                collect = collect.Replace(">", "");
                Console.WriteLine("math №{0} = " + collect, i + 1);
            }
            Console.ReadKey();
        }
    }
}
