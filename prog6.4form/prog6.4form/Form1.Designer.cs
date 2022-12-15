namespace prog6._4form
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.RazmerMas = new System.Windows.Forms.TextBox();
			this.ElementsMas = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 189);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(479, 40);
			this.button1.TabIndex = 8;
			this.button1.Text = "Пуск";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// RazmerMas
			// 
			this.RazmerMas.Location = new System.Drawing.Point(209, 27);
			this.RazmerMas.Multiline = true;
			this.RazmerMas.Name = "RazmerMas";
			this.RazmerMas.Size = new System.Drawing.Size(282, 35);
			this.RazmerMas.TabIndex = 9;
			// 
			// ElementsMas
			// 
			this.ElementsMas.Location = new System.Drawing.Point(209, 97);
			this.ElementsMas.Multiline = true;
			this.ElementsMas.Name = "ElementsMas";
			this.ElementsMas.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.ElementsMas.Size = new System.Drawing.Size(282, 34);
			this.ElementsMas.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Введите размер массива";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Введите элементы массива";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 252);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ElementsMas);
			this.Controls.Add(this.RazmerMas);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox RazmerMas;
		private System.Windows.Forms.TextBox ElementsMas;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

