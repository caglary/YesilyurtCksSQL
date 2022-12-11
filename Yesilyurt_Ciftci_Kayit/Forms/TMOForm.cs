using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Manager;

namespace Yesilyurt_Ciftci_Kayit.Forms
{
    public partial class TMOForm : Form
    {
        Kullanici _kullanici;
        TMOManager _tmoManager;
        Cks _cks;
        Ciftci _ciftci;
        CksManager _cksManager;
        CiftciManager _ciftciManager;
        UrunManager _urunManager;
        FirmaManager _firmaManager;

        //silme işlemi yaparken gerekli
        int silinecekKayitId;

        //datagrid her tıklandığında kayıt tutulsun
        TMO _tmoKayit;


        public TMOForm(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
            _tmoManager = new TMOManager();
            _cksManager = new CksManager();
            _ciftciManager = new CiftciManager();
            _cks = new Cks();
            _ciftci = new Ciftci();
            _urunManager = new UrunManager();
            _firmaManager = new FirmaManager();
            _tmoKayit = new TMO();


        }

        private void TMOForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Hoşgeldin {_kullanici.KullaniciAdi}";
            dataGridView1.DataSource = _tmoManager.GetAll();
            DataGridViewYinele();
            btnArpa.Enabled = false;
            btnBugday.Enabled = false;
        }

        List<Entities.PrintTablo.TMOListPrint> AllList()
        {
            //Tüm Liste
            return _tmoManager.GetAll_TMOKayitlar_ForPrint();
        }
        List<Entities.PrintTablo.TMOListPrint> AllListByCksId(int cksId)
        {
            //ÇKS id numarasına göre
            return _tmoManager.GetAll_TMOKayitlar_ForPrint().Where(I => I.CksId == cksId).ToList();
        }
        private void DataGridViewYinele()
        {
            if (_cks != null)
            {
                dataGridView1.DataSource = AllListByCksId(_cks.Id);
                DataGridColumnsVisibleSetting();

            }
            else
            {
                dataGridView1.DataSource = AllList();
                DataGridColumnsVisibleSetting();

            }
        }

        private void DataGridColumnsVisibleSetting()
        {
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["CksId"].Visible = false;
            dataGridView1.Columns["CksDosyaNo"].DisplayIndex = 1;
            dataGridView1.Columns["TcKimlikNo"].DisplayIndex = 2;
            dataGridView1.Columns["IsimSoyisim"].DisplayIndex = 3;
            dataGridView1.Columns["MahalleKoy"].DisplayIndex = 4;
            dataGridView1.Columns["CepTelefonu"].DisplayIndex = 5;
            dataGridView1.Columns["FaturaNo"].DisplayIndex = 6;
            dataGridView1.Columns["FaturaTarihi"].DisplayIndex = 7;
            dataGridView1.Columns["Urun"].DisplayIndex = 8;
            dataGridView1.Columns["Miktar"].DisplayIndex = 9;
            dataGridView1.Columns["Not"].DisplayIndex = 10;
            dataGridView1.Columns["EvrakKayitNo"].DisplayIndex = 11;
            dataGridView1.Columns["Donem"].DisplayIndex = 12;

            groupBox3.Text = $" Toplam {_tmoManager.GetAll().Count()} adet fatura mevcuttur.";
            var kisiSayisi= _tmoManager.GetAll_TMOKayitlar_ForPrint().GroupBy(I => I.TcKimlikNo).Count();
            lblKisiSayisi.Text = $"Toplam Kişi Sayısı: {kisiSayisi}";

        }

        TMO CreateEntityAdd(int urunId, int firmaId)
        {
            bool kaydet = false;
            string hangiDonem = "";
            if (checkBoxFark1.Checked == true)
            {
                hangiDonem = "1.Fark Dönemi";
                kaydet = true;
            }
            else if (checkBoxNormalDonem.Checked == true)
            {
                hangiDonem = "Normal Dönem";
                kaydet = true;

            }
            else
            {
                Utilities.Mesaj.MessageBoxWarning("Bir icmal dönemi seçiniz.");
                kaydet = false;


            }
            //entity oluştururken id tanımlaması yapmıyoruz.
            TMO kayit = new TMO()
            {
                Note = txtNote.Text,
                KullaniciId = _kullanici.Id,
                Amount = txtAmount.Text,
                CksId = _cks.Id,
                CreateTime = DateTime.Now,
                EvrakKayitNo = txtEvrakKayitNo.Text,
                FaturaNo = txtFaturaHarf.Text + " " + txtFaturaNo.Text,
                FaturaTarihi = dateTimePickerFaturaTarihiAdd.Value,
                ProductId = urunId,
                EvrakKayitTarihi = dateTimePickerEvrakKayitTarihiAdd.Value,
                FirmaId = firmaId,
                Donem = hangiDonem




            };
            if (kaydet)
            {
                return kayit;

            }
            else
            {
                return null;
            }
        }

        void Kaydet(string urunAdi)
        {


            try
            {

            first:
                var urun = _urunManager.GetAll().Where(I => I.UrunAdi == urunAdi && I.UrunCesidi == "Bilinmiyor").FirstOrDefault();
                var firma = _firmaManager.GetAll().Where(I => I.FirmaAdi == "TMO").FirstOrDefault();
                if (urun == null)
                {
                    Urun yeniUrun = new Urun() { CreateTime = DateTime.Now, KullaniciId = _kullanici.Id, UrunAdi = urunAdi, UrunCesidi = "Bilinmiyor" };
                    _urunManager.Add(yeniUrun);

                    goto first;
                }
                if (firma == null)
                {
                    Firma yeniFirma = new Firma() { FirmaAdi = "TMO", CreateTime = DateTime.Now, KullaniciId = _kullanici.Id, Note = "", VergiNo = "8540050958" };
                    _firmaManager.Add(yeniFirma);
                    goto first;
                }

                var kayit = CreateEntityAdd(urun.Id, firma.Id);
                if (kayit!=null)
                {
                    _tmoManager.Add(kayit);
                    DataGridViewYinele();
                }
                


            }
            catch (Exception ex)
            {
                if (_cks == null)
                {
                    Utilities.Mesaj.MessageBoxWarning("İşlem yapmak için çifçi seçiniz."); return;
                }
                else
                {
                    Utilities.Mesaj.MessageBoxError(ex.Message);
                }

            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtTcKimlikNo.Text) && txtTcKimlikNo.Text.Length == 11)
            {
                //ciftci cks kaydını getireceğiz.
                _cks = _cksManager.GetByTc(txtTcKimlikNo.Text);

                //çifçinin çks si yoksa işlem sonlanacak. ekrana mesaj verilecek.
                if (_cks == null)
                {
                    Utilities.Mesaj.MessageBoxInformation($"{txtTcKimlikNo.Text} T.C. Kimlik nolu çiftçinin çks kaydı yoktur.");

                    lblCiftciBilgi.Text = $"T.C. Kimlik numarası ile çiftçi arayınız.";

                    DataGridViewYinele();
                    return;
                }
                //çks kaydı varsa
                //çiftçi bilgilerini al
                _ciftci = _ciftciManager.GetByTc(txtTcKimlikNo.Text);



                lblCiftciBilgi.Text = $"{_ciftci.IsimSoyisim}  -  Dosya No: {_cks.DosyaNo}";


                DataGridViewYinele();



            }
            btnArpa.Enabled = true;
            btnBugday.Enabled = true;


        }

        private void btnArpa_Click(object sender, EventArgs e)
        {
            Kaydet("Arpa");
        }

        private void btnBugday_Click(object sender, EventArgs e)
        {
            Kaydet("Buğday");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (silinecekKayitId != 0)
                {
                    var silinecekKayit = _tmoManager.GetAll().Where(I => I.Id == silinecekKayitId).FirstOrDefault();
                    if (silinecekKayit != null)
                    {
                        var returnValue = _tmoManager.Delete(silinecekKayit);
                        DataGridViewYinele();
                        if (returnValue == 0)
                        {
                            DataGridSelectRowById(silinecekKayitId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Utilities.Mesaj.MessageBoxError(ex.Message);
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            silinecekKayitId = (int)dataGridView1.Rows[index].Cells["Id"].Value;
            _tmoKayit = _tmoManager.GetAll().Where(I => I.Id == silinecekKayitId).FirstOrDefault();
            UpdateFormFill(_tmoKayit);
            _tmoManager.ClipboardTC();


        }

        private void UpdateFormFill(TMO kayit)
        {
            txtUpdateFaturaNo.Text = kayit.FaturaNo;
            dateTimePickerFaturaTarihiUpdate.Value = Convert.ToDateTime(kayit.FaturaTarihi);
            txtUpdateAmount.Text = kayit.Amount;
            txtUpdateEvrakKayitNo.Text = kayit.EvrakKayitNo;
            dateTimePickerEvrakKayitTarihiUpdate.Value = Convert.ToDateTime(kayit.EvrakKayitTarihi);
            txtNoteUpdate.Text = kayit.Note;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_cks == null || _cks.Id == 0) return;
            _tmoKayit.FaturaNo = txtUpdateFaturaNo.Text;
            _tmoKayit.FaturaTarihi = dateTimePickerFaturaTarihiUpdate.Value;
            _tmoKayit.Amount = txtUpdateAmount.Text;
            _tmoKayit.EvrakKayitNo = txtUpdateEvrakKayitNo.Text;
            _tmoKayit.EvrakKayitTarihi = dateTimePickerEvrakKayitTarihiUpdate.Value;
            _tmoKayit.Note = txtNoteUpdate.Text;

            _tmoManager.Update(_tmoKayit);
            DataGridViewYinele();

            DataGridSelectRowById(_tmoKayit.Id);

        }

        private void DataGridSelectRowById(int id)
        {
            //güncellenen kaydı yinelenen listede işaretlemek için
            dataGridView1.ClearSelection();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((int)row.Cells["Id"].Value == id)
                {
                    row.Selected = true;
                }

            }
        }
        void ToExcel()
        {
            var datatable = Utilities.ExcelExport.ConvertToDataTable<Entities.PrintTablo.TMOListPrint>(_tmoManager.GetAll_TMOKayitlar_ForPrint());
            var path = Utilities.FolderBrowser.Path();
            path = path + @"\TMO2022FaturaListesi.xlsx";
            Utilities.Mesaj.MessageBoxInformation("Kayıt işleminiz başladı.İşlem tamamlandığında bilgilendirileceksiniz.");
            Task.Run(() => { Utilities.ExcelExport.GenerateExcel(datatable, path); });
        }

        private void btnToExcel_Click(object sender, EventArgs e)
        {
            ToExcel();
        }

        private void btnTumListe_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _tmoManager.GetAll_TMOKayitlar_ForPrint();
        }
    }


}
