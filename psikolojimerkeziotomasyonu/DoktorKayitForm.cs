using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using PsikolojiMerkeziOtomasyonu;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace psikolojimerkeziotomasyonu
{
    public partial class DoktorKayitForm : DevExpress.XtraEditors.XtraForm
    {
        public DoktorKayitForm()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        // Diğer formdan (UzmanListesiForm) veri taşımak için kullanılan değişkenler
        public string doktorId, ad, soyad, uzmanlik, telefon, email, fotografYolu;

        private void DoktorKayitForm_Load(object sender, EventArgs e)
        {
            // EĞER LİSTEDEN GÜNCELLE DENEEREK GELİNDİYSE (doktorId doluysa):
            if (!string.IsNullOrEmpty(doktorId))
            {
                txtDoktorAd.Text = ad;
                txtDoktorSoyad.Text = soyad;
                cmbUzmanlik.Text = uzmanlik; // ComboBox'a uzmanlık bilgisini aktar
                txtDoktorTel.Text = telefon;
                txtDoktorMail.Text = email;

                // Fotoğrafı yükle
                if (!string.IsNullOrEmpty(fotografYolu) && File.Exists(fotografYolu))
                {
                    picDoktorFoto.Image = Image.FromFile(fotografYolu);
                }

                // Butonun görevini ve ismini güncelle
                btnKaydet.Text = "Güncelle";
                this.Text = "Uzman Bilgilerini Düzenle: " + ad + " " + soyad;
            }
            else
            {
                // Yeni kayıt modu
                btnKaydet.Text = "Kaydet";
                this.Text = "Yeni Uzman Ekleme Paneli";
            }
        }

        // FOTOĞRAF SEÇME BUTONU (btnFotoSec)
        private void btnFotoSec_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dosya = new OpenFileDialog())
            {
                dosya.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (dosya.ShowDialog() == DialogResult.OK)
                {
                    picDoktorFoto.Image = Image.FromFile(dosya.FileName);
                    fotografYolu = dosya.FileName;
                }
            }
        }

        // ANA İŞLEM BUTONU (Kaydet / Güncelle)
        

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {

            // --- GÜVENLİK VE BOŞLUK KONTROLLERİ ---
            if (string.IsNullOrWhiteSpace(txtDoktorAd.Text)) { XtraMessageBox.Show("Lütfen Ad alanını doldurunuz!"); return; }
            if (string.IsNullOrWhiteSpace(txtDoktorSoyad.Text)) { XtraMessageBox.Show("Lütfen Soyad alanını doldurunuz!"); return; }

            // Uzmanlık alanı kontrolü (ComboBox boş geçilemez)
            if (string.IsNullOrWhiteSpace(cmbUzmanlik.Text))
            {
                XtraMessageBox.Show("Lütfen bir uzmanlık alanı seçiniz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbUzmanlik.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDoktorTel.Text)) { XtraMessageBox.Show("Lütfen Telefon alanını doldurunuz!"); return; }
            if (string.IsNullOrWhiteSpace(txtDoktorMail.Text)) { XtraMessageBox.Show("Lütfen E-posta alanını doldurunuz!"); return; }
            if (picDoktorFoto.Image == null) { XtraMessageBox.Show("Lütfen bir fotoğraf seçiniz!"); return; }

            try
            {
                string sorgu = "";
                if (btnKaydet.Text == "Güncelle")
                {
                    // GÜNCELLEME SORGUSU
                    sorgu = "UPDATE doktorlar SET ad=@p1, soyad=@p2, uzmanlik=@p3, telefon=@p4, email=@p5, fotograf_yolu=@p6 WHERE id=@p7";
                }
                else
                {
                    // YENİ KAYIT SORGUSU
                    sorgu = "INSERT INTO doktorlar (ad, soyad, uzmanlik, telefon, email, fotograf_yolu) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";
                }

                MySqlCommand komut = new MySqlCommand(sorgu, bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtDoktorAd.Text);
                komut.Parameters.AddWithValue("@p2", txtDoktorSoyad.Text);
                komut.Parameters.AddWithValue("@p3", cmbUzmanlik.Text); // ComboBox'tan seçilen değeri gönder
                komut.Parameters.AddWithValue("@p4", txtDoktorTel.Text);
                komut.Parameters.AddWithValue("@p5", txtDoktorMail.Text);
                komut.Parameters.AddWithValue("@p6", fotografYolu);

                if (btnKaydet.Text == "Güncelle")
                    komut.Parameters.AddWithValue("@p7", doktorId);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                XtraMessageBox.Show("İşlem başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (btnKaydet.Text == "Güncelle")
                    this.Close(); // Güncelleme yapıldıysa formu kapat
                else
                    Temizle(); // Yeni kayıt yapıldıysa alanları boşalt
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Veritabanı Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Formu temizleme metodu
        void Temizle()
        {
            txtDoktorAd.Text = "";
            txtDoktorSoyad.Text = "";
            cmbUzmanlik.SelectedIndex = -1; // Seçimi sıfırla
            txtDoktorTel.Text = "";
            txtDoktorMail.Text = "";
            picDoktorFoto.Image = null;
            fotografYolu = "";
            txtDoktorAd.Focus();
        }
    }
}