using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Manager;

namespace Yesilyurt_Ciftci_Kayit.Forms
{
    public partial class SertifikaliTohumForm : Form
    {
        Kullanici _kullanici;
        UrunManager _urunManager;
        Ciftci _ciftci;
        FirmaManager _firmaManager;
        SertifikaliTohumManager _sertifikaliTohumManager;
      
        CksManager _cksManager;
        SertifikaliTohum _sertifikaliTohumKayit;
        int _index;
        public SertifikaliTohumForm(Kullanici kullanici, Ciftci ciftci,string FormAdi)
        {
            InitializeComponent();
            _kullanici = kullanici;
            _urunManager = new UrunManager();
            _firmaManager = new FirmaManager();
            _ciftci = ciftci;
            _sertifikaliTohumManager = new SertifikaliTohumManager();
            _cksManager = new CksManager();
            _sertifikaliTohumKayit = null;
            this.Text = $"{FormAdi} Formu";




        }

        private void SertifikaliTohumForm_Load(object sender, EventArgs e)
        {

            if (_kullanici.Yetki == "Read")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

            lblCiftciIsim.Text = _ciftci.IsimSoyisim + " / " + _ciftci.MahalleKoy;
            this.Text =$"Hoşgeldin {_kullanici.KullaniciAdi} - {Utilities.ConnectionString.TeachYearFromFile()} Yılı için çalışıyorsunuz.";

            ComboboxFillData();

            RefreshList();

        }

        private void ComboboxFillData()
        {
            comboBoxAddFirma.DataSource = _firmaManager.GetAll().OrderBy(I=>I.FirmaAdi).ToList();
            comboBoxAddFirma.DisplayMember = "FirmaAdi";
            comboBoxAddFirma.ValueMember = "Id";

            comboBoxUpdateFirma.DataSource = _firmaManager.GetAll().OrderBy(I => I.FirmaAdi).ToList();
            comboBoxUpdateFirma.DisplayMember = "FirmaAdi";
            comboBoxUpdateFirma.ValueMember = "Id";

            comboBoxAddUrun.DataSource = _urunManager.GetAll().OrderBy(I => I.UrunAdi).ToList();
            comboBoxAddUrun.DisplayMember = "UrunAdi";
            comboBoxAddUrun.ValueMember = "Id";

            comboBoxUpdateUrun.DataSource = _urunManager.GetAll().OrderBy(I => I.UrunAdi).ToList();
            comboBoxUpdateUrun.DisplayMember = "UrunAdi";
            comboBoxUpdateUrun.ValueMember = "Id";
        }

        private void RefreshList()
        {
           var cks= _cksManager.GetAll().Where(I => I.CiftciId == _ciftci.Id).FirstOrDefault();
            dgwListe.DataSource = _sertifikaliTohumManager.GetAll_SertifikaliTohumDataGrid().Where(I=>I.CksId== cks.Id).ToList();
            Utilities.Datagrid.DataGridSettings(dgwListe, new string[] { "Id","CksId"});

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            try
            {
                int idUrun = (int)comboBoxAddUrun.SelectedValue;
                int idFirma = (int)comboBoxAddFirma.SelectedValue;


                SertifikaliTohum st = new SertifikaliTohum();
                st.CksId = _cksManager.GetAll().Where(I => I.CiftciId == _ciftci.Id).FirstOrDefault().Id;
                st.FirmaId = Convert.ToInt32(idFirma);
                st.UrunId = Convert.ToInt32(idUrun);
                st.DosyaNo = Convert.ToInt32(txtAddDosyaNo.Text);
                st.MuracaatTarihi = dtpAddMuracaatTarihi.Value;
                st.SertifikaNo = txtAddSertifikaNo.Text;
                st.FaturaNo = txtAddFaturaNo.Text;
                st.FaturaTarihi =dtpAddFaturaTarihi.Value;
                st.Miktari = txtAddMiktari.Text;
                st.BirimFiyati = txtAddBirimFiyati.Text;
                st.ToplamMaliyet = (Convert.ToDecimal(st.Miktari)*Convert.ToDecimal( st.BirimFiyati)).ToString();
                st.Note = txtAddNote.Text;
                st.KullaniciId = _kullanici.Id;
                int result = _sertifikaliTohumManager.Add(st);
                if (result == 1)
                {

                    txtAddBirimFiyati.Text = "";
                    txtAddMiktari.Text = "";
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
            _sertifikaliTohumKayit = _sertifikaliTohumManager.GetAll().Where(I => I.Id == id).FirstOrDefault();

            if (_sertifikaliTohumKayit.OdemeDurumu == "Ödeme bekliyor") radioButtonOdemeBekliyor.Select();
            if (_sertifikaliTohumKayit.OdemeDurumu == "Ödeme yapıldı") radioButtonOdemeYapildi.Select();
            if (_sertifikaliTohumKayit.OdemeDurumu == "Ödeme yapılmadı") radioButtonOdemeYapilmadi.Select();


            GuncelleFormDoldur(_sertifikaliTohumKayit);
            GuncelleButonAyarla(_sertifikaliTohumKayit);
        }

        private void GuncelleButonAyarla(SertifikaliTohum sertifikaliTohum)
        {
            if (sertifikaliTohum == null)
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

        private void GuncelleFormDoldur(SertifikaliTohum sertifikaliTohum)
        {
            comboBoxUpdateFirma.SelectedValue = sertifikaliTohum.FirmaId;
            comboBoxUpdateUrun.SelectedValue = sertifikaliTohum.UrunId;
            txtUpdateDosyaNo.Text = sertifikaliTohum.DosyaNo.ToString();
            dtpUpdateMuracaatTarihi.Value = sertifikaliTohum.MuracaatTarihi;
            txtUpdateSertifikaNo.Text = sertifikaliTohum.SertifikaNo;
            txtUpdateFaturaNo.Text = sertifikaliTohum.FaturaNo;
            dtpUpdateFaturaTarihi.Text = sertifikaliTohum.FaturaTarihi.ToString();
            txtUpdateMiktari.Text = sertifikaliTohum.Miktari.ToString();
            txtUpdateBirimFiyati.Text = sertifikaliTohum.BirimFiyati.ToString();
            txtUpdateNote.Text = sertifikaliTohum.Note;

         
            if (sertifikaliTohum.OdemeDurumu == "Ödeme Bekliyor")
            {
                radioButtonOdemeBekliyor.Select();
            }
            else if (sertifikaliTohum.OdemeDurumu == "Ödeme Yapıldı")
            {
                radioButtonOdemeYapildi.Select();
            }
            else if (sertifikaliTohum.OdemeDurumu == "Ödeme Yapılmadı")
            {
                radioButtonOdemeYapilmadi.Select();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _sertifikaliTohumKayit.UrunId = (int)comboBoxUpdateUrun.SelectedValue;
                _sertifikaliTohumKayit.FirmaId = (int)comboBoxUpdateFirma.SelectedValue;
                _sertifikaliTohumKayit.DosyaNo =Convert.ToInt32( txtUpdateDosyaNo.Text);
                _sertifikaliTohumKayit.MuracaatTarihi = dtpUpdateMuracaatTarihi.Value;
                _sertifikaliTohumKayit.SertifikaNo = txtUpdateSertifikaNo.Text;
                _sertifikaliTohumKayit.FaturaNo = txtUpdateFaturaNo.Text;
                _sertifikaliTohumKayit.FaturaTarihi = dtpUpdateFaturaTarihi.Value;
                _sertifikaliTohumKayit.Miktari = txtUpdateMiktari.Text.Replace(".", ",");
               
                _sertifikaliTohumKayit.BirimFiyati = txtUpdateBirimFiyati.Text.Replace(".", ",");
                _sertifikaliTohumKayit.ToplamMaliyet =(Convert.ToDecimal(_sertifikaliTohumKayit.Miktari) * Convert.ToDecimal(_sertifikaliTohumKayit.BirimFiyati)).ToString();
                _sertifikaliTohumKayit.Note = txtUpdateNote.Text;
                _sertifikaliTohumKayit.KullaniciId = _kullanici.Id;


                if (radioButtonOdemeBekliyor.Checked) _sertifikaliTohumKayit.OdemeDurumu = "Ödeme bekliyor";
                if (radioButtonOdemeYapildi.Checked) _sertifikaliTohumKayit.OdemeDurumu = "Ödeme yapıldı";
                if (radioButtonOdemeYapilmadi.Checked) _sertifikaliTohumKayit.OdemeDurumu = "Ödeme yapılmadı";

                int result = _sertifikaliTohumManager.Update(_sertifikaliTohumKayit);

                if (result == 1)
                {

                    txtUpdateDosyaNo.Text = "";
                    txtUpdateSertifikaNo.Text = "";
                    txtUpdateFaturaNo.Text = "";
                    txtUpdateMiktari.Text = "";
                    txtUpdateBirimFiyati.Text = "";
                    txtUpdateNote.Text = "";
                   
                    
                    _sertifikaliTohumKayit = null;
                    GuncelleButonAyarla(_sertifikaliTohumKayit);

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
            int result = _sertifikaliTohumManager.Delete(_sertifikaliTohumKayit);
            if (result == 1)
            {

                txtUpdateDosyaNo.Text = "";
                txtUpdateSertifikaNo.Text = "";
                txtUpdateFaturaNo.Text = "";
                txtUpdateMiktari.Text = "";
                txtUpdateBirimFiyati.Text = "";
                txtUpdateNote.Text = "";
              

                _sertifikaliTohumKayit = null;
                GuncelleButonAyarla(_sertifikaliTohumKayit);

                RefreshList();
            }
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            Utilities.FormProperties.FormOpen("UrunForm", new UrunForm(_kullanici), this,true);
            ComboboxFillData();

        }

        private void btnFirma_Click(object sender, EventArgs e)
        {
            Utilities.FormProperties.FormOpen("FirmaForm", new FirmaForm(_kullanici), this, true);
            ComboboxFillData();

        }

        private void comboBoxAddUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliUrun=(Urun) comboBoxAddUrun.SelectedItem;
            lblAddUrunCesit.Text = seciliUrun.UrunCesidi;
        }

        private void comboBoxUpdateUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliUrun = (Urun)comboBoxUpdateUrun.SelectedItem;
            lblUpdateUrunCesit.Text = seciliUrun.UrunCesidi;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
