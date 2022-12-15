using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog6._4
{
	class Program
	{
		static int readiInt()
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
			n1: Console.WriteLine("Введите размерность ступенчатого массива: ");
			int n = readiInt();
			if (n <= 1)
			{
				Console.WriteLine("Размерность ступенчатого массива не может быть меньше или равна 1");
				goto n1;
			}

			Console.WriteLine("Заполнение массива:\n");
			int[][] arr = new int[n][];
			for(int i = 0; i < n; i++)
			{
				arr[i] = new int[n];
				for(int j = 0; j < n; j++)
				{
					Console.WriteLine($"arr[{i},{j}] = ");
					arr[i][j] = readiInt();
				}
			}
			Console.WriteLine("Ваш массив:\n");

			for(int i = 0; i < n; i++)
			{
				for(int j = 0; j < n; j++)
				{
					Console.Write($"{arr[i][j]}\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			int[] rez = new int[n];
			Console.WriteLine("Массив из первых положительных элементов:\n");
			for(int j = 0; j < n; j++)
			{
				for(int i = 0; i < n; i++)
				{
					if(arr[i][j] > 0)
					{
						rez[j] = arr[i][j];
						break;
						
					}
				}
			}
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine($"{rez[i]}\t");
			}
			Console.WriteLine();

			Console.ReadLine();

		}
	}
}
