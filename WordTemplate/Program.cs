using Syncfusion.DocIO.DLS;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Yesilyurt_Ciftci_Kayit.Entities.PrintTablo;

namespace WordTemplate
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Yesilyurt_Ciftci_Kayit.Manager.YemBitkisiManager yemManager = new Yesilyurt_Ciftci_Kayit.Manager.YemBitkisiManager();

            var AllOfList = yemManager.GetAll_YemBitkileri_ForPrint();
            

            ciftciInfo ciftci = new ciftciInfo();

            var koyler = new List<string> { "BAHÇEBAŞI", "KARACAÖREN", "GOP", "MERKEZ", "SEKÜCEK", "ÇIKRIK", "ÇERKEZDANİŞMENT", "DAMLALI", "BÜĞET", "ŞEHİTLER", "ÇIRDAK", "KUŞÇU", "KAVUNLUK", "DOĞLACIK", "YAĞMUR", "EKİNLİ", "YENİKÖY", "GÜNDOĞAN", "SİVRİ", "KARAGÖZGÖLLÜALAN", "KARAOLUK", "YÜZÜNCÜYIL", "EVRENPAŞA" };



            ciftci.tc = AllOfList[0].TcKimlikNo;
           
           
            for (int i = 0; i < koyler.Count; i++)
            {
                //herhangi bir köyde bulunan parseller listelenecek
                List<YemBitkileriPrint> filterByKoyMahalleOfAllList = AllOfList.Where(I => I.AraziMahalle == koyler[i]).OrderBy(I => I.IsimSoyisim).ToList();

                //listeyi isme göre sıralayacağız.
                //var siraliListe = filterByKoyMahalleOfAllList.OrderBy(I => I.IsimSoyisim).ToList();

                //isimleri liste halinde arayacağız.
                var listedekiIsimler = filterByKoyMahalleOfAllList.GroupBy(I => I.IsimSoyisim).ToList();


                foreach (var isim in listedekiIsimler)
                {

                    var parseller = filterByKoyMahalleOfAllList.Where(I => I.IsimSoyisim == isim.Key).ToList();


                    //ilk isme ait listedeki  kayda ulaşacağız. 
                    //var üreticiBilgi = filterByKoyMahalleOfAllList.FirstOrDefault(I => I.IsimSoyisim == isim.Key);
                    int parselSayisi = parseller.Count;

                    fieldValues veriler = new fieldValues();
                    veriler.il = "TOKAT";
                    veriler.ilce = "YEŞİLYURT";
                    veriler.tc = parseller[0].TcKimlikNo;
                    veriler.isim = parseller[0].IsimSoyisim;
                    veriler.koy = koyler[i].ToString();

                    if (parselSayisi <= 5)
                    {
                        switch (parselSayisi)
                        {
                            case 1:
                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                break;

                            case 2:
                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[1].Urun;
                                veriler.ada_2 = parseller[1].Ada;
                                veriler.parsel_2 = parseller[1].Parsel;
                                veriler.beyanedilen_2 = parseller[1].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[1].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                break;

                            case 3:
                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[1].Urun;
                                veriler.ada_2 = parseller[1].Ada;
                                veriler.parsel_2 = parseller[1].Parsel;
                                veriler.beyanedilen_2 = parseller[1].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[1].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[2].Urun;
                                veriler.ada_3 = parseller[2].Ada;
                                veriler.parsel_3 = parseller[2].Parsel;
                                veriler.beyanedilen_3 = parseller[2].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[2].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                break;

                            case 4:
                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[1].Urun;
                                veriler.ada_2 = parseller[1].Ada;
                                veriler.parsel_2 = parseller[1].Parsel;
                                veriler.beyanedilen_2 = parseller[1].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[1].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[2].Urun;
                                veriler.ada_3 = parseller[2].Ada;
                                veriler.parsel_3 = parseller[2].Parsel;
                                veriler.beyanedilen_3 = parseller[2].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[2].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[3].Urun;
                                veriler.ada_4 = parseller[3].Ada;
                                veriler.parsel_4 = parseller[3].Parsel;
                                veriler.beyanedilen_4 = parseller[3].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[3].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                break;

                            case 5:
                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[1].Urun;
                                veriler.ada_2 = parseller[1].Ada;
                                veriler.parsel_2 = parseller[1].Parsel;
                                veriler.beyanedilen_2 = parseller[1].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[1].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[2].Urun;
                                veriler.ada_3 = parseller[2].Ada;
                                veriler.parsel_3 = parseller[2].Parsel;
                                veriler.beyanedilen_3 = parseller[2].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[2].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[3].Urun;
                                veriler.ada_4 = parseller[3].Ada;
                                veriler.parsel_4 = parseller[3].Parsel;
                                veriler.beyanedilen_4 = parseller[3].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[3].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[4].Urun;
                                veriler.ada_5 = parseller[4].Ada;
                                veriler.parsel_5 = parseller[4].Parsel;
                                veriler.beyanedilen_5 = parseller[4].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[4].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                break;

                            default:
                                break;
                        }

                        formDoldur(veriler);

                    }
                    else if (parselSayisi > 5 && parselSayisi <= 10)
                    {
                        switch (parselSayisi)
                        {
                            case 6:
                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[1].Urun;
                                veriler.ada_2 = parseller[1].Ada;
                                veriler.parsel_2 = parseller[1].Parsel;
                                veriler.beyanedilen_2 = parseller[1].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[1].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[2].Urun;
                                veriler.ada_3 = parseller[2].Ada;
                                veriler.parsel_3 = parseller[2].Parsel;
                                veriler.beyanedilen_3 = parseller[2].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[2].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[3].Urun;
                                veriler.ada_4 = parseller[3].Ada;
                                veriler.parsel_4 = parseller[3].Parsel;
                                veriler.beyanedilen_4 = parseller[3].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[3].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[4].Urun;
                                veriler.ada_5 = parseller[4].Ada;
                                veriler.parsel_5 = parseller[4].Parsel;
                                veriler.beyanedilen_5 = parseller[4].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[4].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler);

                                veriler.yembitkisi_1 = parseller[5].Urun;
                                veriler.ada_1 = parseller[5].Ada;
                                veriler.parsel_1 = parseller[5].Parsel;
                                veriler.beyanedilen_1 = parseller[5].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[5].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = "";
                                veriler.ada_2 = "";
                                veriler.parsel_2 = "";
                                veriler.beyanedilen_2 = "";
                                veriler.tespitedilen_2 = "";
                                veriler.hasattarihi_2 = "";

                                veriler.yembitkisi_3 = "";
                                veriler.ada_3 = "";
                                veriler.parsel_3 = "";
                                veriler.beyanedilen_3 = "";
                                veriler.tespitedilen_3 = "";
                                veriler.hasattarihi_3 = "";

                                veriler.yembitkisi_4 = "";
                                veriler.ada_4 = "";
                                veriler.parsel_4 = "";
                                veriler.beyanedilen_4 = "";
                                veriler.tespitedilen_4 = "";
                                veriler.hasattarihi_4 = "";

                                veriler.yembitkisi_5 = "";
                                veriler.ada_5 = "";
                                veriler.parsel_5 = "";
                                veriler.beyanedilen_5 = "";
                                veriler.tespitedilen_5 = "";
                                veriler.hasattarihi_5 = "";

                                formDoldur(veriler, "2");



                                break;

                            case 7:

                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[1].Urun;
                                veriler.ada_2 = parseller[1].Ada;
                                veriler.parsel_2 = parseller[1].Parsel;
                                veriler.beyanedilen_2 = parseller[1].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[1].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[2].Urun;
                                veriler.ada_3 = parseller[2].Ada;
                                veriler.parsel_3 = parseller[2].Parsel;
                                veriler.beyanedilen_3 = parseller[2].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[2].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[3].Urun;
                                veriler.ada_4 = parseller[3].Ada;
                                veriler.parsel_4 = parseller[3].Parsel;
                                veriler.beyanedilen_4 = parseller[3].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[3].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[4].Urun;
                                veriler.ada_5 = parseller[4].Ada;
                                veriler.parsel_5 = parseller[4].Parsel;
                                veriler.beyanedilen_5 = parseller[4].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[4].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler);

                                veriler.yembitkisi_1 = parseller[5].Urun;
                                veriler.ada_1 = parseller[5].Ada;
                                veriler.parsel_1 = parseller[5].Parsel;
                                veriler.beyanedilen_1 = parseller[5].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[5].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[6].Urun;
                                veriler.ada_2 = parseller[6].Ada;
                                veriler.parsel_2 = parseller[6].Parsel;
                                veriler.beyanedilen_2 = parseller[6].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[6].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = "";
                                veriler.ada_3 = "";
                                veriler.parsel_3 = "";
                                veriler.beyanedilen_3 = "";
                                veriler.tespitedilen_3 = "";
                                veriler.hasattarihi_3 = "";

                                veriler.yembitkisi_4 = "";
                                veriler.ada_4 = "";
                                veriler.parsel_4 = "";
                                veriler.beyanedilen_4 = "";
                                veriler.tespitedilen_4 = "";
                                veriler.hasattarihi_4 = "";

                                veriler.yembitkisi_5 = "";
                                veriler.ada_5 = "";
                                veriler.parsel_5 = "";
                                veriler.beyanedilen_5 = "";
                                veriler.tespitedilen_5 = "";
                                veriler.hasattarihi_5 = "";

                                formDoldur(veriler, "2");

                                break;

                            case 8:

                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[1].Urun;
                                veriler.ada_2 = parseller[1].Ada;
                                veriler.parsel_2 = parseller[1].Parsel;
                                veriler.beyanedilen_2 = parseller[1].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[1].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[2].Urun;
                                veriler.ada_3 = parseller[2].Ada;
                                veriler.parsel_3 = parseller[2].Parsel;
                                veriler.beyanedilen_3 = parseller[2].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[2].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[3].Urun;
                                veriler.ada_4 = parseller[3].Ada;
                                veriler.parsel_4 = parseller[3].Parsel;
                                veriler.beyanedilen_4 = parseller[3].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[3].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[4].Urun;
                                veriler.ada_5 = parseller[4].Ada;
                                veriler.parsel_5 = parseller[4].Parsel;
                                veriler.beyanedilen_5 = parseller[4].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[4].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler);

                                veriler.yembitkisi_1 = parseller[5].Urun;
                                veriler.ada_1 = parseller[5].Ada;
                                veriler.parsel_1 = parseller[5].Parsel;
                                veriler.beyanedilen_1 = parseller[5].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[5].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[6].Urun;
                                veriler.ada_2 = parseller[6].Ada;
                                veriler.parsel_2 = parseller[6].Parsel;
                                veriler.beyanedilen_2 = parseller[6].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[6].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[7].Urun;
                                veriler.ada_3 = parseller[7].Ada;
                                veriler.parsel_3 = parseller[7].Parsel;
                                veriler.beyanedilen_3 = parseller[7].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[7].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = "";
                                veriler.ada_4 = "";
                                veriler.parsel_4 = "";
                                veriler.beyanedilen_4 = "";
                                veriler.tespitedilen_4 = "";
                                veriler.hasattarihi_4 = "";

                                veriler.yembitkisi_5 = "";
                                veriler.ada_5 = "";
                                veriler.parsel_5 = "";
                                veriler.beyanedilen_5 = "";
                                veriler.tespitedilen_5 = "";
                                veriler.hasattarihi_5 = "";

                                formDoldur(veriler, "2");

                                break;

                            case 9:

                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[1].Urun;
                                veriler.ada_2 = parseller[1].Ada;
                                veriler.parsel_2 = parseller[1].Parsel;
                                veriler.beyanedilen_2 = parseller[1].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[1].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[2].Urun;
                                veriler.ada_3 = parseller[2].Ada;
                                veriler.parsel_3 = parseller[2].Parsel;
                                veriler.beyanedilen_3 = parseller[2].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[2].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[3].Urun;
                                veriler.ada_4 = parseller[3].Ada;
                                veriler.parsel_4 = parseller[3].Parsel;
                                veriler.beyanedilen_4 = parseller[3].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[3].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[4].Urun;
                                veriler.ada_5 = parseller[4].Ada;
                                veriler.parsel_5 = parseller[4].Parsel;
                                veriler.beyanedilen_5 = parseller[4].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[4].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler);

                                veriler.yembitkisi_1 = parseller[5].Urun;
                                veriler.ada_1 = parseller[5].Ada;
                                veriler.parsel_1 = parseller[5].Parsel;
                                veriler.beyanedilen_1 = parseller[5].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[5].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[6].Urun;
                                veriler.ada_2 = parseller[6].Ada;
                                veriler.parsel_2 = parseller[6].Parsel;
                                veriler.beyanedilen_2 = parseller[6].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[6].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[7].Urun;
                                veriler.ada_3 = parseller[7].Ada;
                                veriler.parsel_3 = parseller[7].Parsel;
                                veriler.beyanedilen_3 = parseller[7].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[7].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[8].Urun;
                                veriler.ada_4 = parseller[8].Ada;
                                veriler.parsel_4 = parseller[8].Parsel;
                                veriler.beyanedilen_4 = parseller[8].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[8].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = "";
                                veriler.ada_5 = "";
                                veriler.parsel_5 = "";
                                veriler.beyanedilen_5 = "";
                                veriler.tespitedilen_5 = "";
                                veriler.hasattarihi_5 = "";

                                formDoldur(veriler, "2");

                                break;

                            case 10:

                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[1].Urun;
                                veriler.ada_2 = parseller[1].Ada;
                                veriler.parsel_2 = parseller[1].Parsel;
                                veriler.beyanedilen_2 = parseller[1].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[1].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[2].Urun;
                                veriler.ada_3 = parseller[2].Ada;
                                veriler.parsel_3 = parseller[2].Parsel;
                                veriler.beyanedilen_3 = parseller[2].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[2].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[3].Urun;
                                veriler.ada_4 = parseller[3].Ada;
                                veriler.parsel_4 = parseller[3].Parsel;
                                veriler.beyanedilen_4 = parseller[3].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[3].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[4].Urun;
                                veriler.ada_5 = parseller[4].Ada;
                                veriler.parsel_5 = parseller[4].Parsel;
                                veriler.beyanedilen_5 = parseller[4].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[4].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler);

                                veriler.yembitkisi_1 = parseller[5].Urun;
                                veriler.ada_1 = parseller[5].Ada;
                                veriler.parsel_1 = parseller[5].Parsel;
                                veriler.beyanedilen_1 = parseller[5].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[5].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[6].Urun;
                                veriler.ada_2 = parseller[6].Ada;
                                veriler.parsel_2 = parseller[6].Parsel;
                                veriler.beyanedilen_2 = parseller[6].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[6].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[7].Urun;
                                veriler.ada_3 = parseller[7].Ada;
                                veriler.parsel_3 = parseller[7].Parsel;
                                veriler.beyanedilen_3 = parseller[7].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[7].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[8].Urun;
                                veriler.ada_4 = parseller[8].Ada;
                                veriler.parsel_4 = parseller[8].Parsel;
                                veriler.beyanedilen_4 = parseller[8].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[8].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[9].Urun;
                                veriler.ada_5 = parseller[9].Ada;
                                veriler.parsel_5 = parseller[9].Parsel;
                                veriler.beyanedilen_5 = parseller[9].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[9].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler, "2");

                                break;

                            default:
                                break;
                        }
                    }
                    else if (parselSayisi > 10 && parselSayisi <= 15)
                    {
                        switch (parselSayisi)
                        {



                            case 11:

                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[1].Urun;
                                veriler.ada_2 = parseller[1].Ada;
                                veriler.parsel_2 = parseller[1].Parsel;
                                veriler.beyanedilen_2 = parseller[1].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[1].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[2].Urun;
                                veriler.ada_3 = parseller[2].Ada;
                                veriler.parsel_3 = parseller[2].Parsel;
                                veriler.beyanedilen_3 = parseller[2].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[2].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[3].Urun;
                                veriler.ada_4 = parseller[3].Ada;
                                veriler.parsel_4 = parseller[3].Parsel;
                                veriler.beyanedilen_4 = parseller[3].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[3].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[4].Urun;
                                veriler.ada_5 = parseller[4].Ada;
                                veriler.parsel_5 = parseller[4].Parsel;
                                veriler.beyanedilen_5 = parseller[4].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[4].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler);

                                veriler.yembitkisi_1 = parseller[5].Urun;
                                veriler.ada_1 = parseller[5].Ada;
                                veriler.parsel_1 = parseller[5].Parsel;
                                veriler.beyanedilen_1 = parseller[5].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[5].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[6].Urun;
                                veriler.ada_2 = parseller[6].Ada;
                                veriler.parsel_2 = parseller[6].Parsel;
                                veriler.beyanedilen_2 = parseller[6].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[6].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[7].Urun;
                                veriler.ada_3 = parseller[7].Ada;
                                veriler.parsel_3 = parseller[7].Parsel;
                                veriler.beyanedilen_3 = parseller[7].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[7].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[8].Urun;
                                veriler.ada_4 = parseller[8].Ada;
                                veriler.parsel_4 = parseller[8].Parsel;
                                veriler.beyanedilen_4 = parseller[8].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[8].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[9].Urun;
                                veriler.ada_5 = parseller[9].Ada;
                                veriler.parsel_5 = parseller[9].Parsel;
                                veriler.beyanedilen_5 = parseller[9].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[9].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler, "2");

                                veriler.yembitkisi_1 = parseller[10].Urun;
                                veriler.ada_1 = parseller[10].Ada;
                                veriler.parsel_1 = parseller[10].Parsel;
                                veriler.beyanedilen_1 = parseller[10].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[10].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = "";
                                veriler.ada_2 = "";
                                veriler.parsel_2 = "";
                                veriler.beyanedilen_2 = "";
                                veriler.tespitedilen_2 = "";
                                veriler.hasattarihi_2 = "";

                                veriler.yembitkisi_3 = "";
                                veriler.ada_3 = "";
                                veriler.parsel_3 = "";
                                veriler.beyanedilen_3 = "";
                                veriler.tespitedilen_3 = "";
                                veriler.hasattarihi_3 = "";

                                veriler.yembitkisi_4 = "";
                                veriler.ada_4 = "";
                                veriler.parsel_4 = "";
                                veriler.beyanedilen_4 = "";
                                veriler.tespitedilen_4 = "";
                                veriler.hasattarihi_4 = "";

                                veriler.yembitkisi_5 = "";
                                veriler.ada_5 = "";
                                veriler.parsel_5 = "";
                                veriler.beyanedilen_5 = "";
                                veriler.tespitedilen_5 = "";
                                veriler.hasattarihi_5 = "";

                                formDoldur(veriler, "3");

                                break;

                            case 12:

                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[1].Urun;
                                veriler.ada_2 = parseller[1].Ada;
                                veriler.parsel_2 = parseller[1].Parsel;
                                veriler.beyanedilen_2 = parseller[1].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[1].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[2].Urun;
                                veriler.ada_3 = parseller[2].Ada;
                                veriler.parsel_3 = parseller[2].Parsel;
                                veriler.beyanedilen_3 = parseller[2].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[2].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[3].Urun;
                                veriler.ada_4 = parseller[3].Ada;
                                veriler.parsel_4 = parseller[3].Parsel;
                                veriler.beyanedilen_4 = parseller[3].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[3].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[4].Urun;
                                veriler.ada_5 = parseller[4].Ada;
                                veriler.parsel_5 = parseller[4].Parsel;
                                veriler.beyanedilen_5 = parseller[4].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[4].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler);

                                veriler.yembitkisi_1 = parseller[5].Urun;
                                veriler.ada_1 = parseller[5].Ada;
                                veriler.parsel_1 = parseller[5].Parsel;
                                veriler.beyanedilen_1 = parseller[5].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[5].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[6].Urun;
                                veriler.ada_2 = parseller[6].Ada;
                                veriler.parsel_2 = parseller[6].Parsel;
                                veriler.beyanedilen_2 = parseller[6].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[6].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[7].Urun;
                                veriler.ada_3 = parseller[7].Ada;
                                veriler.parsel_3 = parseller[7].Parsel;
                                veriler.beyanedilen_3 = parseller[7].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[7].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[8].Urun;
                                veriler.ada_4 = parseller[8].Ada;
                                veriler.parsel_4 = parseller[8].Parsel;
                                veriler.beyanedilen_4 = parseller[8].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[8].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[9].Urun;
                                veriler.ada_5 = parseller[9].Ada;
                                veriler.parsel_5 = parseller[9].Parsel;
                                veriler.beyanedilen_5 = parseller[9].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[9].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler, "2");

                                veriler.yembitkisi_1 = parseller[10].Urun;
                                veriler.ada_1 = parseller[10].Ada;
                                veriler.parsel_1 = parseller[10].Parsel;
                                veriler.beyanedilen_1 = parseller[10].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[10].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[11].Urun;
                                veriler.ada_2 = parseller[11].Ada;
                                veriler.parsel_2 = parseller[11].Parsel;
                                veriler.beyanedilen_2 = parseller[11].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[11].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = "";
                                veriler.ada_3 = "";
                                veriler.parsel_3 = "";
                                veriler.beyanedilen_3 = "";
                                veriler.tespitedilen_3 = "";
                                veriler.hasattarihi_3 = "";

                                veriler.yembitkisi_4 = "";
                                veriler.ada_4 = "";
                                veriler.parsel_4 = "";
                                veriler.beyanedilen_4 = "";
                                veriler.tespitedilen_4 = "";
                                veriler.hasattarihi_4 = "";

                                veriler.yembitkisi_5 = "";
                                veriler.ada_5 = "";
                                veriler.parsel_5 = "";
                                veriler.beyanedilen_5 = "";
                                veriler.tespitedilen_5 = "";
                                veriler.hasattarihi_5 = "";

                                formDoldur(veriler, "3");

                                break;


                            case 13:

                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[1].Urun;
                                veriler.ada_2 = parseller[1].Ada;
                                veriler.parsel_2 = parseller[1].Parsel;
                                veriler.beyanedilen_2 = parseller[1].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[1].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[2].Urun;
                                veriler.ada_3 = parseller[2].Ada;
                                veriler.parsel_3 = parseller[2].Parsel;
                                veriler.beyanedilen_3 = parseller[2].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[2].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[3].Urun;
                                veriler.ada_4 = parseller[3].Ada;
                                veriler.parsel_4 = parseller[3].Parsel;
                                veriler.beyanedilen_4 = parseller[3].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[3].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[4].Urun;
                                veriler.ada_5 = parseller[4].Ada;
                                veriler.parsel_5 = parseller[4].Parsel;
                                veriler.beyanedilen_5 = parseller[4].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[4].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler);

                                veriler.yembitkisi_1 = parseller[5].Urun;
                                veriler.ada_1 = parseller[5].Ada;
                                veriler.parsel_1 = parseller[5].Parsel;
                                veriler.beyanedilen_1 = parseller[5].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[5].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[6].Urun;
                                veriler.ada_2 = parseller[6].Ada;
                                veriler.parsel_2 = parseller[6].Parsel;
                                veriler.beyanedilen_2 = parseller[6].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[6].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[7].Urun;
                                veriler.ada_3 = parseller[7].Ada;
                                veriler.parsel_3 = parseller[7].Parsel;
                                veriler.beyanedilen_3 = parseller[7].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[7].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[8].Urun;
                                veriler.ada_4 = parseller[8].Ada;
                                veriler.parsel_4 = parseller[8].Parsel;
                                veriler.beyanedilen_4 = parseller[8].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[8].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[9].Urun;
                                veriler.ada_5 = parseller[9].Ada;
                                veriler.parsel_5 = parseller[9].Parsel;
                                veriler.beyanedilen_5 = parseller[9].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[9].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler, "2");

                                veriler.yembitkisi_1 = parseller[10].Urun;
                                veriler.ada_1 = parseller[10].Ada;
                                veriler.parsel_1 = parseller[10].Parsel;
                                veriler.beyanedilen_1 = parseller[10].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[10].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[11].Urun;
                                veriler.ada_2 = parseller[11].Ada;
                                veriler.parsel_2 = parseller[11].Parsel;
                                veriler.beyanedilen_2 = parseller[11].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[11].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[12].Urun;
                                veriler.ada_3 = parseller[12].Ada;
                                veriler.parsel_3 = parseller[12].Parsel;
                                veriler.beyanedilen_3 = parseller[12].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[12].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = "";
                                veriler.ada_4 = "";
                                veriler.parsel_4 = "";
                                veriler.beyanedilen_4 = "";
                                veriler.tespitedilen_4 = "";
                                veriler.hasattarihi_4 = "";

                                veriler.yembitkisi_5 = "";
                                veriler.ada_5 = "";
                                veriler.parsel_5 = "";
                                veriler.beyanedilen_5 = "";
                                veriler.tespitedilen_5 = "";
                                veriler.hasattarihi_5 = "";

                                formDoldur(veriler, "3");

                                break;

                            case 14:

                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[1].Urun;
                                veriler.ada_2 = parseller[1].Ada;
                                veriler.parsel_2 = parseller[1].Parsel;
                                veriler.beyanedilen_2 = parseller[1].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[1].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[2].Urun;
                                veriler.ada_3 = parseller[2].Ada;
                                veriler.parsel_3 = parseller[2].Parsel;
                                veriler.beyanedilen_3 = parseller[2].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[2].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[3].Urun;
                                veriler.ada_4 = parseller[3].Ada;
                                veriler.parsel_4 = parseller[3].Parsel;
                                veriler.beyanedilen_4 = parseller[3].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[3].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[4].Urun;
                                veriler.ada_5 = parseller[4].Ada;
                                veriler.parsel_5 = parseller[4].Parsel;
                                veriler.beyanedilen_5 = parseller[4].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[4].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler);

                                veriler.yembitkisi_1 = parseller[5].Urun;
                                veriler.ada_1 = parseller[5].Ada;
                                veriler.parsel_1 = parseller[5].Parsel;
                                veriler.beyanedilen_1 = parseller[5].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[5].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[6].Urun;
                                veriler.ada_2 = parseller[6].Ada;
                                veriler.parsel_2 = parseller[6].Parsel;
                                veriler.beyanedilen_2 = parseller[6].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[6].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[7].Urun;
                                veriler.ada_3 = parseller[7].Ada;
                                veriler.parsel_3 = parseller[7].Parsel;
                                veriler.beyanedilen_3 = parseller[7].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[7].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[8].Urun;
                                veriler.ada_4 = parseller[8].Ada;
                                veriler.parsel_4 = parseller[8].Parsel;
                                veriler.beyanedilen_4 = parseller[8].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[8].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[9].Urun;
                                veriler.ada_5 = parseller[9].Ada;
                                veriler.parsel_5 = parseller[9].Parsel;
                                veriler.beyanedilen_5 = parseller[9].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[9].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler, "2");

                                veriler.yembitkisi_1 = parseller[10].Urun;
                                veriler.ada_1 = parseller[10].Ada;
                                veriler.parsel_1 = parseller[10].Parsel;
                                veriler.beyanedilen_1 = parseller[10].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[10].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[11].Urun;
                                veriler.ada_2 = parseller[11].Ada;
                                veriler.parsel_2 = parseller[11].Parsel;
                                veriler.beyanedilen_2 = parseller[11].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[11].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[12].Urun;
                                veriler.ada_3 = parseller[12].Ada;
                                veriler.parsel_3 = parseller[12].Parsel;
                                veriler.beyanedilen_3 = parseller[12].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[12].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[13].Urun;
                                veriler.ada_4 = parseller[13].Ada;
                                veriler.parsel_4 = parseller[13].Parsel;
                                veriler.beyanedilen_4 = parseller[13].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[13].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = "";
                                veriler.ada_5 = "";
                                veriler.parsel_5 = "";
                                veriler.beyanedilen_5 = "";
                                veriler.tespitedilen_5 = "";
                                veriler.hasattarihi_5 = "";

                                formDoldur(veriler, "3");

                                break;

                            case 15:

                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[1].Urun;
                                veriler.ada_2 = parseller[1].Ada;
                                veriler.parsel_2 = parseller[1].Parsel;
                                veriler.beyanedilen_2 = parseller[1].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[1].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[2].Urun;
                                veriler.ada_3 = parseller[2].Ada;
                                veriler.parsel_3 = parseller[2].Parsel;
                                veriler.beyanedilen_3 = parseller[2].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[2].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[3].Urun;
                                veriler.ada_4 = parseller[3].Ada;
                                veriler.parsel_4 = parseller[3].Parsel;
                                veriler.beyanedilen_4 = parseller[3].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[3].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[4].Urun;
                                veriler.ada_5 = parseller[4].Ada;
                                veriler.parsel_5 = parseller[4].Parsel;
                                veriler.beyanedilen_5 = parseller[4].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[4].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler);

                                veriler.yembitkisi_1 = parseller[5].Urun;
                                veriler.ada_1 = parseller[5].Ada;
                                veriler.parsel_1 = parseller[5].Parsel;
                                veriler.beyanedilen_1 = parseller[5].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[5].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[6].Urun;
                                veriler.ada_2 = parseller[6].Ada;
                                veriler.parsel_2 = parseller[6].Parsel;
                                veriler.beyanedilen_2 = parseller[6].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[6].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[7].Urun;
                                veriler.ada_3 = parseller[7].Ada;
                                veriler.parsel_3 = parseller[7].Parsel;
                                veriler.beyanedilen_3 = parseller[7].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[7].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[8].Urun;
                                veriler.ada_4 = parseller[8].Ada;
                                veriler.parsel_4 = parseller[8].Parsel;
                                veriler.beyanedilen_4 = parseller[8].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[8].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[9].Urun;
                                veriler.ada_5 = parseller[9].Ada;
                                veriler.parsel_5 = parseller[9].Parsel;
                                veriler.beyanedilen_5 = parseller[9].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[9].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler, "2");

                                veriler.yembitkisi_1 = parseller[10].Urun;
                                veriler.ada_1 = parseller[10].Ada;
                                veriler.parsel_1 = parseller[10].Parsel;
                                veriler.beyanedilen_1 = parseller[10].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[10].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[11].Urun;
                                veriler.ada_2 = parseller[11].Ada;
                                veriler.parsel_2 = parseller[11].Parsel;
                                veriler.beyanedilen_2 = parseller[11].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[11].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[12].Urun;
                                veriler.ada_3 = parseller[12].Ada;
                                veriler.parsel_3 = parseller[12].Parsel;
                                veriler.beyanedilen_3 = parseller[12].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[12].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[13].Urun;
                                veriler.ada_4 = parseller[13].Ada;
                                veriler.parsel_4 = parseller[13].Parsel;
                                veriler.beyanedilen_4 = parseller[13].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[13].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[14].Urun;
                                veriler.ada_5 = parseller[14].Ada;
                                veriler.parsel_5 = parseller[14].Parsel;
                                veriler.beyanedilen_5 = parseller[14].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[14].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler, "3");

                                break;


                            default:
                                break;
                        }
                    }
                    else if (parselSayisi > 15 && parselSayisi <= 20)
                    {
                        switch (parselSayisi)
                        {



                            case 16:

                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[1].Urun;
                                veriler.ada_2 = parseller[1].Ada;
                                veriler.parsel_2 = parseller[1].Parsel;
                                veriler.beyanedilen_2 = parseller[1].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[1].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[2].Urun;
                                veriler.ada_3 = parseller[2].Ada;
                                veriler.parsel_3 = parseller[2].Parsel;
                                veriler.beyanedilen_3 = parseller[2].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[2].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[3].Urun;
                                veriler.ada_4 = parseller[3].Ada;
                                veriler.parsel_4 = parseller[3].Parsel;
                                veriler.beyanedilen_4 = parseller[3].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[3].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[4].Urun;
                                veriler.ada_5 = parseller[4].Ada;
                                veriler.parsel_5 = parseller[4].Parsel;
                                veriler.beyanedilen_5 = parseller[4].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[4].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler);

                                veriler.yembitkisi_1 = parseller[5].Urun;
                                veriler.ada_1 = parseller[5].Ada;
                                veriler.parsel_1 = parseller[5].Parsel;
                                veriler.beyanedilen_1 = parseller[5].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[5].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[6].Urun;
                                veriler.ada_2 = parseller[6].Ada;
                                veriler.parsel_2 = parseller[6].Parsel;
                                veriler.beyanedilen_2 = parseller[6].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[6].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[7].Urun;
                                veriler.ada_3 = parseller[7].Ada;
                                veriler.parsel_3 = parseller[7].Parsel;
                                veriler.beyanedilen_3 = parseller[7].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[7].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[8].Urun;
                                veriler.ada_4 = parseller[8].Ada;
                                veriler.parsel_4 = parseller[8].Parsel;
                                veriler.beyanedilen_4 = parseller[8].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[8].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[9].Urun;
                                veriler.ada_5 = parseller[9].Ada;
                                veriler.parsel_5 = parseller[9].Parsel;
                                veriler.beyanedilen_5 = parseller[9].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[9].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler, "2");

                                veriler.yembitkisi_1 = parseller[10].Urun;
                                veriler.ada_1 = parseller[10].Ada;
                                veriler.parsel_1 = parseller[10].Parsel;
                                veriler.beyanedilen_1 = parseller[10].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[10].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[11].Urun;
                                veriler.ada_2 = parseller[11].Ada;
                                veriler.parsel_2 = parseller[11].Parsel;
                                veriler.beyanedilen_2 = parseller[11].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[11].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[12].Urun;
                                veriler.ada_3 = parseller[12].Ada;
                                veriler.parsel_3 = parseller[12].Parsel;
                                veriler.beyanedilen_3 = parseller[12].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[12].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[13].Urun;
                                veriler.ada_4 = parseller[13].Ada;
                                veriler.parsel_4 = parseller[13].Parsel;
                                veriler.beyanedilen_4 = parseller[13].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[13].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[14].Urun;
                                veriler.ada_5 = parseller[14].Ada;
                                veriler.parsel_5 = parseller[14].Parsel;
                                veriler.beyanedilen_5 = parseller[14].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[14].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler, "3");

                                veriler.yembitkisi_1 = parseller[15].Urun;
                                veriler.ada_1 = parseller[15].Ada;
                                veriler.parsel_1 = parseller[15].Parsel;
                                veriler.beyanedilen_1 = parseller[15].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[15].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = "";
                                veriler.ada_2 = "";
                                veriler.parsel_2 = "";
                                veriler.beyanedilen_2 = "";
                                veriler.tespitedilen_2 = "";
                                veriler.hasattarihi_2 = "";

                                veriler.yembitkisi_3 = "";
                                veriler.ada_3 = "";
                                veriler.parsel_3 = "";
                                veriler.beyanedilen_3 = "";
                                veriler.tespitedilen_3 = "";
                                veriler.hasattarihi_3 = "";

                                veriler.yembitkisi_4 = "";
                                veriler.ada_4 = "";
                                veriler.parsel_4 = "";
                                veriler.beyanedilen_4 = "";
                                veriler.tespitedilen_4 = "";
                                veriler.hasattarihi_4 = "";

                                veriler.yembitkisi_5 = "";
                                veriler.ada_5 = "";
                                veriler.parsel_5 = "";
                                veriler.beyanedilen_5 = "";
                                veriler.tespitedilen_5 = "";
                                veriler.hasattarihi_5 = "";

                                formDoldur(veriler, "4");

                                break;

                            case 17:

                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[1].Urun;
                                veriler.ada_2 = parseller[1].Ada;
                                veriler.parsel_2 = parseller[1].Parsel;
                                veriler.beyanedilen_2 = parseller[1].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[1].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[2].Urun;
                                veriler.ada_3 = parseller[2].Ada;
                                veriler.parsel_3 = parseller[2].Parsel;
                                veriler.beyanedilen_3 = parseller[2].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[2].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[3].Urun;
                                veriler.ada_4 = parseller[3].Ada;
                                veriler.parsel_4 = parseller[3].Parsel;
                                veriler.beyanedilen_4 = parseller[3].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[3].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[4].Urun;
                                veriler.ada_5 = parseller[4].Ada;
                                veriler.parsel_5 = parseller[4].Parsel;
                                veriler.beyanedilen_5 = parseller[4].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[4].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler);

                                veriler.yembitkisi_1 = parseller[5].Urun;
                                veriler.ada_1 = parseller[5].Ada;
                                veriler.parsel_1 = parseller[5].Parsel;
                                veriler.beyanedilen_1 = parseller[5].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[5].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[6].Urun;
                                veriler.ada_2 = parseller[6].Ada;
                                veriler.parsel_2 = parseller[6].Parsel;
                                veriler.beyanedilen_2 = parseller[6].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[6].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[7].Urun;
                                veriler.ada_3 = parseller[7].Ada;
                                veriler.parsel_3 = parseller[7].Parsel;
                                veriler.beyanedilen_3 = parseller[7].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[7].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[8].Urun;
                                veriler.ada_4 = parseller[8].Ada;
                                veriler.parsel_4 = parseller[8].Parsel;
                                veriler.beyanedilen_4 = parseller[8].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[8].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[9].Urun;
                                veriler.ada_5 = parseller[9].Ada;
                                veriler.parsel_5 = parseller[9].Parsel;
                                veriler.beyanedilen_5 = parseller[9].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[9].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler, "2");

                                veriler.yembitkisi_1 = parseller[10].Urun;
                                veriler.ada_1 = parseller[10].Ada;
                                veriler.parsel_1 = parseller[10].Parsel;
                                veriler.beyanedilen_1 = parseller[10].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[10].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[11].Urun;
                                veriler.ada_2 = parseller[11].Ada;
                                veriler.parsel_2 = parseller[11].Parsel;
                                veriler.beyanedilen_2 = parseller[11].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[11].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[12].Urun;
                                veriler.ada_3 = parseller[12].Ada;
                                veriler.parsel_3 = parseller[12].Parsel;
                                veriler.beyanedilen_3 = parseller[12].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[12].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[13].Urun;
                                veriler.ada_4 = parseller[13].Ada;
                                veriler.parsel_4 = parseller[13].Parsel;
                                veriler.beyanedilen_4 = parseller[13].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[13].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[14].Urun;
                                veriler.ada_5 = parseller[14].Ada;
                                veriler.parsel_5 = parseller[14].Parsel;
                                veriler.beyanedilen_5 = parseller[14].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[14].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler, "3");

                                veriler.yembitkisi_1 = parseller[15].Urun;
                                veriler.ada_1 = parseller[15].Ada;
                                veriler.parsel_1 = parseller[15].Parsel;
                                veriler.beyanedilen_1 = parseller[15].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[15].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[16].Urun;
                                veriler.ada_2 = parseller[16].Ada;
                                veriler.parsel_2 = parseller[16].Parsel;
                                veriler.beyanedilen_2 = parseller[16].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[16].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = "";
                                veriler.ada_3 = "";
                                veriler.parsel_3 = "";
                                veriler.beyanedilen_3 = "";
                                veriler.tespitedilen_3 = "";
                                veriler.hasattarihi_3 = "";

                                veriler.yembitkisi_4 = "";
                                veriler.ada_4 = "";
                                veriler.parsel_4 = "";
                                veriler.beyanedilen_4 = "";
                                veriler.tespitedilen_4 = "";
                                veriler.hasattarihi_4 = "";

                                veriler.yembitkisi_5 = "";
                                veriler.ada_5 = "";
                                veriler.parsel_5 = "";
                                veriler.beyanedilen_5 = "";
                                veriler.tespitedilen_5 = "";
                                veriler.hasattarihi_5 = "";

                                formDoldur(veriler, "4");

                                break;

                            case 18:

                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[1].Urun;
                                veriler.ada_2 = parseller[1].Ada;
                                veriler.parsel_2 = parseller[1].Parsel;
                                veriler.beyanedilen_2 = parseller[1].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[1].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[2].Urun;
                                veriler.ada_3 = parseller[2].Ada;
                                veriler.parsel_3 = parseller[2].Parsel;
                                veriler.beyanedilen_3 = parseller[2].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[2].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[3].Urun;
                                veriler.ada_4 = parseller[3].Ada;
                                veriler.parsel_4 = parseller[3].Parsel;
                                veriler.beyanedilen_4 = parseller[3].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[3].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[4].Urun;
                                veriler.ada_5 = parseller[4].Ada;
                                veriler.parsel_5 = parseller[4].Parsel;
                                veriler.beyanedilen_5 = parseller[4].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[4].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler);

                                veriler.yembitkisi_1 = parseller[5].Urun;
                                veriler.ada_1 = parseller[5].Ada;
                                veriler.parsel_1 = parseller[5].Parsel;
                                veriler.beyanedilen_1 = parseller[5].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[5].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[6].Urun;
                                veriler.ada_2 = parseller[6].Ada;
                                veriler.parsel_2 = parseller[6].Parsel;
                                veriler.beyanedilen_2 = parseller[6].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[6].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[7].Urun;
                                veriler.ada_3 = parseller[7].Ada;
                                veriler.parsel_3 = parseller[7].Parsel;
                                veriler.beyanedilen_3 = parseller[7].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[7].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[8].Urun;
                                veriler.ada_4 = parseller[8].Ada;
                                veriler.parsel_4 = parseller[8].Parsel;
                                veriler.beyanedilen_4 = parseller[8].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[8].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[9].Urun;
                                veriler.ada_5 = parseller[9].Ada;
                                veriler.parsel_5 = parseller[9].Parsel;
                                veriler.beyanedilen_5 = parseller[9].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[9].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler, "2");

                                veriler.yembitkisi_1 = parseller[10].Urun;
                                veriler.ada_1 = parseller[10].Ada;
                                veriler.parsel_1 = parseller[10].Parsel;
                                veriler.beyanedilen_1 = parseller[10].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[10].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[11].Urun;
                                veriler.ada_2 = parseller[11].Ada;
                                veriler.parsel_2 = parseller[11].Parsel;
                                veriler.beyanedilen_2 = parseller[11].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[11].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[12].Urun;
                                veriler.ada_3 = parseller[12].Ada;
                                veriler.parsel_3 = parseller[12].Parsel;
                                veriler.beyanedilen_3 = parseller[12].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[12].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[13].Urun;
                                veriler.ada_4 = parseller[13].Ada;
                                veriler.parsel_4 = parseller[13].Parsel;
                                veriler.beyanedilen_4 = parseller[13].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[13].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[14].Urun;
                                veriler.ada_5 = parseller[14].Ada;
                                veriler.parsel_5 = parseller[14].Parsel;
                                veriler.beyanedilen_5 = parseller[14].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[14].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler, "3");

                                veriler.yembitkisi_1 = parseller[15].Urun;
                                veriler.ada_1 = parseller[15].Ada;
                                veriler.parsel_1 = parseller[15].Parsel;
                                veriler.beyanedilen_1 = parseller[15].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[15].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[16].Urun;
                                veriler.ada_2 = parseller[16].Ada;
                                veriler.parsel_2 = parseller[16].Parsel;
                                veriler.beyanedilen_2 = parseller[16].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[16].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[17].Urun;
                                veriler.ada_3 = parseller[17].Ada;
                                veriler.parsel_3 = parseller[17].Parsel;
                                veriler.beyanedilen_3 = parseller[17].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[17].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = "";
                                veriler.ada_4 = "";
                                veriler.parsel_4 = "";
                                veriler.beyanedilen_4 = "";
                                veriler.tespitedilen_4 = "";
                                veriler.hasattarihi_4 = "";

                                veriler.yembitkisi_5 = "";
                                veriler.ada_5 = "";
                                veriler.parsel_5 = "";
                                veriler.beyanedilen_5 = "";
                                veriler.tespitedilen_5 = "";
                                veriler.hasattarihi_5 = "";

                                formDoldur(veriler, "4");

                                break;

                            case 19:

                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[1].Urun;
                                veriler.ada_2 = parseller[1].Ada;
                                veriler.parsel_2 = parseller[1].Parsel;
                                veriler.beyanedilen_2 = parseller[1].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[1].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[2].Urun;
                                veriler.ada_3 = parseller[2].Ada;
                                veriler.parsel_3 = parseller[2].Parsel;
                                veriler.beyanedilen_3 = parseller[2].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[2].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[3].Urun;
                                veriler.ada_4 = parseller[3].Ada;
                                veriler.parsel_4 = parseller[3].Parsel;
                                veriler.beyanedilen_4 = parseller[3].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[3].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[4].Urun;
                                veriler.ada_5 = parseller[4].Ada;
                                veriler.parsel_5 = parseller[4].Parsel;
                                veriler.beyanedilen_5 = parseller[4].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[4].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler);

                                veriler.yembitkisi_1 = parseller[5].Urun;
                                veriler.ada_1 = parseller[5].Ada;
                                veriler.parsel_1 = parseller[5].Parsel;
                                veriler.beyanedilen_1 = parseller[5].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[5].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[6].Urun;
                                veriler.ada_2 = parseller[6].Ada;
                                veriler.parsel_2 = parseller[6].Parsel;
                                veriler.beyanedilen_2 = parseller[6].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[6].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[7].Urun;
                                veriler.ada_3 = parseller[7].Ada;
                                veriler.parsel_3 = parseller[7].Parsel;
                                veriler.beyanedilen_3 = parseller[7].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[7].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[8].Urun;
                                veriler.ada_4 = parseller[8].Ada;
                                veriler.parsel_4 = parseller[8].Parsel;
                                veriler.beyanedilen_4 = parseller[8].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[8].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[9].Urun;
                                veriler.ada_5 = parseller[9].Ada;
                                veriler.parsel_5 = parseller[9].Parsel;
                                veriler.beyanedilen_5 = parseller[9].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[9].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler, "2");

                                veriler.yembitkisi_1 = parseller[10].Urun;
                                veriler.ada_1 = parseller[10].Ada;
                                veriler.parsel_1 = parseller[10].Parsel;
                                veriler.beyanedilen_1 = parseller[10].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[10].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[11].Urun;
                                veriler.ada_2 = parseller[11].Ada;
                                veriler.parsel_2 = parseller[11].Parsel;
                                veriler.beyanedilen_2 = parseller[11].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[11].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[12].Urun;
                                veriler.ada_3 = parseller[12].Ada;
                                veriler.parsel_3 = parseller[12].Parsel;
                                veriler.beyanedilen_3 = parseller[12].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[12].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[13].Urun;
                                veriler.ada_4 = parseller[13].Ada;
                                veriler.parsel_4 = parseller[13].Parsel;
                                veriler.beyanedilen_4 = parseller[13].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[13].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[14].Urun;
                                veriler.ada_5 = parseller[14].Ada;
                                veriler.parsel_5 = parseller[14].Parsel;
                                veriler.beyanedilen_5 = parseller[14].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[14].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler, "3");

                                veriler.yembitkisi_1 = parseller[15].Urun;
                                veriler.ada_1 = parseller[15].Ada;
                                veriler.parsel_1 = parseller[15].Parsel;
                                veriler.beyanedilen_1 = parseller[15].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[15].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[16].Urun;
                                veriler.ada_2 = parseller[16].Ada;
                                veriler.parsel_2 = parseller[16].Parsel;
                                veriler.beyanedilen_2 = parseller[16].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[16].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[17].Urun;
                                veriler.ada_3 = parseller[17].Ada;
                                veriler.parsel_3 = parseller[17].Parsel;
                                veriler.beyanedilen_3 = parseller[17].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[17].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[18].Urun;
                                veriler.ada_4 = parseller[18].Ada;
                                veriler.parsel_4 = parseller[18].Parsel;
                                veriler.beyanedilen_4 = parseller[18].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[18].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = "";
                                veriler.ada_5 = "";
                                veriler.parsel_5 = "";
                                veriler.beyanedilen_5 = "";
                                veriler.tespitedilen_5 = "";
                                veriler.hasattarihi_5 = "";

                                formDoldur(veriler, "4");

                                break;

                            case 20:

                                veriler.yembitkisi_1 = parseller[0].Urun;
                                veriler.ada_1 = parseller[0].Ada;
                                veriler.parsel_1 = parseller[0].Parsel;
                                veriler.beyanedilen_1 = parseller[0].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[0].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[1].Urun;
                                veriler.ada_2 = parseller[1].Ada;
                                veriler.parsel_2 = parseller[1].Parsel;
                                veriler.beyanedilen_2 = parseller[1].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[1].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[2].Urun;
                                veriler.ada_3 = parseller[2].Ada;
                                veriler.parsel_3 = parseller[2].Parsel;
                                veriler.beyanedilen_3 = parseller[2].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[2].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[3].Urun;
                                veriler.ada_4 = parseller[3].Ada;
                                veriler.parsel_4 = parseller[3].Parsel;
                                veriler.beyanedilen_4 = parseller[3].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[3].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[4].Urun;
                                veriler.ada_5 = parseller[4].Ada;
                                veriler.parsel_5 = parseller[4].Parsel;
                                veriler.beyanedilen_5 = parseller[4].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[4].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler);

                                veriler.yembitkisi_1 = parseller[5].Urun;
                                veriler.ada_1 = parseller[5].Ada;
                                veriler.parsel_1 = parseller[5].Parsel;
                                veriler.beyanedilen_1 = parseller[5].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[5].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[6].Urun;
                                veriler.ada_2 = parseller[6].Ada;
                                veriler.parsel_2 = parseller[6].Parsel;
                                veriler.beyanedilen_2 = parseller[6].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[6].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[7].Urun;
                                veriler.ada_3 = parseller[7].Ada;
                                veriler.parsel_3 = parseller[7].Parsel;
                                veriler.beyanedilen_3 = parseller[7].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[7].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[8].Urun;
                                veriler.ada_4 = parseller[8].Ada;
                                veriler.parsel_4 = parseller[8].Parsel;
                                veriler.beyanedilen_4 = parseller[8].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[8].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[9].Urun;
                                veriler.ada_5 = parseller[9].Ada;
                                veriler.parsel_5 = parseller[9].Parsel;
                                veriler.beyanedilen_5 = parseller[9].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[9].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler, "2");

                                veriler.yembitkisi_1 = parseller[10].Urun;
                                veriler.ada_1 = parseller[10].Ada;
                                veriler.parsel_1 = parseller[10].Parsel;
                                veriler.beyanedilen_1 = parseller[10].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[10].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[11].Urun;
                                veriler.ada_2 = parseller[11].Ada;
                                veriler.parsel_2 = parseller[11].Parsel;
                                veriler.beyanedilen_2 = parseller[11].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[11].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[12].Urun;
                                veriler.ada_3 = parseller[12].Ada;
                                veriler.parsel_3 = parseller[12].Parsel;
                                veriler.beyanedilen_3 = parseller[12].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[12].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[13].Urun;
                                veriler.ada_4 = parseller[13].Ada;
                                veriler.parsel_4 = parseller[13].Parsel;
                                veriler.beyanedilen_4 = parseller[13].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[13].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[14].Urun;
                                veriler.ada_5 = parseller[14].Ada;
                                veriler.parsel_5 = parseller[14].Parsel;
                                veriler.beyanedilen_5 = parseller[14].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[14].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler, "3");

                                veriler.yembitkisi_1 = parseller[15].Urun;
                                veriler.ada_1 = parseller[15].Ada;
                                veriler.parsel_1 = parseller[15].Parsel;
                                veriler.beyanedilen_1 = parseller[15].MuracaatAlani;
                                veriler.tespitedilen_1 = parseller[15].TespitEdilenAlan;
                                veriler.hasattarihi_1 = "2022";

                                veriler.yembitkisi_2 = parseller[16].Urun;
                                veriler.ada_2 = parseller[16].Ada;
                                veriler.parsel_2 = parseller[16].Parsel;
                                veriler.beyanedilen_2 = parseller[16].MuracaatAlani;
                                veriler.tespitedilen_2 = parseller[16].TespitEdilenAlan;
                                veriler.hasattarihi_2 = "2022";

                                veriler.yembitkisi_3 = parseller[17].Urun;
                                veriler.ada_3 = parseller[17].Ada;
                                veriler.parsel_3 = parseller[17].Parsel;
                                veriler.beyanedilen_3 = parseller[17].MuracaatAlani;
                                veriler.tespitedilen_3 = parseller[17].TespitEdilenAlan;
                                veriler.hasattarihi_3 = "2022";

                                veriler.yembitkisi_4 = parseller[18].Urun;
                                veriler.ada_4 = parseller[18].Ada;
                                veriler.parsel_4 = parseller[18].Parsel;
                                veriler.beyanedilen_4 = parseller[18].MuracaatAlani;
                                veriler.tespitedilen_4 = parseller[18].TespitEdilenAlan;
                                veriler.hasattarihi_4 = "2022";

                                veriler.yembitkisi_5 = parseller[19].Urun;
                                veriler.ada_5 = parseller[19].Ada;
                                veriler.parsel_5 = parseller[19].Parsel;
                                veriler.beyanedilen_5 = parseller[19].MuracaatAlani;
                                veriler.tespitedilen_5 = parseller[19].TespitEdilenAlan;
                                veriler.hasattarihi_5 = "2022";

                                formDoldur(veriler, "4");

                                break;

                            default:
                                break;
                        }
                    }
                    else
                    {
                        System.Console.WriteLine($"Toplam parsel sayısı :{parselSayisi}\n{veriler.isim} için tutanak yazdırılmadı.");
                    }


                }
            }







        }
        static void formDoldur(fieldValues veriler, string kayitsonek = "")
        {
            ////var dosyaYolu = Directory.GetCurrentDirectory + @"\EK-8.docx";
            var currentDirectory = Directory.GetCurrentDirectory();

            var dosyaYolu = $"{Directory.GetCurrentDirectory()}\\EK-10.docx";
            using (WordDocument document = new WordDocument(dosyaYolu))
            {
                if (veriler.yembitkisi_1 == "YULAF") { veriler.aciklama_1 = "UYGUN"; veriler.ekilistarihi_1 = "2022"; }
                else { veriler.aciklama_1 = ""; veriler.ekilistarihi_1 = ""; }

                if (veriler.yembitkisi_2 == "YULAF") { veriler.aciklama_2 = "UYGUN"; veriler.ekilistarihi_2 = "2022"; }
                else { veriler.aciklama_2 = ""; veriler.ekilistarihi_2 = ""; }

                if (veriler.yembitkisi_3 == "YULAF") { veriler.aciklama_3 = "UYGUN"; veriler.ekilistarihi_3 = "2022"; }
                else { veriler.aciklama_3 = ""; veriler.ekilistarihi_3 = ""; }

                if (veriler.yembitkisi_4 == "YULAF") { veriler.aciklama_4 = "UYGUN"; veriler.ekilistarihi_4 = "2022"; }
                else { veriler.aciklama_4 = ""; veriler.ekilistarihi_4 = ""; }

                if (veriler.yembitkisi_5 == "YULAF") { veriler.aciklama_5 = "UYGUN"; veriler.ekilistarihi_5 = "2022"; }
                else { veriler.aciklama_5 = ""; veriler.ekilistarihi_5 = ""; }

                string[] fieldNames = { "il", "ilce", "koy", "isim", "tc",
                    "yembitkisi_1","ada_1","parsel_1","beyanedilen_1","tespitedilen_1","ekilistarihi_1","hasattarihi_1","aciklama_1",
                    "yembitkisi_2","ada_2","parsel_2","beyanedilen_2","tespitedilen_2","ekilistarihi_2","hasattarihi_2","aciklama_2",
                    "yembitkisi_3","ada_3","parsel_3","beyanedilen_3","tespitedilen_3","ekilistarihi_3","hasattarihi_3","aciklama_3",
                    "yembitkisi_4","ada_4","parsel_4","beyanedilen_4","tespitedilen_4","ekilistarihi_4","hasattarihi_4","aciklama_4",
                    "yembitkisi_5","ada_5","parsel_5","beyanedilen_5","tespitedilen_5","ekilistarihi_5","hasattarihi_5","aciklama_5",
 };

                string[] fieldValues = {veriler.il,veriler.ilce,veriler.koy,veriler.isim,veriler.tc,
                    veriler.yembitkisi_1,veriler.ada_1,veriler.parsel_1,veriler.beyanedilen_1,veriler.tespitedilen_1,veriler.ekilistarihi_1,veriler.hasattarihi_1,veriler.aciklama_1,
                    veriler.yembitkisi_2,veriler.ada_2,veriler.parsel_2,veriler.beyanedilen_2,veriler.tespitedilen_2,veriler.ekilistarihi_2,veriler.hasattarihi_2,veriler.aciklama_2,
                    veriler.yembitkisi_3,veriler.ada_3,veriler.parsel_3,veriler.beyanedilen_3,veriler.tespitedilen_3,veriler.ekilistarihi_3,veriler.hasattarihi_3,veriler.aciklama_3,
                    veriler.yembitkisi_4,veriler.ada_4,veriler.parsel_4,veriler.beyanedilen_4,veriler.tespitedilen_4,veriler.ekilistarihi_4,veriler.hasattarihi_4,veriler.aciklama_4,
                    veriler.yembitkisi_5,veriler.ada_5,veriler.parsel_5,veriler.beyanedilen_5,veriler.tespitedilen_5,veriler.ekilistarihi_5,veriler.hasattarihi_5,veriler.aciklama_5,


                };

                //Performs the mail merge
                document.MailMerge.Execute(fieldNames, fieldValues);
                var fileName = currentDirectory + @"\Tutanaklar";
                if (!Directory.Exists(fileName))
                {
                    Directory.CreateDirectory(fileName);
                    
                }
                //Saves the Word document
                
                
                document.Save(@"Tutanaklar\" + veriler.koy + "_" + veriler.isim + " " + kayitsonek + ".docx");
            }
        }

    }
    class ciftciInfo
    {
        public string il { get; set; }
        public string ilce { get; set; }
        public string koy { get; set; }
        public string isim { get; set; }
        public string tc { get; set; }


    }
   
    class fieldValues
    {
        public string il { get; set; }
        public string ilce { get; set; }
        public string koy { get; set; }
        public string isim { get; set; }
        public string tc { get; set; }

        public string yembitkisi_1 { get; set; }
        public string ada_1 { get; set; }
        public string parsel_1 { get; set; }
        public string beyanedilen_1 { get; set; }
        public string tespitedilen_1 { get; set; }
        public string ekilistarihi_1 { get; set; }
        public string hasattarihi_1 { get; set; }
        public string aciklama_1 { get; set; }

        public string yembitkisi_2 { get; set; }
        public string ada_2 { get; set; }
        public string parsel_2 { get; set; }
        public string beyanedilen_2 { get; set; }
        public string tespitedilen_2 { get; set; }
        public string ekilistarihi_2 { get; set; }
        public string hasattarihi_2 { get; set; }
        public string aciklama_2 { get; set; }

        public string yembitkisi_3 { get; set; }
        public string ada_3 { get; set; }
        public string parsel_3 { get; set; }
        public string beyanedilen_3 { get; set; }
        public string tespitedilen_3 { get; set; }
        public string ekilistarihi_3 { get; set; }
        public string hasattarihi_3 { get; set; }
        public string aciklama_3 { get; set; }

        public string yembitkisi_4 { get; set; }
        public string ada_4 { get; set; }
        public string parsel_4 { get; set; }
        public string beyanedilen_4 { get; set; }
        public string tespitedilen_4 { get; set; }
        public string ekilistarihi_4 { get; set; }
        public string hasattarihi_4 { get; set; }
        public string aciklama_4 { get; set; }

        public string yembitkisi_5 { get; set; }
        public string ada_5 { get; set; }
        public string parsel_5 { get; set; }
        public string beyanedilen_5 { get; set; }
        public string tespitedilen_5 { get; set; }
        public string ekilistarihi_5 { get; set; }
        public string hasattarihi_5 { get; set; }
        public string aciklama_5 { get; set; }

    }
}
