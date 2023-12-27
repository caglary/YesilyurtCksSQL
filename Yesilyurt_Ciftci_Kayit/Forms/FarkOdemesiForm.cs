using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Manager;
namespace Yesilyurt_Ciftci_Kayit.Forms
{
    public partial class FarkOdemesiForm : Form
    {
        Kullanici _kullanici;
        UrunManager _urunManager;
        Ciftci _ciftci;
        FirmaManager _firmaManager;
        FarkOdemesiManager _farkOdemesiManager;
        CksManager _cksManager;
        FarkOdemesi _farkOdemesi;
        int _index;
        public FarkOdemesiForm(Kullanici kullanici, Ciftci ciftci, string FormAdi)
        {
            InitializeComponent();
            _kullanici = kullanici;
            _urunManager = new UrunManager();
            _firmaManager = new FirmaManager();
            _ciftci = ciftci;
            _farkOdemesiManager = new FarkOdemesiManager();
            _cksManager = new CksManager();
            _farkOdemesi = null;
            this.Text = $"{FormAdi} Formu";
        }
        private void FarkOdemesiForm_Load(object sender, EventArgs e)
        {
            if (_kullanici.Yetki == "Read")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            lblCiftciIsim.Text = _ciftci.IsimSoyisim + " / " + _ciftci.MahalleKoy;
            this.Text = $"Hoşgeldin {_kullanici.KullaniciAdi}  - {Utilities.ConnectionString.TeachYearFromFile()} Yılı için çalışıyorsunuz.";
            ComboboxFillData();
            GuncelleButonAyarla(_farkOdemesi);
            RefreshList();
        }
        private void RefreshList()
        {
            dgwListe.DataSource = _farkOdemesiManager.GetAll_FarkOdemesiDataGrid();
            Utilities.Datagrid.DataGridSettings(dgwListe, new string[] { "Id" });
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                int idUrun = (int)comboBoxAddUrun.SelectedValue;
                int idFirma = (int)comboBoxAddFirma.SelectedValue;
                FarkOdemesi farkOdemesi = new FarkOdemesi();
                farkOdemesi.CksId = _cksManager.GetAll().Where(I => I.CiftciId == _ciftci.Id).FirstOrDefault().Id;
                //2023 yılınca dosyaları için sadece isim soyisim olarak kayıt yapabilme imkanı olduğundan dolayı
                //aşagıdaki kod parçacıkları eklenmiştir.
                if (Utilities.ConnectionString.year == "2023")
                {
                    farkOdemesi.FirmaId = 10;
                    farkOdemesi.UrunId = 29;
                    farkOdemesi.DosyaNo = 0;
                    farkOdemesi.MuracaatTarihi = Convert.ToDateTime("01/01/2000");
                    farkOdemesi.FaturaNo = "0000";
                    farkOdemesi.FaturaTarihi = Convert.ToDateTime("01/01/2000");
                    farkOdemesi.Miktari = "0";
                    farkOdemesi.BirimFiyati = "0";
                    decimal miktar = Convert.ToDecimal(farkOdemesi.Miktari);
                    decimal birimFiyati = Convert.ToDecimal(farkOdemesi.BirimFiyati);
                    decimal toplamMaliyet = miktar * birimFiyati;
                    farkOdemesi.ToplamMaliyet = toplamMaliyet.ToString();
                    farkOdemesi.Note ="fatura bilgileri kayıt altına alınmadı.";
                }
                else
                {
                    farkOdemesi.FirmaId = Convert.ToInt32(idFirma);
                    farkOdemesi.UrunId = Convert.ToInt32(idUrun);
                    farkOdemesi.DosyaNo = Convert.ToInt32(txtAddDosyaNo.Text);
                    farkOdemesi.MuracaatTarihi = dtpAddMuracaatTarihi.Value;
                    farkOdemesi.FaturaNo = txtAddFaturaNo.Text;
                    farkOdemesi.FaturaTarihi = dtpAddFaturaTarihi.Value;
                    farkOdemesi.Miktari = txtAddMiktari.Text;
                    farkOdemesi.BirimFiyati = txtAddBirimFiyati.Text;
                    decimal miktar = Convert.ToDecimal(farkOdemesi.Miktari);
                    decimal birimFiyati = Convert.ToDecimal(farkOdemesi.BirimFiyati);
                    decimal toplamMaliyet = miktar * birimFiyati;
                    farkOdemesi.ToplamMaliyet = toplamMaliyet.ToString();
                    farkOdemesi.Note = txtAddNote.Text;
                }


                farkOdemesi.KullaniciId = _kullanici.Id;
                int result = _farkOdemesiManager.Add(farkOdemesi);
                if (result == 1)
                {

                    txtAddFaturaNo.Text = "";
                    txtAddMiktari.Text = "";
                    txtAddBirimFiyati.Text = "";
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
            _farkOdemesi = _farkOdemesiManager.GetAll().Where(I => I.Id == id).FirstOrDefault();
            if (_farkOdemesi.OdemeDurumu == "Ödeme bekliyor") radioButtonOdemeBekliyor.Select();
            if (_farkOdemesi.OdemeDurumu == "Ödeme yapıldı") radioButtonOdemeYapildi.Select();
            if (_farkOdemesi.OdemeDurumu == "Ödeme yapılmadı") radioButtonOdemeYapilmadi.Select();
            GuncelleFormDoldur(_farkOdemesi);
            GuncelleButonAyarla(_farkOdemesi);
        }
        private void GuncelleButonAyarla(FarkOdemesi farkOdemesi)
        {
            if (farkOdemesi == null)
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
        private void GuncelleFormDoldur(FarkOdemesi farkOdemesi)
        {
            comboBoxUpdateFirma.SelectedValue = farkOdemesi.FirmaId;
            comboBoxUpdateUrun.SelectedValue = farkOdemesi.UrunId;
            txtUpdateDosyaNo.Text = farkOdemesi.DosyaNo.ToString();
            dtpUpdateMuracaatTarihi.Value = farkOdemesi.MuracaatTarihi;
            txtUpdateFaturaNo.Text = farkOdemesi.FaturaNo;
            dtpUpdateFaturaTarihi.Text = farkOdemesi.FaturaTarihi.ToString();
            txtUpdateMiktari.Text = farkOdemesi.Miktari;
            txtUpdateBirimFiyati.Text = farkOdemesi.BirimFiyati;
            txtUpdateNote.Text = farkOdemesi.Note;
            if (farkOdemesi.OdemeDurumu == "Ödeme Bekliyor")
            {
                radioButtonOdemeBekliyor.Select();
            }
            else if (farkOdemesi.OdemeDurumu == "Ödeme Yapıldı")
            {
                radioButtonOdemeYapildi.Select();
            }
            else if (farkOdemesi.OdemeDurumu == "Ödeme Yapılmadı")
            {
                radioButtonOdemeYapilmadi.Select();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _farkOdemesi.UrunId = (int)comboBoxUpdateUrun.SelectedValue;
                _farkOdemesi.FirmaId = (int)comboBoxUpdateFirma.SelectedValue;
                _farkOdemesi.DosyaNo = Convert.ToInt32(txtUpdateDosyaNo.Text);
                _farkOdemesi.MuracaatTarihi = dtpUpdateMuracaatTarihi.Value;
                _farkOdemesi.FaturaNo = txtUpdateFaturaNo.Text;
                _farkOdemesi.FaturaTarihi = dtpUpdateFaturaTarihi.Value;
                _farkOdemesi.Miktari = txtUpdateMiktari.Text.Replace(".", ",");
                _farkOdemesi.BirimFiyati = txtUpdateBirimFiyati.Text.Replace(".", ",");

                decimal miktar = decimal.Parse(_farkOdemesi.Miktari);
                decimal birimFiyati = decimal.Parse(_farkOdemesi.BirimFiyati);
                decimal toplamMaliyet = miktar * birimFiyati;
                _farkOdemesi.ToplamMaliyet = toplamMaliyet.ToString().Replace(".", ",");
                _farkOdemesi.Note = txtUpdateNote.Text;
                _farkOdemesi.KullaniciId = _kullanici.Id;
                if (radioButtonOdemeBekliyor.Checked) _farkOdemesi.OdemeDurumu = "Ödeme bekliyor";
                if (radioButtonOdemeYapildi.Checked) _farkOdemesi.OdemeDurumu = "Ödeme yapıldı";
                if (radioButtonOdemeYapilmadi.Checked) _farkOdemesi.OdemeDurumu = "Ödeme yapılmadı";
                int result = _farkOdemesiManager.Update(_farkOdemesi);
                if (result == 1)
                {
                    txtUpdateDosyaNo.Text = "";
                    txtUpdateFaturaNo.Text = "";
                    txtUpdateMiktari.Text = "";
                    txtUpdateBirimFiyati.Text = "";
                    txtUpdateNote.Text = "";
                    _farkOdemesi = null;
                    GuncelleButonAyarla(_farkOdemesi);
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
            int result = _farkOdemesiManager.Delete(_farkOdemesi);
            if (result == 1)
            {
                txtUpdateDosyaNo.Text = "";
                txtUpdateFaturaNo.Text = "";
                txtUpdateMiktari.Text = "";
                txtUpdateBirimFiyati.Text = "";
                txtUpdateNote.Text = "";
                _farkOdemesi = null;
                GuncelleButonAyarla(_farkOdemesi);
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
            comboBoxAddFirma.DataSource = _firmaManager.GetAll();
            comboBoxAddFirma.DisplayMember = "FirmaAdi";
            comboBoxAddFirma.ValueMember = "Id";
            comboBoxUpdateFirma.DataSource = _firmaManager.GetAll();
            comboBoxUpdateFirma.DisplayMember = "FirmaAdi";
            comboBoxUpdateFirma.ValueMember = "Id";
            comboBoxAddUrun.DataSource = _urunManager.GetAll();
            comboBoxAddUrun.DisplayMember = "UrunAdi";
            comboBoxAddUrun.ValueMember = "Id";
            comboBoxUpdateUrun.DataSource = _urunManager.GetAll();
            comboBoxUpdateUrun.DisplayMember = "UrunAdi";
            comboBoxUpdateUrun.ValueMember = "Id";
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
