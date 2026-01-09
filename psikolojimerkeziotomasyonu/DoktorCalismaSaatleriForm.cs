using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace psikolojimerkeziotomasyonu
{
    public partial class DoktorCalismaSaatleriForm : DevExpress.XtraEditors.XtraForm
    {
        string dbConnectionString = "Server=localhost;Database=psikolojimerkezi_db;Uid=root;Pwd=rabisko2016;";

        public DoktorCalismaSaatleriForm()
        {
            InitializeComponent();
        }

        private void DoktorCalismaSaatleriForm_Load(object sender, EventArgs e)
        {
            DoktorlariYukle();
        }

        void DoktorlariYukle()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(dbConnectionString))
                {
                    string sql = "SELECT id, CONCAT(ad, ' ', soyad) as adsoyad FROM doktorlar";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    lueDoktor.Properties.DataSource = dt;
                    lueDoktor.Properties.DisplayMember = "adsoyad";
                    lueDoktor.Properties.ValueMember = "id";
                }
            }
            catch (Exception ex) { XtraMessageBox.Show("Doktorlar yüklenemedi: " + ex.Message); }
        }

        private void btnMesaiKaydet_Click(object sender, EventArgs e)
        {
            if (lueDoktor.EditValue == null || clbGunler.CheckedItems.Count == 0)
            {
                XtraMessageBox.Show("Lütfen doktor ve en az bir gün seçin!");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(dbConnectionString))
                {
                    conn.Open();
                    foreach (var item in clbGunler.CheckedItems)
                    {
                        // Önce varsa eski kaydı silelim (Güncelleme mantığı)
                        string deleteSql = "DELETE FROM doktor_calisma_saatleri WHERE doktor_id=@dId AND gun=@gun";
                        MySqlCommand delCmd = new MySqlCommand(deleteSql, conn);
                        delCmd.Parameters.AddWithValue("@dId", lueDoktor.EditValue);
                        delCmd.Parameters.AddWithValue("@gun", item.ToString());
                        delCmd.ExecuteNonQuery();

                        // Yeni mesaiyi kaydedelim
                        string insertSql = @"INSERT INTO doktor_calisma_saatleri (doktor_id, gun, baslangic_saat, bitis_saat) 
                                           VALUES (@dId, @gun, @bas, @bit)";
                        MySqlCommand insCmd = new MySqlCommand(insertSql, conn);
                        insCmd.Parameters.AddWithValue("@dId", lueDoktor.EditValue);
                        insCmd.Parameters.AddWithValue("@gun", item.ToString());
                        insCmd.Parameters.AddWithValue("@bas", tseBaslangic.Time.TimeOfDay);
                        insCmd.Parameters.AddWithValue("@bit", tseBitis.Time.TimeOfDay);
                        insCmd.ExecuteNonQuery();
                    }
                }
                XtraMessageBox.Show("Çalışma saatleri başarıyla kaydedildi.");
            }
            catch (Exception ex) { XtraMessageBox.Show("Hata: " + ex.Message); }
        }
    }
}