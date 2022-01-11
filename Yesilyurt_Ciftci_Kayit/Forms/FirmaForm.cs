using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Manager;

namespace Yesilyurt_Ciftci_Kayit.Forms
{
    public partial class FirmaForm : Form
    {
        Kullanici _kullanici;
        FirmaManager _firmaManager;
        Firma _firmaEntity = null;
        public FirmaForm(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
            _firmaManager = new FirmaManager();
        }

        private void FirmaForm_Load(object sender, EventArgs e)
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
            txtFirmaAdiGuncelle.Text = "";
            txtVergiNoGuncelle.Text = "";
            txtNoteGuncelle.Text = "";

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            //Ekle buton aktif olacak.

        }

        private void ListeYinele()
        {
            dgwListe.DataSource = _firmaManager.GetAll_FirmaDataGrid();
            Utilities.Datagrid.DataGridSettings(dgwListe,new string[] { "Id"});

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

            _firmaEntity = _firmaManager.GetAll().Where(I => I.Id == id).FirstOrDefault();
            //Güncelle formunu dolduruyoruz..
            //Aynı zamanda firma bilgilerini bir class içinde saklıyoruz.
            //Güncelleme ve silme işlemlerinde _firmaEntity kullanacağız.
            txtFirmaAdiGuncelle.Text = _firmaEntity.FirmaAdi;
            txtVergiNoGuncelle.Text = _firmaEntity.VergiNo;
            txtNoteGuncelle.Text = _firmaEntity.Note;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (_firmaEntity==null)
            {
                _firmaEntity = new Firma();
            }
            _firmaEntity.FirmaAdi = txtFirmaAdiEkle.Text;
            _firmaEntity.VergiNo = txtVergiNoEkle.Text;
            _firmaEntity.Note = txtNoteEkle.Text;
            _firmaEntity.KullaniciId = _kullanici.Id;

            result=_firmaManager.Add(_firmaEntity);
            if (result==1)
            {
                txtFirmaAdiEkle.Text = "";
                txtVergiNoEkle.Text = "";
                txtNoteEkle.Text = "";
                ListeYinele();

            }

            _firmaEntity = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _firmaManager.Delete(_firmaEntity);

            txtFirmaAdiGuncelle.Text = "";
            txtVergiNoGuncelle.Text = "";
            txtNoteGuncelle.Text = "";

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            _firmaEntity = null;

            ListeYinele();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _firmaEntity.FirmaAdi = txtFirmaAdiGuncelle.Text;
            _firmaEntity.VergiNo = txtVergiNoGuncelle.Text;
            _firmaEntity.Note = txtNoteGuncelle.Text;
            _firmaEntity.KullaniciId = _kullanici.Id;
            _firmaManager.Update(_firmaEntity);

            ListeYinele();

        }
    }
}
