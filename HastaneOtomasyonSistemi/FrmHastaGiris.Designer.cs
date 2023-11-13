namespace HastaneOtomasyonSistemi
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.MskTckn = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.BtnGirisyap = new System.Windows.Forms.Button();
            this.LnkUyeol = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giris Paneli";
            // 
            // MskTckn
            // 
            this.MskTckn.Location = new System.Drawing.Point(191, 112);
            this.MskTckn.Mask = "00000000000";
            this.MskTckn.Name = "MskTckn";
            this.MskTckn.Size = new System.Drawing.Size(171, 40);
            this.MskTckn.TabIndex = 1;
            this.MskTckn.ValidatingType = typeof(int);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(191, 171);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.PasswordChar = '*';
            this.TxtSifre.Size = new System.Drawing.Size(171, 40);
            this.TxtSifre.TabIndex = 2;
            // 
            // BtnGirisyap
            // 
            this.BtnGirisyap.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGirisyap.Location = new System.Drawing.Point(267, 217);
            this.BtnGirisyap.Name = "BtnGirisyap";
            this.BtnGirisyap.Size = new System.Drawing.Size(95, 40);
            this.BtnGirisyap.TabIndex = 3;
            this.BtnGirisyap.Text = "Giris Yap";
            this.BtnGirisyap.UseVisualStyleBackColor = true;
            this.BtnGirisyap.Click += new System.EventHandler(this.BtnGirisyap_Click);
            // 
            // LnkUyeol
            // 
            this.LnkUyeol.AutoSize = true;
            this.LnkUyeol.Location = new System.Drawing.Point(392, 178);
            this.LnkUyeol.Name = "LnkUyeol";
            this.LnkUyeol.Size = new System.Drawing.Size(85, 33);
            this.LnkUyeol.TabIndex = 4;
            this.LnkUyeol.TabStop = true;
            this.LnkUyeol.Text = "Uye Ol";
            this.LnkUyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkUyeol_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "TCKN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sifre:";
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.BtnGirisyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 260);
            this.Controls.Add(this.LnkUyeol);
            this.Controls.Add(this.BtnGirisyap);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskTckn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "Hasta Giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskTckn;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Button BtnGirisyap;
        private System.Windows.Forms.LinkLabel LnkUyeol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}