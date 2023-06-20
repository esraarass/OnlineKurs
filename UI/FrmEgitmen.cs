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
    public partial class FrmEgitmen : Form
    {
        public FrmEgitmen()
        {
            InitializeComponent();
        }

        public Egitmen Egitmen { get; set; }

        private void BtnTamam_Click(object sender, EventArgs e)
        {
            Egitmen.Ad = txtAd.Text;
            Egitmen.Soyad = txtSoy.Text;
            Egitmen.Cinsiyet= txtCinsiyet.Text;
            Egitmen.Mail= txtMail.Text;
            DialogResult = DialogResult.OK;
        }

        private void Btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
    }
}
