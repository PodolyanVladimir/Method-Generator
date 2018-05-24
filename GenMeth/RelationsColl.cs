/*
 * Сделано в SharpDevelop.
 * Пользователь: ТМ
 * Дата: 25.04.2018
 * Время: 13:31
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GenMeth
{
	/// <summary>
	/// Description of RelationsColl.
	/// </summary>
	public partial class RelationsColl : Form
	{
		// Флаг режима редактирования
		public bool RegEdit = false;
		public bool EditFl = false;
		public static RelationsColl rcoll; 
		
		public RelationsColl()
		{
			rcoll = this;
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
			if(EditFl == true)
			{
				DialogResult dialogrezult = MessageBox.Show("Сохранить внесённые изменения?",
			                   "Генератор методов",
			                   MessageBoxButtons.YesNoCancel,
			                   MessageBoxIcon.Question);
				if(dialogrezult == DialogResult.Yes)
				{
					MainForm.Main_Form.RecRels();
					this.Close();
				}
			
				if(dialogrezult == DialogResult.No) this.Close();
			}else{
				this.Close();
			}
		}
		
		// Метод проверки полноты коллекции отношений
		public bool FillCollRel()
		{
			bool poln = false;
			int kolsovp = 0;
			for(int i = 0; i < MainForm.Main_Form.my_properties.Length; i++)
			{
				for(int k = 0; k < this.dataGridView1.Rows.Count; k++)
				{
					if(int.Parse(this.dataGridView1.Rows[i].Cells[1].Value.ToString()) == MainForm.Main_Form.my_properties[i].ClmnNum) kolsovp++;
				}
			}
			
			if(kolsovp == this.dataGridView1.Rows.Count)
			{
				poln = true;
			}else{
				poln = false;
			}
			return poln;
		}
		
		// Кнопка добавления отношений
		void ToolStripButton4Click(object sender, EventArgs e)
		{
			int ispol = 0;
			bool sootv = false;

			for(int i = 0; i < MainForm.Main_Form.my_properties.Length; i++)
			{
				if(MainForm.Main_Form.my_properties[i].ClmnFK == true) ispol++;
			}
			
			ispol -= this.dataGridView1.Rows.Count;

			if(ispol == 0)
			{
				MessageBox.Show("Коллекция отношений полная.", "Внимание!",
			                MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}else{
				RelationsEdit re = new RelationsEdit();
				re.dataGridView1.Rows.Clear();
				re.dataGridView2.Rows.Clear();
				for(int i = 0; i < MainForm.Main_Form.my_properties.Length; i++)
				{
					if(MainForm.Main_Form.my_properties[i].ClmnPK == true)
					{
						int nRow = re.dataGridView1.Rows.Add();
						re.dataGridView1.Rows[nRow].Cells[0].Value = 
							 MainForm.Main_Form.my_properties[i].TbNum.ToString();
						re.dataGridView1.Rows[nRow].Cells[1].Value = 
							 MainForm.Main_Form.my_properties[i].ClmnNum .ToString();
						re.dataGridView1.Rows[nRow].Cells[2].Value = 
							 MainForm.Main_Form.my_Tables[MainForm.Main_Form.my_properties[i].TbNum - 1].TbName;
						re.dataGridView1.Rows[nRow].Cells[3].Value = 
							 MainForm.Main_Form.my_Tables[MainForm.Main_Form.my_properties[i].TbNum - 1].TbComment;
						re.dataGridView1.Rows[nRow].Cells[4].Value = 
							 MainForm.Main_Form.my_Columns[MainForm.Main_Form.my_properties[i].ClmnNum - 1].ClmnName;
						re.dataGridView1.Rows[nRow].Cells[5].Value = 
							 MainForm.Main_Form.my_Columns[MainForm.Main_Form.my_properties[i].ClmnNum - 1].ClmnComment;
					}
						
					if(MainForm.Main_Form.my_properties[i].ClmnFK == true)
					{
						if(this.dataGridView1.Rows.Count == 0)
                        {
							int nRow = re.dataGridView2.Rows.Add();
							re.dataGridView2.Rows[nRow].Cells[0].Value = 
								 MainForm.Main_Form.my_properties[i].TbNum.ToString();
							re.dataGridView2.Rows[nRow].Cells[1].Value = 
								 MainForm.Main_Form.my_properties[i].ClmnNum .ToString();
							re.dataGridView2.Rows[nRow].Cells[2].Value = 
								 MainForm.Main_Form.my_Tables[MainForm.Main_Form.my_properties[i].TbNum - 1].TbName;
							re.dataGridView2.Rows[nRow].Cells[3].Value = 
								 MainForm.Main_Form.my_Tables[MainForm.Main_Form.my_properties[i].TbNum - 1].TbComment;
							re.dataGridView2.Rows[nRow].Cells[4].Value = 
								 MainForm.Main_Form.my_Columns[MainForm.Main_Form.my_properties[i].ClmnNum - 1].ClmnName;
							re.dataGridView2.Rows[nRow].Cells[5].Value = 
								 MainForm.Main_Form.my_Columns[MainForm.Main_Form.my_properties[i].ClmnNum - 1].ClmnComment;
						}else{
                            for(int k = 0; k < this.dataGridView1.Rows.Count; k++)
                            {
                                if(this.dataGridView1.Rows[k].Cells[3].Value.ToString() == MainForm.Main_Form.my_properties[i].ClmnNum.ToString())
                                {
                                    sootv = true;
                                    break;
                                }else{
                                    sootv = false;
                                }
                            }
                            if(!sootv)
                            {
                            	int nRow = re.dataGridView2.Rows.Add();
								re.dataGridView2.Rows[nRow].Cells[0].Value = 
									 MainForm.Main_Form.my_properties[i].TbNum.ToString();
								re.dataGridView2.Rows[nRow].Cells[1].Value = 
									 MainForm.Main_Form.my_properties[i].ClmnNum .ToString();
								re.dataGridView2.Rows[nRow].Cells[2].Value = 
									 MainForm.Main_Form.my_Tables[MainForm.Main_Form.my_properties[i].TbNum - 1].TbName;
								re.dataGridView2.Rows[nRow].Cells[3].Value = 
									 MainForm.Main_Form.my_Tables[MainForm.Main_Form.my_properties[i].TbNum - 1].TbComment;
								re.dataGridView2.Rows[nRow].Cells[4].Value = 
									 MainForm.Main_Form.my_Columns[MainForm.Main_Form.my_properties[i].ClmnNum - 1].ClmnName;
								re.dataGridView2.Rows[nRow].Cells[5].Value = 
									 MainForm.Main_Form.my_Columns[MainForm.Main_Form.my_properties[i].ClmnNum - 1].ClmnComment;
							}
						}
					}
				}
				RegEdit = false;
				re.comboBox1.SelectedIndex = 0;
				re.comboBox2.SelectedIndex = 0;
				re.ShowDialog();
			}
		}
		
		// Кнопка редактирования отношений
		void ToolStripButton2Click(object sender, EventArgs e)
		{
			RegEdit = true;
			RelationsEdit re = new RelationsEdit();
			re.label1.Text = "Текущий первичный ключ: " + this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
			re.label2.Text = "Текущий внешний ключ: " + this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
			re.textBox1.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
			re.textBox2.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
			re.textBox3.Text = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
			re.textBox4.Text = this.dataGridView1.CurrentRow.Cells[15].Value.ToString();
			re.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
			re.comboBox2.Text = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
			re.ShowDialog();
		}
		
		// Кнопка удаления отношения
		void ToolStripButton3Click(object sender, EventArgs e)
		{
			this.dataGridView1.Rows.Remove(this.dataGridView1.CurrentRow);
			RegEdit = false;
		}
		
		void RelationsCollLoad(object sender, EventArgs e)
		{
			EditFl = false;
		}
		
		void DataGridView1CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			EditFl = true;
		}
	}
}
