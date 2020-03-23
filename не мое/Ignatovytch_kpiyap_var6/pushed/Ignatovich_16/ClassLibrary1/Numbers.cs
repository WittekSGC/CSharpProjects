using System;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class Numbers
    {
        private int NumberC;
        private bool NC;
        private double NumberN;
        private bool NN;
        private double NumberX;
        private bool NX;
        char pick;
        public Numbers()
        {
            start:
            Console.WriteLine("Select pattern: C, N, X. If you will show help, return H");
            pick = Char.Parse(Console.ReadLine());
            switch (pick)
            {
                case 'C': PatternC(); break;
                case 'N': PatternN(); break;
                case 'X': PatternX(); break;
                case 'H': ReleaseNote(); goto start;
                default:
                    goto start;
            }
        }
        public void ReleaseNote()
        {
            Console.WriteLine("Havent 3 patterns of numbers: pattern C - int nuber; pattern N - double number, which haven't numbers after point; pattern X - random double number"); 
        }

        private void PatternC()
        {
            Console.Write("Input int number: ");
            string income = Console.ReadLine();
            NC = false;
            try
            {
                NumberC = int.Parse(income);
                NC = true;
            }
            catch
            {
                ShowError();
            }
        }

        private void PatternN()
        {
            Console.Write("Input int number: ");
            string income = Console.ReadLine();
            NN = false;
            try
            {
                NumberN = int.Parse(income);
                NN = true;
            }
            catch
            {
                ShowError();
            }
        }

        private void PatternX()
        {
            Console.Write("Input int number: ");
            string income = Console.ReadLine();
            NX = false;
            try
            {
                NumberX = Double.Parse(income);
                NX = true;
            }
            catch
            {
                ShowError();
            }
        }

        private void ShowError()
        {
            Console.WriteLine("Error number or not illegal to pattern ");
        }

        public void PrintEtryingNumber()
        {
            switch (pick)
            {
                case 'C':
                    if (NC)
                        Console.WriteLine(NumberC);
                    else
                        ShowError();
                    break;
                case 'N':
                    if (NN) 
                        Console.WriteLine(NumberN);
                    else
                        ShowError();
                    break;
                case 'X':
                    if (NX)
                        Console.WriteLine(NumberX);
                    else
                        ShowError();
                    break;
                default: break;
            }
        }
    }
}
