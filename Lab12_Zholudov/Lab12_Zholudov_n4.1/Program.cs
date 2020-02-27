using System;

namespace ConsoleApplication1
{
    delegate string strMod(string stx); 

    class DelegateTest
    {
        public static string replaceSpaces(string a)
        {
            return a.Replace(' ', '-');
        }

        public static strMod ModifyAnonim()
        {
            strMod mod = delegate (string a)
            {
                return a.Replace(' ', '-');
            };
            return mod;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Пример №1";
            Console.BackgroundColor = ConsoleColor.White; Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            string custom = "my some text for tests";

            strMod strOp = new strMod(DelegateTest.replaceSpaces);//просто метод
            Console.WriteLine(strOp(custom) + "||||METHOD||||");

            strMod mod1 = DelegateTest.ModifyAnonim(); //через анонимный метод
            Console.WriteLine(mod1(custom) + "||||ANONYMUS||||");

            strMod mod2 = a => a.Replace(' ', '-'); //через лямбду
            Console.WriteLine(mod2(custom) + "||||LAMBDA||||");

            Console.ReadKey();
        }
    }
}