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
    public partial class frRasxod : Form
    {
        public frRasxod()
        {
            InitializeComponent();
        }

        private void frRasxod_Load(object sender, EventArgs e)
        {
            cbMonth.SelectedIndex = DateTime.Now.Month - 1;
            txYear.Text = DateTime.Now.Year.ToString();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            
            int yy = DateTime.Now.Year;
            Int32.TryParse(txYear.Text, out yy);

            vRASXODTableAdapter.Fill(rasxodDataSet.VRASXOD, (cbMonth.SelectedIndex + 1), yy);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frRasxodAdd fRasxodAdd = new frRasxodAdd();

            fRasxodAdd.ShowDialog();
            if (fRasxodAdd.DialogResult == DialogResult.OK)
            {
        if (fRasxodAdd.prCnt == 0)
				{
          MessageBox.Show( "Не верно введенное количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
				}
        this.vRASXODTableAdapter.InsertQuery(fRasxodAdd.prDate.ToString (), fRasxodAdd.prCnt, fRasxodAdd.prPrice, (int) fRasxodAdd.id_tv, (int) fRasxodAdd.id_pt, fRasxodAdd.prTTN);

        int yy = DateTime.Now.Year;
				Int32.TryParse(txYear.Text, out yy);
				vRASXODTableAdapter.Fill(rasxodDataSet.VRASXOD, (cbMonth.SelectedIndex + 1), yy);

			}
      fRasxodAdd.Dispose();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (grRasxod.CurrentRow == null) return;

            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

        this.vRASXODTableAdapter.DeleteQuery((int)grRasxod.CurrentRow.Cells["id_rs"].Value, (int)grRasxod.CurrentRow.Cells["rsCnt"].Value, (int)grRasxod.CurrentRow.Cells["id_tv"].Value);
                
                int yy = DateTime.Now.Year;
                Int32.TryParse(txYear.Text, out yy);

                vRASXODTableAdapter.Fill(rasxodDataSet.VRASXOD, (cbMonth.SelectedIndex + 1), yy);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (grRasxod.Rows.Count == 0) return;

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
            wSheet.Cells[4, 8] = "Потребитель";

            for (int i = 0; i < grRasxod.Rows.Count; i++)
            {
                wSheet.Cells[5 + i, 1] = grRasxod.Rows[i].Cells["rsDate"].Value.ToString();
                wSheet.Cells[5 + i, 2] = grRasxod.Rows[i].Cells["rsTTN"].Value.ToString();
                wSheet.Cells[5 + i, 3] = grRasxod.Rows[i].Cells["id_tv"].Value.ToString();
                wSheet.Cells[5 + i, 4] = grRasxod.Rows[i].Cells["tvName"].Value.ToString();
                wSheet.Cells[5 + i, 5] = grRasxod.Rows[i].Cells["rsCnt"].Value.ToString();
                wSheet.Cells[5 + i, 6] = grRasxod.Rows[i].Cells["tvEd"].Value.ToString();
                wSheet.Cells[5 + i, 7] = grRasxod.Rows[i].Cells["rsPrice"].Value.ToString();
                wSheet.Cells[5 + i, 8] = grRasxod.Rows[i].Cells["ptName"].Value.ToString();
            }

            Excel.Range rg = wSheet.Range[wSheet.Cells[4, 1], wSheet.Cells[4 + grRasxod.Rows.Count, 8]];
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
