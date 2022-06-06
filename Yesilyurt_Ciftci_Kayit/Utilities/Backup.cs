using System;
using System.Collections.Generic;
using System.IO;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Manager;
namespace Yesilyurt_Ciftci_Kayit.Utilities
{
    public class Backup
    {
        CiftciManager _ciftciManager;
        CksManager _cksManager;
        FarkOdemesiManager _farkOdemesiManager;
        FirmaManager _firmaManager;
        KullaniciManager _kullaniciManager;
        SertifikaliTohumManager _sertifikaliTohumManager;
        UrunManager _urunManager;
        YemBitkisiManager _yemBitkisiManager;
        public Backup()
        {
            _ciftciManager = new CiftciManager();
            _cksManager = new CksManager();
            _farkOdemesiManager = new FarkOdemesiManager();
            _firmaManager = new FirmaManager();
            _kullaniciManager = new KullaniciManager();
            _sertifikaliTohumManager = new SertifikaliTohumManager();
            _urunManager = new UrunManager();
            _yemBitkisiManager = new YemBitkisiManager();
        }
        private string CiftciListesi()
        {
            List<Ciftci> ciftciler = _ciftciManager.GetAll();
            return Utilities.JsonOperations.JsonSerialize(ciftciler);
        }
        private string CksListesi()
        {
            List<Cks> cksListesi = _cksManager.GetAll();
            return Utilities.JsonOperations.JsonSerialize(cksListesi);
        }
        private string FarkOdemesiListesi()
        {
            List<FarkOdemesi> farkOdemesiListesi = _farkOdemesiManager.GetAll();
            return Utilities.JsonOperations.JsonSerialize(farkOdemesiListesi);
        }
        private string FirmaListesi()
        {
            List<Firma> firmalar = _firmaManager.GetAll();
            return Utilities.JsonOperations.JsonSerialize(firmalar);
        }
        private string KullaniciListesi()
        {
            List<Kullanici> kullanicilar = _kullaniciManager.GetAll();
            return Utilities.JsonOperations.JsonSerialize(kullanicilar);
        }
        private string SertifikaliTohumListesi()
        {
            List<SertifikaliTohum> sertifikaliTohumListesi = _sertifikaliTohumManager.GetAll();
            return Utilities.JsonOperations.JsonSerialize(sertifikaliTohumListesi);
        }
        private string UrunListesi()
        {
            List<Urun> urunler = _urunManager.GetAll();
            return Utilities.JsonOperations.JsonSerialize(urunler);
        }
        private string YemBitkisiListesi()
        {
            List<YemBitkisi> yemBitkisiListesi = _yemBitkisiManager.GetAll();
            return Utilities.JsonOperations.JsonSerialize(yemBitkisiListesi);
        }
        public void BackUpAll()
        {
            string backupTime = DateTime.Now.ToShortDateString();
            string SavePath = string.Empty;
            string folderPath = Utilities.FileOperations.FolderPath();
            if (string.IsNullOrEmpty(folderPath))
                return;
            folderPath = folderPath + "\\" + "Yeşilyurt Çks Programı Yedek";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            string ciftciler = CiftciListesi();
            string cksListesi = CksListesi();
            string farkOdemesiListesi = FarkOdemesiListesi();
            string firmalar = FirmaListesi();
            string urunler = UrunListesi();
            string kullaniciListesi = KullaniciListesi();
            string sertifikalıTohumListesi = SertifikaliTohumListesi();
            string yemBitkileriListesi = YemBitkisiListesi();
            SavePath = folderPath + "\\" + backupTime + " Ciftciler.json";
            System.IO.File.WriteAllText(SavePath, ciftciler);
            SavePath = folderPath + "\\" + backupTime + " CksListesi.json";
            System.IO.File.WriteAllText(SavePath, cksListesi);
            SavePath = folderPath + "\\" + backupTime + " FarkOdemesiListesi.json";
            System.IO.File.WriteAllText(SavePath, farkOdemesiListesi);
            SavePath = folderPath + "\\" + backupTime + " Firmalar.json";
            System.IO.File.WriteAllText(SavePath, firmalar);
            SavePath = folderPath + "\\" + backupTime + " Urunler.json";
            System.IO.File.WriteAllText(SavePath, urunler);
            SavePath = folderPath + "\\" + backupTime + " KullanıcıListesi.json";
            System.IO.File.WriteAllText(SavePath, kullaniciListesi);
            SavePath = folderPath + "\\" + backupTime + " SertifikalıTohumListesi.json";
            System.IO.File.WriteAllText(SavePath, sertifikalıTohumListesi);
            SavePath = folderPath + "\\" + backupTime + " YemBitkisiListesi.json";
            System.IO.File.WriteAllText(SavePath, yemBitkileriListesi);
            Utilities.Mesaj.MessageBoxInformation($"Yedekleme işlemi gerçekleşti.\n{folderPath} adresini kontrol ediniz.");
        }
    }
}
