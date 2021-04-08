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
    public partial class frGL : Form
    {
        public frGL()
        {
            InitializeComponent();
        }

        private void extnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frTovar fTov = new frTovar();

            fTov.MdiParent = this;
            fTov.Show();
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frPost fPost = new frPost();

            fPost.MdiParent = this;
            fPost.Show();
        }

        private void потребителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frPotr fPotr = new frPotr();

            fPotr.MdiParent = this;
            fPotr.Show();
        }

        private void остаткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frRest fRest = new frRest();

            fRest.MdiParent = this;
            fRest.Show();
        }

        private void приходыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frPrixod fPrixod = new frPrixod();

            fPrixod.MdiParent = this;
            fPrixod.Show();
        }

        private void расходыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frRasxod fRasxod = new AutoPark.frRasxod();

            fRasxod.MdiParent = this;
            fRasxod.Show();
        }

        private void frGL_Load(object sender, EventArgs e)
        {

        }

		private void страховкаToolStripMenuItem_Click(object sender, EventArgs e)
		{
      frStrax frStrax = new frStrax();
      frStrax.MdiParent = this;
      frStrax.Show();
		}

		private void техосмотрToolStripMenuItem_Click(object sender, EventArgs e)
		{
      frTex frTex = new frTex ();
      frTex.MdiParent = this;
      frTex.Show();
    }
	}
}
