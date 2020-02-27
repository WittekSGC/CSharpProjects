using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream("C:\\english_text.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);

            string fullText = streamReader.ReadToEnd();
            int vosklAndVopr = 0;
            for (int i = 0; i < fullText.Length; i++)
            {
                if (fullText[i] == '!' || fullText[i] == '?') vosklAndVopr++;
            }
            string[] split = new string[vosklAndVopr];
            int count = 0;

            for (int i = 0; i < vosklAndVopr; i++)
            {
                while (true)
                {
                    if (count >= fullText.Length || fullText == null) break;
                    if (fullText[count] == '!' || fullText[count] == '.' || fullText[count] == '?')
                    {

                        if (fullText[count] == '.')
                        {
                            fullText = fullText.Remove(0, count+1);
                            Console.WriteLine('.' + count);
                            count = 0;
                        }
                        else
                        {
                            split[i] = fullText.Substring(0, count+1);
                            fullText = fullText.Remove(0, count+2);
                            count = 0;
                            break;
                        }
                    }
                    count++; 
                }
            }

            for (int i = 0; i < vosklAndVopr; i++)
            {
                if (split[i][split[i].Length-1] == '?') Console.WriteLine(split[i] + "\n\n");
            }

            for (int i = 0; i < vosklAndVopr; i++)
            {
                if (split[i][split[i].Length - 1] == '!') Console.WriteLine(split[i] + "\n\n");
            }

            Console.ReadKey();

            streamReader.Close();
        }
    }
}
