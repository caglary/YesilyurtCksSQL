using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Office.Core;
using wordeaktar = Microsoft.Office.Interop.Word;

namespace WordToExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            string sqlConnectinString = @"data source=DESKTOP-HF3B47B\SQLEXPRESS; Initial Catalog=YesilyurtDb2021; Integrated security=true";
            SqlConnection sqlConnection = new SqlConnection(sqlConnectinString);
            List<YemBitkileriPrint> liste = new List<YemBitkileriPrint>();

            try
            {
                BaglantiAyarla(sqlConnection);
                Console.WriteLine("Bağlantı kuruldu");

                SqlCommand command = new SqlCommand("GetAll_YemBitkileri_ForPrint", sqlConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader _reader = command.ExecuteReader();

                while (_reader.Read())
                {
                    liste.Add(new YemBitkileriPrint()
                    {

                        DosyaNo = _reader.IsDBNull(0) ? 0 : _reader.GetInt32(0),
                        TcKimlikNo = _reader.IsDBNull(1) ? "" : _reader.GetString(1),
                        IsimSoyisim = _reader.IsDBNull(2) ? "" : _reader.GetString(2),
                        BasvuruTarih = _reader.IsDBNull(3) ? DateTime.MinValue : _reader.GetDateTime(3),
                        AraziMahalle = _reader.IsDBNull(4) ? "" : _reader.GetString(4),
                        Urun = _reader.IsDBNull(5) ? "" : _reader.GetString(5),
                        Ada = _reader.IsDBNull(6) ? "" : _reader.GetString(6),
                        Parsel = _reader.IsDBNull(7) ? "" : _reader.GetString(7),
                        MuracaatAlani = _reader.IsDBNull(8) ? "" : _reader.GetString(8),
                        KontrolDurumu = _reader.IsDBNull(9) ? "" : _reader.GetString(9),
                        TespitEdilenAlan = _reader.IsDBNull(10) ? "" : _reader.GetString(10)
                    });
                }
                _reader.Close();

                string wordFilePath = @"C:\Users\cagla\Desktop\tutanak\ek.docx";

            basadon:
                

                wordeaktar.Application wordapp = new wordeaktar.Application();
                wordapp.Visible = true;
                wordeaktar.Document worddoc;
                object missing = System.Reflection.Missing.Value;
                object readOnly = false;
                object fileName = wordFilePath; //benim olusturduğum dosya masaüstünde diye konumunu belirttim

                //+Word dosyamızı açıyoruz.
                worddoc = wordapp.Documents.Open(ref fileName, ref missing, ref readOnly, ref readOnly,
                ref missing, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing);

                //Aktif sayfayı açıyoruz.
                worddoc.Activate();
                liste.OrderBy(I => I.IsimSoyisim).ToList();

                string name = liste[0].IsimSoyisim; 
            koleksiyonDegisti:
                liste.OrderBy(I => I.IsimSoyisim).ToList();
                
                foreach (var item in liste)
                {
                    string filePath = name;
                    if (name == item.IsimSoyisim)
                    {
                        //+Bookmarks işlemleri
                        //Word dosyamızda ki bookmark adını yazıyoruz.
                        object bookMarks_il = "il"; //wordde belirttiğimiz bookmarks isimlerini yazıyoruz
                                                    //ilgili bookmarkı buluyor ve yerine yazmak istediğimiz veriyi yazıyoruz.
                        worddoc.Bookmarks.get_Item(ref bookMarks_il).Range.Text = "TOKAT";

                        liste.Remove(item);
                        goto koleksiyonDegisti;

                    }
                    else
                    {
                        //Kaydedilir ve otomatik olarak çıkılır.
                        //Dosya kaydedilir.
                        //worddoc.SaveAs(name + ".doc");
                        
                        worddoc.SaveAs2(filePath);
                        //Dosya kapatılır.
                        worddoc.Close(ref missing, ref missing, ref missing);
                        worddoc = null;
                        //Word uygulaması kapatılır
                        wordapp.Quit(ref missing, ref missing, ref missing);
                        wordapp = null;
                        goto basadon;
                    }


                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                BaglantiAyarla(sqlConnection);
            }

            Console.Read();
        }
        static void BaglantiAyarla(SqlConnection connect)
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
            else
                connect.Close();
        }


    }

    internal class YemBitkileriPrint
    {
        public int DosyaNo { get; set; }
        public string TcKimlikNo { get; set; }
        public string IsimSoyisim { get; set; }
        public DateTime BasvuruTarih { get; set; }
        public string AraziMahalle { get; set; }
        public string Urun { get; set; }
        public string Ada { get; set; }
        public string Parsel { get; set; }
        public string MuracaatAlani { get; set; }
        public string KontrolDurumu { get; set; }
        public string TespitEdilenAlan { get; set; }
    }
}
