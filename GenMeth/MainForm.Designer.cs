/*
 * Сделано в SharpDevelop.
 * Пользователь: ТМ
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
 
namespace GenMeth
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.создатьРешениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьРешениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.сохранитьРешениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.добавитьИмяТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.изменитьИмяТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.удалитьИмяТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.столбцыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.добавитьИмяСтолбцаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.изменитьИмяСтолбцаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.удалитьИмяСтолбцаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.проектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.режимРедакторасвойствToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.режимРедактораотношенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.выполнитьГенерациюМетодаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вызватьСправкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip2 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.показатьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip3 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.statusStrip2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.statusStrip3.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.файлToolStripMenuItem,
									this.таблицыToolStripMenuItem,
									this.столбцыToolStripMenuItem,
									this.проектToolStripMenuItem,
									this.справкаToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(825, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.создатьРешениеToolStripMenuItem,
									this.открытьРешениеToolStripMenuItem,
									this.toolStripMenuItem1,
									this.сохранитьРешениеToolStripMenuItem,
									this.toolStripMenuItem2,
									this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.файлToolStripMenuItem.Text = "&Файл";
			// 
			// создатьРешениеToolStripMenuItem
			// 
			this.создатьРешениеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("создатьРешениеToolStripMenuItem.Image")));
			this.создатьРешениеToolStripMenuItem.Name = "создатьРешениеToolStripMenuItem";
			this.создатьРешениеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.создатьРешениеToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
			this.создатьРешениеToolStripMenuItem.Text = "Со&здать решение";
			this.создатьРешениеToolStripMenuItem.Click += new System.EventHandler(this.СоздатьРешениеToolStripMenuItemClick);
			// 
			// открытьРешениеToolStripMenuItem
			// 
			this.открытьРешениеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьРешениеToolStripMenuItem.Image")));
			this.открытьРешениеToolStripMenuItem.Name = "открытьРешениеToolStripMenuItem";
			this.открытьРешениеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.открытьРешениеToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
			this.открытьРешениеToolStripMenuItem.Text = "&Открыть решение";
			this.открытьРешениеToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьРешениеToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 6);
			// 
			// сохранитьРешениеToolStripMenuItem
			// 
			this.сохранитьРешениеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьРешениеToolStripMenuItem.Image")));
			this.сохранитьРешениеToolStripMenuItem.Name = "сохранитьРешениеToolStripMenuItem";
			this.сохранитьРешениеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.сохранитьРешениеToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
			this.сохранитьРешениеToolStripMenuItem.Text = "Со&хранить решение";
			this.сохранитьРешениеToolStripMenuItem.Click += new System.EventHandler(this.СохранитьРешениеToolStripMenuItemClick);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 6);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
			this.выходToolStripMenuItem.Text = "В&ыход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItemClick);
			// 
			// таблицыToolStripMenuItem
			// 
			this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.добавитьИмяТаблицыToolStripMenuItem,
									this.изменитьИмяТаблицыToolStripMenuItem,
									this.toolStripMenuItem3,
									this.удалитьИмяТаблицыToolStripMenuItem});
			this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
			this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.таблицыToolStripMenuItem.Text = "&Таблицы";
			// 
			// добавитьИмяТаблицыToolStripMenuItem
			// 
			this.добавитьИмяТаблицыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("добавитьИмяТаблицыToolStripMenuItem.Image")));
			this.добавитьИмяТаблицыToolStripMenuItem.Name = "добавитьИмяТаблицыToolStripMenuItem";
			this.добавитьИмяТаблицыToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.добавитьИмяТаблицыToolStripMenuItem.Text = "Добавить имя таблицы";
			this.добавитьИмяТаблицыToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьИмяТаблицыToolStripMenuItemClick);
			// 
			// изменитьИмяТаблицыToolStripMenuItem
			// 
			this.изменитьИмяТаблицыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("изменитьИмяТаблицыToolStripMenuItem.Image")));
			this.изменитьИмяТаблицыToolStripMenuItem.Name = "изменитьИмяТаблицыToolStripMenuItem";
			this.изменитьИмяТаблицыToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.изменитьИмяТаблицыToolStripMenuItem.Text = "Изменить имя таблицы";
			this.изменитьИмяТаблицыToolStripMenuItem.Click += new System.EventHandler(this.ИзменитьИмяТаблицыToolStripMenuItemClick);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(189, 6);
			// 
			// удалитьИмяТаблицыToolStripMenuItem
			// 
			this.удалитьИмяТаблицыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("удалитьИмяТаблицыToolStripMenuItem.Image")));
			this.удалитьИмяТаблицыToolStripMenuItem.Name = "удалитьИмяТаблицыToolStripMenuItem";
			this.удалитьИмяТаблицыToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.удалитьИмяТаблицыToolStripMenuItem.Text = "Удалить имя таблицы";
			this.удалитьИмяТаблицыToolStripMenuItem.Click += new System.EventHandler(this.УдалитьИмяТаблицыToolStripMenuItemClick);
			// 
			// столбцыToolStripMenuItem
			// 
			this.столбцыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.добавитьИмяСтолбцаToolStripMenuItem,
									this.изменитьИмяСтолбцаToolStripMenuItem,
									this.toolStripMenuItem4,
									this.удалитьИмяСтолбцаToolStripMenuItem});
			this.столбцыToolStripMenuItem.Name = "столбцыToolStripMenuItem";
			this.столбцыToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.столбцыToolStripMenuItem.Text = "&Столбцы";
			// 
			// добавитьИмяСтолбцаToolStripMenuItem
			// 
			this.добавитьИмяСтолбцаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("добавитьИмяСтолбцаToolStripMenuItem.Image")));
			this.добавитьИмяСтолбцаToolStripMenuItem.Name = "добавитьИмяСтолбцаToolStripMenuItem";
			this.добавитьИмяСтолбцаToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.добавитьИмяСтолбцаToolStripMenuItem.Text = "Добавить имя столбца";
			this.добавитьИмяСтолбцаToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьИмяСтолбцаToolStripMenuItemClick);
			// 
			// изменитьИмяСтолбцаToolStripMenuItem
			// 
			this.изменитьИмяСтолбцаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("изменитьИмяСтолбцаToolStripMenuItem.Image")));
			this.изменитьИмяСтолбцаToolStripMenuItem.Name = "изменитьИмяСтолбцаToolStripMenuItem";
			this.изменитьИмяСтолбцаToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.изменитьИмяСтолбцаToolStripMenuItem.Text = "Изменить имя столбца";
			this.изменитьИмяСтолбцаToolStripMenuItem.Click += new System.EventHandler(this.ИзменитьИмяСтолбцаToolStripMenuItemClick);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(186, 6);
			// 
			// удалитьИмяСтолбцаToolStripMenuItem
			// 
			this.удалитьИмяСтолбцаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("удалитьИмяСтолбцаToolStripMenuItem.Image")));
			this.удалитьИмяСтолбцаToolStripMenuItem.Name = "удалитьИмяСтолбцаToolStripMenuItem";
			this.удалитьИмяСтолбцаToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.удалитьИмяСтолбцаToolStripMenuItem.Text = "Удалить имя столбца";
			this.удалитьИмяСтолбцаToolStripMenuItem.Click += new System.EventHandler(this.УдалитьИмяСтолбцаToolStripMenuItemClick);
			// 
			// проектToolStripMenuItem
			// 
			this.проектToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.режимРедакторасвойствToolStripMenuItem,
									this.режимРедактораотношенийToolStripMenuItem,
									this.toolStripMenuItem5,
									this.выполнитьГенерациюМетодаToolStripMenuItem});
			this.проектToolStripMenuItem.Name = "проектToolStripMenuItem";
			this.проектToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.проектToolStripMenuItem.Text = "&Проект";
			// 
			// режимРедакторасвойствToolStripMenuItem
			// 
			this.режимРедакторасвойствToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("режимРедакторасвойствToolStripMenuItem.Image")));
			this.режимРедакторасвойствToolStripMenuItem.Name = "режимРедакторасвойствToolStripMenuItem";
			this.режимРедакторасвойствToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.режимРедакторасвойствToolStripMenuItem.Text = "Редактор &свойств";
			this.режимРедакторасвойствToolStripMenuItem.Click += new System.EventHandler(this.РежимРедакторасвойствToolStripMenuItemClick);
			// 
			// режимРедактораотношенийToolStripMenuItem
			// 
			this.режимРедактораотношенийToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("режимРедактораотношенийToolStripMenuItem.Image")));
			this.режимРедактораотношенийToolStripMenuItem.Name = "режимРедактораотношенийToolStripMenuItem";
			this.режимРедактораотношенийToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.режимРедактораотношенийToolStripMenuItem.Text = "Редактор &отношений";
			this.режимРедактораотношенийToolStripMenuItem.Click += new System.EventHandler(this.РежимРедактораотношенийToolStripMenuItemClick);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(226, 6);
			// 
			// выполнитьГенерациюМетодаToolStripMenuItem
			// 
			this.выполнитьГенерациюМетодаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выполнитьГенерациюМетодаToolStripMenuItem.Image")));
			this.выполнитьГенерациюМетодаToolStripMenuItem.Name = "выполнитьГенерациюМетодаToolStripMenuItem";
			this.выполнитьГенерациюМетодаToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.выполнитьГенерациюМетодаToolStripMenuItem.Text = "Выполнить генерацию метода";
			this.выполнитьГенерациюМетодаToolStripMenuItem.Click += new System.EventHandler(this.ВыполнитьГенерациюМетодаToolStripMenuItemClick);
			// 
			// справкаToolStripMenuItem
			// 
			this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.вызватьСправкуToolStripMenuItem,
									this.toolStripMenuItem6,
									this.оПрограммеToolStripMenuItem});
			this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
			this.справкаToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.справкаToolStripMenuItem.Text = "Спра&вка";
			// 
			// вызватьСправкуToolStripMenuItem
			// 
			this.вызватьСправкуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вызватьСправкуToolStripMenuItem.Image")));
			this.вызватьСправкуToolStripMenuItem.Name = "вызватьСправкуToolStripMenuItem";
			this.вызватьСправкуToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.вызватьСправкуToolStripMenuItem.Text = "В&ызвать справку";
			this.вызватьСправкуToolStripMenuItem.Click += new System.EventHandler(this.ВызватьСправкуToolStripMenuItemClick);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(158, 6);
			// 
			// оПрограммеToolStripMenuItem
			// 
			this.оПрограммеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("оПрограммеToolStripMenuItem.Image")));
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.оПрограммеToolStripMenuItem.Text = "&О программе";
			this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItemClick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButton1,
									this.toolStripButton2,
									this.toolStripSeparator1,
									this.toolStripButton3,
									this.toolStripSeparator2,
									this.toolStripLabel1,
									this.toolStripButton4,
									this.toolStripButton5,
									this.toolStripButton6,
									this.toolStripSeparator3,
									this.toolStripLabel2,
									this.toolStripButton7,
									this.toolStripButton8,
									this.toolStripButton9,
									this.toolStripSeparator4,
									this.toolStripLabel3,
									this.toolStripButton10,
									this.toolStripButton11,
									this.toolStripSeparator5,
									this.toolStripTextBox1,
									this.toolStripButton12,
									this.toolStripSeparator6,
									this.toolStripTextBox2,
									this.toolStripButton13,
									this.toolStripSeparator7});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(825, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.ToolTipText = "Создать новое решение";
			this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "toolStripButton2";
			this.toolStripButton2.ToolTipText = "Открыть решение";
			this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton3.Text = "toolStripButton3";
			this.toolStripButton3.ToolTipText = "Сохранить решение";
			this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(51, 22);
			this.toolStripLabel1.Text = "Таблицы";
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton4.Text = "toolStripButton4";
			this.toolStripButton4.ToolTipText = "Добавить имя таблицы";
			this.toolStripButton4.Click += new System.EventHandler(this.ToolStripButton4Click);
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton5.Text = "toolStripButton5";
			this.toolStripButton5.ToolTipText = "Изменить имя таблицы";
			this.toolStripButton5.Click += new System.EventHandler(this.ToolStripButton5Click);
			// 
			// toolStripButton6
			// 
			this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
			this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton6.Name = "toolStripButton6";
			this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton6.Text = "toolStripButton6";
			this.toolStripButton6.ToolTipText = "Удалить имя таблицы";
			this.toolStripButton6.Click += new System.EventHandler(this.ToolStripButton6Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(52, 22);
			this.toolStripLabel2.Text = "Столбцы";
			// 
			// toolStripButton7
			// 
			this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
			this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton7.Name = "toolStripButton7";
			this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton7.Text = "toolStripButton7";
			this.toolStripButton7.ToolTipText = "Добавить имя столбца";
			this.toolStripButton7.Click += new System.EventHandler(this.ToolStripButton7Click);
			// 
			// toolStripButton8
			// 
			this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
			this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton8.Name = "toolStripButton8";
			this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton8.Text = "toolStripButton8";
			this.toolStripButton8.ToolTipText = "Изменить имя столбца";
			this.toolStripButton8.Click += new System.EventHandler(this.ToolStripButton8Click);
			// 
			// toolStripButton9
			// 
			this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
			this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton9.Name = "toolStripButton9";
			this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton9.Text = "toolStripButton9";
			this.toolStripButton9.ToolTipText = "Удалить имя столбца";
			this.toolStripButton9.Click += new System.EventHandler(this.ToolStripButton9Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(110, 22);
			this.toolStripLabel3.Text = "Индексация ключей";
			// 
			// toolStripButton10
			// 
			this.toolStripButton10.Checked = true;
			this.toolStripButton10.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton10.Name = "toolStripButton10";
			this.toolStripButton10.Size = new System.Drawing.Size(36, 22);
			this.toolStripButton10.Text = "GUID";
			this.toolStripButton10.ToolTipText = "Технология индексации ключей GUID (Рекомендуется)";
			this.toolStripButton10.Click += new System.EventHandler(this.ToolStripButton10Click);
			// 
			// toolStripButton11
			// 
			this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton11.Name = "toolStripButton11";
			this.toolStripButton11.Size = new System.Drawing.Size(49, 22);
			this.toolStripButton11.Text = "AutoInc";
			this.toolStripButton11.ToolTipText = "Технология индексации ключей AutoIncrement";
			this.toolStripButton11.Click += new System.EventHandler(this.ToolStripButton11Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.ReadOnly = true;
			this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
			this.toolStripTextBox1.Text = "dataSet1";
			this.toolStripTextBox1.ToolTipText = "Имя объекта класса DataSet";
			// 
			// toolStripButton12
			// 
			this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
			this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton12.Name = "toolStripButton12";
			this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton12.Text = "toolStripButton12";
			this.toolStripButton12.ToolTipText = "Изменить имя объекта класса DataSet";
			this.toolStripButton12.Click += new System.EventHandler(this.ToolStripButton12Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripTextBox2
			// 
			this.toolStripTextBox2.Name = "toolStripTextBox2";
			this.toolStripTextBox2.ReadOnly = true;
			this.toolStripTextBox2.Size = new System.Drawing.Size(100, 25);
			this.toolStripTextBox2.Text = "CreateDataSet";
			this.toolStripTextBox2.ToolTipText = "Имя метода создания объекта класса DataSet";
			// 
			// toolStripButton13
			// 
			this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
			this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton13.Name = "toolStripButton13";
			this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton13.Text = "toolStripButton13";
			this.toolStripButton13.ToolTipText = "Изменить имя метода создания объекта класса DataSet";
			this.toolStripButton13.Click += new System.EventHandler(this.ToolStripButton13Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel3});
			this.statusStrip1.Location = new System.Drawing.Point(0, 540);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(825, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 49);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
			this.splitContainer1.Panel1.Controls.Add(this.statusStrip2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
			this.splitContainer1.Panel2.Controls.Add(this.statusStrip3);
			this.splitContainer1.Size = new System.Drawing.Size(825, 491);
			this.splitContainer1.SplitterDistance = 380;
			this.splitContainer1.TabIndex = 5;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column4});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(380, 469);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellClick);
			this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellValueChanged);
			this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.DataGridView1CurrentCellChanged);
			this.dataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1DoubleClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "№ т";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column1.Width = 35;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Имя объекта таблицы";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column2.Width = 150;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column4.HeaderText = "Псевдоним таблицы";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// statusStrip2
			// 
			this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1});
			this.statusStrip2.Location = new System.Drawing.Point(0, 469);
			this.statusStrip2.Name = "statusStrip2";
			this.statusStrip2.Size = new System.Drawing.Size(380, 22);
			this.statusStrip2.TabIndex = 2;
			this.statusStrip2.Text = "statusStrip2";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn1,
									this.dataGridViewTextBoxColumn2,
									this.Column3,
									this.dataGridViewTextBoxColumn3});
			this.dataGridView2.ContextMenuStrip = this.contextMenuStrip1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(0, 0);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.RowHeadersVisible = false;
			this.dataGridView2.Size = new System.Drawing.Size(441, 469);
			this.dataGridView2.TabIndex = 3;
			this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2CellContentClick);
			this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2CellValueChanged);
			this.dataGridView2.CurrentCellChanged += new System.EventHandler(this.DataGridView2CurrentCellChanged);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "№ т";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn1.Width = 35;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "№ с";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn2.Width = 35;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Имя объекта столбца";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column3.Width = 150;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.HeaderText = "Псевдоним столбца";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.показатьВсёToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(143, 26);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1Opening);
			// 
			// показатьВсёToolStripMenuItem
			// 
			this.показатьВсёToolStripMenuItem.Name = "показатьВсёToolStripMenuItem";
			this.показатьВсёToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.показатьВсёToolStripMenuItem.Text = "Показать всё";
			this.показатьВсёToolStripMenuItem.Click += new System.EventHandler(this.ПоказатьВсёToolStripMenuItemClick);
			// 
			// statusStrip3
			// 
			this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel2});
			this.statusStrip3.Location = new System.Drawing.Point(0, 469);
			this.statusStrip3.Name = "statusStrip3";
			this.statusStrip3.Size = new System.Drawing.Size(441, 22);
			this.statusStrip3.TabIndex = 2;
			this.statusStrip3.Text = "statusStrip3";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "TXT files|*.txt";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "TXT files|*.txt";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(825, 562);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Генератор методов создания объектов класса DataSet";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.statusStrip2.ResumeLayout(false);
			this.statusStrip2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.statusStrip3.ResumeLayout(false);
			this.statusStrip3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
		public System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		public System.Windows.Forms.ToolStripMenuItem вызватьСправкуToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
		public System.Windows.Forms.OpenFileDialog openFileDialog1;
		public System.Windows.Forms.SaveFileDialog saveFileDialog1;
		public System.Windows.Forms.ToolStripMenuItem выполнитьГенерациюМетодаToolStripMenuItem;
		public System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		public System.Windows.Forms.ToolStripMenuItem показатьВсёToolStripMenuItem;
		public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		public System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		public System.Windows.Forms.StatusStrip statusStrip3;
		public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		public System.Windows.Forms.StatusStrip statusStrip2;
		public System.Windows.Forms.ToolStripMenuItem режимРедактораотношенийToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem режимРедакторасвойствToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem проектToolStripMenuItem;
		public System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		public System.Windows.Forms.ToolStripButton toolStripButton13;
		public System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		public System.Windows.Forms.ToolStripButton toolStripButton12;
		public System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
		public System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
		public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		public System.Windows.Forms.ToolStripButton toolStripButton11;
		public System.Windows.Forms.ToolStripButton toolStripButton10;
		public System.Windows.Forms.ToolStripLabel toolStripLabel3;
		public System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		public System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		public System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		public System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		public System.Windows.Forms.StatusStrip statusStrip1;
		public System.Windows.Forms.ToolStripMenuItem удалитьИмяСтолбцаToolStripMenuItem;
		public System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		public System.Windows.Forms.ToolStripMenuItem изменитьИмяСтолбцаToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem добавитьИмяСтолбцаToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem столбцыToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem удалитьИмяТаблицыToolStripMenuItem;
		public System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		public System.Windows.Forms.ToolStripMenuItem изменитьИмяТаблицыToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem добавитьИмяТаблицыToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
		public System.Windows.Forms.ToolStripButton toolStripButton9;
		public System.Windows.Forms.ToolStripButton toolStripButton8;
		public System.Windows.Forms.ToolStripButton toolStripButton7;
		public System.Windows.Forms.ToolStripLabel toolStripLabel2;
		public System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		public System.Windows.Forms.ToolStripButton toolStripButton6;
		public System.Windows.Forms.ToolStripButton toolStripButton5;
		public System.Windows.Forms.ToolStripButton toolStripButton4;
		public System.Windows.Forms.ToolStripLabel toolStripLabel1;
		public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		public System.Windows.Forms.ToolStripButton toolStripButton3;
		public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		public System.Windows.Forms.ToolStripButton toolStripButton2;
		public System.Windows.Forms.ToolStripButton toolStripButton1;
		public System.Windows.Forms.ToolStrip toolStrip1;
		public System.Windows.Forms.DataGridView dataGridView2;
		public System.Windows.Forms.DataGridView dataGridView1;
		public System.Windows.Forms.SplitContainer splitContainer1;
		public System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		public System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		public System.Windows.Forms.ToolStripMenuItem сохранитьРешениеToolStripMenuItem;
		public System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		public System.Windows.Forms.ToolStripMenuItem открытьРешениеToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem создатьРешениеToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		public System.Windows.Forms.MenuStrip menuStrip1;
	}
}
