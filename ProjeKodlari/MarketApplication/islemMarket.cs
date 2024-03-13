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
    public partial class islemMarket : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public islemMarket()
        {
            InitializeComponent();
        }
        // FONKSİYONLAR
        
        public void ResimGosterDataGridView()
        {
            SqlConnection con = new SqlConnection(@"Server=.;Database=MarketDataBases;Trusted_Connection=true");
            con.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select UrunId,UrunResim,UrunAd,UrunAded,UrunFiyat,UrunCesit from Urunler",con);
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            dt.Columns.Add("UrunResmi", Type.GetType("System.Byte[]"));
            foreach (DataRow item in dt.Rows)
            {
                item["UrunResmi"] = File.ReadAllBytes(item["UrunResim"].ToString());
            }
            dtGrdView1.DataSource = dt;
            con.Close();
            this.dtGrdView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGrdView1.Columns[1].Visible = false;
            dtGrdView1.Refresh();
        }
        public int SqlVarMi(string aranan)
        {
            int sonuc1;
            SqlConnection con = new SqlConnection(@"Server=.;Database=MarketDataBases;Trusted_Connection=true");
            string sorgu = "Select COUNT(UrunAd) from Urunler WHERE UrunAd='" + aranan + "'";
            cmd = new SqlCommand(sorgu, con);
            con.Open();
            sonuc1 = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return sonuc1;
        }
        public int SqlVarMi2(string aranan)
        {
            int sonuc2;
            SqlConnection con = new SqlConnection(@"Server=.;Database=MarketDataBases;Trusted_Connection=true");
            string sorgu = "Select COUNT(UrunId) from Urunler WHERE UrunId='" + aranan + "'";
            cmd = new SqlCommand(sorgu, con);
            con.Open();
            sonuc2 = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return sonuc2;
        }

        // BUTTON İŞLEMLERİ
        private void bttnResimSec_Click(object sender, EventArgs e)
        {
            oFileDialog1.Title = "ResimSeç";
            oFileDialog1.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            oFileDialog1.ShowDialog();
            string dosyayolu = oFileDialog1.FileName;
            pictureBox1.ImageLocation = dosyayolu;
        }
        private void bttnEkle_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen Resim Seçiniz");
            }
            else
            {
                if (SqlVarMi(txtUrunAd.Text) != 0)
                {
                    MessageBox.Show("Bu Ürün Adı ile daha önce kayıt yapılmış");
                }
                else
                {
                    if (SqlVarMi2(txtUrunId.Text) != 0)
                    {
                        MessageBox.Show("Bu Ürün Id'si ile daha önce kayıt yapılmış");
                    }
                    else
                    {
                        if (pictureBox1.Image.Width > 128 || pictureBox1.Image.Height > 128)
                        {
                            MessageBox.Show("Fotoğraf boyutu en fazla 128x128 olmalıdır.");
                        }
                        else
                        {

                            SqlConnection con = new SqlConnection(@"Server=.;Database=MarketDataBases;Trusted_Connection=true");
                            string sorgu = "Insert into Urunler (UrunId,UrunResim,UrunAd,UrunAded,UrunFiyat,UrunCesit) values (@UrunId,@UrunResim,@UrunAd,@UrunAded,@UrunFiyat,@UrunCesit)";
                            cmd = new SqlCommand(sorgu, con);
                            cmd.Parameters.AddWithValue("@UrunId", txtUrunId.Text);
                            cmd.Parameters.AddWithValue("@UrunResim", pictureBox1.ImageLocation);
                            cmd.Parameters.AddWithValue("@UrunAd", txtUrunAd.Text);
                            cmd.Parameters.AddWithValue("@UrunAded", txtUrunAdet.Text);
                            cmd.Parameters.AddWithValue("@UrunFiyat", txtUrunFiyat.Text);
                            cmd.Parameters.AddWithValue("@UrunCesit", txtUrunCesit.Text);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            ResimGosterDataGridView();
                            MessageBox.Show("Ürün Kaydedildi");
                        }
                    }
                }
            }
        }private void bttnDuzenle_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image.Width > 128 || pictureBox1.Image.Height > 128)
            {
                MessageBox.Show("Fotoğraf boyutu en fazla 128x128 olmalıdır.");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Server=.;Database=MarketDataBases;Trusted_Connection=true");
                string sorgu = "UPDATE Urunler SET @UrunId=UrunId,UrunResim=@UrunResim,UrunAd=@UrunAd,UrunAded=@UrunAded,UrunFiyat=@UrunFiyat,UrunCesit=@UrunCesit WHERE UrunId=@UrunId";
                cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@UrunId", txtUrunId.Text);
                cmd.Parameters.AddWithValue("@UrunResim", pictureBox1.ImageLocation);
                cmd.Parameters.AddWithValue("@UrunAd", txtUrunAd.Text);
                cmd.Parameters.AddWithValue("@UrunAded", txtUrunAdet.Text);
                cmd.Parameters.AddWithValue("@UrunFiyat", txtUrunFiyat.Text);
                cmd.Parameters.AddWithValue("@UrunCesit", txtUrunCesit.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                ResimGosterDataGridView();
                MessageBox.Show("Ürün Güncellendi");
            }
        }
        private void bttnSil_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtGrdView1.SelectedRows.Count; i++)
            {
                SqlConnection con = new SqlConnection(@"Server=.;Database=MarketDataBases;Trusted_Connection=true");
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Urunler where UrunId='" + dtGrdView1.SelectedRows[i].Cells["UrunId"].Value.ToString() + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            ResimGosterDataGridView();
            MessageBox.Show("Ürün Silindi");
        }
        // DATAGRİDVİEW İŞLEMLERİ
        private void dtGrdView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.ImageLocation = dtGrdView1.CurrentRow.Cells[1].Value.ToString();
            txtUrunId.Text = dtGrdView1.CurrentRow.Cells[0].Value.ToString();
            txtUrunAd.Text = dtGrdView1.CurrentRow.Cells[2].Value.ToString();
            txtUrunAdet.Text = dtGrdView1.CurrentRow.Cells[3].Value.ToString();
            txtUrunFiyat.Text = dtGrdView1.CurrentRow.Cells[4].Value.ToString();
            txtUrunCesit.Text = dtGrdView1.CurrentRow.Cells[5].Value.ToString();
        }
        private void dtGrdView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtGrdView1.CurrentRow.Selected = true;
            int id = Convert.ToInt32(dtGrdView1.Rows[e.RowIndex].Cells["UrunId"].FormattedValue);
            SqlConnection con = new SqlConnection(@"Server=.;Database=MarketDataBases;Trusted_Connection=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("select ImageFile from Urunler Where Id = '" + id + "'", con);
            string img = cmd.ExecuteScalar().ToString();
            pictureBox1.Image = Image.FromFile(img);
            con.Close();
        }
        //FORM İŞLEMLERİ
        private void islemMarket_Load(object sender, EventArgs e)
        {
            ResimGosterDataGridView();
            
        }
        // TEXTBOX İŞLEMLERİ
        private void txtUrunAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void txtUrunAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtUrunFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtUrunCesit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
              && !char.IsSeparator(e.KeyChar);
        }

        private void txtUrunId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
    }

