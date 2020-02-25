using System;
namespace ConsoleApplication1
{
    delegate string strMod(string stx); 
    class DelegateTest
                      
    {
        public static string replaceSpaces(string a)
        {
            Console.WriteLine(" Замена пробелов дефисами.");
            return a.Replace(' ', '-');
        }

      /*  public static string removeSpaces(string a)
        {
            string temp = "";
            Console.WriteLine(" Удаление пробелов.");
            for (int i = 0; i < a.Length; i++)
                if (a[i] != ' ')
                    temp += a[i];
            return temp;
        }

        public static string reverse(string a)
        {
            string temp = "";
            Console.WriteLine(" Реверсирование строки.");
            for (int j = 0, i = a.Length - 1; i >= 0; i--, j++)
                temp += a[i];
            return temp;
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            strMod strOp = new strMod(DelegateTest.replaceSpaces);

            str = strOp(" Это простой тест.");
            Console.WriteLine(" Результирующая строка: " + str);
            Console.WriteLine();

           /* strOp = new strMod(DelegateTest.removeSpaces);
            str = strOp(" Это простой тест.");
            Console.WriteLine(" Результирующая строка: " + str);
            Console.WriteLine();

            strOp = new strMod(DelegateTest.reverse);
            str = strOp(" Это простой тест.");
            Console.WriteLine(" Результирующая строка: " + str);
            Console.Write("Для завершения работы приложения нажмите клавишу < Enter > ");*/

            Console.Read();
        }
    }
}