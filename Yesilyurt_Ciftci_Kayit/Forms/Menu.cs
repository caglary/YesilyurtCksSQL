using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Utilities;

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
        private void butonControl(Button button)
        {
            foreach (Control item in this.Controls)
            {
                if (item.Name == "panel1")
                {
                    foreach (var items in item.Controls)
                    {
                        if (items.GetType() == typeof(Button))
                        {
                            Button btn = (Button)items;
                            if (btn.Text != button.Text)
                            {
                                btn.BackColor = Color.WhiteSmoke;
                                btn.Font=new Font("Microsoft Sans Serif", 8);
                              
                               
                            }
                            else
                            {
                                btn.BackColor = Color.Wheat;
                                btn.Font = new Font("Microsoft Sans Serif", 12);
                              

                            }

                        }
                    }
                }

            }
        }
        private void btn_2021_Click(object sender, EventArgs e)
        {
          
            Button btnSender= (Button)sender;
            butonControl(btnSender);
            OpenAnasayfaForm("2021");
            
           
            
        }

        private void btn_2022_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            butonControl(btnSender);
            OpenAnasayfaForm("2022");
           


        }

        private void btn_2023_Click(object sender, EventArgs e)
        {

            Button btnSender = (Button)sender;
            butonControl(btnSender);
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
            string seciliYil = ConnectionString.year;
            ConnectionString.year = year;

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

        private void btn_2024_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            butonControl(btnSender);
            OpenAnasayfaForm("2024");
        }
    }
}
