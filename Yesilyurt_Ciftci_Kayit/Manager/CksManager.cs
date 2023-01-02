using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Yesilyurt_Ciftci_Kayit.Database;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Entities.PrintTablo;
using Yesilyurt_Ciftci_Kayit.Entities.Tablo;
namespace Yesilyurt_Ciftci_Kayit.Manager
{
    public class CksManager : IBaseManager<Cks>
    {
        CksListesiDal dal;
        SqlDataReader _reader;
        public CksManager()
        {
            dal = new CksListesiDal();
        }
        public int Result { get; set; }
        public int Add(Cks cksKaydi)
        {
            Result = 0;
            //aynı tc kaydı olmayacak
            var TcSorgu = GetAll().Where(I => I.CiftciId == cksKaydi.CiftciId).FirstOrDefault();
            if (TcSorgu != null)
            {
                Utilities.Mesaj.MessageBoxWarning("Kaydedilmek istenen Tc Kimlik No mevcuttur.");
                return Result;
            }
            // aynı dosya no kaydı olmayacak...
            var dosyaNoSorgu = GetAll().Where(I => I.DosyaNo == cksKaydi.DosyaNo).FirstOrDefault();
            if (dosyaNoSorgu != null)
            {
                Utilities.Mesaj.MessageBoxWarning("Kaydedilmek istenen Dosya Numarası mevcuttur.Başka bir numara giriniz.");
                return Result;
            }
            Result = dal.Add(cksKaydi);
            return Result;
        }
        public int Delete(Cks cksKaydi)
        {
            int result = 0;
            EdevletManager edevletManager = new EdevletManager();
            var edevletkaydi = edevletManager.GetAll().Where(I => I.CksId == cksKaydi.Id).FirstOrDefault();
            if (edevletkaydi != null)
            {
                EdevletDal edevletDatabase = new EdevletDal();
                edevletDatabase.Delete(edevletkaydi);
             
            }
            result= dal.Delete(cksKaydi);
            if (result == 1)
            {
                Utilities.Mesaj.MessageBoxInformation("Kayıt silindi");
            }
            return result;
        }
        public List<Cks> GetAll()
        {
            List<Cks> cksListesi = new List<Cks>();
            try
            {
                _reader = dal.GetAll();
                while (_reader.Read())
                {
                    cksListesi.Add(new Cks()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        CiftciId = _reader.IsDBNull(1) ? 0 : _reader.GetInt32(1),
                        DosyaNo = _reader.IsDBNull(3) ? 0 : _reader.GetInt32(2),
                        //KoyMahalle = _reader.IsDBNull(3) ? "" : _reader.GetString(3),
                        Note = _reader.IsDBNull(3) ? "" : _reader.GetString(3),
                        KullaniciId = _reader.IsDBNull(4) ? 0 : _reader.GetInt32(4),
                        CreateTime = _reader.IsDBNull(5) ? DateTime.MinValue : _reader.GetDateTime(5),
                        EvrakKayitNo = _reader.IsDBNull(6) ? "" : _reader.GetString(6),
                        HavaleEdilenPersonel = _reader.IsDBNull(7) ? "" : _reader.GetString(7),
                        MuracaatYeri = _reader.IsDBNull(8) ? "" : _reader.GetString(8)
                    }); ; ;
                }
                _reader.Close();
            }
            catch (Exception ex)
            {
                Utilities.Mesaj.MessageBoxError(ex.Message);
            }
            finally
            {
                dal.BaglantiAyarla();
            }
            return cksListesi.OrderByDescending(I => I.CreateTime).ToList();
        }
        public List<CksDatagrid> GetAllCksDataGrid()
        {
            List<CksDatagrid> cksListesi = new List<CksDatagrid>();
            try
            {
                _reader = dal.GetAll_CksDataGrid();
                while (_reader.Read())
                {
                    cksListesi.Add(new CksDatagrid()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        DosyaNo = _reader.IsDBNull(1) ? 0 : _reader.GetInt32(1),
                        TcKimlikNo = _reader.IsDBNull(2) ? "" : _reader.GetString(2),
                        IsimSoyisim = _reader.IsDBNull(3) ? "" : _reader.GetString(3),
                        BabaAdi = _reader.IsDBNull(4) ? "" : _reader.GetString(4),
                        MobilePhone = _reader.IsDBNull(5) ? "" : _reader.GetString(5),
                        HomePhone = _reader.IsDBNull(6) ? "" : _reader.GetString(6),
                        KoyMahalle = _reader.IsDBNull(7) ? "" : _reader.GetString(7),
                        Note = _reader.IsDBNull(8) ? "" : _reader.GetString(8),
                        CreateTime = _reader.IsDBNull(9) ? DateTime.MinValue : _reader.GetDateTime(9),
                        EvrakKayitNo = _reader.IsDBNull(10) ? "" : _reader.GetString(10),
                        HavaleEdilenPersonel = _reader.IsDBNull(11) ? "" : _reader.GetString(11),
                        MuracaatYeri = _reader.IsDBNull(12) ? "" : _reader.GetString(12)
                    });
                }
                _reader.Close();
            }
            catch (Exception ex)
            {
                Utilities.Mesaj.MessageBoxError(ex.Message);
            }
            finally
            {
                dal.BaglantiAyarla();
            }
            return cksListesi.OrderByDescending(I => I.CreateTime).ToList();
        }
        public List<CksListesiPrint> GetAll_CKS_ForPrint()
        {
            List<CksListesiPrint> cksListesi = new List<CksListesiPrint>();
            try
            {
                _reader = dal.GetAll_CKS_ForPrint();
                while (_reader.Read())
                {
                    cksListesi.Add(new CksListesiPrint()
                    {
                        DosyaNo = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        TcKimlikNo = _reader.IsDBNull(1) ? "" : _reader.GetString(1),
                        IsimSoyisim = _reader.IsDBNull(2) ? "" : _reader.GetString(2),
                        BabaAdi = _reader.IsDBNull(3) ? "" : _reader.GetString(3),
                        CepTelefonu = _reader.IsDBNull(4) ? "" : _reader.GetString(4),
                        EvTelefonu = _reader.IsDBNull(5) ? "" : _reader.GetString(5),
                        KoyMahalle = _reader.IsDBNull(6) ? "" : _reader.GetString(6),
                        MuracaatTarihi = _reader.IsDBNull(7) ? DateTime.MinValue : _reader.GetDateTime(7),
                        EvrakKayitNo = _reader.IsDBNull(8) ? "" : _reader.GetString(8),
                        HavaleEdilenPersonel = _reader.IsDBNull(9) ? "" : _reader.GetString(9),
                        MuracaatYeri = _reader.IsDBNull(10) ? "" : _reader.GetString(10)
                    });
                }
                _reader.Close();
            }
            catch (Exception ex)
            {
                Utilities.Mesaj.MessageBoxError(ex.Message);
            }
            finally
            {
                dal.BaglantiAyarla();
            }
            return cksListesi;
        }
        public int Update(Cks cksKaydi)
        {
            Result = dal.Update(cksKaydi);
            return Result;
        }
        public int DosyaNoFactory()
        {
            int LastDosyaNo = 0;
            var liste = GetAll();
            if (liste.Count > 0)
            {
                LastDosyaNo = GetAll().OrderByDescending(I => I.DosyaNo).First().DosyaNo;
                if (liste.Count == LastDosyaNo)
                {
                    return LastDosyaNo + 1;
                }
                else if (liste.Count < LastDosyaNo)
                {
                    return LastDosyaNo + 1;
                }
            }
            return LastDosyaNo + 1;
        }
        public Cks GetByTc(string tcno)
        {
            Result = 0;
            CiftciManager ciftciManager = new CiftciManager();
            Ciftci ciftci = ciftciManager.GetByTc(tcno);
            if (ciftci == null)
            {
                return null;
            }
            Cks cksKayit = GetAll().Where(I => I.CiftciId == ciftci.Id).FirstOrDefault();
            return cksKayit;
        }
        public int Add(Cks cks, Edevlet edevlet)
        {
            Result = 0;
            Result = Add(cks);
            if (!string.IsNullOrEmpty(edevlet.DosyaNoEdevlet) && Result==1)
            {
                var cksKaydı = GetAll().Where(I => I.CiftciId == cks.CiftciId).FirstOrDefault();
                EdevletManager edevletManager = new EdevletManager();
                edevlet.CksId = cksKaydı.Id;
                Result = edevletManager.Add(edevlet);
            }
            if (Result!=1)
            {
                Result=dal.Delete(cks);
                if (Result != 0) throw new Exception("E devlet başvuru numarası eklenmeden çks kaydı yapıldı. kaydı silip tekrar deneyin...");
            }
            return Result;
        }
    }
}
