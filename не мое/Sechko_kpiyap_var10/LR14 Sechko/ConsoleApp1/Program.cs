using System;
using System.Text;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				string[] array = { "string1", "string2", "string3" };
				Object[] objarray = (Object[])array;
				Object obj = (Object)1;
				objarray[2] = obj;
			}
			catch (ArrayTypeMismatchException)
			{
				Console.WriteLine("1) ArrayTypeMismatchException");
			}

			try
			{
				int a = 0;
				Console.WriteLine(10 / a);
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("2) DivideByZeroException");
			}

			try
			{
				int[] mass = new int[10];
				Console.WriteLine(mass[20]);
			}
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("3) IndexOutOfRangeException");
			}

			try
			{
				bool flag = true;
				IConvertible conv = flag;
				char ch = conv.ToChar(null);
			}
			catch (InvalidCastException)
			{
				Console.WriteLine("4) InvalidCastException");
			}

			try
			{
				StringBuilder sb = new StringBuilder(15, 15);
				sb.Append("aaaaaaaaaa");
				sb.Insert(0, "bbbbbbbbbb", 1);
			}
			catch (OutOfMemoryException)
			{
				Console.WriteLine("5) OutOfMemoryException");
			}

			checked
			{
				try
				{
					int k = 100;
					int square = int.MaxValue * k;
				}
				catch (OverflowException)
				{
					Console.WriteLine("6) OverflowException");
				}
			}

			Console.ReadKey();
		}
	}
}
