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
				string[] array = { "a", "b", "c" };
				Object[] objarray = (Object[])array;
				Object obj = (Object)10000;
				objarray[2] = obj;
			}
			catch (ArrayTypeMismatchException e)
			{
				Console.WriteLine("ArrayTypeMismatchException: " + e.Message);
			}

			try
			{
				int a = 0;
				Console.WriteLine(0 / a);
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine("DivideByZeroException: " + e.Message);
			}

			try
			{
				int[] mass = new int[1];
				Console.WriteLine(mass[2]);
			}
			catch (IndexOutOfRangeException e)
			{
				Console.WriteLine("IndexOutOfRangeException: " + e.Message);
			}

			try
			{
				bool g = true;
				IConvertible convertion = g;
				char c = convertion.ToChar(null);
			}
			catch (InvalidCastException e)
			{
				Console.WriteLine("InvalidCastException: " + e.Message);
			}

			try
			{
				StringBuilder s = new StringBuilder(15, 15);
				s.Append("abcdefgh");
				s.Insert(5, "abcdefgh", 1);
			}
			catch (OutOfMemoryException e)
			{
				Console.WriteLine("OutOfMemoryException: " + e.Message);
			}

			checked
			{
				try
				{
					int k = 2;
					int kv = int.MaxValue * k;
				}
				catch (OverflowException e)
				{
					Console.WriteLine("overflowException: " + e.Message);
				}
			}

			Console.ReadKey();
		}
	}
}
