using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Yesilyurt_Ciftci_Kayit.Database.icmaller;
using Yesilyurt_Ciftci_Kayit.Manager;
using Yesilyurt_Ciftci_Kayit.Manager.icmaller;

namespace Yesilyurt_Ciftci_Kayit.Forms
{
    public partial class icmallerForm : Form
    {
        icmalFarkOdemesiDestegiYagliTohumluManager _icmalFarkOdemesiDestegiYagliTohumluManager;
        icmalFarkOdemsiManager _icmalFarkOdemsiManager;
        icmalKoogManager _icmalKoogManager;
        icmalMgdManager _icmalMgdManager;
        icmalStkdManager _icmalStkdManager;
        icmalTmoManager _icmalTmoManager;
        CiftciManager _ciftciManager;
        CksManager _cksManager;
        public icmallerForm()
        {
            InitializeComponent();
            _icmalFarkOdemesiDestegiYagliTohumluManager=new icmalFarkOdemesiDestegiYagliTohumluManager();
            _icmalFarkOdemsiManager=new icmalFarkOdemsiManager();
            _icmalKoogManager=new icmalKoogManager();    
            _icmalMgdManager=new icmalMgdManager();
            _icmalStkdManager=new icmalStkdManager();
            _icmalTmoManager=new icmalTmoManager();
            _ciftciManager = new CiftciManager();
            _cksManager=new CksManager();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBoxKimlikNo.Text.Length==11)
            {
                string kimlikNo=textBoxKimlikNo.Text;
                var yaglıTohumlus=_icmalFarkOdemesiDestegiYagliTohumluManager.GetAll(kimlikNo);
                var farkOdemesis=_icmalFarkOdemsiManager.GetAll(kimlikNo);
                var koogs=_icmalKoogManager.GetAll(kimlikNo);
                var mgds=_icmalMgdManager.GetAll(kimlikNo);  
                var stkds=_icmalStkdManager.GetAll(kimlikNo);
                var tmos=_icmalTmoManager.GetAll(kimlikNo);
                List<Destek> liste = new List<Destek>();
                foreach (var yaglıTohumlu in yaglıTohumlus)
                {
                    liste.Add(new Destek { Tutar = yaglıTohumlu.DestegeTutari,DestekAdi="Fark Ödemesi Desteği - Yağlı Tohumlu" });
                }
                foreach (var farkOdemesi in farkOdemesis)
                {
                    liste.Add(new Destek { Tutar = farkOdemesi.DestegeTutari, DestekAdi = "Fark Ödemesi Desteği" });
                }
                foreach (var koog in koogs)
                {
                    liste.Add(new Destek { Tutar = koog.DestekTutari,DestekAdi="Katı Organik Organomineral" });
                }
                foreach (var mgd in mgds)
                {
                    liste.Add(new Destek { Tutar = mgd.NetOdenecekTutar,DestekAdi="MGD" });
                }
                foreach (var stkd in stkds)
                {
                    liste.Add(new Destek { Tutar = stkd.DesteklemeMiktari, DestekAdi = "STKD" });

                }
                foreach (var tmo in tmos)
                {
                    liste.Add(new Destek { Tutar = tmo.DestekTutari, DestekAdi = "TMO" });

                }

                decimal toplamTutar = 0;
                if (liste.Count>0)
                {
                  
                    labelDestek.Text = "";

                }
               
                foreach (var destek in liste)
                {
                    toplamTutar+= destek.Tutar;
                    labelDestek.Text += destek.DestekAdi+"  => "+destek.Tutar  +" TL"+ "\n";
                }

               
                

                //Toplam için
                labelToplamTutar.Text = "Toplam :"+toplamTutar+" TL";

                var ciftci=_ciftciManager.GetByTc(kimlikNo);
                if(ciftci != null)
                {
                    //Dosya no
                    var cksDosya = _cksManager.GetByTc(kimlikNo);

                    labelInfo.Text = "";
                    labelInfo.Text = ciftci.IsimSoyisim + " => " + ciftci.MahalleKoy + " => " + ciftci.CepTelefonu+"\n" + "\n" + "Dosya No: " + cksDosya.DosyaNo.ToString();
                }



            }
        }
    }
    class Destek
    {
        public string DestekAdi { get; set; }
        public decimal Tutar { get; set; }
    }
}
