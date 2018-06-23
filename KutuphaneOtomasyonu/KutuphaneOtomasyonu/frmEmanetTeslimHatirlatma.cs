using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class frmEmanetTeslimHatirlatma : Form
    {
        public frmEmanetTeslimHatirlatma()
        {
            InitializeComponent();
        }
        private void DataDuzelt()
        {

            for (int i = 0; i < dgwteslimhatirlatma.Rows.Count; i++)
            {
                if (dgwteslimhatirlatma.Rows[i].Cells[7].Value.ToString().IndexOf("[Kırmızı]") != -1)
                {
                    dgwteslimhatirlatma.Rows[i].DefaultCellStyle.BackColor = Color.Thistle;
                    dgwteslimhatirlatma.Rows[i].Cells[7].Value = dgwteslimhatirlatma.Rows[i].Cells[7].Value.ToString().Replace("[Kırmızı]", "");
                    dgwteslimhatirlatma.Rows[i].Cells[7].Style.BackColor = Color.Red;
                }
            }
        }
        private void frmTeslimHatirlatma_Load(object sender, EventArgs e)
        {
            clsEmanetTeslimHatirlatma hatirlatma = new clsEmanetTeslimHatirlatma();
            dgwteslimhatirlatma.DataSource = hatirlatma.datagrdDoldur();
            DataDuzelt();
        }

        private void dgwteslimhatirlatma_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgwteslimhatirlatma.RowCount != 0)
            {
                clsEmanetTeslimHatirlatma hatirlatma = new clsEmanetTeslimHatirlatma();
                dgwteslimhatirlatma.DataSource = hatirlatma.datagrdDoldur();
                DataDuzelt();
            }
        }

        private void txtisbnsuzme_TextChanged(object sender, EventArgs e)
        {
            clsEmanetTeslimHatirlatma hatirlatma = new clsEmanetTeslimHatirlatma();
            hatirlatma.zIsbn = txtisbnsuzme.Text;
            hatirlatma.zUyetc = txttcsuzme.Text;
            dgwteslimhatirlatma.DataSource = hatirlatma.suzme();
            DataDuzelt();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clsEmanetTeslimHatirlatma hatirlatma = new clsEmanetTeslimHatirlatma();
            hatirlatma.zIsbn = txtisbnsuzme.Text;
            hatirlatma.zUyetc = txttcsuzme.Text;
            dgwteslimhatirlatma.DataSource = hatirlatma.suzme();
            DataDuzelt();

        }


    }
}
