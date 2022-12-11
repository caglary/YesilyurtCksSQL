using System;
using System.Windows.Forms;

namespace Yesilyurt_Ciftci_Kayit.Utilities
{
    public static class Question
    {
        public static void IfYes(Action action, string mesaj)
        {
            DialogResult result = MessageBox.Show(mesaj, "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
                action.Invoke();
        }
    }
}
