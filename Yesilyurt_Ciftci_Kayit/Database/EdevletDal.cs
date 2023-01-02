using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesilyurt_Ciftci_Kayit.Entities;
namespace Yesilyurt_Ciftci_Kayit.Database
{
    public class EdevletDal : BaseDal, IBaseDal<Edevlet>
    {
        public int Add(Edevlet Entity)
        {
            try
            {
                command = new SqlCommand("Add_Edevlet", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@CksId", SqlDbType.Int).Value = Entity.CksId;
                command.Parameters.Add("@DosyaNoEdevlet", SqlDbType.NVarChar).Value = Entity.DosyaNoEdevlet;
                
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = Entity.KullaniciId;
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
        public int Delete(Edevlet Entity)
        {
            result = 0;
            try
            {
                command = new SqlCommand("Delete_Edevlet", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
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
            command = new SqlCommand("GetAll_Edevlet", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public int Update(Edevlet Entity)
        {
            try
            {
              
                command = new SqlCommand("Update_Edevlet", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = Entity.Id;
                command.Parameters.Add("@DosyaNoEdevlet", SqlDbType.NVarChar).Value = Entity.DosyaNoEdevlet;
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = Entity.KullaniciId;
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
