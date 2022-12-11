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
                command = new SqlCommand("Add_TMO_Kayit", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;

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
                command = new SqlCommand("Delete_TMO_Kayit", connect);
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
            command = new SqlCommand("GetAll_TMO_Kayit", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_TMOKayitlar_ForPrint()
        {
            command = new SqlCommand("GetAll_TMOKayitlar_ForPrint", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }

        public int Update(TMO Entity)
        {

            try
            {
                command = new SqlCommand("Update_TMO_Kayit", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
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
