/*
 * Сделано в SharpDevelop.
 * Пользователь: ТМ
 * Дата: 02.05.2018
 * Время: 7:11
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GenMeth
{
	/// <summary>
	/// Description of About.
	/// </summary>
	public partial class About : Form
	{
		public About()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void AboutClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
