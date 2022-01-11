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
    public class SertifikaliTohumManager : IBaseManager<SertifikaliTohum>
    {
        //database class bağlı olacak..

        SertifikaliTohumDal dal;
        SqlDataReader _reader;
        public SertifikaliTohumManager()
        {
            dal = new SertifikaliTohumDal();

        }
        public int Result { get; set; }

        public int Add(SertifikaliTohum sertifikaliTohum)
        {

            //will code....

            return dal.Add(sertifikaliTohum);
        }

        public int Delete(SertifikaliTohum sertifikaliTohum)
        {
            //silmeden önce sor...

            //will code....

            return dal.Delete(sertifikaliTohum);

        }

        public List<SertifikaliTohum> GetAll()
        {
            List<SertifikaliTohum> liste = new List<SertifikaliTohum>();
            try
            {
                _reader = dal.GetAll();
                while (_reader.Read())
                {
                    liste.Add(new SertifikaliTohum()
                    {

                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        CksId = _reader.IsDBNull(1) ? 0 : _reader.GetInt32(1),
                        FirmaId = _reader.IsDBNull(2) ? 0 : _reader.GetInt32(2),
                        UrunId = _reader.IsDBNull(3) ? 0 : _reader.GetInt32(3),
                        DosyaNo = _reader.IsDBNull(4) ? 0 : _reader.GetInt32(4),
                        MuracaatTarihi = _reader.IsDBNull(5) ? DateTime.MinValue : _reader.GetDateTime(5),
                        SertifikaNo = _reader.IsDBNull(6) ? "" : _reader.GetString(6),
                        FaturaNo = _reader.IsDBNull(7) ? "" : _reader.GetString(7),
                        FaturaTarihi = _reader.IsDBNull(8) ? DateTime.MinValue : _reader.GetDateTime(8),
                        Miktari = _reader.IsDBNull(9) ? "" : _reader.GetString(9),
                        BirimFiyati = _reader.IsDBNull(10) ? "" : _reader.GetString(10),
                        ToplamMaliyet = _reader.IsDBNull(11) ? "" : _reader.GetString(11),
                        Note = _reader.IsDBNull(12) ? "" : _reader.GetString(12),
                        OdemeDurumu = _reader.IsDBNull(13) ? "" : _reader.GetString(13),

                        KullaniciId = _reader.IsDBNull(14) ? 0 : _reader.GetInt32(14)

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


        public List<SertifikaliTohumDataGrid> GetAll_SertifikaliTohumDataGrid()
        {
            List<SertifikaliTohumDataGrid> liste = new List<SertifikaliTohumDataGrid>();
            try
            {
                _reader = dal.GetAll_SertifikaliTohumDataGrid();
                while (_reader.Read())
                {
                    liste.Add(new SertifikaliTohumDataGrid()
                    {

                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),

                        DosyaNo = _reader.IsDBNull(1) ? 0 : _reader.GetInt32(1),
                        FirmaAdi = _reader.IsDBNull(2) ? "" : _reader.GetString(2),
                        UrunAdi = _reader.IsDBNull(3) ? "" : _reader.GetString(3),
                        Miktari = _reader.IsDBNull(4) ? "" : _reader.GetString(4),

                        Note = _reader.IsDBNull(5) ? "" : _reader.GetString(5),
                        OdemeDurumu = _reader.IsDBNull(6) ? "" : _reader.GetString(6),
                        CksId = _reader.IsDBNull(7) ? 0 : _reader.GetInt32(7)


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
            return liste;
        }
        public List<SertifikaliTohumPrint> GetAll_SertifikaliTohum_ForPrint()
        {
            List<SertifikaliTohumPrint> liste = new List<SertifikaliTohumPrint>();
            try
            {
                _reader = dal.GetAll_SertifikaliTohum_ForPrint();
                while (_reader.Read())
                {
                    liste.Add(new SertifikaliTohumPrint()
                    {
                        
                        TcKimlikNo = _reader.IsDBNull(0) ? "" : _reader.GetString(0),
                        IsimSoyisim = _reader.IsDBNull(1) ? "" : _reader.GetString(1),

                        DosyaNo = _reader.IsDBNull(2) ? 0 : _reader.GetInt32(2),
                        MuracaatTarihi = _reader.IsDBNull(3) ? DateTime.MinValue : _reader.GetDateTime(3),


                        FirmaAdi = _reader.IsDBNull(4) ? "" : _reader.GetString(4),

                        UrunAdi = _reader.IsDBNull(5) ? "" : _reader.GetString(5),

                        Miktari = _reader.IsDBNull(6) ? "" : _reader.GetString(6),
                        OdemeDurumu = _reader.IsDBNull(7) ? "" : _reader.GetString(7)

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
            return liste;
        }

        public int Update(SertifikaliTohum sertifikaliTohum)
        {
            return dal.Update(sertifikaliTohum);

        }
    }
}
