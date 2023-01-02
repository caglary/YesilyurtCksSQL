using System;
using System.Collections.Generic;
using Yesilyurt_Ciftci_Kayit.Database;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Manager;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tcGetir();
        }

        static void tcGetir()
        {

            List<MyClass> list = new List<MyClass> {
                new MyClass{ dilekceno="e1987", tc ="33167081346", tarih="1.10.2022 "},
                new MyClass{ dilekceno="e14135", tc ="25784327334", tarih="1.10.2022 "},
                new MyClass{ dilekceno="e27319", tc ="28621851474", tarih="1.10.2022 "},
                new MyClass{ dilekceno="e31747", tc ="65254011868", tarih="2.10.2022 "},
                new MyClass{ dilekceno="e32877", tc ="17963588018", tarih="2.10.2022 "},
                new MyClass{ dilekceno="e34959", tc ="52042452194", tarih="2.10.2022 "},
                new MyClass{ dilekceno="e35015", tc ="51982454176", tarih="2.10.2022 "},
                new MyClass{ dilekceno="e35196", tc ="28874224322", tarih="2.10.2022 "},
                new MyClass{ dilekceno="e38466", tc ="26225312698", tarih="2.10.2022 "},
                new MyClass{ dilekceno="e41618", tc ="13007371158", tarih="2.10.2022 "},
                new MyClass{ dilekceno="e44073", tc ="40528835982", tarih="3.10.2022 "},
                new MyClass{ dilekceno="e46182", tc ="29204213306", tarih="3.10.2022 "},
                new MyClass{ dilekceno="e47651", tc ="29417206270", tarih="3.10.2022 "},
                new MyClass{ dilekceno="e64164", tc ="65422006184", tarih="3.10.2022 "},
                new MyClass{ dilekceno="e68995", tc ="50119516244", tarih="4.10.2022 "},
                new MyClass{ dilekceno="e73008", tc ="34298043654", tarih="4.10.2022 "},
                new MyClass{ dilekceno="e75687", tc ="33086084046", tarih="4.10.2022 "},
                new MyClass{ dilekceno="e78984", tc ="27350275124", tarih="4.10.2022 "},
                new MyClass{ dilekceno="e80221", tc ="17744595372", tarih="4.10.2022 "},
                new MyClass{ dilekceno="e86254", tc ="11369807926", tarih="4.10.2022 "},
                new MyClass{ dilekceno="e90710", tc ="60661164954", tarih="5.10.2022 "},
                new MyClass{ dilekceno="e91792", tc ="24986545508", tarih="5.10.2022 "},
                new MyClass{ dilekceno="e100127", tc ="12200780224", tarih="5.10.2022 "},
                new MyClass{ dilekceno="e104586", tc ="42121782816", tarih="6.10.2022 "},
                new MyClass{ dilekceno="e104930", tc ="42277777698", tarih="6.10.2022 "},
                new MyClass{ dilekceno="e112338", tc ="36568967998", tarih="6.10.2022 "},
                new MyClass{ dilekceno="e118329", tc ="25712329720", tarih="6.10.2022 "},
                new MyClass{ dilekceno="e121653", tc ="10211846632", tarih="7.10.2022 "},
                new MyClass{ dilekceno="e123448", tc ="35096017090", tarih="7.10.2022 "},
                new MyClass{ dilekceno="e125079", tc ="13700730214", tarih="7.10.2022 "},
                new MyClass{ dilekceno="e127038", tc ="17192613864", tarih="7.10.2022 "},
                new MyClass{ dilekceno="e127086", tc ="19034170498", tarih="7.10.2022 "},
                new MyClass{ dilekceno="e128618", tc ="34145048740", tarih="7.10.2022 "},
                new MyClass{ dilekceno="e138515", tc ="46204646798", tarih="8.10.2022 "},
                new MyClass{ dilekceno="e142218", tc ="25028352658", tarih="9.10.2022 "},
                new MyClass{ dilekceno="e142835", tc ="24383374138", tarih="9.10.2022 "},
                new MyClass{ dilekceno="e161114", tc ="18305576724", tarih="10.10.2022"},
                new MyClass{ dilekceno="e168831", tc ="30770161106", tarih="11.10.2022"},
                new MyClass{ dilekceno="e176806", tc ="11585800794", tarih="12.10.2022"},
                new MyClass{ dilekceno="e178560", tc ="29825192660", tarih="12.10.2022"},
                new MyClass{ dilekceno="e186804", tc ="49759528212", tarih="12.10.2022"},
                new MyClass{ dilekceno="e202020", tc ="55834325768", tarih="14.10.2022"},
                new MyClass{ dilekceno="e210022", tc ="29912189764", tarih="14.10.2022"},
                new MyClass{ dilekceno="e213197", tc ="61738129074", tarih="15.10.2022"},
                new MyClass{ dilekceno="e221062", tc ="33482070872", tarih="16.10.2022"},
                new MyClass{ dilekceno="e234187", tc ="33410073258", tarih="18.10.2022"},
                new MyClass{ dilekceno="e237892", tc ="62458104976", tarih="18.10.2022"},
                new MyClass{ dilekceno="e276638", tc ="64288043982", tarih="23.10.2022"},
                new MyClass{ dilekceno="e281030", tc ="20342508712", tarih="24.10.2022"},
                new MyClass{ dilekceno="e294587", tc ="25904514910", tarih="25.10.2022"},
                new MyClass{ dilekceno="e308962", tc ="50344508830", tarih="27.10.2022"},
                new MyClass{ dilekceno="e322998", tc ="33287077366", tarih="30.10.2022"},
                new MyClass{ dilekceno="e332391", tc ="61555135180", tarih="31.10.2022"},
                new MyClass{ dilekceno="e334302", tc ="18968554602", tarih="1.11.2022 "},
                new MyClass{ dilekceno="e335080", tc ="54655365076", tarih="1.11.2022 "},
                new MyClass{ dilekceno="e338110", tc ="25721329438", tarih="1.11.2022 "},
                new MyClass{ dilekceno="e338885", tc ="53386407376", tarih="1.11.2022 "},
                new MyClass{ dilekceno="e338898", tc ="17414606414", tarih="1.11.2022 "},
                new MyClass{ dilekceno="e363898", tc ="64666031440", tarih="6.11.2022 "},
                new MyClass{ dilekceno="e366920", tc ="32495103782", tarih="7.11.2022 "},
                new MyClass{ dilekceno="e372856", tc ="40567834670", tarih="7.11.2022 "},
                new MyClass{ dilekceno="e373318", tc ="19115167720", tarih="8.11.2022 "},
                new MyClass{ dilekceno="e376200", tc ="42127782698", tarih="8.11.2022 "},
                new MyClass{ dilekceno="e378963", tc ="27212279710", tarih="8.11.2022 "},
                new MyClass{ dilekceno="e382013", tc ="47308609962", tarih="9.11.2022 "},
                new MyClass{ dilekceno="e394673", tc ="62560101696", tarih="11.11.2022"},
                new MyClass{ dilekceno="e400434", tc ="21437090310", tarih="13.11.2022"},
                new MyClass{ dilekceno="e412719", tc ="61429139320", tarih="15.11.2022"},
                new MyClass{ dilekceno="e417058", tc ="52159448288", tarih="16.11.2022"},
                new MyClass{ dilekceno="e425130", tc ="21431090538", tarih="18.11.2022"},
                new MyClass{ dilekceno="e428751", tc ="24440372220", tarih="18.11.2022"},
                new MyClass{ dilekceno="e429125", tc ="58666231344", tarih="18.11.2022"},
                new MyClass{ dilekceno="e429961", tc ="56443305448", tarih="19.11.2022"},
                new MyClass{ dilekceno="e438612", tc ="26588300608", tarih="22.11.2022"},
                new MyClass{ dilekceno="e448217", tc ="23636399034", tarih="23.11.2022"},
                new MyClass{ dilekceno="e451317", tc ="60625166192", tarih="24.11.2022"},
                new MyClass{ dilekceno="e451397", tc ="60676164444", tarih="24.11.2022"},
                new MyClass{ dilekceno="e456831", tc ="25877324288", tarih="25.11.2022"},
                new MyClass{ dilekceno="e460700", tc ="58741228894", tarih="27.11.2022"},
                new MyClass{ dilekceno="e464939", tc ="24071384548", tarih="28.11.2022"},
                new MyClass{ dilekceno="e481737", tc ="24404373478", tarih="1.12.2022 "},
                new MyClass{ dilekceno="e489855", tc ="60856158492", tarih="4.12.2022 "},
                new MyClass{ dilekceno="e495319", tc ="44080717540", tarih="5.12.2022 "},
                new MyClass{ dilekceno="e497040", tc ="29473823008", tarih="6.12.2022 "},
                new MyClass{ dilekceno="e502260", tc ="31061151592", tarih="7.12.2022 "},
                new MyClass{ dilekceno="e504150", tc ="41545802032", tarih="7.12.2022 "},
                new MyClass{ dilekceno="e520262", tc ="48853558422", tarih="9.12.2022 "},
                new MyClass{ dilekceno="e526283", tc ="20777112300", tarih="10.12.2022"},
                new MyClass{ dilekceno="e529542", tc ="22964050570", tarih="11.12.2022"},
                new MyClass{ dilekceno="e531614", tc ="11570801126", tarih="11.12.2022"},
                new MyClass{ dilekceno="e533104", tc ="12359774884", tarih="12.12.2022"},
                new MyClass{ dilekceno="e534593", tc ="65086017328", tarih="12.12.2022"},
                new MyClass{ dilekceno="e552871", tc ="34012911146", tarih="13.12.2022"},
                new MyClass{ dilekceno="e555523", tc ="20351508420", tarih="13.12.2022"},
                new MyClass{ dilekceno="e570877", tc ="40711829866", tarih="15.12.2022"},
                new MyClass{ dilekceno="e572327", tc ="37588933994", tarih="16.12.2022"},
                new MyClass{ dilekceno="e573903", tc ="60406173456", tarih="16.12.2022"},
                new MyClass{ dilekceno="e581506", tc ="61099150236", tarih="18.12.2022"},
                new MyClass{ dilekceno="e582713", tc ="62923089548", tarih="19.12.2022"},
                new MyClass{ dilekceno="e583151", tc ="58648231928", tarih="19.12.2022"},
                new MyClass{ dilekceno="e583535", tc ="15767661234", tarih="19.12.2022"},
                new MyClass{ dilekceno="e585387", tc ="23633399198", tarih="19.12.2022"},
                new MyClass{ dilekceno="e589635", tc ="63322076290", tarih="20.12.2022"},
                new MyClass{ dilekceno="e596111", tc ="64084050894", tarih="20.12.2022"},
                new MyClass{ dilekceno="e600814", tc ="20951106576", tarih="21.12.2022"},
                new MyClass{ dilekceno="e601151", tc ="29656816902", tarih="21.12.2022"},
                new MyClass{ dilekceno="e602996", tc ="15338675660", tarih="21.12.2022"},
                new MyClass{ dilekceno="e603062", tc ="63733062516", tarih="21.12.2022"},
                new MyClass{ dilekceno="e606540", tc ="63619066300", tarih="22.12.2022"},
                new MyClass{ dilekceno="e656056", tc ="58861224882", tarih="24.12.2022"},
                new MyClass{ dilekceno="e659693", tc ="58852225164", tarih="26.12.2022"},
                new MyClass{ dilekceno="e676013", tc ="58783227428", tarih="26.12.2022"},
                new MyClass{ dilekceno="e677022", tc ="58855225000", tarih="26.12.2022"},
                new MyClass{ dilekceno="e678265", tc ="37243945478", tarih="26.12.2022"},
                new MyClass{ dilekceno="e678506", tc ="48787560690", tarih="26.12.2022"},
                new MyClass{ dilekceno="e702875", tc ="32342108878", tarih="27.12.2022"},
                new MyClass{ dilekceno="e708317", tc ="61147148710", tarih="27.12.2022"},
                new MyClass{ dilekceno="e708445", tc ="18203580120", tarih="27.12.2022"},
                new MyClass{ dilekceno="e711217", tc ="64561034942", tarih="28.12.2022"},
                new MyClass{ dilekceno="e716178", tc ="36511579490", tarih="28.12.2022"},
                new MyClass{ dilekceno="e716360", tc ="19490155206", tarih="28.12.2022"},
                new MyClass{ dilekceno="e716996", tc ="18266577990", tarih="29.12.2022"},
                new MyClass{ dilekceno="e723323", tc ="62863091410", tarih="29.12.2022"},
                new MyClass{ dilekceno="e726209", tc ="19157166354", tarih="30.12.2022"},
                new MyClass{ dilekceno="e726824", tc ="11753795020", tarih="30.12.2022"},
                new MyClass{ dilekceno="e730440", tc ="37726929308", tarih="31.12.2022"},



            };
            CksListesiDal cksListesiDal=new CksListesiDal();
            CksManager cksManager=new CksManager();

            foreach (var item in list)
            {
                string tcNo = item.tc;

                CiftciManager ciftciManager = new CiftciManager();

                Ciftci _ciftci = ciftciManager.GetByTc(tcNo);
                if (_ciftci==null)
                {
                    continue;
                }
                Cks cks = new Cks()
                {
                    CiftciId = _ciftci.Id,
                    DosyaNo = cksManager.DosyaNoFactory(),
                    CreateTime = Convert.ToDateTime(item.tarih),
                    KullaniciId = 1,
                    Note = "",
                    EvrakKayitNo = "",
                    HavaleEdilenPersonel = "",
                    MuracaatYeri = "E-Devlet Üzerinden yapılan başvuru",
                };
                Edevlet edevlet = new Edevlet()
                {
                    DosyaNoEdevlet = item.dilekceno,
                    KullaniciId = 1,
                    
                };
                var result = cksManager.Add(cks,edevlet);
                Console.WriteLine(result);
                Console.WriteLine(result);
            }

        }


    }
    class MyClass
    {
        public string tc { get; set; }
        public string dilekceno { get; set; }
        public string tarih { get; set; }

    }


}
