/*
 * Сделано в SharpDevelop.
 * Пользователь: ТМ
 * Дата: 08.02.2018
 * Время: 5:40
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using IdentCtrl;

namespace GenMeth
{
	/// <summary>
	/// Description of NamesEdit.
	/// </summary>
	public partial class NamesEdit : Form
	{
		// Создание объекта класса проверки идентификаторов
		IdentInputControl ic1 = new IdentInputControl();
		
		public NamesEdit()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(this.textBox1.Text.Length > 0)
			{
				switch(this.Text)
				{
					case "Изменить имя объекта класса DataSet":
						MainForm.Main_Form.toolStripTextBox1.Text = this.textBox1.Text;
						break;
					case "Изменить имя метода":
						MainForm.Main_Form.toolStripTextBox2.Text = this.textBox1.Text;
						break;
				}
				this.Close();
			}else{
				MessageBox.Show("Пустое значение!", "Ошибка!",
				               MessageBoxButtons.OK,
				              MessageBoxIcon.Error);
				this.textBox1.Focus();
			}
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			ic1.IdentControl(this.textBox1);
		}
	}
}
