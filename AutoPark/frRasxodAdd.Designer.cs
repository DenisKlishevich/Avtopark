namespace AutoPark
{
    partial class frRasxodAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelostatok = new System.Windows.Forms.Label();
            this.cbPotr = new System.Windows.Forms.ComboBox();
            this.pOTRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.potrDataSet = new AutoPark.potrDataSet();
            this.txPrice = new System.Windows.Forms.TextBox();
            this.txCnt = new System.Windows.Forms.TextBox();
            this.cbTovar = new System.Windows.Forms.ComboBox();
            this.tOVARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarDataSet = new AutoPark.tovarDataSet();
            this.txTTN = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pOTRTableAdapter = new AutoPark.potrDataSetTableAdapters.POTRTableAdapter();
            this.tOVARTableAdapter = new AutoPark.tovarDataSetTableAdapters.TOVARTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOTRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOVARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelostatok);
            this.groupBox1.Controls.Add(this.cbPotr);
            this.groupBox1.Controls.Add(this.txPrice);
            this.groupBox1.Controls.Add(this.txCnt);
            this.groupBox1.Controls.Add(this.cbTovar);
            this.groupBox1.Controls.Add(this.txTTN);
            this.groupBox1.Controls.Add(this.dtDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(480, 330);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // labelostatok
            // 
            this.labelostatok.AutoSize = true;
            this.labelostatok.Location = new System.Drawing.Point(244, 187);
            this.labelostatok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelostatok.Name = "labelostatok";
            this.labelostatok.Size = new System.Drawing.Size(63, 17);
            this.labelostatok.TabIndex = 12;
            this.labelostatok.Text = "Остаток";
            // 
            // cbPotr
            // 
            this.cbPotr.DataSource = this.pOTRBindingSource;
            this.cbPotr.DisplayMember = "PTGOSNOMER";
            this.cbPotr.FormattingEnabled = true;
            this.cbPotr.Location = new System.Drawing.Point(29, 278);
            this.cbPotr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPotr.Name = "cbPotr";
            this.cbPotr.Size = new System.Drawing.Size(429, 24);
            this.cbPotr.TabIndex = 11;
            this.cbPotr.ValueMember = "ID_PT";
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
            // txPrice
            // 
            this.txPrice.Location = new System.Drawing.Point(29, 230);
            this.txPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(205, 22);
            this.txPrice.TabIndex = 10;
            // 
            // txCnt
            // 
            this.txCnt.Location = new System.Drawing.Point(29, 182);
            this.txCnt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txCnt.Name = "txCnt";
            this.txCnt.Size = new System.Drawing.Size(205, 22);
            this.txCnt.TabIndex = 9;
            // 
            // cbTovar
            // 
            this.cbTovar.DataSource = this.tOVARBindingSource;
            this.cbTovar.DisplayMember = "TVNAME";
            this.cbTovar.FormattingEnabled = true;
            this.cbTovar.Location = new System.Drawing.Point(29, 133);
            this.cbTovar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTovar.Name = "cbTovar";
            this.cbTovar.Size = new System.Drawing.Size(429, 24);
            this.cbTovar.TabIndex = 8;
            this.cbTovar.ValueMember = "ID_TV";
            this.cbTovar.SelectedIndexChanged += new System.EventHandler(this.cbTovar_SelectedIndexChanged);
            // 
            // tOVARBindingSource
            // 
            this.tOVARBindingSource.DataMember = "TOVAR";
            this.tOVARBindingSource.DataSource = this.tovarDataSet;
            // 
            // tovarDataSet
            // 
            this.tovarDataSet.DataSetName = "tovarDataSet";
            this.tovarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txTTN
            // 
            this.txTTN.Location = new System.Drawing.Point(29, 85);
            this.txTTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txTTN.Name = "txTTN";
            this.txTTN.Size = new System.Drawing.Size(205, 22);
            this.txTTN.TabIndex = 7;
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(29, 37);
            this.dtDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(205, 22);
            this.dtDate.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Автотранспорт";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кол-во";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Товар";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ТТН";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(505, 320);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(505, 284);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pOTRTableAdapter
            // 
            this.pOTRTableAdapter.ClearBeforeFill = true;
            // 
            // tOVARTableAdapter
            // 
            this.tOVARTableAdapter.ClearBeforeFill = true;
            // 
            // frRasxodAdd
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(617, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frRasxodAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый расход ТМЦ";
            this.Load += new System.EventHandler(this.frRasxodAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOTRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOVARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPotr;
        private System.Windows.Forms.TextBox txPrice;
        private System.Windows.Forms.TextBox txCnt;
        private System.Windows.Forms.ComboBox cbTovar;
        private System.Windows.Forms.TextBox txTTN;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private potrDataSet potrDataSet;
        private System.Windows.Forms.BindingSource pOTRBindingSource;
        private potrDataSetTableAdapters.POTRTableAdapter pOTRTableAdapter;
        private tovarDataSet tovarDataSet;
        private System.Windows.Forms.BindingSource tOVARBindingSource;
        private tovarDataSetTableAdapters.TOVARTableAdapter tOVARTableAdapter;
		private System.Windows.Forms.Label labelostatok;
	}
}
