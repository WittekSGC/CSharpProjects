using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number the trolley bus: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x==2)
            {
                Console.WriteLine("Zyalyonyy lug - TEC-2"); //Зеленый луг - ТЭЦ-2
            } 
            else
            {
                if (x==3)
                {
                    Console.WriteLine("TEC-2 - pl. Ardzhanikidze"); //ТЭЦ-2 - пл. Орджоникидзе
                }
                else
                {
                    if (x==4)
                    {
                        Console.WriteLine("Lyubuzh - ZHD station"); //Любуж - Железнодорожный вокзал (переезд)
                    }
                    else
                    {
                        if (x==5)
                        {
                            Console.WriteLine("TEC-2 - ZHD station");  //ТЭЦ - 2 - Железнодорожный вокзал
                        }
                        else
                        {
                            if (x==6)
                            {
                                Console.WriteLine("Lyubuzh - TEC-2"); //Любуж - ТЭЦ-2
                            }
                            else
                            {
                                if (x==7)
                                {
                                    Console.WriteLine("Lyubuzh - Zyalyonyy lug"); //Любуж - Зеленый луг
                                }
                                else
                                {
                                    if (x == 11)
                                    {
                                        Console.WriteLine("Lyubuzh - Zyalyonyy lug"); //Зеленый луг - Любуж
                                    }
                                    else
                                    {
                                        Console.WriteLine("There is no such trolleybus"); //нету
                                    }
                                }
                            }
                        }
                    }
                }
              
            }
            Console.ReadKey();
        }
    }
}
