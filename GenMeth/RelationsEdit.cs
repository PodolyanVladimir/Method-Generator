/*
 * Сделано в SharpDevelop.
 * Пользователь: Asus
 * Дата: 26.04.2018
 * Время: 11:33
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using IdentCtrl;
using UnicalCtrl;

namespace GenMeth
{
	/// <summary>
	/// Description of RelationsEdit.
	/// </summary>
	public partial class RelationsEdit : Form
	{
		IdentInputControl icr = new IdentInputControl();
		UnicCtrl ucr = new UnicCtrl();
		
		public RelationsEdit()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		// Метод добавления отношения
		public void AddRel()
		{
			int nRow = RelationsColl.rcoll.dataGridView1.Rows.Add();
			RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[0].Value =
				this.dataGridView1.CurrentRow.Cells[0].Value;
			RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[1].Value =
				this.dataGridView1.CurrentRow.Cells[1].Value;
			RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[2].Value =
				this.dataGridView2.CurrentRow.Cells[0].Value;
			RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[3].Value =
				this.dataGridView2.CurrentRow.Cells[1].Value;
			RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[4].Value =
				this.dataGridView1.CurrentRow.Cells[2].Value;
			RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[5].Value =
				this.dataGridView1.CurrentRow.Cells[3].Value;
			RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[6].Value =
				this.dataGridView1.CurrentRow.Cells[4].Value;
			RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[7].Value =
				this.dataGridView1.CurrentRow.Cells[5].Value;
			RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[8].Value =
				this.dataGridView2.CurrentRow.Cells[2].Value;
			RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[9].Value =
				this.dataGridView2.CurrentRow.Cells[3].Value;
			RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[10].Value =
				this.dataGridView2.CurrentRow.Cells[4].Value;
			RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[11].Value =
				this.dataGridView2.CurrentRow.Cells[5].Value;
			RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[12].Value =
				this.textBox1.Text;
			RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[13].Value =
				this.textBox2.Text;
			RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[14].Value =
				this.textBox3.Text;
			RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[15].Value =
				this.textBox4.Text;
			RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[16].Value =
				this.comboBox1.Text;
			RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[17].Value =
				this.comboBox2.Text;
		}
		
		// Метод изменения отношения
		public void EditRel()
		{
			if(RelationsColl.rcoll.RegEdit == false)
			{
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[0].Value =
					this.dataGridView1.CurrentRow.Cells[0].Value;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[1].Value =
					this.dataGridView1.CurrentRow.Cells[1].Value;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[2].Value =
					this.dataGridView2.CurrentRow.Cells[0].Value;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[3].Value =
					this.dataGridView2.CurrentRow.Cells[1].Value;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[4].Value =
					this.dataGridView1.CurrentRow.Cells[2].Value;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[5].Value =
					this.dataGridView1.CurrentRow.Cells[3].Value;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[6].Value =
					this.dataGridView1.CurrentRow.Cells[4].Value;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[7].Value =
					this.dataGridView1.CurrentRow.Cells[5].Value;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[8].Value =
					this.dataGridView2.CurrentRow.Cells[2].Value;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[9].Value =
					this.dataGridView2.CurrentRow.Cells[3].Value;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[10].Value =
					this.dataGridView2.CurrentRow.Cells[4].Value;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[11].Value =
					this.dataGridView2.CurrentRow.Cells[5].Value;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[12].Value =
					this.textBox1.Text;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[13].Value =
					this.textBox2.Text;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[14].Value =
					this.textBox3.Text;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[15].Value =
					this.textBox4.Text;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[16].Value =
					this.comboBox1.Text;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[17].Value =
					this.comboBox2.Text;
			}else{
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[12].Value =
					this.textBox1.Text;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[13].Value =
					this.textBox2.Text;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[14].Value =
					this.textBox3.Text;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[15].Value =
					this.textBox4.Text;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[16].Value =
					this.comboBox1.Text;
				RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[17].Value =
					this.comboBox2.Text;
			}
		}
		
		void DataGridView1CurrentCellChanged(object sender, EventArgs e)
		{
			try{
				this.label1.Text = "Текущий первичный ключ: " + this.dataGridView1.CurrentRow.Cells[4].Value;
			}catch{
				
			}
		}
		
		void DataGridView2CurrentCellChanged(object sender, EventArgs e)
		{
			try{
				this.label2.Text = "Текущий внешний ключ: " + this.dataGridView2.CurrentRow.Cells[4].Value;
			}catch{
				
			}
		}
		
		// Кнопка "Отменить"
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		// Кнопка "Принять"
		void Button1Click(object sender, EventArgs e)
		{
			if((this.textBox1.Text.Length > 0)&&
			   (this.textBox2.Text.Length > 0)&&
			  (this.textBox3.Text.Length >0)&&
			 (this.textBox4.Text.Length > 0))
			{
				if(RelationsColl.rcoll.RegEdit == false)
				{
					if(ucr.UnicName(RelationsColl.rcoll.dataGridView1, 12, this.textBox1)&&
					   ucr.UnicName(RelationsColl.rcoll.dataGridView1, 14, this.textBox3))
					{
						AddRel();
						this.Close();
					}
				}else{
					if((RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[12].Value.ToString() == this.textBox1.Text)&&
					   (RelationsColl.rcoll.dataGridView1.CurrentRow.Cells[14].Value.ToString() == this.textBox3.Text))
					{
						EditRel();
						this.Close();
					}else{
						if(ucr.UnicName(RelationsColl.rcoll.dataGridView1, 12, this.textBox1)&&
						   ucr.UnicName(RelationsColl.rcoll.dataGridView1, 14, this.textBox3))
						{
							EditRel();
							this.Close();
						}
					}
				}
			}else{
				MessageBox.Show("Не все поля заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			icr.IdentControl(this.textBox1);
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			icr.IdentControl(this.textBox3);
		}
		
		void RelationsEditLoad(object sender, EventArgs e)
		{
			if(RelationsColl.rcoll.RegEdit == true)
			{
				this.dataGridView1.Visible = false;
				this.dataGridView2.Visible = false;
				this.groupBox1.Visible = false;
				this.groupBox2.Visible = false;
			}else{
				this.dataGridView1.Visible = true;
				this.dataGridView2.Visible = true;
				this.groupBox1.Visible = true;
				this.groupBox2.Visible = true;
			}
		}
	}
}
