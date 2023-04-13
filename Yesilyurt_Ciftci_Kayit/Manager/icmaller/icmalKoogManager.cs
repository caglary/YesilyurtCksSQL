using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Yesilyurt_Ciftci_Kayit.Entities.icmaller;

namespace Yesilyurt_Ciftci_Kayit.Database.icmaller
{
    public class icmalKoogManager
    {
        icmalKoogDal dal;
        SqlDataReader _reader;
        public icmalKoogManager()
        {
            dal= new icmalKoogDal();
        }
        public List<icmalKoog> GetAll(string kimlikNo)
        {
            List<icmalKoog> list = new List<icmalKoog>();
            try
            {
                _reader = dal.GetAll(kimlikNo);
                while (_reader.Read())
                {
                    list.Add(new icmalKoog()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        KimlikNo = _reader.IsDBNull(1) ? "" : _reader.GetString(1),
                        Urun = _reader.IsDBNull(3) ? "" : _reader.GetString(2),
                        KatiOrganikToprakDuzenleyici = _reader.IsDBNull(3) ? 0 : _reader.GetDecimal(3),
                        KatiOrganomineral = _reader.IsDBNull(4) ? 0 : _reader.GetDecimal(4),
                        KaplamaGubre = _reader.IsDBNull(5) ? 0 : _reader.GetDecimal(5),
                        OrganikGubre = _reader.IsDBNull(6) ? 0 : _reader.GetDecimal(6),
                        DestegeTabiAlan = _reader.IsDBNull(7) ? 0 : _reader.GetDecimal(7),
                        DestekTutari = _reader.IsDBNull(8) ? 0 : _reader.GetDecimal(8),


                    }); ; ;
                }
                _reader.Close();
            }
            catch (Exception ex)
            {
                Utilities.Mesaj.MessageBoxError(ex.Message);
            }
            finally
            {
                dal.BaglantiAyarla();
            }



            return list;

        }
    }
}
