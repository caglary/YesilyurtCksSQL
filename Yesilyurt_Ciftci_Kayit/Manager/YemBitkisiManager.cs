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
    public class YemBitkisiManager : IBaseManager<YemBitkisi>
    {
        //database class bağlı olacak..

        YemBitkisiDal dal;
        SqlDataReader _reader;
        public YemBitkisiManager()
        {
            dal = new YemBitkisiDal();

        }
        public int Result { get; set; }

        public int Add(YemBitkisi yemBitkisi)
        {
           
            
            //Bir çiftçinin bir tane dosya numarası olacak..farklı numaralarda dosya numarası olmayacak...

            //will code....
           

            return dal.Add(yemBitkisi);
        }

        public int Delete(YemBitkisi yemBitkisi)
        {
            Result = 0;
            Utilities.Question.IfYes(() => { Result = dal.Delete(yemBitkisi); }, $"{yemBitkisi.Ada}/{yemBitkisi.Parsel} ada parsel üzerindeki kaydı silmek istediğinizden emin misiniz?");

            return Result;

        }

        public List<YemBitkisi> GetAll()
        {
            List<YemBitkisi> liste = new List<YemBitkisi>();
            try
            {
                _reader = dal.GetAll();
                while (_reader.Read())
                {
                    liste.Add(new YemBitkisi()
                    {

                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        CksId = _reader.IsDBNull(1) ? 0 : _reader.GetInt32(1),
                        UrunId = _reader.IsDBNull(2) ? 0 : _reader.GetInt32(2),
                        DosyaNo = _reader.IsDBNull(3) ? 0 : _reader.GetInt32(3),
                        MuracaatTarihi = _reader.IsDBNull(4) ? DateTime.MinValue : _reader.GetDateTime(4),
                        EkilisYili = _reader.IsDBNull(5) ? "" : _reader.GetString(5),
                        AraziMahalle = _reader.IsDBNull(6) ? "" : _reader.GetString(6),
                        Ada = _reader.IsDBNull(7) ? "" : _reader.GetString(7),
                        Parsel = _reader.IsDBNull(8) ? "" : _reader.GetString(8),
                        MuracaatAlani = _reader.IsDBNull(9) ? "" : _reader.GetString(9),
                        TespitEdilenAlan = _reader.IsDBNull(10) ? "" : _reader.GetString(10),
                        KontrolTarihi = _reader.IsDBNull(11) ? "" : _reader.GetString(11),
                        KontrolEdenler = _reader.IsDBNull(12) ? "" : _reader.GetString(12),
                        Note = _reader.IsDBNull(13) ? "" : _reader.GetString(13),
                        KontrolDurumu = _reader.IsDBNull(14) ? "" : _reader.GetString(14),
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
                dal.BaglantiAyarla();
            }
            return liste.OrderByDescending(I => I.CreateTime).ToList();
        }
        public List<YemBitkisiDataGrid> GetAll_YemBitkisiDataGrid()
        {
            List<YemBitkisiDataGrid> liste = new List<YemBitkisiDataGrid>();
            try
            {
                _reader = dal.GetAll_YemBitkisiDataGrid();
                while (_reader.Read())
                {
                    liste.Add(new YemBitkisiDataGrid()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),

                        DosyaNo = _reader.IsDBNull(1) ? 0 : _reader.GetInt32(1),

                        UrunAdi = _reader.IsDBNull(2) ? "" : _reader.GetString(2),

                        EkilisYili = _reader.IsDBNull(3) ? "" : _reader.GetString(3),

                        AraziMahalle = _reader.IsDBNull(4) ? "" : _reader.GetString(4),

                        Ada = _reader.IsDBNull(5) ? "" : _reader.GetString(5),

                        Parsel = _reader.IsDBNull(6) ? "" : _reader.GetString(6),

                        MuracaatAlani = _reader.IsDBNull(7) ? "" : _reader.GetString(7),

                        MuracaatTarihi = _reader.IsDBNull(8) ? DateTime.MinValue : _reader.GetDateTime(8),
                        CksId = _reader.IsDBNull(9) ? 0 : _reader.GetInt32(9),
                        KontrolDurumu = _reader.IsDBNull(10) ? "" : _reader.GetString(10),
                        TespitEdilenAlan = _reader.IsDBNull(11) ? "" : _reader.GetString(11)




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
            return liste;
        }

        public int Update(YemBitkisi yemBitkisi)
        {
            return dal.Update(yemBitkisi);

        }

        //Table FOR Print

        public List<YemBitkileriPrint> GetAll_YemBitkileri_ForPrint()
        {
            List<YemBitkileriPrint> liste = new List<YemBitkileriPrint>();
            try
            {
                _reader = dal.GetAll_YemBitkileri_ForPrint();
                while (_reader.Read())
                {
                    liste.Add(new YemBitkileriPrint()
                    {
                      

                        DosyaNo = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),

                        TcKimlikNo = _reader.IsDBNull(1) ? "" : _reader.GetString(1),

                        IsimSoyisim = _reader.IsDBNull(2) ? "" : _reader.GetString(2),

                        BasvuruTarih = _reader.IsDBNull(3) ? DateTime.MinValue : _reader.GetDateTime(3),                       
                        AraziMahalle = _reader.IsDBNull(4) ? "" : _reader.GetString(4),

                        Urun = _reader.IsDBNull(5) ? "" : _reader.GetString(5),

                        Ada = _reader.IsDBNull(6) ? "" : _reader.GetString(6),

                        Parsel = _reader.IsDBNull(7) ? "" : _reader.GetString(7),

                        MuracaatAlani = _reader.IsDBNull(8) ? "" : _reader.GetString(8),

                        KontrolDurumu = _reader.IsDBNull(9) ? "" : _reader.GetString(9),

                        TespitEdilenAlan = _reader.IsDBNull(10) ? "" : _reader.GetString(10)

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
            return liste;
        }

    }
}
