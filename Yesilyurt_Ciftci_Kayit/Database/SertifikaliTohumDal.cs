using System;
using System.Data;
using System.Data.SqlClient;
using Yesilyurt_Ciftci_Kayit.Entities;
namespace Yesilyurt_Ciftci_Kayit.Database
{
    public class SertifikaliTohumDal : BaseDal, IBaseDal<SertifikaliTohum>
    {
        public int Add(SertifikaliTohum sertifikaliTohum)
        {
            try
            {
                command = new SqlCommand("insert into SertifikaliTohum (CksId,FirmaId,UrunId,DosyaNo,MuracaatTarihi,SertifikaNo,FaturaNo,FaturaTarihi,Miktari,BirimFiyati,ToplamMaliyet,Note,KullaniciId) values (@CksId,@FirmaId,@UrunId,@DosyaNo,@MuracaatTarihi,@SertifikaNo,@FaturaNo,@FaturaTarihi,@Miktari,@BirimFiyati,@ToplamMaliyet,@Note,@KullaniciId) ", connect);
                command.Parameters.Add("@CksId", SqlDbType.Int).Value = sertifikaliTohum.CksId;
                command.Parameters.Add("@FirmaId", SqlDbType.Int).Value = sertifikaliTohum.FirmaId;
                command.Parameters.Add("@UrunId", SqlDbType.Int).Value = sertifikaliTohum.UrunId;
                command.Parameters.Add("@DosyaNo", SqlDbType.Int).Value = sertifikaliTohum.DosyaNo;
                command.Parameters.Add("@MuracaatTarihi", SqlDbType.DateTime).Value = sertifikaliTohum.MuracaatTarihi;
                command.Parameters.Add("@SertifikaNo", SqlDbType.NVarChar).Value = sertifikaliTohum.SertifikaNo;
                command.Parameters.Add("@FaturaNo", SqlDbType.NVarChar).Value = sertifikaliTohum.FaturaNo;
                command.Parameters.Add("@FaturaTarihi", SqlDbType.DateTime).Value = sertifikaliTohum.FaturaTarihi;
                command.Parameters.Add("@Miktari", SqlDbType.Decimal).Value = sertifikaliTohum.Miktari;
                command.Parameters.Add("@BirimFiyati", SqlDbType.Decimal).Value = sertifikaliTohum.BirimFiyati;
                command.Parameters.Add("@ToplamMaliyet", SqlDbType.Decimal).Value = sertifikaliTohum.ToplamMaliyet;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = sertifikaliTohum.Note;
               
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = sertifikaliTohum.KullaniciId;
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
        public int Delete(SertifikaliTohum sertifikaliTohum)
        {
            try
            {
                command = new SqlCommand("delete from SertifikaliTohum where Id=@Id ", connect);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = sertifikaliTohum.Id;
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
            command = new SqlCommand("select * from SertifikaliTohum", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_SertifikaliTohumDataGrid()
        {
            command = new SqlCommand("select  SertifikaliTohum.Id, SertifikaliTohum.DosyaNo,Firma.FirmaAdi, Urun.UrunAdi, SertifikaliTohum.Miktari, SertifikaliTohum.Note, SertifikaliTohum.OdemeDurumu, Cks.Id as cksId from SertifikaliTohum inner join cks on SertifikaliTohum.CksId=cks.Id inner join Firma on SertifikaliTohum.FirmaId=Firma.Id inner join Urun on SertifikaliTohum.UrunId=Urun.Id", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_SertifikaliTohum_ForPrint()
        {
            command = new SqlCommand("select Ciftciler.TcKimlikNo, Ciftciler.NameSurname, SertifikaliTohum.DosyaNo, SertifikaliTohum.MuracaatTarihi, Firma.FirmaAdi, Urun.UrunAdi, SertifikaliTohum.Miktari SertifikaliTohum.OdemeDurumu from SertifikaliTohum inner join cks on cks.Id=SertifikaliTohum.CksId inner join firma on Firma.Id=SertifikaliTohum.FirmaId inner join Urun on Urun.Id=SertifikaliTohum.UrunId inner join Ciftciler on Ciftciler.Id=cks.CiftciId order by SertifikaliTohum.DosyaNo desc", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public int Update(SertifikaliTohum sertifikaliTohum)
        {
            try
            {
                command = new SqlCommand("update SertifikaliTohum set CksId=@CksId,FirmaId=@FirmaId,UrunId=@UrunId,DosyaNo=@DosyaNo,MuracaatTarihi=@MuracaatTarihi,SertifikaNo=@SertifikaNo, FaturaNo=@FaturaNo,FaturaTarihi=@FaturaTarihi,Miktari=@Miktari,BirimFiyati=@BirimFiyati,ToplamMaliyet=@ToplamMaliyet,Note=@Note,KullaniciId=@KullaniciId, OdemeDurumu=@OdemeDurumu where Id=@Id", connect);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = sertifikaliTohum.Id;
                command.Parameters.Add("@CksId", SqlDbType.Int).Value = sertifikaliTohum.CksId;
                command.Parameters.Add("@FirmaId", SqlDbType.Int).Value = sertifikaliTohum.FirmaId;
                command.Parameters.Add("@UrunId", SqlDbType.Int).Value = sertifikaliTohum.UrunId;
                command.Parameters.Add("@DosyaNo", SqlDbType.Int).Value = sertifikaliTohum.DosyaNo;
                command.Parameters.Add("@MuracaatTarihi", SqlDbType.DateTime).Value = sertifikaliTohum.MuracaatTarihi;
                command.Parameters.Add("@SertifikaNo", SqlDbType.NVarChar).Value = sertifikaliTohum.SertifikaNo;
                command.Parameters.Add("@FaturaNo", SqlDbType.NVarChar).Value = sertifikaliTohum.FaturaNo;
                command.Parameters.Add("@FaturaTarihi", SqlDbType.DateTime).Value = sertifikaliTohum.FaturaTarihi;
                command.Parameters.Add("@Miktari", SqlDbType.NVarChar).Value = sertifikaliTohum.Miktari;
                command.Parameters.Add("@BirimFiyati", SqlDbType.NVarChar).Value =sertifikaliTohum.BirimFiyati;
                command.Parameters.Add("@ToplamMaliyet", SqlDbType.NVarChar).Value = sertifikaliTohum.ToplamMaliyet;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = sertifikaliTohum.Note;
                command.Parameters.Add("@OdemeDurumu", SqlDbType.NVarChar).Value = sertifikaliTohum.OdemeDurumu;
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = sertifikaliTohum.KullaniciId;
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
