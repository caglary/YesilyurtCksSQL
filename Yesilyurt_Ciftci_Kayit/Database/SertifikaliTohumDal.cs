using System;
using System.Data;
using System.Data.SqlClient;
using Yesilyurt_Ciftci_Kayit.Entities;

namespace Yesilyurt_Ciftci_Kayit.Database
{
    public class SertifikaliTohumDal : BaseDal, IBaseDal<SertifikaliTohum>
    {
        public int Add(SertifikaliTohum sertifikaliTohum)
        {
            try
            {
                command = new SqlCommand("Add_SertifikaliTohum", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@CksId", SqlDbType.Int).Value = sertifikaliTohum.CksId;
                command.Parameters.Add("@FirmaId", SqlDbType.Int).Value = sertifikaliTohum.FirmaId;

                command.Parameters.Add("@UrunId", SqlDbType.Int).Value = sertifikaliTohum.UrunId;
                command.Parameters.Add("@DosyaNo", SqlDbType.Int).Value = sertifikaliTohum.DosyaNo;
                command.Parameters.Add("@MuracaatTarihi", SqlDbType.DateTime).Value = sertifikaliTohum.MuracaatTarihi;
                command.Parameters.Add("@SertifikaNo", SqlDbType.NVarChar).Value = sertifikaliTohum.SertifikaNo;
                command.Parameters.Add("@FaturaNo", SqlDbType.NVarChar).Value = sertifikaliTohum.FaturaNo;
                command.Parameters.Add("@FaturaTarihi", SqlDbType.DateTime).Value = sertifikaliTohum.FaturaTarihi;

                command.Parameters.Add("@Miktari", SqlDbType.Decimal).Value = sertifikaliTohum.Miktari;
                command.Parameters.Add("@BirimFiyati", SqlDbType.Decimal).Value = sertifikaliTohum.BirimFiyati;
                command.Parameters.Add("@ToplamMaliyet", SqlDbType.Decimal).Value = sertifikaliTohum.ToplamMaliyet;

                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = sertifikaliTohum.Note;
               
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = sertifikaliTohum.KullaniciId;



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

        public int Delete(SertifikaliTohum sertifikaliTohum)
        {
            try
            {
                command = new SqlCommand("Delete_SertifikaliTohum", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = sertifikaliTohum.Id;

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
            command = new SqlCommand("GetAll_SertifikaliTohum", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_SertifikaliTohumDataGrid()
        {
            command = new SqlCommand("GetAll_SertifikaliTohumDataGrid", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_SertifikaliTohum_ForPrint()
        {
            command = new SqlCommand("GetAll_SertifikaliTohum_ForPrint", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }

        public int Update(SertifikaliTohum sertifikaliTohum)
        {
            try
            {
                command = new SqlCommand("Update_SertifikaliTohum", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = sertifikaliTohum.Id;
                command.Parameters.Add("@CksId", SqlDbType.Int).Value = sertifikaliTohum.CksId;
                command.Parameters.Add("@FirmaId", SqlDbType.Int).Value = sertifikaliTohum.FirmaId;

                command.Parameters.Add("@UrunId", SqlDbType.Int).Value = sertifikaliTohum.UrunId;
                command.Parameters.Add("@DosyaNo", SqlDbType.Int).Value = sertifikaliTohum.DosyaNo;
                command.Parameters.Add("@MuracaatTarihi", SqlDbType.DateTime).Value = sertifikaliTohum.MuracaatTarihi;
                command.Parameters.Add("@SertifikaNo", SqlDbType.NVarChar).Value = sertifikaliTohum.SertifikaNo;
                command.Parameters.Add("@FaturaNo", SqlDbType.NVarChar).Value = sertifikaliTohum.FaturaNo;
                command.Parameters.Add("@FaturaTarihi", SqlDbType.DateTime).Value = sertifikaliTohum.FaturaTarihi;

                command.Parameters.Add("@Miktari", SqlDbType.NVarChar).Value = sertifikaliTohum.Miktari;

                command.Parameters.Add("@BirimFiyati", SqlDbType.NVarChar).Value =sertifikaliTohum.BirimFiyati;
                command.Parameters.Add("@ToplamMaliyet", SqlDbType.NVarChar).Value = sertifikaliTohum.ToplamMaliyet;

                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = sertifikaliTohum.Note;
                command.Parameters.Add("@OdemeDurumu", SqlDbType.NVarChar).Value = sertifikaliTohum.OdemeDurumu;


                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = sertifikaliTohum.KullaniciId;

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
