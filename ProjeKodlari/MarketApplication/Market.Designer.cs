namespace MarketApplication
{
    partial class Market
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Market));
            this.grpBoxUrunler = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxArama = new System.Windows.Forms.TextBox();
            this.dtGrdView1 = new System.Windows.Forms.DataGridView();
            this.grpBoxKayıtOl = new System.Windows.Forms.GroupBox();
            this.bttnResimSec = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bttnKayitTamamla = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxTelefonNo = new System.Windows.Forms.TextBox();
            this.txtBoxEposta = new System.Windows.Forms.TextBox();
            this.txtBoxSifre = new System.Windows.Forms.TextBox();
            this.txtBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.grpBoxKullaniciBilgileri = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxKullaniciAd = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttnGirisYap = new System.Windows.Forms.Button();
            this.bttnKayitOl = new System.Windows.Forms.Button();
            this.grpBoxGirisYap = new System.Windows.Forms.GroupBox();
            this.grpBoxSepetim = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxAdet = new System.Windows.Forms.TextBox();
            this.bttnUrunCikar = new System.Windows.Forms.Button();
            this.bttnSepetiSil = new System.Windows.Forms.Button();
            this.bttnSatinAl = new System.Windows.Forms.Button();
            this.lstBoxSepetim = new System.Windows.Forms.ListBox();
            this.bttnCikisYap = new System.Windows.Forms.Button();
            this.oFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtBoxToplamTutar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.grpBoxUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdView1)).BeginInit();
            this.grpBoxKayıtOl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpBoxKullaniciBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoxGirisYap.SuspendLayout();
            this.grpBoxSepetim.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxUrunler
            // 
            this.grpBoxUrunler.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxUrunler.Controls.Add(this.label2);
            this.grpBoxUrunler.Controls.Add(this.txtBoxArama);
            this.grpBoxUrunler.Controls.Add(this.dtGrdView1);
            this.grpBoxUrunler.Location = new System.Drawing.Point(331, 12);
            this.grpBoxUrunler.Name = "grpBoxUrunler";
            this.grpBoxUrunler.Size = new System.Drawing.Size(921, 657);
            this.grpBoxUrunler.TabIndex = 1;
            this.grpBoxUrunler.TabStop = false;
            this.grpBoxUrunler.Text = "Ürünler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ne Aramıştınız?";
            // 
            // txtBoxArama
            // 
            this.txtBoxArama.Location = new System.Drawing.Point(6, 38);
            this.txtBoxArama.Name = "txtBoxArama";
            this.txtBoxArama.Size = new System.Drawing.Size(154, 20);
            this.txtBoxArama.TabIndex = 1;
            this.txtBoxArama.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dtGrdView1
            // 
            this.dtGrdView1.AllowUserToAddRows = false;
            this.dtGrdView1.AllowUserToDeleteRows = false;
            this.dtGrdView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGrdView1.ColumnHeadersHeight = 30;
            this.dtGrdView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGrdView1.Location = new System.Drawing.Point(6, 64);
            this.dtGrdView1.Name = "dtGrdView1";
            this.dtGrdView1.ReadOnly = true;
            this.dtGrdView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdView1.Size = new System.Drawing.Size(909, 587);
            this.dtGrdView1.TabIndex = 0;
            this.dtGrdView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdView1_CellClick);
            // 
            // grpBoxKayıtOl
            // 
            this.grpBoxKayıtOl.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxKayıtOl.Controls.Add(this.bttnResimSec);
            this.grpBoxKayıtOl.Controls.Add(this.pictureBox2);
            this.grpBoxKayıtOl.Controls.Add(this.bttnKayitTamamla);
            this.grpBoxKayıtOl.Controls.Add(this.label7);
            this.grpBoxKayıtOl.Controls.Add(this.label6);
            this.grpBoxKayıtOl.Controls.Add(this.label5);
            this.grpBoxKayıtOl.Controls.Add(this.label4);
            this.grpBoxKayıtOl.Controls.Add(this.txtBoxTelefonNo);
            this.grpBoxKayıtOl.Controls.Add(this.txtBoxEposta);
            this.grpBoxKayıtOl.Controls.Add(this.txtBoxSifre);
            this.grpBoxKayıtOl.Controls.Add(this.txtBoxKullaniciAdi);
            this.grpBoxKayıtOl.Location = new System.Drawing.Point(7, 11);
            this.grpBoxKayıtOl.Name = "grpBoxKayıtOl";
            this.grpBoxKayıtOl.Size = new System.Drawing.Size(324, 263);
            this.grpBoxKayıtOl.TabIndex = 10;
            this.grpBoxKayıtOl.TabStop = false;
            this.grpBoxKayıtOl.Text = "Kayıt Ol";
            this.grpBoxKayıtOl.Visible = false;
            // 
            // bttnResimSec
            // 
            this.bttnResimSec.Location = new System.Drawing.Point(117, 79);
            this.bttnResimSec.Name = "bttnResimSec";
            this.bttnResimSec.Size = new System.Drawing.Size(75, 23);
            this.bttnResimSec.TabIndex = 17;
            this.bttnResimSec.Text = "Resim Seç";
            this.bttnResimSec.UseVisualStyleBackColor = true;
            this.bttnResimSec.Click += new System.EventHandler(this.bttnResimSec_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(32, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // bttnKayitTamamla
            // 
            this.bttnKayitTamamla.Location = new System.Drawing.Point(184, 213);
            this.bttnKayitTamamla.Name = "bttnKayitTamamla";
            this.bttnKayitTamamla.Size = new System.Drawing.Size(133, 23);
            this.bttnKayitTamamla.TabIndex = 15;
            this.bttnKayitTamamla.Text = "Kaydı Tamamla";
            this.bttnKayitTamamla.UseVisualStyleBackColor = true;
            this.bttnKayitTamamla.Click += new System.EventHandler(this.bttnKayitTamamla_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefon No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "E-Posta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // txtBoxTelefonNo
            // 
            this.txtBoxTelefonNo.Location = new System.Drawing.Point(100, 187);
            this.txtBoxTelefonNo.Name = "txtBoxTelefonNo";
            this.txtBoxTelefonNo.Size = new System.Drawing.Size(217, 20);
            this.txtBoxTelefonNo.TabIndex = 3;
            // 
            // txtBoxEposta
            // 
            this.txtBoxEposta.Location = new System.Drawing.Point(100, 161);
            this.txtBoxEposta.Name = "txtBoxEposta";
            this.txtBoxEposta.Size = new System.Drawing.Size(217, 20);
            this.txtBoxEposta.TabIndex = 2;
            // 
            // txtBoxSifre
            // 
            this.txtBoxSifre.Location = new System.Drawing.Point(100, 135);
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.Size = new System.Drawing.Size(217, 20);
            this.txtBoxSifre.TabIndex = 1;
            // 
            // txtBoxKullaniciAdi
            // 
            this.txtBoxKullaniciAdi.Location = new System.Drawing.Point(100, 109);
            this.txtBoxKullaniciAdi.Name = "txtBoxKullaniciAdi";
            this.txtBoxKullaniciAdi.Size = new System.Drawing.Size(217, 20);
            this.txtBoxKullaniciAdi.TabIndex = 0;
            // 
            // grpBoxKullaniciBilgileri
            // 
            this.grpBoxKullaniciBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxKullaniciBilgileri.Controls.Add(this.label10);
            this.grpBoxKullaniciBilgileri.Controls.Add(this.label9);
            this.grpBoxKullaniciBilgileri.Controls.Add(this.label8);
            this.grpBoxKullaniciBilgileri.Controls.Add(this.pictureBox1);
            this.grpBoxKullaniciBilgileri.Location = new System.Drawing.Point(14, 11);
            this.grpBoxKullaniciBilgileri.Name = "grpBoxKullaniciBilgileri";
            this.grpBoxKullaniciBilgileri.Size = new System.Drawing.Size(314, 130);
            this.grpBoxKullaniciBilgileri.TabIndex = 9;
            this.grpBoxKullaniciBilgileri.TabStop = false;
            this.grpBoxKullaniciBilgileri.Text = "Kullanıcı Bilgileri";
            this.grpBoxKullaniciBilgileri.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(104, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "label8";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtBoxKullaniciAd
            // 
            this.txtBoxKullaniciAd.Location = new System.Drawing.Point(78, 19);
            this.txtBoxKullaniciAd.Name = "txtBoxKullaniciAd";
            this.txtBoxKullaniciAd.Size = new System.Drawing.Size(169, 20);
            this.txtBoxKullaniciAd.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre";
            // 
            // bttnGirisYap
            // 
            this.bttnGirisYap.Location = new System.Drawing.Point(11, 83);
            this.bttnGirisYap.Name = "bttnGirisYap";
            this.bttnGirisYap.Size = new System.Drawing.Size(128, 23);
            this.bttnGirisYap.TabIndex = 7;
            this.bttnGirisYap.Text = "Giriş Yap";
            this.bttnGirisYap.UseVisualStyleBackColor = true;
            this.bttnGirisYap.Click += new System.EventHandler(this.bttnGirisYap_Click);
            // 
            // bttnKayitOl
            // 
            this.bttnKayitOl.Location = new System.Drawing.Point(145, 83);
            this.bttnKayitOl.Name = "bttnKayitOl";
            this.bttnKayitOl.Size = new System.Drawing.Size(128, 23);
            this.bttnKayitOl.TabIndex = 8;
            this.bttnKayitOl.Text = "Kayıt Ol";
            this.bttnKayitOl.UseVisualStyleBackColor = true;
            this.bttnKayitOl.Click += new System.EventHandler(this.bttnKayitOl_Click);
            // 
            // grpBoxGirisYap
            // 
            this.grpBoxGirisYap.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxGirisYap.Controls.Add(this.txtBoxKullaniciAd);
            this.grpBoxGirisYap.Controls.Add(this.bttnKayitOl);
            this.grpBoxGirisYap.Controls.Add(this.textBox3);
            this.grpBoxGirisYap.Controls.Add(this.bttnGirisYap);
            this.grpBoxGirisYap.Controls.Add(this.label1);
            this.grpBoxGirisYap.Controls.Add(this.label3);
            this.grpBoxGirisYap.Location = new System.Drawing.Point(24, 12);
            this.grpBoxGirisYap.Name = "grpBoxGirisYap";
            this.grpBoxGirisYap.Size = new System.Drawing.Size(301, 118);
            this.grpBoxGirisYap.TabIndex = 9;
            this.grpBoxGirisYap.TabStop = false;
            this.grpBoxGirisYap.Text = "Giriş Bilgileri";
            // 
            // grpBoxSepetim
            // 
            this.grpBoxSepetim.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxSepetim.Controls.Add(this.label12);
            this.grpBoxSepetim.Controls.Add(this.txtBoxAdet);
            this.grpBoxSepetim.Controls.Add(this.bttnUrunCikar);
            this.grpBoxSepetim.Controls.Add(this.bttnSepetiSil);
            this.grpBoxSepetim.Controls.Add(this.bttnSatinAl);
            this.grpBoxSepetim.Controls.Add(this.lstBoxSepetim);
            this.grpBoxSepetim.Location = new System.Drawing.Point(11, 159);
            this.grpBoxSepetim.Name = "grpBoxSepetim";
            this.grpBoxSepetim.Size = new System.Drawing.Size(314, 270);
            this.grpBoxSepetim.TabIndex = 14;
            this.grpBoxSepetim.TabStop = false;
            this.grpBoxSepetim.Text = "Sepetim";
            this.grpBoxSepetim.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(197, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Adet";
            // 
            // txtBoxAdet
            // 
            this.txtBoxAdet.Location = new System.Drawing.Point(232, 210);
            this.txtBoxAdet.Name = "txtBoxAdet";
            this.txtBoxAdet.Size = new System.Drawing.Size(52, 20);
            this.txtBoxAdet.TabIndex = 4;
            // 
            // bttnUrunCikar
            // 
            this.bttnUrunCikar.ForeColor = System.Drawing.Color.Black;
            this.bttnUrunCikar.Location = new System.Drawing.Point(20, 210);
            this.bttnUrunCikar.Name = "bttnUrunCikar";
            this.bttnUrunCikar.Size = new System.Drawing.Size(77, 23);
            this.bttnUrunCikar.TabIndex = 3;
            this.bttnUrunCikar.Text = "Ürün Çıkar";
            this.bttnUrunCikar.UseVisualStyleBackColor = true;
            this.bttnUrunCikar.Click += new System.EventHandler(this.bttnUrunCikar_Click);
            // 
            // bttnSepetiSil
            // 
            this.bttnSepetiSil.ForeColor = System.Drawing.Color.DarkRed;
            this.bttnSepetiSil.Location = new System.Drawing.Point(151, 239);
            this.bttnSepetiSil.Name = "bttnSepetiSil";
            this.bttnSepetiSil.Size = new System.Drawing.Size(133, 23);
            this.bttnSepetiSil.TabIndex = 2;
            this.bttnSepetiSil.Text = "Sepeti Sil";
            this.bttnSepetiSil.UseVisualStyleBackColor = true;
            this.bttnSepetiSil.Click += new System.EventHandler(this.bttnSepetiSil_Click);
            // 
            // bttnSatinAl
            // 
            this.bttnSatinAl.ForeColor = System.Drawing.Color.Green;
            this.bttnSatinAl.Location = new System.Drawing.Point(20, 239);
            this.bttnSatinAl.Name = "bttnSatinAl";
            this.bttnSatinAl.Size = new System.Drawing.Size(125, 23);
            this.bttnSatinAl.TabIndex = 1;
            this.bttnSatinAl.Text = "Satın Al";
            this.bttnSatinAl.UseVisualStyleBackColor = true;
            this.bttnSatinAl.Click += new System.EventHandler(this.bttnSatinAl_Click);
            // 
            // lstBoxSepetim
            // 
            this.lstBoxSepetim.FormattingEnabled = true;
            this.lstBoxSepetim.Location = new System.Drawing.Point(20, 19);
            this.lstBoxSepetim.Name = "lstBoxSepetim";
            this.lstBoxSepetim.Size = new System.Drawing.Size(264, 186);
            this.lstBoxSepetim.TabIndex = 0;
            // 
            // bttnCikisYap
            // 
            this.bttnCikisYap.ForeColor = System.Drawing.Color.DarkRed;
            this.bttnCikisYap.Location = new System.Drawing.Point(14, 643);
            this.bttnCikisYap.Name = "bttnCikisYap";
            this.bttnCikisYap.Size = new System.Drawing.Size(105, 26);
            this.bttnCikisYap.TabIndex = 14;
            this.bttnCikisYap.Text = "Çıkış Yap";
            this.bttnCikisYap.UseVisualStyleBackColor = true;
            this.bttnCikisYap.Click += new System.EventHandler(this.bttnCikisYap_Click);
            // 
            // oFileDialog1
            // 
            this.oFileDialog1.FileName = "openFileDialog1";
            // 
            // txtBoxToplamTutar
            // 
            this.txtBoxToplamTutar.Enabled = false;
            this.txtBoxToplamTutar.Location = new System.Drawing.Point(168, 435);
            this.txtBoxToplamTutar.Name = "txtBoxToplamTutar";
            this.txtBoxToplamTutar.Size = new System.Drawing.Size(156, 20);
            this.txtBoxToplamTutar.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(36, 438);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Toplam Ödenecek Tutar";
            // 
            // Market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBoxToplamTutar);
            this.Controls.Add(this.bttnCikisYap);
            this.Controls.Add(this.grpBoxSepetim);
            this.Controls.Add(this.grpBoxKullaniciBilgileri);
            this.Controls.Add(this.grpBoxKayıtOl);
            this.Controls.Add(this.grpBoxGirisYap);
            this.Controls.Add(this.grpBoxUrunler);
            this.Name = "Market";
            this.Text = "Market ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpBoxUrunler.ResumeLayout(false);
            this.grpBoxUrunler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdView1)).EndInit();
            this.grpBoxKayıtOl.ResumeLayout(false);
            this.grpBoxKayıtOl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpBoxKullaniciBilgileri.ResumeLayout(false);
            this.grpBoxKullaniciBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoxGirisYap.ResumeLayout(false);
            this.grpBoxGirisYap.PerformLayout();
            this.grpBoxSepetim.ResumeLayout(false);
            this.grpBoxSepetim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBoxUrunler;
        private System.Windows.Forms.DataGridView dtGrdView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxArama;
        private System.Windows.Forms.TextBox txtBoxKullaniciAd;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnGirisYap;
        private System.Windows.Forms.Button bttnKayitOl;
        private System.Windows.Forms.GroupBox grpBoxGirisYap;
        private System.Windows.Forms.GroupBox grpBoxKayıtOl;
        private System.Windows.Forms.Button bttnKayitTamamla;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxTelefonNo;
        private System.Windows.Forms.TextBox txtBoxEposta;
        private System.Windows.Forms.TextBox txtBoxSifre;
        private System.Windows.Forms.TextBox txtBoxKullaniciAdi;
        private System.Windows.Forms.GroupBox grpBoxKullaniciBilgileri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpBoxSepetim;
        private System.Windows.Forms.ListBox lstBoxSepetim;
        private System.Windows.Forms.Button bttnUrunCikar;
        private System.Windows.Forms.Button bttnSepetiSil;
        private System.Windows.Forms.Button bttnSatinAl;
        private System.Windows.Forms.Button bttnCikisYap;
        private System.Windows.Forms.Button bttnResimSec;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog oFileDialog1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxAdet;
        private System.Windows.Forms.TextBox txtBoxToplamTutar;
        private System.Windows.Forms.Label label13;
    }
}