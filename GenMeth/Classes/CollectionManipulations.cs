/*
 * Сделано в SharpDevelop.
 * Пользователь: Asus
 * Дата: 22.05.2018
 * Время: 23:32
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using IdentCtrl;
using GenMeth;

namespace GenMeth.Classes
{
	/// <summary>
	/// Description of CollectionManipulations.
	/// </summary>
	public class CollectionManipulations: MainForm
	{
		
		IdentInputControl ict = new IdentInputControl();
		
		public Tbls[] my_coll_Tables;			// Массив структур таблиц
		public Clmns[] my_coll_Columns;			// Массив структур столбцов
		public ClmnProp[] my_coll_properties;		// Массив структур свойств
		public ClmnProp[] P_coll_rez;	// Резервный массив структур свойств
		public Rels[] my_coll_Relations;			// Массив структур отношений
		public Rels[] R_coll_rez;		// Резервный массив структур отношений
		
		
						// --------------Метод создания нового решения-------------- \\
		//IdentInputControl ict = new IdentInputControl();		
				
		public void NewCollection()
		{
			if(Main_Form.Edited == true)
			{
				DialogResult dr = MessageBox.Show("Сохранить внесённые изменения?",
				                                  "Генератор методов",
				                                  MessageBoxButtons.YesNoCancel,
				                                  MessageBoxIcon.Question,
				                                  MessageBoxDefaultButton.Button1);
				if(dr == DialogResult.Yes)
				{
					if(Main_Form.CurrentFileName.Length > 0)
					{
						SaveCollection();
					}else{
						SaveCollectionDlg();
					}
					Main_Form.dataGridView1.Rows.Clear();
					Main_Form.dataGridView2.Rows.Clear();
					Main_Form.toolStripButton10.Checked = true;
					Main_Form.toolStripButton11.Checked = false;
					Main_Form.toolStripTextBox1.Text = "dataSet1";
					Main_Form.toolStripTextBox2.Text = "CreateDataSet";
					Main_Form.Edited = false;
					Main_Form.CurrentFileName = "";
					Main_Form.toolStripStatusLabel3.Text = "Редактор коллекции имён. ";
					if(Main_Form.my_Tables != null)
					{
						Main_Form.my_Tables = new Tbls[0];
					}
					if(Main_Form.my_Columns != null)
					{
						Main_Form.my_Columns = new Clmns[0];
					}
					if(Main_Form.my_properties != null)
					{
						Main_Form.my_properties = new ClmnProp[0];
					}
					if(Main_Form.P_rez != null)
					{
						Main_Form.P_rez = new ClmnProp[0];
					}
					if(Main_Form.my_Relations != null)
					{
						Main_Form.my_Relations = new Rels[0];
					}
					if(Main_Form.R_rez != null)
					{
						Main_Form.R_rez = new Rels[0];
					}
				}
				
				if(dr == DialogResult.No)
				{
					Main_Form.dataGridView1.Rows.Clear();
					Main_Form.dataGridView2.Rows.Clear();
					Main_Form.toolStripButton10.Checked = true;
					Main_Form.toolStripButton11.Checked = false;
					Main_Form.toolStripTextBox1.Text = "dataSet1";
					Main_Form.toolStripTextBox2.Text = "CreateDataSet";
					Main_Form.Edited = false;
					Main_Form.CurrentFileName = "";
					Main_Form.toolStripStatusLabel3.Text = "Редактор коллекции имён. ";
				}
				
			}else{
				Main_Form.dataGridView1.Rows.Clear();
				Main_Form.dataGridView2.Rows.Clear();
				Main_Form.toolStripButton10.Checked = true;
				Main_Form.toolStripButton11.Checked = false;
				Main_Form.toolStripTextBox1.Text = "dataSet1";
				Main_Form.toolStripTextBox2.Text = "CreateDataSet";
				Main_Form.Edited = false;
				Main_Form.CurrentFileName = "";
				Main_Form.toolStripStatusLabel3.Text = "Редактор коллекции имён. ";
			}
		}
		
		
				// --------------Метод открытия коллекций-------------- \\
		
		
		public void OpenCollection()
		{
			Main_Form.saveFileDialog1.InitialDirectory = System.IO.Path.Combine(Application.StartupPath, @"Решения");
			if((openFileDialog1.ShowDialog() == DialogResult.OK)&&
			   (openFileDialog1.FileName.Length > 0))
			{
				Main_Form.CurrentFileName = openFileDialog1.FileName;
				Main_Form.toolStripStatusLabel3.Text = "Редактор коллекции имён. " + Main_Form.CurrentFileName;
				Main_Form.dataGridView1.Rows.Clear();
				Main_Form.dataGridView2.Rows.Clear();
				
				FileStream fin = new FileStream(openFileDialog1.FileName, FileMode.Open);
				StreamReader sr = new StreamReader(fin);
				
				// Читаю технологию индексации ключей
				string teh = sr.ReadLine();
				// Меняю состояние интерфейса
				if(teh == "Guid")
				{
					Main_Form.toolStripButton10.Checked = true;
					Main_Form.toolStripButton11.Checked = false;
				}
				if(teh == "Ai")
				{
					Main_Form.toolStripButton10.Checked = false;
					Main_Form.toolStripButton11.Checked = true;
				}
				
				// Читаю имя объекта класса DataSet
				Main_Form.toolStripTextBox1.Text = sr.ReadLine();
				
				// Читаю имя метода
				Main_Form.toolStripTextBox2.Text = sr.ReadLine();
				
				// Читаю размеры коллекций
				int tab = int.Parse(sr.ReadLine());
				int clm = int.Parse(sr.ReadLine());
				int prp = int.Parse(sr.ReadLine());
				int rel = int.Parse(sr.ReadLine());
				
				if(tab > 0)
				{
					Main_Form.my_Tables = new Tbls[tab];
					for(int i = 0; i < tab; i++)
					{
						Main_Form.my_Tables[i] = new Tbls(int.Parse(sr.ReadLine()),
						                sr.ReadLine(),
						                sr.ReadLine()
						               );
					}
					ReadTables();
				}
				
				if(clm > 0)
				{
					Main_Form.my_Columns = new Clmns[clm];
					for(int i = 0; i < clm; i++)
					{
						Main_Form.my_Columns[i] = new Clmns(int.Parse(sr.ReadLine()),
						                 int.Parse(sr.ReadLine()),
						                 sr.ReadLine(),
						                 sr.ReadLine()
						                );
					}
					ReadColumns();
				}
				
				if(prp > 0)
				{
					Main_Form.my_properties = new ClmnProp[prp];
					for(int i = 0; i < prp; i++)
					{
						Main_Form.my_properties[i] = new ClmnProp(int.Parse(sr.ReadLine()),
						                    int.Parse(sr.ReadLine()),
						                    sr.ReadLine(),
						                    sr.ReadLine(),
						                    bool.Parse(sr.ReadLine()),
						                    bool.Parse(sr.ReadLine()),
						                    bool.Parse(sr.ReadLine()),
						                    int.Parse(sr.ReadLine()),
						                    int.Parse(sr.ReadLine()),
						                    int.Parse(sr.ReadLine()),
						                    sr.ReadLine()
						                   );
					}
					
					Main_Form.P_rez = new ClmnProp[prp];
					for(int i = 0; i < prp; i++)
					{
						Main_Form.P_rez[i] = new ClmnProp(Main_Form.my_properties[i].TbNum,
				                        Main_Form.my_properties[i].ClmnNum,
				                        Main_Form.my_properties[i].ClmnCaption,
				                        Main_Form.my_properties[i].ClmnType,
				                        Main_Form.my_properties[i].ClmnPK,
				                        Main_Form.my_properties[i].ClmnFK,
				                        Main_Form.my_properties[i].ClmnDT,
				                        Main_Form.my_properties[i].ClmnLen,
				                        Main_Form.my_properties[i].AiStart,
				                        Main_Form.my_properties[i].AiStep,
				                        Main_Form.my_properties[i].ClmnExpr
				                       );
					}
					
				}
				
				if(rel > 0)
				{
					Main_Form.my_Relations = new Rels[rel];
					for(int i = 0; i < rel; i++)
					{
						Main_Form.my_Relations[i] = new Rels(int.Parse(sr.ReadLine()),
						                sr.ReadLine(),
						                sr.ReadLine(),
						                int.Parse(sr.ReadLine()),
						                sr.ReadLine(),
						                sr.ReadLine(),
						                int.Parse(sr.ReadLine()),
						                sr.ReadLine(),
						                sr.ReadLine(),
						                int.Parse(sr.ReadLine()),
						                sr.ReadLine(),
						                sr.ReadLine(),
						                sr.ReadLine(),
						                sr.ReadLine(),
						                sr.ReadLine(),
						                sr.ReadLine(),
						                sr.ReadLine(),
						                sr.ReadLine()
										);
					}
					
					Main_Form.R_rez = new Rels[rel];
					for(int i = 0; i < rel; i++)
					{
						Main_Form.R_rez[i] = new Rels(
											Main_Form.my_Relations[i].TabNumP,
											Main_Form.my_Relations[i].TabNameP,
											Main_Form.my_Relations[i].TabPsP,
											Main_Form.my_Relations[i].ClmnNumP,
											Main_Form.my_Relations[i].ClmnNameP,
											Main_Form.my_Relations[i].ClmnPsP,
											Main_Form.my_Relations[i].TabNumC,
											Main_Form.my_Relations[i].TabNameC,
											Main_Form.my_Relations[i].TabPsC,
											Main_Form.my_Relations[i].ClmnNumC,
											Main_Form.my_Relations[i].ClmnNameC,
											Main_Form.my_Relations[i].ClmnPsC,
											Main_Form.my_Relations[i].DrName,
											Main_Form.my_Relations[i].DrPs,
											Main_Form.my_Relations[i].ConstrName,
											Main_Form.my_Relations[i].ConstrPs,
											Main_Form.my_Relations[i].DelRule,
											Main_Form.my_Relations[i].UpdRule
											);
					}
				}
				
				Edited = false;
				sr.Close();
			}
		}
		
		// Метод чтения имён таблиц из структуры T
		public void ReadTables()
		{
			Main_Form.dataGridView1.Rows.Clear();
			for(int i = 0; i < Main_Form.my_Tables.Length; i++)
			{
				Main_Form.dataGridView1.Rows.Add();
				Main_Form.dataGridView1.Rows[i].Cells[0].Value = Main_Form.my_Tables[i].TbNum.ToString();
				Main_Form.dataGridView1.Rows[i].Cells[1].Value = Main_Form.my_Tables[i].TbName;
				Main_Form.dataGridView1.Rows[i].Cells[2].Value = Main_Form.my_Tables[i].TbComment;
			}
		}
		
		// Метод чтения имён столбцов из структуры C
		public void ReadColumns()
		{
			Main_Form.dataGridView2.Rows.Clear();
			for(int i = 0; i < Main_Form.my_Columns.Length; i++)
			{
				Main_Form.dataGridView2.Rows.Add();
				Main_Form.dataGridView2.Rows[i].Cells[0].Value = Main_Form.my_Columns[i].TbNum.ToString();
				Main_Form.dataGridView2.Rows[i].Cells[1].Value = Main_Form.my_Columns[i].ClmnNum.ToString();
				Main_Form.dataGridView2.Rows[i].Cells[2].Value = Main_Form.my_Columns[i].ClmnName;
				Main_Form.dataGridView2.Rows[i].Cells[3].Value = Main_Form.my_Columns[i].ClmnComment;
			}
		}
		
						// --------------Метод сохранения коллекций-------------- \\


		public void SaveCollectionDlg()
		{
			Main_Form.saveFileDialog1.InitialDirectory = System.IO.Path.Combine(Application.StartupPath, @"Решения");
			if((saveFileDialog1.ShowDialog() == DialogResult.OK)&&
			   (saveFileDialog1.FileName.Length > 0))
			{
				Main_Form.CurrentFileName = saveFileDialog1.FileName;
				Main_Form.toolStripStatusLabel3.Text = "Редактор коллекции имён. " + Main_Form.CurrentFileName;
				FileStream fout = new FileStream(saveFileDialog1.FileName, FileMode.Create);
				StreamWriter sw = new StreamWriter(fout);
				
				// Обозначаю технологию индексации ключей
				if(Main_Form.toolStripButton10.Checked == true)
				{
					sw.WriteLine("Guid");
				}else{
					sw.WriteLine("Ai");
				}
				
				// Записываю имя объекта класса DataSet
				sw.WriteLine(Main_Form.toolStripTextBox1.Text);
				// Записываю имя метода
				sw.WriteLine(Main_Form.toolStripTextBox2.Text);
				
				// Записываю размеры массивов структур
				if(Main_Form.my_Tables != null)
				{
					sw.WriteLine(Main_Form.my_Tables.Length);
				}else{
					sw.WriteLine("0");
				}
				if(Main_Form.my_Columns != null)
				{
					sw.WriteLine(Main_Form.my_Columns.Length);
				}else{
					sw.WriteLine("0");
				}
				if(Main_Form.my_properties != null)
				{
					sw.WriteLine(Main_Form.my_properties.Length);
				}else{
					sw.WriteLine("0");
				}
				
				if(Main_Form.my_Relations != null)
				{
					sw.WriteLine(Main_Form.my_Relations.Length);
				}else{
					sw.WriteLine("0");
				}
				
				// Записываю коллекцию имён таблиц
				if(Main_Form.my_Tables != null)
				{
					for(int i = 0; i < Main_Form.my_Tables.Length; i++)
					{
						sw.WriteLine(Main_Form.my_Tables[i].TbNum);
						sw.WriteLine(Main_Form.my_Tables[i].TbName);
						sw.WriteLine(Main_Form.my_Tables[i].TbComment);
					}
				}
				
				// Записываю коллекцию имён столбцов
				if(Main_Form.my_Columns != null)
				{
					for(int i = 0; i < Main_Form.my_Columns.Length; i++)
					{
						sw.WriteLine(Main_Form.my_Columns[i].TbNum);
						sw.WriteLine(Main_Form.my_Columns[i].ClmnNum);
						sw.WriteLine(Main_Form.my_Columns[i].ClmnName);
						sw.WriteLine(Main_Form.my_Columns[i].ClmnComment);
					}
				}
				
				// Записываю коллекцию свойств
				if(Main_Form.my_properties != null)
				{
					for(int i = 0; i < Main_Form.my_properties.Length; i++)
					{
						sw.WriteLine(Main_Form.my_properties[i].TbNum);
						sw.WriteLine(Main_Form.my_properties[i].ClmnNum);
						sw.WriteLine(Main_Form.my_properties[i].ClmnCaption);
						sw.WriteLine(Main_Form.my_properties[i].ClmnType);
						sw.WriteLine(Main_Form.my_properties[i].ClmnPK);
						sw.WriteLine(Main_Form.my_properties[i].ClmnFK);
						sw.WriteLine(Main_Form.my_properties[i].ClmnDT);
						sw.WriteLine(Main_Form.my_properties[i].ClmnLen);
						sw.WriteLine(Main_Form.my_properties[i].AiStart);
						sw.WriteLine(Main_Form.my_properties[i].AiStep);
						sw.WriteLine(Main_Form.my_properties[i].ClmnExpr);
					}
				}
				
				// Записываю коллекцию отношений
			if(Main_Form.my_Relations != null)
			{
				for(int i = 0; i < Main_Form.my_Relations.Length; i++)
				{
					sw.WriteLine(Main_Form.my_Relations[i].TabNumP);
					sw.WriteLine(Main_Form.my_Relations[i].TabNameP);
					sw.WriteLine(Main_Form.my_Relations[i].TabPsP);
					sw.WriteLine(Main_Form.my_Relations[i].ClmnNumP);
					sw.WriteLine(Main_Form.my_Relations[i].ClmnNameP);
					sw.WriteLine(Main_Form.my_Relations[i].ClmnPsP);
					sw.WriteLine(Main_Form.my_Relations[i].TabNumC);
					sw.WriteLine(Main_Form.my_Relations[i].TabNameC);
					sw.WriteLine(Main_Form.my_Relations[i].TabPsC);
					sw.WriteLine(Main_Form.my_Relations[i].ClmnNumC);
					sw.WriteLine(Main_Form.my_Relations[i].ClmnNameC);
					sw.WriteLine(Main_Form.my_Relations[i].ClmnPsC);
					sw.WriteLine(Main_Form.my_Relations[i].DrName);
					sw.WriteLine(Main_Form.my_Relations[i].DrPs);
					sw.WriteLine(Main_Form.my_Relations[i].ConstrName);
					sw.WriteLine(Main_Form.my_Relations[i].ConstrPs);
					sw.WriteLine(Main_Form.my_Relations[i].DelRule);
					sw.WriteLine(Main_Form.my_Relations[i].UpdRule);
				}
			}
				
				Main_Form.Edited = false;
				sw.Close();
			}
		}
		
		
						// --------------Метод сохранения без диалогового окна-------------- \\
		
		
		public void SaveCollection()
		{
			Main_Form.toolStripStatusLabel3.Text = "Редактор коллекции имён. " + Main_Form.CurrentFileName;
			FileStream fout = new FileStream(Main_Form.CurrentFileName, FileMode.Create);
			StreamWriter sw = new StreamWriter(fout);
			
			// Обозначаю технологию индексации ключей
			if(Main_Form.toolStripButton10.Checked == true)
			{
				sw.WriteLine("Guid");
			}else{
				sw.WriteLine("Ai");
			}
			
			// Записываю имя объекта класса DataSet
			sw.WriteLine(Main_Form.toolStripTextBox1.Text);
			// Записываю имя метода
			sw.WriteLine(Main_Form.toolStripTextBox2.Text);
			
			// Записываю размеры массивов структур
			if(Main_Form.my_Tables != null)
			{
				sw.WriteLine(Main_Form.my_Tables.Length);
			}else{
				sw.WriteLine("0");
			}
			if(Main_Form.my_Columns != null)
			{
				sw.WriteLine(Main_Form.my_Columns.Length);
			}else{
				sw.WriteLine("0");
			}
			if(Main_Form.my_properties != null)
			{
				sw.WriteLine(Main_Form.my_properties.Length);
			}else{
				sw.WriteLine("0");
			}
			if(Main_Form.my_Relations != null)
			{
				sw.WriteLine(Main_Form.my_Relations.Length);
			}else{
				sw.WriteLine("0");
			}
			
			// Записываю коллекцию имён таблиц
			if(Main_Form.my_Tables != null)
			{
				for(int i = 0; i < Main_Form.my_Tables.Length; i++)
				{
					sw.WriteLine(Main_Form.my_Tables[i].TbNum);
					sw.WriteLine(Main_Form.my_Tables[i].TbName);
					sw.WriteLine(Main_Form.my_Tables[i].TbComment);
				}
			}
			
			// Записываю коллекцию имён столбцов
			if(Main_Form.my_Columns != null)
			{
				for(int i = 0; i < Main_Form.my_Columns.Length; i++)
				{
					sw.WriteLine(Main_Form.my_Columns[i].TbNum);
					sw.WriteLine(Main_Form.my_Columns[i].ClmnNum);
					sw.WriteLine(Main_Form.my_Columns[i].ClmnName);
					sw.WriteLine(Main_Form.my_Columns[i].ClmnComment);
				}
			}
			
			// Записываю коллекцию свойств
			if(Main_Form.my_properties != null)
			{
				for(int i = 0; i < Main_Form.my_properties.Length; i++)
				{
					sw.WriteLine(Main_Form.my_properties[i].TbNum);
					sw.WriteLine(Main_Form.my_properties[i].ClmnNum);
					sw.WriteLine(Main_Form.my_properties[i].ClmnCaption);
					sw.WriteLine(Main_Form.my_properties[i].ClmnType);
					sw.WriteLine(Main_Form.my_properties[i].ClmnPK);
					sw.WriteLine(Main_Form.my_properties[i].ClmnFK);
					sw.WriteLine(Main_Form.my_properties[i].ClmnDT);
					sw.WriteLine(Main_Form.my_properties[i].ClmnLen);
					sw.WriteLine(Main_Form.my_properties[i].AiStart);
					sw.WriteLine(Main_Form.my_properties[i].AiStep);
					sw.WriteLine(Main_Form.my_properties[i].ClmnExpr);
				}
			}
			
			// Записываю коллекцию отношений
			if(Main_Form.my_Relations != null)
			{
				for(int i = 0; i < Main_Form.my_Relations.Length; i++)
				{
					sw.WriteLine(Main_Form.my_Relations[i].TabNumP);
					sw.WriteLine(Main_Form.my_Relations[i].TabNameP);
					sw.WriteLine(Main_Form.my_Relations[i].TabPsP);
					sw.WriteLine(Main_Form.my_Relations[i].ClmnNumP);
					sw.WriteLine(Main_Form.my_Relations[i].ClmnNameP);
					sw.WriteLine(Main_Form.my_Relations[i].ClmnPsP);
					sw.WriteLine(Main_Form.my_Relations[i].TabNumC);
					sw.WriteLine(Main_Form.my_Relations[i].TabNameC);
					sw.WriteLine(Main_Form.my_Relations[i].TabPsC);
					sw.WriteLine(Main_Form.my_Relations[i].ClmnNumC);
					sw.WriteLine(Main_Form.my_Relations[i].ClmnNameC);
					sw.WriteLine(Main_Form.my_Relations[i].ClmnPsC);
					sw.WriteLine(Main_Form.my_Relations[i].DrName);
					sw.WriteLine(Main_Form.my_Relations[i].DrPs);
					sw.WriteLine(Main_Form.my_Relations[i].ConstrName);
					sw.WriteLine(Main_Form.my_Relations[i].ConstrPs);
					sw.WriteLine(Main_Form.my_Relations[i].DelRule);
					sw.WriteLine(Main_Form.my_Relations[i].UpdRule);
				}
			}
			
			Main_Form.Edited = false;
			sw.Close();

		}
	}
}
