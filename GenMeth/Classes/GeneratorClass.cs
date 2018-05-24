/*
 * Сделано в SharpDevelop.
 * Пользователь: Asus
 * Дата: 20.05.2018
 * Время: 18:36
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
	/// Description of GeneratorClass.
	/// </summary>
	public class GeneratorClass: MainForm
	{
		public void MethodGenerate()
		{
			string n = @"
	";
			string nn = @"
		";
			string nnn = @"
						";
			// Строка пространств имён для технологии Guid
			string NameSpacesGuid = 
	@"
// Пространства имён
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;";
			
			// Строка пространств имён для технологии AutoIncrement
			string NameSpacesAi = 
	@"
// Пространства имён
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;
using System.IO;";
			
			// Строка для объявления имени объекта класса DataSet
			string NameDS = "private System.Data.DataSet " + this.toolStripTextBox1.Text + ";";
			
			// Строка для объявления имён таблиц
			string NameTb = "private System.Data.DataTable ";
				
			// Строка для объявления имён столбцов
			string NameClm = "private System.Data.DataColumn ";
			
			// Строка для объявления имён отношений
			string NameDr = "private System.Data.DataRelation ";
			
	// Блок генерации метода
			// Создание экземпляра объекта формы
			Generator gen = new Generator();
			
			// Запись пространств имён для технологии Guid
			if(this.toolStripButton10.Checked == true)
			{
				gen.textBox1.Text =  NameSpacesGuid + n + n;
			}
			
			// Запись пространств имён для технологии AutoIncrement
			if(this.toolStripButton11.Checked == true)
			{
				gen.textBox1.Text =  NameSpacesAi + n + n;
			}
			
			gen.textBox1.Text += "// Обявление имён экземпляров объектов" + n;
			
			// Запись имени экземпляра объекта DataSet
			gen.textBox1.Text += NameDS + n;
				
			
			// Запись имён объектов таблиц
		    
			for(int i = 0; i < Main_Form.my_Tables.Length; i++)
			{
				gen.textBox1.Text += NameTb + Main_Form.my_Tables[i].TbName + ";" + n;
			}
			
			// Запись имён объектов столбцов
			for(int i = 0; i < Main_Form.my_Columns.Length; i++)
			{
				gen.textBox1.Text += NameClm + Main_Form.my_Columns[i].ClmnName + ";" + n;
			}
			
			// Запись имён объектов отношений
		
			for(int i = 0; i < Main_Form.my_Relations.Length; i++)
			{
				gen.textBox1.Text += NameDr + Main_Form.my_Relations[i].DrName + ";" + n;
			}
			
			
			gen.textBox1.Text += n;
			
			// Начало метода создания объектов локального представления данных
			gen.textBox1.Text += "// Метод создания объектов локального представления данных" + n;
			gen.textBox1.Text += "public void " + this.toolStripTextBox2.Text +
				"()" + n + "{" + nn;
			
			// Создание экземпляра объекта класса DataSet
			gen.textBox1.Text += "// Создание экземпляра объекта класса DataSet" + nn;
			gen.textBox1.Text += "this." + this.toolStripTextBox1.Text + " = new System.Data.DataSet();" + nn;
			
			// Создание экземпляров таблиц
			gen.textBox1.Text += nn;
			gen.textBox1.Text += "// Создание экземпляров таблиц" + nn;
			for(int i = 0; i < Main_Form.my_Tables.Length; i++)
			{
				gen.textBox1.Text += "this." + Main_Form.my_Tables[i].TbName + " = new System.Data.DataTable();" + nn;
			}
			
			// Создание экземпляров столбцов
			gen.textBox1.Text += nn;
			gen.textBox1.Text += "// Создание экземпляров столбцов" + nn;
			for(int i = 0; i < Main_Form.my_Columns.Length; i++)
			{
				gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + " = new System.Data.DataColumn();" + nn;
			}
			
			// Присвоение псевдонимов таблицам
			gen.textBox1.Text += nn;
			gen.textBox1.Text += "// Присвоение псевдонимов таблицам" + nn;
			for(int i = 0; i < Main_Form.my_Tables.Length; i++)
			{
				gen.textBox1.Text += "this." + Main_Form.my_Tables[i].TbName + ".TableName = " + "\"" + Main_Form.my_Tables[i].TbComment + "\";" + nn;
			}
			
			// Присвоение псевдонимов столбцам
			gen.textBox1.Text += nn;
			gen.textBox1.Text += "// Присвоение псевдонимов столбцам" + nn;
			for(int i = 0; i < Main_Form.my_Columns.Length; i++)
			{
				gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".ColumnName = " + "\"" + Main_Form.my_Columns[i].ClmnComment + "\";" + nn;
			}
			
					
			// Добавление столбцов в коллекции объектов таблиц
			gen.textBox1.Text += nn;
			gen.textBox1.Text += "// Добавление столбцов к таблицам" + nn;
			int KolCol = 0;
			for(int i = 0; i < Main_Form.my_Tables.Length; i++)
			{
				gen.textBox1.Text += "this." + Main_Form.my_Tables[i].TbName + ".Columns.AddRange(new DataColumn[]{" + nnn;
				for(int k = 0; k < Main_Form.my_Columns.Length; k++)
				{
					if(Main_Form.my_Columns[k].TbNum == Main_Form.my_Tables[i].TbNum)
					{
						// Считаем количество столбцов для таблицы
						KolCol++;
					}
				}
				for(int l = 0; l < Main_Form.my_Columns.Length; l++)
				{
					if(Main_Form.my_Columns[l].TbNum == Main_Form.my_Tables[i].TbNum)
					{
						if(KolCol == 1)
						{
							gen.textBox1.Text += Main_Form.my_Columns[l].ClmnName + nnn;
						}else{
							gen.textBox1.Text += Main_Form.my_Columns[l].ClmnName + "," + nnn;
						}
						KolCol--;
					}
				}
					
				KolCol = 0;
				gen.textBox1.Text += "});" + nn;
				gen.textBox1.Text += nn;
			}
			
			// Определение свойств столбцов
			gen.textBox1.Text += nn;
			gen.textBox1.Text += "// Определение свойств столбцов" + nn;
			for(int i = 0; i < Main_Form.my_properties.Length; i++)
			{
				// Паттерны свойств
				// Свойства первичного ключа по технологии Guid
				if((Main_Form.my_properties[i].ClmnPK == true)&&(Main_Form.my_properties[i].ClmnType == "Guid"))
				{
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".DataType = typeof(System.Guid);" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".AllowDBNull = false;" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".ReadOnly = true;" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".Unique = true;" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".DefaultValue = Guid.NewGuid();" + nn;
				}
				
				// Свойства первичного ключа по технологии AutoIncrement
				if((Main_Form.my_properties[i].ClmnPK == true)&&(Main_Form.my_properties[i].ClmnType == "Int32"))
				{
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".DataType = typeof(System.Int32);" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".AllowDBNull = false;" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".ReadOnly = true;" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".Unique = true;" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".AutoIncrement = true;" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".AutoIncrementSeed = " + my_properties[i].AiStart.ToString() + ";" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".AutoIncrementStep = " + my_properties[i].AiStep.ToString() + ";" + nn;
				}
				
				// Свойства внешнего ключа по технологии Guid
				if((Main_Form.my_properties[i].ClmnFK == true)&&(Main_Form.my_properties[i].ClmnType == "Guid"))
				{
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".DataType = typeof(System.Guid);" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".AllowDBNull = false;" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".ReadOnly = true;" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".Unique = false;" + nn;
				}
				
				// Свойства внешнего ключа по технологии AutoIncrement
				if((Main_Form.my_properties[i].ClmnFK == true)&&(Main_Form.my_properties[i].ClmnType == "Int32"))
				{
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".DataType = typeof(System.Int32);" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".AllowDBNull = false;" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".ReadOnly = true;" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".Unique = false;" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".AutoIncrement = false;" + nn;
				}
				
				// Свойства столбца данных
				if(Main_Form.my_properties[i].ClmnDT == true)
				{
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".DataType = typeof(System." + Main_Form.my_properties[i].ClmnType +");" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".AllowDBNull = true;" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".ReadOnly = false;" + nn;
					gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".Unique = false;" + nn;
					if(Main_Form.my_properties[i].ClmnExpr != "")
						gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".Expression = \"" + Main_Form.my_properties[i].ClmnExpr + "\";" + nn;
					if(Main_Form.my_properties[i].ClmnType == "String")
						gen.textBox1.Text += "this." + Main_Form.my_Columns[i].ClmnName + ".MaxLength = " + Main_Form.my_properties[i].ClmnLen.ToString() + ";" + nn;
				}
				
				// Завершение определения свойств
				gen.textBox1.Text += nn;
			}
			
			// Добавление таблиц в коллекцию Tables объекта DataSet
			gen.textBox1.Text += "// Добавление таблиц в объект DataSet" + nn;
			gen.textBox1.Text += "this." + this.toolStripTextBox1.Text + ".Tables.AddRange(new DataTable[]{" + nnn;
			for(int i = 0; i < Main_Form.my_Tables.Length; i++)
			{
				if(i == (Main_Form.my_Tables.Length - 1))
				{
					gen.textBox1.Text += Main_Form.my_Tables[i].TbName + nnn;
				}else{
					gen.textBox1.Text += Main_Form.my_Tables[i].TbName + "," + nnn;
				}
			}
			gen.textBox1.Text += "});" + nn;	
			
			// Установка первичных ключей
			gen.textBox1.Text += nn;
			gen.textBox1.Text += "// Установка первичных ключей" + nn;
			int KolPK = 0;
			int Tb = 0;
			for(int i = 0; i < Main_Form.my_properties.Length; i++)
			{
				if(Main_Form.my_properties[i].ClmnPK == true)
				{
					// Фиксируем индекс таблицы
					Tb = Main_Form.my_properties[i].TbNum;
					gen.textBox1.Text += "this." + Main_Form.my_Tables[(Tb - 1)].TbName + ".PrimaryKey = new DataColumn[]{" + nnn;
					// Определение количества PK для одной таблицы
					for(int k = 0; k < Main_Form.my_properties.Length; k++)
					{
						if((Main_Form.my_properties[k].TbNum == Tb)&&(Main_Form.my_properties[k].ClmnPK == true)) KolPK++;
					}
					if(KolPK > 1) i += KolPK;
					for(int l = 0; l < Main_Form.my_properties.Length; l++)
					{
						if((Main_Form.my_properties[l].TbNum == Tb)&&(Main_Form.my_properties[l].ClmnPK == true))
						{
							if(Main_Form.my_Columns[l].TbNum == Tb)
							{
								if(KolPK == 1)
								{
									gen.textBox1.Text += Main_Form.my_Columns[l].ClmnName + nnn;
								}else{
									gen.textBox1.Text += Main_Form.my_Columns[l].ClmnName + "," + nnn;
								}
							KolPK--;
							}
						}
					}
					KolPK = 0;
					gen.textBox1.Text += "};" + nn + nn;
				}
			}
			
			// Генерация отношений и ограничений
			gen.textBox1.Text += nn;
			gen.textBox1.Text += "// Создание отношений и ограничений" + nn;
			for(int i = 0; i < Main_Form.my_Relations.Length; i++)
			{
				gen.textBox1.Text += "ForeignKeyConstraint " + Main_Form.my_Relations[i].ConstrName +
					" = new ForeignKeyConstraint(" + Main_Form.my_Relations[i].TabNameP + ".Columns[\"" + Main_Form.my_Relations[i].ClmnPsP + "\"]," + nnn;
				gen.textBox1.Text += Main_Form.my_Relations[i].TabNameC + ".Columns[\"" + Main_Form.my_Relations[i].ClmnPsC + "\"]);" + nn;
				gen.textBox1.Text += Main_Form.my_Relations[i].ConstrName + ".ConstraintName = \"" + Main_Form.my_Relations[i].ConstrPs + "\";" + nn;
				gen.textBox1.Text += Main_Form.my_Relations[i].ConstrName + ".DeleteRule = Rule." + Main_Form.my_Relations[i].DelRule + ";" + nn;
				gen.textBox1.Text += Main_Form.my_Relations[i].ConstrName + ".UpdateRule = Rule." + Main_Form.my_Relations[i].UpdRule + ";" + nn;
				gen.textBox1.Text += this.toolStripTextBox1.Text + ".Tables[\"" + Main_Form.my_Relations[i].TabPsC + "\"].Constraints.Add(" + Main_Form.my_Relations[i].ConstrName + ");" +nn;
				gen.textBox1.Text += nn;
				gen.textBox1.Text += Main_Form.my_Relations[i].DrName + " = new DataRelation(\"" + Main_Form.my_Relations[i].DrPs + "\"," + Main_Form.my_Relations[i].TabNameP + ".Columns[\"" + Main_Form.my_Relations[i].ClmnPsP + "\"]," +nnn;
				gen.textBox1.Text += Main_Form.my_Relations[i].TabNameC + ".Columns[\"" + Main_Form.my_Relations[i].ClmnPsC + "\"]);" + nn;
				gen.textBox1.Text += this.toolStripTextBox1.Text + ".Relations.Add(" + Main_Form.my_Relations[i].DrName + ");" + nn;
				gen.textBox1.Text += nn;
			}
			
			gen.textBox1.Text += this.toolStripTextBox1.Text + ".EnforceConstraints = true;";
			
			// Закрытие тела метода
			gen.textBox1.Text += n + "}";
			
			gen.textBox1.Select(0, 0);
			gen.ShowDialog();
		}
	}
}
