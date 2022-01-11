using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Entities.PrintTablo;
using Yesilyurt_Ciftci_Kayit.Manager;

namespace Yesilyurt_Ciftci_Kayit.Forms
{
    public partial class ListelerForm : Form
    {
        YemBitkisiManager _yemBitkisiManager;
        FarkOdemesiManager _farkOdemesiManager;
        SertifikaliTohumManager _sertifikaliTohumManager;
        CksManager _cksManager;
        Kullanici _kullanici;
        Butonclick activeButon;

        public ListelerForm(Kullanici kullanici)
        {
            InitializeComponent();
            _yemBitkisiManager = new YemBitkisiManager();
            _farkOdemesiManager = new FarkOdemesiManager();
            _sertifikaliTohumManager = new SertifikaliTohumManager();
            _cksManager = new CksManager();
            _kullanici = kullanici;
        }

        private void btnYemBitkisiDestegi_Click(object sender, EventArgs e)
        {
            groupBoxYemKontrolDurumu.Visible = true;


            activeButon = Butonclick.Yembitkileri;
            var liste = _yemBitkisiManager.GetAll_YemBitkileri_ForPrint();
            dgwListe.DataSource = liste;
            Button buton = (Button)sender;
            lblKayitSayisi.Text = $"{buton.Text} Toplam Kayıt Sayısı:  {liste.Count}  Adet";

        }

        private void btnFarkOdemesiDestegi_Click(object sender, EventArgs e)
        {
            groupBoxYemKontrolDurumu.Visible = false;


            activeButon = Butonclick.FarkOdemesi;
            var liste = _farkOdemesiManager.GetAll_FarkOdemesi_ForPrint();
            dgwListe.DataSource = liste;
            Button buton = (Button)sender;
            lblKayitSayisi.Text = $"{buton.Text} Toplam Kayıt Sayısı:  {liste.Count}  Adet";
        }

        private void btnSertifikaliTohumDestegi_Click(object sender, EventArgs e)
        {
            groupBoxYemKontrolDurumu.Visible = false;


            activeButon = Butonclick.Sertifikalı;
            var liste = _sertifikaliTohumManager.GetAll_SertifikaliTohum_ForPrint();
            dgwListe.DataSource = liste;
            Button buton = (Button)sender;
            lblKayitSayisi.Text = $"{buton.Text} Toplam Kayıt Sayısı:  {liste.Count}  Adet";

        }
        private void btnCksListesi_Click(object sender, EventArgs e)
        {
            groupBoxYemKontrolDurumu.Visible = false;


            activeButon = Butonclick.CksListesi;
            dgwListe.DataSource = null;
            var liste = _cksManager.GetAll_CKS_ForPrint();
            dgwListe.DataSource = liste;
            Button buton = (Button)sender;
            lblKayitSayisi.Text = $"{buton.Text} Toplam Kayıt Sayısı:  {liste.Count}  Adet";
           

        }
        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (activeButon == Butonclick.Yembitkileri)
            {
                if (string.IsNullOrEmpty(txtSearchByName.Text))
                {
                    dgwListe.DataSource = _yemBitkisiManager.GetAll_YemBitkileri_ForPrint();
                    return;
                }
                dgwListe.DataSource = _yemBitkisiManager.GetAll_YemBitkileri_ForPrint().Where(I => I.IsimSoyisim.ToLower().Contains(txtSearchByName.Text.ToLower())).ToList();
            }
            if (activeButon == Butonclick.FarkOdemesi)
            {
                if (string.IsNullOrEmpty(txtSearchByName.Text))
                {
                    dgwListe.DataSource = _farkOdemesiManager.GetAll_FarkOdemesi_ForPrint();
                    return;
                }
                dgwListe.DataSource = _farkOdemesiManager.GetAll_FarkOdemesi_ForPrint().Where(I => I.IsimSoyisim.ToLower().Contains(txtSearchByName.Text.ToLower())).ToList();
            }
            if (activeButon == Butonclick.Sertifikalı)
            {
                if (string.IsNullOrEmpty(txtSearchByName.Text))
                {
                    dgwListe.DataSource = _sertifikaliTohumManager.GetAll_SertifikaliTohum_ForPrint();
                    return;
                }
                dgwListe.DataSource = _sertifikaliTohumManager.GetAll_SertifikaliTohum_ForPrint().Where(I => I.IsimSoyisim.ToLower().Contains(txtSearchByName.Text.ToLower())).ToList();
            }
            if (activeButon == Butonclick.CksListesi)
            {
                if (string.IsNullOrEmpty(txtSearchByName.Text))
                {
                    dgwListe.DataSource = _cksManager.GetAll_CKS_ForPrint();
                    return;
                }
                dgwListe.DataSource = _cksManager.GetAll_CKS_ForPrint().Where(I => I.IsimSoyisim.ToLower().Contains(txtSearchByName.Text.ToLower())).ToList();
            }
        }

        private void txtSearchByTc_TextChanged(object sender, EventArgs e)
        {
            if (activeButon == Butonclick.Yembitkileri)
            {
                if (string.IsNullOrEmpty(txtSearchByTc.Text))
                {
                    dgwListe.DataSource = _yemBitkisiManager.GetAll_YemBitkileri_ForPrint();
                    return;
                }
                dgwListe.DataSource = _yemBitkisiManager.GetAll_YemBitkileri_ForPrint().Where(I => I.TcKimlikNo.Contains(txtSearchByTc.Text)).ToList();
            }
            if (activeButon == Butonclick.FarkOdemesi)
            {
                if (string.IsNullOrEmpty(txtSearchByTc.Text))
                {
                    dgwListe.DataSource = _farkOdemesiManager.GetAll_FarkOdemesi_ForPrint();
                    return;
                }
                dgwListe.DataSource = _farkOdemesiManager.GetAll_FarkOdemesi_ForPrint().Where(I => I.TcKimlikNo.Contains(txtSearchByTc.Text)).ToList();
            }
            if (activeButon == Butonclick.Sertifikalı)
            {
                if (string.IsNullOrEmpty(txtSearchByTc.Text))
                {
                    dgwListe.DataSource = _sertifikaliTohumManager.GetAll_SertifikaliTohum_ForPrint();
                    return;
                }
                dgwListe.DataSource = _sertifikaliTohumManager.GetAll_SertifikaliTohum_ForPrint().Where(I => I.TcKimlikNo.Contains(txtSearchByTc.Text)).ToList();
            }
            if (activeButon == Butonclick.CksListesi)
            {
                if (string.IsNullOrEmpty(txtSearchByTc.Text))
                {
                    dgwListe.DataSource = _cksManager.GetAll_CKS_ForPrint();
                    return;
                }
                dgwListe.DataSource = _cksManager.GetAll_CKS_ForPrint().Where(I => I.TcKimlikNo.Contains(txtSearchByTc.Text)).ToList();
            }
        }

        private void txtSearchByDosyaNo_TextChanged(object sender, EventArgs e)
        {
            if (activeButon == Butonclick.Yembitkileri)
            {
                if (string.IsNullOrEmpty(txtSearchByDosyaNo.Text))
                {
                    dgwListe.DataSource = _yemBitkisiManager.GetAll_YemBitkileri_ForPrint();
                    return;
                }

                dgwListe.DataSource = _yemBitkisiManager.GetAll_YemBitkileri_ForPrint().Where(I => I.DosyaNo == (Convert.ToInt32(txtSearchByDosyaNo.Text))).ToList();
            }
            if (activeButon == Butonclick.FarkOdemesi)
            {
                if (string.IsNullOrEmpty(txtSearchByDosyaNo.Text))
                {
                    dgwListe.DataSource = _farkOdemesiManager.GetAll_FarkOdemesi_ForPrint();
                    return;
                }

                dgwListe.DataSource = _farkOdemesiManager.GetAll_FarkOdemesi_ForPrint().Where(I => I.DosyaNo == (Convert.ToInt32(txtSearchByDosyaNo.Text))).ToList();
            }
            if (activeButon == Butonclick.Sertifikalı)
            {
                if (string.IsNullOrEmpty(txtSearchByDosyaNo.Text))
                {
                    dgwListe.DataSource = _sertifikaliTohumManager.GetAll_SertifikaliTohum_ForPrint();
                    return;
                }

                dgwListe.DataSource = _sertifikaliTohumManager.GetAll_SertifikaliTohum_ForPrint().Where(I => I.DosyaNo == (Convert.ToInt32(txtSearchByDosyaNo.Text))).ToList();
            }
            if (activeButon == Butonclick.CksListesi)
            {
                if (string.IsNullOrEmpty(txtSearchByDosyaNo.Text))
                {
                    dgwListe.DataSource = _cksManager.GetAll_CKS_ForPrint();
                    return;
                }

                dgwListe.DataSource = _cksManager.GetAll_CKS_ForPrint().Where(I => I.DosyaNo == (Convert.ToInt32(txtSearchByDosyaNo.Text))).ToList();
            }

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (activeButon == Butonclick.Yembitkileri)
            {
                var datatable = Utilities.ExcelExport.ConvertToDataTable<YemBitkileriPrint>(_yemBitkisiManager.GetAll_YemBitkileri_ForPrint());
                var path = Utilities.FolderBrowser.Path();
                path = path + @"\YemBitkisiMuracaatlari.xlsx";
                Utilities.Mesaj.MessageBoxInformation("Kayıt işleminiz başladı.İşlem tamamlandığında bilgilendirileceksiniz.");
                Task.Run(() => { Utilities.ExcelExport.GenerateExcel(datatable, path); });
            }

            if (activeButon == Butonclick.Sertifikalı)
            {
                var datatable = Utilities.ExcelExport.ConvertToDataTable<SertifikaliTohumPrint>(_sertifikaliTohumManager.GetAll_SertifikaliTohum_ForPrint());
                var path = Utilities.FolderBrowser.Path();
                path = path + @"\SertifikaliTohumMuracaatlari.xlsx";
                Utilities.Mesaj.MessageBoxInformation("Kayıt işleminiz başladı.İşlem tamamlandığında bilgilendirileceksiniz.");
                Task.Run(() => { Utilities.ExcelExport.GenerateExcel(datatable, path); });
            }
            if (activeButon == Butonclick.FarkOdemesi)
            {
                var datatable = Utilities.ExcelExport.ConvertToDataTable<FarkOdemesiPrint>(_farkOdemesiManager.GetAll_FarkOdemesi_ForPrint());
                var path = Utilities.FolderBrowser.Path();
                path = path + @"\FarkOdemesiMuracaatlari.xlsx";
                Utilities.Mesaj.MessageBoxInformation("Kayıt işleminiz başladı.İşlem tamamlandığında bilgilendirileceksiniz.");
                Task.Run(() => { Utilities.ExcelExport.GenerateExcel(datatable, path); });
            }
            if (activeButon == Butonclick.CksListesi)
            {
                var datatable = Utilities.ExcelExport.ConvertToDataTable<CksListesiPrint>(_cksManager.GetAll_CKS_ForPrint());
                var path = Utilities.FolderBrowser.Path();
                path = path + @"\CKS_Muracaatlari.xlsx";
                Utilities.Mesaj.MessageBoxInformation("Kayıt işleminiz başladı.İşlem tamamlandığında bilgilendirileceksiniz.");
                Task.Run(() => { Utilities.ExcelExport.GenerateExcel(datatable, path); });
            }

        }





        private void ListelerForm_Load(object sender, EventArgs e)
        {
            activeButon = Butonclick.Empty;
            Utilities.Datagrid.DataGridSettings(dgwListe);
            lblKayitSayisi.Text = "";
            groupBoxYemKontrolDurumu.Visible = false;
        }

       


        private void radioButtonUygun_Click(object sender, EventArgs e)
        {
            var liste = _yemBitkisiManager.GetAll_YemBitkileri_ForPrint().Where(I=>I.KontrolDurumu== "UYGUNDUR").ToList();
            dgwListe.DataSource = liste;
            RadioButton buton = (RadioButton)sender;
            lblKayitSayisi.Text = $"{buton.Text} Toplam Kayıt Sayısı:  {liste.Count}  Adet";
        }

        private void radioButtonUygunDegil_Click(object sender, EventArgs e)
        {
            var liste = _yemBitkisiManager.GetAll_YemBitkileri_ForPrint().Where(I => I.KontrolDurumu == "UYGUN DEGİLDİR").ToList();
            dgwListe.DataSource = liste;
            RadioButton buton = (RadioButton)sender;
            lblKayitSayisi.Text = $"{buton.Text} Toplam Kayıt Sayısı:  {liste.Count}  Adet";
        }

        private void radioButtonAraziKontrolEdilmedi_Click(object sender, EventArgs e)
        {
            var liste = _yemBitkisiManager.GetAll_YemBitkileri_ForPrint().Where(I => I.KontrolDurumu == "Arazi Kontrol Edilmedi.").ToList();
            dgwListe.DataSource = liste;
            RadioButton buton = (RadioButton)sender;
            lblKayitSayisi.Text = $"{buton.Text} Toplam Kayıt Sayısı:  {liste.Count}  Adet";
        }

        //when datagridview doubleClick event 

        private void dgwListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgwListe.CurrentRow.Index;
            string tcNo = dgwListe.Rows[index].Cells["TcKimlikNo"].Value.ToString();

            if (activeButon==Butonclick.CksListesi)
            {
                Utilities.FormProperties.FormOpen("CksForm", new CksForm(_kullanici, tcNo), this, true);
                Utilities.Mesaj.MessageBoxInformation(tcNo+"\n"+_kullanici.KullaniciAdi);
            }
                   }

        private void dgwListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgwListe.CurrentRow.Index;
            string tcNo = dgwListe.Rows[index].Cells["TcKimlikNo"].Value.ToString();
            Clipboard.SetText(tcNo);
        }
    }
    enum Butonclick
    {
        FarkOdemesi, Yembitkileri, Sertifikalı, Empty, CksListesi
    }
}
