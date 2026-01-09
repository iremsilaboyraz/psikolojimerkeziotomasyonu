using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using PsikolojiMerkeziOtomasyonu;
using System;
using System.Data;
using System.Windows.Forms;

namespace psikolojimerkeziotomasyonu
{
    public partial class UzmanListesiForm : DevExpress.XtraEditors.XtraForm
    {
        public UzmanListesiForm()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        // Doktorları Grid'e Doldurma
        void Listele()
        {
            try
            {
                DataTable dt = new DataTable();
                // Not: SELECT * çekiyoruz ki email ve fotograf_yolu gibi gizli veriler de güncellenmek üzere forma gitsin
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM doktorlar", bgl.baglanti());
                da.Fill(dt);
                gridControlUzmanlar.DataSource = dt;

                // ID sütununu kodla gizliyoruz
                if (gridView1.Columns["id"] != null)
                    gridView1.Columns["id"].Visible = false;

                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Liste yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void UzmanListesiForm_Load(object sender, EventArgs e)
        {
            Listele();

            // TASARIMSAL AYARLAR (Kodla garantiye alıyoruz)
            gridView1.OptionsBehavior.Editable = false; // Hücrelerin içine girmeyi/yazmayı kapatır
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false; // Sadece hücre değil, tüm satırı odaklar
        }

        // GÜNCELLE BUTONU: Seçili doktorun verilerini alıp kayıt formuna gönderir
       
        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0) return;

            string doktorId = gridView1.GetFocusedRowCellValue("id").ToString();
            string doktorAd = gridView1.GetFocusedRowCellValue("ad").ToString();
            string doktorSoyad = gridView1.GetFocusedRowCellValue("soyad").ToString();

            DialogResult onay = XtraMessageBox.Show(
                $"{doktorAd} {doktorSoyad} isimli uzmanı silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand komut = new MySqlCommand("DELETE FROM doktorlar WHERE id = @p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", doktorId);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();

                    XtraMessageBox.Show("Uzman sistemden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                }
                catch (MySqlException ex)
                {
                    // 1451 hatası: Yabancıl anahtar kısıtlaması (Doktorun randevusu varsa silinemez)
                    if (ex.Number == 1451)
                    {
                        XtraMessageBox.Show(
                            "Bu doktoru silemezsiniz! \n\nNedeni: Bu doktora ait kayıtlı randevular veya geçmiş veriler bulunmaktadır. Önce randevuları temizlemelisiniz.",
                            "Silme Engellendi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        XtraMessageBox.Show("Hata: " + ex.Message);
                    }
                }
                finally
                {
                    bgl.baglanti().Close();
                }
            }
        }

        private void btnYenile_Click_1(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            // Eğer bir satır seçiliyse
            if (gridView1.FocusedRowHandle >= 0)
            {
                // DoktorKayitForm'un bir örneğini oluşturuyoruz
                DoktorKayitForm frm = new DoktorKayitForm();

                // Grid'deki verileri formun public değişkenlerine aktarıyoruz
                frm.doktorId = gridView1.GetFocusedRowCellValue("id").ToString();
                frm.ad = gridView1.GetFocusedRowCellValue("ad").ToString();
                frm.soyad = gridView1.GetFocusedRowCellValue("soyad").ToString();
                frm.uzmanlik = gridView1.GetFocusedRowCellValue("uzmanlik").ToString();
                frm.telefon = gridView1.GetFocusedRowCellValue("telefon").ToString();
                frm.email = gridView1.GetFocusedRowCellValue("email").ToString();
                frm.fotografYolu = gridView1.GetFocusedRowCellValue("fotograf_yolu")?.ToString();

                // Formu açıyoruz
                frm.ShowDialog();

                // Form kapandıktan sonra yapılan değişiklikleri görmek için listeyi yeniliyoruz
                Listele();
            }
            else
            {
                XtraMessageBox.Show("Lütfen önce listeden bir uzman seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        

    }
}
}