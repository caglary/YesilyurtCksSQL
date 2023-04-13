using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using Yesilyurt_Ciftci_Kayit.Entities.icmaller;

namespace Yesilyurt_Ciftci_Kayit.Database.icmaller
{
    public class icmalTmoManager
    {
        icmalTmoDal dal;
        SqlDataReader _reader;
        public icmalTmoManager()
        {
            dal= new icmalTmoDal();
        }
        public List<icmalTmo> GetAll(string kimlikNo)
        {
            List<icmalTmo> list = new List<icmalTmo>();
            try
            {
                _reader = dal.GetAll(kimlikNo);
                while (_reader.Read())
                {
                    list.Add(new icmalTmo()
                    {
                        Id = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        KimlikNo = _reader.IsDBNull(1) ? "" : _reader.GetString(1),
                        Urun = _reader.IsDBNull(3) ? "" : _reader.GetString(2),
                        DestegeTabiAlan = _reader.IsDBNull(3) ? 0 : _reader.GetDecimal(3),
                        UretimMiktari = _reader.IsDBNull(4) ? 0 : _reader.GetDecimal(4),
                        SatısMiktari = _reader.IsDBNull(5) ? 0 : _reader.GetDecimal(5),
                        DestegeTabiMiktar = _reader.IsDBNull(6) ? 0 : _reader.GetDecimal(6),
                        DestekTutari = _reader.IsDBNull(7) ? 0 : _reader.GetDecimal(7),



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
