using System

namespace Lab12_Zholudov_n4
{
    class Program
    {
        delegate string MyEventHandler();

        class MyEvent
        {
            public event MyEventHandler SomeEvent;

            public string OnSomeEvent()
            {
                return SomeEvent();
            }
        }

        class EventDemo
        {
            public static string handler()
            {
                Console.Write("Вы хотите изменить название автомобиля (Y - да, N - нет)?: ");
                ConsoleKeyInfo key = Console.ReadKey();

                if (Convert.ToChar(key.KeyChar) == 'y' || Convert.ToChar(key.KeyChar) == 'Y')
                {
                    Console.WriteLine();
                    Console.Write("Введите новое название автомобиля: ");
                    return Console.ReadLine();
                }
                else if (Convert.ToChar(key.KeyChar) == 'n' || Convert.ToChar(key.KeyChar) == 'N')
                {
                    return null;
                }
                else return null;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите старое название автомобиля: ");
            string old = Console.ReadLine();
            MyEvent myEvent = new MyEvent();
            myEvent.SomeEvent += new MyEventHandler(EventDemo.handler);

            string nev = myEvent.OnSomeEvent();
            if (nev != null)
            {
                old = nev;
                Console.WriteLine("Название изменено");
            }

            Console.ReadKey();
        }
    }
}
