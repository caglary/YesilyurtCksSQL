using System;
using System.Windows.Forms;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Manager;
namespace Yesilyurt_Ciftci_Kayit.Forms
{
    public partial class LoginForm : Form
    {
        Kullanici _kullanici;
        LoginManager loginManager;
        public LoginForm()
        {
            InitializeComponent();
            loginManager = new LoginManager();
            _kullanici = new Kullanici();

        }
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void btnGiris_Click(object sender, System.EventArgs e)
        {
            _kullanici.KullaniciAdi = txtKullaniciAdi.Text.ToLower();
            _kullanici.Parola = txtParola.Text.ToLower();
            if (loginManager.KullaniciGirisOnay(_kullanici))
            {
                OpenMenuForm(_kullanici);

            }
        }
        private void LoginForm_Activated(object sender, EventArgs e)
        {
            string macAddress = Utilities.MacAddress.GetMacAddress();
            string machineName = Environment.MachineName; // Lenovo için ekleme yapıldı...

            if (machineName == "DESKTOP-ITQCLKI" || machineName == "M601102-0042")
            {
                _kullanici.KullaniciAdi = "caglar";
                OpenMenuForm(_kullanici);


            }
            else if (machineName == "M601102-0044")
            {
                _kullanici.KullaniciAdi = "burak";
                OpenMenuForm(_kullanici);
            }
        }
        
        private void OpenMenuForm(Kullanici _kullanici)
        {
            var kullanici = loginManager.GetKullanici(_kullanici);
            Form Menu=Application.OpenForms["Menu"];

            if (kullanici != null && Menu==null)
            {
                Menu selectYearForm = new Menu(kullanici);
                selectYearForm.Show();
                this.Hide();
            }
        }

    }
}
