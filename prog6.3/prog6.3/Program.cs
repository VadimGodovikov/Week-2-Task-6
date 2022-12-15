using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog6._3
{
	class Program
	{
		static int readInt()
		{
			do
			{
				int res;
				bool pars = int.TryParse(Console.ReadLine(), out res);
				if (pars) return res;
				else Console.WriteLine("Введите корректные данные");
			} while (true);
		}
		static void Main(string[] args)
		{
			n1: Console.WriteLine("Введите размерность двумерного массива: ");
			int n = readInt();

			if (n <= 1)
			{
				Console.WriteLine("Размерность массива не должна быть меньше или равна 1");
				goto n1;
			}

			int[,] arr = new int[n, n];
			int[,] narr = new int[n, n];

			Console.WriteLine("Заполнение массива:\n");
			for(int i = 0; i < n; i++)
			{
				for(int j = 0; j < n; j++)
				{
					Console.WriteLine($"arr[{i},{j}] = ");
					arr[i, j] = readInt();
				}
			}

			Console.WriteLine("\nВаш массив:\n");

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write(arr[i, j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			Console.WriteLine("Изменённый массив: \n");
			if (n % 2 == 0)
			{
				bool b = true;

				for (int j = 0; j < n; j++)
				{
					for (int i = 0; i < n; i++)
					{
						if (b)
						{
							narr[i, j] = arr[i, j + 1];
						}
						else
						{
							narr[i, j] = arr[i, j - 1];
						}
					}
					b = !b;
				}
				
				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < n; j++)
					{
						Console.Write(narr[i, j] + "\t");
					}
					Console.WriteLine();
				}
			}
			else
			{
				Console.WriteLine("Кол-во столбцов нечетное");
			}
			Console.WriteLine();
		}
	}
}
