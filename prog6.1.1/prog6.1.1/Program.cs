using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog6._1._1
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
			Console.WriteLine("Двумерный массив\n");

		n2: Console.WriteLine("Введите кол-во столбцов в массиве: ");
			int n = readInt();

			if (n <= 0)
			{
				Console.WriteLine("Кол-во столбцов массива не должны быть меньше или равно 0");
				goto n2;
			}
		m1: Console.WriteLine("Введите кол-во строк в массиве: ");
			int m = readInt();
			if (m <= 0)
			{
				Console.WriteLine("Кол-во столбцов массива не должны быть меньше или равно 0");
				goto m1;
			}

			int sum = 0;
			int[,] mnog = new int[n, m];
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					Console.WriteLine($"mnog[{i},{j}] = ");
					mnog[i, j] = readInt();
					if (mnog[i, j] % 9 == 0)
					{
						sum += mnog[i, j];
					}
				}
			}

			Console.WriteLine("Ваш массив: ");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					Console.Write($"{mnog[i, j]}\t");
				}
				Console.WriteLine();
			}

			Console.WriteLine($"Сумма элементов кратных 9: {sum}");
		}
	}
}
