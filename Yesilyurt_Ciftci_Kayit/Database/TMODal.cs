using System.Data;
using System.Data.SqlClient;
using Yesilyurt_Ciftci_Kayit.Entities;
namespace Yesilyurt_Ciftci_Kayit.Database
{
    public class TMODal : BaseDal, IBaseDal<TMO>
    {
        public int Add(TMO Entity)
        {
            try
            {
                command = new SqlCommand("insert into TMOKayitlar (CksId,EvrakKayitNo,EvrakKayitTarihi,Note,FirmaId,FaturaNo,FaturaTarihi,ProductId,Amount,KullaniciId,CreateTime,Donem) values (@CksId,@EvrakKayitNo,@EvrakKayitTarihi,@Note,@FirmaId,@FaturaNo,@FaturaTarihi,@ProductId,@Amount,@KullaniciId,@CreateTime,@Donem) ", connect);
                command.Parameters.Add("@CksId", SqlDbType.Int).Value = Entity.CksId;
                command.Parameters.Add("@EvrakKayitNo", SqlDbType.NVarChar).Value = Entity.EvrakKayitNo;
                command.Parameters.Add("@EvrakKayitTarihi", SqlDbType.DateTime).Value = Entity.EvrakKayitTarihi;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = Entity.Note;
                command.Parameters.Add("@FirmaId", SqlDbType.Int).Value = Entity.FirmaId;
                command.Parameters.Add("@FaturaNo", SqlDbType.NVarChar).Value = Entity.FaturaNo;
                command.Parameters.Add("@FaturaTarihi", SqlDbType.DateTime).Value = Entity.FaturaTarihi;
                command.Parameters.Add("@ProductId", SqlDbType.Int).Value = Entity.ProductId;
                command.Parameters.Add("@Amount", SqlDbType.NVarChar).Value = Entity.Amount;
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = Entity.KullaniciId;
                command.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = Entity.CreateTime;
                command.Parameters.Add("@Donem", SqlDbType.NVarChar).Value = Entity.Donem;
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
        public int Delete(TMO Entity)
        {
            try
            {
                command = new SqlCommand("delete from TMOKayitlar where Id=@Id", connect);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = Entity.Id;
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
            command = new SqlCommand("select * from TMOKayitlar", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_TMOKayitlar_ForPrint()
        {
            command = new SqlCommand("select TMOKayitlar.Id, Cks.DosyaNo as [ÇKS Dosya No], Ciftciler.TcKimlikNo  Ciftciler.NameSurname as [İsim Soyisim], Ciftciler.Village as [Mahalle/Köy], Ciftciler.MobilePhone as [Cep Telefonu], TMOKayitlar.FaturaNo as [Fatura No], TMOKayitlar.FaturaTarihi as [Fatura Tarihi], Urun.UrunAdi as [Ürün], TMOKayitlar.Amount as [Miktar (kg)], TMOKayitlar.Note as [Not],  TMOKayitlar.EvrakKayitNo as [Evrak Kayıt No], Cks.Id as [cksId], TMOKayitlar.Donem from TMOKayitlar  inner join Cks on Cks.Id=TMOKayitlar.CksId inner join Ciftciler on Ciftciler.Id=Cks.CiftciId inner join Urun on Urun.Id=TMOKayitlar.ProductId order by cks.DosyaNo desc", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public int Update(TMO Entity)
        {
            try
            {
                command = new SqlCommand("update TMOKayitlar set CksId=@CksId,FirmaId=@FirmaId ,EvrakKayitNo=@EvrakKayitNo, EvrakKayitTarihi=@EvrakKayitTarihi, Note=@Note, FaturaNo=@FaturaNo, FaturaTarihi=@FaturaTarihi,ProductId=@ProductId, Amount=@Amount , KullaniciId=@KullaniciId , CreateTime=@CreateTime, Donem=@Donem where Id=@Id", connect);
               
                command.Parameters.Add("@Id", SqlDbType.Int).Value = Entity.Id;
                command.Parameters.Add("@CksId", SqlDbType.Int).Value = Entity.CksId;
                command.Parameters.Add("@EvrakKayitNo", SqlDbType.NVarChar).Value = Entity.EvrakKayitNo;
                command.Parameters.Add("@EvrakKayitTarihi", SqlDbType.DateTime).Value = Entity.EvrakKayitTarihi;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = Entity.Note;
                command.Parameters.Add("@FirmaId", SqlDbType.Int).Value = Entity.FirmaId;
                command.Parameters.Add("@FaturaNo", SqlDbType.NVarChar).Value = Entity.FaturaNo;
                command.Parameters.Add("@FaturaTarihi", SqlDbType.DateTime).Value = Entity.FaturaTarihi;
                command.Parameters.Add("@ProductId", SqlDbType.Int).Value = Entity.ProductId;
                command.Parameters.Add("@Amount", SqlDbType.NVarChar).Value = Entity.Amount;
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = Entity.KullaniciId;
                command.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = Entity.CreateTime;
                command.Parameters.Add("@Donem", SqlDbType.NVarChar).Value = Entity.Donem;
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
