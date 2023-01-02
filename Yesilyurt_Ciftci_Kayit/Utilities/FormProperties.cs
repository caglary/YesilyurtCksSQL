using System.Windows.Forms;
namespace Yesilyurt_Ciftci_Kayit.Utilities
{
    public class FormProperties
    {
        public static void FormOpen(string formName, Form acilacakForm, Form acildigiForm, bool withShowDialog = false,bool mdiform=false)
        {
            Form f = Application.OpenForms[formName];
            if (f == null)
            {
                f = acilacakForm;
                FromSettings(f,acildigiForm,mdiform);
                if (withShowDialog)
                    f.ShowDialog();
                    
                else
                    f.Show();
            }
            else
            {
                f.Focus();
            }
        }
        static void FromSettings(Form form, Form acildigiForm, bool mdiform = false)
        {
            //form.Size = new System.Drawing.Size(1000, 800);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //form.Font = new System.Drawing.Font("Tahoma", 9);
            form.Font = new System.Drawing.Font("Segoe UI", 9);
            //form.Size = new System.Drawing.Size(950, 700);
            
            form.WindowState = FormWindowState.Normal;
            if (mdiform)
                form.MdiParent = acildigiForm;
        }
    }
}
