using System;
using System.Text;

namespace LR14Valetova
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				int a = 1, b = 0;
				Console.WriteLine(a / b);
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Деление на ноль!");
			}

			try
			{
				int[] c = new int[3];
				Console.WriteLine(c[4]);
			}
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("Ошибка индекса массива!");
			}

			try
			{
				string[] names = { "Dog", "Cat", "Fish" };
				Object[] objs = (Object[])names;
				Object obj = (Object)13;
				objs[2] = obj;
			}
			catch (ArrayTypeMismatchException)
			{
				Console.WriteLine("Несовместимость типов переменной и массива!");
			}

			bool flag = true;
			try
			{
				IConvertible conv = flag;
				Char ch = conv.ToChar(null);
			}
			catch (InvalidCastException)
			{
				Console.WriteLine("Невозможное преобразование!");
			}

			try
			{
				StringBuilder sb = new StringBuilder(15, 15);
				sb.Append("Substring #1 ");			
				sb.Insert(0, "Substring #2 ", 1);
			}
			catch (OutOfMemoryException)
			{
				Console.WriteLine("Недостаточно памяти!");
			}

			int value = 780000000;
			checked
			{
				try
				{
					int square = value * value;
					Console.WriteLine("{0} ^ 2 = {1}", value, square);
				}
				catch (OverflowException)
				{
					Console.WriteLine("Переполнение типа данных переменной!");
				}
			}

			Console.ReadKey();
        }
    }
}
