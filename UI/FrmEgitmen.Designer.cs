namespace OnlineKurs.UI
{
    partial class FrmEgitmen
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
            this.Btnİptal = new System.Windows.Forms.Button();
            this.BtnTamam = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCinsiyet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btnİptal
            // 
            this.Btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btnİptal.Location = new System.Drawing.Point(208, 182);
            this.Btnİptal.Name = "Btnİptal";
            this.Btnİptal.Size = new System.Drawing.Size(75, 23);
            this.Btnİptal.TabIndex = 15;
            this.Btnİptal.Text = "İptal";
            this.Btnİptal.UseVisualStyleBackColor = true;
            this.Btnİptal.Click += new System.EventHandler(this.Btnİptal_Click);
            // 
            // BtnTamam
            // 
            this.BtnTamam.Location = new System.Drawing.Point(113, 182);
            this.BtnTamam.Name = "BtnTamam";
            this.BtnTamam.Size = new System.Drawing.Size(75, 23);
            this.BtnTamam.TabIndex = 14;
            this.BtnTamam.Text = "Tamam";
            this.BtnTamam.UseVisualStyleBackColor = true;
            this.BtnTamam.Click += new System.EventHandler(this.BtnTamam_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mail";
            // 
            // txtSoy
            // 
            this.txtSoy.Location = new System.Drawing.Point(86, 68);
            this.txtSoy.Name = "txtSoy";
            this.txtSoy.Size = new System.Drawing.Size(204, 22);
            this.txtSoy.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(86, 40);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(204, 22);
            this.txtAd.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ad";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(86, 12);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(204, 22);
            this.textID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(86, 99);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(204, 22);
            this.txtMail.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cinsiyet";
            // 
            // txtCinsiyet
            // 
            this.txtCinsiyet.Location = new System.Drawing.Point(86, 133);
            this.txtCinsiyet.Name = "txtCinsiyet";
            this.txtCinsiyet.Size = new System.Drawing.Size(204, 22);
            this.txtCinsiyet.TabIndex = 13;
            // 
            // FrmEgitmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 253);
            this.Controls.Add(this.Btnİptal);
            this.Controls.Add(this.BtnTamam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCinsiyet);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSoy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.Name = "FrmEgitmen";
            this.Text = "FrmEgitmen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnİptal;
        private System.Windows.Forms.Button BtnTamam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCinsiyet;
    }
}