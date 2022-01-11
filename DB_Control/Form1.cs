using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yesilyurt_Ciftci_Kayit.Database;
using Yesilyurt_Ciftci_Kayit.Manager;

namespace DB_Control
{
    public partial class Form1 : Form
    {
        FarkOdemesiManager fdal;
        YemBitkisiManager ydal;
        SertifikaliTohumManager sdal;
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
            fdal = new FarkOdemesiManager();
            ydal = new YemBitkisiManager();
            sdal = new SertifikaliTohumManager();


        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac += 1;
            label1.Text = sayac.ToString();
            dataGridView1.DataSource = fdal.GetAll().ToList();
            dataGridView2.DataSource = ydal.GetAll().ToList();
            dataGridView3.DataSource = sdal.GetAll().ToList();
        }
    }
}
