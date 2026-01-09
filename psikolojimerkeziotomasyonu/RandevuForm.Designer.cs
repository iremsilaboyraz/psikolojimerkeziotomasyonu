namespace psikolojimerkeziotomasyonu
{
    partial class RandevuForm
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
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            meNotlar = new DevExpress.XtraEditors.MemoEdit();
            txtUcret = new DevExpress.XtraEditors.TextEdit();
            teSaat = new DevExpress.XtraEditors.TimeEdit();
            deTarih = new DevExpress.XtraEditors.DateEdit();
            lueSeansTur = new DevExpress.XtraEditors.LookUpEdit();
            lueDoktor = new DevExpress.XtraEditors.LookUpEdit();
            slueHasta = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            Hasta = new DevExpress.XtraGrid.Columns.GridColumn();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            NOT = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)meNotlar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUcret.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teSaat.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deTarih.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deTarih.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lueSeansTur.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lueDoktor.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slueHasta.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NOT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnKaydet);
            layoutControl1.Controls.Add(meNotlar);
            layoutControl1.Controls.Add(txtUcret);
            layoutControl1.Controls.Add(teSaat);
            layoutControl1.Controls.Add(deTarih);
            layoutControl1.Controls.Add(lueSeansTur);
            layoutControl1.Controls.Add(lueDoktor);
            layoutControl1.Controls.Add(slueHasta);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(787, 76, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(588, 335);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new System.Drawing.Point(385, 291);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new System.Drawing.Size(58, 28);
            btnKaydet.StyleController = layoutControl1;
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // meNotlar
            // 
            meNotlar.Location = new System.Drawing.Point(237, 230);
            meNotlar.Name = "meNotlar";
            meNotlar.Size = new System.Drawing.Size(142, 89);
            meNotlar.StyleController = layoutControl1;
            meNotlar.TabIndex = 7;
            // 
            // txtUcret
            // 
            txtUcret.Location = new System.Drawing.Point(237, 186);
            txtUcret.Name = "txtUcret";
            txtUcret.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtUcret.Size = new System.Drawing.Size(206, 28);
            txtUcret.StyleController = layoutControl1;
            txtUcret.TabIndex = 6;
            // 
            // teSaat
            // 
            teSaat.EditValue = new System.DateTime(2026, 1, 4, 0, 0, 0, 0);
            teSaat.Location = new System.Drawing.Point(237, 152);
            teSaat.Name = "teSaat";
            teSaat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            teSaat.Properties.MaskSettings.Set("mask", "t");
            teSaat.Size = new System.Drawing.Size(206, 28);
            teSaat.StyleController = layoutControl1;
            teSaat.TabIndex = 5;
            // 
            // deTarih
            // 
            deTarih.EditValue = null;
            deTarih.Location = new System.Drawing.Point(237, 118);
            deTarih.Name = "deTarih";
            deTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deTarih.Properties.NullDate = new System.DateTime(2026, 1, 4, 18, 6, 28, 412);
            deTarih.Size = new System.Drawing.Size(206, 28);
            deTarih.StyleController = layoutControl1;
            deTarih.TabIndex = 4;
            // 
            // lueSeansTur
            // 
            lueSeansTur.Location = new System.Drawing.Point(237, 84);
            lueSeansTur.Name = "lueSeansTur";
            lueSeansTur.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lueSeansTur.Properties.NullText = "Lütfen seçiniz...";
            lueSeansTur.Size = new System.Drawing.Size(206, 28);
            lueSeansTur.StyleController = layoutControl1;
            lueSeansTur.TabIndex = 3;
            // 
            // lueDoktor
            // 
            lueDoktor.Location = new System.Drawing.Point(237, 50);
            lueDoktor.Name = "lueDoktor";
            lueDoktor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lueDoktor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Doktor", "Doktor Adı") });
            lueDoktor.Properties.NullText = "Lütfen seçiniz...";
            lueDoktor.Size = new System.Drawing.Size(206, 28);
            lueDoktor.StyleController = layoutControl1;
            lueDoktor.TabIndex = 2;
            // 
            // slueHasta
            // 
            slueHasta.Location = new System.Drawing.Point(237, 16);
            slueHasta.Name = "slueHasta";
            slueHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            slueHasta.Properties.NullText = "Lütfen seçiniz...";
            slueHasta.Properties.PopupView = searchLookUpEdit1View;
            slueHasta.Size = new System.Drawing.Size(206, 28);
            slueHasta.StyleController = layoutControl1;
            slueHasta.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { Hasta });
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Hasta
            // 
            Hasta.Caption = "Hasta Adı";
            Hasta.FieldName = "Hasta";
            Hasta.Name = "Hasta";
            Hasta.Visible = true;
            Hasta.VisibleIndex = 0;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6, NOT, layoutControlItem7, emptySpaceItem3, emptySpaceItem4, emptySpaceItem2 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(588, 335);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = slueHasta;
            layoutControlItem1.Location = new System.Drawing.Point(125, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(308, 34);
            layoutControlItem1.Text = "Hasta Seçimi : ";
            layoutControlItem1.TextSize = new System.Drawing.Size(80, 13);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new System.Drawing.Point(369, 214);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(64, 61);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = lueDoktor;
            layoutControlItem2.Location = new System.Drawing.Point(125, 34);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(308, 34);
            layoutControlItem2.Text = "Doktor Seçimi : ";
            layoutControlItem2.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = lueSeansTur;
            layoutControlItem3.Location = new System.Drawing.Point(125, 68);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(308, 34);
            layoutControlItem3.Text = "Hizmet Türü : ";
            layoutControlItem3.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = deTarih;
            layoutControlItem4.Location = new System.Drawing.Point(125, 102);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(308, 34);
            layoutControlItem4.Text = "Tarih : ";
            layoutControlItem4.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = teSaat;
            layoutControlItem5.Location = new System.Drawing.Point(125, 136);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(308, 34);
            layoutControlItem5.Text = "Saat : ";
            layoutControlItem5.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = txtUcret;
            layoutControlItem6.Location = new System.Drawing.Point(125, 170);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new System.Drawing.Size(308, 34);
            layoutControlItem6.Text = "Ücret : ";
            layoutControlItem6.TextSize = new System.Drawing.Size(80, 13);
            // 
            // NOT
            // 
            NOT.Control = meNotlar;
            NOT.Location = new System.Drawing.Point(125, 214);
            NOT.Name = "NOT";
            NOT.Size = new System.Drawing.Size(244, 95);
            NOT.Text = "NOT : ";
            NOT.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = btnKaydet;
            layoutControlItem7.Location = new System.Drawing.Point(369, 275);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new System.Drawing.Size(64, 34);
            layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.Location = new System.Drawing.Point(125, 204);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new System.Drawing.Size(308, 10);
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.Location = new System.Drawing.Point(433, 0);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new System.Drawing.Size(129, 309);
            // 
            // emptySpaceItem4
            // 
            emptySpaceItem4.Location = new System.Drawing.Point(0, 0);
            emptySpaceItem4.Name = "emptySpaceItem4";
            emptySpaceItem4.Size = new System.Drawing.Size(125, 309);
            // 
            // RandevuForm
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(588, 335);
            Controls.Add(layoutControl1);
            Name = "RandevuForm";
            Text = "Randevu Oluştur";
            Load += RandevuForm_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)meNotlar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUcret.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)teSaat.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deTarih.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deTarih.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lueSeansTur.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lueDoktor.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)slueHasta.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)NOT).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtUcret;
        private DevExpress.XtraEditors.TimeEdit teSaat;
        private DevExpress.XtraEditors.DateEdit deTarih;
        private DevExpress.XtraEditors.LookUpEdit lueSeansTur;
        private DevExpress.XtraEditors.LookUpEdit lueDoktor;
        private DevExpress.XtraEditors.SearchLookUpEdit slueHasta;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.MemoEdit meNotlar;
        private DevExpress.XtraLayout.LayoutControlItem NOT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn Hasta;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}