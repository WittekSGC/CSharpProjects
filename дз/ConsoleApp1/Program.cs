using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream("d:\\txt.txt" ,FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);

            string s = streamReader.ReadToEnd();
            string[] ss = s.Split('\n');
            Console.WriteLine(s);

            Console.WriteLine("-----------");

            int max = 0, imax = -1;
            for (int i = 0; i < ss.Length; i++)
            {
                if (ss[i].Length > max)
                {
                    max = ss[i].Length;
                    imax = i;
                }
            }
            Console.WriteLine("самая длинная строка {0}, кол-во символов: {1}", imax, max);

            Console.ReadKey();
        }
    }
}
