using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog6._1form
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
			try
			{
				int n = int.Parse(numericUpDown1.Text);

				if(n <= 0)
				{
					MessageBox.Show("Размерность массива не может быть меньше или равно 0");
					return;
				}

				int A = int.Parse(numericUpDown2.Text);
				int B = int.Parse(numericUpDown3.Text);

				int sum = 0;

				int[] odn = new int[n];

				if(A > B)
				{
					MessageBox.Show("Начальное число диапазона не должно быть больше конечного");
				}

				textBox1.Text = "Реузльтат программы:" + Environment.NewLine;

				textBox1.Text = "Ваш одномерный массив: " + Environment.NewLine;
				for(int i = 0; i < n; i++)
				{
					odn[i] = rand.Next(A, B);
					if (odn[i] % 9 == 0)
					{
						sum += odn[i];
					}
					textBox1.Text += $"massive[{i}] = {odn[i]}" + Environment.NewLine;
				}

				textBox1.Text += $"Сумма элементов массива кратных 9 = {sum}" + Environment.NewLine;

			}
			catch
			{
				MessageBox.Show("Введите корректное значение");
				return;
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Random rand = new Random();
			try
			{
				int n = int.Parse(numericUpDown4.Text);

				if (n <= 0)
				{
					MessageBox.Show("Кол-во столбцов не может быть меньше или равно 0");
					return;
				}

				int m = int.Parse(numericUpDown5.Text);

				if (m <= 0)
				{
					MessageBox.Show("Кол-во строк не может быть меньше или равно 0");
					return;
				}

				int A = int.Parse(numericUpDown6.Text);
				int B = int.Parse(numericUpDown7.Text);

				int sum = 0;

				int[,] mnog = new int[n,m];

				if (A > B)
				{
					MessageBox.Show("Начальное число диапазона не должно быть больше конечного");
				}

				textBox2.Text = "Реузльтат программы:" + Environment.NewLine;

				textBox2.Text = "Ваш двумерный массив: " + Environment.NewLine;
				for (int i = 0; i < n; i++)
				{
					for(int j = 0; j < m; j++)
					{
						mnog[i,j] = rand.Next(A, B);
						if (mnog[i,j] % 9 == 0)
						{
							sum += mnog[i,j];
						}
						textBox2.Text += $"massive[{i},{j}] = {mnog[i,j]}" + Environment.NewLine;
					}
				}

				textBox2.Text += $"Сумма элементов массива кратных 9 = {sum}" + Environment.NewLine;

			}
			catch
			{
				MessageBox.Show("Введите корректное значение");
				return;
			}
		}
	}
}
