using System.Data;
using System.Data.SqlClient;
using Yesilyurt_Ciftci_Kayit.Entities;
namespace Yesilyurt_Ciftci_Kayit.Database
{
    public class FirmaDal : BaseDal, IBaseDal<Firma>
    {
        public int Add(Firma firma)
        {
            try
            {
                command = new SqlCommand("insert into Firma (FirmaAdi,VergiNo,Note,KullaniciId) values (@FirmaAdi,@VergiNo,@Note,@KullaniciId)", connect);
              
                command.Parameters.Add("@FirmaAdi", SqlDbType.NVarChar).Value = firma.FirmaAdi;
                command.Parameters.Add("@VergiNo", SqlDbType.NVarChar).Value = firma.VergiNo;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = firma.Note;
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = firma.KullaniciId;
               
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
        public int Delete(Firma firma)
        {
            try
            {
                command = new SqlCommand("delete from Firma where Id=@Id", connect);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = firma.Id;
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
            command = new SqlCommand("select * from Firma", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_FirmaDataGrid()
        {
            command = new SqlCommand("select Firma.Id, FirmaAdi from Firma", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public int Update(Firma firma)
        {
            try
            {
                command = new SqlCommand("update Firma set FirmaAdi=@FirmaAdi,VergiNo=@VergiNo,Note=@Note,KullaniciId=@KullaniciId where Id=@Id", connect);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = firma.Id;
                command.Parameters.Add("@FirmaAdi", SqlDbType.NVarChar).Value = firma.FirmaAdi;
                command.Parameters.Add("@VergiNo", SqlDbType.NVarChar).Value = firma.VergiNo;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = firma.Note;
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = firma.KullaniciId;
                
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
