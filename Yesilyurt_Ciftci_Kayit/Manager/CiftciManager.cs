using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Yesilyurt_Ciftci_Kayit.Database;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Entities.Tablo;
namespace Yesilyurt_Ciftci_Kayit.Manager
{
    public class CiftciManager : IBaseManager<Ciftci>
    {
        CiftciDal _dal;
        SqlDataReader _reader;
        public CiftciManager()
        {
            _dal = new CiftciDal();
        }
        public int Result { get; set; }
        public int Add(Ciftci c)
        {
            Result = 0;
            if (string.IsNullOrEmpty(c.TcKimlikNo) || string.IsNullOrEmpty(c.IsimSoyisim) || string.IsNullOrEmpty(c.BabaAdi) || string.IsNullOrEmpty(c.AnneAdi) || string.IsNullOrEmpty(c.DogumTarihi) || string.IsNullOrEmpty(c.CepTelefonu) || string.IsNullOrEmpty(c.Il) || string.IsNullOrEmpty(c.Ilce) || string.IsNullOrEmpty(c.MahalleKoy))
            {
                Utilities.Mesaj.MessageBoxWarning("(*) işaretli alanları doldurunuz.");
                return Result;
            }
            if (c.TcKimlikNo.Length != 11)
            {
                Utilities.Mesaj.MessageBoxWarning("T.C. Kimlik No eksik yada yanlış girdiniz.");
                return Result;
            }
            bool tcSorguSonuc = TcKontrol(c.TcKimlikNo);
            if (tcSorguSonuc)
                Result = _dal.Add(c);
            return Result;
        }
        public int Delete(Ciftci c)
        {
            int sonuc = 0;
            if (c.Id == -1)
            {
                Utilities.Mesaj.MessageBoxWarning("Silinecek kayıt bulunamadı.");
                return 0;
            }
            Utilities.Question.IfYes(() =>
            {
                sonuc = _dal.Delete(c);
                if (sonuc == 1)
                {
                    Utilities.Mesaj.MessageBoxInformation("Kayıt silindi.");
                }
            }, $"{c.IsimSoyisim} isimli kaydı silmek istiyor musunuz?");
            return sonuc;
        }
        public List<Ciftci> GetAll()
        {
            List<Ciftci> Ciftcilerim = new List<Ciftci>();
            try
            {
                _reader = _dal.GetAll();
                while (_reader.Read())
                {
                    Ciftcilerim.Add(new Ciftci()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        TcKimlikNo = _reader.IsDBNull(1) ? "" : _reader.GetString(1),
                        IsimSoyisim = _reader.IsDBNull(2) ? "" : _reader.GetString(2),
                        BabaAdi = _reader.IsDBNull(3) ? "" : _reader.GetString(3),
                        AnneAdi = _reader.IsDBNull(4) ? "" : _reader.GetString(4),
                        DogumTarihi = _reader.IsDBNull(5) ? "" : _reader.GetString(5),
                        Cinsiyet = _reader.IsDBNull(6) ? "" : _reader.GetString(6),
                        MedeniDurum = _reader.IsDBNull(7) ? "" : _reader.GetString(7),
                        CepTelefonu = _reader.IsDBNull(8) ? "" : _reader.GetString(8),
                        EvTelefonu = _reader.IsDBNull(9) ? "" : _reader.GetString(9),
                        Email = _reader.IsDBNull(10) ? "" : _reader.GetString(10),
                        Il = _reader.IsDBNull(11) ? "" : _reader.GetString(11),
                        Ilce = _reader.IsDBNull(12) ? "" : _reader.GetString(12),
                        MahalleKoy = _reader.IsDBNull(13) ? "" : _reader.GetString(13),
                        Not = _reader.IsDBNull(14) ? "" : _reader.GetString(14),
                        KullaniciId = _reader.IsDBNull(15) ? 0 : _reader.GetInt32(15),
                        CreateTime = _reader.IsDBNull(16) ? DateTime.MinValue : _reader.GetDateTime(16),
                    }); ;
                }
                _reader.Close();
            }
            catch (Exception ex)
            {
                Utilities.Mesaj.MessageBoxError(ex.Message);
            }
            finally
            {
                _dal.BaglantiAyarla();
            }
            return Ciftcilerim.OrderByDescending(I => I.CreateTime).ToList();
        }
        public List<CiftciDataGrid> GetAll_CiftciDataGrid()
        {
            List<CiftciDataGrid> Ciftcilerim = new List<CiftciDataGrid>();
            try
            {
                _reader = _dal.GetAll_CiftciDataGrid();
                while (_reader.Read())
                {
                    Ciftcilerim.Add(new CiftciDataGrid()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        TcKimlikNo = _reader.IsDBNull(1) ? "" : _reader.GetString(1),
                        IsimSoyisim = _reader.IsDBNull(2) ? "" : _reader.GetString(2),
                        BabaAdi = _reader.IsDBNull(3) ? "" : _reader.GetString(3),
                        AnneAdi = _reader.IsDBNull(4) ? "" : _reader.GetString(4),
                        MahalleKoy = _reader.IsDBNull(5) ? "" : _reader.GetString(5)
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
                _dal.BaglantiAyarla();
            }
            return Ciftcilerim.ToList();
        }
        internal Ciftci GetByTc(string tcNumarasi)
        {
            if (tcNumarasi.Length != 11)
            {
                Utilities.Mesaj.MessageBoxWarning("Tc Numarasını eksik yada hatalı tuşladınız.");
                return null;
            }
            return GetAll().Where(I => I.TcKimlikNo == tcNumarasi).FirstOrDefault();
        }
        public int Update(Ciftci c)
        {
            Result = 0;
            if (c.Id == -1)
            {
                Utilities.Mesaj.MessageBoxWarning("Güncellenecek kayıt bulunamadı.");
                return Result;
            }
            Result = _dal.Update(c);
           
            return Result;
        }
        public bool TcKontrol(string tcNumarasi)
        {
            Ciftci _arananTc = GetAll().Where(I => I.TcKimlikNo == tcNumarasi).FirstOrDefault();
            if (_arananTc != null)
            {
                Utilities.Mesaj.MessageBoxWarning("TC Kimlik numarasını kontrol ediniz.Eklemek istediğiniz TC Kimlik No listede mevcuttur.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
