# 🧠 Psikoloji Merkezi Yönetim Sistemi

![License](https://img.shields.io/badge/license-MIT-blue.svg)
![Status](https://img.shields.io/badge/status-Geliştirme%20Aşamasında-orange)
![Platform](https://img.shields.io/badge/platform-Windows-lightgrey)

Bu proje, psikoloji kliniklerinin ve danışmanlık merkezlerinin günlük operasyonlarını dijitalleştirmek, danışan takibini kolaylaştırmak ve randevu süreçlerini optimize etmek amacıyla geliştirilmiş kapsamlı bir otomasyon sistemidir.

## 📋 İçindekiler
- [Proje Hakkında](#-proje-hakkında)
- [Özellikler](#-özellikler)
- [Ekran Görüntüleri](#-ekran-görüntüleri)
- [Kullanılan Teknolojiler](#-kullanılan-teknolojiler)
- [Kurulum](#-kurulum)
- [Veritabanı Yapısı](#-veritabanı-yapısı)
- [İletişim](#-iletişim)

## 🎯 Proje Hakkında
Geleneksel kağıt-kalem veya karmaşık Excel dosyaları yerine; psikologların danışan notlarını güvenle saklayabileceği, sekreteryanın randevuları çakışmadan yönetebileceği merkezi bir masaüstü uygulamasıdır.

## ✨ Özellikler

### 👥 Danışan Yönetimi
- Yeni danışan kaydı oluşturma ve düzenleme.
- Danışan geçmişi ve iletişim bilgilerini görüntüleme.

### 📅 Randevu Sistemi
- Dinamik takvim üzerinden randevu oluşturma.
- Randevu iptal ve erteleme işlemleri.
- Çakışma kontrolü (Aynı saate randevu verilmesini engelleme).

### 📝 Klinik Notlar (Önemli)
- Her seans için özel not ekleme ekranı.
- Geçmiş seans notlarına sadece yetkili doktorun erişimi.
- Tanı ve tedavi planı alanları.

### 📊 Raporlama
- Günlük/Aylık randevu yoğunluk grafikleri.
- Gelir/Gider takibi (Opsiyonel).

## 📷 Ekran Görüntüleri

| Giriş Ekranı | Ajanda | Admin Panel | Klinik Sayfa |
| :---: | :---: || :---: | :---: |
| ![Giriş Ekranı](resimler/giris.png) | ![Ajanda](resimler/ajanda.png) |![Admin Panel](resimler/admin.png) |![Klinik Sayfa](resimler/seans.png) |





## 💻 Kullanılan Teknolojiler

Bu proje aşağıdaki teknolojiler kullanılarak geliştirilmiştir:

* **Programlama Dili:** C#
* **Arayüz:** Windows Forms Application (WinForms) / WPF
* **Veritabanı:** Microsoft SQL Server
* **ORM:** Entity Framework / ADO.NET
* **IDE:** Visual Studio 2022

## ⚙️ Kurulum

Projeyi yerel makinenizde çalıştırmak için şu adımları izleyin:

1.  Projeyi klonlayın:
    ```bash
    git clone [https://github.com/iremsilaboyraz/psikolojimerkeziotomasyonu.git](https://github.com/iremsilaboyraz/psikolojimerkeziotomasyonu.git)
    ```
2.  `database.sql` dosyasını SQL Server'da çalıştırarak veritabanını oluşturun.
3.  `App.config` dosyasındaki **Connection String** (Bağlantı Yolu) bilgisini kendi sunucunuza göre güncelleyin.
4.  Visual Studio üzerinden projeyi açın ve **Start** tuşuna basın.

## 🗄️ Veritabanı Yapısı
Proje ilişkisel veritabanı yapısına sahiptir. Temel tablolar:
* `tbl_Danisanlar`
* `tbl_Doktorlar`
* `tbl_Randevular`
* `tbl_Notlar`

## 📧 İletişim

Geliştirici: **[İrem Sıla Boyraz]**
* LinkedIn: [https://www.linkedin.com/in/irem-sıla-boyraz-1b499a295/]
* E-posta: [iremsilaboyrazz@gmail.com]

---
⭐️ Bu projeyi beğendiyseniz yıldız vermeyi unutmayın!