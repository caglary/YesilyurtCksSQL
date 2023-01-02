using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesilyurt_Ciftci_Kayit.Database;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Entities.Tablo;
namespace Yesilyurt_Ciftci_Kayit.Manager
{
    public class UrunManager : IBaseManager<Urun>
    {
        //database class bağlı olacak..
        UrunDal _urunDal;
        SqlDataReader _reader;
        public UrunManager()
        {
            _urunDal = new UrunDal();
        }
        public int Result { get; set; }
        public int Add(Urun urun)
        {
            return _urunDal.Add(urun);
        }
        public int Delete(Urun urun)
        {
            Result = 0;
            Utilities.Question.IfYes(() => { Result = _urunDal.Delete(urun); },$"{urun.UrunAdi} adlı ürünü silmek istediğinize emin misiniz?");
            return Result;
        }
        public List<Urun> GetAll()
        {
            List<Urun> urunListe = new List<Urun>();
            try
            {
                _reader = _urunDal.GetAll();
                while (_reader.Read())
                {
                    urunListe.Add(new Urun()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        UrunAdi = _reader.IsDBNull(1) ? "" : _reader.GetString(1),
                        UrunCesidi = _reader.IsDBNull(2) ? "" : _reader.GetString(2),
                        KullaniciId = _reader.IsDBNull(3) ? 0 : _reader.GetInt32(3),
                        CreateTime = _reader.IsDBNull(4) ? DateTime.MinValue : _reader.GetDateTime(4),
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
                _urunDal.BaglantiAyarla();
            }
            return urunListe.OrderByDescending(I => I.CreateTime).ToList();
        }
        public List<UrunDataGrid> GetAll_UrunDataGrid()
        {
            List<UrunDataGrid> urunListe = new List<UrunDataGrid>();
            try
            {
                _reader = _urunDal.GetAll_UrunDataGrid();
                while (_reader.Read())
                {
                    urunListe.Add(new UrunDataGrid()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        UrunAdi = _reader.IsDBNull(1) ? "" : _reader.GetString(1),
                        UrunCesidi = _reader.IsDBNull(2) ? "" : _reader.GetString(2),
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
                _urunDal.BaglantiAyarla();
            }
            return urunListe;
        }
        public int Update(Urun urun)
        {
            return _urunDal.Update(urun);
        }
    }
}
