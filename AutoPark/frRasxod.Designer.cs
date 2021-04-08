namespace AutoPark
{
    partial class frRasxod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frRasxod));
            this.grRasxod = new System.Windows.Forms.DataGridView();
            this.rsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rsTTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rsCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvEd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vRASXODBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rasxodDataSet = new AutoPark.rasxodDataSet();
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
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cbMonth = new System.Windows.Forms.ToolStripComboBox();
            this.txYear = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.vRASXODTableAdapter = new AutoPark.rasxodDataSetTableAdapters.VRASXODTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grRasxod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRASXODBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasxodDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grRasxod
            // 
            this.grRasxod.AllowUserToAddRows = false;
            this.grRasxod.AllowUserToDeleteRows = false;
            this.grRasxod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grRasxod.AutoGenerateColumns = false;
            this.grRasxod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grRasxod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rsDate,
            this.rsTTN,
            this.id_tv,
            this.tvName,
            this.rsCnt,
            this.tvEd,
            this.rsPrice,
            this.ptName,
            this.id_rs,
            this.id_pt});
            this.grRasxod.DataSource = this.vRASXODBindingSource;
            this.grRasxod.Location = new System.Drawing.Point(16, 34);
            this.grRasxod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grRasxod.Name = "grRasxod";
            this.grRasxod.ReadOnly = true;
            this.grRasxod.RowHeadersWidth = 51;
            this.grRasxod.Size = new System.Drawing.Size(1132, 293);
            this.grRasxod.TabIndex = 0;
            // 
            // rsDate
            // 
            this.rsDate.DataPropertyName = "RSDATE";
            this.rsDate.HeaderText = "Дата";
            this.rsDate.MinimumWidth = 6;
            this.rsDate.Name = "rsDate";
            this.rsDate.ReadOnly = true;
            this.rsDate.Width = 125;
            // 
            // rsTTN
            // 
            this.rsTTN.DataPropertyName = "RSTTN";
            this.rsTTN.HeaderText = "ТТН";
            this.rsTTN.MinimumWidth = 6;
            this.rsTTN.Name = "rsTTN";
            this.rsTTN.ReadOnly = true;
            this.rsTTN.Width = 125;
            // 
            // id_tv
            // 
            this.id_tv.DataPropertyName = "ID_TV";
            this.id_tv.HeaderText = "Код товара";
            this.id_tv.MinimumWidth = 6;
            this.id_tv.Name = "id_tv";
            this.id_tv.ReadOnly = true;
            this.id_tv.Width = 125;
            // 
            // tvName
            // 
            this.tvName.DataPropertyName = "TVNAME";
            this.tvName.HeaderText = "Товар";
            this.tvName.MinimumWidth = 6;
            this.tvName.Name = "tvName";
            this.tvName.ReadOnly = true;
            this.tvName.Width = 125;
            // 
            // rsCnt
            // 
            this.rsCnt.DataPropertyName = "RSCNT";
            this.rsCnt.HeaderText = "Кол-во";
            this.rsCnt.MinimumWidth = 6;
            this.rsCnt.Name = "rsCnt";
            this.rsCnt.ReadOnly = true;
            this.rsCnt.Width = 125;
            // 
            // tvEd
            // 
            this.tvEd.DataPropertyName = "TVED";
            this.tvEd.HeaderText = "Ед. изм.";
            this.tvEd.MinimumWidth = 6;
            this.tvEd.Name = "tvEd";
            this.tvEd.ReadOnly = true;
            this.tvEd.Width = 125;
            // 
            // rsPrice
            // 
            this.rsPrice.DataPropertyName = "RSPRICE";
            this.rsPrice.HeaderText = "Цена";
            this.rsPrice.MinimumWidth = 6;
            this.rsPrice.Name = "rsPrice";
            this.rsPrice.ReadOnly = true;
            this.rsPrice.Width = 125;
            // 
            // ptName
            // 
            this.ptName.DataPropertyName = "PTNAME";
            this.ptName.HeaderText = "Автотранспорт";
            this.ptName.MinimumWidth = 6;
            this.ptName.Name = "ptName";
            this.ptName.ReadOnly = true;
            this.ptName.Width = 125;
            // 
            // id_rs
            // 
            this.id_rs.DataPropertyName = "ID_RS";
            this.id_rs.HeaderText = "ID_RS";
            this.id_rs.MinimumWidth = 6;
            this.id_rs.Name = "id_rs";
            this.id_rs.ReadOnly = true;
            this.id_rs.Visible = false;
            this.id_rs.Width = 125;
            // 
            // id_pt
            // 
            this.id_pt.DataPropertyName = "ID_PT";
            this.id_pt.HeaderText = "ID_PT";
            this.id_pt.MinimumWidth = 6;
            this.id_pt.Name = "id_pt";
            this.id_pt.ReadOnly = true;
            this.id_pt.Visible = false;
            this.id_pt.Width = 125;
            // 
            // vRASXODBindingSource
            // 
            this.vRASXODBindingSource.DataMember = "VRASXOD";
            this.vRASXODBindingSource.DataSource = this.rasxodDataSet;
            // 
            // rasxodDataSet
            // 
            this.rasxodDataSet.DataSetName = "rasxodDataSet";
            this.rasxodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
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
            this.toolStripButton4});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1164, 28);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // vRASXODTableAdapter
            // 
            this.vRASXODTableAdapter.ClearBeforeFill = true;
            // 
            // frRasxod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 342);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.grRasxod);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frRasxod";
            this.Text = "Расход ТМЦ";
            this.Load += new System.EventHandler(this.frRasxod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grRasxod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRASXODBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasxodDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grRasxod;
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
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.BindingSource vRASXODBindingSource;
        private rasxodDataSet rasxodDataSet;
        private rasxodDataSetTableAdapters.VRASXODTableAdapter vRASXODTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn rsDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn rsTTN;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_tv;
		private System.Windows.Forms.DataGridViewTextBoxColumn tvName;
		private System.Windows.Forms.DataGridViewTextBoxColumn rsCnt;
		private System.Windows.Forms.DataGridViewTextBoxColumn tvEd;
		private System.Windows.Forms.DataGridViewTextBoxColumn rsPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn ptName;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_rs;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_pt;
	}
}
