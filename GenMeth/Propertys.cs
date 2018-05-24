/*
 * Сделано в SharpDevelop.
 * Пользователь: ТМ
 * Дата: 02.04.2018
 * Время: 13:43
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GenMeth
{
	/// <summary>
	/// Description of Propertys.
	/// </summary>
	public partial class Propertys : Form
	{
		public static Propertys pk;		// Ссылка на данную форму
		public bool EditFlag = false;	// флаг внесения изменений
		public bool Rejim = false;
		
		public Propertys()
		{
			pk = this;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			if(EditFlag == true)
			{
				DialogResult dialogrezult = MessageBox.Show("Сохранить внесённые изменения?",
			                   "Генератор методов",
			                   MessageBoxButtons.YesNoCancel,
			                   MessageBoxIcon.Question);
				if(dialogrezult == DialogResult.Yes)
				{
					MainForm.Main_Form.WriteProp();
					this.Close();
				}
			
				if(dialogrezult == DialogResult.No) this.Close();
			}else{
				this.Close();
			}
			
		}
		
		void DataGridView1CurrentCellChanged(object sender, EventArgs e)
		{
			try{
				this.toolStripStatusLabel1.Text = "Текущая таблица: " +
					this.dataGridView1.CurrentRow.Cells[0].Value + ".";
				this.toolStripStatusLabel2.Text = "Текущий столбец: " +
					this.dataGridView1.CurrentRow.Cells[1].Value + ".";
			}catch{
				
			}
		}
		
		void PropertysLoad(object sender, EventArgs e)
		{
			if(MainForm.Main_Form.toolStripButton10.Checked == true)
			{
				this.dataGridView1.Columns[8].Visible = false;
				this.dataGridView1.Columns[9].Visible = false;
			}else{
				this.dataGridView1.Columns[8].Visible = true;
				this.dataGridView1.Columns[9].Visible = true;
			}
			EditFlag = false;
		}
		
		void ToolStripButton2Click(object sender, EventArgs e)
		{
			PropertyEdit pe = new PropertyEdit();
			pe.label1.Text = "Текущая таблица: " +
				this.dataGridView1.CurrentRow.Cells[0].Value + ".";
			pe.label2.Text = "Текущий столбец: " +
				this.dataGridView1.CurrentRow.Cells[1].Value + ".";
			Rejim = false;
			pe.ShowDialog();
		}
		
		void DataGridView1CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			EditFlag = true;
			MainForm.Main_Form.Edited = true;
		}
		
		void ПервичныйКлючToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(MainForm.Main_Form.toolStripButton10.Checked == true)
			{
				this.dataGridView1.CurrentRow.Cells[3].Value = true;
				this.dataGridView1.CurrentRow.Cells[4].Value = false;
				this.dataGridView1.CurrentRow.Cells[5].Value = false;
				this.dataGridView1.CurrentRow.Cells[6].Value = "Guid";
				this.dataGridView1.CurrentRow.Cells[7].Value = "0";
				this.dataGridView1.CurrentRow.Cells[8].Value = "0";
				this.dataGridView1.CurrentRow.Cells[9].Value = "0";
				this.dataGridView1.CurrentRow.Cells[10].Value = "";
			}
			
			// Первичный ключ типа Autoincrement
			if(MainForm.Main_Form.toolStripButton11.Checked == true)
			{
				PropertyEdit pe = new PropertyEdit();
					pe.label1.Text = "Текущая таблица: " +
					this.dataGridView1.CurrentRow.Cells[0].Value + ".";
				pe.label2.Text = "Текущий столбец: " +
					this.dataGridView1.CurrentRow.Cells[1].Value + ".";
				Rejim = true;
				pe.PK = true;
				pe.FK = false;
				pe.CD = false;
				pe.tabControl1.SelectedIndex = 1;
				pe.ShowDialog();
			}
		}
		
		void ВнешнийКлючToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(MainForm.Main_Form.toolStripButton10.Checked == true)
			{
				this.dataGridView1.CurrentRow.Cells[3].Value = false;
				this.dataGridView1.CurrentRow.Cells[4].Value = true;
				this.dataGridView1.CurrentRow.Cells[5].Value = false;
				this.dataGridView1.CurrentRow.Cells[6].Value = "Guid";
				this.dataGridView1.CurrentRow.Cells[7].Value = "0";
				this.dataGridView1.CurrentRow.Cells[8].Value = "0";
				this.dataGridView1.CurrentRow.Cells[9].Value = "0";
				this.dataGridView1.CurrentRow.Cells[10].Value = "";
			}
			
			if(MainForm.Main_Form.toolStripButton11.Checked == true)
			{
				this.dataGridView1.CurrentRow.Cells[3].Value = false;
				this.dataGridView1.CurrentRow.Cells[4].Value = true;
				this.dataGridView1.CurrentRow.Cells[5].Value = false;
				this.dataGridView1.CurrentRow.Cells[6].Value = "Int32";
				this.dataGridView1.CurrentRow.Cells[7].Value = "0";
				this.dataGridView1.CurrentRow.Cells[8].Value = "0";
				this.dataGridView1.CurrentRow.Cells[9].Value = "0";
				this.dataGridView1.CurrentRow.Cells[10].Value = "";
			}
		}
		
		void СтолбецДанныхToolStripMenuItemClick(object sender, EventArgs e)
		{
			PropertyEdit pe = new PropertyEdit();
					pe.label1.Text = "Текущая таблица: " +
					this.dataGridView1.CurrentRow.Cells[0].Value + ".";
				pe.label2.Text = "Текущий столбец: " +
					this.dataGridView1.CurrentRow.Cells[1].Value + ".";
				Rejim = true;
				pe.PK = false;
				pe.FK = false;
				pe.CD = true;
				pe.tabControl1.SelectedIndex = 2;
				pe.comboBox1.SelectedIndex = 0;
				pe.ShowDialog();
		}
		
		void ВыйтиИзРедактораСвойствToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(EditFlag == true)
			{
				DialogResult dialogrezult = MessageBox.Show("Сохранить внесённые изменения?",
			                   "Генератор методов",
			                   MessageBoxButtons.YesNoCancel,
			                   MessageBoxIcon.Question);
				if(dialogrezult == DialogResult.Yes)
				{
					MainForm.Main_Form.WriteProp();
					this.Close();
				}
			
				if(dialogrezult == DialogResult.No) this.Close();
			}else{
				this.Close();
			}
		}
	}
}
