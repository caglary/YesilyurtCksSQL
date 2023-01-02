using System.Data;
using System.Data.SqlClient;
using Yesilyurt_Ciftci_Kayit.Entities;
namespace Yesilyurt_Ciftci_Kayit.Database
{
    public class CksListesiDal : BaseDal, IBaseDal<Cks>
    {
        public int Add(Cks cksKaydi)
        {
            result = 0;
            try
            {
                command = new SqlCommand("insert into Cks (CiftciId,DosyaNo,Note,KullaniciId,CreateTime,EvrakKayitNo,HavaleEdilenPersonel,MuracaatYeri) values (@CiftciId,@DosyaNo,@Note,@KullaniciId,@CreateTime,@EvrakKayitNo,@HavaleEdilenPersonel,@MuracaatYeri)", connect);
                command.Parameters.Add("@CiftciId", SqlDbType.Int).Value = cksKaydi.CiftciId;
                command.Parameters.Add("@DosyaNo", SqlDbType.Int).Value = cksKaydi.DosyaNo;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = cksKaydi.Note;
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = cksKaydi.KullaniciId;
                command.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = cksKaydi.CreateTime;
                command.Parameters.Add("@EvrakKayitNo", SqlDbType.NVarChar).Value = cksKaydi.EvrakKayitNo;
                command.Parameters.Add("@HavaleEdilenPersonel", SqlDbType.NVarChar).Value = cksKaydi.HavaleEdilenPersonel;
                command.Parameters.Add("@MuracaatYeri", SqlDbType.NVarChar).Value = cksKaydi.MuracaatYeri;
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
        public int Delete(Cks cksKaydi)
        {
            result = 0;
            try
            {
                command = new SqlCommand("delete from Cks where Id=@Id", connect);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = cksKaydi.Id;
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
            command = new SqlCommand("select *from Cks", connect);
           
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_CksDataGrid()
        {
            command = new SqlCommand("select cks.Id, cks.DosyaNo,Ciftciler.TcKimlikNo, Ciftciler.NameSurname,Ciftciler.FatherName, Ciftciler.MobilePhone,Ciftciler.HomePhone,Ciftciler.Village,cks.Note,Cks.CreateTime,cks.EvrakKayitNo,cks.HavaleEdilenPersonel,cks.MuracaatYeri from Cks full  join Ciftciler on cks.CiftciId=Ciftciler.Id where Cks.DosyaNo is not null", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_CKS_ForPrint()
        {
            command = new SqlCommand("select  cks.DosyaNo,Ciftciler.TcKimlikNo, Ciftciler.NameSurname,Ciftciler.FatherName,Ciftciler.MobilePhone,Ciftciler.HomePhone,Ciftciler.Village,Cks.CreateTime,cks.EvrakKayitNo,cks.HavaleEdilenPersonel,cks.MuracaatYeri from Cks inner  join Ciftciler on cks.CiftciId=Ciftciler.Id order by cks.DosyaNo desc", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public int Update(Cks cksKaydi)
        {
            result = 0;
            try
            {
                command = new SqlCommand("update Cks set CiftciId=@CiftciId,DosyaNo=@DosyaNo,Note=@Note, KullaniciId=@KullaniciId,CreateTime=@CreateTime,EvrakKayitNo=@EvrakKayitNo,HavaleEdilenPersonel=@HavaleEdilenPersonel, MuracaatYeri=@MuracaatYeri where Id=@Id", connect);
                
                command.Parameters.Add("@Id", SqlDbType.Int).Value = cksKaydi.Id;
                command.Parameters.Add("@CiftciId", SqlDbType.NVarChar).Value = cksKaydi.CiftciId;
                command.Parameters.Add("@DosyaNo", SqlDbType.NVarChar).Value = cksKaydi.DosyaNo;
             
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = cksKaydi.Note;
                command.Parameters.Add("@KullaniciId", SqlDbType.NVarChar).Value = cksKaydi.KullaniciId;
                command.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = cksKaydi.CreateTime;
                command.Parameters.Add("@EvrakKayitNo", SqlDbType.NVarChar).Value = cksKaydi.EvrakKayitNo;
                command.Parameters.Add("@HavaleEdilenPersonel", SqlDbType.NVarChar).Value = cksKaydi.HavaleEdilenPersonel;
                command.Parameters.Add("@MuracaatYeri", SqlDbType.NVarChar).Value = cksKaydi.MuracaatYeri;
                BaglantiAyarla();
                result = command.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                if (ex.HResult.ToString() == "-2146232060")
                {
                    Utilities.Mesaj.MessageBoxError("Dosya Numarasına ait kayıt mevcuttur.Dosya No değiştirin ve tekrar deneyin.");
                    return 0;
                }
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
