using System;

namespace MyData
{
    public class MyData
    {
        DateTime value { get; set; }
        public MyData(DateTime date)
        {
            value = date;
            Console.WriteLine("Получена дата {0}", value);
        }

        public int GetYears()
        {
            return value.Year;
        }

        public int GetMonth()
        {
            return value.Month;
        }

        public int GetDay()
        {
            return value.Day;
        }
    }
}
