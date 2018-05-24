/*
 * Сделано в SharpDevelop.
 * Пользователь: Asus
 * Дата: 02.04.2018
 * Время: 13:43
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace GenMeth
{
	partial class Propertys
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Propertys));
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.первичныйКлючToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.внешнийКлючToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.столбецДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.выйтиИзРедактораСвойствToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
			this.toolStripContainer1.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 237);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.Size = new System.Drawing.Size(784, 262);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1,
									this.toolStripStatusLabel2});
			this.statusStrip1.Location = new System.Drawing.Point(0, 0);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(784, 22);
			this.statusStrip1.TabIndex = 1;
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3,
									this.Column5,
									this.Column6,
									this.Column7,
									this.Column4,
									this.Column8,
									this.Column10,
									this.Column11,
									this.Column9});
			this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(784, 237);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellValueChanged);
			this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.DataGridView1CurrentCellChanged);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Таблица";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Столбец";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Псевдоним столбца";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "PK";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 25;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "FK";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 25;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "DT";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column7.Width = 25;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Тип данных";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Размер";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Column10
			// 
			this.Column10.HeaderText = "AiStart";
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column10.Width = 50;
			// 
			// Column11
			// 
			this.Column11.HeaderText = "AiStep";
			this.Column11.Name = "Column11";
			this.Column11.ReadOnly = true;
			this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column11.Width = 50;
			// 
			// Column9
			// 
			this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column9.HeaderText = "Выражение";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.первичныйКлючToolStripMenuItem,
									this.внешнийКлючToolStripMenuItem,
									this.столбецДанныхToolStripMenuItem,
									this.toolStripMenuItem1,
									this.выйтиИзРедактораСвойствToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(230, 120);
			// 
			// первичныйКлючToolStripMenuItem
			// 
			this.первичныйКлючToolStripMenuItem.Name = "первичныйКлючToolStripMenuItem";
			this.первичныйКлючToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.первичныйКлючToolStripMenuItem.Text = "Первичный ключ";
			this.первичныйКлючToolStripMenuItem.Click += new System.EventHandler(this.ПервичныйКлючToolStripMenuItemClick);
			// 
			// внешнийКлючToolStripMenuItem
			// 
			this.внешнийКлючToolStripMenuItem.Name = "внешнийКлючToolStripMenuItem";
			this.внешнийКлючToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.внешнийКлючToolStripMenuItem.Text = "Внешний ключ";
			this.внешнийКлючToolStripMenuItem.Click += new System.EventHandler(this.ВнешнийКлючToolStripMenuItemClick);
			// 
			// столбецДанныхToolStripMenuItem
			// 
			this.столбецДанныхToolStripMenuItem.Name = "столбецДанныхToolStripMenuItem";
			this.столбецДанныхToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.столбецДанныхToolStripMenuItem.Text = "Столбец данных";
			this.столбецДанныхToolStripMenuItem.Click += new System.EventHandler(this.СтолбецДанныхToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(226, 6);
			// 
			// выйтиИзРедактораСвойствToolStripMenuItem
			// 
			this.выйтиИзРедактораСвойствToolStripMenuItem.Name = "выйтиИзРедактораСвойствToolStripMenuItem";
			this.выйтиИзРедактораСвойствToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.выйтиИзРедактораСвойствToolStripMenuItem.Text = "Выйти из редактора свойств";
			this.выйтиИзРедактораСвойствToolStripMenuItem.Click += new System.EventHandler(this.ВыйтиИзРедактораСвойствToolStripMenuItemClick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButton1,
									this.toolStripButton2});
			this.toolStrip1.Location = new System.Drawing.Point(53, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(58, 25);
			this.toolStrip1.TabIndex = 2;
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.ToolTipText = "Выход";
			this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.ToolTipText = "Редактировать свойства";
			this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2Click);
			// 
			// Propertys
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 262);
			this.ControlBox = false;
			this.Controls.Add(this.toolStripContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Propertys";
			this.Text = "Коллекция свойств";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.PropertysLoad);
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolStripMenuItem выйтиИзРедактораСвойствToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem столбецДанныхToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem внешнийКлючToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem первичныйКлючToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		public System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
	}
}
