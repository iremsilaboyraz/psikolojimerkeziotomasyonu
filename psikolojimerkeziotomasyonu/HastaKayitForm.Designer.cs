namespace psikolojimerkeziotomasyonu
{
    partial class HastaKayitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaKayitForm));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            txtTelefon = new DevExpress.XtraEditors.TextEdit();
            txtTC = new DevExpress.XtraEditors.TextEdit();
            txtSoyad = new DevExpress.XtraEditors.TextEdit();
            txtAd = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            txt1 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            txt2 = new DevExpress.XtraLayout.LayoutControlItem();
            txt3 = new DevExpress.XtraLayout.LayoutControlItem();
            txt4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtTelefon.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTC.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSoyad.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem10).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnKaydet);
            layoutControl1.Controls.Add(txtTelefon);
            layoutControl1.Controls.Add(txtTC);
            layoutControl1.Controls.Add(txtSoyad);
            layoutControl1.Controls.Add(txtAd);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(496, 504, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(724, 340);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.ForeColor = System.Drawing.Color.Black;
            btnKaydet.Appearance.Options.UseForeColor = true;
            btnKaydet.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnKaydet.ImageOptions.Image");
            btnKaydet.Location = new System.Drawing.Point(278, 215);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new System.Drawing.Size(172, 36);
            btnKaydet.StyleController = layoutControl1;
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Hastaya Ait Kaydı Tamamla";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new System.Drawing.Point(263, 170);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            txtTelefon.Properties.MaskSettings.Set("mask", "(999) 999 99 99");
            txtTelefon.Size = new System.Drawing.Size(257, 20);
            txtTelefon.StyleController = layoutControl1;
            txtTelefon.TabIndex = 5;
            // 
            // txtTC
            // 
            txtTC.Location = new System.Drawing.Point(263, 136);
            txtTC.Name = "txtTC";
            txtTC.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            txtTC.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            txtTC.Properties.MaskSettings.Set("mask", "99999999999");
            txtTC.Properties.MaxLength = 11;
            txtTC.Size = new System.Drawing.Size(257, 20);
            txtTC.StyleController = layoutControl1;
            txtTC.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new System.Drawing.Point(263, 102);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new System.Drawing.Size(257, 20);
            txtSoyad.StyleController = layoutControl1;
            txtSoyad.TabIndex = 3;
            // 
            // txtAd
            // 
            txtAd.Location = new System.Drawing.Point(263, 68);
            txtAd.Name = "txtAd";
            txtAd.Size = new System.Drawing.Size(257, 20);
            txtAd.StyleController = layoutControl1;
            txtAd.TabIndex = 0;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { txt1, emptySpaceItem1, txt2, txt3, txt4, layoutControlItem1, emptySpaceItem2, emptySpaceItem3, emptySpaceItem4, emptySpaceItem5, emptySpaceItem6, emptySpaceItem7, emptySpaceItem8, emptySpaceItem9, emptySpaceItem10 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(724, 340);
            Root.TextVisible = false;
            // 
            // txt1
            // 
            txt1.Control = txtAd;
            txt1.Location = new System.Drawing.Point(172, 56);
            txt1.Name = "txt1";
            txt1.Size = new System.Drawing.Size(340, 24);
            txt1.Text = "HastaAdı:";
            txt1.TextSize = new System.Drawing.Size(67, 13);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new System.Drawing.Point(172, 243);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(340, 77);
            // 
            // txt2
            // 
            txt2.Control = txtSoyad;
            txt2.Location = new System.Drawing.Point(172, 90);
            txt2.Name = "txt2";
            txt2.Size = new System.Drawing.Size(340, 24);
            txt2.Text = "Hasta Soyadı:";
            txt2.TextSize = new System.Drawing.Size(67, 13);
            // 
            // txt3
            // 
            txt3.Control = txtTC;
            txt3.Location = new System.Drawing.Point(172, 124);
            txt3.Name = "txt3";
            txt3.Size = new System.Drawing.Size(340, 24);
            txt3.Text = "TC Kimlik No:";
            txt3.TextSize = new System.Drawing.Size(67, 13);
            // 
            // txt4
            // 
            txt4.Control = txtTelefon;
            txt4.Location = new System.Drawing.Point(172, 158);
            txt4.Name = "txt4";
            txt4.Size = new System.Drawing.Size(340, 24);
            txt4.Text = "Telefon No:";
            txt4.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = btnKaydet;
            layoutControlItem1.Location = new System.Drawing.Point(266, 203);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(176, 40);
            layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new System.Drawing.Size(172, 320);
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.Location = new System.Drawing.Point(512, 0);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new System.Drawing.Size(192, 320);
            // 
            // emptySpaceItem4
            // 
            emptySpaceItem4.Location = new System.Drawing.Point(172, 0);
            emptySpaceItem4.Name = "emptySpaceItem4";
            emptySpaceItem4.Size = new System.Drawing.Size(340, 56);
            // 
            // emptySpaceItem5
            // 
            emptySpaceItem5.Location = new System.Drawing.Point(172, 80);
            emptySpaceItem5.Name = "emptySpaceItem5";
            emptySpaceItem5.Size = new System.Drawing.Size(340, 10);
            // 
            // emptySpaceItem6
            // 
            emptySpaceItem6.Location = new System.Drawing.Point(172, 114);
            emptySpaceItem6.Name = "emptySpaceItem6";
            emptySpaceItem6.Size = new System.Drawing.Size(340, 10);
            // 
            // emptySpaceItem7
            // 
            emptySpaceItem7.Location = new System.Drawing.Point(172, 148);
            emptySpaceItem7.Name = "emptySpaceItem7";
            emptySpaceItem7.Size = new System.Drawing.Size(340, 10);
            // 
            // emptySpaceItem8
            // 
            emptySpaceItem8.Location = new System.Drawing.Point(172, 182);
            emptySpaceItem8.Name = "emptySpaceItem8";
            emptySpaceItem8.Size = new System.Drawing.Size(340, 21);
            // 
            // emptySpaceItem9
            // 
            emptySpaceItem9.Location = new System.Drawing.Point(172, 203);
            emptySpaceItem9.Name = "emptySpaceItem9";
            emptySpaceItem9.Size = new System.Drawing.Size(94, 40);
            // 
            // emptySpaceItem10
            // 
            emptySpaceItem10.Location = new System.Drawing.Point(442, 203);
            emptySpaceItem10.Name = "emptySpaceItem10";
            emptySpaceItem10.Size = new System.Drawing.Size(70, 40);
            // 
            // HastaKayitForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(724, 340);
            Controls.Add(layoutControl1);
            Name = "HastaKayitForm";
            Text = "HastaKayitForm";
            Load += HastaKayitForm_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtTelefon.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTC.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSoyad.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt2).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt3).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem9).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem10).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem txt1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private DevExpress.XtraEditors.TextEdit txtTC;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraLayout.LayoutControlItem txt2;
        private DevExpress.XtraLayout.LayoutControlItem txt3;
        private DevExpress.XtraLayout.LayoutControlItem txt4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
    }
}