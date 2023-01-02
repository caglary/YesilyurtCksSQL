using System;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Yesilyurt_Ciftci_Kayit.Utilities
{
    public partial class WaitingForm : Form
    {
        public Action Action { get; set; }
        public WaitingForm(Action action)
        {
            InitializeComponent();
            if (action!=null)
            {
                Action = action;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Action).ContinueWith(I => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void WaitingForm_Load(object sender, EventArgs e)
        {
        }
    }
}
