using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Zholudov_n2
{
    class Program
    {
        delegate void MyEventHandler(ConsoleKeyInfo consoleKeyInfo);
                                       
        class MyEvent
        {
            public event MyEventHandler SomeEvent;

            public void OnSomeEvent(ConsoleKeyInfo consoleKeyInfo)
            {
                if (SomeEvent != null) SomeEvent(consoleKeyInfo);
            }
        }

        class EventDemo
        {
            public static void handler(ConsoleKeyInfo key)
            {
                Console.WriteLine("Нажата клавиша {0}", key.KeyChar);
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Создание массива символов";
            ConsoleKeyInfo cki;

            string Str = "";
            Console.WriteLine(" Ввод символов в массив. " + "(для прекращения ввода нажмите клавишу<F1>)\n");

            do
            {
                Console.Write(" Введите символ. ");
                cki = Console.ReadKey(true);
                MyEvent myEvent = new MyEvent();
                myEvent.SomeEvent += new MyEventHandler(EventDemo.handler);
                Str += cki.KeyChar;
                myEvent.OnSomeEvent(cki);
            } while (cki.Key != ConsoleKey.F1);

            Console.WriteLine();
            Console.WriteLine(" Массив символов: " + Str);
            Console.ReadKey();
        }
        
    }
}