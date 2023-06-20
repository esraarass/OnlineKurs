namespace OnlineKurs
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Kurslar = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnMüşteriEkle = new System.Windows.Forms.ToolStripButton();
            this.BtnMüşteriDüzenle = new System.Windows.Forms.ToolStripButton();
            this.BtnMüşteriSil = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.BtnMüşteriBul = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BtnKursEkle = new System.Windows.Forms.ToolStripButton();
            this.BtnKursDüzenle = new System.Windows.Forms.ToolStripButton();
            this.BtnKursSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Kurslar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Kurslar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Üyeler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Kurslar
            // 
            this.Kurslar.Controls.Add(this.toolStrip2);
            this.Kurslar.Controls.Add(this.dataGridView2);
            this.Kurslar.Location = new System.Drawing.Point(4, 25);
            this.Kurslar.Name = "Kurslar";
            this.Kurslar.Padding = new System.Windows.Forms.Padding(3);
            this.Kurslar.Size = new System.Drawing.Size(776, 415);
            this.Kurslar.TabIndex = 1;
            this.Kurslar.Text = "Kurslar";
            this.Kurslar.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(3, 390);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(770, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnMüşteriEkle,
            this.BtnMüşteriDüzenle,
            this.BtnMüşteriSil,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.BtnMüşteriBul});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(770, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Click += new System.EventHandler(this.btnÜyeEkle);
            // 
            // BtnMüşteriEkle
            // 
            this.BtnMüşteriEkle.Image = ((System.Drawing.Image)(resources.GetObject("BtnMüşteriEkle.Image")));
            this.BtnMüşteriEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMüşteriEkle.Name = "BtnMüşteriEkle";
            this.BtnMüşteriEkle.Size = new System.Drawing.Size(60, 24);
            this.BtnMüşteriEkle.Text = "Ekle";
            // 
            // BtnMüşteriDüzenle
            // 
            this.BtnMüşteriDüzenle.Image = ((System.Drawing.Image)(resources.GetObject("BtnMüşteriDüzenle.Image")));
            this.BtnMüşteriDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMüşteriDüzenle.Name = "BtnMüşteriDüzenle";
            this.BtnMüşteriDüzenle.Size = new System.Drawing.Size(87, 24);
            this.BtnMüşteriDüzenle.Text = "Düzenle";
            this.BtnMüşteriDüzenle.ToolTipText = "Düzenle";
            // 
            // BtnMüşteriSil
            // 
            this.BtnMüşteriSil.Image = ((System.Drawing.Image)(resources.GetObject("BtnMüşteriSil.Image")));
            this.BtnMüşteriSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMüşteriSil.Name = "BtnMüşteriSil";
            this.BtnMüşteriSil.Size = new System.Drawing.Size(49, 24);
            this.BtnMüşteriSil.Text = "Sil";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 354);
            this.dataGridView1.TabIndex = 2;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 24);
            this.toolStripLabel1.Text = "Ara";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // BtnMüşteriBul
            // 
            this.BtnMüşteriBul.Image = ((System.Drawing.Image)(resources.GetObject("BtnMüşteriBul.Image")));
            this.BtnMüşteriBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMüşteriBul.Name = "BtnMüşteriBul";
            this.BtnMüşteriBul.Size = new System.Drawing.Size(29, 24);
            this.BtnMüşteriBul.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(760, 354);
            this.dataGridView2.TabIndex = 3;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnKursEkle,
            this.BtnKursDüzenle,
            this.BtnKursSil,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.toolStripTextBox2,
            this.toolStripButton4});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(770, 27);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // BtnKursEkle
            // 
            this.BtnKursEkle.Image = ((System.Drawing.Image)(resources.GetObject("BtnKursEkle.Image")));
            this.BtnKursEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnKursEkle.Name = "BtnKursEkle";
            this.BtnKursEkle.Size = new System.Drawing.Size(60, 24);
            this.BtnKursEkle.Text = "Ekle";
            // 
            // BtnKursDüzenle
            // 
            this.BtnKursDüzenle.Image = ((System.Drawing.Image)(resources.GetObject("BtnKursDüzenle.Image")));
            this.BtnKursDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnKursDüzenle.Name = "BtnKursDüzenle";
            this.BtnKursDüzenle.Size = new System.Drawing.Size(87, 24);
            this.BtnKursDüzenle.Text = "Düzenle";
            this.BtnKursDüzenle.ToolTipText = "Düzenle";
            // 
            // BtnKursSil
            // 
            this.BtnKursSil.Image = ((System.Drawing.Image)(resources.GetObject("BtnKursSil.Image")));
            this.BtnKursSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnKursSil.Name = "BtnKursSil";
            this.BtnKursSil.Size = new System.Drawing.Size(49, 24);
            this.BtnKursSil.Text = "Sil";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(32, 24);
            this.toolStripLabel2.Text = "Ara";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 444);
            this.Controls.Add(this.tabControl1);
            this.Name = "AnaForm";
            this.Text = "ta";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Kurslar.ResumeLayout(false);
            this.Kurslar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnMüşteriEkle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage Kurslar;
        private System.Windows.Forms.ToolStripButton BtnMüşteriDüzenle;
        private System.Windows.Forms.ToolStripButton BtnMüşteriSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton BtnMüşteriBul;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BtnKursEkle;
        private System.Windows.Forms.ToolStripButton BtnKursDüzenle;
        private System.Windows.Forms.ToolStripButton BtnKursSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

