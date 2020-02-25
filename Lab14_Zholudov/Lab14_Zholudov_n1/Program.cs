using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_Zholudov_n1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3] { 1, 3, 0 };
            bool a = true ;
            StringBuilder stringBuilder = new StringBuilder(5, 5);
            string b = "dddd", c = "ffff";
            byte f = 240, l = 200;
            try
            {
                array[1] = -2;
                for (int i = 0; i < 3; i++)
                {
                    if (array[i] < 0) throw new ArrayTypeMismatchException();//←
                }

                array[0] = array[1] / array[2];//←DivideByZero

                array[4] = 10; //←IndexOutOfRangeException

                a = Convert.ToBoolean(array[1]);//←InvalidCastException

                stringBuilder.Append(b + c);//←OutOfMemoryException

                f += l;//←OverflowException
            }
            catch (ArrayTypeMismatchException)
            {
                Console.WriteLine("Несовместимые типы сохраняемого элемента и массива");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Попытка деления на ноль");

            }
            catch (StackOverflowException)
            {
                Console.WriteLine("Переполнение стека");

            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Вызов new был неудачным из-за недостатка памяти");

            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Некорректное преобразование в процессе выполнения");

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Индекс массива выходит за пределы диапазона");

            }
            catch (OverflowException)
            {
                Console.WriteLine("Переполнение при выполнении арифметической операции");

            }
            catch
            {
                Console.WriteLine("Произошла неизвестная ошибка");
            }
        }
    }
}
