using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog6._2
{
	class Program
	{
		static double readDouble()
		{
			do
			{
				double res;
				bool pars = double.TryParse(Console.ReadLine(), out res);
				if (pars) return res;
				else Console.WriteLine("Введите корректное число");
			} while (true);
		}
		static int readInt()
		{
			do
			{
				int res;
				bool pars = int.TryParse(Console.ReadLine(), out res);
				if (pars) return res;
				else Console.WriteLine("Введите корректное число");
			} while (true);
		}
		static void Main(string[] args)
		{
			n1: Console.WriteLine("Введите размерность массива: ");
			int n = readInt();

			if (n <= 0)
			{
				Console.WriteLine("Размерность массива не должна быть меньше или равно 0");
				goto n1;
			}

			double[] arr = new double[n];
			Console.WriteLine("Заполните массив: \n");
			for (int i = 0; i < n; i++)
			{
				Console.Write($"arr[{i}] = ");
				arr[i] = readDouble();
			}

			Console.WriteLine("\nВаш массив: ");
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine($"arr[{i}] = {arr[i]}");
			}

			double max = arr[0];
			int index = 0;
			for (int i = 0; i < n; i++)
			{
				if(max < arr[1])
				{
					max = arr[i];
					index = i;
				}
			}

			Console.WriteLine($"\nНомер первого максимального элемента {max} = {index}");
			
		}
	}
}
