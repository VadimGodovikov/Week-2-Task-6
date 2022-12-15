using System;

namespace prog6._1
{
	class Program
	{
		public static int readInt()
		{
			do
			{
				int res;
				bool pars = int.TryParse(Console.ReadLine(), out res);
				if (pars) return res;
				else Console.WriteLine("Введите корректное число: ");
			} while (true);
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Одномерный массив\n\n");
			n1: Console.WriteLine("Введите размерность одномерного массива: ");
			int n = readInt();

			if(n <= 0)
			{
				Console.WriteLine("Размерность массива не должна быть меньше или равно 0");
				goto n1;
			}

			int[] odn = new int[n];
			int sum = 0;
			for (int i = 0; i < odn.Length; i++)
			{
				Console.WriteLine($"odn[{i}] = ");
				odn[i] = readInt();
				if (odn[i] % 9 == 0)
				{
					sum += odn[i];
				}
			}

			Console.WriteLine("Ваш массив:\n ");

			for(int i = 0; i < odn.Length; i++)
			{
				Console.WriteLine($"odn[{i}] = {odn[i]}");
			}

			Console.WriteLine($"Сумма элементов кратных 9: {sum}");
		}
	}
}
