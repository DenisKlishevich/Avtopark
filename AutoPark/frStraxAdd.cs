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
	public partial class frStraxAdd : Form
	{
		public DateTime prDateS;
		public DateTime prDatePo;
		public long id_pt = 0;
		public frStraxAdd()
		{
			InitializeComponent();
		}

		private void frStraxAdd_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'potrDataSet.POTR' table. You can move, or remove it, as needed.
			this.pOTRTableAdapter.Fill(this.potrDataSet.POTR);
			dtDateS.Value = DateTime.Now.Date;
			dtDatePo.Value = DateTime.Now.Date;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			prDateS = dtDateS.Value;
			prDatePo = dtDatePo.Value;
			id_pt = Decimal.ToInt32((int)cbPotr.SelectedValue);
		}
	}
}
