using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineKurs.UI
{
    public partial class FrmKurs : Form
    {
        public FrmKurs()
        {
            InitializeComponent();
        }

        public Sertifika Sertifika { get; set; }
        public Kurs Kurs { get; set; }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            Kurs.Ad = txtAdi.Text;
            Kurs.EgitmenAdi=txtEA.Text;
            
            DialogResult = DialogResult.OK;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtBT_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private void txtEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBİT_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void adi_Click(object sender, EventArgs e)
        {

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
