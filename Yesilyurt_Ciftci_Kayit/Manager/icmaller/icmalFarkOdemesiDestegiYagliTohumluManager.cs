using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Yesilyurt_Ciftci_Kayit.Database.icmaller;
using Yesilyurt_Ciftci_Kayit.Entities.icmaller;

namespace Yesilyurt_Ciftci_Kayit.Manager.icmaller
{
    public class icmalFarkOdemesiDestegiYagliTohumluManager 
    {
        icmalFarkOdemesiDestegiYagliTohumluDal dal;
        SqlDataReader _reader;
        public icmalFarkOdemesiDestegiYagliTohumluManager()
        {
            dal=new icmalFarkOdemesiDestegiYagliTohumluDal();
        }
        public List<icmalFarkOdemesiYagliTohumlu> GetAll(string kimlikNo)
        {
            List<icmalFarkOdemesiYagliTohumlu> list= new List<icmalFarkOdemesiYagliTohumlu>();
            try
            {
                _reader = dal.GetAll(kimlikNo);
                while (_reader.Read())
                {
                    list.Add(new icmalFarkOdemesiYagliTohumlu()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        KimlikNo = _reader.IsDBNull(1) ? "" : _reader.GetString(1),
                        Urun = _reader.IsDBNull(3) ? "" : _reader.GetString(2),
                        DestegeTabiAlan = _reader.IsDBNull(3) ? 0 : _reader.GetDecimal(3),
                        UretimMiktari = _reader.IsDBNull(4) ? 0 : _reader.GetDecimal(4),
                        SatisMiktari = _reader.IsDBNull(5) ? 0 : _reader.GetDecimal(5),
                        DestegeTabiMiktar = _reader.IsDBNull(6) ? 0 : _reader.GetDecimal(6),
                        DestegeTutari = _reader.IsDBNull(7) ? 0 : _reader.GetDecimal(7),
                      
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
