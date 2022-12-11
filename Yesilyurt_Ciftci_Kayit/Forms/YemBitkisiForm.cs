using System;
using System.Linq;
using System.Windows.Forms;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Manager;

namespace Yesilyurt_Ciftci_Kayit.Forms
{
    public partial class YemBitkisiForm : Form
    {
        Kullanici _kullanici;
        UrunManager _urunManager;
        Ciftci _ciftci;
        YemBitkisiManager _yemBitkisiManager;
        
        CksManager _cksManager;
        YemBitkisi _yemKayit;
        int _index;
        public YemBitkisiForm(Kullanici kullanici, Ciftci ciftci,string FormAdi)
        {
            InitializeComponent();
            _kullanici = kullanici;
            _urunManager = new UrunManager();
            _ciftci = ciftci;
            _yemBitkisiManager = new YemBitkisiManager();
            _cksManager = new CksManager();
            _yemKayit = null;
            this.Text = $"{FormAdi} Formu";
        }

        private void YemBitkisiForm_Load(object sender, System.EventArgs e)
        {

            if (_kullanici.Yetki == "Read")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

            ComboboxFillData();

            lblCiftciIsim.Text = $"{_ciftci.IsimSoyisim.ToUpper()} / {_ciftci.MahalleKoy.ToUpper()}";
            this.Text = $"Hoşgeldin {_kullanici.KullaniciAdi} - {Utilities.ConnectionString.TeachYearFromFile()} Yılı için çalışıyorsunuz.";

            RefreshList();

        }

        private void RefreshList()
        {
            var cksId=_cksManager.GetAll().Where(I => I.CiftciId == _ciftci.Id).FirstOrDefault().Id;
           var liste= _yemBitkisiManager.GetAll_YemBitkisiDataGrid().Where(I => I.CksId == cksId).ToList();
            dgwListe.DataSource = liste;
            Utilities.Datagrid.DataGridSettings(dgwListe, new string[] { "Id","CksId"});
            int kayitSayisi= liste.Count();
            var uygunListe= liste.Where(I => I.KontrolDurumu == "UYGUNDUR").ToList();
            decimal toplam = 0;
            foreach (var yemKayit in uygunListe)
            {
                toplam += Convert.ToDecimal(yemKayit.TespitEdilenAlan);
            }

            lblNot.Text = $"Toplam Kayıt Sayısı: {kayitSayisi} adet\nToplam Desteklenen Alan: {toplam / 1000} da";
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            try
            {
                int id = (int)comboBoxAddUrun.SelectedValue;

                YemBitkisi yem = new YemBitkisi();
                yem.CksId = _cksManager.GetAll().Where(I => I.CiftciId == _ciftci.Id).FirstOrDefault().Id;
                yem.UrunId = Convert.ToInt32(id);
                yem.DosyaNo = Convert.ToInt32(txtAddDosyaNo.Text);
                yem.MuracaatTarihi = dtpAddMuracaatTarihi.Value;
                yem.EkilisYili = txtAddEkilisYili.Text;
                yem.AraziMahalle = comboBoxAddMahalle.Text;
                yem.Ada = txtAddAda.Text;
                yem.Parsel = txtAddParsel.Text;
                yem.MuracaatAlani = txtAddMuracaatAlani.Text;
                yem.Note = txtAddNote.Text;
                yem.KontrolDurumu = "Arazi Kontrol Edilmedi.";
                yem.KullaniciId = _kullanici.Id;
                yem.TespitEdilenAlan= txtAddMuracaatAlani.Text;
                int result = _yemBitkisiManager.Add(yem);
                if (result == 1)
                {
                    txtAddAda.Text = "";
                    txtAddParsel.Text = "";
                    txtAddMuracaatAlani.Text = "";
                    txtAddNote.Text = "";
                    RefreshList();
                }
            }
            catch (Exception exception)
            {

                Utilities.Mesaj.MessageBoxError(exception.Message);
            }

        }

        private void dgwListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            _index = dgwListe.CurrentRow.Index;
            int id = (int)dgwListe.Rows[_index].Cells["Id"].Value;
            _yemKayit = _yemBitkisiManager.GetAll().Where(I => I.Id == id).FirstOrDefault();
            GuncelleFormDoldur(_yemKayit);
            GuncelleButonAyarla(_yemKayit);
        }

        private void GuncelleButonAyarla(YemBitkisi yemKayit)
        {
            if (_yemKayit == null)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                lblUpdateMesaj.Visible = true;
            }
            else
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                lblUpdateMesaj.Visible = false;
            }
        }

        private void GuncelleFormDoldur(YemBitkisi yemKayit)
        {
            comboBoxUpdateUrun.SelectedValue = yemKayit.UrunId;
            dtpUpdateMuracaatTarihi.Value = yemKayit.MuracaatTarihi;
            txtUpdateEkilisYili.Text = yemKayit.EkilisYili;
            comboBoxUpdateMahalle.Text = yemKayit.AraziMahalle;
            txtUpdateAda.Text = yemKayit.Ada;
            txtUpdateParsel.Text = yemKayit.Parsel;
            txtUpdateMuracaatAlani.Text = yemKayit.MuracaatAlani.ToString();
            txtUpdateTespitEdilenAlan.Text = yemKayit.TespitEdilenAlan.ToString();
            dtpUpdateKontrolTarihi.Value = string.IsNullOrEmpty(yemKayit.KontrolTarihi) ? DateTime.Now : Convert.ToDateTime(yemKayit.KontrolTarihi);
            txtUpdateKontrolEdenler.Text = yemKayit.KontrolEdenler;
            txtUpdateNote.Text = yemKayit.Note;
            if (yemKayit.KontrolDurumu == "Arazi Kontrol Edilmedi.")
            {
                radioButtonAraziKontrolEdilmedi.Select();
            }
            else if (yemKayit.KontrolDurumu == "UYGUNDUR")
            {
                radioButtonUygun.Select();
            }
            else if (yemKayit.KontrolDurumu == "UYGUN DEGİLDİR")
            {
                radioButtonUygunDegil.Select();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _yemKayit.UrunId = (int)comboBoxUpdateUrun.SelectedValue;
                _yemKayit.MuracaatTarihi = dtpUpdateMuracaatTarihi.Value;
                _yemKayit.EkilisYili = txtUpdateEkilisYili.Text;
                _yemKayit.AraziMahalle = comboBoxUpdateMahalle.Text;
                _yemKayit.Ada = txtUpdateAda.Text;
                _yemKayit.Parsel = txtUpdateParsel.Text;
                _yemKayit.MuracaatAlani = txtUpdateMuracaatAlani.Text;
                _yemKayit.TespitEdilenAlan = txtUpdateTespitEdilenAlan.Text;
                _yemKayit.KontrolTarihi = dtpUpdateKontrolTarihi.Value.ToString();
                _yemKayit.KontrolEdenler = txtUpdateKontrolEdenler.Text;
                _yemKayit.Note = txtUpdateNote.Text;
                if (radioButtonAraziKontrolEdilmedi.Checked) _yemKayit.KontrolDurumu = "Arazi Kontrol Edilmedi.";
                if (radioButtonUygun.Checked) _yemKayit.KontrolDurumu = "UYGUNDUR";
                if (radioButtonUygunDegil.Checked) _yemKayit.KontrolDurumu = "UYGUN DEGİLDİR";

                int result = _yemBitkisiManager.Update(_yemKayit);

                if (result == 1)
                {

                    txtUpdateEkilisYili.Text = "";
                    txtUpdateAda.Text = "";
                    txtUpdateParsel.Text = "";
                    dtpUpdateMuracaatTarihi.Text = "";
                    txtUpdateTespitEdilenAlan.Text = "";
                    txtUpdateKontrolEdenler.Text = "";
                    txtUpdateNote.Text = "";
                    txtUpdateMuracaatAlani.Text = "";
                    _yemKayit = null;
                    GuncelleButonAyarla(_yemKayit);

                    RefreshList();
                    dgwListe.Rows[_index].Selected = true;
                }
            }
            catch (Exception exception)
            {

                Utilities.Mesaj.MessageBoxError(exception.Message);
            }




        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int result = _yemBitkisiManager.Delete(_yemKayit);
            if (result == 1)
            {
                txtUpdateEkilisYili.Text = "";
                txtUpdateAda.Text = "";
                txtUpdateParsel.Text = "";
                dtpUpdateMuracaatTarihi.Text = "";
                txtUpdateTespitEdilenAlan.Text = "";
                txtUpdateKontrolEdenler.Text = "";
                txtUpdateNote.Text = "";
                txtUpdateMuracaatAlani.Text = "";
                _yemKayit = null;
                GuncelleButonAyarla(_yemKayit);

                RefreshList();
            }
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            Utilities.FormProperties.FormOpen("UrunForm", new UrunForm(_kullanici), this, true);
            ComboboxFillData();
        }

        private void ComboboxFillData()
        {

            comboBoxAddUrun.DataSource = _urunManager.GetAll();
            comboBoxAddUrun.DisplayMember = "UrunAdi";
            comboBoxAddUrun.ValueMember = "Id";
            comboBoxUpdateUrun.DataSource = _urunManager.GetAll();
            comboBoxUpdateUrun.DisplayMember = "UrunAdi";
            comboBoxUpdateUrun.ValueMember = "Id";



            comboBoxAddMahalle.DataSource = Utilities.RequiredLists.VillageNameList();
            comboBoxUpdateMahalle.DataSource = Utilities.RequiredLists.VillageNameList();
        }

        private void btnFirma_Click(object sender, EventArgs e)
        {
            Utilities.FormProperties.FormOpen("FirmaForm", new FirmaForm(_kullanici), this, true);
            ComboboxFillData();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
   
}
