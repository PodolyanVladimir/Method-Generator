/*
 * Сделано в SharpDevelop.
 * Пользователь: Asus
 * Дата: 31.01.2018
 * Время: 3:15
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using IdentCtrl;
using UnicalCtrl;
using GenMeth;

namespace GenMeth
{
	/// <summary>
	/// Description of Dialog.
	/// </summary>
	public partial class Dialog : Form
	{
		// Создание объекта класса проверки идентификаторов
		IdentInputControl ic = new IdentInputControl();
		// Создание объекта класса проверки на уникальность имён
		UnicCtrl uc = new UnicCtrl();
		
		public Dialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		// Метод проверки уникальности имён столбюцов в пределах таблицы
		public bool ClmnsNameCtrl()
		{
			bool ctrl = true;
			for(int i = 0; i < MainForm.Main_Form.dataGridView2.Rows.Count; i++)
			{
				if((this.textBox1.Text == MainForm.Main_Form.dataGridView2.Rows[i].Cells[2].Value.ToString())
				   &&(MainForm.Main_Form.GetCurTable() == int.Parse(MainForm.Main_Form.dataGridView2.Rows[i].Cells[0].Value.ToString())))
				{
					ctrl = false;
					break;
				}else{
					ctrl = true;
				}
			}
			return ctrl;
		}
		
		
		// Кнопка "Отменить"
		void Button2Click(object sender, EventArgs e)
		{
			this.textBox2.Text = "";
			this.Close();
		}
		
		// Кнопка "Добавить"
		void Button1Click(object sender, EventArgs e)
		{
				switch(this.Text){
					case "Новое имя таблицы":
					if((this.textBox1.Text.Length > 0)&&(this.textBox2.Text.Length > 0))
						{
							if(uc.UnicName(MainForm.Main_Form.dataGridView1, 1, textBox1))
							{
								MainForm.Main_Form.AddNamesToGrid(
									MainForm.Main_Form.dataGridView1,
									this.textBox1, 1, 0, 1, this.textBox2);
								this.Close();
							}
						}else{
							if(this.textBox1.Text.Length == 0)
							{
								MessageBox.Show("Не введено имя объекта таблицы", "Ошибка!",
							                MessageBoxButtons.OK,
							                MessageBoxIcon.Error);
							}
							if(this.textBox2.Text.Length == 0)
							{
								MessageBox.Show("Не введён псевдоним таблицы", "Ошибка!",
							                MessageBoxButtons.OK,
							                MessageBoxIcon.Error);
							}
						}
						break;
					case "Новое имя столбца":
						if((this.textBox1.Text.Length > 0)&&(this.textBox2.Text.Length > 0))
						{
							if(uc.UnicName(MainForm.Main_Form.dataGridView2, 2, textBox1))
							{
								MainForm.Main_Form.AddNamesToGrid(
									MainForm.Main_Form.dataGridView2,
									this.textBox1, 2, 1, 2, this.textBox2);
								this.Close();
							}
						}else{
							if(this.textBox1.Text.Length == 0)
							{
								MessageBox.Show("Не введено имя объекта столбца!", "Ошибка!",
							                MessageBoxButtons.OK,
							                MessageBoxIcon.Error);
							}
							if(this.textBox2.Text.Length == 0)
							{
								MessageBox.Show("Не введён псевдоним столбца!", "Ошибка!",
							                MessageBoxButtons.OK,
							                MessageBoxIcon.Error);
							}
						}
						break;
					case "Изменение имени таблицы":
						if((this.textBox1.Text.Length > 0)&&(this.textBox2.Text.Length > 0))
						{
							if(MainForm.Main_Form.dataGridView1.Rows[(MainForm.Main_Form.NumCurTable - 1)].Cells[1].Value.ToString() == this.textBox1.Text)
							{
								MainForm.Main_Form.dataGridView1.Rows[(MainForm.Main_Form.NumCurTable - 1)].Cells[2].Value = this.textBox2.Text;
								this.Close();
							}else{
								if(uc.UnicName(MainForm.Main_Form.dataGridView1, 1, textBox1))
								{
									MainForm.Main_Form.dataGridView1.Rows[(MainForm.Main_Form.NumCurTable - 1)].Cells[1].Value = this.textBox1.Text;
									MainForm.Main_Form.dataGridView1.Rows[(MainForm.Main_Form.NumCurTable - 1)].Cells[2].Value = this.textBox2.Text;
									this.Close();
								}
							}
						}else{
							if((this.textBox1.Text.Length == 0)||(this.textBox2.Text.Length == 0))
							{
								MessageBox.Show("Пустое значение!", "Ошибка!",
							                MessageBoxButtons.OK,
							                MessageBoxIcon.Error);
							}
							
						}
						break;
					case "Изменение имени столбца":
						if((this.textBox1.Text.Length > 0)&&(this.textBox2.Text.Length > 0))
						{
							if(MainForm.Main_Form.dataGridView2.Rows[(MainForm.Main_Form.NumCurColumn - 1)].Cells[2].Value.ToString() == this.textBox1.Text)
							{
								MainForm.Main_Form.dataGridView2.Rows[(MainForm.Main_Form.NumCurColumn - 1)].Cells[3].Value = this.textBox2.Text;
								this.Close();
							}else{
								if(uc.UnicName(MainForm.Main_Form.dataGridView2, 2, textBox1))
								{
									MainForm.Main_Form.dataGridView2.Rows[(MainForm.Main_Form.NumCurColumn - 1)].Cells[2].Value = this.textBox1.Text;
									MainForm.Main_Form.dataGridView2.Rows[(MainForm.Main_Form.NumCurColumn - 1)].Cells[3].Value = this.textBox2.Text;
									this.Close();
								}
							}
						}else{
							if((this.textBox1.Text.Length == 0)||(this.textBox2.Text.Length == 0))
							{
								MessageBox.Show("Пустое значение!", "Ошибка!",
							                MessageBoxButtons.OK,
							                MessageBoxIcon.Error);
							}
						}
						break;
				}
				this.textBox2.Text = "";
				this.textBox1.Focus();
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			ic.IdentControl(this.textBox1);
		}
	}
}
