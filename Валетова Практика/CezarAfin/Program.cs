using System;

namespace CezarAfin
{
    class Cezr
    {
        public Cezr()
        {

        }
                                                       //3    //5
        public void Shifr(string text, string mode, int a, int b)
        {
            string shifrText = "", engAlf = "abcdefghijklmnopqrstuvwxyz", rusAlf = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
            text = text.ToLower();
            bool find = false;
            if (mode == "eng")
            {
                if (a >= b || b >= 26)
                    //debug
                    Console.WriteLine("error indexer");
                //
                else
                    for (int i = 0; i < text.Length; i++)
                    {
                        for (int j = 0; j < engAlf.Length; j++)
                        {
                            if (text[i] == engAlf[j])
                            {
                                find = true;
                                shifrText += engAlf[(a * j + b) % 26];
                            }
                        }
                        if (!find)
                        {
                            shifrText += text[i];
                        }
                        find = false;
                    }
                //degug
                Console.WriteLine(shifrText);
                //
            }
            else
            if (mode == "rus")
            {
                if (a >= b || b >= 32)
                    //debug
                    Console.WriteLine("error indexer");
                //
                else
                    for (int i = 0; i < text.Length; i++)
                    {
                        for (int j = 0; j < rusAlf.Length; j++)
                        {
                            if (text[i] == rusAlf[j])
                            {
                                find = true;
                                shifrText += rusAlf[(a * j + b) % 32];
                            }
                        }
                        if (!find)
                        {
                            shifrText += text[i];
                        }
                        find = false;
                    }
                //debug
                Console.WriteLine(shifrText);
                //
            }
            else
                //debug
                Console.WriteLine("Unknown language");
            //
        }

        public void UnShifr(string text, string mode, int a, int b)
        {
            string unShifrText = "", engAlf = "abcdefghijklmnopqrstuvwxyz", rusAlf = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
            text = text.ToLower();
            bool find = false;
            //a * x + b mod 26
            if (mode == "eng")
            {
                if (a >= b || b >= 26)
                    //debug
                    Console.WriteLine("error indexer");
                //
                else
                    for (int i = 0; i < text.Length; i++)
                    {
                        for (int j = 0; j < engAlf.Length; j++)
                        {
                            if (text[i] == engAlf[(a * j + b) % 26])
                            {
                                find = true;
                                unShifrText += engAlf[j];
                            }

                        }
                        if (!find)
                        {
                            unShifrText += text[i];
                        }
                        find = false;
                    }                    
                //degug
                Console.WriteLine(unShifrText);
                //
            }
            else
            if (mode == "rus")
            {
                if (a >= b || b >= 32)
                    //debug
                    Console.WriteLine("error indexer");
                //
                else
                    for (int i = 0; i < text.Length; i++)
                    {
                        for (int j = 0; j < rusAlf.Length; j++)
                        {
                            if (text[i] == rusAlf[(a * j + b) % 32])
                            {
                                find = true;
                                unShifrText += rusAlf[j];
                            }

                        }
                        if (!find)
                        {
                            unShifrText += text[i];
                        }
                        find = false;
                    }
                //debug
                Console.WriteLine(unShifrText);
                //
            }
            else
                //debug
                Console.WriteLine("Unknown language");
            //
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            Cezr cezr = new Cezr();
            cezr.Shifr(n, "eng", 3, 5);
            n = Console.ReadLine();
            cezr.UnShifr(n, "eng", 3, 5);

            Console.ReadKey();
        }
    }
}
