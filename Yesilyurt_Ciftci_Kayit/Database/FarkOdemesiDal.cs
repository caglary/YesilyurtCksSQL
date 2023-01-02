using System.Data;
using System.Data.SqlClient;
using Yesilyurt_Ciftci_Kayit.Entities;
namespace Yesilyurt_Ciftci_Kayit.Database
{
    public class FarkOdemesiDal : BaseDal, IBaseDal<FarkOdemesi>
    {
        public int Add(FarkOdemesi farkOdemesi)
        {
            try
            {
                command = new SqlCommand("insert into FarkOdemesi (CksId,FirmaId,UrunId,DosyaNo,MuracaatTarihi,FaturaNo,FaturaTarihi,Miktari,BirimFiyati,ToplamMaliyet,Note,KullaniciId) values(@CksId,@FirmaId,@UrunId,@DosyaNo,@MuracaatTarihi,@FaturaNo,@FaturaTarihi,@Miktari,@BirimFiyati,@ToplamMaliyet,@Note,@KullaniciId)", connect);
                command.Parameters.Add("@CksId", SqlDbType.Int).Value = farkOdemesi.CksId;
                command.Parameters.Add("@FirmaId", SqlDbType.Int).Value = farkOdemesi.FirmaId;
                command.Parameters.Add("@UrunId", SqlDbType.Int).Value = farkOdemesi.UrunId;
                command.Parameters.Add("@DosyaNo", SqlDbType.Int).Value = farkOdemesi.DosyaNo;
                command.Parameters.Add("@MuracaatTarihi", SqlDbType.DateTime).Value = farkOdemesi.MuracaatTarihi;
                command.Parameters.Add("@FaturaNo", SqlDbType.NVarChar).Value = farkOdemesi.FaturaNo;
                command.Parameters.Add("@FaturaTarihi", SqlDbType.DateTime).Value = farkOdemesi.FaturaTarihi;
                command.Parameters.Add("@Miktari", SqlDbType.NVarChar).Value = farkOdemesi.Miktari;
                command.Parameters.Add("@BirimFiyati", SqlDbType.NVarChar).Value = farkOdemesi.BirimFiyati;
                command.Parameters.Add("@ToplamMaliyet", SqlDbType.NVarChar).Value = farkOdemesi.ToplamMaliyet;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = farkOdemesi.Note;
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = farkOdemesi.KullaniciId;
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
        public int Delete(FarkOdemesi farkOdemesi)
        {
            try
            {
                command = new SqlCommand("delete from FarkOdemesi where Id=@Id", connect);
               
                command.Parameters.Add("@Id", SqlDbType.Int).Value = farkOdemesi.Id;
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
            command = new SqlCommand("select * from FarkOdemesi", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_FarkOdemesiDataGrid()
        {
            command = new SqlCommand("select FarkOdemesi.Id,FarkOdemesi.DosyaNo,Firma.FirmaAdi,Urun.UrunAdi,FarkOdemesi.Miktari,FarkOdemesi.Note,FarkOdemesi.OdemeDurumu from FarkOdemesi inner join cks on FarkOdemesi.CksId=cks.Id inner join Firma on FarkOdemesi.FirmaId=Firma.Id inner join Urun on FarkOdemesi.UrunId=Urun.Id", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_FarkOdemesi_ForPrint()
        {
            command = new SqlCommand("select  Ciftciler.TcKimlikNo, Ciftciler.NameSurname, fark.DosyaNo, fark.MuracaatTarihi, firma.FirmaAdi, Urun.UrunAdi, fark.Miktari, fark.OdemeDurumu from FarkOdemesi as fark inner join cks on fark.CksId=cks.Id inner join Firma on firma.Id=fark.FirmaId inner join Ciftciler on Ciftciler.Id=cks.CiftciId inner join Urun on Urun.Id=fark.UrunId order by fark.DosyaNo desc", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public int Update(FarkOdemesi farkOdemesi)
        {
            try
            {
                command = new SqlCommand("update FarkOdemesi set CksId=@CksId,FirmaId=@FirmaId,UrunId=@UrunId,DosyaNo=@DosyaNo,MuracaatTarihi=@MuracaatTarihi,FaturaNo=@FaturaNo,FaturaTarihi=@FaturaTarihi,Miktari=@Miktari,BirimFiyati=@BirimFiyati,ToplamMaliyet=@ToplamMaliyet,Note=@Note,OdemeDurumu=@OdemeDurumu,KullaniciId=@KullaniciId  where Id=@Id", connect);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = farkOdemesi.Id;
                command.Parameters.Add("@CksId", SqlDbType.Int).Value = farkOdemesi.CksId;
                command.Parameters.Add("@FirmaId", SqlDbType.Int).Value = farkOdemesi.FirmaId;
                command.Parameters.Add("@UrunId", SqlDbType.Int).Value = farkOdemesi.UrunId;
                command.Parameters.Add("@DosyaNo", SqlDbType.Int).Value = farkOdemesi.DosyaNo;
                command.Parameters.Add("@MuracaatTarihi", SqlDbType.DateTime).Value = farkOdemesi.MuracaatTarihi;
                command.Parameters.Add("@FaturaNo", SqlDbType.NVarChar).Value = farkOdemesi.FaturaNo;
                command.Parameters.Add("@FaturaTarihi", SqlDbType.DateTime).Value = farkOdemesi.FaturaTarihi;
                command.Parameters.Add("@Miktari", SqlDbType.Decimal).Value = farkOdemesi.Miktari;
                command.Parameters.Add("@BirimFiyati", SqlDbType.Decimal).Value = farkOdemesi.BirimFiyati;
                command.Parameters.Add("@ToplamMaliyet", SqlDbType.Decimal).Value = farkOdemesi.ToplamMaliyet;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = farkOdemesi.Note;
                command.Parameters.Add("@OdemeDurumu", SqlDbType.NVarChar).Value = farkOdemesi.OdemeDurumu;
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = farkOdemesi.KullaniciId;
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
