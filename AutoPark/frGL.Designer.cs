namespace AutoPark
{
    partial class frGL
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frGL));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.extnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приходыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расходыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.остаткиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.потребителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обслуживаниеТранспортаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.страховкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.техосмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extnToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.обслуживаниеТранспортаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1289, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // extnToolStripMenuItem
            // 
            this.extnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приходыToolStripMenuItem,
            this.расходыToolStripMenuItem,
            this.toolStripMenuItem1,
            this.остаткиToolStripMenuItem,
            this.toolStripMenuItem2,
            this.выходToolStripMenuItem});
            this.extnToolStripMenuItem.Name = "extnToolStripMenuItem";
            this.extnToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.extnToolStripMenuItem.Text = "Складской учет";
            this.extnToolStripMenuItem.Click += new System.EventHandler(this.extnToolStripMenuItem_Click);
            // 
            // приходыToolStripMenuItem
            // 
            this.приходыToolStripMenuItem.Name = "приходыToolStripMenuItem";
            this.приходыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.приходыToolStripMenuItem.Text = "Приходы";
            this.приходыToolStripMenuItem.Click += new System.EventHandler(this.приходыToolStripMenuItem_Click);
            // 
            // расходыToolStripMenuItem
            // 
            this.расходыToolStripMenuItem.Name = "расходыToolStripMenuItem";
            this.расходыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.расходыToolStripMenuItem.Text = "Расходы";
            this.расходыToolStripMenuItem.Click += new System.EventHandler(this.расходыToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // остаткиToolStripMenuItem
            // 
            this.остаткиToolStripMenuItem.Name = "остаткиToolStripMenuItem";
            this.остаткиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.остаткиToolStripMenuItem.Text = "Остатки";
            this.остаткиToolStripMenuItem.Click += new System.EventHandler(this.остаткиToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарыToolStripMenuItem,
            this.поставщикиToolStripMenuItem,
            this.потребителиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.товарыToolStripMenuItem.Text = "ТМЦ";
            this.товарыToolStripMenuItem.Click += new System.EventHandler(this.товарыToolStripMenuItem_Click);
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // потребителиToolStripMenuItem
            // 
            this.потребителиToolStripMenuItem.Name = "потребителиToolStripMenuItem";
            this.потребителиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.потребителиToolStripMenuItem.Text = "Автотранспорт";
            this.потребителиToolStripMenuItem.Click += new System.EventHandler(this.потребителиToolStripMenuItem_Click);
            // 
            // обслуживаниеТранспортаToolStripMenuItem
            // 
            this.обслуживаниеТранспортаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.страховкаToolStripMenuItem,
            this.техосмотрToolStripMenuItem});
            this.обслуживаниеТранспортаToolStripMenuItem.Name = "обслуживаниеТранспортаToolStripMenuItem";
            this.обслуживаниеТранспортаToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.обслуживаниеТранспортаToolStripMenuItem.Text = "Обслуживание транспорта";
            // 
            // страховкаToolStripMenuItem
            // 
            this.страховкаToolStripMenuItem.Name = "страховкаToolStripMenuItem";
            this.страховкаToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.страховкаToolStripMenuItem.Text = "Страховка";
            this.страховкаToolStripMenuItem.Click += new System.EventHandler(this.страховкаToolStripMenuItem_Click);
            // 
            // техосмотрToolStripMenuItem
            // 
            this.техосмотрToolStripMenuItem.Name = "техосмотрToolStripMenuItem";
            this.техосмотрToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.техосмотрToolStripMenuItem.Text = "Техосмотр";
            this.техосмотрToolStripMenuItem.Click += new System.EventHandler(this.техосмотрToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 687);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1289, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 709);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frGL";
            this.Text = "Программное обеспечение по обслуживанию автотранспорта";
            this.Load += new System.EventHandler(this.frGL_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem extnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приходыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расходыToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem остаткиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem потребителиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem обслуживаниеТранспортаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem страховкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem техосмотрToolStripMenuItem;
	}
}

