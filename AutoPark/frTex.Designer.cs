
namespace AutoPark
{
	partial class frTex
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frTex));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.vTEXOSMOTRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sKLDataSet = new AutoPark.SKLDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cbMonth = new System.Windows.Forms.ToolStripComboBox();
            this.txYear = new System.Windows.Forms.ToolStripTextBox();
            this.cbFILTR = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.vTEXDataGridView = new System.Windows.Forms.DataGridView();
            this.id_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Po = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTEXOSMOTRTableAdapter = new AutoPark.SKLDataSetTableAdapters.vTEXOSMOTRTableAdapter();
            this.tableAdapterManager = new AutoPark.SKLDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vTEXOSMOTRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTEXDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.vTEXOSMOTRBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.cbMonth,
            this.txYear,
            this.cbFILTR,
            this.toolStripButton4});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1371, 28);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // vTEXOSMOTRBindingSource
            // 
            this.vTEXOSMOTRBindingSource.DataMember = "vTEXOSMOTR";
            this.vTEXOSMOTRBindingSource.DataSource = this.sKLDataSet;
            // 
            // sKLDataSet
            // 
            this.sKLDataSet.DataSetName = "SKLDataSet";
            this.sKLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(61, 25);
            this.toolStripButton1.Text = "Новый";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(69, 25);
            this.toolStripButton2.Text = "Удалить";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 25);
            this.toolStripButton3.Text = "Отчет";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(160, 28);
            // 
            // txYear
            // 
            this.txYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txYear.Name = "txYear";
            this.txYear.Size = new System.Drawing.Size(132, 28);
            // 
            // cbFILTR
            // 
            this.cbFILTR.Items.AddRange(new object[] {
            "Действующие",
            "Завершенные",
            "Дата начала",
            "Дата окончания",
            "Все техосмотры"});
            this.cbFILTR.Name = "cbFILTR";
            this.cbFILTR.Size = new System.Drawing.Size(160, 28);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(73, 25);
            this.toolStripButton4.Text = "Выбрать";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // vTEXDataGridView
            // 
            this.vTEXDataGridView.AllowUserToAddRows = false;
            this.vTEXDataGridView.AllowUserToDeleteRows = false;
            this.vTEXDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vTEXDataGridView.AutoGenerateColumns = false;
            this.vTEXDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vTEXDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_code,
            this.S,
            this.Po,
            this.avto,
            this.gv,
            this.gn,
            this.vt});
            this.vTEXDataGridView.DataSource = this.vTEXOSMOTRBindingSource;
            this.vTEXDataGridView.Location = new System.Drawing.Point(0, 34);
            this.vTEXDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vTEXDataGridView.Name = "vTEXDataGridView";
            this.vTEXDataGridView.RowHeadersWidth = 51;
            this.vTEXDataGridView.Size = new System.Drawing.Size(1369, 705);
            this.vTEXDataGridView.TabIndex = 5;
            // 
            // id_code
            // 
            this.id_code.DataPropertyName = "Id";
            this.id_code.HeaderText = "Код";
            this.id_code.MinimumWidth = 6;
            this.id_code.Name = "id_code";
            this.id_code.ReadOnly = true;
            this.id_code.Width = 125;
            // 
            // S
            // 
            this.S.DataPropertyName = "DATE_S";
            this.S.HeaderText = "Дата начала";
            this.S.MinimumWidth = 6;
            this.S.Name = "S";
            this.S.Width = 125;
            // 
            // Po
            // 
            this.Po.DataPropertyName = "DATE_PO";
            this.Po.HeaderText = "Дата окончания";
            this.Po.MinimumWidth = 6;
            this.Po.Name = "Po";
            this.Po.Width = 125;
            // 
            // avto
            // 
            this.avto.DataPropertyName = "PTNAME";
            this.avto.HeaderText = "Автотранспорт";
            this.avto.MinimumWidth = 6;
            this.avto.Name = "avto";
            this.avto.Width = 125;
            // 
            // gv
            // 
            this.gv.DataPropertyName = "PTGODVYP";
            this.gv.HeaderText = "Год выпуска";
            this.gv.MinimumWidth = 6;
            this.gv.Name = "gv";
            this.gv.Width = 125;
            // 
            // gn
            // 
            this.gn.DataPropertyName = "PTGOSNOMER";
            this.gn.HeaderText = "Гос. номер";
            this.gn.MinimumWidth = 6;
            this.gn.Name = "gn";
            this.gn.Width = 125;
            // 
            // vt
            // 
            this.vt.DataPropertyName = "PTVIDTOPLIVA";
            this.vt.HeaderText = "Вид топлива";
            this.vt.MinimumWidth = 6;
            this.vt.Name = "vt";
            this.vt.Width = 125;
            // 
            // vTEXOSMOTRTableAdapter
            // 
            this.vTEXOSMOTRTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.TEXOSMOTRTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AutoPark.SKLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frTex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 738);
            this.Controls.Add(this.vTEXDataGridView);
            this.Controls.Add(this.bindingNavigator1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frTex";
            this.Text = "Техосмотры";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frTex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vTEXOSMOTRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTEXDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingNavigator bindingNavigator1;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripComboBox cbMonth;
		private System.Windows.Forms.ToolStripTextBox txYear;
		private System.Windows.Forms.ToolStripComboBox cbFILTR;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.DataGridView vTEXDataGridView;
		private SKLDataSet sKLDataSet;
		private System.Windows.Forms.BindingSource vTEXOSMOTRBindingSource;
		private SKLDataSetTableAdapters.vTEXOSMOTRTableAdapter vTEXOSMOTRTableAdapter;
		private SKLDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_code;
		private System.Windows.Forms.DataGridViewTextBoxColumn S;
		private System.Windows.Forms.DataGridViewTextBoxColumn Po;
		private System.Windows.Forms.DataGridViewTextBoxColumn avto;
		private System.Windows.Forms.DataGridViewTextBoxColumn gv;
		private System.Windows.Forms.DataGridViewTextBoxColumn gn;
		private System.Windows.Forms.DataGridViewTextBoxColumn vt;
	}
}