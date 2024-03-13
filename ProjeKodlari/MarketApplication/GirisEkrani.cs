using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketApplication
{
    public partial class GirisEkrani : Form
    {
        string KullaniciAdi = "Emircan";
        string Sifre = "Kahveci";
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            bttnMarketİslemleri.Visible = false;
        }

        private void bttnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == KullaniciAdi && txtSifre.Text == Sifre)
            {
                MessageBox.Show("Giriş Başarılı");
                bttnMarketİslemleri.Visible = true;
                Refresh();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
        }

        private void bttnMarketİslemleri_Click(object sender, EventArgs e)
        {
            islemMarket islemMarket = new islemMarket();
            islemMarket.ShowDialog();
        }

        private void bttnMarketGiris_Click(object sender, EventArgs e)
        {
            Market market = new Market();
            market.ShowDialog();
        }

        private void bttnKayıtlıGiris_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = "Emircan";
            txtSifre.Text = "Kahveci";
        }
    }
}
