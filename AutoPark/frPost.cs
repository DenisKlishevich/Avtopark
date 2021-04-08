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
    public partial class frPost : Form
    {
        public frPost()
        {
            InitializeComponent();
        }

        private void frPost_Load(object sender, EventArgs e)
        {
            this.pOSTTableAdapter.Fill(this.postDataSet.POST);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (grPost.CurrentRow == null) return;

            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.pOSTTableAdapter.DeleteQuery((int) grPost.CurrentRow.Cells["id_ps"].Value);
                this.pOSTTableAdapter.Fill(this.postDataSet.POST);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frPostAdd fPAdd = new frPostAdd();

            fPAdd.ShowDialog();
            if (fPAdd.DialogResult == DialogResult.OK)
            {
            this.pOSTTableAdapter.InsertQuery(fPAdd.psName);
            this.pOSTTableAdapter.Fill(this.postDataSet.POST);
            }
            fPAdd.Dispose();
        }
    }
}
