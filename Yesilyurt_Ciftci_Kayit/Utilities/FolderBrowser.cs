using System.Windows.Forms;

namespace Yesilyurt_Ciftci_Kayit.Utilities
{
    public static class FolderBrowser
    {
        public static string Path()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            return fbd.SelectedPath;
        }
    }
}
