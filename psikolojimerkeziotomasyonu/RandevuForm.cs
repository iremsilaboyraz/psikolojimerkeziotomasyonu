using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using PsikolojiMerkeziOtomasyonu;
using System;
using System.Data;
using System.Windows.Forms;

namespace psikolojimerkeziotomasyonu
{
    public partial class RandevuForm : DevExpress.XtraEditors.XtraForm
    {
        public RandevuForm()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        // --- SENARYO 1: DOKTOR ÇALIŞMA SAATİ KONTROL METODU ---
        bool DoktorCalisiyorMu(int doktorId, DateTime randevuTarihi, TimeSpan randevuSaati)
        {
            string[] gunler = { "Pazar", "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi" };
            string secilenGun = gunler[(int)randevuTarihi.DayOfWeek];
            bool calisiyor = false;

            try
            {
                string sql = "SELECT baslangic_saat, bitis_saat FROM doktor_calisma_saatleri WHERE doktor_id=@dId AND gun=@gun";
                MySqlCommand cmd = new MySqlCommand(sql, bgl.baglanti());
                cmd.Parameters.AddWithValue("@dId", doktorId);
                cmd.Parameters.AddWithValue("@gun", secilenGun);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        TimeSpan baslangic = (TimeSpan)dr["baslangic_saat"];
                        TimeSpan bitis = (TimeSpan)dr["bitis_saat"];

                        // Seçilen saat mesai aralığına dahil mi?
                        if (randevuSaati >= baslangic && randevuSaati < bitis)
                        {
                            calisiyor = true;
                        }
                    }
                }
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Mesai kontrolü sırasında hata: " + ex.Message);
            }
            return calisiyor;
        }

        void VerileriYukle()
        {
            try
            {
                // HASTA LİSTESİ
                DataTable dtHasta = new DataTable();
                MySqlDataAdapter daHasta = new MySqlDataAdapter("SELECT id, CONCAT(ad, ' ', soyad) as 'Hasta' FROM hastalar", bgl.baglanti());
                daHasta.Fill(dtHasta);
                slueHasta.Properties.DataSource = dtHasta;
                slueHasta.Properties.DisplayMember = "Hasta";
                slueHasta.Properties.ValueMember = "id";

                // DOKTOR LİSTESİ
                DataTable dtDoktor = new DataTable();
                MySqlDataAdapter daDoktor = new MySqlDataAdapter("SELECT id, CONCAT(ad, ' ', soyad) as 'Doktor' FROM doktorlar", bgl.baglanti());
                daDoktor.Fill(dtDoktor);
                lueDoktor.Properties.DataSource = dtDoktor;
                lueDoktor.Properties.DisplayMember = "Doktor";
                lueDoktor.Properties.ValueMember = "id";

                // SEANS TÜRLERİ
                lueSeansTur.Properties.DataSource = new string[] { "Bireysel Terapi", "Aile Danışmanlığı", "Çocuk ve Ergen", "İlişki Terapisi", };

                bgl.baglanti().Close();
            }
            catch (Exception) { /* Bağlantı hatası yönetimi */ }
        }

        private void RandevuForm_Load(object sender, EventArgs e)
        {
            VerileriYukle();
            deTarih.DateTime = DateTime.Now;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // 1. ADIM: BOŞ KONTROLLERİ
            if (slueHasta.EditValue == null)
            {
                XtraMessageBox.Show("Lütfen bir hasta seçiniz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lueDoktor.EditValue == null)
            {
                XtraMessageBox.Show("Lütfen randevu verilecek doktoru seçiniz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal ucret;
            if (string.IsNullOrWhiteSpace(txtUcret.Text) || !decimal.TryParse(txtUcret.Text, out ucret))
            {
                XtraMessageBox.Show("Lütfen geçerli bir ücret giriniz!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- 2. ADIM: MESAI KONTROLÜ (SENARYO 1) ---
            int secilenDoktorId = Convert.ToInt32(lueDoktor.EditValue);
            DateTime rTarih = deTarih.DateTime;
            TimeSpan rSaat = teSaat.Time.TimeOfDay;

            if (!DoktorCalisiyorMu(secilenDoktorId, rTarih, rSaat))
            {
                XtraMessageBox.Show(
                    string.Format("Seçilen doktor {0} günü saat {1} aralığında çalışmamaktadır.",
                    rTarih.ToString("dddd"), rSaat.ToString(@"hh\:mm")),
                    "Mesai Dışı Saat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return; // Çalışmıyorsa kaydı durdurur
            }

            // 3. ADIM: KAYIT İŞLEMİ
            try
            {
                string sorgu = "INSERT INTO randevular (hasta_id, doktor_id, randevu_tarih, randevu_saat, ucret, durum, notlar, seans_turu) " +
                               "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)";

                MySqlCommand komut = new MySqlCommand(sorgu, bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", slueHasta.EditValue);
                komut.Parameters.AddWithValue("@p2", lueDoktor.EditValue);
                komut.Parameters.AddWithValue("@p3", deTarih.DateTime.ToString("yyyy-MM-dd"));
                komut.Parameters.AddWithValue("@p4", teSaat.Text);
                komut.Parameters.AddWithValue("@p5", ucret);
                komut.Parameters.AddWithValue("@p6", "Beklemede");
                komut.Parameters.AddWithValue("@p7", meNotlar.Text ?? "");
                komut.Parameters.AddWithValue("@p8", lueSeansTur.EditValue?.ToString() ?? "");

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                XtraMessageBox.Show("Randevu kaydı başarıyla tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Sistem Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}