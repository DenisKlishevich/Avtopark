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

namespace AutoPark
{
    public partial class frPotr : Form
    {
        public frPotr()
        {
            InitializeComponent();
        }

        private void frPotr_Load(object sender, EventArgs e)
        {
            this.pOTRTableAdapter.Fill(this.potrDataSet.POTR);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (grPotr.CurrentRow == null) return;

            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.pOTRTableAdapter.DeleteQuery((int)grPotr.CurrentRow.Cells["id_pt"].Value);
                this.pOTRTableAdapter.Fill(this.potrDataSet.POTR);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frPotrAdd fPotrAdd = new frPotrAdd();

            fPotrAdd.ShowDialog();
            if (fPotrAdd.DialogResult == DialogResult.OK)
            {
        this.pOTRTableAdapter.InsertQuery(fPotrAdd.prName, fPotrAdd.prGV.ToString(), fPotrAdd.prGN, fPotrAdd.prVT);
        this.pOTRTableAdapter.Fill(this.potrDataSet.POTR);
      }
            fPotrAdd.Dispose();
        }
    }
}
