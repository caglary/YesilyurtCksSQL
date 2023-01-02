using System;
using System.Windows.Forms;
using Yesilyurt_Ciftci_Kayit.Entities;
namespace Yesilyurt_Ciftci_Kayit.Forms
{
    public partial class Anasayfa : Form
    {
        Kullanici kullanici;
        public Anasayfa(Kullanici k)
        {
            InitializeComponent();
            kullanici = k;
        }
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            if (kullanici.Yetki == "Read")
            {
                pictureBoxSifreDegistir.Visible = false;
                pictureBoxUrunler.Visible = false;
                pictureBoxFirmalar.Visible = false;
                pictureBoxCiftciler.Visible = false;
                pictureBoxCksIslemleri.Visible = false;
            }
            string connectionstring =Utilities.ConnectionString.Get().Substring(0, 36);
            
            this.Text = $"Hoşgeldin {kullanici.KullaniciAdi} - {Utilities.ConnectionString.TeachYearFromFile()} Yılı için çalışıyorsunuz.  {connectionstring}";
            string uretimSezonuYili = Utilities.ConnectionString.TeachYearFromFile();
            labelYear.Text= $"{uretimSezonuYili} yılı için yapılan kayıtlar";
            if (uretimSezonuYili=="2023")
            {
                pictureBoxTMO.Visible = false;
            }    
        }
        private void btnCiftciler_Click(object sender, EventArgs e)
        {
            if (kullanici.Yetki == "Write")
            {
                Utilities.FormProperties.FormOpen("CiftcilerForm", new CiftcilerForm(kullanici), this, false);
            }
        }
        private void Anasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnFirmalar_Click(object sender, EventArgs e)
        {
            Utilities.FormProperties.FormOpen("FirmaForm", new FirmaForm(kullanici), this, false);
        }
        private void btnUrunler_Click(object sender, EventArgs e)
        {
            Utilities.FormProperties.FormOpen("UrunForm", new UrunForm(kullanici), this, false);
        }
        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            Utilities.FormProperties.FormOpen("KullaniciSifreForm", new KullaniciSifreForm(kullanici), this, false);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBoxListeter_Click(object sender, EventArgs e)
        {
            Utilities.FormProperties.FormOpen("ListelerForm", new ListelerForm(kullanici), this, false);
        }
        private void pictureBoxCksIslemleri_Click(object sender, EventArgs e)
        {
            Utilities.FormProperties.FormOpen("CksForm", new CksForm(kullanici), this, false);
        }
        private void pictureBoxTMO_Click(object sender, EventArgs e)
        {
            Utilities.FormProperties.FormOpen("TMOForm", new TMOForm(kullanici), this, false);
        }
    }
}
