/*
 * Сделано в SharpDevelop.
 * Пользователь: ТМ
 * Дата: 30.03.2018
 * Время: 9:32
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace GenMeth
{
	partial class PropertyEdit
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Текущая таблица:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Текущий столбец:";
			// 
			// tabControl1
			// 
			this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
			this.tabControl1.Location = new System.Drawing.Point(13, 63);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(428, 94);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 2;
			this.tabControl1.TabStop = false;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.radioButton3);
			this.tabPage1.Controls.Add(this.radioButton2);
			this.tabPage1.Controls.Add(this.radioButton1);
			this.tabPage1.Location = new System.Drawing.Point(4, 5);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(420, 85);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
			this.radioButton3.Location = new System.Drawing.Point(161, 58);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(110, 23);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.Text = "Внешний ключ";
			this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
			this.radioButton2.Location = new System.Drawing.Point(161, 32);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(110, 23);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "Первичный ключ";
			this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
			this.radioButton1.Location = new System.Drawing.Point(161, 6);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(110, 23);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.Text = "Столбец данных";
			this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.Click += new System.EventHandler(this.RadioButton1Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.numericUpDown2);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.numericUpDown1);
			this.tabPage2.Location = new System.Drawing.Point(4, 5);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(420, 85);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(215, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Шаг автоинкремента";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(105, 46);
			this.numericUpDown2.Maximum = new decimal(new int[] {
									1000000,
									0,
									0,
									0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(90, 20);
			this.numericUpDown2.TabIndex = 2;
			this.numericUpDown2.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(215, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(199, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Начальное значение автоинкремента";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(105, 19);
			this.numericUpDown1.Maximum = new decimal(new int[] {
									1000000,
									0,
									0,
									0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(90, 20);
			this.numericUpDown1.TabIndex = 0;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.label10);
			this.tabPage4.Controls.Add(this.textBox4);
			this.tabPage4.Controls.Add(this.label9);
			this.tabPage4.Controls.Add(this.comboBox1);
			this.tabPage4.Controls.Add(this.label8);
			this.tabPage4.Controls.Add(this.numericUpDown3);
			this.tabPage4.Location = new System.Drawing.Point(4, 5);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(420, 85);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "tabPage4";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(216, 64);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(66, 13);
			this.label10.TabIndex = 13;
			this.label10.Text = "Выражение";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(28, 60);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(170, 20);
			this.textBox4.TabIndex = 12;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(216, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 13);
			this.label9.TabIndex = 11;
			this.label9.Text = "Тип данных";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"String",
									"Boolean",
									"Byte",
									"Char",
									"DateTime",
									"Decimal",
									"Double",
									"Int16",
									"Int32",
									"Int64",
									"SByte",
									"Single",
									"TimeSpan",
									"UInt16",
									"UInt32",
									"UInt64"});
			this.comboBox1.Location = new System.Drawing.Point(75, 5);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 10;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(216, 37);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(161, 13);
			this.label8.TabIndex = 9;
			this.label8.Text = "Максимальная длина столбца";
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(106, 33);
			this.numericUpDown3.Maximum = new decimal(new int[] {
									10000,
									0,
									0,
									0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(90, 20);
			this.numericUpDown3.TabIndex = 8;
			this.numericUpDown3.Value = new decimal(new int[] {
									25,
									0,
									0,
									0});
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(233, 172);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Отменить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.Location = new System.Drawing.Point(136, 171);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Принять";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// PropertyEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 208);
			this.ControlBox = false;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "PropertyEdit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Свойства столбца";
			this.Load += new System.EventHandler(this.PropertyEditLoad);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.Label label8;
		public System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		public System.Windows.Forms.RadioButton radioButton1;
		public System.Windows.Forms.RadioButton radioButton2;
		public System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabPage tabPage2;
		public System.Windows.Forms.TabPage tabPage1;
		public System.Windows.Forms.TabControl tabControl1;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label1;
	}
}
