
namespace AutoPark
{
	partial class frStraxAdd
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
			this.cbPotr = new System.Windows.Forms.ComboBox();
			this.dtDateS = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dtDatePo = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.potrDataSet = new AutoPark.potrDataSet();
			this.pOTRBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pOTRTableAdapter = new AutoPark.potrDataSetTableAdapters.POTRTableAdapter();
			this.tableAdapterManager = new AutoPark.potrDataSetTableAdapters.TableAdapterManager();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.potrDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pOTRBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// cbPotr
			// 
			this.cbPotr.DataSource = this.pOTRBindingSource;
			this.cbPotr.DisplayMember = "PTNAME";
			this.cbPotr.FormattingEnabled = true;
			this.cbPotr.Location = new System.Drawing.Point(22, 143);
			this.cbPotr.Name = "cbPotr";
			this.cbPotr.Size = new System.Drawing.Size(323, 21);
			this.cbPotr.TabIndex = 11;
			this.cbPotr.ValueMember = "ID_PT";
			// 
			// dtDateS
			// 
			this.dtDateS.Location = new System.Drawing.Point(22, 30);
			this.dtDateS.Name = "dtDateS";
			this.dtDateS.Size = new System.Drawing.Size(155, 20);
			this.dtDateS.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 127);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Автотранспорт";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Дата начала";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtDatePo);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cbPotr);
			this.groupBox1.Controls.Add(this.dtDateS);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(360, 268);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(378, 257);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "Отмена";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(378, 228);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Ok";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dtDatePo
			// 
			this.dtDatePo.Location = new System.Drawing.Point(22, 84);
			this.dtDatePo.Name = "dtDatePo";
			this.dtDatePo.Size = new System.Drawing.Size(155, 20);
			this.dtDatePo.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Дата окончания";
			// 
			// potrDataSet
			// 
			this.potrDataSet.DataSetName = "potrDataSet";
			this.potrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// pOTRBindingSource
			// 
			this.pOTRBindingSource.DataMember = "POTR";
			this.pOTRBindingSource.DataSource = this.potrDataSet;
			// 
			// pOTRTableAdapter
			// 
			this.pOTRTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.POTRTableAdapter = this.pOTRTableAdapter;
			this.tableAdapterManager.UpdateOrder = AutoPark.potrDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// frStraxAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(465, 316);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "frStraxAdd";
			this.Text = "Новая страховка";
			this.Load += new System.EventHandler(this.frStraxAdd_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.potrDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pOTRBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cbPotr;
		private System.Windows.Forms.DateTimePicker dtDateS;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DateTimePicker dtDatePo;
		private System.Windows.Forms.Label label2;
		private potrDataSet potrDataSet;
		private System.Windows.Forms.BindingSource pOTRBindingSource;
		private potrDataSetTableAdapters.POTRTableAdapter pOTRTableAdapter;
		private potrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
	}
}