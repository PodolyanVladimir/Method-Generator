/*
 * Сделано в SharpDevelop.
 * Пользователь: Asus
 * Дата: 25.04.2018
 * Время: 13:31
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
	partial class RelationsColl
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelationsColl));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 316);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1157, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripContainer1
			// 
			this.toolStripContainer1.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1157, 291);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.Size = new System.Drawing.Size(1157, 316);
			this.toolStripContainer1.TabIndex = 1;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InfoText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column4,
									this.Column5,
									this.Column11,
									this.Column15,
									this.Column3,
									this.Column13,
									this.Column12,
									this.Column16,
									this.Column6,
									this.Column14,
									this.Column7,
									this.Column17,
									this.Column8,
									this.Column18,
									this.Column9,
									this.Column10});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.ReadOnly = true;
			this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.Size = new System.Drawing.Size(1157, 291);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellValueChanged);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "№тР";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column1.Visible = false;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "№сР";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column2.Visible = false;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "№тД";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column4.Visible = false;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "№сД";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column5.Visible = false;
			// 
			// Column11
			// 
			this.Column11.HeaderText = "Родительская таблица";
			this.Column11.Name = "Column11";
			this.Column11.ReadOnly = true;
			this.Column11.Width = 150;
			// 
			// Column15
			// 
			this.Column15.HeaderText = "Псевдоним род. таблицы";
			this.Column15.Name = "Column15";
			this.Column15.ReadOnly = true;
			this.Column15.Visible = false;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Первичный ключ";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column3.Width = 140;
			// 
			// Column13
			// 
			this.Column13.HeaderText = "Псевдоним PK";
			this.Column13.Name = "Column13";
			this.Column13.ReadOnly = true;
			this.Column13.Visible = false;
			// 
			// Column12
			// 
			this.Column12.HeaderText = "Дочерняя таблица";
			this.Column12.Name = "Column12";
			this.Column12.ReadOnly = true;
			this.Column12.Width = 140;
			// 
			// Column16
			// 
			this.Column16.HeaderText = "Псевдоним Доч. таблицы";
			this.Column16.Name = "Column16";
			this.Column16.ReadOnly = true;
			this.Column16.Visible = false;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Внешний ключ";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column6.Width = 140;
			// 
			// Column14
			// 
			this.Column14.HeaderText = "Псевдоним FK";
			this.Column14.Name = "Column14";
			this.Column14.ReadOnly = true;
			this.Column14.Visible = false;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Имя отношения";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Column17
			// 
			this.Column17.HeaderText = "Псевдоним отношения";
			this.Column17.Name = "Column17";
			this.Column17.ReadOnly = true;
			this.Column17.Visible = false;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Имя ограничения";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column8.Width = 110;
			// 
			// Column18
			// 
			this.Column18.HeaderText = "Псевдоним ограничения";
			this.Column18.Name = "Column18";
			this.Column18.ReadOnly = true;
			this.Column18.Visible = false;
			// 
			// Column9
			// 
			this.Column9.HeaderText = "Правило удаления";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column9.Width = 110;
			// 
			// Column10
			// 
			this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column10.HeaderText = "Правило обновления";
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButton1,
									this.toolStripButton4,
									this.toolStripButton2,
									this.toolStripButton3});
			this.toolStrip1.Location = new System.Drawing.Point(4, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(104, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.ToolTipText = "Выйти из редактора отношений";
			this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1Click);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton4.ToolTipText = "Добавить отношение";
			this.toolStripButton4.Click += new System.EventHandler(this.ToolStripButton4Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.ToolTipText = "Редактировать отношение";
			this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2Click);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton3.ToolTipText = "Удалить отношение";
			this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3Click);
			// 
			// RelationsColl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1157, 338);
			this.ControlBox = false;
			this.Controls.Add(this.toolStripContainer1);
			this.Controls.Add(this.statusStrip1);
			this.Name = "RelationsColl";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Коллекция отношений";
			this.Load += new System.EventHandler(this.RelationsCollLoad);
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		public System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
