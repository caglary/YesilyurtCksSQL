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
    public class FarkOdemesiManager : IBaseManager<FarkOdemesi>
    {
        //database class bağlı olacak..
        icmalFarkOdemesiDal dal;
        SqlDataReader _reader;
        public FarkOdemesiManager()
        {
            dal = new icmalFarkOdemesiDal();
        }
        public int Result { get; set; }
        public int Add(FarkOdemesi farkOdemesi)
        {
            //will code....
            return dal.Add(farkOdemesi);
        }
        public int Delete(FarkOdemesi farkOdemesi)
        {
            Result = 0;
            Utilities.Question.IfYes(() =>
            {
                Result = dal.Delete(farkOdemesi);
            }, "Kaydı silmek istediğinizden emin misiniz?");
            //will code....
            return Result;
        }
        public List<FarkOdemesi> GetAll()
        {
            List<FarkOdemesi> liste = new List<FarkOdemesi>();
            try
            {
                _reader = dal.GetAll();
                while (_reader.Read())
                {
                    liste.Add(new FarkOdemesi()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        CksId = _reader.IsDBNull(1) ? 0 : _reader.GetInt32(1),
                        FirmaId = _reader.IsDBNull(2) ? 0 : _reader.GetInt32(2),
                        UrunId = _reader.IsDBNull(3) ? 0 : _reader.GetInt32(3),
                        DosyaNo = _reader.IsDBNull(4) ? 0 : _reader.GetInt32(4),
                        MuracaatTarihi = _reader.IsDBNull(5) ? DateTime.MinValue : _reader.GetDateTime(5),
                        FaturaNo = _reader.IsDBNull(6) ? "" : _reader.GetString(6),
                        FaturaTarihi = _reader.IsDBNull(7) ? DateTime.MinValue : _reader.GetDateTime(7),
                        Miktari = _reader.IsDBNull(8) ? "" : _reader.GetString(8),
                        BirimFiyati = _reader.IsDBNull(9) ? "" : _reader.GetString(9),
                        ToplamMaliyet = _reader.IsDBNull(10) ? "" : _reader.GetString(10),
                        Note = _reader.IsDBNull(11) ? "" : _reader.GetString(11),
                        OdemeDurumu = _reader.IsDBNull(12) ? "" : _reader.GetString(12),
                        KullaniciId = _reader.IsDBNull(13) ? 0 : _reader.GetInt32(13)
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
                dal.BaglantiAyarla();
            }
            return liste.OrderByDescending(I => I.CreateTime).ToList();
        }
        public int Update(FarkOdemesi farkOdemesi)
        {
            return dal.Update(farkOdemesi);
        }
        public List<FarkOdemesiDataGrid> GetAll_FarkOdemesiDataGrid()
        {
            List<FarkOdemesiDataGrid> farkOdemesiListe = new List<FarkOdemesiDataGrid>();
            try
            {
                _reader = dal.GetAll_FarkOdemesiDataGrid();
                while (_reader.Read())
                {
                    farkOdemesiListe.Add(new FarkOdemesiDataGrid()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        DosyaNo = _reader.IsDBNull(1) ? 0 : _reader.GetInt32(1),
                        FirmaAdi = _reader.IsDBNull(2) ? "" : _reader.GetString(2),
                        UrunAdi = _reader.IsDBNull(3) ? "" : _reader.GetString(3),
                        Miktari = _reader.IsDBNull(4) ? "" : _reader.GetString(4),
                        Note = _reader.IsDBNull(5) ? "" : _reader.GetString(5),
                        OdemeDurumu = _reader.IsDBNull(6) ? "" : _reader.GetString(6)
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
            return farkOdemesiListe;
        }
        public List<FarkOdemesiPrint> GetAll_FarkOdemesi_ForPrint()
        {
            List<FarkOdemesiPrint> farkOdemesiListe = new List<FarkOdemesiPrint>();
            try
            {
                _reader = dal.GetAll_FarkOdemesi_ForPrint();
                while (_reader.Read())
                {
                    farkOdemesiListe.Add(new FarkOdemesiPrint()
                    {
                        TcKimlikNo = _reader.IsDBNull(0) ? "" : _reader.GetString(0),
                        IsimSoyisim = _reader.IsDBNull(1) ? "" : _reader.GetString(1),
                        DosyaNo = _reader.IsDBNull(2) ? 0 : _reader.GetInt32(2),
                        MuracaatTarihi = _reader.IsDBNull(3) ? DateTime.MinValue : _reader.GetDateTime(3),
                        FirmaAdi = _reader.IsDBNull(4) ? "" : _reader.GetString(4),
                        UrunAdi = _reader.IsDBNull(5) ? "" : _reader.GetString(5),
                        Miktari = _reader.IsDBNull(6) ? "" : _reader.GetString(6),
                        OdemeDurumu = _reader.IsDBNull(7) ? "" : _reader.GetString(7)
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
            return farkOdemesiListe;
        }
        public List<FarkOdemesi> GetAll_FarkOdemesi()
        {
            List<FarkOdemesi> farkOdemesiListe = new List<FarkOdemesi>();
            try
            {
                _reader = dal.GetAll();
                while (_reader.Read())
                {
                    farkOdemesiListe.Add(new FarkOdemesi()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        CksId= _reader.IsDBNull(1) ? 0 : _reader.GetInt32(1),
                        FirmaId= _reader.IsDBNull(2) ? 0 : _reader.GetInt32(2),
                        UrunId= _reader.IsDBNull(3) ? 0 : _reader.GetInt32(3),
                        DosyaNo = _reader.IsDBNull(4) ? 0 : _reader.GetInt32(4),
                        MuracaatTarihi = _reader.IsDBNull(5) ? DateTime.MinValue : _reader.GetDateTime(5),
                        FaturaNo= _reader.IsDBNull(6) ? "" : _reader.GetString(6),
                        FaturaTarihi = _reader.IsDBNull(7) ? DateTime.MinValue : _reader.GetDateTime(7),
                        Miktari = _reader.IsDBNull(8) ? "" : _reader.GetString(8),
                        BirimFiyati= _reader.IsDBNull(9) ? "" : _reader.GetString(9),
                        ToplamMaliyet= _reader.IsDBNull(10) ? "" : _reader.GetString(10),
                        Note= _reader.IsDBNull(11) ? "" : _reader.GetString(11),
                        OdemeDurumu = _reader.IsDBNull(12) ? "" : _reader.GetString(12),
                        KullaniciId = _reader.IsDBNull(13) ? 1 : _reader.GetInt32(13),
                        CreateTime= _reader.IsDBNull(14) ? DateTime.MinValue : _reader.GetDateTime(14),
                      
                        
                      
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
            return farkOdemesiListe;
        }
    }
}
