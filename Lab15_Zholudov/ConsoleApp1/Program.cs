using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("C:\\english_text.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(file);
            string s = streamReader.ReadToEnd();
            streamReader.Close();

            string[] str = s.Split(' ');
            string glas = "euioayEYUIOA";
            string tk = "~!@#$%^&*()_+-={}\\<>?|:.";
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < glas.Length; j++)
                {
                    if (str[i][0] == glas[j])
                    {
                        for (int ki = 0; ki < str[i].Length; ki++)
                        {
                            for (int kj = 0; kj < tk.Length; kj++)
                            {
                                if (str[i][ki] == tk[kj]) str[i] = str[i].Remove(ki, 1);
                            }
                        }
                        Console.WriteLine(str[i]);
                        break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
