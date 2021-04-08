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
    public partial class frPrixodAdd : Form
    {
        public DateTime prDate;
        public string prTTN;
        public long id_tv = 0;
        public int prCnt = 0;
        public int prPrice = 0;
        public long id_ps = 0;

        public frPrixodAdd()
        {
            InitializeComponent();
        }

        private void frPrixodAdd_Load(object sender, EventArgs e)
        {
            this.tOVARTableAdapter.Fill(this.tovarDataSet.TOVAR);
            this.pOSTTableAdapter.Fill(this.postDataSet.POST);
            dtDate.Value = DateTime.Now.Date;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prDate = dtDate.Value;
            prTTN = txTTN.Text;
            id_tv = Decimal.ToInt32((int)cbTovar.SelectedValue);
            Int32.TryParse(txCnt.Text, out prCnt);
            Int32.TryParse(txPrice.Text, out prPrice);
            id_ps = Decimal.ToInt32((int)cbPost.SelectedValue);
        }
    }
}
