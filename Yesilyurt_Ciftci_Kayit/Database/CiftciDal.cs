using System.Data;
using System.Data.SqlClient;
using Yesilyurt_Ciftci_Kayit.Entities;
namespace Yesilyurt_Ciftci_Kayit.Database
{
    public class CiftciDal : BaseDal, IBaseDal<Ciftci>
    {
        public int Add(Ciftci c)
        {
            try
            {
                command = new SqlCommand("insert into Ciftciler (TcKimlikNo,NameSurname,FatherName,MotherName,Birthday,Gender,MaritalStatus,MobilePhone,HomePhone,Email,City,Town,Village,Note,KullaniciId) values (@TcKimlikNo,@NameSurname,@FatherName,@MotherName,@Birthday,@Gender,@MaritalStatus,@MobilePhone,@HomePhone,@Email,@City, @Town,@Village,@Note,@KullaniciId)", connect);
               
                command.Parameters.Add("@TcKimlikNo", SqlDbType.NVarChar).Value = c.TcKimlikNo;
                command.Parameters.Add("@NameSurname", SqlDbType.NVarChar).Value = c.IsimSoyisim;
                command.Parameters.Add("@FatherName", SqlDbType.NVarChar).Value = c.BabaAdi;
                command.Parameters.Add("@MotherName", SqlDbType.NVarChar).Value = c.AnneAdi;
                command.Parameters.Add("@Birthday", SqlDbType.NVarChar).Value = c.DogumTarihi;
                command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = c.Cinsiyet;
                command.Parameters.Add("@MaritalStatus", SqlDbType.NVarChar).Value = c.MedeniDurum;
                command.Parameters.Add("@MobilePhone", SqlDbType.NVarChar).Value = c.CepTelefonu;
                command.Parameters.Add("@HomePhone", SqlDbType.NVarChar).Value = c.EvTelefonu;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = c.Email;
                command.Parameters.Add("@City", SqlDbType.NVarChar).Value = c.Il;
                command.Parameters.Add("@Town", SqlDbType.NVarChar).Value = c.Ilce;
                command.Parameters.Add("@Village", SqlDbType.NVarChar).Value = c.MahalleKoy;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = c.Not;
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = c.KullaniciId;
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
        public int Delete(Ciftci c)
        {
            result = 0;
            try
            {
                command = new SqlCommand("delete from Ciftciler where Id=@Id", connect);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = c.Id;
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
            command = new SqlCommand("select * from Ciftciler order by CreateTime desc", connect);
           
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll_CiftciDataGrid()
        {
            command = new SqlCommand("select Ciftciler.Id, TcKimlikNo,NameSurname,FatherName,MotherName,Village,CreateTime from Ciftciler order by CreateTime desc", connect);
            
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public int Update(Ciftci c)
        {
            try
            {
                command = new SqlCommand(" update Ciftciler set TcKimlikNo=@TcKimlikNo,NameSurname=@NameSurname,FatherName=@FatherName,MotherName=@MotherName,Birthday=@Birthday,Gender=@Gender,MaritalStatus=@MaritalStatus,MobilePhone=@MobilePhone,HomePhone=@HomePhone,Email=@Email,City=@City,Town=@Town,Village=@Village,Note=@Note,KullaniciId=@KullaniciId where Id=@Id", connect);
               
                command.Parameters.Add("@Id", SqlDbType.Int).Value = c.Id;
                command.Parameters.Add("@TcKimlikNo", SqlDbType.NVarChar).Value = c.TcKimlikNo;
                command.Parameters.Add("@NameSurname", SqlDbType.NVarChar).Value = c.IsimSoyisim;
                command.Parameters.Add("@FatherName", SqlDbType.NVarChar).Value = c.BabaAdi;
                command.Parameters.Add("@MotherName", SqlDbType.NVarChar).Value = c.AnneAdi;
                command.Parameters.Add("@Birthday", SqlDbType.NVarChar).Value = c.DogumTarihi;
                command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = c.Cinsiyet;
                command.Parameters.Add("@MaritalStatus", SqlDbType.NVarChar).Value = c.MedeniDurum;
                command.Parameters.Add("@MobilePhone", SqlDbType.NVarChar).Value = c.CepTelefonu;
                command.Parameters.Add("@HomePhone", SqlDbType.NVarChar).Value = c.EvTelefonu;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = c.Email;
                command.Parameters.Add("@City", SqlDbType.NVarChar).Value = c.Il;
                command.Parameters.Add("@Town", SqlDbType.NVarChar).Value = c.Ilce;
                command.Parameters.Add("@Village", SqlDbType.NVarChar).Value = c.MahalleKoy;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = c.Not;
                command.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = c.KullaniciId;
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
