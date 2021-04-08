namespace AutoPark
{
    partial class frPotr
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frPotr));
			this.grPotr = new System.Windows.Forms.DataGridView();
			this.pOTRBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.potrDataSet = new AutoPark.potrDataSet();
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.pOTRTableAdapter = new AutoPark.potrDataSetTableAdapters.POTRTableAdapter();
			this.id_pt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PTGODVYP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PTGOSNOMER = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PTVIDTOPLIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.grPotr)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pOTRBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.potrDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grPotr
			// 
			this.grPotr.AllowUserToAddRows = false;
			this.grPotr.AllowUserToDeleteRows = false;
			this.grPotr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grPotr.AutoGenerateColumns = false;
			this.grPotr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grPotr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pt,
            this.pTNAMEDataGridViewTextBoxColumn,
            this.PTGODVYP,
            this.PTGOSNOMER,
            this.PTVIDTOPLIVA});
			this.grPotr.DataSource = this.pOTRBindingSource;
			this.grPotr.Location = new System.Drawing.Point(12, 28);
			this.grPotr.Name = "grPotr";
			this.grPotr.ReadOnly = true;
			this.grPotr.Size = new System.Drawing.Size(596, 172);
			this.grPotr.TabIndex = 0;
			// 
			// pOTRBindingSource
			// 
			this.pOTRBindingSource.DataMember = "POTR";
			this.pOTRBindingSource.DataSource = this.potrDataSet;
			// 
			// potrDataSet
			// 
			this.potrDataSet.DataSetName = "potrDataSet";
			this.potrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = null;
			this.bindingNavigator1.BindingSource = this.pOTRBindingSource;
			this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator1.DeleteItem = null;
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
            this.toolStripButton2});
			this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
			this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator1.Name = "bindingNavigator1";
			this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator1.Size = new System.Drawing.Size(620, 25);
			this.bindingNavigator1.TabIndex = 2;
			this.bindingNavigator1.Text = "bindingNavigator1";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Положение";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(49, 22);
			this.toolStripButton1.Text = "Новый";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(55, 22);
			this.toolStripButton2.Text = "Удалить";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// pOTRTableAdapter
			// 
			this.pOTRTableAdapter.ClearBeforeFill = true;
			// 
			// id_pt
			// 
			this.id_pt.DataPropertyName = "ID_PT";
			this.id_pt.HeaderText = "Код";
			this.id_pt.Name = "id_pt";
			this.id_pt.ReadOnly = true;
			// 
			// pTNAMEDataGridViewTextBoxColumn
			// 
			this.pTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PTNAME";
			this.pTNAMEDataGridViewTextBoxColumn.HeaderText = "Автотранспорт";
			this.pTNAMEDataGridViewTextBoxColumn.Name = "pTNAMEDataGridViewTextBoxColumn";
			this.pTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
			this.pTNAMEDataGridViewTextBoxColumn.Width = 150;
			// 
			// PTGODVYP
			// 
			this.PTGODVYP.DataPropertyName = "PTGODVYP";
			this.PTGODVYP.HeaderText = "Год выпуска";
			this.PTGODVYP.Name = "PTGODVYP";
			this.PTGODVYP.ReadOnly = true;
			// 
			// PTGOSNOMER
			// 
			this.PTGOSNOMER.DataPropertyName = "PTGOSNOMER";
			this.PTGOSNOMER.HeaderText = "Гос. номер ";
			this.PTGOSNOMER.Name = "PTGOSNOMER";
			this.PTGOSNOMER.ReadOnly = true;
			// 
			// PTVIDTOPLIVA
			// 
			this.PTVIDTOPLIVA.DataPropertyName = "PTVIDTOPLIVA";
			this.PTVIDTOPLIVA.HeaderText = "Вид топлива";
			this.PTVIDTOPLIVA.Name = "PTVIDTOPLIVA";
			this.PTVIDTOPLIVA.ReadOnly = true;
			// 
			// frPotr
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(620, 212);
			this.Controls.Add(this.bindingNavigator1);
			this.Controls.Add(this.grPotr);
			this.Name = "frPotr";
			this.Text = "Потребители";
			this.Load += new System.EventHandler(this.frPotr_Load);
			((System.ComponentModel.ISupportInitialize)(this.grPotr)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pOTRBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.potrDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grPotr;
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
        private potrDataSet potrDataSet;
        private System.Windows.Forms.BindingSource pOTRBindingSource;
        private potrDataSetTableAdapters.POTRTableAdapter pOTRTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_pt;
		private System.Windows.Forms.DataGridViewTextBoxColumn pTNAMEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn PTGODVYP;
		private System.Windows.Forms.DataGridViewTextBoxColumn PTGOSNOMER;
		private System.Windows.Forms.DataGridViewTextBoxColumn PTVIDTOPLIVA;
	}
}
