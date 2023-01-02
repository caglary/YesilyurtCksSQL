using System.Linq;
using Yesilyurt_Ciftci_Kayit.Entities;
namespace Yesilyurt_Ciftci_Kayit.Manager
{
    public class LoginManager
    {
        KullaniciManager kullaniciManager;
        public LoginManager()
        {
            kullaniciManager = new KullaniciManager();
        }
        public bool KullaniciGirisOnay(Kullanici k)
        {
            if (string.IsNullOrEmpty(k.KullaniciAdi) ||string.IsNullOrEmpty(k.Parola))
            {
                Utilities.Mesaj.MessageBoxWarning("Kullanici adı ya da parola alanı boş geçilemez.");
                return false;
            }
            //Kullanicinin olup olmadığına bakılacak
            var kullanici = kullaniciManager.GetAll().Where(I=>I.KullaniciAdi.ToLower()==k.KullaniciAdi.ToLower()).FirstOrDefault();
            if (kullanici==null)
            {
                Utilities.Mesaj.MessageBoxWarning($"{k.KullaniciAdi} isimli kullanıcı kaydı bulunmamaktadır.");
                return false;
            }
            // gelen kullanicinin bilgileri kontrol edilip giriş sağlanacak.
            if (kullanici.Parola != k.Parola)
            {
                Utilities.Mesaj.MessageBoxWarning("Parola yanlış.Tekrar deneyin.");
                return false;
            }
            return true;
            
        }
        public Kullanici GetKullanici(Kullanici k)
        {
            return kullaniciManager.GetAll().Where(I => I.KullaniciAdi.ToLower() == k.KullaniciAdi.ToLower()).FirstOrDefault();
        }
    }
}
