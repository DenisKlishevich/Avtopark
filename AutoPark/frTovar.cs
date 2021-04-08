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
    public partial class frTovar : Form
    {
        public frTovar()
        {
            InitializeComponent();
        }

        private void frTovar_Load(object sender, EventArgs e)
        {
            this.tOVARTableAdapter.Fill(this.tovarDataSet.TOVAR);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (grTovar.CurrentRow == null) return;

            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                this.tOVARTableAdapter.DeleteQuery((int) grTovar.CurrentRow.Cells["id_tv"].Value);
                this.tOVARTableAdapter.Fill(this.tovarDataSet.TOVAR);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frTovarAdd fTA = new frTovarAdd();

            fTA.ShowDialog();
            if(fTA.DialogResult == DialogResult.OK)
            {
        this.tOVARTableAdapter.InsertQuery(fTA.tName, fTA.tEI);
        this.tOVARTableAdapter.Fill(this.tovarDataSet.TOVAR);

      }
            fTA.Dispose();
        }
    }
}
