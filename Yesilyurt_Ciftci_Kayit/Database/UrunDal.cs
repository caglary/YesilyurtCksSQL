using System;
using System.Data;
using System.Data.SqlClient;
using Yesilyurt_Ciftci_Kayit.Entities;

namespace Yesilyurt_Ciftci_Kayit.Database
{
    public class UrunDal : BaseDal, IBaseDal<Urun>
    {
        public int Add(Urun urun)
        {
            try
            {
                command = new SqlCommand("Add_Urun", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@UrunAdi", SqlDbType.NVarChar).Value = urun.UrunAdi;
                command.Parameters.Add("@UrunCesidi", SqlDbType.NVarChar).Value = urun.@UrunCesidi;
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = urun.KullaniciId;

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

        public int Delete(Urun urun)
        {
            try
            {
                command = new SqlCommand("Delete_Urun", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = urun.Id;

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
            command = new SqlCommand("GetAll_Urun", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_UrunDataGrid()
        {
            command = new SqlCommand("GetAll_UrunDataGrid", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }

        public int Update(Urun urun)
        {
            try
            {
                command = new SqlCommand("Update_Urun", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = urun.Id;
                command.Parameters.Add("@UrunAdi", SqlDbType.NVarChar).Value = urun.UrunAdi;
                command.Parameters.Add("@UrunCesidi", SqlDbType.NVarChar).Value = urun.UrunCesidi;
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = urun.KullaniciId;

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
