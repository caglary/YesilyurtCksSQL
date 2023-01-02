using System;
using System.Data;
using System.Data.SqlClient;
using Yesilyurt_Ciftci_Kayit.Entities;
namespace Yesilyurt_Ciftci_Kayit.Database
{
    public class YemBitkisiDal : BaseDal, IBaseDal<YemBitkisi>
    {
        public int Add(YemBitkisi yemBitkisi)
        {
            try
            {
                command = new SqlCommand("insert into YemBitkileri (CksId,UrunId,DosyaNo,MuracaatTarihi,EkilisYili,AraziMahalle,Ada,Parsel,MuracaatAlani,TespitEdilenAlan, KontrolTarihi,KontrolEdenler,Note,KontrolDurumu,KullaniciId) values (@CksId,@UrunId,@DosyaNo,@MuracaatTarihi,@EkilisYili,@AraziMahalle,@Ada,@Parsel,@MuracaatAlani,@TespitEdilenAlan,@KontrolTarihi,@KontrolEdenler,@Note,@KontrolDurumu,@KullaniciId)", connect);
                command.Parameters.Add("@CksId", SqlDbType.Int).Value = yemBitkisi.CksId;
                command.Parameters.Add("@UrunId", SqlDbType.Int).Value = yemBitkisi.UrunId;
                command.Parameters.Add("@DosyaNo", SqlDbType.Int).Value = yemBitkisi.DosyaNo;
                command.Parameters.Add("@MuracaatTarihi", SqlDbType.DateTime).Value = yemBitkisi.MuracaatTarihi;
                command.Parameters.Add("@EkilisYili", SqlDbType.NVarChar).Value = yemBitkisi.EkilisYili;
                command.Parameters.Add("@AraziMahalle", SqlDbType.NVarChar).Value = yemBitkisi.AraziMahalle;
                command.Parameters.Add("@Ada", SqlDbType.NVarChar).Value = yemBitkisi.Ada;
                command.Parameters.Add("@Parsel", SqlDbType.NVarChar).Value = yemBitkisi.Parsel;
                command.Parameters.Add("@MuracaatAlani", SqlDbType.NVarChar).Value = yemBitkisi.MuracaatAlani;
                command.Parameters.Add("@TespitEdilenAlan", SqlDbType.NVarChar).Value = yemBitkisi.TespitEdilenAlan;
                command.Parameters.Add("@KontrolTarihi", SqlDbType.NVarChar).Value = yemBitkisi.KontrolTarihi==null ? "" : yemBitkisi.KontrolTarihi;
                command.Parameters.Add("@KontrolEdenler", SqlDbType.NVarChar).Value = yemBitkisi.KontrolEdenler==null ?"":yemBitkisi.KontrolEdenler;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = yemBitkisi.Note;
                command.Parameters.Add("@KontrolDurumu", SqlDbType.NVarChar).Value = yemBitkisi.KontrolDurumu;
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = yemBitkisi.KullaniciId;
                BaglantiAyarla();
                result = command.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                Utilities.Mesaj.MessageBoxError(ex.Message);
            }
            finally
            {
                BaglantiAyarla();
            }
            return result;
        }
        public int Delete(YemBitkisi yemBitkisi)
        {
            try
            {
                command = new SqlCommand("delete from YemBitkileri where Id=@Id", connect);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = yemBitkisi.Id;
                BaglantiAyarla();
                result = command.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                Utilities.Mesaj.MessageBoxError(ex.Message);
            }
            finally
            {
                BaglantiAyarla();
            }
            return result;
        }
        public SqlDataReader GetAll()
        {
            command = new SqlCommand("select * from YemBitkileri", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_YemBitkisiDataGrid()
        {
            command = new SqlCommand("select  YemBitkileri.Id, YemBitkileri.DosyaNo, Urun.UrunAdi, YemBitkileri.EkilisYili, YemBitkileri.AraziMahalle, YemBitkileri.Ada, YemBitkileri.Parsel, YemBitkileri.MuracaatAlani, YemBitkileri.MuracaatTarihi, YemBitkileri.CksId, YemBitkileri.KontrolDurumu, YemBitkileri.TespitEdilenAlan from YemBitkileri inner join Cks  on YemBitkileri.CksId=cks.Id inner join Urun on YemBitkileri.UrunId=Urun.Id", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_YemBitkileri_ForPrint()
        {
            command = new SqlCommand("SELECT  YemBitkileri.DosyaNo as [Dosya No], Ciftciler.TcKimlikNo as TcNo, ciftciler.NameSurname as [İsim Soyisim], YemBitkileri.MuracaatTarihi as [Başvuru Tarih] , YemBitkileri.AraziMahalle as [Köy/Mahalle], Urun.UrunAdi as [Ürün], YemBitkileri.Ada, YemBitkileri.Parsel, YemBitkileri.MuracaatAlani as [Başvuru Alan], YemBitkileri.KontrolDurumu as [Kontrol Durumu], YemBitkileri.TespitEdilenAlan as [Tespit Edilen Alan] FROM YemBitkileri inner join Cks on YemBitkileri.CksId=Cks.Id inner join Ciftciler on Cks.CiftciId=Ciftciler.Id inner join Urun on YemBitkileri.UrunId=Urun.Id order by YemBitkileri.DosyaNo desc", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public int Update(YemBitkisi yemBitkisi)
        {
            try
            {
                command = new SqlCommand("update YemBitkileri set CksId=@CksId, UrunId=@UrunId,DosyaNo=@DosyaNo,MuracaatTarihi=@MuracaatTarihi,EkilisYili=@EkilisYili,AraziMahalle=@AraziMahalle,Ada=@Ada,Parsel=@Parsel,MuracaatAlani=@MuracaatAlani,TespitEdilenAlan=@TespitEdilenAlan,KontrolTarihi=@KontrolTarihi,KontrolEdenler=@KontrolEdenler,Note=@Note,KontrolDurumu=@KontrolDurumu,KullaniciId=@KullaniciId, @CreateTime=CreateTime where Id=@Id ", connect);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = yemBitkisi.Id;
                command.Parameters.Add("@CksId", SqlDbType.Int).Value = yemBitkisi.CksId;
                command.Parameters.Add("@UrunId", SqlDbType.Int).Value = yemBitkisi.UrunId;
                command.Parameters.Add("@DosyaNo", SqlDbType.Int).Value = yemBitkisi.DosyaNo;
                command.Parameters.Add("@MuracaatTarihi", SqlDbType.Date).Value = yemBitkisi.MuracaatTarihi;
                command.Parameters.Add("@EkilisYili", SqlDbType.NVarChar).Value = yemBitkisi.EkilisYili;
                command.Parameters.Add("@AraziMahalle", SqlDbType.NVarChar).Value = yemBitkisi.AraziMahalle;
                command.Parameters.Add("@Ada", SqlDbType.NVarChar).Value = yemBitkisi.Ada;
                command.Parameters.Add("@Parsel", SqlDbType.NVarChar).Value = yemBitkisi.Parsel;
                command.Parameters.Add("@MuracaatAlani", SqlDbType.Decimal).Value = yemBitkisi.MuracaatAlani;
                command.Parameters.Add("@TespitEdilenAlan", SqlDbType.Decimal).Value = yemBitkisi.TespitEdilenAlan;
                command.Parameters.Add("@KontrolTarihi", SqlDbType.NVarChar).Value = yemBitkisi.KontrolTarihi;
                command.Parameters.Add("@KontrolEdenler", SqlDbType.NVarChar).Value = yemBitkisi.KontrolEdenler;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = yemBitkisi.Note;
                command.Parameters.Add("@KontrolDurumu", SqlDbType.NVarChar).Value = yemBitkisi.KontrolDurumu;
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = yemBitkisi.KullaniciId;
                command.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Now;
                BaglantiAyarla();
                result = command.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                Utilities.Mesaj.MessageBoxError(ex.Message);
            }
            finally
            {
                BaglantiAyarla();
            }
            return result;
        }
    }
}
