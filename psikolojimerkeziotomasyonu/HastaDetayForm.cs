using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using PsikolojiMerkeziOtomasyonu;
using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace psikolojimerkeziotomasyonu
{
    public partial class HastaDetayForm : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglantisi bgl = new SqlBaglantisi();

        public HastaDetayForm()
        {
            InitializeComponent();
        }

        private void HastaDetayForm_Load(object sender, EventArgs e)
        {
            TumHastalarYukle();
        }

        void TumHastalarYukle()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "";

                // --- YETKİ KONTROLÜ ---
                if (KullaniciOturumu.Rol == "Doktor")
                {
                    // Doktor sadece kendi randevusu olan hastaları görür
                    sql = @"SELECT DISTINCT h.id, CONCAT(h.ad, ' ', h.soyad) as 'HastaAdSoyad' 
                            FROM hastalar h 
                            INNER JOIN randevular r ON h.id = r.hasta_id 
                            WHERE r.doktor_id = @p1";
                }
                else
                {
                    // Admin veya Sekreter tüm hastaları görebilir
                    sql = "SELECT id, CONCAT(ad, ' ', soyad) as 'HastaAdSoyad' FROM hastalar";
                }

                MySqlCommand cmd = new MySqlCommand(sql, bgl.baglanti());

                if (KullaniciOturumu.Rol == "Doktor")
                    cmd.Parameters.AddWithValue("@p1", KullaniciOturumu.KullaniciId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                slueHastaSec.Properties.DataSource = dt;
                slueHastaSec.Properties.DisplayMember = "HastaAdSoyad";
                slueHastaSec.Properties.ValueMember = "id";
                slueHastaSec.Properties.PopulateViewColumns();
                bgl.baglanti().Close();
            }
            catch (Exception ex) { XtraMessageBox.Show("Yükleme Hatası: " + ex.Message); }
        }

        private void slueHastaSec_EditValueChanged(object sender, EventArgs e)
        {
            if (slueHastaSec.EditValue != null && slueHastaSec.EditValue != DBNull.Value)
            {
                int id = Convert.ToInt32(slueHastaSec.EditValue);
                BilgiKartlariniDoldur(id);
                GecmisSeanslariListele(id);
                GelisimGrafiginiGuncelle(id);
            }
        }

        void BilgiKartlariniDoldur(int hastaId)
        {
            try
            {
                lblHastaAdi.Text = slueHastaSec.Text;
                lblHastaId.Text = "Hasta ID: #" + hastaId.ToString();

                string sql = "SELECT MAX(randevu_tarih) FROM randevular WHERE hasta_id = @p1";
                MySqlCommand cmd = new MySqlCommand(sql, bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", hastaId);
                object tarih = cmd.ExecuteScalar();

                lblSonRandevu.Text = (tarih != null && tarih != DBNull.Value)
                                     ? "Son Seans: " + Convert.ToDateTime(tarih).ToString("dd.MM.yyyy")
                                     : "Son Seans: Kayıt Yok";
                bgl.baglanti().Close();
            }
            catch { bgl.baglanti().Close(); }
        }

        void GelisimGrafiginiGuncelle(int hastaId)
        {
            try
            {
                chartControl1.Series.Clear();
                Series seri = new Series("Gelişim", ViewType.Spline);
                seri.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                seri.ArgumentScaleType = ScaleType.Qualitative;

                string sql = @"SELECT DATE_FORMAT(kayit_tarihi, '%d.%m.%Y') as T, gelisim_puani 
                               FROM seans_detaylari 
                               WHERE hasta_id = @p1 
                               ORDER BY kayit_tarihi ASC";

                MySqlCommand cmd = new MySqlCommand(sql, bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", hastaId);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    seri.Points.Add(new SeriesPoint(dr["T"].ToString(), dr["gelisim_puani"]));
                }
                bgl.baglanti().Close();

                chartControl1.Series.Add(seri);

                XYDiagram diagram = (XYDiagram)chartControl1.Diagram;
                if (diagram != null)
                {
                    diagram.AxisY.WholeRange.SetMinMaxValues(0, 11);
                    diagram.AxisY.VisualRange.SetMinMaxValues(0, 11);
                    diagram.AxisY.NumericScaleOptions.GridSpacing = 1;
                    diagram.AxisX.Label.Angle = -45;
                    diagram.Margins.All = 10;
                }

                SplineSeriesView view = (SplineSeriesView)seri.View;
                view.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                view.LineMarkerOptions.Size = 10;
                view.LineMarkerOptions.Kind = MarkerKind.Circle;
            }
            catch { bgl.baglanti().Close(); }
        }

        void GecmisSeanslariListele(int hastaId)
        {
            try
            {
                DataTable dt = new DataTable();
                // --- YETKİ KONTROLÜ (Seans Listesi) ---
                string sql = "";
                if (KullaniciOturumu.Rol == "Doktor")
                {
                    // Doktor sadece kendi yaptığı seansları listeler
                    sql = "SELECT id, CONCAT(DATE_FORMAT(randevu_tarih, '%d.%m.%Y'), ' - Seans') as SeansBilgi FROM randevular WHERE hasta_id = @p1 AND doktor_id = @p2 ORDER BY randevu_tarih DESC";
                }
                else
                {
                    // Admin her seansı görebilir
                    sql = "SELECT id, CONCAT(DATE_FORMAT(randevu_tarih, '%d.%m.%Y'), ' - Seans') as SeansBilgi FROM randevular WHERE hasta_id = @p1 ORDER BY randevu_tarih DESC";
                }

                MySqlDataAdapter da = new MySqlDataAdapter(sql, bgl.baglanti());
                da.SelectCommand.Parameters.AddWithValue("@p1", hastaId);

                if (KullaniciOturumu.Rol == "Doktor")
                    da.SelectCommand.Parameters.AddWithValue("@p2", KullaniciOturumu.KullaniciId);

                da.Fill(dt);
                listBoxControl1.DataSource = dt;
                listBoxControl1.DisplayMember = "SeansBilgi";
                listBoxControl1.ValueMember = "id";
                bgl.baglanti().Close();
            }
            catch { bgl.baglanti().Close(); }
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxControl1.SelectedValue == null || listBoxControl1.SelectedValue is DataRowView) return;

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT seans_notu, gelisim_puani FROM seans_detaylari WHERE randevu_id = @p1", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", listBoxControl1.SelectedValue);
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        memoEdit1.Text = dr["seans_notu"].ToString();
                        trackBarControl1.Value = Convert.ToInt32(dr["gelisim_puani"]);
                    }
                    else { memoEdit1.Text = ""; trackBarControl1.Value = 0; }
                }
                bgl.baglanti().Close();
            }
            catch { bgl.baglanti().Close(); }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (slueHastaSec.EditValue == null || listBoxControl1.SelectedValue == null) return;
            try
            {
                int rId = Convert.ToInt32(listBoxControl1.SelectedValue);
                int hId = Convert.ToInt32(slueHastaSec.EditValue);

                MySqlCommand sil = new MySqlCommand("DELETE FROM seans_detaylari WHERE randevu_id=@p1", bgl.baglanti());
                sil.Parameters.AddWithValue("@p1", rId);
                sil.ExecuteNonQuery();
                bgl.baglanti().Close();

                string sql = "INSERT INTO seans_detaylari (randevu_id, hasta_id, seans_notu, gelisim_puani) VALUES (@p1,@p2,@p3,@p4)";
                MySqlCommand cmd = new MySqlCommand(sql, bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", rId);
                cmd.Parameters.AddWithValue("@p2", hId);
                cmd.Parameters.AddWithValue("@p3", memoEdit1.Text);
                cmd.Parameters.AddWithValue("@p4", trackBarControl1.Value);
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();

                XtraMessageBox.Show("Başarıyla Kaydedildi.");
                GelisimGrafiginiGuncelle(hId);
            }
            catch (Exception ex) { XtraMessageBox.Show("Hata: " + ex.Message); }
        }
    }
}