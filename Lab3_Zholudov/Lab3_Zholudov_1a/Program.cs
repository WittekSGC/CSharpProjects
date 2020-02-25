using System;

namespace Lab3_Zholudov_1a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of trolley bus: ");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 2:
                    Console.WriteLine("Zyalyonyy lug - TEC-2"); break;
                case 3:
                    Console.WriteLine("TEC-2 - pl. Ardzhanikidze"); break;,
                case 4:
                    Console.WriteLine("Lyubuzh - ZHD station"); break;
                case 5:
                    Console.WriteLine("TEC-2 - ZHD station"); break;
                case 6:
                    Console.WriteLine("Lyubuzh - TEC-2"); break;
                case 7:
                    Console.WriteLine("Lyubuzh - Zyalyonyy lug"); break;
                case 11:
                    Console.WriteLine("Lyubuzh - Zyalyonyy lug"); break;
                default:
                    Console.WriteLine("This tolley bus is not found..."); break;
            }
            Console.ReadKey();
        } 
    }
}
