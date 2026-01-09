using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using PsikolojiMerkeziOtomasyonu;
using System;
using System.Data;
using System.Windows.Forms;

namespace psikolojimerkeziotomasyonu
{
    public partial class KasaRaporuForm : DevExpress.XtraEditors.XtraForm
    {
        public KasaRaporuForm()
        {
            InitializeComponent();
        }

        // Merkezi bağlantı sınıfınız
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void KasaRaporuForm_Load(object sender, EventArgs e)
        {
            // Form açıldığında tarihleri otomatik doldur (Ayın 1'inden bugüne)
            deBaslangic.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            deBitis.DateTime = DateTime.Now;
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            GelirRaporuGetir();
        }

        void GelirRaporuGetir()
        {
            try
            {
                // SQL Sorgusu: Sütun isimlerini küçük harf 'tutar' (FieldName ile uyumlu) yapıyoruz
                string sql = @"SELECT 
                                o.id as 'İşlem No',
                                CONCAT(h.ad, ' ', h.soyad) as 'Hasta Adı Soyadı',
                                o.tutar as 'tutar',
                                o.odeme_yontemi as 'Ödeme Yöntemi',
                                o.odeme_tarihi as 'Ödeme Tarihi',
                                o.aciklama as 'Açıklama'
                               FROM odemeler o
                               INNER JOIN randevular r ON o.randevu_id = r.id
                               INNER JOIN hastalar h ON r.hasta_id = h.id
                               WHERE o.odeme_tarihi BETWEEN @p1 AND @p2
                               ORDER BY o.odeme_tarihi DESC";

                MySqlCommand komut = new MySqlCommand(sql, bgl.baglanti());

                // Tarih filtreleme parametreleri
                komut.Parameters.AddWithValue("@p1", deBaslangic.DateTime.Date);
                komut.Parameters.AddWithValue("@p2", deBitis.DateTime.Date.AddDays(1).AddSeconds(-1));

                MySqlDataAdapter da = new MySqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // GridControl'e veriyi bağla
                gcKasaRaporu.DataSource = dt;

                // --- HATA ÇÖZÜMÜ: ALT TOPLAM (FOOTER) AYARLARI ---
                // Tasarımda (Name) kısmında 'coltutar' yazdığı için doğrudan bu ismi kullanıyoruz.
                // 'FieldName' küçük harf 'tutar' olduğu için toplama bunu hedefliyoruz.

                if (coltutar != null)
                {
                    coltutar.Summary.Clear();
                    coltutar.Summary.Add(DevExpress.Data.SummaryItemType.Sum, "tutar", "Toplam={0:C2}");
                    gridView1.OptionsView.ShowFooter = true;
                }

                bgl.baglanti().Close();

                if (dt.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Seçilen tarih aralığında ödeme kaydı bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Rapor hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}