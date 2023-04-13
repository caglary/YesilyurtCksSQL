using System.Data;
using System.Data.SqlClient;
using Yesilyurt_Ciftci_Kayit.Entities;
namespace Yesilyurt_Ciftci_Kayit.Database
{
    public class icmalFarkOdemesiDal : BaseDal, IBaseDal<FarkOdemesi>
    {
        public int Add(FarkOdemesi farkOdemesi)
        {
            try
            {
                command = new SqlCommand("Add_FarkOdemesi", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
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
                command = new SqlCommand("Delete_FarkOdemesi", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
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
            command = new SqlCommand("GetAll_FarkOdemesi", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_FarkOdemesiDataGrid()
        {
            command = new SqlCommand("GetAll_FarkOdemesiDataGrid", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_FarkOdemesi_ForPrint()
        {
            command = new SqlCommand("GetAll_FarkOdemesi_ForPrint", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public int Update(FarkOdemesi farkOdemesi)
        {
            try
            {
                command = new SqlCommand("Update_FarkOdemesi", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
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
