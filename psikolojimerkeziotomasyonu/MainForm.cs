using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace psikolojimerkeziotomasyonu
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        // Merkezi Form Açma Metodu
        void FormuAc(Form frm)
        {
            bool durum = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == frm.Name)
                {
                    durum = true;
                    form.Activate();
                }
            }

            if (durum == false)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {// Eğer kullanıcı formu manuel olarak (X tuşuyla) kapatıyorsa uygulamayı bitir
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            // Global sınıftan rolü alıyoruz
            string rol = KullaniciOturumu.Rol;

            // --- YETKİLENDİRME MANTIĞI ---

            // 1. DOKTOR (D) Kısıtlamaları: Sadece Klinik İşlemleri görebilir.
            if (rol == "Doktor")
            {
                ribbonPageHasta.Visible = false;   // Hasta İşlemleri gizle
                ribbonPageRandevu.Visible = false; // Randevu Yönetimi gizle
                ribbonPageUzman.Visible = false;   // Uzman Yönetimi gizle
                ribbonPageSaatler.Visible = false; // Çalışma Saatleri gizle
                ribbonPageMali.Visible = false;    // Mali İşlemler gizle
                ribbonPageAdmin.Visible = false;   // Yönetici Paneli gizle

                // Klinik İşlemler (ribbonPageKlinik) açık kalır.
            }

            // 2. SEKRETER (S) Kısıtlamaları: Klinik, Mali ve Admin panellerini göremez.
            if (rol == "Sekreter")
            {
                ribbonPageKlinik.Visible = false; // Klinik İşlemler gizle
                ribbonPageMali.Visible = false;   // Mali İşlemler gizle
                ribbonPageAdmin.Visible = false;  // Yönetici Paneli gizle

                // Hasta, Randevu, Uzman ve Saatler sekmeleri açık kalır.
            }

            // 3. ADMIN (A) Kontrolü: Her şeyi görebilir.
            if (rol == "Admin")
            {
                // Admin her yeri gördüğü için ek bir gizleme yapmıyoruz.
                // Tüm sekmelerin Visible değeri True kalır.
            }

            // Bilgi başlığı güncelleme
            this.Text = "Psikoloji Merkezi Otomasyonu - " + KullaniciOturumu.AdSoyad + " (" + rol + ")";
        }

        // --- BUTON OLAYLARI ---

        private void btnHastaKayit_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            FormuAc(new HastaKayitForm());
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormuAc(new HastaListesiForm());
        }

        private void btnHastaSeansDetay_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormuAc(new HastaDetayForm());
        }

        private void btnDoktorTanimlama_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormuAc(new DoktorKayitForm());
        }

        private void btnRandevuOlustur_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormuAc(new RandevuForm());
        }

        private void btnAjanda_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormuAc(new RandevuTakvimForm());
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormuAc(new OdemeForm());
        }

        private void btnYoneticiPanel_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormuAc(new YoneticiPanelForm());
        }

        private void btnDoktorCalismaSaatleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormuAc(new DoktorCalismaSaatleriForm());
        }

        private void btnSeansUcretTanim_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormuAc(new SeansTanimForm());
        }

        private void btnGelirAnalizi_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormuAc(new KasaRaporuForm());
        }

        private void btnDoktorSil_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormuAc(new UzmanListesiForm());
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            // Kullanıcıya emin olup olmadığını soralım (Profesyonel bir dokunuş)
            DialogResult secim = DevExpress.XtraEditors.XtraMessageBox.Show(
                "Oturumu kapatmak istediğinize emin misiniz?",
                "Oturum Kapatılıyor",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (secim == DialogResult.Yes)
            {
                // 1. Global oturum verilerini temizle (Güvenlik için önemli)
                KullaniciOturumu.KullaniciId = 0;
                KullaniciOturumu.AdSoyad = string.Empty;
                KullaniciOturumu.Rol = string.Empty;

                // 2. Login formunu bul ve göster
                // Not: Projendeki login formunun isminin 'LoginForm' olduğunu varsayıyoruz.
                LoginForm frmGiris = new LoginForm();
                frmGiris.Show();

                // 3. Mevcut MainForm'u kapat (Application.Exit kullanma, sadece bu formu kapat)
                // Eğer MainForm_FormClosing olayında Application.Exit varsa, 
                // o olayı tetiklememesi için önce olayı devre dışı bırakabilir veya kodu buna göre güncelleyebiliriz.
                this.Hide();
                this.Dispose(); // Kaynakları serbest bırak
            }
        }

        private void picArkaplan_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}