namespace OnlineKurs.UI
{
    partial class FrmSertifika
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
            this.txtSoy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVT = new System.Windows.Forms.MaskedTextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.adi = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSoy
            // 
            this.txtSoy.Location = new System.Drawing.Point(123, 73);
            this.txtSoy.Name = "txtSoy";
            this.txtSoy.Size = new System.Drawing.Size(204, 22);
            this.txtSoy.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Soyadi";
            // 
            // txtVT
            // 
            this.txtVT.Location = new System.Drawing.Point(123, 104);
            this.txtVT.Mask = "00/00/0000";
            this.txtVT.Name = "txtVT";
            this.txtVT.Size = new System.Drawing.Size(204, 22);
            this.txtVT.TabIndex = 28;
            this.txtVT.ValidatingType = typeof(System.DateTime);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(252, 154);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 27;
            this.BtnCancel.Text = "İptal";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(162, 154);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 26;
            this.BtnOk.Text = "Tamam";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Veriliş Tarihi";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(123, 42);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(204, 22);
            this.txtAdi.TabIndex = 24;
            // 
            // adi
            // 
            this.adi.AutoSize = true;
            this.adi.Location = new System.Drawing.Point(24, 48);
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(24, 16);
            this.adi.TabIndex = 21;
            this.adi.Text = "Ad";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(123, 14);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(204, 22);
            this.textID.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID";
            // 
            // FrmSertifika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 231);
            this.Controls.Add(this.txtSoy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVT);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.adi);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.Name = "FrmSertifika";
            this.Text = "FrmSertifika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtVT;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label adi;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label1;
    }
}