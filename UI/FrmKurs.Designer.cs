namespace OnlineKurs.UI
{
    partial class FrmKurs
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.txtBİT = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.adi = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBT = new System.Windows.Forms.MaskedTextBox();
            this.txtEA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(261, 172);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 15;
            this.BtnCancel.Text = "İptal";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(163, 172);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 14;
            this.BtnOk.Text = "Tamam";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // txtBİT
            // 
            this.txtBİT.Location = new System.Drawing.Point(132, 93);
            this.txtBİT.Mask = "00/00/0000";
            this.txtBİT.Name = "txtBİT";
            this.txtBİT.Size = new System.Drawing.Size(204, 22);
            this.txtBİT.TabIndex = 12;
            this.txtBİT.ValidatingType = typeof(System.DateTime);
            this.txtBİT.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtBİT_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bitiş Tarihi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Başlangıç Tarihi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(132, 40);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(204, 22);
            this.txtAdi.TabIndex = 11;
            this.txtAdi.TextChanged += new System.EventHandler(this.txtAdi_TextChanged);
            // 
            // adi
            // 
            this.adi.AutoSize = true;
            this.adi.Location = new System.Drawing.Point(33, 46);
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(24, 16);
            this.adi.TabIndex = 8;
            this.adi.Text = "Ad";
            this.adi.Click += new System.EventHandler(this.adi_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(132, 12);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(204, 22);
            this.textID.TabIndex = 9;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBT
            // 
            this.txtBT.Location = new System.Drawing.Point(132, 65);
            this.txtBT.Mask = "00/00/0000";
            this.txtBT.Name = "txtBT";
            this.txtBT.Size = new System.Drawing.Size(204, 22);
            this.txtBT.TabIndex = 16;
            this.txtBT.ValidatingType = typeof(System.DateTime);
            this.txtBT.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtBT_MaskInputRejected);
            // 
            // txtEA
            // 
            this.txtEA.Location = new System.Drawing.Point(132, 119);
            this.txtEA.Name = "txtEA";
            this.txtEA.Size = new System.Drawing.Size(204, 22);
            this.txtEA.TabIndex = 17;
            this.txtEA.TextChanged += new System.EventHandler(this.txtEA_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Eğitmen Adı";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FrmKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 260);
            this.Controls.Add(this.txtEA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBT);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.txtBİT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.adi);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.Name = "FrmKurs";
            this.Text = "FrmKurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.MaskedTextBox txtBİT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label adi;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtBT;
        private System.Windows.Forms.TextBox txtEA;
        private System.Windows.Forms.Label label5;
    }
}