using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPark
{
	public partial class frRasxodAdd : Form
	{
		public DateTime prDate;
		public string prTTN;
		public long id_tv = 0;
		public int prCnt = 0;
		public int prPrice = 0;
		public long id_pt = 0;

		public frRasxodAdd()
		{
			InitializeComponent();
		}

		private void frRasxodAdd_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "tovarDataSet.TOVAR". При необходимости она может быть перемещена или удалена.
			this.tOVARTableAdapter.Fill(this.tovarDataSet.TOVAR);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "potrDataSet.POTR". При необходимости она может быть перемещена или удалена.
			this.pOTRTableAdapter.Fill(this.potrDataSet.POTR);
			dtDate.Value = DateTime.Now.Date;
			labelostatok.Text = "Остаток: " + getost();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			prDate = dtDate.Value;
			prTTN = txTTN.Text;
			id_tv = Decimal.ToInt32((int)cbTovar.SelectedValue);
			Int32.TryParse(txCnt.Text, out prCnt);
			Int32.TryParse(txPrice.Text, out prPrice);
			id_pt = Decimal.ToInt32((int)cbPotr.SelectedValue);
			if (getost() < prCnt)
			{
				prCnt = 0;
			}
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}
		private int getost()
		{
			labelostatok.Text = "Остаток: ";
			var drv = cbTovar.SelectedItem as DataRowView;
			if (drv == null)
				return 0;
			var t = (drv.Row as tovarDataSet.TOVARRow);
			if (t == null)
				return 0;
			return t.RSCNT;
		}
		private void cbTovar_SelectedIndexChanged(object sender, EventArgs e)
		{

			labelostatok.Text = "Остаток: " + getost();
		}
	}
}
