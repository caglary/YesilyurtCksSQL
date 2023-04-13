using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Yesilyurt_Ciftci_Kayit.Entities.icmaller;

namespace Yesilyurt_Ciftci_Kayit.Database.icmaller
{
    public class icmalMgdManager
    {
        icmalMgdDal dal;
        SqlDataReader _reader;
        public icmalMgdManager()
        {
            dal= new icmalMgdDal();
        }
        public List<icmalMgd> GetAll(string kimlikNo)
        {
            List<icmalMgd> list = new List<icmalMgd>();
            try
            {
                _reader = dal.GetAll(kimlikNo);
                while (_reader.Read())
                {
                    list.Add(new icmalMgd()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        KimlikNo = _reader.IsDBNull(1) ? "" : _reader.GetString(1),
                        MazotAlani = _reader.IsDBNull(3) ? 0 : _reader.GetDecimal(2),
                        MazotDesteklemeMiktari = _reader.IsDBNull(3) ? 0 : _reader.GetDecimal(3),
                        GubreAlani = _reader.IsDBNull(4) ? 0 : _reader.GetDecimal(4),
                        GubreDesteklemeMiktari = _reader.IsDBNull(5) ? 0 : _reader.GetDecimal(5),
                        ToplamDesteklemeMiktari = _reader.IsDBNull(6) ? 0 : _reader.GetDecimal(6),
                        VergiKesintisi = _reader.IsDBNull(7) ? 0 : _reader.GetDecimal(7),
                        NetOdenecekTutar = _reader.IsDBNull(8) ? 0 : _reader.GetDecimal(8),


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
