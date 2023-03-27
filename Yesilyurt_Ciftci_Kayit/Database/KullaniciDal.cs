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
                command = new SqlCommand("Add_Kullanici", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
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
                command = new SqlCommand("Delete_Kullanici", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
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
            command = new SqlCommand("GetAll_Kullanici", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_KullaniciDataGrid()
        {
            command = new SqlCommand("GetAll_KullaniciDataGrid", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public int Update(Kullanici k)
        {
            try
            {
                command = new SqlCommand("Update_Kullanici", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
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
