using System;

namespace Lab6_Zholudov_n3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] znak = new string[12][] 
            {
                new string [] {"Овен"},
                new string [] {"Телец"},
                new string [] {"Близнецы"},
                new string [] {"Рак"},
                new string [] {"Лев"},
                new string [] {"Дева"},
                new string [] {"Весы"},
                new string [] {"Скорпион"},
                new string [] {"Стрелец"},
                new string [] {"Козерог"},
                new string [] {"Водолей"},
                new string [] {"Рыбы"},
            };

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(znak[i][0]);
            }
        }
    }
}
