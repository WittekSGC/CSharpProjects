using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    public struct Worker
    {
        public string fio, dolg; 
        public int god;      
    }

    public class WorkerClass : IComparer<Worker>
    {
        string FilePath = "input.txt";
        List<Worker> workers = new List<Worker>();
        string SortParametr;

        public WorkerClass()
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

                Worker tempWorker = new Worker();
                tempWorker.fio = temp;
                temp = inputReader.ReadLine();
                tempWorker.dolg = temp;
                temp = inputReader.ReadLine();
                tempWorker.god = int.Parse(temp);
                workers.Add(tempWorker);
            }
            inputReader.Close();
            input.Close();
        }

        public void WriteToFile()
        {
            FileStream outStream = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter outWriter = new StreamWriter(outStream);

            foreach (var item in workers)
            {
                outWriter.WriteLine();
                outWriter.WriteLine(item.fio);
                outWriter.WriteLine(item.dolg);
                outWriter.WriteLine(item.god);
            }

            outWriter.Close();
            outStream.Close();
        }

        public void Sorting()
        {
            Console.WriteLine("Pick sort parameter: 1 - fio, 2 - dolgnost, 3 - year");
            SortParametr = Console.ReadLine();
            workers.Sort(Compare);
        }

        public int Compare(Worker x, Worker y)
        {
            switch (SortParametr)
            {
                case "1":
                    foreach (char a in x.fio)
                    {
                        foreach (char b in y.fio)
                        {
                            if (a < b) return -1;
                            else if (a > b) return 1;
                        }
                    }
                    return 0;
                case "2":
                    foreach (char a in x.dolg)
                    {
                        foreach (char b in y.dolg)
                        {
                            if (a < b) return -1;
                            else if (a > b) return 1;
                        }
                    }
                    return 0;
                case "3":
                    if (x.god < y.god) return -1;
                    else if (x.god > y.god) return 1;
                    return 0;
                default: return 0;
            }
        }

        public void AddElement()
        {
            Worker worker = new Worker()
            {
                fio = Console.ReadLine(),
                dolg = Console.ReadLine(),
                god = int.Parse(Console.ReadLine())
            };
            workers.Add(worker);
        }

        public void FindBy()
        {
            Console.WriteLine("Enter 'fio', 'dolg' or 'god' to pick type of search");
            string find;
            switch (Console.ReadLine())
            {
                case "fio":
                    Console.Write("Enter search parameter: ");
                    find = Console.ReadLine();
                    foreach (Worker item in workers)
                    {
                        if (item.fio == find)
                        {
                            Console.WriteLine(item.fio + " " + item.dolg + " " + item.god);
                        }
                    }
                    break;
                case "dolg":
                    Console.Write("Enter search parameter: ");
                    find = Console.ReadLine();
                    foreach (Worker item in workers)
                    {
                        if (item.dolg == find)
                        {
                            Console.WriteLine(item.fio + " " + item.dolg + " " + item.god);
                        }
                    }
                    break;
                case "god":
                    Console.Write("Enter search parameter: ");
                    int nfind = int.Parse(Console.ReadLine());
                    foreach (Worker item in workers)
                    {
                        if (item.god == nfind)
                        {
                            Console.WriteLine(item.fio + " " + item.dolg + " " + item.god);
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        public void RemoveElement(int position)
        {
            if (position >= workers.Count || position < 0)
                Console.WriteLine("error index!");
            else
            {
                int count = 0;
                foreach (Worker item in workers.ToArray())
                {
                    if (count == position)
                    {
                        workers.Remove(item);
                        break;
                    }
                    else
                        count++;
                }
            }
        }

        public void PrintElements()
        {
            int count = 0;
            foreach (var item in workers)
            {
                Console.WriteLine("{0}: fio: {1}, dolgnost’: {2}, year: {3}", count, item.fio, item.dolg, item.god);
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
            WorkerClass workless = new WorkerClass();
            workless.PrintElements();

            //Console.WriteLine("\nFind Element");
            //workless.FindBy();

            //Console.WriteLine("\nSort Element");
            //workless.Sorting();
            //workless.PrintElements();

            Console.WriteLine("\nAdd Element");
            workless.AddElement();
            workless.PrintElements();

            Console.WriteLine("\nRemove Element (4)");
            workless.RemoveElement(4);
            workless.PrintElements();

            Console.WriteLine("\nSave to another file all Elements");
            workless.SwitchFilePath();
            workless.WriteToFile();

            Console.ReadKey();
        }
    }
}

