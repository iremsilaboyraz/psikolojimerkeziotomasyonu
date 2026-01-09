using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using PsikolojiMerkeziOtomasyonu; // SqlBaglantisi sınıfının olduğu namespace
using System;
using System.Data;
using System.Windows.Forms;

namespace psikolojimerkeziotomasyonu
{
    public partial class HastaListesiForm : DevExpress.XtraEditors.XtraForm
    {
        public HastaListesiForm()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        // Veritabanındaki tüm hastaları çeken ve Grid'i dolduran metod
        void Listele()
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id, ad, soyad, tc_no, telefon FROM hastalar ORDER BY id DESC", bgl.baglanti());
                da.Fill(dt);
                gridControl1.DataSource = dt; // Formundaki GridControl'ün adının gridControl1 olduğundan emin ol

                // GridView sütun başlıklarını Türkçeleştirelim (Opsiyonel)
                gridView1.Columns["id"].Caption = "ID";
                gridView1.Columns["ad"].Caption = "Ad";
                gridView1.Columns["soyad"].Caption = "Soyad";
                gridView1.Columns["tc_no"].Caption = "TC Kimlik No";
                gridView1.Columns["telefon"].Caption = "Telefon";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Listeleme Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bgl.baglanti().Close();
            }
        }

        private void HastaListesiForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        // Listeyi Yenile butonu eklediysen bunun içine de Listele() yazabilirsin
        private void btnYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

      
      
    }
}