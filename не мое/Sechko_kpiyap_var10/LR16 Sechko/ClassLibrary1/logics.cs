using System;

namespace LogicGate
{
    public class logics
    {
        public logics()
        {
            Console.WriteLine("operations: <, >, !=, <=, >=, =");
            Console.Write("Select operation: "); string operation = Console.ReadLine();

            bool result = false;
            if (operation == ">") result = Bolshe();
            if (operation == "<") result = Menshe();
            if (operation == "<=") result = MensheIliRavno();
            if (operation == ">=") result = BolsheIliRavno();
            if (operation == "!=") result = NeRavno();
            if (operation == "=") result = Ravno();

            Console.WriteLine(result);
        }

        bool Bolshe()
        {
            Console.Write("parametr1 = "); double x = double.Parse(Console.ReadLine());
            Console.Write("parametr2 = "); double y = double.Parse(Console.ReadLine());

            if (x > y) return true;
            else return false;
        }
        
        bool Menshe()
        {
            Console.Write("parametr1 = "); double x = double.Parse(Console.ReadLine());
            Console.Write("parametr2 = "); double y = double.Parse(Console.ReadLine());

            if (x < y) return true;
            else return false;
        }
        
        bool MensheIliRavno()
        {
            Console.Write("parametr1 = "); double x = double.Parse(Console.ReadLine());
            Console.Write("parametr2 = "); double y = double.Parse(Console.ReadLine());

            if (x <= y) return true;
            else return false;
        }
        
        bool BolsheIliRavno()
        {
            Console.Write("parametr1 = "); double x = double.Parse(Console.ReadLine());
            Console.Write("parametr2 = "); double y = double.Parse(Console.ReadLine());

            if (x >= y) return true;
            else return false;
        }
        
        bool NeRavno()
        {
            Console.Write("parametr1 = "); double x = double.Parse(Console.ReadLine());
            Console.Write("parametr2 = "); double y = double.Parse(Console.ReadLine());

            if (x != y) return true;
            else return false;
        }
        
        bool Ravno()
        {
            Console.Write("parametr1 = "); double x = double.Parse(Console.ReadLine());
            Console.Write("parametr2 = "); double y = double.Parse(Console.ReadLine());

            if (x != y) return true;
            else return false;
        }
    }
}
