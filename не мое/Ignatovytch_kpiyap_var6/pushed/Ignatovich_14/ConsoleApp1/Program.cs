using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3] { 1, 3, 0 };
            bool a = true;
            StringBuilder stringBuilder = new StringBuilder(5, 5);
            string b = "dddd", c = "ffff";
            byte f = 240, l = 200;

            try
            {
                try
                {
                    array[1] = -2;
                    for (int i = 0; i < 3; i++)
                    {
                        if (array[i] < 0) throw new ArrayTypeMismatchException();//←
                    }
                }
                catch (ArrayTypeMismatchException)
                {
                    Console.WriteLine("Несовместимые типы сохраняемого элемента и массива");
                }

                try
                {
                    array[0] = array[1] / array[2];
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Попытка деления на ноль");
                }

                try
                {
                    array[4] = 10;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Индекс массива выходит за пределы диапазона");
                }

                try
                {
                    a = Convert.ToBoolean(array[1]);
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine("Некорректное преобразование в процессе выполнения");
                }

                try
                {
                    stringBuilder.Append(b + c);

                }
                catch (OutOfMemoryException)
                {
                    Console.WriteLine("Вызов new был неудачным из-за недостатка памяти");
                }

                try
                {
                    f += l;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Переполнение при выполнении арифметической операции");
                }
            }
            catch
            {
                Console.WriteLine("Произошла неизвестная ошибка");
            }
            Console.ReadKey();
        }
    }
}
