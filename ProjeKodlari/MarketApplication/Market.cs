using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MarketApplication
{
    public partial class Market : Form
    {
        double toplam = 0.0;
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmda;
        SqlCommand cmd;
        DataTable table;
        string secilensatir;
        string secilensatir2;
        decimal secilensatir3;
        bool urunEklendimi = false;
        int urunAdedi = 1;
        decimal toplamTutar = 0;
        


        public Market()
        {
            InitializeComponent();
        }
        void urunEklensinMi()
        {
            DialogResult res = MessageBox.Show("Ürün Eklensinmi?", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                urunEklendimi = true;
            }
            else if (res == DialogResult.Cancel)
            {
                urunEklendimi = false;
            }
        }
        void sepeteEkle()
        {
            urunAdedi = Convert.ToInt16(txtBoxAdet.Text);
            lstBoxSepetim.Items.Add(secilensatir.ToString() + " " + "x" + urunAdedi.ToString());
            toplamTutar = (secilensatir3 * urunAdedi) + toplamTutar;
            txtBoxToplamTutar.Text = Convert.ToString(toplamTutar) +"TL";
        }
        public int VarMi(string aranan)
        {
            int sonuc;
            SqlConnection con = new SqlConnection(@"Server=.;Database=MarketDataBases;Trusted_Connection=true");
            string sorgu = "Select COUNT(KullaniciAdi) from Kullanicilar WHERE KullaniciAdi ='" + aranan + "'";
            cmd = new SqlCommand(sorgu, con);
            con.Open();
            sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return sonuc;
        }
        public int VarMi2(string aranan2)
        {
            int sonuc2;
            SqlConnection con = new SqlConnection(@"Server=.;Database=MarketDataBases;Trusted_Connection=true");
            string sorgu = "Select COUNT(Sifre) from Kullanicilar WHERE Sifre ='" + aranan2 + "'";
            cmd = new SqlCommand(sorgu, con);
            con.Open();
            sonuc2 = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return sonuc2;
        }
        public void ResimGosterDataGridView()
        {
            SqlConnection con = new SqlConnection(@"Server=.;Database=MarketDataBases;Trusted_Connection=true");
            con.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select UrunId,UrunResim,UrunAd,UrunAded,UrunFiyat,UrunCesit from Urunler", con);
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            ds = new DataSet();
            dt.Columns.Add("UrunResmi", Type.GetType("System.Byte[]"));
            foreach (DataRow item in dt.Rows)
            {
                item["UrunResmi"] = File.ReadAllBytes(item["UrunResim"].ToString());
            }
            dtGrdView1.DataSource = dt;
            con.Close();
            dtGrdView1.Columns[1].Visible = false;
            this.dtGrdView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGrdView1.Refresh();
            table = new DataTable();
            table = dt;
        }
        void veriTabaniKisiler()
        {
            ResimGosterDataGridView();
            SqlConnection con = new SqlConnection(@"Server=.;Database=MarketDataBases;Trusted_Connection=true");
            con.Open();
            da = new SqlDataAdapter("Select * from Urunler", con);
            cmda = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Urunler");
            con.Close();
        }

        private void bttnKayitOl_Click(object sender, EventArgs e)
        {
            grpBoxGirisYap.Visible = false;
            grpBoxKayıtOl.Visible = true;
        }
        private void bttnGirisYap_Click(object sender, EventArgs e)
        {
            if (VarMi(txtBoxKullaniciAd.Text) == 1 && (VarMi2(textBox3.Text) == 1))
            {
                MessageBox.Show("Giriş Başarılı");
                grpBoxGirisYap.Visible = false;
                grpBoxKullaniciBilgileri.Visible = true;
                grpBoxSepetim.Visible = true;
                grpBoxKayıtOl.Visible = false;
                bttnCikisYap.Visible = true;
                label8.Text = txtBoxKullaniciAd.Text;
                
                string Eposta = "", TelefonNo = "", Resim = "";
                SqlConnection con = new SqlConnection(@"Server=.;Database=MarketDataBases;Trusted_Connection=true");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Kullanicilar where KullaniciAdi=@KullaniciAdi ", con);
                cmd.Parameters.AddWithValue("@KullaniciAdi", txtBoxKullaniciAd.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Eposta = dr["Eposta"].ToString();
                    TelefonNo = dr["Telefon"].ToString();
                    Resim = dr["ProfilResmi"].ToString();
                    
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                grpBoxUrunler.Visible = true;
                label13.Visible = true;
                txtBoxToplamTutar.Visible = true;
                label9.Text = Eposta;
                label10.Text = TelefonNo;
                pictureBox1.Image = Image.FromFile(Resim);
                }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
        }
        private void bttnKayitTamamla_Click(object sender, EventArgs e)
        {
            if(VarMi(txtBoxKullaniciAdi.Text) == 1)
            {
                MessageBox.Show("Bu Kullanıcı Adı Daha Önce Alınmış");
            }
            else
            {
                if (pictureBox2.Image == null)
                {
                    MessageBox.Show("Lütfen Resim Seçiniz");
                    grpBoxGirisYap.Visible = false;
                    grpBoxKayıtOl.Visible = true;
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Server=.;Database=MarketDataBases;Trusted_Connection=true");
                    string sorgu = "Insert into Kullanicilar(KullaniciAdi,Sifre,Eposta,Telefon,ProfilResmi) values (@KullaniciAdi,@Sifre,@Eposta,@Telefon,@ProfilResmi)";
                        cmd = new SqlCommand(sorgu, con);
                        cmd.Parameters.AddWithValue("@KullaniciAdi", txtBoxKullaniciAdi.Text);
                        cmd.Parameters.AddWithValue("@Sifre", txtBoxSifre.Text);
                        cmd.Parameters.AddWithValue("@Eposta", txtBoxEposta.Text);
                        cmd.Parameters.AddWithValue("@Telefon", txtBoxTelefonNo.Text);
                        cmd.Parameters.AddWithValue("@ProfilResmi", pictureBox2.ImageLocation);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ResimGosterDataGridView();
                        MessageBox.Show("Kayıt Tamamlandı");
                        MessageBox.Show("Market Butonuna Tıklayıp Giriş Yapınız");
                        Application.Restart();
                }
            }
            
        }

        private void bttnCikisYap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış Başarılı");
            grpBoxGirisYap.Visible = true;
            grpBoxKullaniciBilgileri.Visible = false;
            grpBoxSepetim.Visible = false;
            grpBoxKayıtOl.Visible = false;
            bttnCikisYap.Visible = false;
            grpBoxUrunler.Visible = false;
            label13.Visible = false;
            txtBoxToplamTutar.Visible = false;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            grpBoxGirisYap.Visible = true;
            bttnCikisYap.Visible = false;
            grpBoxUrunler.Visible = false;
            label13.Visible = false;
            txtBoxToplamTutar.Visible = false;
            ResimGosterDataGridView();
            veriTabaniKisiler();
        }
        private void bttnResimSec_Click(object sender, EventArgs e)
        {
            oFileDialog1.Title = "ResimSeç";
            oFileDialog1.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            oFileDialog1.ShowDialog();
            string dosyayolu = oFileDialog1.FileName;
            pictureBox2.ImageLocation = dosyayolu;
        }
        private void bttnSepetiSil_Click(object sender, EventArgs e)
        {
            lstBoxSepetim.Items.Clear();
            txtBoxToplamTutar.Text = " ";
        }

        private void bttnSatinAl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürünler Satın Alınmıştır");
            lstBoxSepetim.Items.Clear();
            txtBoxToplamTutar.Text = " ";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataView dv = table.DefaultView;
            dv.RowFilter = "UrunAd LIKE '" + txtBoxArama.Text + "%'";
            dtGrdView1.DataSource = dv;
        }

        private void dtGrdView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            urunEklensinMi();
         
            secilensatir = Convert.ToString(ds.Tables["Urunler"].Rows[e.RowIndex]["UrunAd"]);
            secilensatir2 = Convert.ToString(ds.Tables["Urunler"].Rows[e.RowIndex]["UrunAded"]);
            secilensatir3 = Convert.ToDecimal(ds.Tables["Urunler"].Rows[e.RowIndex]["UrunFiyat"]);
           

            if (urunEklendimi == false)
            {
                MessageBox.Show("Ürün Eklenemedi");
            }
            else
            {
                if (txtBoxAdet.Text == "")
                {
                    MessageBox.Show("Lütfen Adet Giriniz");
                }
                else
                {
                    if (lstBoxSepetim.Items.Contains(secilensatir + " " + "x" + urunAdedi.ToString()))
                    {
                        MessageBox.Show("Sepette aynı ürün bulunmakta!");
                    }
                    else
                    {
                        if (Convert.ToInt32(txtBoxAdet.Text) > Convert.ToInt32(secilensatir2))
                        {
                            MessageBox.Show("Bu Üründen Maksimum"+ " " + secilensatir2 + " " + "adet sepete ekleyebilirsiniz.");
                        }
                        else
                        {
                            sepeteEkle();
                        }
                    }

                }
            }
        }

        private void bttnUrunCikar_Click(object sender, EventArgs e)
        {
            int secim = lstBoxSepetim.SelectedIndex;
            if (secim != -1)
            {
                lstBoxSepetim.Items.RemoveAt(secim);
            }
            else
            {
                MessageBox.Show("Lütfen Ürün Seçimi Yapınız");
            }
        }
    }
}
