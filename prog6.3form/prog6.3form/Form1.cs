using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog6._3form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Random rand = new Random();
			int n = int.Parse(numericUpDown1.Text);
			if (n <= 1)
			{
				MessageBox.Show("Размерность массива не должна быть меньше или равна 1");
				return;
			}
			int A = int.Parse(numericUpDown2.Text);
			int B = int.Parse(numericUpDown3.Text);

			if (A > B)
			{
				MessageBox.Show("Начальное число диапазона не может быть больше конечного");
				return;
			}

			int[,] arr = new int[n, n];
			int[,] narr = new int[n, n];

			textBox1.Text = "Результат работы программы:" + Environment.NewLine;
			textBox1.Text += "Ваш массив: " + Environment.NewLine;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					arr[i, j] = rand.Next(A, B);
					textBox1.Text += arr[i, j] + "\t";
				}
				textBox1.Text += "" + Environment.NewLine;
			}

			textBox1.Text += "" + Environment.NewLine;
			textBox1.Text += "Изменённый массив" + Environment.NewLine;
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
						textBox1.Text += narr[i, j] + "\t";
					}
					textBox1.Text += "" + Environment.NewLine;
				}
			}
			else
			{
				MessageBox.Show("Кол-во столбцов нечетное");
			}
		}

	}
	
}
