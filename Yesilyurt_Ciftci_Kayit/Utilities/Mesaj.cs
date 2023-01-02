using System.Windows.Forms;
namespace Yesilyurt_Ciftci_Kayit.Utilities
{
    public static class Mesaj
    {
        public static DialogResult MessageBoxError(string Message)
        {
            return MessageBox.Show(Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult MessageBoxInformation(string Message)
        {
            return MessageBox.Show(Message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult MessageBoxWarning(string Message)
        {
            return MessageBox.Show(Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult MessageBoxQuestion(string Message)
        {
            return MessageBox.Show(Message, "Soru", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
        public static DialogResult Unauthorized()
        {
            return MessageBox.Show("Yetkiniz bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
