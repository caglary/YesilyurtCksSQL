using System;
using System.Drawing;
using System.Windows.Forms;
using Yesilyurt_Ciftci_Kayit.Entities;
using icmaller;
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
            labelYear.Text= $"{uretimSezonuYili} yılı için yapılan kayıtlar     "+Environment.MachineName;
            if (uretimSezonuYili=="2021")
            {
                pictureBoxTMO.Visible = false;
                pictureBoxCksIslemleri.Visible= false;
                labelYear.ForeColor=Color.White;
                btn_icmaller.Visible= false;
                btnIcmal2023.Visible = false;
            }
            else if (uretimSezonuYili == "2022")
            {
                pictureBoxTMO.Visible = false;
                pictureBoxCksIslemleri.Visible = false;
                btn_icmaller.Visible = false;
                btnIcmal2023.Visible = false;
                labelYear.ForeColor = Color.Red;


            }
            else if (uretimSezonuYili == "2023")
            {
                pictureBoxTMO.Visible = false;
                labelYear.ForeColor = Color.Yellow;
                btnIcmal2023.Visible = false;
            }
            else if (uretimSezonuYili == "2024")
            {
                pictureBoxTMO.Visible = false;
                labelYear.ForeColor = Color.Blue;
                btn_icmaller.Visible = false;
                pictureBoxFirmalar.Visible = false;
                pictureBoxUrunler.Visible = false;
                pictureBoxSifreDegistir.Visible= false;
         
               
            }
        }
        private void btnCiftciler_Click(object sender, EventArgs e)
        {
            if (kullanici.Yetki == "Write")
            {
                Utilities.FormProperties.FormOpen("CiftcilerForm", new CiftcilerForm(kullanici), this, false);
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
            Utilities.FormProperties.FormOpen("ListelerForm", new ListelerForm(kullanici), this, false);
        }
        private void pictureBoxCksIslemleri_Click(object sender, EventArgs e)
        {
           
            Utilities.FormProperties.FormOpen("CksForm", new CksForm(kullanici), this, false);
        }
        private void pictureBoxTMO_Click(object sender, EventArgs e)
        {
            Utilities.FormProperties.FormOpen("TMOForm", new TMOForm(kullanici), this, true);
        }

        private void btn_icmaller_Click(object sender, EventArgs e)
        {
            Utilities.FormProperties.FormOpen("icmaller", new icmallerForm(), this, true);
        }

        private void btnIcmal2023_Click(object sender, EventArgs e)
        {
            Utilities.FormProperties.FormOpen("icmaller 2023", new Form1(), this, true);
        }
    }
}
