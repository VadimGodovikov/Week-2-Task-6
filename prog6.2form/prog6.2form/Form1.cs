using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog6._2form
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

			if (n <= 0)
			{
				MessageBox.Show("Размерность массива не должна быть меньше или равно 0");
				return;
			}

			double A = double.Parse(numericUpDown2.Text);
			double B = double.Parse(numericUpDown3.Text);

			if (A > B)
			{
				MessageBox.Show("Начальное число диапазона рандома не должно быть меньше конечного");
			}

			textBox1.Text = "Результат работы программы" + Environment.NewLine;
			double[] arr = new double[n];
			for (int i = 0; i < n; i++)
			{
				arr[i] = A + rand.NextDouble() * (B - A);
			}

			textBox1.Text += "Ваш массив: " + Environment.NewLine;
			for (int i = 0; i < n; i++)
			{
				textBox1.Text += $"arr[{i}] = {arr[i]:f2}" + Environment.NewLine;
			}

			double max = arr[0];
			int index = 0;

			for (int i = 0; i < n; i++)
			{
				if (max < arr[1])
				{
					max = arr[i];
					index = i;
				}
			}

			textBox1.Text += $"\nНомер первого максимального элемента = {index}" + Environment.NewLine;
		}
	}
}
