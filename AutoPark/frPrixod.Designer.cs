namespace AutoPark
{
    partial class frPrixod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frPrixod));
            this.grPrix = new System.Windows.Forms.DataGridView();
            this.id_pr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prTTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvEd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vPRIXODBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vprixodDataSet = new AutoPark.vprixodDataSet();
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
            this.vPRIXODTableAdapter = new AutoPark.vprixodDataSetTableAdapters.VPRIXODTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPRIXODBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vprixodDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grPrix
            // 
            this.grPrix.AllowUserToAddRows = false;
            this.grPrix.AllowUserToDeleteRows = false;
            this.grPrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grPrix.AutoGenerateColumns = false;
            this.grPrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grPrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pr,
            this.iDPSDataGridViewTextBoxColumn,
            this.prDate,
            this.prTTN,
            this.id_tv,
            this.tvName,
            this.prCnt,
            this.tvEd,
            this.prPrice,
            this.psName});
            this.grPrix.DataSource = this.vPRIXODBindingSource;
            this.grPrix.Location = new System.Drawing.Point(16, 34);
            this.grPrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grPrix.Name = "grPrix";
            this.grPrix.ReadOnly = true;
            this.grPrix.RowHeadersWidth = 51;
            this.grPrix.Size = new System.Drawing.Size(896, 300);
            this.grPrix.TabIndex = 0;
            // 
            // id_pr
            // 
            this.id_pr.DataPropertyName = "ID_PR";
            this.id_pr.HeaderText = "Код";
            this.id_pr.MinimumWidth = 6;
            this.id_pr.Name = "id_pr";
            this.id_pr.ReadOnly = true;
            this.id_pr.Visible = false;
            this.id_pr.Width = 125;
            // 
            // iDPSDataGridViewTextBoxColumn
            // 
            this.iDPSDataGridViewTextBoxColumn.DataPropertyName = "ID_PS";
            this.iDPSDataGridViewTextBoxColumn.HeaderText = "ID_PS";
            this.iDPSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPSDataGridViewTextBoxColumn.Name = "iDPSDataGridViewTextBoxColumn";
            this.iDPSDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPSDataGridViewTextBoxColumn.Visible = false;
            this.iDPSDataGridViewTextBoxColumn.Width = 125;
            // 
            // prDate
            // 
            this.prDate.DataPropertyName = "PRDATE";
            this.prDate.HeaderText = "Дата";
            this.prDate.MinimumWidth = 6;
            this.prDate.Name = "prDate";
            this.prDate.ReadOnly = true;
            this.prDate.Width = 125;
            // 
            // prTTN
            // 
            this.prTTN.DataPropertyName = "PRTTN";
            this.prTTN.HeaderText = "№ ТТН";
            this.prTTN.MinimumWidth = 6;
            this.prTTN.Name = "prTTN";
            this.prTTN.ReadOnly = true;
            this.prTTN.Width = 125;
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
            // prCnt
            // 
            this.prCnt.DataPropertyName = "PRCNT";
            this.prCnt.HeaderText = "Кол-во ";
            this.prCnt.MinimumWidth = 6;
            this.prCnt.Name = "prCnt";
            this.prCnt.ReadOnly = true;
            this.prCnt.Width = 125;
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
            // prPrice
            // 
            this.prPrice.DataPropertyName = "PRPRICE";
            this.prPrice.HeaderText = "Цена";
            this.prPrice.MinimumWidth = 6;
            this.prPrice.Name = "prPrice";
            this.prPrice.ReadOnly = true;
            this.prPrice.Width = 125;
            // 
            // psName
            // 
            this.psName.DataPropertyName = "PSNAME";
            this.psName.HeaderText = "Поставщик";
            this.psName.MinimumWidth = 6;
            this.psName.Name = "psName";
            this.psName.ReadOnly = true;
            this.psName.Width = 125;
            // 
            // vPRIXODBindingSource
            // 
            this.vPRIXODBindingSource.DataMember = "VPRIXOD";
            this.vPRIXODBindingSource.DataSource = this.vprixodDataSet;
            // 
            // vprixodDataSet
            // 
            this.vprixodDataSet.DataSetName = "vprixodDataSet";
            this.vprixodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.vPRIXODBindingSource;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(928, 28);
            this.bindingNavigator1.TabIndex = 2;
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
            // vPRIXODTableAdapter
            // 
            this.vPRIXODTableAdapter.ClearBeforeFill = true;
            // 
            // frPrixod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 350);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.grPrix);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frPrixod";
            this.Text = "Поступленеи ТМЦ";
            this.Load += new System.EventHandler(this.frPrixod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPRIXODBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vprixodDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grPrix;
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
        private System.Windows.Forms.BindingSource vPRIXODBindingSource;
        private vprixodDataSet vprixodDataSet;
        private vprixodDataSetTableAdapters.VPRIXODTableAdapter vPRIXODTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cbMonth;
        private System.Windows.Forms.ToolStripTextBox txYear;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pr;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn prTTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prCnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tvEd;
        private System.Windows.Forms.DataGridViewTextBoxColumn prPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn psName;
    }
}
