﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace KPI_Test
{
    public interface IA
    {
        double Balans { get; }

        void Zachisl(double sum);
        void Nalog(double sum); //abonplata
    }

    public interface IB
    {
        string Surname { get; set; }
        string Name { get; set; }

        void ShowInfo(string filename);
    }

    public class MyKlass : IA, IB
    {

        double MySum { get; set; }
        public double Balans { get; set; }
        public string Name{ get; set; } 
        public string Surname { get; set; }
        
        public MyKlass()
        {
            MySum = 1000;
            Name = "Ya";
            Surname = "Ty";
        }

        public MyKlass(string name, string surname, double money)
        {
            MySum = money;
            Name = name;
            Surname = surname;
        }
        public void Zachisl(double sum)
        {
            Balans += sum;
            MySum -= sum;
        }
        public void Nalog(double sum)
        {
            try
            {
                Balans -= sum;
                if (Balans<0) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Недостаточно средств");
            }
        }

        public void ShowInfo(string filename)
        {
            FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);

            Console.WriteLine(Name);
            writer.WriteLine(Name);
            Console.WriteLine(Surname);
            writer.WriteLine(Surname);
            Console.WriteLine($"My money {MySum}");
            writer.WriteLine($"My money {MySum}");
            Console.WriteLine($"Balans {Balans}");
            writer.WriteLine($"Balans {Balans}");

            writer.Close();
        }        
    }

    delegate void Method1(double sum);

    class Program
    {
        static void Main(string[] args)
        {
            MyKlass first = new MyKlass();
            MyKlass second = new MyKlass("one", "two", 500);

            Method1 firstMethods = new Method1(first.Zachisl);
            firstMethods.Invoke(100);
            first.ShowInfo("first");

            Console.ReadLine();
        }
    }
}