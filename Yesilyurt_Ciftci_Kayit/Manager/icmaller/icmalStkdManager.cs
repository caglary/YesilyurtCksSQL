using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using Yesilyurt_Ciftci_Kayit.Entities.icmaller;

namespace Yesilyurt_Ciftci_Kayit.Database.icmaller
{
    public class icmalStkdManager
    {
        icmalStkdDal dal;
        SqlDataReader _reader;
        public icmalStkdManager()
        {
            dal=new icmalStkdDal();
        }
        public List<icmalStkd> GetAll(string kimlikNo)
        {
            List<icmalStkd> list = new List<icmalStkd>();
            try
            {
                _reader = dal.GetAll(kimlikNo);
                while (_reader.Read())
                {
                    list.Add(new icmalStkd()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        KimlikNo = _reader.IsDBNull(1) ? "" : _reader.GetString(1),
                        Urun = _reader.IsDBNull(3) ? "" : _reader.GetString(2),
                        FaturaMiktari = _reader.IsDBNull(3) ? 0 : _reader.GetDecimal(3),
                        DesteklemeAlani = _reader.IsDBNull(4) ? 0 : _reader.GetDecimal(4),
                        DesteklemeMiktari = _reader.IsDBNull(5) ? 0 : _reader.GetDecimal(5),
                      


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
