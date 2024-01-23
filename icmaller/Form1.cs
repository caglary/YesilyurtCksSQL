using icmaller.Manager;
using System;
using System.Windows.Forms;

namespace icmaller
{
    public partial class Form1 : Form
    {
        Mgd2023Manager mgd2023Manager;
        FarkOdemesi2023Manager farkOdemesi2023Manager;
        SertifikaliTohum2023Manager sertifikaliTohum2023Manager;
        YemBitkileri2023Manager yemBitkileri2023Manager;
        public Form1()
        {
            InitializeComponent();
            mgd2023Manager = new Manager.Mgd2023Manager();
            farkOdemesi2023Manager = new FarkOdemesi2023Manager();
            sertifikaliTohum2023Manager = new SertifikaliTohum2023Manager();
            yemBitkileri2023Manager = new YemBitkileri2023Manager();
            initialize();

        }

        private void initialize()
        {
            var mgdRapor = mgd2023Manager.ToplamRapor();
            lblMgdToplamKisi.Text = mgdRapor[0];
            lblMgdToplamDestekTurar.Text= mgdRapor[1] + " TL";

            var farkOdemesiRapor=farkOdemesi2023Manager.ToplamRapor();
            lblFarkOdemesiToplamKisi.Text = farkOdemesiRapor[0];
            lblFarkOdemesiToplamDestekTutari.Text = farkOdemesiRapor[1] + " TL";

            var sertifikaliTohumRapor=sertifikaliTohum2023Manager.ToplamRapor();
            lblSertifikaliTohumToplamKisi.Text = sertifikaliTohumRapor[0];
            lblSertifikaliTohumToplamDestekTutari.Text = sertifikaliTohumRapor[1] + " TL";

            var yemBitkileriRapor = yemBitkileri2023Manager.ToplamRapor();
            lblYemBitkileriToplamKisi.Text = yemBitkileriRapor[0];
            lblYemBitkileriToplamDestekTutari.Text = yemBitkileriRapor[1]+" TL";

            var toplamDestek =Convert.ToDecimal( mgdRapor[1]) + Convert.ToDecimal(farkOdemesiRapor[1]) + Convert.ToDecimal(sertifikaliTohumRapor[1]) + Convert.ToDecimal(yemBitkileriRapor[1]);
            lblToplamDestek.Text = $"(*) Toplam verilen destek miktarı {toplamDestek.ToString("##0,##")} TL'dir.";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
              
                listBox1.Items.Clear();
                string tc = txtTc.Text;
               
                var farkOdemesiListe = farkOdemesi2023Manager.Mesaj(tc);
                var yemBitkileriListe = yemBitkileri2023Manager.Mesaj(tc);
                var mgdListe = mgd2023Manager.Mesaj(tc);
                var sertifikaliTohumListe = sertifikaliTohum2023Manager.Mesaj(tc);

               

                foreach (var item in mgdListe)
                {

                    listBox1.Items.Add(item);
                   

                }
                listBox1.Items.Add("-----------------");

                foreach (var item in farkOdemesiListe)
                {


                    listBox1.Items.Add(item);
                }
                listBox1.Items.Add("-----------------");

                foreach (var item in yemBitkileriListe)
                {

                    listBox1.Items.Add(item);

                }
                listBox1.Items.Add("-----------------");

                foreach (var item in sertifikaliTohumListe)
                {

                    listBox1.Items.Add(item);

                }
                listBox1.Items.Add("-----------------");

                var farkOdemesiDestekTutari = farkOdemesi2023Manager.FarkOdemesiDestekTutari(tc);
                var sertifikaliTohumDestekTutari = sertifikaliTohum2023Manager.SertifikaliTohumDestekTutari(tc);
                var yemBitkileriDestekTutari = yemBitkileri2023Manager.YemBitkileriDestekTutari(tc);
                var mgdDestekTutari = mgd2023Manager.MgdDestekTutari(tc);
                var toplam = (farkOdemesiDestekTutari + sertifikaliTohumDestekTutari + yemBitkileriDestekTutari + mgdDestekTutari).ToString();
                listBox1.Items.Add("\n\tToplam "+toplam + " TL destek alınmıştır.");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
