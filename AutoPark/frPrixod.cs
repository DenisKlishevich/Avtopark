using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace AutoPark
{
	public partial class frPrixod : Form
	{
		public frPrixod()
		{
			InitializeComponent();
		}

		private void frPrixod_Load(object sender, EventArgs e)
		{
			cbMonth.SelectedIndex = DateTime.Now.Month - 1;
			txYear.Text = DateTime.Now.Year.ToString();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			frPrixodAdd fPrixodAdd = new frPrixodAdd();

			fPrixodAdd.ShowDialog();
			if (fPrixodAdd.DialogResult == DialogResult.OK)
			{

				this.vPRIXODTableAdapter.InsertQuery(fPrixodAdd.prDate.ToString(), fPrixodAdd.prCnt, fPrixodAdd.prPrice, (int)fPrixodAdd.id_tv, (int)fPrixodAdd.id_ps, fPrixodAdd.prTTN);
				int yy = DateTime.Now.Year;
				Int32.TryParse(txYear.Text, out yy);
				vPRIXODTableAdapter.Fill(vprixodDataSet.VPRIXOD, (int)(cbMonth.SelectedIndex + 1), (int)yy);
			}
			fPrixodAdd.Dispose();
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			Object pp = new object();
			int yy = DateTime.Now.Year;
			Int32.TryParse(txYear.Text, out yy);

			vPRIXODTableAdapter.Fill(vprixodDataSet.VPRIXOD, (cbMonth.SelectedIndex + 1), yy);
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			if (grPrix.CurrentRow == null) return;

			if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.vPRIXODTableAdapter.DeleteQuery((int) grPrix.CurrentRow.Cells["id_pr"].Value,
					(int) grPrix.CurrentRow.Cells["prCnt"].Value, (int) grPrix.CurrentRow.Cells["id_tv"].Value);
				int yy = DateTime.Now.Year;
				Int32.TryParse(txYear.Text, out yy);

				vPRIXODTableAdapter.Fill(vprixodDataSet.VPRIXOD, (cbMonth.SelectedIndex + 1), yy);
			}
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			if (grPrix.Rows.Count == 0) return;

			Excel.Application eApp = null;
			Excel.Workbook wBook = null;
			Excel.Worksheet wSheet = null;

			eApp = new Excel.Application();
			eApp.Workbooks.Add();
			wBook = eApp.Workbooks[1];
			wBook.Worksheets.Add();
			wSheet = wBook.Worksheets[1];

			int yy = DateTime.Now.Year;
			Int32.TryParse(txYear.Text, out yy);

			wSheet.Cells[1, 1] = "Поступление продукции";
			wSheet.Cells[2, 1] = "за " + cbMonth.Text + yy.ToString();

			wSheet.Cells[4, 1] = "Дата";
			wSheet.Cells[4, 2] = "ТТН";
			wSheet.Cells[4, 3] = "Код товара";
			wSheet.Cells[4, 4] = "Товар";
			wSheet.Cells[4, 5] = "Кол-во";
			wSheet.Cells[4, 6] = "Ед. изм.";
			wSheet.Cells[4, 7] = "Цена";
			wSheet.Cells[4, 8] = "Поставщик";

			for (int i = 0; i < grPrix.Rows.Count; i++)
			{
				wSheet.Cells[5 + i, 1] = grPrix.Rows[i].Cells["prDate"].Value.ToString();
				wSheet.Cells[5 + i, 2] = grPrix.Rows[i].Cells["prTTN"].Value.ToString();
				wSheet.Cells[5 + i, 3] = grPrix.Rows[i].Cells["id_tv"].Value.ToString();
				wSheet.Cells[5 + i, 4] = grPrix.Rows[i].Cells["tvName"].Value.ToString();
				wSheet.Cells[5 + i, 5] = grPrix.Rows[i].Cells["prCnt"].Value.ToString();
				wSheet.Cells[5 + i, 6] = grPrix.Rows[i].Cells["tvEd"].Value.ToString();
				wSheet.Cells[5 + i, 7] = grPrix.Rows[i].Cells["prPrice"].Value.ToString();
				wSheet.Cells[5 + i, 8] = grPrix.Rows[i].Cells["psName"].Value.ToString();
			}

			Excel.Range rg = wSheet.Range[wSheet.Cells[4, 1], wSheet.Cells[4 + grPrix.Rows.Count, 8]];
			rg.Select();
			rg.Columns.AutoFit();

			rg.Columns.Borders[Excel.XlBordersIndex.xlEdgeBottom].ColorIndex = 1;
			rg.Columns.Borders[Excel.XlBordersIndex.xlEdgeLeft].ColorIndex = 1;
			rg.Columns.Borders[Excel.XlBordersIndex.xlEdgeRight].ColorIndex = 1;
			rg.Columns.Borders[Excel.XlBordersIndex.xlEdgeTop].ColorIndex = 1;
			rg.Columns.Borders[Excel.XlBordersIndex.xlInsideHorizontal].ColorIndex = 1;
			rg.Columns.Borders[Excel.XlBordersIndex.xlInsideVertical].ColorIndex = 1;

			eApp.Visible = true;
		}
	}
}
