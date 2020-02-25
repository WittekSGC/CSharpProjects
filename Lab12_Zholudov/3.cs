using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Zholudov_n3
{
    class Program
    {
        delegate void MyEventHandler();

        class MyEvent
        {
            public event MyEventHandler SomeEvent;

            public void OnSomeEvent()
            {
                if (SomeEvent != null) SomeEvent();
            }
        }

        class EventDemo
        {
            public static void handler()
            {
                Console.WriteLine("Название автомобиля изменено");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите старое название автомобиля: ");
            string old = Console.ReadLine();
            MyEvent myEvent = new MyEvent();
            myEvent.SomeEvent += new MyEventHandler(EventDemo.handler);

            Console.Write("Введите новое название автомобиля: ");
            string nev = Console.ReadLine();

            if (nev != old) myEvent.OnSomeEvent();

            Console.ReadKey();
        }
    }
}
