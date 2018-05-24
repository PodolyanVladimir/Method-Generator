/*
 * Сделано в SharpDevelop.
 * Пользователь: Asus
 * Дата: 30.03.2018
 * Время: 9:32
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GenMeth
{
	/// <summary>
	/// Description of PropertyEdit.
	/// </summary>
	public partial class PropertyEdit : Form
	{
		public bool PK = false;
		public bool FK = false;
		public bool CD = false;
		
		public PropertyEdit()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			// Столбец данных
			if(CD == true)
			{
				Propertys.pk.dataGridView1.CurrentRow.Cells[3].Value = false;
				Propertys.pk.dataGridView1.CurrentRow.Cells[4].Value = false;
				Propertys.pk.dataGridView1.CurrentRow.Cells[5].Value = true;
				Propertys.pk.dataGridView1.CurrentRow.Cells[6].Value = this.comboBox1.Text;
				if(this.comboBox1.SelectedIndex == 0)
				{
					Propertys.pk.dataGridView1.CurrentRow.Cells[7].Value = this.numericUpDown3.Value.ToString();
				}else{
					Propertys.pk.dataGridView1.CurrentRow.Cells[7].Value = "0";
				}
				
				Propertys.pk.dataGridView1.CurrentRow.Cells[8].Value = "0";
				Propertys.pk.dataGridView1.CurrentRow.Cells[9].Value = "0";
				Propertys.pk.dataGridView1.CurrentRow.Cells[10].Value = this.textBox4.Text;
			}
			
			// Первичный ключ типа Guid
			if((PK == true)&&(MainForm.Main_Form.toolStripButton10.Checked == true))
			{
				Propertys.pk.dataGridView1.CurrentRow.Cells[3].Value = true;
				Propertys.pk.dataGridView1.CurrentRow.Cells[4].Value = false;
				Propertys.pk.dataGridView1.CurrentRow.Cells[5].Value = false;
				Propertys.pk.dataGridView1.CurrentRow.Cells[6].Value = "Guid";
				Propertys.pk.dataGridView1.CurrentRow.Cells[7].Value = "0";
				Propertys.pk.dataGridView1.CurrentRow.Cells[8].Value = "0";
				Propertys.pk.dataGridView1.CurrentRow.Cells[9].Value = "0";
				Propertys.pk.dataGridView1.CurrentRow.Cells[10].Value = "";
			}
			
			// Первичный ключ типа Autoincrement
			if((PK == true)&&(MainForm.Main_Form.toolStripButton11.Checked == true))
			{
				Propertys.pk.dataGridView1.CurrentRow.Cells[3].Value = true;
				Propertys.pk.dataGridView1.CurrentRow.Cells[4].Value = false;
				Propertys.pk.dataGridView1.CurrentRow.Cells[5].Value = false;
				Propertys.pk.dataGridView1.CurrentRow.Cells[6].Value = "Int32";
				Propertys.pk.dataGridView1.CurrentRow.Cells[7].Value = "0";
				Propertys.pk.dataGridView1.CurrentRow.Cells[8].Value = this.numericUpDown1.Value.ToString();
				Propertys.pk.dataGridView1.CurrentRow.Cells[9].Value = this.numericUpDown2.Value.ToString();
				Propertys.pk.dataGridView1.CurrentRow.Cells[10].Value = "";
			}
			
			// Внешний ключ
			if(FK == true)
			{
				Propertys.pk.dataGridView1.CurrentRow.Cells[3].Value = false;
				Propertys.pk.dataGridView1.CurrentRow.Cells[4].Value = true;
				Propertys.pk.dataGridView1.CurrentRow.Cells[5].Value = false;
				Propertys.pk.dataGridView1.CurrentRow.Cells[7].Value = "0";
				
				Propertys.pk.dataGridView1.CurrentRow.Cells[10].Value = "";
				if(MainForm.Main_Form.toolStripButton10.Checked == true)
				{
					Propertys.pk.dataGridView1.CurrentRow.Cells[6].Value = "Guid";
					Propertys.pk.dataGridView1.CurrentRow.Cells[8].Value = "0";
					Propertys.pk.dataGridView1.CurrentRow.Cells[9].Value = "0";
				}
				if(MainForm.Main_Form.toolStripButton11.Checked == true)
				{
					Propertys.pk.dataGridView1.CurrentRow.Cells[6].Value = "Int32";
					Propertys.pk.dataGridView1.CurrentRow.Cells[8].Value = this.numericUpDown1.Value.ToString();
					Propertys.pk.dataGridView1.CurrentRow.Cells[9].Value = this.numericUpDown2.Value.ToString();
				}
			}
			this.Close();
		}
		
		void PropertyEditLoad(object sender, EventArgs e)
		{
			if(Propertys.pk.Rejim == false)
			{
				this.numericUpDown1.Value = 0;
				this.numericUpDown2.Value = 1;
				this.numericUpDown3.Value = 25;
				this.textBox4.Text = "";
				this.button2.Visible = false;
				this.radioButton1.Checked = false;
				this.radioButton2.Checked = false;
				this.radioButton3.Checked = false;
				this.comboBox1.SelectedIndex = 0;
				this.tabControl1.SelectedIndex = 0;
				PK = false;
			}
		}
		
		void RadioButton1Click(object sender, EventArgs e)
		{
			this.tabControl1.SelectedIndex = 2;
			this.button2.Visible = true;
			PK = false;
			FK = false;
			CD = true;
		}
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			if(MainForm.Main_Form.toolStripButton10.Checked == true) this.button2.Visible = true;
			if(MainForm.Main_Form.toolStripButton11.Checked == true)
			{
				this.tabControl1.SelectedIndex = 1;
				this.button2.Visible = true;
			}
			PK = true;
			FK = false;
			CD = false;
		}
		
		void RadioButton3CheckedChanged(object sender, EventArgs e)
		{
			this.button2.Visible = true;
			PK = false;
			FK = true;
			CD = false;
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			if(this.comboBox1.SelectedIndex == 0)
			{
				this.numericUpDown3.Visible = true;
				this.label8.Visible = true;
			}else{
				this.numericUpDown3.Visible = false;
				this.label8.Visible = false;
			}
		}
	}
}
