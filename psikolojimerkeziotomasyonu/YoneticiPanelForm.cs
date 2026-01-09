using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using PsikolojiMerkeziOtomasyonu;
using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace psikolojimerkeziotomasyonu
{
    public partial class YoneticiPanelForm : DevExpress.XtraEditors.XtraForm
    {
        public YoneticiPanelForm()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        void KartVerileriniGetir()
        {
            try
            {
                // 1. Bugünün Randevu Sayısı
                MySqlCommand komut1 = new MySqlCommand("SELECT COUNT(*) FROM randevular WHERE randevu_tarih = CURDATE()", bgl.baglanti());
                lblBugunkuRandevu.Text = komut1.ExecuteScalar().ToString();
                bgl.baglanti().Close();

                // 2. Bugünün Toplam Kazancı
                MySqlCommand komut2 = new MySqlCommand("SELECT SUM(tutar) FROM odemeler WHERE DATE(odeme_tarihi) = CURDATE()", bgl.baglanti());
                object kazanc = komut2.ExecuteScalar();
                lblBugunkuKazanc.Text = (kazanc != DBNull.Value) ? string.Format("{0:N2} ₺", kazanc) : "0,00 ₺";
                bgl.baglanti().Close();

                // 3. BEKLEYEN ÖDEMELER (DÜZELTİLDİ)
                // Mantık: Randevular tablosunda olan ama henüz ödemeler tablosunda kaydı olmayanları sayar
                string bekleyenSorgu = @"SELECT COUNT(*) FROM randevular 
                                         WHERE id NOT IN (SELECT randevu_id FROM odemeler)";
                MySqlCommand komut3 = new MySqlCommand(bekleyenSorgu, bgl.baglanti());
                lblBekleyenOdemeler.Text = komut3.ExecuteScalar().ToString();
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("İstatistikler çekilirken hata: " + ex.Message);
            }
        }

        void GrafigiYukle()
        {
            try
            {
                DataTable dt = new DataTable();
                // Sorgu: Ayları yerel dile (Türkçe) göre getirmek ve yıla göre filtrelemek daha sağlıklıdır
                string sorgu = @"SELECT DATE_FORMAT(odeme_tarihi, '%M') as Ay, SUM(tutar) as Toplam 
                                 FROM odemeler 
                                 GROUP BY Ay, MONTH(odeme_tarihi) 
                                 ORDER BY MONTH(odeme_tarihi) ASC";

                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, bgl.baglanti());
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    // Series 1 isminin doğruluğundan emin olun (Tasarım ekranından kontrol edebilirsiniz)
                    chartGelir.Series["Series 1"].DataSource = dt;
                    chartGelir.Series["Series 1"].ArgumentDataMember = "Ay";
                    chartGelir.Series["Series 1"].ValueDataMembers.AddRange(new string[] { "Toplam" });
                }
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Grafik yükleme hatası: " + ex.Message);
            }
        }

        void YaklasanRandevular()
        {
            try
            {
                DataTable dt = new DataTable();
                // Saatlerin 00:00 görünmemesi için sorguyu ve tablo sütunlarını kontrol ediyoruz
                string sorgu = @"SELECT r.randevu_tarih as 'Tarih', 
                                 r.randevu_saat as 'Saat', 
                                 CONCAT(h.ad, ' ', h.soyad) as 'Danışan' 
                                 FROM randevular r 
                                 INNER JOIN hastalar h ON r.hasta_id = h.id 
                                 WHERE r.randevu_tarih >= CURDATE() 
                                 ORDER BY r.randevu_tarih ASC, r.randevu_saat ASC LIMIT 10";

                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, bgl.baglanti());
                da.Fill(dt);
                gridYaklasanRandevular.DataSource = dt;
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Randevu listesi hatası: " + ex.Message);
            }
        }

        private void YoneticiPanelForm_Load(object sender, EventArgs e)
        {
            KartVerileriniGetir();
            GrafigiYukle();
            YaklasanRandevular();
        }
    }
}