using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yesilyurt_Ciftci_Kayit.Forms
{
    public partial class SelectYearForm : Form
    {
        public SelectYearForm()
        {
            InitializeComponent();
        }

        private void btn_2021_Click(object sender, EventArgs e)
        {
            Yesilyurt_Ciftci_Kayit.Utilities.ConnectionString.year="2021";
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btn_2022_Click(object sender, EventArgs e)
        {
            Yesilyurt_Ciftci_Kayit.Utilities.ConnectionString.year = "2022";
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btn_2023_Click(object sender, EventArgs e)
        {
            Yesilyurt_Ciftci_Kayit.Utilities.ConnectionString.year = "2023";
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
