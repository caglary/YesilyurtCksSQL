using System;
using System.Windows.Forms;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Manager;

namespace Yesilyurt_Ciftci_Kayit.Forms
{
    public partial class KullaniciSifreForm : Form
    {
        Kullanici _kullanici;
        KullaniciManager _kullaniciManager;
        public KullaniciSifreForm(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
            _kullaniciManager = new KullaniciManager();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KullaniciSifreForm_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = _kullanici.KullaniciAdi;
            txtKullaniciAdi.Enabled = false;
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            
            if (_kullanici.Parola!=txtSifre.Text)
            {
                Utilities.Mesaj.MessageBoxWarning("Parolanızı yanlış girdiniz.");
                return;
            }
            if (txtYeniSifre.Text!=txtYeniSifreTekrar.Text)
            {
                Utilities.Mesaj.MessageBoxWarning("Yeni sifre ve Yeni sifre tekrar kısımlarını farklı girdiniz.");
                return;
            }
            _kullanici.Parola = txtYeniSifre.Text;
            int result= _kullaniciManager.Update(_kullanici);
            if (result==1)
            {
                Utilities.Mesaj.MessageBoxInformation("Şifreniz değiştirildi.");
                this.Close();
            }

        }

    }
}
