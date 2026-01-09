using System;
using MySql.Data.MySqlClient;

namespace PsikolojiMerkeziOtomasyonu
{
    class SqlBaglantisi
    {
        public MySqlConnection baglanti()
        {
            // Senin verdiğin bağlantı adresi
            MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=psikolojimerkezi_db;Uid=root;Pwd=rabisko2016;");
            baglan.Open();
            return baglan;
        }
    }
}