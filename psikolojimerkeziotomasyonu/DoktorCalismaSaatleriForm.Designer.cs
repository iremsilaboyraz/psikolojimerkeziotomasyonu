namespace psikolojimerkeziotomasyonu
{
    partial class DoktorCalismaSaatleriForm
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
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            btnMesaiKaydet = new DevExpress.XtraEditors.SimpleButton();
            tseBitis = new DevExpress.XtraEditors.TimeSpanEdit();
            tseBaslangic = new DevExpress.XtraEditors.TimeSpanEdit();
            clbGunler = new DevExpress.XtraEditors.CheckedListBoxControl();
            lueDoktor = new DevExpress.XtraEditors.LookUpEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tseBitis.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tseBaslangic.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clbGunler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lueDoktor.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnMesaiKaydet);
            layoutControl1.Controls.Add(tseBitis);
            layoutControl1.Controls.Add(tseBaslangic);
            layoutControl1.Controls.Add(clbGunler);
            layoutControl1.Controls.Add(lueDoktor);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(470, 393, 650, 400);
            layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(733, 473);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // btnMesaiKaydet
            // 
            btnMesaiKaydet.Location = new System.Drawing.Point(184, 348);
            btnMesaiKaydet.Name = "btnMesaiKaydet";
            btnMesaiKaydet.Size = new System.Drawing.Size(337, 28);
            btnMesaiKaydet.StyleController = layoutControl1;
            btnMesaiKaydet.TabIndex = 5;
            btnMesaiKaydet.Text = "Kaydet";
            btnMesaiKaydet.Click += btnMesaiKaydet_Click;
            // 
            // tseBitis
            // 
            tseBitis.EditValue = System.TimeSpan.Parse("00:00:00");
            tseBitis.Location = new System.Drawing.Point(288, 314);
            tseBitis.Name = "tseBitis";
            tseBitis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            tseBitis.Size = new System.Drawing.Size(233, 28);
            tseBitis.StyleController = layoutControl1;
            tseBitis.TabIndex = 4;
            // 
            // tseBaslangic
            // 
            tseBaslangic.EditValue = System.TimeSpan.Parse("00:00:00");
            tseBaslangic.Location = new System.Drawing.Point(288, 280);
            tseBaslangic.Name = "tseBaslangic";
            tseBaslangic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            tseBaslangic.Size = new System.Drawing.Size(233, 28);
            tseBaslangic.StyleController = layoutControl1;
            tseBaslangic.TabIndex = 3;
            // 
            // clbGunler
            // 
            clbGunler.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] { new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Pazartesi"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Salı"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Çarşamba"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Perşembe"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Cuma"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Cumartesi"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Pazar") });
            clbGunler.Location = new System.Drawing.Point(184, 145);
            clbGunler.Name = "clbGunler";
            clbGunler.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            clbGunler.Size = new System.Drawing.Size(337, 129);
            clbGunler.StyleController = layoutControl1;
            clbGunler.TabIndex = 2;
            // 
            // lueDoktor
            // 
            lueDoktor.Location = new System.Drawing.Point(288, 111);
            lueDoktor.Name = "lueDoktor";
            lueDoktor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lueDoktor.Size = new System.Drawing.Size(233, 28);
            lueDoktor.StyleController = layoutControl1;
            lueDoktor.TabIndex = 0;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, emptySpaceItem2, emptySpaceItem3, emptySpaceItem4 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(733, 473);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = lueDoktor;
            layoutControlItem1.Location = new System.Drawing.Point(168, 95);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(343, 34);
            layoutControlItem1.Text = "Doktor Seçimi : ";
            layoutControlItem1.TextSize = new System.Drawing.Size(88, 13);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new System.Drawing.Point(168, 366);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(343, 81);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = clbGunler;
            layoutControlItem2.Location = new System.Drawing.Point(168, 129);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(343, 135);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = tseBaslangic;
            layoutControlItem3.Location = new System.Drawing.Point(168, 264);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(343, 34);
            layoutControlItem3.Text = "Mesai Başlangıç :";
            layoutControlItem3.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = tseBitis;
            layoutControlItem4.Location = new System.Drawing.Point(168, 298);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(343, 34);
            layoutControlItem4.Text = "Mesai Bitiş : ";
            layoutControlItem4.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = btnMesaiKaydet;
            layoutControlItem5.Location = new System.Drawing.Point(168, 332);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(343, 34);
            layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.Location = new System.Drawing.Point(168, 0);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new System.Drawing.Size(343, 95);
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new System.Drawing.Size(168, 447);
            // 
            // emptySpaceItem4
            // 
            emptySpaceItem4.Location = new System.Drawing.Point(511, 0);
            emptySpaceItem4.Name = "emptySpaceItem4";
            emptySpaceItem4.Size = new System.Drawing.Size(196, 447);
            // 
            // DoktorCalismaSaatleriForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(733, 473);
            Controls.Add(layoutControl1);
            Name = "DoktorCalismaSaatleriForm";
            Text = "DoktorCalismaSaatleriForm";
            Load += DoktorCalismaSaatleriForm_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tseBitis.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tseBaslangic.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)clbGunler).EndInit();
            ((System.ComponentModel.ISupportInitialize)lueDoktor.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnMesaiKaydet;
        private DevExpress.XtraEditors.TimeSpanEdit tseBitis;
        private DevExpress.XtraEditors.TimeSpanEdit tseBaslangic;
        private DevExpress.XtraEditors.CheckedListBoxControl clbGunler;
        private DevExpress.XtraEditors.LookUpEdit lueDoktor;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
    }
}