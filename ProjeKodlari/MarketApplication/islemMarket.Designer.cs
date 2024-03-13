
namespace MarketApplication
{
    partial class islemMarket
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnResimSec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUrunCesit = new System.Windows.Forms.TextBox();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.txtUrunAdet = new System.Windows.Forms.TextBox();
            this.dtGrdView1 = new System.Windows.Forms.DataGridView();
            this.bttnEkle = new System.Windows.Forms.Button();
            this.bttnDuzenle = new System.Windows.Forms.Button();
            this.bttnSil = new System.Windows.Forms.Button();
            this.oFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUrunId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bttnResimSec);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtUrunCesit);
            this.groupBox1.Controls.Add(this.txtUrunFiyat);
            this.groupBox1.Controls.Add(this.txtUrunAd);
            this.groupBox1.Controls.Add(this.txtUrunAdet);
            this.groupBox1.Location = new System.Drawing.Point(881, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekleme İşlemleri";
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(325, 127);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(40, 20);
            this.txtUrunId.TabIndex = 18;
            this.txtUrunId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunId_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ürün ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ürün Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ürün Çeşidi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ürün Adedi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ürün Adı";
            // 
            // bttnResimSec
            // 
            this.bttnResimSec.Location = new System.Drawing.Point(6, 179);
            this.bttnResimSec.Name = "bttnResimSec";
            this.bttnResimSec.Size = new System.Drawing.Size(116, 23);
            this.bttnResimSec.TabIndex = 10;
            this.bttnResimSec.Text = "Resim Seç";
            this.bttnResimSec.UseVisualStyleBackColor = true;
            this.bttnResimSec.Click += new System.EventHandler(this.bttnResimSec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtUrunCesit
            // 
            this.txtUrunCesit.Location = new System.Drawing.Point(192, 104);
            this.txtUrunCesit.Name = "txtUrunCesit";
            this.txtUrunCesit.Size = new System.Drawing.Size(173, 20);
            this.txtUrunCesit.TabIndex = 3;
            this.txtUrunCesit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunCesit_KeyPress);
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Location = new System.Drawing.Point(192, 78);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(173, 20);
            this.txtUrunFiyat.TabIndex = 2;
            this.txtUrunFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunFiyat_KeyPress);
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(192, 23);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(173, 20);
            this.txtUrunAd.TabIndex = 0;
            this.txtUrunAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunAd_KeyPress);
            // 
            // txtUrunAdet
            // 
            this.txtUrunAdet.Location = new System.Drawing.Point(192, 49);
            this.txtUrunAdet.Name = "txtUrunAdet";
            this.txtUrunAdet.Size = new System.Drawing.Size(173, 20);
            this.txtUrunAdet.TabIndex = 1;
            this.txtUrunAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunAdet_KeyPress);
            // 
            // dtGrdView1
            // 
            this.dtGrdView1.AllowUserToAddRows = false;
            this.dtGrdView1.AllowUserToDeleteRows = false;
            this.dtGrdView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGrdView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtGrdView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdView1.Location = new System.Drawing.Point(12, 9);
            this.dtGrdView1.Name = "dtGrdView1";
            this.dtGrdView1.ReadOnly = true;
            this.dtGrdView1.RowHeadersWidth = 48;
            this.dtGrdView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdView1.Size = new System.Drawing.Size(863, 278);
            this.dtGrdView1.TabIndex = 9;
            this.dtGrdView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdView1_CellEnter);
            // 
            // bttnEkle
            // 
            this.bttnEkle.Location = new System.Drawing.Point(881, 264);
            this.bttnEkle.Name = "bttnEkle";
            this.bttnEkle.Size = new System.Drawing.Size(116, 23);
            this.bttnEkle.TabIndex = 11;
            this.bttnEkle.Text = "Ekle";
            this.bttnEkle.UseVisualStyleBackColor = true;
            this.bttnEkle.Click += new System.EventHandler(this.bttnEkle_Click);
            // 
            // bttnDuzenle
            // 
            this.bttnDuzenle.Location = new System.Drawing.Point(1003, 264);
            this.bttnDuzenle.Name = "bttnDuzenle";
            this.bttnDuzenle.Size = new System.Drawing.Size(127, 23);
            this.bttnDuzenle.TabIndex = 12;
            this.bttnDuzenle.Text = "Düzenle";
            this.bttnDuzenle.UseVisualStyleBackColor = true;
            this.bttnDuzenle.Click += new System.EventHandler(this.bttnDuzenle_Click);
            // 
            // bttnSil
            // 
            this.bttnSil.ForeColor = System.Drawing.Color.DarkRed;
            this.bttnSil.Location = new System.Drawing.Point(1136, 264);
            this.bttnSil.Name = "bttnSil";
            this.bttnSil.Size = new System.Drawing.Size(116, 23);
            this.bttnSil.TabIndex = 13;
            this.bttnSil.Text = "Sil";
            this.bttnSil.UseVisualStyleBackColor = true;
            this.bttnSil.Click += new System.EventHandler(this.bttnSil_Click);
            // 
            // oFileDialog1
            // 
            this.oFileDialog1.FileName = "openFileDialog1";
            // 
            // islemMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1264, 302);
            this.Controls.Add(this.bttnEkle);
            this.Controls.Add(this.bttnDuzenle);
            this.Controls.Add(this.bttnSil);
            this.Controls.Add(this.dtGrdView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "islemMarket";
            this.Text = "Market İşlemleri";
            this.Load += new System.EventHandler(this.islemMarket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttnResimSec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUrunCesit;
        private System.Windows.Forms.TextBox txtUrunFiyat;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.TextBox txtUrunAdet;
        private System.Windows.Forms.DataGridView dtGrdView1;
        private System.Windows.Forms.Button bttnEkle;
        private System.Windows.Forms.Button bttnDuzenle;
        private System.Windows.Forms.Button bttnSil;
        private System.Windows.Forms.OpenFileDialog oFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.Label label5;
    }
}