using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter char (only english language)");
            char run = Console.ReadLine().ToCharArray()[0];
            Console.WriteLine(CharDLL.CharDLL.DetectChar(run));
            Console.ReadKey();
        }
    }
}
