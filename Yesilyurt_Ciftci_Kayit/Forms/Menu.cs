using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yesilyurt_Ciftci_Kayit.Entities;

namespace Yesilyurt_Ciftci_Kayit.Forms
{
    public partial class Menu : Form
    {
        Kullanici _kullanici;
        public Menu(Kullanici user)
        {
            InitializeComponent();
            _kullanici = user;

        }

        private void btn_2021_Click(object sender, EventArgs e)
        {
           

            OpenAnasayfaForm("2021");
        }

        private void btn_2022_Click(object sender, EventArgs e)
        {

            OpenAnasayfaForm("2022");



        }

        private void btn_2023_Click(object sender, EventArgs e)
        {


            OpenAnasayfaForm("2023");


        }

        private void SelectYearForm_Load(object sender, EventArgs e)
        {
            welcome.Text = "Hoşgeldin, " + _kullanici.KullaniciAdi;
        }

        private void SelectYearForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OpenAnasayfaForm(string year)
        {
            string seciliYil = Yesilyurt_Ciftci_Kayit.Utilities.ConnectionString.year;
            Yesilyurt_Ciftci_Kayit.Utilities.ConnectionString.year = year;

            var anasayfa = Application.OpenForms["Anasayfa"];
            if (year == seciliYil)
            {
                if (anasayfa == null)//form açık değilse
                {
                    Form _anasayfa = new Anasayfa(_kullanici);
                    _anasayfa.MdiParent = this;
                    _anasayfa.StartPosition = FormStartPosition.CenterParent;
                    _anasayfa.Show();
                }
                else
                {
                    anasayfa.Focus();
                }
            }
            else
            {
                // farklı bir butona tıklandı demektir.
                //butonName eşit değilse year
                //var olan anasayfayı kapat

                if (anasayfa != null) { anasayfa.Close(); }

                //seçilen yılı gösteren yeni bir anasayfa aç 
                Form _anasayfa = new Anasayfa(_kullanici);
                _anasayfa.MdiParent = this;
                
                _anasayfa.Show();

            }

        }
    }
}
