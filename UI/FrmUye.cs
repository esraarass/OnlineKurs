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
    public partial class FrmUye : Form
    {
        public FrmUye()
        {
            InitializeComponent();
        }

        
        private void FrmUye_Load(object sender, EventArgs e)
        {

        }
          public Egitmen Egitmen { get; set; }
          public Kurs Kurs { get; set; }
          public Uye Uye { get; set; }
        private void BtnTamam_Click(object sender, EventArgs e)
        {
            if(!ErrorControl(txtAd)) return;
            if(!ErrorControl(txtSoy)) return;
            
            DialogResult = DialogResult.OK;
        }

        private void Btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private bool ErrorControl(Control c)
        { 
          if (c is TextBox )
          {
            if (c.Text == "")
            {
                errorProvider1.SetError(c, "Eksik ya da hatalı giriş");
                c.Focus();
                return false;
            }
                else
                {

                    errorProvider1.SetError(c, "");
                    return true;
                }
          }

            return true;
        }

        private void txtTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSoy_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
