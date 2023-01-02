using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Yesilyurt_Ciftci_Kayit.Database;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Entities.Tablo;
namespace Yesilyurt_Ciftci_Kayit.Manager
{
    public class FirmaManager : IBaseManager<Firma>
    {
        //database class bağlı olacak..
        FirmaDal _firmaDal;
        SqlDataReader _reader;
        public FirmaManager()
        {
            _firmaDal = new FirmaDal();
        }
        public int Result { get; set; }
        public int Add(Firma firma)
        {
            if (string.IsNullOrEmpty(firma.FirmaAdi) && string.IsNullOrEmpty(firma.VergiNo))
            {
                Utilities.Mesaj.MessageBoxWarning("Firma Adı ve Vergi No alanları boş geçilemez.");
                return 0;
            }
            return _firmaDal.Add(firma);
        }
        public int Delete(Firma firma)
        {
            Result = 0;
            Utilities.Question.IfYes(() => { _firmaDal.Delete(firma); },$"{firma.FirmaAdi} isimli firmayı silmek istiyor musnuz?");
            return Result; ;
        }
        public List<Firma> GetAll()
        {
            List<Firma> firmaListe = new List<Firma>();
            try
            {
                _reader = _firmaDal.GetAll();
                while (_reader.Read())
                {
                    firmaListe.Add(new Firma()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        FirmaAdi = _reader.IsDBNull(1) ? "" : _reader.GetString(1),
                        VergiNo = _reader.IsDBNull(2) ? "" : _reader.GetString(2),
                        Note = _reader.IsDBNull(3) ? "" : _reader.GetString(3),
                        KullaniciId = _reader.IsDBNull(4) ? 0 : _reader.GetInt32(4),
                        CreateTime = _reader.IsDBNull(5) ? DateTime.MinValue : _reader.GetDateTime(5),
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
                _firmaDal.BaglantiAyarla();
            }
            return firmaListe.OrderByDescending(I => I.CreateTime).ToList();
        }
        public List<FirmaDataGrid> GetAll_FirmaDataGrid()
        {
            List<FirmaDataGrid> firmaListe = new List<FirmaDataGrid>();
            try
            {
                _reader = _firmaDal.GetAll_FirmaDataGrid();
                while (_reader.Read())
                {
                    firmaListe.Add(new FirmaDataGrid()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        FirmaAdi = _reader.IsDBNull(1) ? "" : _reader.GetString(1)
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
                _firmaDal.BaglantiAyarla();
            }
            return firmaListe;
        }
        //GetAll_FirmaDataGrid
        public int Update(Firma firma)
        {
            return _firmaDal.Update(firma);
        }
    }
}
