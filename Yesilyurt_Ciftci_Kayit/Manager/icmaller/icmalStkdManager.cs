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
                        //siraNo = _reader.IsDBNull(0) ? 0 : _reader.GetFloat(0),
                        //KimlikNo = _reader.IsDBNull(4) ? "" : _reader.GetString(4),
                        //Urun = _reader.IsDBNull(9) ? "" : _reader.GetString(9),
                        //FaturaMiktari = _reader.IsDBNull(10) ? 0 : _reader.GetFloat(10),
                        //DesteklemeAlani = _reader.IsDBNull(11) ? 0 : _reader.GetFloat(11),
                        //DesteklemeMiktari = _reader.IsDBNull(12) ? 0 : _reader.GetFloat(12),
                        DesteklemeMiktari = _reader.GetFloat(12),




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
