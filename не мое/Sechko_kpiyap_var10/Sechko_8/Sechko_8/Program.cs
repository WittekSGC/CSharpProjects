using System;
using System.Text.RegularExpressions;

namespace Sechko_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"((Ctrl)|(Shift)|(Alt))(\+\w)+";
            Regex regex = new Regex(pattern);

            Console.Write("Enter the text: ");
            string text = Console.ReadLine();

            MatchCollection n = regex.Matches(text);
            for (int i = 0; i < n.Count; i++)
            {
                Console.WriteLine("Math {0} = {1}",i+1, n[i].Value);
            }
            Console.ReadKey();
        }
    }
}
