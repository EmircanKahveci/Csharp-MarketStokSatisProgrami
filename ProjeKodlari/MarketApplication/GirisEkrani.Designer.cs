
namespace MarketApplication
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.bttnMarketİslemleri = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.bttnMarketGiris = new System.Windows.Forms.Button();
            this.bttnGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnKayıtlıGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnMarketİslemleri
            // 
            this.bttnMarketİslemleri.Location = new System.Drawing.Point(1107, 117);
            this.bttnMarketİslemleri.Name = "bttnMarketİslemleri";
            this.bttnMarketİslemleri.Size = new System.Drawing.Size(145, 47);
            this.bttnMarketİslemleri.TabIndex = 9;
            this.bttnMarketİslemleri.Text = "Market İşlemleri";
            this.bttnMarketİslemleri.UseVisualStyleBackColor = true;
            this.bttnMarketİslemleri.Click += new System.EventHandler(this.bttnMarketİslemleri_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(1107, 91);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(145, 20);
            this.txtSifre.TabIndex = 8;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(1107, 65);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(145, 20);
            this.txtKullaniciAdi.TabIndex = 7;
            // 
            // bttnMarketGiris
            // 
            this.bttnMarketGiris.Location = new System.Drawing.Point(11, 12);
            this.bttnMarketGiris.Name = "bttnMarketGiris";
            this.bttnMarketGiris.Size = new System.Drawing.Size(153, 47);
            this.bttnMarketGiris.TabIndex = 6;
            this.bttnMarketGiris.Text = "Market";
            this.bttnMarketGiris.UseVisualStyleBackColor = true;
            this.bttnMarketGiris.Click += new System.EventHandler(this.bttnMarketGiris_Click);
            // 
            // bttnGiris
            // 
            this.bttnGiris.Location = new System.Drawing.Point(1107, 31);
            this.bttnGiris.Name = "bttnGiris";
            this.bttnGiris.Size = new System.Drawing.Size(145, 28);
            this.bttnGiris.TabIndex = 5;
            this.bttnGiris.Text = "Giriş Yap";
            this.bttnGiris.UseVisualStyleBackColor = true;
            this.bttnGiris.Click += new System.EventHandler(this.bttnGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1127, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "YÖNETİCİ PANELİ";
            // 
            // bttnKayıtlıGiris
            // 
            this.bttnKayıtlıGiris.Location = new System.Drawing.Point(964, 34);
            this.bttnKayıtlıGiris.Name = "bttnKayıtlıGiris";
            this.bttnKayıtlıGiris.Size = new System.Drawing.Size(137, 23);
            this.bttnKayıtlıGiris.TabIndex = 16;
            this.bttnKayıtlıGiris.Text = "Giriş Bilgileri İçin Tıklayınız";
            this.bttnKayıtlıGiris.UseVisualStyleBackColor = true;
            this.bttnKayıtlıGiris.Click += new System.EventHandler(this.bttnKayıtlıGiris_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.bttnKayıtlıGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnMarketİslemleri);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.bttnMarketGiris);
            this.Controls.Add(this.bttnGiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisEkrani";
            this.Text = "GirisEkrani";
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnMarketİslemleri;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Button bttnGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnKayıtlıGiris;
        public System.Windows.Forms.Button bttnMarketGiris;
    }
}