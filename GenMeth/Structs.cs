/*
 * Сделано в SharpDevelop.
 * Пользователь: Asus
 * Дата: 23.03.2018
 * Время: 7:53
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;

namespace GenMeth
{
	/// <summary>
	/// Description of Structs.
	/// </summary>
	
	// Структура коллекции таблиц
	public struct Tbls
	{
		public int TbNum;			// Номер таблицы
		public string TbName;		// Имя таблицы
		public string TbComment;	// Комментарий
		
		public Tbls(int a, string b, string c)
		{
			TbNum = a;
			TbName = b;
			TbComment = c;
		}
	}
	
	// Структура коллекции столбцов
	public struct Clmns
	{
		public int TbNum;			// Номер таблицы
		public int ClmnNum;			// Номер столбца
		public string ClmnName;		// Имя столбца
		public string ClmnComment;	// Комментарий
		
		public Clmns(int a, int b, string c, string d)
		{
			TbNum = a;
			ClmnNum = b;
			ClmnName = c;
			ClmnComment = d;
		}
	}
	
	// Структура коллекции свойств столбцов
	public struct ClmnProp
	{
		public int TbNum;				// Номер таблицы
		public int ClmnNum;			// Номер столбца
		public string ClmnCaption;		// Заголовок столбца
		public string ClmnType;			// Тип данных
		public bool ClmnPK;			// Первичный ключ
		public bool ClmnFK;			// Внешний ключ
		public bool ClmnDT;			// Столбец данных
		public int ClmnLen;			// Размер ячейки
		public int AiStart;			// Начальное значение автоинкремента
		public int AiStep;				// Шаг автоинкремента
		public string ClmnExpr;		// Выражение
		
		public ClmnProp(int a, int b, string c, string d,
		            bool e, bool f, bool g, int h, int i, int j, string k)
		{
			TbNum = a;
			ClmnNum = b;
			ClmnCaption = c;
			ClmnType = d;
			ClmnPK = e;
			ClmnFK = f;
			ClmnDT = g;
			ClmnLen = h;
			AiStart = i;
			AiStep = j;
			ClmnExpr = k;
		}
		
		public ClmnProp(int a, int b, string c)
		{
			TbNum = a;
			ClmnNum = b;
			ClmnCaption = c;
			ClmnType = "";
			ClmnPK = false;
			ClmnFK = false;
			ClmnDT = false;
			ClmnLen = 0;
			AiStart = 0;
			AiStep = 0;
			ClmnExpr = "";
		}
	}
	
	// Структура коллекции отношений
	public struct Rels
	{
		public int TabNumP;			// Номер родительской таблицы
		public string TabNameP;		// Имя родительской таблицы
		public string TabPsP;		// Псевдоним родительской таблицы
		public int ClmnNumP;		// Номер первичного ключа
		public string ClmnNameP;	// Имя первичного ключа
		public string ClmnPsP;		// Псевдоним первичного ключа
		
		public int TabNumC;			// Номер дочерней таблицы
		public string TabNameC;		// Имя дочерней таблицы
		public string TabPsC;		// Псевдоним дочерней таблицы
		public int ClmnNumC;		// Номер внешнего ключа
		public string ClmnNameC;	// Имя внешнего ключа
		public string ClmnPsC;		// Псевдоним внешнего ключа
		
		public string DrName;		// Имя реляционного отношения
		public string DrPs;			// Псевдоним реляционного отношения
		public string ConstrName;	// Имя ограничения
		public string ConstrPs;		// Псевдоним ограничения
		public string DelRule;		// Правило для удаления
		public string UpdRule;		// Правило для обновления
		
		public Rels(int a,
		            string b,
		            string c,
		            int d,
		            string e,
		            string f,
		            int g,
		            string h,
		            string i,
		            int j,
		            string k,
		            string l,
		            string m,
		            string n,
		            string o,
		            string p,
		            string q,
		            string r
					)
		{
			TabNumP = a;
			TabNameP = b;
			TabPsP = c;
			ClmnNumP = d;
			ClmnNameP = e;
			ClmnPsP = f;		
			TabNumC = g;
			TabNameC = h;
			TabPsC = i;
			ClmnNumC = j;
			ClmnNameC = k;
			ClmnPsC = l;
			DrName = m;
			DrPs = n;
			ConstrName = o;
			ConstrPs = p;
			DelRule = q;
			UpdRule = r;
		}
	}
}
