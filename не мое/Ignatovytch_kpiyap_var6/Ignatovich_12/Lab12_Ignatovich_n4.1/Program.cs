using System;

namespace ConsoleApp
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
            strMod myFunc = delegate (string a)
            {
                return a.Replace(' ', '-');
            };
            return myFunc;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string custom = "my some text for tests";

            strMod strOp = new strMod(DelegateTest.replaceSpaces);//просто метод
            Console.WriteLine(strOp(custom));

            strMod mod1 = DelegateTest.ModifyAnonim(); //через анонимный метод
            Console.WriteLine(mod1(custom));

            strMod mod2 = a => a.Replace(' ', '-'); //через лямбду
            Console.WriteLine(mod2(custom));

            Console.ReadKey();
        }
    }
}
