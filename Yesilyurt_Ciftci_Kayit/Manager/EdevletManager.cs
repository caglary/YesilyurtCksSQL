using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Yesilyurt_Ciftci_Kayit.Database;
using Yesilyurt_Ciftci_Kayit.Entities;
namespace Yesilyurt_Ciftci_Kayit.Manager
{
    public class EdevletManager : IBaseManager<Edevlet>
    {
        public int Result { get; set; }
        EdevletDal dal;
        SqlDataReader _reader;
        public EdevletManager()
        {
            dal = new EdevletDal();
        }
        public int Add(Edevlet Entity)
        {
            Result = 0;
            Result = dal.Add(Entity);
            return Result;
        }
        public int Delete(Edevlet Entity)
        {
            Result = 0;

            Utilities.Question.IfYes(() =>
            {
                Result = dal.Delete(Entity);
            }, "Kaydı silmek istediğinize emin misiniz?");
            if (Result == 1)
            {
                Utilities.Mesaj.MessageBoxInformation("Kayıt silindi");
            }
            return Result;
        }
        public List<Edevlet> GetAll()
        {
            List<Edevlet> EdevletListesi = new List<Edevlet>();
            try
            {
                _reader = dal.GetAll();
                while (_reader.Read())
                {
                    EdevletListesi.Add(new Edevlet()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        CksId = _reader.IsDBNull(1) ? 0 : _reader.GetInt32(1),
                        DosyaNoEdevlet = _reader.IsDBNull(2) ? "" : _reader.GetString(2),
                        KullaniciId = _reader.IsDBNull(3) ? 0 : _reader.GetInt32(3),
                        CreateTime = _reader.IsDBNull(4) ? DateTime.MinValue : _reader.GetDateTime(4),
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
            return EdevletListesi.OrderByDescending(I => I.CreateTime).ToList();
        }
        public int Update(Edevlet Entity)
        {
            Result = 0;
            Result = dal.Update(Entity);
            return Result;
        }

    }
}
