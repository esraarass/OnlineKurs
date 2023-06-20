using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineKurs.UI;
using OnlineKurs.BL;

namespace OnlineKurs
{
    public partial class AnaForm : Form
    {
        public object Blogin { get; private set; }

        public AnaForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnÜyeEkle(object sender, EventArgs e)
        {
            FrmUye frmUye = new FrmUye()
            {
                Text = "Üye ekle.",
                Uye = new Uye() { ID = Guid.NewGuid() },



            };

            var sonuc=frmUye.ShowDialog();
            if (sonuc == DialogResult.OK)
            {

                BLogin.UyeEkle(frmUye.Uye);
            }

        }
    }
}
