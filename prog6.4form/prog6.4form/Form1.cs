using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog6._4form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			try
			{
				string[] strs = ElementsMas.Text.Split(' ');
				int n = int.Parse(RazmerMas.Text);
				if (n <= 1)
				{
					MessageBox.Show("Размерность массива должны быть больше 1");
					return;
				}

				int[][] arr = new int[n][];

				int iterator = 0;
				for (int i = 0; i < n; i++)
				{
					arr[i] = new int[n];
					for (int j = 0; j < n; j++)
					{
						int number = int.Parse(strs[iterator]);
						arr[i][j] = number;
						iterator++;
					}
				}
				string result = "Получившийся массив:\n";
				result += "";
				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < n; j++)
					{
						result += $"{arr[i][j]}\t";
					}
					result += "\n";
				}

				int[] rez = new int[n];
				result += "Массив из первых положительных элементов:\n";
				result += "";
				for (int j = 0; j < n; j++)
				{
					for (int i = 0; i < n; i++)
					{
						if (arr[i][j] > 0)
						{
							rez[j] = arr[i][j];
							break;

						}
					}
				}
				for (int i = 0; i < n; i++)
				{
					result += $"{rez[i]}\t";
				}
				result += "\n";
				result += "Если вышло 0, значит положительных элементов нет";

				MessageBox.Show(result, "Результат");
			}
			catch (FormatException)
			{
				MessageBox.Show("Ожидается ввод целых чисел элементов массива и размерности строк массива!", "Ошибка");
				return;
			}
			catch (IndexOutOfRangeException)
			{
				MessageBox.Show($"Неверное количество элементов массива!", "Ошибка");
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка");
				return;
			}


		}
	}
}
