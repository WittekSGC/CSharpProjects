using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab22
{ 
    class Program
    {
        static void Main(string[] args)
        {
            string [] [] vr = new string [4][];
            vr[0] = new string[0]["Зима"];
            vr[1] = new string[1]["Весна"];
            vr[2] = new string[2]["Лето"];
            vr[3] = new string[3]["Осень"];

            Console.Write("Enter number of monat: ");
            int i = int.Parse(Console.ReadLine());

            if (i>0 && i<4) Console.WriteLine("{0}", vr[0]);

        }    
    }
}
