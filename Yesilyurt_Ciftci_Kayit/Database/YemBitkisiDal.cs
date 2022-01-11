using System;
using System.Data;
using System.Data.SqlClient;
using Yesilyurt_Ciftci_Kayit.Entities;

namespace Yesilyurt_Ciftci_Kayit.Database
{
    public class YemBitkisiDal : BaseDal, IBaseDal<YemBitkisi>
    {
        public int Add(YemBitkisi yemBitkisi)
        {
            try
            {
                command = new SqlCommand("Add_YemBitkileri", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@CksId", SqlDbType.Int).Value = yemBitkisi.CksId;
                command.Parameters.Add("@UrunId", SqlDbType.Int).Value = yemBitkisi.UrunId;
                command.Parameters.Add("@DosyaNo", SqlDbType.Int).Value = yemBitkisi.DosyaNo;
                command.Parameters.Add("@MuracaatTarihi", SqlDbType.DateTime).Value = yemBitkisi.MuracaatTarihi;
                command.Parameters.Add("@EkilisYili", SqlDbType.NVarChar).Value = yemBitkisi.EkilisYili;
                command.Parameters.Add("@AraziMahalle", SqlDbType.NVarChar).Value = yemBitkisi.AraziMahalle;
                command.Parameters.Add("@Ada", SqlDbType.NVarChar).Value = yemBitkisi.Ada;
                command.Parameters.Add("@Parsel", SqlDbType.NVarChar).Value = yemBitkisi.Parsel;
                command.Parameters.Add("@MuracaatAlani", SqlDbType.NVarChar).Value = yemBitkisi.MuracaatAlani;
                command.Parameters.Add("@TespitEdilenAlan", SqlDbType.NVarChar).Value = yemBitkisi.TespitEdilenAlan;
                command.Parameters.Add("@KontrolTarihi", SqlDbType.NVarChar).Value = yemBitkisi.KontrolTarihi==null ? "" : yemBitkisi.KontrolTarihi;
                command.Parameters.Add("@KontrolEdenler", SqlDbType.NVarChar).Value = yemBitkisi.KontrolEdenler==null ?"":yemBitkisi.KontrolEdenler;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = yemBitkisi.Note;
                command.Parameters.Add("@KontrolDurumu", SqlDbType.NVarChar).Value = yemBitkisi.KontrolDurumu;
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = yemBitkisi.KullaniciId;



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

        public int Delete(YemBitkisi yemBitkisi)
        {
            try
            {
                command = new SqlCommand("Delete_YemBitkileri", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = yemBitkisi.Id;

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
            command = new SqlCommand("GetAll_YemBitkileri", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_YemBitkisiDataGrid()
        {
            command = new SqlCommand("GetAll_YemBitkisiDataGrid", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_YemBitkileri_ForPrint()
        {
            command = new SqlCommand("GetAll_YemBitkileri_ForPrint", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();
        }

        public int Update(YemBitkisi yemBitkisi)
        {
            try
            {
                command = new SqlCommand("Update_YemBitkileri", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = yemBitkisi.Id;
                command.Parameters.Add("@CksId", SqlDbType.Int).Value = yemBitkisi.CksId;
                command.Parameters.Add("@UrunId", SqlDbType.Int).Value = yemBitkisi.UrunId;
                command.Parameters.Add("@DosyaNo", SqlDbType.Int).Value = yemBitkisi.DosyaNo;
                command.Parameters.Add("@MuracaatTarihi", SqlDbType.Date).Value = yemBitkisi.MuracaatTarihi;
                command.Parameters.Add("@EkilisYili", SqlDbType.NVarChar).Value = yemBitkisi.EkilisYili;
                command.Parameters.Add("@AraziMahalle", SqlDbType.NVarChar).Value = yemBitkisi.AraziMahalle;
                command.Parameters.Add("@Ada", SqlDbType.NVarChar).Value = yemBitkisi.Ada;
                command.Parameters.Add("@Parsel", SqlDbType.NVarChar).Value = yemBitkisi.Parsel;
                command.Parameters.Add("@MuracaatAlani", SqlDbType.Decimal).Value = yemBitkisi.MuracaatAlani;
                command.Parameters.Add("@TespitEdilenAlan", SqlDbType.Decimal).Value = yemBitkisi.TespitEdilenAlan;
                command.Parameters.Add("@KontrolTarihi", SqlDbType.NVarChar).Value = yemBitkisi.KontrolTarihi;
                command.Parameters.Add("@KontrolEdenler", SqlDbType.NVarChar).Value = yemBitkisi.KontrolEdenler;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = yemBitkisi.Note;
                command.Parameters.Add("@KontrolDurumu", SqlDbType.NVarChar).Value = yemBitkisi.KontrolDurumu;
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = yemBitkisi.KullaniciId;
                command.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Now;

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
