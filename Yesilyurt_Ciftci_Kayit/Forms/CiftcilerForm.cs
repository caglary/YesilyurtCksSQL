using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Manager;
namespace Yesilyurt_Ciftci_Kayit.Forms
{
    public partial class CiftcilerForm : Form
    {
        CiftciManager bll;
        Kullanici kullanici;
        Ciftci _activeCiftci;
        List<Ciftci> liste;
        public CiftcilerForm(Kullanici k)
        {
            InitializeComponent();
            bll = new CiftciManager();
            kullanici = k;
            _activeCiftci = new Ciftci() { Id = -1 };
            liste = new List<Ciftci>();
        }
        private void CiftcilerForm_Load(object sender, EventArgs e)
        {
            this.Text = $"{ Utilities.ConnectionString.TeachYearFromFile()} Yılı Çiftçi Bilgi İşlemleri";
            if (kullanici.Yetki=="Read")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            comboBoxGender.DataSource = Utilities.RequiredLists.GenderList();
            comboBoxMaritalStatus.DataSource = Utilities.RequiredLists.MaritalStatusList();
            comboBoxVillage.DataSource = Utilities.RequiredLists.VillageNameList();
            comboBoxUpdateGender.DataSource = Utilities.RequiredLists.GenderList();
            comboBoxUpdateMaritalStatus.DataSource = Utilities.RequiredLists.MaritalStatusList();
            comboBoxUpdateVillage.DataSource = Utilities.RequiredLists.VillageNameList();
            DataGridYinele();
            txtCity.Text = "TOKAT";
            txtTown.Text = "YEŞİLYURT";
        }
        private void DataGridYinele()
        {
            dgwListe.DataSource = bll.GetAll_CiftciDataGrid();
            Utilities.Datagrid.DataGridSettings(dgwListe, new string[] { "Id"});
            label7.Text = dgwListe.RowCount.ToString()+" Kişi";
        }
        private Ciftci FormToEntityForAdd()
        {
            Ciftci ciftci = new Ciftci()
            {
                TcKimlikNo = string.IsNullOrEmpty(txtTc.Text) ? "" : txtTc.Text.Trim(),
                IsimSoyisim = string.IsNullOrEmpty(txtNameSurname.Text) ? "" : txtNameSurname.Text,
                BabaAdi = string.IsNullOrEmpty(txtFatherName.Text) ? "" : txtFatherName.Text,
                AnneAdi = string.IsNullOrEmpty(txtMotherName.Text) ? "" : txtMotherName.Text,
                DogumTarihi = string.IsNullOrEmpty(dtpBirthday.Text) ? "" : dtpBirthday.Text,
                Cinsiyet = string.IsNullOrEmpty(comboBoxGender.Text) ? "" : comboBoxGender.Text,
                MedeniDurum = string.IsNullOrEmpty(comboBoxMaritalStatus.Text) ? "" : comboBoxMaritalStatus.Text,
                CepTelefonu = string.IsNullOrEmpty(txtMobilePhone.Text) ? "" : txtMobilePhone.Text,
                EvTelefonu = string.IsNullOrEmpty(txtHomePhone.Text) ? "" : txtHomePhone.Text,
                Email = string.IsNullOrEmpty(txtEmail.Text) ? "" : txtEmail.Text,
                Il = string.IsNullOrEmpty(txtCity.Text) ? "" : txtCity.Text,
                Ilce = string.IsNullOrEmpty(txtTown.Text) ? "" : txtTown.Text,
                MahalleKoy = string.IsNullOrEmpty(comboBoxVillage.Text) ? "" : comboBoxVillage.Text,
                Not = string.IsNullOrEmpty(txtNote.Text) ? "" : txtNote.Text,
                KullaniciId = kullanici.Id
            };
            return ciftci;
        }
        private Ciftci FormToEntityForUpdate()
        {
            Ciftci ciftci = new Ciftci()
            {
                Id = _activeCiftci.Id,
                TcKimlikNo = string.IsNullOrEmpty(txtupdateTc.Text) ? "" : txtupdateTc.Text.Trim(),
                IsimSoyisim = string.IsNullOrEmpty(txtUpdateNameSurname.Text) ? "" : txtUpdateNameSurname.Text,
                BabaAdi = string.IsNullOrEmpty(txtUpdateFatherName.Text) ? "" : txtUpdateFatherName.Text,
                AnneAdi = string.IsNullOrEmpty(txtUpdateMotherName.Text) ? "" : txtUpdateMotherName.Text,
                DogumTarihi = string.IsNullOrEmpty(dtpUpdateBirthday.Text) ? "" : dtpUpdateBirthday.Text,
                Cinsiyet = string.IsNullOrEmpty(comboBoxUpdateGender.Text) ? "" : comboBoxUpdateGender.Text,
                MedeniDurum = string.IsNullOrEmpty(comboBoxUpdateMaritalStatus.Text) ? "" : comboBoxUpdateMaritalStatus.Text,
                CepTelefonu = string.IsNullOrEmpty(txtUpdateMobile.Text) ? "" : txtUpdateMobile.Text,
                EvTelefonu = string.IsNullOrEmpty(txtUpdateHomePhone.Text) ? "" : txtUpdateHomePhone.Text,
                Email = string.IsNullOrEmpty(txtUpdateEmail.Text) ? "" : txtUpdateEmail.Text,
                Il = string.IsNullOrEmpty(txtUpdateCity.Text) ? "" : txtUpdateCity.Text,
                Ilce = string.IsNullOrEmpty(txtUpdateTown.Text) ? "" : txtUpdateTown.Text,
                MahalleKoy = string.IsNullOrEmpty(comboBoxUpdateVillage.Text) ? "" : comboBoxUpdateVillage.Text,
                Not = string.IsNullOrEmpty(txtUpdateNote.Text) ? "" : txtUpdateNote.Text,
                KullaniciId = kullanici.Id
            };
            return ciftci;
        }
        private void AddFormuTemizle()
        {
            txtTc.Text = "";
            txtNameSurname.Text = "";
            txtFatherName.Text = "";
            txtMotherName.Text = "";
            dtpBirthday.Text = "";
            comboBoxGender.Text = "";
            comboBoxMaritalStatus.Text = "";
            txtMobilePhone.Text = "";
            txtHomePhone.Text = "";
            txtEmail.Text = "";
            txtCity.Text = "";
            txtTown.Text = "";
            comboBoxVillage.Text = "";
            txtNote.Text = "";
        }
        private void PersonToFormForUpdate(Ciftci person)
        {
            txtupdateTc.Text = person.TcKimlikNo;
            txtUpdateNameSurname.Text = person.IsimSoyisim;
            txtUpdateFatherName.Text = person.BabaAdi;
            txtUpdateMotherName.Text = person.AnneAdi;
            dtpUpdateBirthday.Text = person.DogumTarihi;
            comboBoxUpdateGender.Text = person.Cinsiyet;
            comboBoxUpdateMaritalStatus.Text = person.MedeniDurum;
            txtUpdateMobile.Text = person.CepTelefonu;
            txtUpdateHomePhone.Text = person.EvTelefonu;
            txtUpdateEmail.Text = person.Email;
            txtUpdateCity.Text = person.Il;
            txtUpdateTown.Text = person.Ilce;
            comboBoxUpdateVillage.Text = person.MahalleKoy;
            txtUpdateNote.Text = person.Not;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int sonuc = 0;
            var ciftci = FormToEntityForAdd();
            sonuc= bll.Add(ciftci);
            if (sonuc==1)
            {
                DataGridYinele();
                AddFormuTemizle();
            }
           
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Ciftci ciftci = FormToEntityForUpdate();
            int result=bll.Update(ciftci);
            if (result == 1)
            {
                Utilities.Mesaj.MessageBoxInformation("Kayıt güncellendi.");
            }
            //GuncelleFormunuTemizle();
            DataGridYineleTekKayit(ciftci);
        }
        private void GuncelleFormunuTemizle()
        {
            txtupdateTc.Text = "";
            txtUpdateNameSurname.Text = "";
            txtUpdateFatherName.Text = "";
            txtUpdateMotherName.Text = "";
            dtpUpdateBirthday.Text = "";
            comboBoxUpdateGender.Text = "";
            comboBoxUpdateMaritalStatus.Text = "";
            txtUpdateMobile.Text = "";
            txtUpdateHomePhone.Text = "";
            txtUpdateEmail.Text = "";
            txtUpdateCity.Text = "";
            txtUpdateTown.Text = "";
            comboBoxUpdateVillage.Text = "";
            txtUpdateNote.Text = "";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_activeCiftci.Id == -1)
            {
                Utilities.Mesaj.MessageBoxWarning("Silinecek kayıt yok.");
                return;
            }
            int result = bll.Delete(_activeCiftci);
            if (result == 1)
            {
                GuncelleFormunuTemizle();
                DataGridYineleTekKayit(null);
                _activeCiftci.Id = -1;
            }
        }
        private void tabPageGuncelle_Click(object sender, EventArgs e)
        {
            _activeCiftci.Id = -1;
            GuncelleFormunuTemizle();
            comboBoxUpdateGender.DataSource = Utilities.RequiredLists.GenderList();
            comboBoxUpdateMaritalStatus.DataSource = Utilities.RequiredLists.MaritalStatusList();
            comboBoxUpdateVillage.DataSource = Utilities.RequiredLists.VillageNameList();
        }
        private void btnTcAra_Click(object sender, EventArgs e)
        {
            txtUpdateNameSurname.Text = "";
            txtUpdateFatherName.Text = "";
            txtUpdateMotherName.Text = "";
            dtpUpdateBirthday.Text = "";
            comboBoxUpdateGender.Text = "";
            comboBoxUpdateMaritalStatus.Text = "";
            txtUpdateMobile.Text = "";
            txtUpdateHomePhone.Text = "";
            txtUpdateEmail.Text = "";
            txtUpdateCity.Text = "";
            txtUpdateTown.Text = "";
            comboBoxUpdateVillage.Text = "";
            txtUpdateNote.Text = "";
            var bulunankayit = bll.GetByTc(txtupdateTc.Text);
            if (bulunankayit != null)
            {
                PersonToFormForUpdate(bulunankayit);
                liste.Add(bulunankayit);
                _activeCiftci = bulunankayit;
            }
            else
            {
                _activeCiftci.Id = -1;
            }
            DataGridYineleTekKayit(bulunankayit);
        }
        private void DataGridYineleTekKayit(Ciftci c)
        {
            liste.Clear();
            liste.Add(c);
            dgwListe.DataSource = null;
            dgwListe.DataSource = liste;
            Utilities.Datagrid.DataGridSettings(dgwListe, new string[] { "Id", "DogumTarihi", "Cinsiyet", "MedeniDurum", "Email", "Il", "Ilce", "KullaniciId", "CreateTime" });
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                DataGridYinele();
                _activeCiftci.Id = -1;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                GuncelleFormunuTemizle();
                DataGridYineleTekKayit(null);
            }
        }
        private void dgwListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgwListe.CurrentRow.Index;
            string tcNo = dgwListe.Rows[index].Cells["TcKimlikNo"].Value.ToString();
            tabControl1.SelectedTab = tabPageGuncelle;
            _activeCiftci = bll.GetByTc(tcNo);
            PersonToFormForUpdate(_activeCiftci);
            DataGridYineleTekKayit(_activeCiftci);
        }
    }
}
