using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using PsikolojiMerkeziOtomasyonu;
using System;
using System.Data;
using System.Windows.Forms;

namespace psikolojimerkeziotomasyonu
{
    public partial class SeansTanimForm : DevExpress.XtraEditors.XtraForm
    {
        public SeansTanimForm()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        string seciliSeansId = "";

        // Verileri bir kere çekip hafızada tutmak performansı uçurur
        void ListeyiDoldur()
        {
            try
            {
                DataTable dt = new DataTable();
                // Veritabanı bağlantısını tek seferde aç-kapat yapıyoruz
                using (MySqlConnection conn = bgl.baglanti())
                {
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT id, hizmet_adi, ucret, sure_dakika FROM seans_turleri", conn);
                    da.Fill(dt);
                }

                lueSeanslar.Properties.DataSource = dt;
                lueSeanslar.Properties.DisplayMember = "hizmet_adi";
                lueSeanslar.Properties.ValueMember = "id";

                // Arama kutusunun içindeki sütunları düzenle (Görsel hız algısı için)
                lueSeanslar.Properties.PopulateColumns();
                if (lueSeanslar.Properties.Columns["id"] != null)
                    lueSeanslar.Properties.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void SeansTanimForm_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
            groupControl1.Text = "Yeni Hizmet Tanımlama Detayları";
        }

        // BU KISIM HIZIN ANAHTARI: Veritabanına sormadan direkt hafızadaki satırı alır
        private void lueSeanslar_EditValueChanged(object sender, EventArgs e)
        {
            // Seçilen satırı bir veri objesi olarak alıyoruz
            DataRowView row = lueSeanslar.GetSelectedDataRow() as DataRowView;

            if (row != null)
            {
                // Hafızadaki verileri değişkenlere aktar (Sıfır gecikme)
                seciliSeansId = row["id"].ToString();
                txtHizmetAd.Text = row["hizmet_adi"].ToString();
                txtUcret.Text = row["ucret"].ToString();
                txtSure.Value = Convert.ToDecimal(row["sure_dakika"]);

                // UI Güncelleme
                btnKaydet.Text = "Güncelle";
                groupControl1.Text = "Hizmet Güncelleme: " + txtHizmetAd.Text;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
          
            // Temel kontrol: Hizmet adı her zaman dolu olmalı
            if (string.IsNullOrWhiteSpace(txtHizmetAd.Text))
            {
                XtraMessageBox.Show("Lütfen hizmet adını boş bırakmayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sorgu = "";
                if (btnKaydet.Text == "Güncelle")
                {
                    sorgu = "UPDATE seans_turleri SET hizmet_adi=@p1, ucret=@p2, sure_dakika=@p3 WHERE id=@p4";
                }
                else
                {
                    sorgu = "INSERT INTO seans_turleri (hizmet_adi, ucret, sure_dakika) VALUES (@p1, @p2, @p3)";
                }

                using (MySqlConnection conn = bgl.baglanti())
                {
                    MySqlCommand komut = new MySqlCommand(sorgu, conn);

                    // 1. Parametre: Hizmet Adı
                    komut.Parameters.AddWithValue("@p1", txtHizmetAd.Text);

                    // 2. Parametre: Ücret (Sayısal formata güvenli dönüştürme)
                    // txtUcret boşsa veya hatalıysa 0 olarak kabul et ya da mevcut değeri koru
                    string ucretHamVeri = txtUcret.Text.Replace(".", ",");
                    decimal ucretDegeri;
                    if (!decimal.TryParse(ucretHamVeri, out ucretDegeri))
                    {
                        ucretDegeri = 0; // Eğer ücret silindiyse 0 kaydeder
                    }
                    komut.Parameters.AddWithValue("@p2", ucretDegeri);

                    // 3. Parametre: Süre (SpinEdit'ten gelen değer)
                    komut.Parameters.AddWithValue("@p3", (int)txtSure.Value);

                    // 4. Parametre: ID (Sadece güncelleme modunda)
                    if (btnKaydet.Text == "Güncelle")
                    {
                        komut.Parameters.AddWithValue("@p4", seciliSeansId);
                    }

                    komut.ExecuteNonQuery();
                }

                XtraMessageBox.Show("İşlem başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListeyiDoldur(); // Listeyi tazele
                Temizle();      // Formu varsayılan "Yeni Kayıt" moduna döndür
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Kaydetme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        void Temizle()
        {
            txtHizmetAd.Text = "";
            txtUcret.Text = "";
            txtSure.Value = 0;
            seciliSeansId = "";
            lueSeanslar.EditValue = null;
            btnKaydet.Text = "Kaydet";
            groupControl1.Text = "Yeni Hizmet Tanımlama Detayları";
        }

        private void lueSeanslar_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            // Kullanıcı bir şey seçtiyse ve "İptal" demediyse
            if (e.AcceptValue && e.Value != null)
            {
                // Seçilen satırı hafızadan (DataTable'dan) çekiyoruz
                // e.Value burada seçilen satırın ID'sini (ValueMember) verir
                DataRowView row = lueSeanslar.Properties.GetDataSourceRowByKeyValue(e.Value) as DataRowView;

                if (row != null)
                {
                    // Verileri kutulara anlık aktar
                    seciliSeansId = row["id"].ToString();
                    txtHizmetAd.Text = row["hizmet_adi"].ToString();
                    txtUcret.Text = row["ucret"].ToString();
                    txtSure.Value = Convert.ToDecimal(row["sure_dakika"]);

                    // Modu ve Başlığı Güncelle
                    btnKaydet.Text = "Güncelle";
                    groupControl1.Text = "Hizmet Güncelleme: " + txtHizmetAd.Text;
                }
            }
        
    }
    }
}