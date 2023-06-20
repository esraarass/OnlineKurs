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
    public partial class FrmSertifika : Form
    {
        public FrmSertifika()
        {
            InitializeComponent();
        }
        public Sertifika Sertifika { get; set; }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            Sertifika.Ad=txtAdi.Text;
            Sertifika.Soyad = txtSoy.Text;
            
            DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
    }
}
