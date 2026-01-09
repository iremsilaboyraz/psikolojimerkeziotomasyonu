using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using PsikolojiMerkeziOtomasyonu;
using System;
using System.Windows.Forms;

namespace psikolojimerkeziotomasyonu
{
    public partial class HastaKayitForm : DevExpress.XtraEditors.XtraForm
    {
        public HastaKayitForm()
        {
            InitializeComponent();
        }

        // Kutuları temizleme metodu (Kayıttan sonra veya iptal edildiğinde çağırmak için)
        void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTC.Text = "";
            txtTelefon.Text = "";
            txtAd.Focus(); // İmleci tekrar ilk kutuya gönderir
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // 1. ADIM: TC Karakter Sayısı ve Boşluk Kontrolü
            string tc = txtTC.Text.Trim();
            if (tc.Length != 11)
            {
                XtraMessageBox.Show("TC Kimlik numarası tam olarak 11 hane olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. ADIM: Ad ve Soyad Boş mu?
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text))
            {
                XtraMessageBox.Show("Lütfen hasta adını ve soyadını eksiksiz giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlBaglantisi bgl = new SqlBaglantisi();
            try
            {
                MySqlCommand komut = new MySqlCommand(
                    "INSERT INTO hastalar (ad, soyad, tc_no, telefon) VALUES (@p1, @p2, @p3, @p4)",
                    bgl.baglanti()
                );

                komut.Parameters.AddWithValue("@p1", txtAd.Text.Trim());
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text.Trim());
                komut.Parameters.AddWithValue("@p3", tc);
                komut.Parameters.AddWithValue("@p4", txtTelefon.Text.Trim());

                komut.ExecuteNonQuery(); // Veriyi MySQL'e gönder

                XtraMessageBox.Show("Hasta sisteme başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Kayıt başarılıysa kutuları boşalt
                Temizle();
            }
            catch (Exception ex)
            {
                // TC zaten varsa veritabanı bu hatayı döndürür
                if (ex.Message.Contains("Duplicate entry"))
                {
                    XtraMessageBox.Show("Bu TC numarasına sahip bir hasta zaten sistemde mevcut!", "Mükerrer Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XtraMessageBox.Show("Veritabanı Hatası: " + ex.Message);
                }
            }
            finally
            {
                // Bağlantıyı her ihtimalde kapat
                bgl.baglanti().Close();
            }
        }

        private void HastaKayitForm_Load(object sender, EventArgs e)
        {
            // Form açıldığında temiz başlasın
            Temizle();
        }
    }
}