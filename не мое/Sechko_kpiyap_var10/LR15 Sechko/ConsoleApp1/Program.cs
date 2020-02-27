using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("c:\\english_text.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            string alltext = reader.ReadToEnd();
            string znaki = "~!@#$%^&*()_+,./';[]\\|";

            for (int i = 0; i < alltext.Length; i++)
            {
                for (int j = 0; j < znaki.Length; j++)
                {
                    if (alltext[i] == znaki[j]) alltext = alltext.Replace(alltext[i], ' ');
                }
            }

            string[] words = alltext.Split(' ');
            string liters = "EUIOAYeyuioa";

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i].Length != 0)
                    for (int j = 0; j < liters.Length; j++)
                    {
                        if (words[i][0] == liters[j])
                        {
                            for (int k = 0; k < liters.Length; k++)
                            {
                                if (words[i][words[i].Length - 1] == liters[k]) Console.WriteLine(words[i]);
                            }
                        }
                    }
            }

            Console.ReadKey();
        }
    }
}
