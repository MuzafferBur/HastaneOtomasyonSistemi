namespace HastaneOtomasyonSistemi
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.MskTckn = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnKayitol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(140, 227);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(171, 40);
            this.TxtSifre.TabIndex = 5;
            // 
            // MskTckn
            // 
            this.MskTckn.Location = new System.Drawing.Point(140, 129);
            this.MskTckn.Mask = "00000000000";
            this.MskTckn.Name = "MskTckn";
            this.MskTckn.Size = new System.Drawing.Size(171, 40);
            this.MskTckn.TabIndex = 3;
            this.MskTckn.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "TCKN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(140, 31);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(171, 40);
            this.TxtAd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "SoyAd:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(140, 81);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(171, 40);
            this.TxtSoyad.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 33);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tel:";
            // 
            // MskTel
            // 
            this.MskTel.Location = new System.Drawing.Point(140, 178);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(171, 40);
            this.MskTel.TabIndex = 4;
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadin"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(140, 277);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(171, 41);
            this.CmbCinsiyet.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 33);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cinsiyet:";
            // 
            // BtnKayitol
            // 
            this.BtnKayitol.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnKayitol.Location = new System.Drawing.Point(140, 324);
            this.BtnKayitol.Name = "BtnKayitol";
            this.BtnKayitol.Size = new System.Drawing.Size(171, 40);
            this.BtnKayitol.TabIndex = 8;
            this.BtnKayitol.Text = "Kayit Ol";
            this.BtnKayitol.UseVisualStyleBackColor = false;
            this.BtnKayitol.Click += new System.EventHandler(this.BtnKayitol_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.BtnKayitol;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(359, 378);
            this.Controls.Add(this.BtnKayitol);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MskTel);
            this.Controls.Add(this.MskTckn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox MskTckn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MskTel;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnKayitol;
    }
}