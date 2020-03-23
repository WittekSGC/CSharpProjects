using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    public struct Aeroflot
    {
        public string _name, _type;    //пункт назначения, тип самолета
        public int _number;            //номер рейса
    }

    public class AeroClass : IComparer<Aeroflot>
    {
        string FilePath = "input.txt";
        List<Aeroflot> aeroflots = new List<Aeroflot>();
        string SortParametr;

        public AeroClass()
        {
            ReadFromFile();
        }
        public void ReadFromFile()
        {
            FileStream input = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            StreamReader inputReader = new StreamReader(input);

            while (!inputReader.EndOfStream)
            {
                string temp = inputReader.ReadLine();
                temp = inputReader.ReadLine();

                Aeroflot tempAeroflot = new Aeroflot();
                tempAeroflot._name = temp;
                temp = inputReader.ReadLine();
                tempAeroflot._type = temp;
                temp = inputReader.ReadLine();
                tempAeroflot._number = int.Parse(temp);
                aeroflots.Add(tempAeroflot);
            }
            inputReader.Close();
            input.Close();
        }

        public void WriteToFile()
        {
            FileStream outStream = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter outWriter = new StreamWriter(outStream);

            foreach (var item in aeroflots)
            {
                outWriter.WriteLine();
                outWriter.WriteLine(item._name);
                outWriter.WriteLine(item._type);
                outWriter.WriteLine(item._number);
            }

            outWriter.Close();
            outStream.Close();
        }

        public void Sorting()
        {
            Console.WriteLine("Pick sort parameter: 1 - name, 2 - type, 3 - number");
            SortParametr = Console.ReadLine();
            aeroflots.Sort(Compare);
        }

        public int Compare(Aeroflot x, Aeroflot y)
        {
            switch (SortParametr)
            {
                case "1":
                    foreach (char a in x._name)
                    {
                        foreach (char b in y._name)
                        {
                            if (a < b) return -1;
                            else if (a > b) return 1;
                        }
                    }
                    return 0;
                case "2":
                    foreach (char a in x._type)
                    {
                        foreach (char b in y._type)
                        {
                            if (a < b) return -1;
                            else if (a > b) return 1;
                        }
                    }
                    return 0;
                case "3":
                    if (x._number < y._number) return -1;
                    else if (x._number > y._number) return 1;
                    return 0;
                default: return 0;
            }
        }

        public void AddElement()
        {
            Aeroflot aeroflot = new Aeroflot()
            {
                _name = Console.ReadLine(),
                _type = Console.ReadLine(),
                _number = int.Parse(Console.ReadLine())
            };
            aeroflots.Add(aeroflot);
        }

        public void FindBy()
        {
            Console.WriteLine("Enter 'name', 'type' or 'number' to pick type of search");
            string find;
            switch (Console.ReadLine())
            {
                case "name":
                    Console.Write("Enter search parameter: ");
                    find = Console.ReadLine();
                    foreach (Aeroflot item in aeroflots)
                    {
                        if (item._name == find)
                        {
                            Console.WriteLine(item._name + " " + item._type + " " + item._number);
                        }
                    }
                    break;
                case "type":
                    Console.Write("Enter search parameter: ");
                    find = Console.ReadLine();
                    foreach (Aeroflot item in aeroflots)
                    {
                        if (item._type == find)
                        {
                            Console.WriteLine(item._name + " " + item._type + " " + item._number);
                        }
                    }
                    break;
                case "number":
                    Console.Write("Enter search parameter: ");
                    int nfind = int.Parse(Console.ReadLine());
                    foreach (Aeroflot item in aeroflots)
                    {
                        if (item._number == nfind)
                        {
                            Console.WriteLine(item._name + " " + item._type + " " + item._number);
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        public void RemoveElement(int position)
        {
            if (position >= aeroflots.Count || position < 0)
                Console.WriteLine("error index!");
            else
            {
                int count = 0;
                foreach (Aeroflot item in aeroflots)
                {
                    if (count == position)
                        aeroflots.Remove(item);
                    else
                        count++;
                }
            }
        }

        public void PrintElements()
        {
            int count = 0;
            foreach (var item in aeroflots)
            {
                Console.WriteLine("{0}: name: {1}, type: {2}, number: {3}", count, item._name, item._type, item._number);
                count++;
            }
        }

        public void SwitchFilePath()
        {
            Console.WriteLine("Enter new path and(or) name to file");
            FilePath = Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AeroClass aero = new AeroClass();
            aero.PrintElements();

            aero.FindBy();
            aero.Sorting();
            aero.PrintElements();

            aero.AddElement();
            aero.PrintElements();

            aero.RemoveElement(4);
            aero.PrintElements();

            aero.SwitchFilePath();
            aero.WriteToFile();

            Console.ReadKey();
        }
    }
}
