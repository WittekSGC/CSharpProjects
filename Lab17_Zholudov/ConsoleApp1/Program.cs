using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Aeroflot
    {
        public string _name, _type;    //пункт назначения, тип самолета
        public int _number;            //номер рейса
    }

    class AeroClass : IComparer<Aeroflot>
    {
        string FilePath = "input.txt";
        List<Aeroflot> aeroflots = new List<Aeroflot>();
        string SortParametr;

        public AeroClass()
        {
            ReadFromFile();

            foreach (var item in aeroflots)
            {
                Console.WriteLine(item._name + " " + item._type + " " + item._number);
            }

            //тут типа изменяется все
            AddElement();
            Sorting();

            WriteToFile();

            Console.ReadKey();
        }
        private  void ReadFromFile()
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

        private void WriteToFile()
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

        private void Sorting()
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

        private void AddElement()
        {
            Aeroflot aeroflot = new Aeroflot()
            {
                _name = Console.ReadLine(),
                _type = Console.ReadLine(),
                _number = int.Parse(Console.ReadLine())
            };
            aeroflots.Add(aeroflot);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AeroClass aeroClass = new AeroClass();
            Console.ReadKey();
        }        
    }
}
