using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Yesilyurt_Ciftci_Kayit.Database;
using Yesilyurt_Ciftci_Kayit.Entities;
namespace Yesilyurt_Ciftci_Kayit.Manager
{
    public class KullaniciManager : IBaseManager<Kullanici>
    {
        KullaniciDal _dal;
        SqlDataReader _reader;
        public KullaniciManager()
        {
            _dal = new KullaniciDal();
        }
        public int Result { get; set; }
        public int Add(Kullanici k)
        {
            Result = 0;
            if (string.IsNullOrEmpty(k.KullaniciAdi))
            {
                Utilities.Mesaj.MessageBoxWarning("Kullanici adı alanı boş geçilemez.");
                return Result;
            }
            if (string.IsNullOrEmpty(k.Parola))
            {
                Utilities.Mesaj.MessageBoxWarning("Parola adı alanı boş geçilemez.");
                return Result;
            }
            var parola = GetAll().Where(I => I.KullaniciAdi == k.KullaniciAdi).FirstOrDefault();
            if (parola == null)
            {
                Result = _dal.Add(k);
                if (Result == 1)
                {
                    Utilities.Mesaj.MessageBoxWarning("Kullanıcı Eklendi.");
                }
            }
            else
                Utilities.Mesaj.MessageBoxWarning("Eklemek istediğiniz kullanici adı mevcuttur.Başka bir kullanici adı girerek tekrar deneyiniz.");
            return Result;
        }
        public int Delete(Kullanici k)
        {
            Result = 0;
            
            Utilities.Question.IfYes(() =>
            {
                Result = _dal.Delete(k);
            }, $"{k.KullaniciAdi} isimli kullanıcıyı silmek istediğinizden emin misiniz?");
            return Result;
        }
        public List<Kullanici> GetAll()
        {
            List<Kullanici> Kullanicilar = new List<Kullanici>();
            try
            {
                _reader = _dal.GetAll();
                while (_reader.Read())
                {
                    Kullanicilar.Add(new Kullanici()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        KullaniciAdi = _reader.IsDBNull(1) ? "" : _reader.GetString(1),
                        Parola = _reader.IsDBNull(2) ? "" : _reader.GetString(2),
                        Yetki = _reader.IsDBNull(3) ? "" : _reader.GetString(3),
                        CreateTime = _reader.IsDBNull(4) ? DateTime.MinValue : _reader.GetDateTime(4),
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
            return Kullanicilar;
        }
        public int Update(Kullanici k)
        {
            Result = 0;
            Utilities.Question.IfYes(() =>
            {
                Result= _dal.Update(k);
            }, $"{k.KullaniciAdi} isimli kaydı güncellemek istediğinizden emin misiniz?");
            return Result;
        }
    }
}
