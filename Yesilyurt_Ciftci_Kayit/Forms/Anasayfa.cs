using Microsoft.Office.Interop.Excel;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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
            if (uretimSezonuYili=="2021")
            {
                pictureBoxTMO.Visible = false;
                pictureBoxCksIslemleri.Visible= false;
                labelYear.ForeColor=Color.White;
            }
            else if (uretimSezonuYili == "2022")
            {
                pictureBoxTMO.Visible = false;
                pictureBoxCksIslemleri.Visible = false;

                labelYear.ForeColor = Color.Red;


            }
            else if (uretimSezonuYili == "2023")
            {
                pictureBoxTMO.Visible = false;
              

                labelYear.ForeColor = Color.Yellow;
                


            }
        }
        private void btnCiftciler_Click(object sender, EventArgs e)
        {
            if (kullanici.Yetki == "Write")
            {
                Utilities.FormProperties.FormOpen("CiftcilerForm", new CiftcilerForm(kullanici), this, true);
            }
        }
        private void btnFirmalar_Click(object sender, EventArgs e)
        {
            Utilities.FormProperties.FormOpen("FirmaForm", new FirmaForm(kullanici), this, true);
        }
        private void btnUrunler_Click(object sender, EventArgs e)
        {
            Utilities.FormProperties.FormOpen("UrunForm", new UrunForm(kullanici), this, true);
        }
        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            Utilities.FormProperties.FormOpen("KullaniciSifreForm", new KullaniciSifreForm(kullanici), this, true);
        }
       
        private void pictureBoxListeter_Click(object sender, EventArgs e)
        {
            Utilities.FormProperties.FormOpen("ListelerForm", new ListelerForm(kullanici), this, true);
        }
        private void pictureBoxCksIslemleri_Click(object sender, EventArgs e)
        {
           
            Utilities.FormProperties.FormOpen("CksForm", new CksForm(kullanici), this, true);
        }
        private void pictureBoxTMO_Click(object sender, EventArgs e)
        {
            Utilities.FormProperties.FormOpen("TMOForm", new TMOForm(kullanici), this, true);
        }
    }
}
