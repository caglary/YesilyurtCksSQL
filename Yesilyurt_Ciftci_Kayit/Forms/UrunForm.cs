using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Manager;

namespace Yesilyurt_Ciftci_Kayit.Forms
{
    public partial class UrunForm : Form
    {
        Kullanici _kullanici;
        UrunManager _urunManager;
        Urun _urunEntity = null;
        public UrunForm(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
            _urunManager = new UrunManager();
        }

        private void UrunForm_Load(object sender, EventArgs e)
        {
            if (_kullanici.Yetki == "Read")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

            //Form  açıldığında liste ekrana gelecek.
            ListeYinele();

            //güncelleme formu boş olacak..
            //güncelleme butonları pasif olacak..
            txtUrunAdiGuncelle.Text = "";
            txtUrunCesidiGuncelle.Text = "";
           

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            //Ekle buton aktif olacak.
        }

        private void ListeYinele()
        {
            dgwListe.DataSource = _urunManager.GetAll_UrunDataGrid();
            Utilities.Datagrid.DataGridSettings(dgwListe,new string[] {"Id" });


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Urun eklenecekKayit = new Urun();
            eklenecekKayit.UrunAdi = txtUrunAdiEkle.Text;
            eklenecekKayit.UrunCesidi = txtUrunCesidiEkle.Text;
            eklenecekKayit.KullaniciId = _kullanici.Id;

           int result= _urunManager.Add(eklenecekKayit);
            if (result==1)
            {
                txtUrunAdiEkle.Text = "";
                txtUrunCesidiEkle.Text = "";
                ListeYinele();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _urunManager.Delete(_urunEntity);

            txtUrunAdiGuncelle.Text = "";
            txtUrunCesidiGuncelle.Text = "";

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            _urunEntity = null;

            ListeYinele();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _urunEntity.UrunAdi = txtUrunAdiGuncelle.Text;
            _urunEntity.UrunCesidi = txtUrunCesidiGuncelle.Text;
            _urunManager.Update(_urunEntity);
            ListeYinele();
        }

        private void dgwListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            try
            {
                index = dgwListe.CurrentRow.Index;
            }
            catch (Exception)
            {

                return;
            }
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            int id = (int)dgwListe.Rows[index].Cells["Id"].Value;

            _urunEntity = _urunManager.GetAll().Where(I => I.Id == id).FirstOrDefault();
            //Güncelle formunu dolduruyoruz..
            //Aynı zamanda firma bilgilerini bir class içinde saklıyoruz.
            //Güncelleme ve silme işlemlerinde _firmaEntity kullanacağız.
            txtUrunAdiGuncelle.Text = _urunEntity.UrunAdi;
            txtUrunCesidiGuncelle.Text = _urunEntity.UrunCesidi;
        }
    }
}
