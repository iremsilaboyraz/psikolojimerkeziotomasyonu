using System;

namespace psikolojimerkeziotomasyonu
{
    public static class KullaniciOturumu
    {
        // Giriş yapan kişinin veritabanındaki ID numarası
        public static int KullaniciId { get; set; }

        // Giriş yapan kişinin ekranda görünecek adı soyadı
        public static string AdSoyad { get; set; }

        // Giriş yapanın yetkisi ("Admin" veya "Doktor")
        public static string Rol { get; set; }
    }
}