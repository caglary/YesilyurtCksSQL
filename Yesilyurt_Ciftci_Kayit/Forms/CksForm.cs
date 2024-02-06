using System;
using System.Linq;
using System.Windows.Forms;
using Yesilyurt_Ciftci_Kayit.Database;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Manager;
namespace Yesilyurt_Ciftci_Kayit.Forms
{
    public partial class CksForm : Form
    {

        Kullanici _kullanici;
        CksManager _cksmanager;
        CiftciManager _ciftciManager;
        Ciftci _ciftci;
        Aksiyon aksiyon;
        EdevletManager _edevletManager;
        public CksForm(Kullanici k)
        {
            InitializeComponent();
            _kullanici = k;
            _cksmanager = new CksManager();
            _ciftciManager = new CiftciManager();
            _edevletManager = new EdevletManager();
        }
        public CksForm(Kullanici k, string tcNo)
        {
            InitializeComponent();
            _kullanici = k;
            _cksmanager = new CksManager();
            _ciftciManager = new CiftciManager();
            _edevletManager = new EdevletManager();
            tabControl1.SelectedTab = tabPageGuncelle;
            txtupdateTc.Text = tcNo;
        }
        private void CksForm_Load(object sender, EventArgs e)
        {
            this.Text = $"{Utilities.ConnectionString.TeachYearFromFile()} Yılı ÇKS İşlemleri";
            txtUpdateNameSurname.Enabled = false;
            //ekle butonu aktif olacak.. daha sonra ise çiftçi olup olmamasına göre aktifleşecek.
            btnAdd.Enabled = true;
            //açıldığında aksiyn form load olacak..
            aksiyon = Aksiyon.FormLoad;
            /*Çiftçiden alınan veriler çiftçiler listesinden güncelleneceğinden burada form
            elemanları Enable property False olacak...açılışta ise çiftçi boş olduğundan herhangi 
            bir eleman girilemeyecek.
            */
            comboBoxAddVillage.Enabled = false;
            txtAddNameSurname.Enabled = false;
            txtAddMobilePhone.Enabled = false;
            txtAddHomePhone.Enabled = false;
            txtAddDosyaNo.Enabled = false;
            comboBoxAddVillage.DataSource = Utilities.RequiredLists.VillageNameList();
            comboBoxUpdateVillage.DataSource = Utilities.RequiredLists.VillageNameList();
            //açılışta çks listesi listelenecek..
            DataGridYinele();
            //form üzerinde şu an herhangi bir çiftçi çağrılmadığından ciftci null olacak...
            _ciftci = null;
            if (_kullanici.Yetki == "Read")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            string[] havaleEdilenPersoneller = {  "Çağlar YURDAKUL" };
            comboBoxHavaleEdilenPersonel.DataSource = havaleEdilenPersoneller;
            comboBoxUpdateHavaleEdilenPersonel.DataSource = havaleEdilenPersoneller;
            comboBoxHavaleEdilenPersonel.Text = "";
            comboBoxUpdateHavaleEdilenPersonel.Text = "";
            txtEdevlet.Visible = false;
            txtEdevletUpdate.Visible = false;

            if (Utilities.ConnectionString.year == "2023")
            {
               btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                //kullanıcı adı çağlar değilse buton pasif olacak                
                if(_kullanici.KullaniciAdi!="caglar")
                    btnAdd.Enabled = false;


            }
        }
        private void DataGridYinele(Ciftci ciftci = null)
        {
            UpdateButtonDurum(ciftci);
            lblToplamKayitSayisi.Text = $"Toplam ÇKS Kayıt Sayısı: {_cksmanager.GetAll().Count.ToString()} Adet";
            var allList=_cksmanager.GetAllCksDataGrid();
            var desiredDataList = allList.Select(d => new { d.DosyaNo, d.TcKimlikNo, d.IsimSoyisim, d.BabaAdi, d.MobilePhone, d.KoyMahalle,d.Note }).ToList();


            var yeniListe = desiredDataList.OrderByDescending(I => I.DosyaNo).ToList();
            //listede eleman yok ise 
            if (yeniListe == null || yeniListe.Count < 1)
            {
                dgwListe.DataSource = null;
                //DataGridHeaderTextSettings();
                return;
            }
            //Listede dolu ve etkin çiftçi yok ise TÜM kayıtlar
            if (ciftci == null)
            {
                dgwListe.DataSource = yeniListe;
               
                return;
            }
            //Listede kayıt var ve etkin çiftçi VAR ise ciftcinin olduğu kayıt
            if (ciftci != null)
            {
                dgwListe.DataSource = yeniListe.Where(I => I.TcKimlikNo == _ciftci.TcKimlikNo).ToList();
             
                return;
            }
        }
        //private void DataGridHeaderTextSettings()
        //{
        //    Utilities.Datagrid.DataGridSettings(dgwListe, new string[] { "Id" });
        //    dgwListe.Columns[1].HeaderText = "Dosya No";
        //    dgwListe.Columns[2].HeaderText = "TC Kimlik No";
        //    dgwListe.Columns[3].HeaderText = "İsim Soyisim";
        //    dgwListe.Columns[4].HeaderText = "Baba Adı";
        //    dgwListe.Columns[5].HeaderText = "Cep Tel";
        //    dgwListe.Columns[6].HeaderText = "Ev Tel";
        //    dgwListe.Columns[7].HeaderText = "Köy/Mahalle";
        //    dgwListe.Columns[8].HeaderText = "Not";
        //    dgwListe.Columns[9].HeaderText = "Kayıt Tarihi";
        //    dgwListe.Columns[10].HeaderText = "Evrak Kayıt No";
        //    dgwListe.Columns[11].HeaderText = "Havale Edilen Personel";
        //    dgwListe.Columns[12].HeaderText = "Müracaat Yeri";
        //}
        private void UpdateButtonDurum(Ciftci ciftci)
        {
            // Guncelle kısmında aktif çiftçi olup olmamasına göre butonlar aktif yada pasif olacak.
            if (ciftci == null)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private void btnCiftciGetir_Click(object sender, EventArgs e)
        {
            aksiyon = Aksiyon.ciftciGetirClick;
            string tcNo = txtAddTc.Text.Trim();
            //Tc numarasının kontrolü yapılıyor..
            if (tcNo.Length != 11)
            {
                Utilities.Mesaj.MessageBoxWarning("Tc Numarasını kontrol ediniz.");
                return;
            }
            //Çiftçiler listesinden tc numarasına ait kayıt olup olmadığı sorgulanıyor.
            _ciftci = _ciftciManager.GetByTc(tcNo);
            //eğer çiftçiler listesinde herhangi bir kayıt dönmez ise 
            if (_ciftci == null)
            {
                Utilities.Mesaj.MessageBoxWarning("Tc numarasına ait kayıt bulunamadı.");
                return;
            }
            //eğer çiftçi bulunursa forma veriler yazılacak..
            txtAddNameSurname.Text = _ciftci.IsimSoyisim;
            txtAddMobilePhone.Text = _ciftci.CepTelefonu;
            txtAddHomePhone.Text = _ciftci.EvTelefonu;
            comboBoxAddVillage.Text = _ciftci.MahalleKoy;
            txtAddNote.Text = _ciftci.Not;
            txtAddDosyaNo.Text = _cksmanager.DosyaNoFactory().ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            try
            {
               
                Edevlet edevlet = new Edevlet();
                aksiyon = Aksiyon.btnAddClick;
                txtAddTc.Text = txtAddTc.Text.Trim();
                if (txtAddTc.Text.Length != 11)
                {
                    Utilities.Mesaj.MessageBoxWarning("Tc numarasını kontrol ediniz.");
                    return;
                }
                /*
                 ekleme işlemi için öncelikle etkin bir çiftçi olup olmadığına bakılacak.
                 */
                if (_ciftci == null)
                {
                    Utilities.Mesaj.MessageBoxWarning("Tc numarası girin. çiftçi getir butonuna basın ve tekrar deneyin.");
                    return;
                }
                //eğer etkin bir çiftçi varsa
                int result = 0;
                Cks cks = new Cks()
                {
                    CiftciId = _ciftci.Id,
                    DosyaNo = Convert.ToInt32(txtAddDosyaNo.Text),
                    CreateTime = dtpAddCreateTime.Value,
                    KullaniciId = _kullanici.Id,
                    Note = txtAddNote.Text,
                    EvrakKayitNo = txtEvrakKayitNo.Text,
                    HavaleEdilenPersonel = comboBoxHavaleEdilenPersonel.Text,
                };
                if (checkBoxEdevlet.Checked == true)
                {
                    cks.MuracaatYeri = "E-Devlet Üzerinden yapılan başvuru";
                }
                else
                {
                    cks.MuracaatYeri = "İlçe Tarım Müdürlüğünden yapılan başvuru";
                }
                // * benden başka kimse havale edip, evrak kayıt numarası giremesin ....
                if (_kullanici.KullaniciAdi != "caglar")
                {
                    cks.HavaleEdilenPersonel = "";
                    cks.EvrakKayitNo = "";
                }
                edevlet.KullaniciId = _kullanici.Id;
                edevlet.DosyaNoEdevlet = txtEdevlet.Text;
                result = _cksmanager.Add(cks, edevlet);
                if (result == 1)
                {
                    DataGridYinele();
                    Utilities.Mesaj.MessageBoxInformation("Çiftçi kaydı yapıldı.");
                    EkleFormuBoşalt();
                }
                else
                {
                    throw new Exception("Kayıt işlemi başarısız.");
                }
            }
            catch (Exception exception)
            {
                Utilities.Mesaj.MessageBoxError(exception.Message);
            }
            checkBoxEdevlet.Checked = false;
        }
        private void EkleFormuBoşalt()
        {
            txtAddTc.Text = "";
            txtAddTc.Focus();

            txtAddNameSurname.Text = "";
            txtAddMobilePhone.Text = "";
            txtAddHomePhone.Text = "";
            comboBoxAddVillage.Text = "";
            txtAddNote.Text = "";
            txtAddDosyaNo.Text = _cksmanager.DosyaNoFactory().ToString();
            txtEvrakKayitNo.Text = "";
            checkBoxEdevlet.Checked = false;
           
            _ciftci = null;
        }
        private void UpdateFormuBoşalt()
        {
            txtupdateTc.Text = "";
            txtUpdateNameSurname.Text = "";
            txtUpdateMobile.Text = "";
            txtUpdateHomePhone.Text = "";
            comboBoxUpdateVillage.Text = "";
            txtUpdateNote.Text = "";
            txtUpdateDosyaNo.Text = "";
            txtUpdateEvrakKayitNo.Text = "";
            checkBoxUpdateEDevlet.Checked = false;
            _ciftci = null;
        }
        private void dgwListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                aksiyon = Aksiyon.datagridClick;
                int index = dgwListe.CurrentRow.Index;
                string tcNo = dgwListe.Rows[index].Cells["TcKimlikNo"].Value.ToString();
                //guncelle formu açılacak...
                tabControl1.SelectedTab = tabPageGuncelle;
                _ciftci = _ciftciManager.GetByTc(tcNo);
                Cks cksKayit = _cksmanager.GetByTc(tcNo);
                //Edevlet edevletKayit = _edevletManager.GetAll().Where(I => I.CksId == cksKayit.Id).FirstOrDefault();
                //if (edevletKayit != null)
                //{
                //    txtEdevletUpdate.Text = edevletKayit.DosyaNoEdevlet;
                //}
                txtupdateTc.Text = tcNo;
                txtUpdateNameSurname.Text = _ciftci.IsimSoyisim;
                txtUpdateMobile.Text = _ciftci.CepTelefonu;
                txtUpdateHomePhone.Text = _ciftci.EvTelefonu;
                comboBoxUpdateVillage.Text = _ciftci.MahalleKoy;
                txtUpdateDosyaNo.Text = cksKayit.DosyaNo.ToString();
                dtpUpdateCreateTime.Text = cksKayit.CreateTime.ToString();
                txtUpdateNote.Text = cksKayit.Note;
                txtUpdateEvrakKayitNo.Text = cksKayit.EvrakKayitNo;
                comboBoxUpdateHavaleEdilenPersonel.Text = cksKayit.HavaleEdilenPersonel;
                //if (cksKayit.MuracaatYeri == "E-Devlet Üzerinden yapılan başvuru")
                //{
                //    checkBoxUpdateEDevlet.Checked = true;
                //}
                //else
                //{
                //    checkBoxUpdateEDevlet.Checked = false;
                //}
                DataGridYinele(_ciftci);
            }
            catch (Exception exception)
            {
                Utilities.Mesaj.MessageBoxError(exception.Message);
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxHavaleEdilenPersonel.Text = "";
            comboBoxUpdateHavaleEdilenPersonel.Text = "";
            if (tabControl1.SelectedIndex == 0) //Ekle TabPage
            {
                if (aksiyon == Aksiyon.btnDeleteClick)
                {
                    UpdateFormuBoşalt();//update formunda bulunan çiftçi null oluyor.
                }
                if (aksiyon == Aksiyon.btnUpdateClick)
                {
                    UpdateFormuBoşalt();//update formunda bulunan çiftçi null oluyor.
                }
                if (aksiyon == Aksiyon.TabPageUpdateClick)
                {
                    UpdateFormuBoşalt();//update formunda bulunan çiftçi null oluyor.
                }
                aksiyon = Aksiyon.TabPageEkleClick;
                DataGridYinele(_ciftci);
            }
            else if (tabControl1.SelectedIndex == 1)//Guncelle TabPage
            {
                if (aksiyon == Aksiyon.ciftciGetirClick)
                {
                    EkleFormuBoşalt();//böylelikle ekle formunda bulunan çiftçi null oluyor..
                }
                if (aksiyon == Aksiyon.TabPageEkleClick || aksiyon == Aksiyon.btnAddClick)
                {
                    _ciftci = null;
                }
                aksiyon = Aksiyon.TabPageUpdateClick;
                DataGridYinele(_ciftci);
            }
        }
        private void btnUpdateTcAra_Click(object sender, EventArgs e)
        {
            string tcNo = txtupdateTc.Text;
            if (tcNo.Length != 11)
            {
                Utilities.Mesaj.MessageBoxWarning("Tc numarasını eksik yada hatalı girdiniz.");
                return;
            }
            //Tc numarasına ait çiftçi ve çks kaydını alıyoruz.
            _ciftci = _ciftciManager.GetByTc(tcNo);
            Cks cksKayit = _cksmanager.GetByTc(tcNo);
            if (cksKayit == null)
            {
                Utilities.Mesaj.MessageBoxWarning("Tc Numarasına ait kayıt bulunamadı.");
                return;
            }
            txtUpdateNameSurname.Text = _ciftci.IsimSoyisim;
            txtUpdateMobile.Text = _ciftci.CepTelefonu;
            txtUpdateHomePhone.Text = _ciftci.EvTelefonu;
            comboBoxUpdateVillage.Text = _ciftci.MahalleKoy;
            txtUpdateDosyaNo.Text = cksKayit.DosyaNo.ToString();
            dtpUpdateCreateTime.Text = cksKayit.CreateTime.ToString();
            txtAddNote.Text = cksKayit.Note;
            txtUpdateEvrakKayitNo.Text = cksKayit.EvrakKayitNo.ToString();
            comboBoxUpdateHavaleEdilenPersonel.Text = cksKayit.HavaleEdilenPersonel.ToString();
            if (cksKayit.MuracaatYeri == "E-Devlet Üzerinden yapılan başvuru")
            {
                checkBoxUpdateEDevlet.Checked = true;
            }
            else
            {
                checkBoxUpdateEDevlet.Checked = false;
            }
            DataGridYinele(_ciftci);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            aksiyon = Aksiyon.btnUpdateClick;
            string tcNo = txtupdateTc.Text;
            _ciftci = _ciftciManager.GetByTc(tcNo);
            Cks cksKayit = _cksmanager.GetByTc(tcNo);
            Edevlet edevlet = _edevletManager.GetAll().Where(I => I.CksId == cksKayit.Id).FirstOrDefault();
            cksKayit.CiftciId = _ciftci.Id;
            _ciftci.MahalleKoy = comboBoxUpdateVillage.Text;
            cksKayit.KullaniciId = _kullanici.Id;
            cksKayit.Note = txtUpdateNote.Text;
            cksKayit.DosyaNo = Convert.ToInt32(txtUpdateDosyaNo.Text);
            cksKayit.CreateTime = dtpUpdateCreateTime.Value;
            cksKayit.EvrakKayitNo = txtUpdateEvrakKayitNo.Text;
            cksKayit.HavaleEdilenPersonel = comboBoxUpdateHavaleEdilenPersonel.Text;
            _ciftci.CepTelefonu = txtUpdateMobile.Text;
            _ciftci.EvTelefonu = txtUpdateHomePhone.Text;
            _ciftci.MahalleKoy = comboBoxUpdateVillage.Text;
            if (checkBoxUpdateEDevlet.Checked == true)
            {
                if (_kullanici.KullaniciAdi == "caglar")
                {
                    cksKayit.MuracaatYeri = "E-Devlet Üzerinden yapılan başvuru";
                    _cksmanager.Update(cksKayit);
                    _ciftciManager.Update(_ciftci);
                    if (edevlet == null)
                    {
                        _edevletManager.Add(new Edevlet
                        {
                            CksId = cksKayit.Id,
                            DosyaNoEdevlet = txtEdevletUpdate.Text,
                            KullaniciId = cksKayit.KullaniciId

                        });
                    }
                    else
                    {
                        _edevletManager.Update(new Edevlet
                        {
                            Id = edevlet.Id,
                            CksId = cksKayit.Id,
                            DosyaNoEdevlet = txtEdevletUpdate.Text,
                            KullaniciId = cksKayit.KullaniciId

                        });
                    }
                    Utilities.Mesaj.MessageBoxInformation("Güncelleme işleme yapıldı.");

                    DataGridYinele(_ciftci);
                }

            }
            else
            {
                cksKayit.MuracaatYeri = "İlçe Tarım Müdürlüğünden yapılan başvuru";
                _cksmanager.Update(cksKayit);
                _ciftciManager.Update(_ciftci);

                if (edevlet != null)
                {
                    EdevletDal edevletDal = new EdevletDal();
                    edevletDal.Delete(edevlet);
                }

                Utilities.Mesaj.MessageBoxInformation("Güncelleme işleme yapıldı.");
                DataGridYinele(_ciftci);
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Utilities.ConnectionString.year == "2023")
            {
                Utilities.Mesaj.MessageBoxWarning("İşlem yapmak için süreniz dolmuştur.");
                return;

            }
            aksiyon = Aksiyon.btnDeleteClick;
            var silinecekCksKayit = _cksmanager.GetAll().Where(I => I.CiftciId == _ciftci.Id).FirstOrDefault();
            int result = _cksmanager.Delete(silinecekCksKayit);
            if (result == 1)
            {
                UpdateFormuBoşalt();
                _ciftci = null;
                DataGridYinele(_ciftci);
            }
        }
        private void btnYemBitkisiDestegi_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //herhangi bir çiftçi yoksa form açılmasın ...
            if (_ciftci == null)
            {
                Utilities.Mesaj.MessageBoxWarning("Öncelikle bir çiftçi seçimi yapmalısınız.");
                return;
            }
            Utilities.FormProperties.FormOpen("YemBitkisiForm", new YemBitkisiForm(_kullanici, _ciftci, button.Text), this, true, false);
        }
        private void btnSertifikaliTohumDestegi_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //herhangi bir çiftçi yoksa form açılmasın ...
            if (_ciftci == null)
            {
                Utilities.Mesaj.MessageBoxWarning("Öncelikle bir çiftçi seçimi yapmalısınız.");
                return;
            }
            Utilities.FormProperties.FormOpen("SertifikaliTohumForm", new SertifikaliTohumForm(_kullanici, _ciftci, button.Text), this, true, false);
        }
        private void btnFarkOdemesiDestegi_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //herhangi bir çiftçi yoksa form açılmasın ...
            if (_ciftci == null)
            {
                Utilities.Mesaj.MessageBoxWarning("Öncelikle bir çiftçi seçimi yapmalısınız.");
                return;
            }
            Utilities.FormProperties.FormOpen("FarkOdemesiForm", new FarkOdemesiForm(_kullanici, _ciftci, button.Text), this, true, false);
        }
        private void dgwListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgwListe.CurrentRow.Index;
            string tcNo = dgwListe.Rows[index].Cells["TcKimlikNo"].Value.ToString();
            Clipboard.SetText(tcNo);
        }
        private void checkBoxEdevlet_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEdevlet.Checked == true)
            {
                txtEdevlet.Visible = true;
            }
            else
            {
                txtEdevlet.Visible = false;
                txtEdevlet.Text = "";
            }
        }
        private void checkBoxUpdateEDevlet_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUpdateEDevlet.Checked == true)
            {
                txtEdevletUpdate.Visible = true;
            }
            else
            {
                txtEdevletUpdate.Visible = false;
                txtEdevletUpdate.Text = "";
            }
        }
    }
    enum Aksiyon
    {
        TabPageEkleClick,
        TabPageUpdateClick,
        datagridClick,
        ciftciGetirClick,
        FormLoad,
        btnUpdateClick,
        btnAddClick,
        btnDeleteClick
    }
}
