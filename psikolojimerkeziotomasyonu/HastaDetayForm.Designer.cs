namespace psikolojimerkeziotomasyonu
{
    partial class HastaDetayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaDetayForm));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
            sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            label1 = new System.Windows.Forms.Label();
            trackBarControl1 = new DevExpress.XtraEditors.TrackBarControl();
            chartControl1 = new DevExpress.XtraCharts.ChartControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            lblSonRandevu = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            lblHastaId = new DevExpress.XtraEditors.LabelControl();
            label2 = new System.Windows.Forms.Label();
            slueHastaSec = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            lblHastaAdi = new DevExpress.XtraEditors.LabelControl();
            navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listBoxControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)navigationFrame1).BeginInit();
            navigationFrame1.SuspendLayout();
            navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarControl1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xyDiagram1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)series1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splineSeriesView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slueHastaSec.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            SuspendLayout();
            // 
            // sidePanel1
            // 
            sidePanel1.Appearance.BorderColor = System.Drawing.Color.Silver;
            sidePanel1.Appearance.Options.UseBorderColor = true;
            sidePanel1.Controls.Add(listBoxControl1);
            sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            sidePanel1.Location = new System.Drawing.Point(0, 0);
            sidePanel1.Name = "sidePanel1";
            sidePanel1.Size = new System.Drawing.Size(185, 592);
            sidePanel1.TabIndex = 0;
            sidePanel1.Text = "sidePanel1";
            // 
            // listBoxControl1
            // 
            listBoxControl1.Appearance.BorderColor = System.Drawing.Color.Gray;
            listBoxControl1.Appearance.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            listBoxControl1.Appearance.Options.UseBorderColor = true;
            listBoxControl1.Appearance.Options.UseFont = true;
            listBoxControl1.AppearanceDisabled.BorderColor = System.Drawing.Color.Black;
            listBoxControl1.AppearanceDisabled.Options.UseBorderColor = true;
            listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            listBoxControl1.HotTrackItems = true;
            listBoxControl1.ItemHeight = 35;
            listBoxControl1.Items.AddRange(new object[] { "15.12.2025 - Seans 1", "01.01.2026 - Seans 2" });
            listBoxControl1.Location = new System.Drawing.Point(0, 0);
            listBoxControl1.Name = "listBoxControl1";
            listBoxControl1.Size = new System.Drawing.Size(184, 592);
            listBoxControl1.TabIndex = 0;
            listBoxControl1.SelectedIndexChanged += listBoxControl1_SelectedIndexChanged;
            // 
            // navigationFrame1
            // 
            navigationFrame1.Controls.Add(navigationPage1);
            navigationFrame1.Controls.Add(navigationPage2);
            navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            navigationFrame1.Location = new System.Drawing.Point(185, 0);
            navigationFrame1.Name = "navigationFrame1";
            navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] { navigationPage1, navigationPage2 });
            navigationFrame1.SelectedPage = navigationPage1;
            navigationFrame1.Size = new System.Drawing.Size(822, 592);
            navigationFrame1.TabIndex = 1;
            navigationFrame1.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            navigationPage1.Caption = "navigationPage1";
            navigationPage1.Controls.Add(splitContainerControl1);
            navigationPage1.Controls.Add(panelControl1);
            navigationPage1.Name = "navigationPage1";
            navigationPage1.Size = new System.Drawing.Size(822, 592);
            // 
            // splitContainerControl1
            // 
            splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainerControl1.Location = new System.Drawing.Point(0, 102);
            splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            splitContainerControl1.Panel1.Controls.Add(groupControl1);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(btnKaydet);
            splitContainerControl1.Panel2.Controls.Add(label1);
            splitContainerControl1.Panel2.Controls.Add(trackBarControl1);
            splitContainerControl1.Panel2.Controls.Add(chartControl1);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new System.Drawing.Size(822, 490);
            splitContainerControl1.SplitterPosition = 293;
            splitContainerControl1.TabIndex = 1;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(memoEdit1);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl1.Location = new System.Drawing.Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(293, 490);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "Seans Notları";
            // 
            // memoEdit1
            // 
            memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            memoEdit1.Location = new System.Drawing.Point(2, 29);
            memoEdit1.Name = "memoEdit1";
            memoEdit1.Properties.NullText = "Bu seansa dair klinik gözlemlerinizi buraya yazın...";
            memoEdit1.Size = new System.Drawing.Size(289, 459);
            memoEdit1.TabIndex = 0;
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.BackColor = System.Drawing.SystemColors.InactiveBorder;
            btnKaydet.Appearance.ForeColor = System.Drawing.Color.Black;
            btnKaydet.Appearance.Options.UseBackColor = true;
            btnKaydet.Appearance.Options.UseForeColor = true;
            btnKaydet.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnKaydet.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnKaydet.ImageOptions.Image");
            btnKaydet.Location = new System.Drawing.Point(0, 107);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new System.Drawing.Size(513, 33);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Seansı Kaydet / Güncelle";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(0, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(283, 13);
            label1.TabIndex = 3;
            label1.Text = "Hastanın gelişim durumu hakkında puanlama yapınız.\r\n";
            // 
            // trackBarControl1
            // 
            trackBarControl1.EditValue = null;
            trackBarControl1.Location = new System.Drawing.Point(0, 70);
            trackBarControl1.Name = "trackBarControl1";
            trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = true;
            trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarControl1.Size = new System.Drawing.Size(458, 45);
            trackBarControl1.TabIndex = 2;
            // 
            // chartControl1
            // 
            chartControl1.BorderOptions.Color = System.Drawing.Color.White;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            chartControl1.Diagram = xyDiagram1;
            chartControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            chartControl1.Location = new System.Drawing.Point(0, 140);
            chartControl1.Name = "chartControl1";
            series1.Name = "Series 1";
            series1.SeriesID = 0;
            series1.View = splineSeriesView1;
            chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[]
    {
    series1
    };
            chartControl1.Size = new System.Drawing.Size(513, 350);
            chartControl1.TabIndex = 1;
            // 
            // panelControl1
            // 
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl1.Controls.Add(lblSonRandevu);
            panelControl1.Controls.Add(labelControl3);
            panelControl1.Controls.Add(lblHastaId);
            panelControl1.Controls.Add(label2);
            panelControl1.Controls.Add(slueHastaSec);
            panelControl1.Controls.Add(labelControl2);
            panelControl1.Controls.Add(lblHastaAdi);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(822, 102);
            panelControl1.TabIndex = 0;
            // 
            // lblSonRandevu
            // 
            lblSonRandevu.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            lblSonRandevu.Appearance.ForeColor = System.Drawing.Color.Gray;
            lblSonRandevu.Appearance.Options.UseFont = true;
            lblSonRandevu.Appearance.Options.UseForeColor = true;
            lblSonRandevu.Location = new System.Drawing.Point(77, 81);
            lblSonRandevu.Name = "lblSonRandevu";
            lblSonRandevu.Size = new System.Drawing.Size(64, 14);
            lblSonRandevu.TabIndex = 6;
            lblSonRandevu.Text = "10.01.2026";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            labelControl3.Appearance.ForeColor = System.Drawing.Color.Gray;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new System.Drawing.Point(6, 81);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(65, 14);
            labelControl3.TabIndex = 5;
            labelControl3.Text = "Son Seans: ";
            // 
            // lblHastaId
            // 
            lblHastaId.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            lblHastaId.Appearance.ForeColor = System.Drawing.Color.Gray;
            lblHastaId.Appearance.Options.UseFont = true;
            lblHastaId.Appearance.Options.UseForeColor = true;
            lblHastaId.Location = new System.Drawing.Point(62, 61);
            lblHastaId.Name = "lblHastaId";
            lblHastaId.Size = new System.Drawing.Size(37, 14);
            lblHastaId.TabIndex = 4;
            lblHastaId.Text = "#4521";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(481, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(142, 13);
            label2.TabIndex = 3;
            label2.Text = "Listeden hastanızı seçiniz: ";
            // 
            // slueHastaSec
            // 
            slueHastaSec.Location = new System.Drawing.Point(620, 3);
            slueHastaSec.Name = "slueHastaSec";
            slueHastaSec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            slueHastaSec.Properties.PopupView = searchLookUpEdit1View;
            slueHastaSec.Size = new System.Drawing.Size(199, 28);
            slueHastaSec.TabIndex = 2;
            slueHastaSec.EditValueChanged += slueHastaSec_EditValueChanged;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            labelControl2.Appearance.ForeColor = System.Drawing.Color.Gray;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new System.Drawing.Point(6, 61);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(50, 14);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "Hasta ID: \r\n";
            // 
            // lblHastaAdi
            // 
            lblHastaAdi.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            lblHastaAdi.Appearance.Options.UseFont = true;
            lblHastaAdi.Location = new System.Drawing.Point(6, 32);
            lblHastaAdi.Name = "lblHastaAdi";
            lblHastaAdi.Size = new System.Drawing.Size(147, 23);
            lblHastaAdi.TabIndex = 0;
            lblHastaAdi.Text = "Mehmet Yılmaz";
            // 
            // navigationPage2
            // 
            navigationPage2.Caption = "navigationPage2";
            navigationPage2.Name = "navigationPage2";
            navigationPage2.Size = new System.Drawing.Size(822, 592);
            // 
            // HastaDetayForm
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1007, 592);
            Controls.Add(navigationFrame1);
            Controls.Add(sidePanel1);
            Name = "HastaDetayForm";
            Text = "Hasta Seans Detayları ve Gelişim Takibi";
            Load += HastaDetayForm_Load;
            sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listBoxControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)navigationFrame1).EndInit();
            navigationFrame1.ResumeLayout(false);
            navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            splitContainerControl1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarControl1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)xyDiagram1).EndInit();
            ((System.ComponentModel.ISupportInitialize)splineSeriesView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)series1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)slueHastaSec.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblHastaAdi;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.TrackBarControl trackBarControl1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit slueHastaSec;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LabelControl lblHastaId;
        private DevExpress.XtraEditors.LabelControl lblSonRandevu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}