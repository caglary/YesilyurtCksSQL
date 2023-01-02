using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Yesilyurt_Ciftci_Kayit.Database;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Entities.PrintTablo;
namespace Yesilyurt_Ciftci_Kayit.Manager
{
    public class TMOManager : IBaseManager<TMO>
    {
        TMODal _tmoDal;
        SqlDataReader _reader;
        public int Result { get; set; }
        public TMOManager()
        {
            _tmoDal = new TMODal();
        }
        public int Add(TMO Entity)
        {
            return _tmoDal.Add(Entity);
        }
        public int Delete(TMO Entity)
        {
            Result = 0;
            Utilities.Question.IfYes(() => { Result = _tmoDal.Delete(Entity); }, $" {Entity.FaturaNo} nolu faturayı silmek istediğinize emin misiniz?");
            return Result;
        }
        public List<TMO> GetAll()
        {
            List<TMO> tmoKayitlar = new List<TMO>();
            try
            {
                _reader = _tmoDal.GetAll();
                while (_reader.Read())
                {
                    tmoKayitlar.Add(new TMO()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        CksId = _reader.IsDBNull(1) ? 0 : _reader.GetInt32(1),
                        EvrakKayitNo = _reader.IsDBNull(2) ? "" : _reader.GetString(2),
                        EvrakKayitTarihi = _reader.IsDBNull(3) ? DateTime.MinValue : _reader.GetDateTime(3),
                        Note = _reader.IsDBNull(4) ? "" : _reader.GetString(4),
                        FirmaId = _reader.IsDBNull(5) ? 0 : _reader.GetInt32(5),
                        FaturaNo = _reader.IsDBNull(6) ? "" : _reader.GetString(6),
                        FaturaTarihi = _reader.IsDBNull(7) ? DateTime.MinValue : _reader.GetDateTime(7),
                        ProductId = _reader.IsDBNull(8) ? 0 : _reader.GetInt32(8),
                        Amount = _reader.IsDBNull(9) ? "" : _reader.GetString(9),
                        KullaniciId = _reader.IsDBNull(10) ? 0 : _reader.GetInt32(10),
                        CreateTime = _reader.IsDBNull(11) ? DateTime.MinValue : _reader.GetDateTime(11),
                        Donem = _reader.IsDBNull(12) ? "" : _reader.GetString(12),
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
                _tmoDal.BaglantiAyarla();
            }
            if (tmoKayitlar.Count == 0)
            {
                return new List<TMO>();
            }
            return tmoKayitlar.ToList();
        }
        public int Update(TMO Entity)
        {
            return _tmoDal.Update(Entity);
        }
        public List<TMOListPrint> GetAll_TMOKayitlar_ForPrint()
        {
            List<TMOListPrint> liste = new List<TMOListPrint>();
            try
            {
                _reader = _tmoDal.GetAll_TMOKayitlar_ForPrint();
                while (_reader.Read())
                {
                    TMOListPrint printEntity = new TMOListPrint();
                    printEntity.Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0);
                    printEntity.CksDosyaNo = _reader.IsDBNull(1) ? 0 : _reader.GetInt32(1);
                    printEntity.TcKimlikNo = _reader.IsDBNull(2) ? "" : _reader.GetString(2);
                    printEntity.IsimSoyisim = _reader.IsDBNull(3) ? "" : _reader.GetString(3);
                    printEntity.MahalleKoy = _reader.IsDBNull(4) ? "" : _reader.GetString(4);
                    printEntity.CepTelefonu = _reader.IsDBNull(5) ? "" : _reader.GetString(5);
                    printEntity.FaturaNo = _reader.IsDBNull(6) ? "" : _reader.GetString(6);
                    printEntity.FaturaTarihi = _reader.IsDBNull(7) ? "" : _reader.GetDateTime(7).ToShortDateString();
                    printEntity.Urun = _reader.IsDBNull(8) ? "" : _reader.GetString(8);
                    printEntity.Miktar = _reader.IsDBNull(9) ? "" : _reader.GetString(9);
                    printEntity.Not = _reader.IsDBNull(10) ? "" : _reader.GetString(10);
                    printEntity.EvrakKayitNo = _reader.IsDBNull(11) ? "" : _reader.GetString(11);
                    printEntity.CksId = _reader.IsDBNull(12) ? 0 : _reader.GetInt32(12);
                    printEntity.Donem = _reader.IsDBNull(13) ? "" : _reader.GetString(13);
                    liste.Add(printEntity);
                }
                _reader.Close();
            }
            catch (Exception ex)
            {
                Utilities.Mesaj.MessageBoxError(ex.Message);
            }
            finally
            {
                _tmoDal.BaglantiAyarla();
            }
            return liste;
        }
        internal void ClipboardTC()
        {
            //kodlanacak.
        }
    }
}
