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
    public partial class frRest : Form
    {
        public frRest()
        {
            InitializeComponent();
        }

        private void frRest_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restDataSet.VREST". При необходимости она может быть перемещена или удалена.
            this.vRESTTableAdapter.Fill(this.restDataSet.VREST);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(grRest.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для отображения!");
                return;
            }

            Excel.Application eApp = null;
            Excel.Workbook wBook = null;
            Excel.Worksheet wSheet = null;

            eApp = new Excel.Application();
            eApp.Workbooks.Add();
            wBook = eApp.Workbooks[1];
            wBook.Worksheets.Add();
            wSheet = wBook.Worksheets[1];

            wSheet.Cells[1, 1] = "Ведомость остатков по складу";
            wSheet.Cells[2, 1] = "на " + DateTime.Now.Date.ToString("dd.MM.yyyy");

            wSheet.Cells[4, 1] = "Код";
            wSheet.Cells[4, 2] = "Наименование";
            wSheet.Cells[4, 3] = "Кол-во";
            wSheet.Cells[4, 4] = "Ед. изм.";

            for (int i = 0; i < grRest.Rows.Count; i++)
            {
                wSheet.Cells[5 + i, 1] = grRest.Rows[i].Cells["id_tv"].Value.ToString();
                wSheet.Cells[5 + i, 2] = grRest.Rows[i].Cells["tvName"].Value.ToString();
                wSheet.Cells[5 + i, 3] = grRest.Rows[i].Cells["rsCnt"].Value.ToString();
                wSheet.Cells[5 + i, 4] = grRest.Rows[i].Cells["tvEd"].Value.ToString();

            }

            Excel.Range rg = wSheet.Range[wSheet.Cells[4, 1], wSheet.Cells[4 + grRest.Rows.Count, 4]];
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
