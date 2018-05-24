/*
 * Сделано в SharpDevelop.
 * Пользователь: Asus
 * Дата: 09.02.2018
 * Время: 5:10
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace GenMeth
{
	/// <summary>
	/// Description of Generator.
	/// </summary>
	public partial class Generator : Form
	{
		public static Generator gf;
		public Generator()
		{
			gf = this;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		// Метод сохранения в файл
		public void  SaveFile()
		{
			if(this.textBox1.Text.Length > 0)
			{
				string s = this.textBox1.Text;
				this.saveFileDialog1.InitialDirectory = System.IO.Path.Combine(Application.StartupPath, @"Методы");
				if(saveFileDialog1.ShowDialog() == DialogResult.OK &&
			  	saveFileDialog1.FileName.Length > 0)
				{
					// Создаю файловый поток
					FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
					// Помещаю файловый поток в оболочку StreamWriter
					StreamWriter sw = new StreamWriter(fs);
					// Записываю данные в файл
					sw.Write(s);
					// Закрываю поток файлового вывода
					sw.Close();
				}
			}else{
				MessageBox.Show("Нет данных для сохранения.", "Внимание!",
				                MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
		
		void ЗакрытьToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void КопироватьВБуферToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.textBox1.SelectAll();
			this.textBox1.Copy();
			this.textBox1.Select(0, 0);
		}
		
		void СохранитьToolStripMenuItemClick(object sender, EventArgs e)
		{
			SaveFile();
		}
	}
}
