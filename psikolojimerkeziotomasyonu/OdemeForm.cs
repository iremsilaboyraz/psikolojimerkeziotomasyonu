using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using MySql.Data.MySqlClient;

namespace psikolojimerkeziotomasyonu
{
    public partial class OdemeForm : DevExpress.XtraEditors.XtraForm
    {
        // Veritabanı bağlantı dizesi
        string dbConnectionString = "Server=localhost;Database=psikolojimerkezi_db;Uid=root;Pwd=rabisko2016;";

        public OdemeForm()
        {
            InitializeComponent();
        }

        private void OdemeForm_Load(object sender, EventArgs e)
        {
            RandevulariYukle();
            OdemeYontemleriniYukle();
        }

        // Ödenmemiş randevuları yükleyen metot
        void RandevulariYukle()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(dbConnectionString))
                {
                    string sorgu = @"SELECT r.id, CONCAT(h.ad, ' ', h.soyad) as hasta, r.ucret 
                                     FROM randevular r 
                                     INNER JOIN hastalar h ON r.hasta_id = h.id 
                                     WHERE r.id NOT IN (SELECT randevu_id FROM odemeler)";

                    MySqlDataAdapter da = new MySqlDataAdapter(sorgu, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    glueRandevu.Properties.DataSource = dt;
                    glueRandevu.Properties.DisplayMember = "hasta";
                    glueRandevu.Properties.ValueMember = "id";
                }
            }
            catch (Exception ex) { XtraMessageBox.Show("Randevular yüklenemedi: " + ex.Message); }
        }

        void OdemeYontemleriniYukle()
        {
            cmbOdemeYontemi.Properties.Items.Clear();
            cmbOdemeYontemi.Properties.Items.AddRange(new string[] { "Nakit", "Kredi Kartı", "Havale/EFT" });
            cmbOdemeYontemi.SelectedIndex = 0;
        }

        // Randevu seçildiğinde ücretin otomatik gelmesi
        private void glueRandevu_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = glueRandevu.Properties.View.GetFocusedDataRow();
            if (row != null) { txtTutar.Text = row["ucret"].ToString(); }
        }

        private void btnOdemeTamamla_Click(object sender, EventArgs e)
        {
            // Boş alan kontrolü
            if (glueRandevu.EditValue == null || string.IsNullOrWhiteSpace(txtTutar.Text))
            {
                XtraMessageBox.Show("Lütfen randevu ve tutar alanlarını doldurun!", "Uyarı");
                return;
            }

            long sonId = 0;
            try
            {
                // 1. ADIM: VERİTABANINA KAYIT
                using (MySqlConnection conn = new MySqlConnection(dbConnectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO odemeler (randevu_id, tutar, odeme_yontemi, odeme_tarihi, aciklama) VALUES (@p1, @p2, @p3, @p4, @p5); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@p1", glueRandevu.EditValue);
                    cmd.Parameters.AddWithValue("@p2", Convert.ToDecimal(txtTutar.Text));
                    cmd.Parameters.AddWithValue("@p3", cmbOdemeYontemi.Text);
                    cmd.Parameters.AddWithValue("@p4", DateTime.Now);
                    cmd.Parameters.AddWithValue("@p5", txtAciklama.Text);
                    sonId = Convert.ToInt64(cmd.ExecuteScalar());
                }

                // 2. ADIM: RAPORU HAZIRLA VE MANUEL DOLDUR
                MakbuzRapor rapor = new MakbuzRapor();

                // Raporun Detail bandının basılması için 1 satırlık sahte veri kaynağı
                DataTable dtHile = new DataTable();
                dtHile.Columns.Add("id");
                dtHile.Rows.Add(1);
                rapor.DataSource = dtHile;

                // FORMDAKİ VERİLERİ RAPOR ETİKETLERİNE BASIYORUZ
                rapor.xrLabelHasta.Text = glueRandevu.Text.ToUpper();
                rapor.xrLabelTutar.Text = string.Format("{0:C2}", Convert.ToDecimal(txtTutar.Text)); // Para birimi formatı
                rapor.xrLabelOdemeYontem.Text = cmbOdemeYontemi.Text;
                rapor.xrLabelTarih.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

                // Görseldeki 'DOLDURULACAK' yazan yer için:
                rapor.xrLabelHizmetTuru.Text = "Psikolojik Danışmanlık Seans Ücreti";

                if (rapor.xrBarCodeId != null) rapor.xrBarCodeId.Text = sonId.ToString();

                // 3. ADIM: KLASÖRLEME VE PDF KAYIT (Masaüstü/Makbuzlar/Yıl-Ay/)
                string masaustu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string anaKlasor = Path.Combine(masaustu, "Makbuzlar");
                string aylikKlasor = Path.Combine(anaKlasor, DateTime.Now.ToString("yyyy-MM"));

                if (!Directory.Exists(anaKlasor)) Directory.CreateDirectory(anaKlasor);
                if (!Directory.Exists(aylikKlasor)) Directory.CreateDirectory(aylikKlasor);

                string tamYol = Path.Combine(aylikKlasor, $"Makbuz_{sonId}.pdf");
                rapor.ExportToPdf(tamYol);

                // 4. ADIM: ÖNİZLEME GÖSTER
                rapor.CreateDocument();
                ReportPrintTool pt = new ReportPrintTool(rapor);
                pt.ShowPreviewDialog();

                XtraMessageBox.Show("İşlem Başarılı ve Makbuz Kaydedildi!", "Bilgi");

                Temizle();
                RandevulariYukle(); // Listeyi güncelle ki ödenen randevu düşsün
            }
            catch (Exception ex) { XtraMessageBox.Show("Hata oluştu: " + ex.Message); }
        }

        // Formdaki alanları temizleyen metot
        void Temizle()
        {
            glueRandevu.EditValue = null;
            txtTutar.Text = "";
            txtAciklama.Text = "";
            cmbOdemeYontemi.SelectedIndex = 0;
        }
    }
}