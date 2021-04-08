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
	public partial class frPotrAdd : Form
	{
		public string prName;
		public DateTime prGV;
		public string prGN;
		public string prVT;
		public frPotrAdd()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			prName = txPotr.Text;
			prGV = dateTimePickerGV.Value;
			prGN = textBoxGN.Text;
			prVT = comboBoxVT.SelectedItem.ToString();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
