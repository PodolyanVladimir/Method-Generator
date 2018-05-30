/*
 * Сделано в SharpDevelop.
 * Пользователь: Asus
 * Дата: 31.01.2018
 * Время: 1:53
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using IdentCtrl;
using GenMeth.Classes;

namespace GenMeth
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		// рефакторинг start
		static GeneratorClass Generator_Class = new GeneratorClass();
		static CollectionManipulations Collection_Class = new CollectionManipulations();
		public static CollectionManipulations Collection_Data;
		// рефакторинг stop
		
		static Dialog df = new Dialog();	// Объект диалога ввода
		static NamesEdit ne = new NamesEdit(); // Объект диалога изменения имён метода и объекта класса DataSet
		public static MainForm Main_Form;			// Ссылка на главную форму
		public string CurTable = "";		// Имя текущей таблицы
		public int NumCurTable;				// Номер текущей таблицы
		public string CurColumn = "";		// Имя текущего столбца
		public int NumCurColumn;			// Номер текущего столбца
		public int KolTables;				// Количество имён таблиц
		public int KolColumns;				// Количество имён столбцов
		public int NomTable;				// Постфикс имени таблицы
		public int NomColumn;				// Постфикс имени столбца
		public string CurrentFileName = ""; // Имя текущего файла
		public bool Edited = false;			// Флаг редактирования
		public bool FromMenuExit = false;	// Флаг выхода через меню
		

		IdentInputControl ict = new IdentInputControl();
		
		public Tbls[] my_Tables;			// Массив структур таблиц
		public Clmns[] my_Columns;			// Массив структур столбцов
		public ClmnProp[] my_properties;		// Массив структур свойств
		public ClmnProp[] P_rez;	// Резервный массив структур свойств
		public Rels[] my_Relations;			// Массив структур отношений
		public Rels[] R_rez;		// Резервный массив структур отношений

		public MainForm()
		{
			Main_Form = this;			// Инициализация ссылки на главную форму
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		// Метод записи имён таблиц в структуру T
		public void RecTables()
		{
				my_Tables = new Tbls[this.dataGridView1.RowCount];
				for(int i = 0; i < this.dataGridView1.RowCount; i++)
				{
					my_Tables[i] = new Tbls(int.Parse(this.dataGridView1.Rows[i].Cells[0].Value.ToString()),
				                this.dataGridView1.Rows[i].Cells[1].Value.ToString(),
				                this.dataGridView1.Rows[i].Cells[2].Value.ToString()
				               );
				}
		}
		
		
		
		// Метод записи имён столбцов в структуру C
		public void RecColumns()
		{
			// Переопределяем массив С
			my_Columns = new Clmns[this.dataGridView2.RowCount];
			for(int i = 0; i < this.dataGridView2.RowCount; i++)
			{
				my_Columns[i] = new Clmns(int.Parse(this.dataGridView2.Rows[i].Cells[0].Value.ToString()),
				                 int.Parse(this.dataGridView2.Rows[i].Cells[1].Value.ToString()),
				                 this.dataGridView2.Rows[i].Cells[2].Value.ToString(),
				                 this.dataGridView2.Rows[i].Cells[3].Value.ToString()
				                );
			}
		}
		
		
		
		// Метод записи отношений в массив структур my_Relations
		public void RecRels()
		{
			// Переопределяем массив my_Relations
			my_Relations = new Rels[RelationsColl.rcoll.dataGridView1.Rows.Count];
			
			for(int i = 0; i < RelationsColl.rcoll.dataGridView1.Rows.Count; i++)
			{
				my_Relations[i] = new Rels(
					int.Parse(RelationsColl.rcoll.dataGridView1.Rows[i].Cells[0].Value.ToString()),
					RelationsColl.rcoll.dataGridView1.Rows[i].Cells[4].Value.ToString(),
					RelationsColl.rcoll.dataGridView1.Rows[i].Cells[5].Value.ToString(),
					int.Parse(RelationsColl.rcoll.dataGridView1.Rows[i].Cells[1].Value.ToString()),
					RelationsColl.rcoll.dataGridView1.Rows[i].Cells[6].Value.ToString(),
					RelationsColl.rcoll.dataGridView1.Rows[i].Cells[7].Value.ToString(),
					int.Parse(RelationsColl.rcoll.dataGridView1.Rows[i].Cells[2].Value.ToString()),
					RelationsColl.rcoll.dataGridView1.Rows[i].Cells[8].Value.ToString(),
					RelationsColl.rcoll.dataGridView1.Rows[i].Cells[9].Value.ToString(),
					int.Parse(RelationsColl.rcoll.dataGridView1.Rows[i].Cells[3].Value.ToString()),
					RelationsColl.rcoll.dataGridView1.Rows[i].Cells[10].Value.ToString(),
					RelationsColl.rcoll.dataGridView1.Rows[i].Cells[11].Value.ToString(),
					RelationsColl.rcoll.dataGridView1.Rows[i].Cells[12].Value.ToString(),
					RelationsColl.rcoll.dataGridView1.Rows[i].Cells[13].Value.ToString(),
					RelationsColl.rcoll.dataGridView1.Rows[i].Cells[14].Value.ToString(),
					RelationsColl.rcoll.dataGridView1.Rows[i].Cells[15].Value.ToString(),
					RelationsColl.rcoll.dataGridView1.Rows[i].Cells[16].Value.ToString(),
					RelationsColl.rcoll.dataGridView1.Rows[i].Cells[17].Value.ToString()
								);
			}
		}
		
		// Метод чтения отношений из массива структур my_Relations
		public void ReadRels()
		{
			for(int i = 0; i < my_Relations.Length; i++)
			{
				int nRow = RelationsColl.rcoll.dataGridView1.Rows.Add();
				RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[0].Value = my_Relations[i].TabNumP.ToString();
				RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[1].Value = my_Relations[i].ClmnNumP.ToString();
				RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[2].Value = my_Relations[i].TabNumC.ToString();
				RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[3].Value = my_Relations[i].ClmnNumC.ToString();
				RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[4].Value = my_Relations[i].TabNameP;
				RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[5].Value = my_Relations[i].TabPsP;
				RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[6].Value = my_Relations[i].ClmnNameP;
				RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[7].Value = my_Relations[i].ClmnPsP;
				RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[8].Value = my_Relations[i].TabNameC;
				RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[9].Value = my_Relations[i].TabPsC;
				RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[10].Value = my_Relations[i].ClmnNameC;
				RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[11].Value = my_Relations[i].ClmnPsC;
				RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[12].Value = my_Relations[i].DrName;
				RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[13].Value = my_Relations[i].DrPs;
				RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[14].Value = my_Relations[i].ConstrName;
				RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[15].Value = my_Relations[i].ConstrPs;
				RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[16].Value = my_Relations[i].DelRule;
				RelationsColl.rcoll.dataGridView1.Rows[nRow].Cells[17].Value = my_Relations[i].UpdRule;
			}
		}
		
		
		
		
		// Метод фильтрации имён столбцов
		public void FiltrColumns()
		{
			int nCT = GetCurTable();
			this.dataGridView2.Rows.Clear();
			if(this.dataGridView1.RowCount > 0)
			{
				if(my_Columns != null)
				{
					for(int i = 0; i < my_Columns.Length; i++)
					{
						if(my_Columns[i].TbNum == nCT)
						{
							int nRow = this.dataGridView2.Rows.Add();
							this.dataGridView2.Rows[nRow].Cells[0].Value = my_Columns[i].TbNum.ToString();
							this.dataGridView2.Rows[nRow].Cells[1].Value = my_Columns[i].ClmnNum.ToString();
							this.dataGridView2.Rows[nRow].Cells[2].Value = my_Columns[i].ClmnName;
							this.dataGridView2.Rows[nRow].Cells[3].Value = my_Columns[i].ClmnComment;
						}
					}
				}
			} 
		}
		
		// Метод проверки наличия имён столбцов для всех таблиц
		public string NameClmnsCtrl()
		{
			string zStr = "";
			bool bErr = true;
			for(int i = 0; i < (this.dataGridView1.RowCount); i++)
			{
				for(int k = 0; k < (this.dataGridView2.RowCount); k++)
				{
					if(this.dataGridView2.Rows[k].Cells[0].Value.ToString() == this.dataGridView1.Rows[i].Cells[0].Value.ToString())
					{
						bErr = false;
						break;
					}else{
						bErr = true;
					}
				}
				if(bErr)
				{
					zStr += this.dataGridView1.Rows[i].Cells[1].Value.ToString() + "\n";
				}
			}
			return zStr;
		}
		
		// Метод перезаписи одноразмерных массивов структур свойств
		// P == P_rez
		public void RWR()
		{
			for(int i = 0; i < my_properties.Length; i++)
			{
				// Если есть соответствие индексов, записываю
				if((my_properties[i].TbNum == P_rez[i].TbNum)&&
				   (my_properties[i].ClmnNum == P_rez[i].ClmnNum))
				{
					my_properties[i].ClmnType = P_rez[i].ClmnType;
					my_properties[i].ClmnPK = P_rez[i].ClmnPK;
					my_properties[i].ClmnFK = P_rez[i].ClmnFK;
					my_properties[i].ClmnDT = P_rez[i].ClmnDT;
					my_properties[i].ClmnLen = P_rez[i].ClmnLen;
					my_properties[i].AiStart = P_rez[i].AiStart;
					my_properties[i].AiStep = P_rez[i].AiStep;
					my_properties[i].ClmnExpr = P_rez[i].ClmnExpr;
				}else{
					// Нет соответствия индексов, обнуляю
					my_properties[i].ClmnType = "";
					my_properties[i].ClmnPK = false;
					my_properties[i].ClmnFK = false;
					my_properties[i].ClmnDT = false;
					my_properties[i].ClmnLen = 0;
					my_properties[i].AiStart = 0;
					my_properties[i].AiStep = 0;
					my_properties[i].ClmnExpr = "";
				}

			}
		}
		
		// Метод перезаписи разноразмерных массивов структур свойств
		// P > P_rez
		public void RWB()
		{
			for(int i = 0; i < my_properties.Length; i++)
			{
				if(i < P_rez.Length)
				{
					if((my_properties[i].TbNum == P_rez[i].TbNum)&&
					   (my_properties[i].ClmnNum == P_rez[i].ClmnNum))
					{
						my_properties[i].ClmnType = P_rez[i].ClmnType;
						my_properties[i].ClmnPK = P_rez[i].ClmnPK;
						my_properties[i].ClmnFK = P_rez[i].ClmnFK;
						my_properties[i].ClmnDT = P_rez[i].ClmnDT;
						my_properties[i].ClmnLen = P_rez[i].ClmnLen;
						my_properties[i].AiStart = P_rez[i].AiStart;
						my_properties[i].AiStep = P_rez[i].AiStep;
						my_properties[i].ClmnExpr = P_rez[i].ClmnExpr;
					}else{
						my_properties[i].ClmnType = "";
						my_properties[i].ClmnPK = false;
						my_properties[i].ClmnFK = false;
						my_properties[i].ClmnDT = false;
						my_properties[i].ClmnLen = 0;
						my_properties[i].AiStart = 0;
						my_properties[i].AiStep = 0;
						my_properties[i].ClmnExpr = "";
					}
				}
			}
		}
		
		// Метод перезаписи разноразмерных массивов структур свойств
		// P < P_rez
		public void RWM()
		{
			for(int i = 0; i < my_properties.Length; i++)
			{
				for(int k = 0; k < P_rez.Length; k++)
				{
					if((my_properties[i].TbNum == P_rez[k].TbNum)&&
					   (my_properties[i].ClmnNum == P_rez[k].ClmnNum))
					{
						my_properties[i].ClmnType = P_rez[k].ClmnType;
						my_properties[i].ClmnPK = P_rez[k].ClmnPK;
						my_properties[i].ClmnFK = P_rez[k].ClmnFK;
						my_properties[i].ClmnDT = P_rez[k].ClmnDT;
						my_properties[i].ClmnLen = P_rez[k].ClmnLen;
						my_properties[i].AiStart = P_rez[k].AiStart;
						my_properties[i].AiStep = P_rez[k].AiStep;
						my_properties[i].ClmnExpr = P_rez[k].ClmnExpr;
					}else{
						my_properties[i].ClmnType = "";
						my_properties[i].ClmnPK = false;
						my_properties[i].ClmnFK = false;
						my_properties[i].ClmnDT = false;
						my_properties[i].ClmnLen = 0;
						my_properties[i].AiStart = 0;
						my_properties[i].AiStep = 0;
						my_properties[i].ClmnExpr = "";
					}
				}
			}
		}
		
		// Метод перезаписи массива структур свойств
		public void ReWriteProp()
		{
			// Перезапись массива структур таблиц
			RecTables();
			// Перезапись массива структур столбцов
			RecColumns();
			// Резервное копирование массива структур свойств
			P_rez = new ClmnProp[my_properties.Length];
			for(int i = 0; i < my_properties.Length; i++)
			{
				P_rez[i] = new ClmnProp(my_properties[i].TbNum,
				                        my_properties[i].ClmnNum,
				                        my_properties[i].ClmnCaption,
				                        my_properties[i].ClmnType,
				                        my_properties[i].ClmnPK,
				                        my_properties[i].ClmnFK,
				                        my_properties[i].ClmnDT,
				                        my_properties[i].ClmnLen,
				                        my_properties[i].AiStart,
				                        my_properties[i].AiStep,
				                        my_properties[i].ClmnExpr
				                       );
			}
			// Переопределение массива структур свойств
			my_properties = new ClmnProp[my_Columns.Length];
			// Запись индексов таблиц и столбцов в массив свойств
			// с дружественными именами
			for(int i = 0; i < my_Columns.Length; i++)
			{
				my_properties[i] = new ClmnProp(my_Columns[i].TbNum,
				                    my_Columns[i].ClmnNum,
				                    my_Columns[i].ClmnComment
				                   );
			}
			
			if(my_properties.Length == P_rez.Length)
			{
				RWR();
			}
			
			if(my_properties.Length > P_rez.Length)
			{
				RWB();
			}
			
			if(my_properties.Length < P_rez.Length)
			{
				RWM();
			}
		}
		
		// Метод генерации начального массива структуры свойств столбцов P
		public void GenMassProp()
		{
			if(my_properties == null)
			{
				RecTables();
				RecColumns();
				my_properties = new ClmnProp[my_Columns.Length];
				for(int i = 0; i < my_Columns.Length; i++)
				{
					my_properties[i] = new ClmnProp(my_Columns[i].TbNum,
					                    my_Columns[i].ClmnNum,
					                    my_Columns[i].ClmnComment,
					                    "",
					                    false,
					                    false,
					                    false,
					                    0,
					                    0,
					                    0,
					                    ""
					                   );
				}
			}
		}
		
		// Метод чтения свойств из массива структур свойств P
		public void ReadProp()
		{
			Propertys prp = new Propertys();
			string szTblName = "";
			string szClmnName = "";
			string szClmnZagol = "";
			int nRow = 0;
			for(int i = 0; i < my_properties.Length; i++)
			{
				szTblName = my_Tables[(my_properties[i].TbNum - 1)].TbName;
				szClmnName = my_Columns[(my_properties[i].ClmnNum - 1)].ClmnName;
				szClmnZagol = my_Columns[(my_properties[i].ClmnNum - 1)].ClmnComment;

				nRow = prp.dataGridView1.Rows.Add();
				prp.dataGridView1.Rows[nRow].Cells[0].Value = szTblName;
				prp.dataGridView1.Rows[nRow].Cells[1].Value = szClmnName;
				prp.dataGridView1.Rows[nRow].Cells[2].Value = szClmnZagol;
				prp.dataGridView1.Rows[nRow].Cells[3].Value = my_properties[i].ClmnPK;
				prp.dataGridView1.Rows[nRow].Cells[4].Value = my_properties[i].ClmnFK;
				prp.dataGridView1.Rows[nRow].Cells[5].Value = my_properties[i].ClmnDT;
				prp.dataGridView1.Rows[nRow].Cells[6].Value = my_properties[i].ClmnType;
				prp.dataGridView1.Rows[nRow].Cells[7].Value = my_properties[i].ClmnLen.ToString();
				prp.dataGridView1.Rows[nRow].Cells[8].Value = my_properties[i].AiStart.ToString();
				prp.dataGridView1.Rows[nRow].Cells[9].Value = my_properties[i].AiStep.ToString();
				prp.dataGridView1.Rows[nRow].Cells[10].Value = my_properties[i].ClmnExpr;
				szTblName = "";
				szClmnName = "";
				szClmnZagol = "";
			}
			prp.ShowDialog();
		}
		
		// Метод записи свойств в массив структур P
		public void WriteProp()
		{
			// Запись свойств в массив P
			for(int i = 0; i < my_Columns.Length; i++)
			{
				my_properties[i].ClmnType = Propertys.pk.dataGridView1.Rows[i].Cells[6].Value.ToString();
				my_properties[i].ClmnPK =bool.Parse(Propertys.pk.dataGridView1.Rows[i].Cells[3].Value.ToString());
				my_properties[i].ClmnFK = bool.Parse(Propertys.pk.dataGridView1.Rows[i].Cells[4].Value.ToString());
				my_properties[i].ClmnDT = bool.Parse(Propertys.pk.dataGridView1.Rows[i].Cells[5].Value.ToString());
				my_properties[i].ClmnLen = int.Parse(Propertys.pk.dataGridView1.Rows[i].Cells[7].Value.ToString());
				my_properties[i].AiStart = int.Parse(Propertys.pk.dataGridView1.Rows[i].Cells[8].Value.ToString());
				my_properties[i].AiStep = int.Parse(Propertys.pk.dataGridView1.Rows[i].Cells[9].Value.ToString());
				my_properties[i].ClmnExpr = Propertys.pk.dataGridView1.Rows[i].Cells[10].Value.ToString();
			}
			
			// Резервное копирование массива свойств в P_rez
			P_rez = new ClmnProp[my_properties.Length];
			
			for(int i = 0; i < my_properties.Length; i++)
			{
				P_rez[i] = new ClmnProp(my_properties[i].TbNum,
				                        my_properties[i].ClmnNum,
				                        my_properties[i].ClmnCaption,
				                        my_properties[i].ClmnType,
				                        my_properties[i].ClmnPK,
				                        my_properties[i].ClmnFK,
				                        my_properties[i].ClmnDT,
				                        my_properties[i].ClmnLen,
				                        my_properties[i].AiStart,
				                        my_properties[i].AiStep,
				                        my_properties[i].ClmnExpr
				                       );
			}
		}
		
		// Метод получения имени и номера текущей таблицы
		public int GetCurTable()
		{
			try{
				CurTable = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
				NumCurTable = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
				toolStripStatusLabel1.Text = "Текущая таблица: " + CurTable;
			}catch{
				
			}
			return NumCurTable;
		}
		
		// Метод получения имени и номера текущего столбца
		public int GetCurColumn()
		{
			try{
				CurColumn = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
				NumCurColumn = int.Parse(this.dataGridView2.CurrentRow.Cells[1].Value.ToString());
				toolStripStatusLabel2.Text = "Текущий столбец: " + CurColumn;
			}catch{
				
			}
			return NumCurColumn;
		}
		
		// метод ренумерации DataGridView
		// Параметры:	a - объект DataGridView
		//				b - номер столбца для ренумерации
		public void ReNumerator(DataGridView a, int b)
		{
			for(int i = 0; i < (a.RowCount - 1); i++)
			{
				a.Rows[i].Cells[b].Value = (i + 1).ToString();
			}
		}
		
		// Метод вызова диалога добавления имени
		// Параметры: 	a - заголовок окна
		//				b - текст надписи
		//				c - имя по-умолчанию
		//				d - надпись на кнопке
		public void AddNameDlg(string a, string b, string c, string d)
		{
			if(a == "Изменение имени таблицы")
			{
				df.textBox2.Text = dataGridView1.Rows[(NumCurTable - 1)].Cells[2].Value.ToString();
			}
			if(a == "Изменение имени столбца")
			{
				df.textBox2.Text = dataGridView2.Rows[(NumCurColumn - 1)].Cells[3].Value.ToString();
			}
			df.Text = a;
			df.label1.Text = b;
			df.textBox1.Text = c;
			df.button1.Text = d;
			df.ShowDialog();
			df.textBox1.Select(0, df.Text.Length);
			df.textBox1.Focus();
		}
		
		// Метод добавления имён в списки
		// Параметры:	a - объект DataGridView
		//				b - объект TextBox
		//				c - номер столбца для записи
		//				d - номер столбца для номеров
		//				e - номер объекта DataGridView
		//				f - текст комментария
		public void AddNamesToGrid(DataGridView a, TextBox b, int c, int d, int e, TextBox f)
		{
			int nRow = a.Rows.Add();
			a.Rows[nRow].Cells[c].Value = b.Text;
			a.Rows[nRow].Cells[c+1].Value  = f.Text;
			switch(e)
			{
				case 1:
					KolTables = a.Rows.Count;
					a.Rows[nRow].Cells[d].Value = KolTables.ToString();
					break;
				case 2:
					KolColumns = a.Rows.Count;
					a.Rows[nRow].Cells[d].Value = KolColumns.ToString();
					a.Rows[nRow].Cells[0].Value = NumCurTable.ToString();
					break;
			}
		}
		
		// Метод удаления строки списка имён при отсутствии связей
		public void DeleteRow(DataGridView a, int b)
		{
			if(a.Rows.Count > 0)
			{
				if((my_properties != null)||(P_rez != null))
				{
					// Фиксируем индекс текущего столбца
					string nRow = a.CurrentRow.Cells[1].Value.ToString();
					// Удаляем текущую строку
					a.Rows.Remove(a.CurrentRow);
					// Переопределяем массив P
					my_properties = new ClmnProp[a.Rows.Count];
					// Перезаписываем свойства в P из P_rez
					int k = 0;
					for(int i = 0; i < P_rez.Length; i++)
					{
						if(P_rez[i].ClmnNum != int.Parse(nRow))
						{
							my_properties[k] = new ClmnProp(P_rez[i].TbNum,
							                    P_rez[i].ClmnNum,
							                    P_rez[i].ClmnCaption,
							                    P_rez[i].ClmnType,
							                    P_rez[i].ClmnPK,
							                    P_rez[i].ClmnFK,
							                    P_rez[i].ClmnDT,
							                    P_rez[i].ClmnLen,
							                    P_rez[i].AiStart,
							                    P_rez[i].AiStep,
							                    P_rez[i].ClmnExpr
							                   );
							k++;
						}
					}
					
					// Реиндексируем столбцы
					for(int i = 0; i < a.Rows.Count; i++)
					{
						a.Rows[i].Cells[1].Value = (i + 1).ToString();
						my_properties[i].ClmnNum = (i + 1);
					}
				}else{
					a.Rows.Remove(a.CurrentRow);
					Renumerator(a, b);
				}
			}else{
				MessageBox.Show("Нет элемента для удаления!", "Ошибка!",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Error);
			}
			if(my_Tables != null) RecTables();
			if(my_Columns != null) RecColumns();
			if(my_properties != null) ReWriteProp();
		}
		
		// Метод удаления значений из связанных списков
		public void DeleteLinkRows(DataGridView a, int b, DataGridView c, int d, bool e)
		{
			if(c.Rows.Count > 0)
			{
				// Фиксируем индекс текущей таблицы
				string szIndTable = a.CurrentRow.Cells[0].Value.ToString();
				
				// Удаляем связанные строки в списке столбцов
				for(int i = 0; i < (c.RowCount); i++)
				{
					if(c.Rows[i].Cells[0].Value.ToString() == szIndTable)
					{
						c.Rows.Remove(c.Rows[i]);
						i--;
					}
				}
				
				if((my_properties != null)&&(P_rez != null))
				{
					// Переопределяем массив свойств P
					my_properties = new ClmnProp[c.Rows.Count];
				
					// Записываем свойства в массив P
					int k = 0;
					for(int i = 0; i < P_rez.Length; i++)
					{
						if(P_rez[i].TbNum != int.Parse(szIndTable))
						{
							my_properties[k] = new ClmnProp(P_rez[i].TbNum,
							                    P_rez[i].ClmnNum,
							                    P_rez[i].ClmnCaption,
							                    P_rez[i].ClmnType,
							                    P_rez[i].ClmnPK,
							                    P_rez[i].ClmnFK,
							                    P_rez[i].ClmnDT,
							                    P_rez[i].ClmnLen,
							                    P_rez[i].AiStart,
							                    P_rez[i].AiStep,
							                    P_rez[i].ClmnExpr
							                   );
							k++;
						}
					}
				}
				
				// Удаляем текущую запись в списке таблиц
				
				a.Rows.Remove(a.Rows[int.Parse(szIndTable) - 1]);

				// Реиндексируем столбцы
				for(int i = 0; i < c.Rows.Count; i++)
				{
					c.Rows[i].Cells[1].Value = (i + 1).ToString();
					my_properties[i].ClmnNum = (i + 1);
				}
				
				// Выполняем ренумерацию таблиц с реиндексацией столбцов
				string szNum = "";
				for(int i = 0; i < (a.RowCount); i++)
				{
					szNum = a.Rows[i].Cells[0].Value.ToString();
					a.Rows[i].Cells[b].Value = (i + 1).ToString();
					for(int k = 0; k < (c.RowCount); k++)
					{
						if(c.Rows[k].Cells[0].Value.ToString() == szNum)
						{
							c.Rows[k].Cells[0].Value = a.Rows[i].Cells[b].Value.ToString();
							my_properties[k].TbNum = int.Parse(a.Rows[i].Cells[b].Value.ToString());
						}
					}
				}
			}else{
				DeleteRow(a, b);
			}
		}
		
		// Метод ренумерации списков имён
		public void Renumerator(DataGridView a, int b)
		{
			if(a.Rows.Count > 0)
			{
				for(int i = 0; i < a.Rows.Count; i++)
				{
					a.Rows[i].Cells[b].Value = (i + 1).ToString();
				}
			}
		}
		
		// Метод получения максимального номера имени
		public string GetNum(DataGridView a, int b)
		{
			string numT = "";
			string num = "";
			int max = 0;
			int[] noms = new int[a.Rows.Count];
			for(int i = 0; i < a.Rows.Count; i++)
			{
				num = "";
				numT = a.Rows[i].Cells[b].Value.ToString();
				for(int k = 0; k < a.Rows[i].Cells[b].Value.ToString().Length; k++)
				{
					if((numT[k].ToString() == "0")||(numT[k].ToString() == "1")||(numT[k].ToString() == "2")||
					  (numT[k].ToString() == "3")||(numT[k].ToString() == "4")||(numT[k].ToString() == "5")||
					 (numT[k].ToString() == "6")||(numT[k].ToString() == "7")||(numT[k].ToString() == "8")||
					(numT[k].ToString() == "9"))
					{
						num += numT[k].ToString();
					}else{
						num = "0";
					}
				}
				noms[i] = int.Parse(num);
			}
			
			for(int i = 0; i < noms.Length; i++)
			{
				if(noms[i] > max) max = noms[i];
			}
			max++;
			return max.ToString();
		}
		
		// Метод добавления имени таблицы
		public void AddTable()
		{
				string c = "";
				NomTable = (this.dataGridView1.Rows.Count + 1);
				if(this.dataGridView1.Rows.Count > 0)
				{
					c = "table" + GetNum(dataGridView1, 1);
				}else{
					c = "table" + NomTable.ToString();
				}
				AddNameDlg("Новое имя таблицы", "", c, "Добавить");
		}
		
		// Метод изменения имени таблицы
		public void EditTable()
		{
			if(GetCurTable() != 0)
			{
				AddNameDlg("Изменение имени таблицы", "", CurTable, "Изменить");
			}else{
				MessageBox.Show("Не выбрана таблица!", "Ошибка!",   MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		// Метод добавления имени столбца
		public void AddColumn()
		{
			if(GetCurTable() != 0)
			{
				string c ="";
				NomColumn = (this.dataGridView2.Rows.Count + 1);
				if(this.dataGridView1.Rows.Count > 0)
				{
					c = "column" + GetNum(dataGridView2, 2);
				}else{
					c = "column" + NomColumn.ToString();
				}
			
				AddNameDlg("Новое имя столбца", "Текущая таблица: " + CurTable, c, "Добавить");
			}else{
				MessageBox.Show("Не выбрана таблица!", "Ошибка!",   MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		// Метод изменения имени столбца
		public void EditColumn()
		{
			if(GetCurColumn() != 0)
			{
				AddNameDlg("Изменение имени столбца", "", CurColumn, "Изменить");
			}else{
				MessageBox.Show("Не выбран столбец!", "Ошибка!",   MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		// Пункт меню "Выход"
		void ВыходToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(Edited == true)
			{
				DialogResult dr = MessageBox.Show("Сохранить внесённые изменения?",
				                                  "Генератор методов",
				                                  MessageBoxButtons.YesNoCancel,
				                                  MessageBoxIcon.Question,
				                                  MessageBoxDefaultButton.Button1);
				if(dr == DialogResult.Yes)
				{
					if(CurrentFileName.Length > 0)
					{
						Collection_Class.SaveCollection();
						FromMenuExit = true;
						Application.Exit();
					}else{
						Collection_Class.SaveCollectionDlg();
						FromMenuExit = true;
						Application.Exit();
					}
				}
				
				if(dr == DialogResult.No)
				{
					FromMenuExit = true;
					Application.Exit();
				}
			}else{
				FromMenuExit = true;
				Application.Exit();
			}
		}
		
		// Кнопка "Добавить имя таблицы"
		void ToolStripButton4Click(object sender, EventArgs e)
		{
			AddTable();
			RecTables();
		}
		
		// Кнопка "Изменить имя таблицы"
		void ToolStripButton5Click(object sender, EventArgs e)
		{
			EditTable();
			RecTables();
		}
		
		// Кнопка "Удалить имя таблицы"
		void ToolStripButton6Click(object sender, EventArgs e)
		{
			if(my_Relations != null)
			{
				if(MessageBox.Show("Будет потеряна коллекция отношений\nПродолжить?", "Генератор методов",
				                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					DeleteLinkRows(dataGridView1, 0, dataGridView2, 1, false);
					RecTables();
					RecColumns();
					my_Relations = new Rels[0];
				}
			}else{
				DeleteLinkRows(dataGridView1, 0, dataGridView2, 1, false);
				RecTables();
				RecColumns();
			}
		}
		
		// Кнопка "Добавить имя столбца"
		void ToolStripButton7Click(object sender, EventArgs e)
		{
			AddColumn();
			RecColumns();
		}
		
		// Кнопка "Изменить имя стобца"
		void ToolStripButton8Click(object sender, EventArgs e)
		{
			EditColumn();
			RecColumns();
		}
		
		// Кнопка "Удалить имя столбца"
		void ToolStripButton9Click(object sender, EventArgs e)
		{
			if(my_Relations != null)
			{
				if(MessageBox.Show("Будет потеряна коллекция отношений\nПродолжить?", "Генератор методов",
				                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					DeleteRow(dataGridView2, 1);
					RecTables();
					RecColumns();
					my_Relations = new Rels[0];
				}
			}else{
				DeleteRow(dataGridView2, 1);
				RecTables();
				RecColumns();
			}
		}
		
		// Определение параметров текущей таблицы
		void DataGridView1CurrentCellChanged(object sender, EventArgs e)
		{
			GetCurTable();
		}
		
		// Определение параметров текущего столбца
		void DataGridView2CurrentCellChanged(object sender, EventArgs e)
		{
			GetCurColumn();
		}

		// Кнопка выбора технологии индексации ключей AutoIncrement
		void ToolStripButton11Click(object sender, EventArgs e)
		{
			if((my_properties != null)&&(my_properties.Length > 0))
			{
				if(MessageBox.Show("Смена технологии на этом этапе\nприведёт к обнулению коллекции свойств и отношений!\nПродолжить?", "Внимание!",
				                   MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
				{
					
					if(my_Columns != null)	my_properties = new ClmnProp[my_Columns.Length];
				}
			}
			toolStripButton11.Checked = true;
			toolStripButton10.Checked = false;
		}
		
		// Кнопка выбора технологии индексации ключей GUID
		void ToolStripButton10Click(object sender, EventArgs e)
		{
			if((my_properties != null)&&(my_properties.Length > 0))
			{
				if(MessageBox.Show("Смена технологии на этом этапе\nприведёт к обнулению коллекции свойств и отношений!\nПродолжить?", "Внимание!",
				                   MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
				{
					
					if(my_Columns != null)	my_properties = new ClmnProp[my_Columns.Length];
				}
			}
			toolStripButton10.Checked = true;
			toolStripButton11.Checked = false;
		}
		
		// Кнопка изменения имени объекта класса DataSet
		void ToolStripButton12Click(object sender, EventArgs e)
		{
			ne.Text = "Изменить имя объекта класса DataSet";
			ne.textBox1.Text = toolStripTextBox1.Text;
			ne.ShowDialog();
			ne.textBox1.Focus();
			ne.textBox1.Select(0, ne.Text.Length);
		}
		
		// Кнопка изменения имени метода создания объекта
		void ToolStripButton13Click(object sender, EventArgs e)
		{
			ne.Text = "Изменить имя метода";
			ne.textBox1.Text = toolStripTextBox2.Text;
			ne.ShowDialog();
			ne.textBox1.Focus();
			ne.textBox1.Select(0, ne.Text.Length);
		}
		
		void ДобавитьИмяТаблицыToolStripMenuItemClick(object sender, EventArgs e)
		{
			AddTable();
			RecTables();
		}
		
		void ИзменитьИмяТаблицыToolStripMenuItemClick(object sender, EventArgs e)
		{
			EditTable();
			RecTables();
		}
		
		void УдалитьИмяТаблицыToolStripMenuItemClick(object sender, EventArgs e)
		{
			DeleteLinkRows(dataGridView1, 0, dataGridView2, 1, false);
			RecTables();
			RecColumns();
		}
		
		void ДобавитьИмяСтолбцаToolStripMenuItemClick(object sender, EventArgs e)
		{
			AddColumn();
			RecColumns();
		}
		
		void ИзменитьИмяСтолбцаToolStripMenuItemClick(object sender, EventArgs e)
		{
			EditColumn();
			RecColumns();
		}
		
		void УдалитьИмяСтолбцаToolStripMenuItemClick(object sender, EventArgs e)
		{
			DeleteRow(dataGridView2, 1);
			RecColumns();
		}
		
		// Кнопка запуска генерации метода
		void ToolStripButton14Click(object sender, EventArgs e)
		{
			Generator gf = new Generator();
			gf.ShowDialog();
		}
		
		void РежимРедакторасвойствToolStripMenuItemClick(object sender, EventArgs e)
		{
			if((this.dataGridView1.Rows.Count > 0)&&(this.dataGridView2.Rows.Count > 0))
			{
				if(NameClmnsCtrl() == "")
				{
					if(my_properties != null)
					{
						ReWriteProp();
						ReadProp();
					}else{
						GenMassProp();
						ReadProp();
					}
					
				}else{
					MessageBox.Show("Не определены имена столбцов для таблиц:\n" + NameClmnsCtrl());
				}
			}else{
				MessageBox.Show("Коллекция имён неполная!\nВключение редактора свойств невозможно!");
			}
		}
		
		void DataGridView1DoubleClick(object sender, EventArgs e)
		{
			FiltrColumns();
			режимРедакторасвойствToolStripMenuItem.Enabled = false;
			режимРедактораотношенийToolStripMenuItem.Enabled = false;
		}
		
		void ПоказатьВсёToolStripMenuItemClick(object sender, EventArgs e)
		{
			Collection_Class.ReadColumns();
			режимРедакторасвойствToolStripMenuItem.Enabled = true;
			режимРедактораотношенийToolStripMenuItem.Enabled = true;
		}
		
		void СвойстваToolStripMenuItemClick(object sender, EventArgs e)
		{
			PropertyEdit pe = new PropertyEdit();
			pe.ShowDialog();
		}
		
		void ContextMenuStrip1Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(this.dataGridView2.Rows.Count == 0)
			{
				показатьВсёToolStripMenuItem.Enabled = false;
			}else{
				показатьВсёToolStripMenuItem.Enabled = true;
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			this.dataGridView1.ColumnHeadersHeightSizeMode =
				DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView2.ColumnHeadersHeightSizeMode =
				DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.toolStripStatusLabel3.Text = "Редактор коллекции имён.";
			Edited = false;
			About ap = new About();
			ap.ShowDialog();
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}
		
		void СохранитьРешениеToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(CurrentFileName.Length > 0)
			{
				Collection_Class.SaveCollection();
			}else{
				Collection_Class.SaveCollectionDlg();
			}
		}
		
		void ToolStripButton3Click(object sender, EventArgs e)
		{
			if(CurrentFileName.Length > 0)
			{
				Collection_Class.SaveCollection();
			}else{
				Collection_Class.SaveCollectionDlg();
			}
		}
		
		void ОткрытьРешениеToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(Edited == true)
			{
				DialogResult dr = MessageBox.Show("Сохранить внесённые изменения?",
				                                  "Генератор методов",
				                                  MessageBoxButtons.YesNoCancel,
				                                  MessageBoxIcon.Question,
				                                  MessageBoxDefaultButton.Button1);
				if(dr == DialogResult.Yes)
				{
					if(CurrentFileName.Length > 0)
					{
						Collection_Class.SaveCollection();
					}else{
						Collection_Class.SaveCollectionDlg();
					}
					Collection_Class.OpenCollection();
				}
			}else{
				Collection_Class.OpenCollection();
			}
		}
		
		void ToolStripButton2Click(object sender, EventArgs e)
		{
			if(Edited == true)
			{
				DialogResult dr = MessageBox.Show("Сохранить внесённые изменения?",
				                                  "Генератор методов",
				                                  MessageBoxButtons.YesNoCancel,
				                                  MessageBoxIcon.Question,
				                                  MessageBoxDefaultButton.Button1);
				if(dr == DialogResult.Yes)
				{
					if(CurrentFileName.Length > 0)
					{
						Collection_Class.SaveCollection();
					}else{
						Collection_Class.SaveCollectionDlg();
					}
					Collection_Class.OpenCollection();
				}
				if(dr == DialogResult.No)
				{
					Collection_Class.OpenCollection();
				}
			}else{
				Collection_Class.OpenCollection();
			}
		}
		
		void DataGridView1CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			Edited = true;
		}
		
		void DataGridView2CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			Edited = true;
		}
		
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			Collection_Class.NewCollection();
		}
		
		void СоздатьРешениеToolStripMenuItemClick(object sender, EventArgs e)
		{
			Collection_Class.NewCollection();
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if(FromMenuExit == false)
			{
				if(Edited == true)
				{
					DialogResult dr = MessageBox.Show("Сохранить внесённые изменения?",
					                                  "Генератор методов",
					                                  MessageBoxButtons.YesNoCancel,
					                                  MessageBoxIcon.Question,
					                                  MessageBoxDefaultButton.Button1);
					if(dr == DialogResult.Yes)
					{
						if(CurrentFileName.Length > 0)
						{
							Collection_Class.SaveCollection();
							Application.Exit();
						}else{
							Collection_Class.SaveCollectionDlg();
							Application.Exit();
						}
					}
					
					if(dr == DialogResult.No)
					{
						e.Cancel = false;
					}
					
					if(dr == DialogResult.Cancel)
					{
						e.Cancel = true;
					}
				}else{
					Application.Exit();
				}
			}
		}
		
		void ВыполнитьГенерациюМетодаToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(my_Tables == null || my_Columns == null || my_properties == null || my_Relations == null)
			{
				DialogResult dr = MessageBox.Show("База данных '" 
				+ toolStripTextBox1.Text + "' заполнена не полностью", "Генератор методов",
				MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);	
				
				
			}else{
				Generator_Class.MethodGenerate();
			}
		}
		
		// Метод проверки наличия первичных ключей
		public bool PKCtrl()
		{
			bool pkno = true;
			for(int i = 0; i < my_properties.Length; i++){
				if(my_properties[i].ClmnPK == true)
				{
					pkno = false;
					break;
				}
			}
			return pkno;
		}
		
		// Метод проверки наличия внешних ключей
		public bool FKCtrl()
		{
			bool fkno = true;
			for(int i = 0; i < my_properties.Length; i++){
				if(my_properties[i].ClmnFK == true)
				{
					fkno = false;
					break;
				}
			}
			return fkno;
		}
		
		// Метод проверки наличия всех свойств
		public bool PropCtrl()
		{
			RecTables();
			RecColumns();
			ReWriteProp();
			bool ctrl =false;
			if(my_properties != null)
			{
				for(int i = 0; i < my_properties.Length; i++)
				{
					if((my_properties[i].ClmnPK == false)&&(my_properties[i].ClmnFK == false)&&(my_properties[i].ClmnDT == false))
					{
						ctrl = true;
						break;
					}
				}
			}
			return ctrl;
		}
		
		// Вызов редактора отношений
		void РежимРедактораотношенийToolStripMenuItemClick(object sender, EventArgs e)
		{
			if((this.dataGridView1.Rows.Count == 0)||(this.dataGridView2.Rows.Count == 0))
			{
				MessageBox.Show("Нет объектов для отношений!\nВключение редактора отношений невозможно!");
			}else if(NameClmnsCtrl() != ""){
				MessageBox.Show("Не определены имена столбцов для таблиц:\n" + NameClmnsCtrl());
			}else if(PropCtrl()){
				MessageBox.Show("Не для всех столбцов определены свойства!");
			}else if(PKCtrl()){
				MessageBox.Show("Не определены первичные ключи!");
			}else if(FKCtrl()){
				MessageBox.Show("Не определены внешние ключи!");
			}else{
				RelationsColl rc = new RelationsColl();
				if(my_Relations != null)
				{
					ReadRels();
				}
				rc.ShowDialog();
			}
		}
		
		void ОПрограммеToolStripMenuItemClick(object sender, EventArgs e)
		{
			About ap = new About();
			ap.ShowDialog();
		}
		
		void ВызватьСправкуToolStripMenuItemClick(object sender, EventArgs e)
		{
			Help.ShowHelp(this, "SpravkaGM.chm");
		}
		
		void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}
		
				void DataGridView1CellMouseEnter(object sender, DataGridViewCellEventArgs e)
		{
				this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
		}
		
		void DataGridView1CellMouseLeave(object sender, DataGridViewCellEventArgs e)
		{
				this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
		}
		
		
	}
}
