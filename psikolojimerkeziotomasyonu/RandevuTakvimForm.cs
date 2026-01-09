using DevExpress.XtraScheduler;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace psikolojimerkeziotomasyonu
{
    public partial class RandevuTakvimForm : DevExpress.XtraEditors.XtraForm
    {
        string dbConnectionString = "Server=localhost;Database=psikolojimerkezi_db;Uid=root;Pwd=rabisko2016;";

        public RandevuTakvimForm()
        {
            InitializeComponent();
        }

        private void RandevuTakvimForm_Load(object sender, EventArgs e)
        {
            AjandaAyarlariniYap();
            RandevulariTakvimeYukle();
        }

        void AjandaAyarlariniYap()
        {
            dateNavigator1.SchedulerControl = schedulerControl1;
            schedulerControl1.Start = DateTime.Now;
            schedulerControl1.ActiveViewType = SchedulerViewType.WorkWeek;

            schedulerControl1.WorkWeekView.TimeSlots.Clear();
            schedulerControl1.WorkWeekView.TimeSlots.Add(new TimeSlot(TimeSpan.FromMinutes(30), "30 Dakika"));
        }

        void RandevulariTakvimeYukle()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(dbConnectionString))
                {
                    // Tablo yapınıza (randevu_tarih, randevu_saat, notlar) göre düzenlenmiş sorgu
                    string sql = @"SELECT r.id, 
                                   CONCAT(h.ad, ' ', h.soyad) as Subject, 
                                   ADDTIME(CAST(r.randevu_tarih AS DATETIME), r.randevu_saat) as StartTime, 
                                   DATE_ADD(ADDTIME(CAST(r.randevu_tarih AS DATETIME), r.randevu_saat), INTERVAL 1 HOUR) as EndTime, 
                                   r.notlar as Description
                                   FROM randevular r
                                   INNER JOIN hastalar h ON r.hasta_id = h.id";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // HATA ÇÖZÜMÜ: Clear() yerine eşleştirmeleri doğrudan üzerine yazarak güncelliyoruz
                    // Label ve Status eşleştirmelerini string.Empty yaparak hata vermelerini engelliyoruz
                    schedulerDataStorage1.Appointments.Mappings.AppointmentId = "id";
                    schedulerDataStorage1.Appointments.Mappings.Start = "StartTime";
                    schedulerDataStorage1.Appointments.Mappings.End = "EndTime";
                    schedulerDataStorage1.Appointments.Mappings.Subject = "Subject";
                    schedulerDataStorage1.Appointments.Mappings.Description = "Description";

                    // Bu iki satır "Label mapping" hatasını kesin olarak çözer
                    schedulerDataStorage1.Appointments.Mappings.Label = string.Empty;
                    schedulerDataStorage1.Appointments.Mappings.Status = string.Empty;

                    schedulerDataStorage1.Appointments.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Detayı: " + ex.Message);
            }
        }
    }
}