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
                command = new SqlCommand("Add_Cks", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@CiftciId", SqlDbType.Int).Value = cksKaydi.CiftciId;
                command.Parameters.Add("@DosyaNo", SqlDbType.Int).Value = cksKaydi.DosyaNo;
                //command.Parameters.Add("@KoyMahalle", SqlDbType.NVarChar).Value = cksKaydi.KoyMahalle;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = cksKaydi.Note;
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = cksKaydi.KullaniciId;
                command.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = cksKaydi.CreateTime;
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
                command = new SqlCommand("Delete_Cks", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
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
            command = new SqlCommand("GetAll_Cks", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_CksDataGrid()
        {
            command = new SqlCommand("GetAll_CksDataGrid", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_CKS_ForPrint()
        {
            command = new SqlCommand("GetAll_CKS_ForPrint", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public int Update(Cks cksKaydi)
        {
            result = 0;
            try
            {
                command = new SqlCommand("Update_Cks", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = cksKaydi.Id;
                command.Parameters.Add("@CiftciId", SqlDbType.NVarChar).Value = cksKaydi.CiftciId;
                command.Parameters.Add("@DosyaNo", SqlDbType.NVarChar).Value = cksKaydi.DosyaNo;
                //command.Parameters.Add("@KoyMahalle", SqlDbType.NVarChar).Value = cksKaydi.KoyMahalle;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = cksKaydi.Note;
                command.Parameters.Add("@KullaniciId", SqlDbType.NVarChar).Value = cksKaydi.KullaniciId;
                command.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = cksKaydi.CreateTime;
                
                BaglantiAyarla();
                result = command.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                if (ex.HResult.ToString()== "-2146232060")
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
