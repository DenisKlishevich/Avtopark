using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace AutoPark
{
	public partial class frStrax : Form
	{
		public frStrax()
		{
			InitializeComponent();
		}
		private void loaddata()
		{
			int yy = DateTime.Now.Year;
			Int32.TryParse(txYear.Text, out yy);
			int mm = (int)(cbMonth.SelectedIndex + 1);
			switch (cbFILTR.SelectedIndex)
			{
				case 0:
					this.vSTRAXTableAdapter.FillByD(this.straxDataSet.VSTRAX, yy, mm);
					break;
				case 1:
					this.vSTRAXTableAdapter.FillByZ(this.straxDataSet.VSTRAX, yy, mm);
					break;
				case 2:
					this.vSTRAXTableAdapter.FillByPo(this.straxDataSet.VSTRAX, mm, yy);
					break;
				case 3:
					this.vSTRAXTableAdapter.FillByS(this.straxDataSet.VSTRAX, mm, yy);
					break;
				case 4:
					this.vSTRAXTableAdapter.FillAll(this.straxDataSet.VSTRAX);
					break;
			}
			
		}
		private void frStrax_Load(object sender, EventArgs e)
		{
			cbFILTR.SelectedIndex = 0;
			cbMonth.SelectedIndex = DateTime.Now.Month - 1;
			txYear.Text = DateTime.Now.Year.ToString();
			loaddata();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			frStraxAdd StraxAdd = new frStraxAdd();
			StraxAdd.ShowDialog();
			if (StraxAdd.DialogResult== DialogResult.OK)
			{
				this.vSTRAXTableAdapter.InsertQuery((int) StraxAdd.id_pt, StraxAdd.prDateS.ToString(), StraxAdd.prDatePo.ToString());
				loaddata();
			}
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			loaddata();
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			if (vSTRAXDataGridView.CurrentRow == null) return;

			if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.vSTRAXTableAdapter.DeleteQuery((int)vSTRAXDataGridView.CurrentRow.Cells["id_code"].Value);
				loaddata();
			}
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			if (vSTRAXDataGridView.Rows.Count == 0) return;

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

			wSheet.Cells[1, 1] = "Застрахованный автотранспорт";
			if (cbFILTR.SelectedIndex != 4)
			{
				wSheet.Cells[2, 1] = "за " + cbMonth.Text + " " + yy.ToString() + " (" + cbFILTR.Text + ")";
			}
			else
				wSheet.Cells[2, 1] = "(" + cbFILTR.Text + ")";

			wSheet.Cells[4, 1] = "№п/п";
			wSheet.Cells[4, 2] = "Дата начала";
			wSheet.Cells[4, 3] = "Дата окончания";
			wSheet.Cells[4, 4] = "Автотранспорт";
			wSheet.Cells[4, 5] = "Год выпуска";
			wSheet.Cells[4, 6] = "Гос. номер";
			wSheet.Cells[4, 7] = "Вид топлива";
			wSheet.Cells[4, 8] = "Количество дней до окончания";

			for (int i = 0; i < vSTRAXDataGridView.Rows.Count; i++)
			{
				wSheet.Cells[5 + i, 1] = (i+1).ToString();
				wSheet.Cells[5 + i, 2] = Convert.ToDateTime(vSTRAXDataGridView.Rows[i].Cells["S"].Value).ToString("dd.MM.yyyy");
				wSheet.Cells[5 + i, 3] = Convert.ToDateTime(vSTRAXDataGridView.Rows[i].Cells["Po"].Value).ToString("dd.MM.yyyy");
				wSheet.Cells[5 + i, 4] = vSTRAXDataGridView.Rows[i].Cells["avto"].Value.ToString();
				wSheet.Cells[5 + i, 5] = Convert.ToDateTime(vSTRAXDataGridView.Rows[i].Cells["gv"].Value).ToString("dd.MM.yyyy");
				wSheet.Cells[5 + i, 6] = vSTRAXDataGridView.Rows[i].Cells["gn"].Value.ToString();
				wSheet.Cells[5 + i, 7] = vSTRAXDataGridView.Rows[i].Cells["vt"].Value.ToString();
				DateTime date = Convert.ToDateTime (vSTRAXDataGridView.Rows[i].Cells["Po"].Value);
				int kol = (int) (date - DateTime.Now).TotalDays + 1;
				if (kol < 0)
				{
					wSheet.Cells[5 + i, 8] = "Завершено " + Convert.ToDateTime(vSTRAXDataGridView.Rows[i].Cells["Po"].Value).ToString("dd.MM.yyyy");
				}
				else
				{
					wSheet.Cells[5 + i, 8] = kol.ToString();
				}
			}

			Excel.Range rg = wSheet.Range[wSheet.Cells[4, 1], wSheet.Cells[4 + vSTRAXDataGridView.Rows.Count, 8]];
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

		private void cbFILTR_Click(object sender, EventArgs e)
		{

		}
	}
}
