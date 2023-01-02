using System;
using System.Data;
using System.Data.SqlClient;
using Yesilyurt_Ciftci_Kayit.Entities;
namespace Yesilyurt_Ciftci_Kayit.Database
{
    public class KullaniciDal : BaseDal, IBaseDal<Kullanici>
    {
        public int Add(Kullanici k)
        {
            try
            {
                command = new SqlCommand("insert into Kullanici (KullaniciAdi,Parola) values (@KullaniciAdi,@Parola) ", connect);
                command.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = k.KullaniciAdi;
                command.Parameters.Add("@Parola", SqlDbType.NVarChar).Value = k.Parola;
                BaglantiAyarla();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Utilities.Mesaj.MessageBoxError(ex.Message);
            }
            finally
            {
                BaglantiAyarla();
            }
            return result;
        }
        public int Delete(Kullanici k)
        {
            try
            {
                command = new SqlCommand("delete from Kullanici where Id=@Id ", connect);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = k.Id;
                BaglantiAyarla();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
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
            command = new SqlCommand("select * from Kullanici", connect);
            
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_KullaniciDataGrid()
        {
            command = new SqlCommand("select Kullanici.Id,KullaniciAdi from Kullanici", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public int Update(Kullanici k)
        {
            try
            {
                command = new SqlCommand("update Kullanici set KullaniciAdi=@KullaniciAdi, Parola=@Parola , Yetki=@Yetki where Id=@Id ", connect);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = k.Id;
                command.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = k.KullaniciAdi;
                command.Parameters.Add("@Parola", SqlDbType.NVarChar).Value = k.Parola;
                command.Parameters.Add("@Yetki", SqlDbType.NVarChar).Value = k.Yetki;
                BaglantiAyarla();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
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
