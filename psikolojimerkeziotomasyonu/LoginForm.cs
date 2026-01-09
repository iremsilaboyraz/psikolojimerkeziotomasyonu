using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using PsikolojiMerkeziOtomasyonu;
using System;
using System.Data;
using System.Windows.Forms;

namespace psikolojimerkeziotomasyonu
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        // Bağlantı sınıfını burada tanımlıyoruz (Hata listesindeki 'bgl' hatalarını çözer)
        SqlBaglantisi bgl = new SqlBaglantisi();

        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                // Veritabanı sütun isimlerine (id, kullanici_adi, sifre, rol) göre sorgu
                string sql = "SELECT id, kullanici_adi, rol FROM kullanicilar WHERE kullanici_adi=@p1 AND sifre=@p2";

                MySqlCommand komut = new MySqlCommand(sql, bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);

                MySqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    // Bilgileri Global oturum sınıfına kaydediyoruz
                    KullaniciOturumu.KullaniciId = Convert.ToInt32(dr["id"]);

                    // Veritabanında ad_soyad sütunu olmadığı için kullanici_adi'nı atıyoruz
                    KullaniciOturumu.AdSoyad = dr["kullanici_adi"].ToString();

                    KullaniciOturumu.Rol = dr["rol"].ToString();

                    // Ana formu aç
                    MainForm anaForm = new MainForm();
                    anaForm.Show();

                    // Giriş formunu kapat
                    this.Hide();
                }
                else
                {
                    XtraMessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Bağlantı Hatası: " + ex.Message);
                if (bgl.baglanti().State == ConnectionState.Open) bgl.baglanti().Close();
            }
        }
    }
}