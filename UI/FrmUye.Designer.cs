namespace OnlineKurs.UI
{
    partial class FrmUye
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.BtnTamam = new System.Windows.Forms.Button();
            this.Btnİptal = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(66, 7);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(204, 22);
            this.textID.TabIndex = 0;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(66, 35);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(204, 22);
            this.txtAd.TabIndex = 1;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSoy
            // 
            this.txtSoy.Location = new System.Drawing.Point(66, 63);
            this.txtSoy.Name = "txtSoy";
            this.txtSoy.Size = new System.Drawing.Size(204, 22);
            this.txtSoy.TabIndex = 3;
            this.txtSoy.TextChanged += new System.EventHandler(this.txtSoy_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(66, 92);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(204, 22);
            this.txtTel.TabIndex = 3;
            this.txtTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTel_MaskInputRejected);
            // 
            // BtnTamam
            // 
            this.BtnTamam.Location = new System.Drawing.Point(104, 138);
            this.BtnTamam.Name = "BtnTamam";
            this.BtnTamam.Size = new System.Drawing.Size(75, 23);
            this.BtnTamam.TabIndex = 4;
            this.BtnTamam.Text = "Tamam";
            this.BtnTamam.UseVisualStyleBackColor = true;
            this.BtnTamam.Click += new System.EventHandler(this.BtnTamam_Click);
            // 
            // Btnİptal
            // 
            this.Btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btnİptal.Location = new System.Drawing.Point(195, 138);
            this.Btnİptal.Name = "Btnİptal";
            this.Btnİptal.Size = new System.Drawing.Size(75, 23);
            this.Btnİptal.TabIndex = 5;
            this.Btnİptal.Text = "İptal";
            this.Btnİptal.UseVisualStyleBackColor = true;
            this.Btnİptal.Click += new System.EventHandler(this.Btnİptal_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmUye
            // 
            this.AcceptButton = this.BtnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btnİptal;
            this.ClientSize = new System.Drawing.Size(299, 199);
            this.Controls.Add(this.Btnİptal);
            this.Controls.Add(this.BtnTamam);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.Name = "FrmUye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmUye";
            this.Load += new System.EventHandler(this.FrmUye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.Button BtnTamam;
        private System.Windows.Forms.Button Btnİptal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}