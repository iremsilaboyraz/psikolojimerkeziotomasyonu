namespace psikolojimerkeziotomasyonu
{
    partial class YoneticiPanelForm
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Legend legend1 = new DevExpress.XtraCharts.Legend();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SplineAreaSeriesView splineAreaSeriesView1 = new DevExpress.XtraCharts.SplineAreaSeriesView();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            gridYaklasanRandevular = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            chartGelir = new DevExpress.XtraCharts.ChartControl();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            lblBekleyenOdemeler = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            lblBugunkuRandevu = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            panelControl4 = new DevExpress.XtraEditors.PanelControl();
            lblBugunkuKazanc = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridYaklasanRandevular).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGelir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xyDiagram1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)legend1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)series1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splineAreaSeriesView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
            panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl4).BeginInit();
            panelControl4.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(40, 50, 80);
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(1005, 80);
            panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            labelControl1.Location = new System.Drawing.Point(0, 0);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(293, 40);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Klinik Yönetim Paneli";
            // 
            // splitContainerControl1
            // 
            splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            splitContainerControl1.Location = new System.Drawing.Point(0, 157);
            splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            splitContainerControl1.Panel1.Controls.Add(groupControl1);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(groupControl2);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new System.Drawing.Size(1005, 432);
            splitContainerControl1.SplitterPosition = 494;
            splitContainerControl1.TabIndex = 2;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(gridYaklasanRandevular);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl1.Location = new System.Drawing.Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(494, 432);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "Yaklaşan Randevular";
            // 
            // gridYaklasanRandevular
            // 
            gridYaklasanRandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            gridYaklasanRandevular.Location = new System.Drawing.Point(2, 29);
            gridYaklasanRandevular.MainView = gridView1;
            gridYaklasanRandevular.Name = "gridYaklasanRandevular";
            gridYaklasanRandevular.Size = new System.Drawing.Size(490, 401);
            gridYaklasanRandevular.TabIndex = 0;
            gridYaklasanRandevular.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridYaklasanRandevular;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl2
            // 
            groupControl2.Controls.Add(chartGelir);
            groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl2.Location = new System.Drawing.Point(0, 0);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new System.Drawing.Size(495, 432);
            groupControl2.TabIndex = 0;
            groupControl2.Text = "Aylık Gelir Grafiği";
            // 
            // chartGelir
            // 
            chartGelir.BackColor = System.Drawing.Color.White;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 0D;
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 0D;
            xyDiagram1.AxisY.Interlaced = true;
            xyDiagram1.AxisY.MinorCount = 4;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            chartGelir.Diagram = xyDiagram1;
            chartGelir.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.LegendID = 0;
            legend1.Name = "Legend 1";
            chartGelir.Legends.AddRange(new DevExpress.XtraCharts.Legend[] { legend1 });
            chartGelir.Location = new System.Drawing.Point(2, 29);
            chartGelir.Name = "chartGelir";
            series1.CrosshairTextOptions.TextColor = System.Drawing.Color.Navy;
            series1.Name = "Series 1";
            series1.SeriesID = 6;
            splineAreaSeriesView1.EmptyPointOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
            series1.View = splineAreaSeriesView1;
            chartGelir.SeriesSerializable = new DevExpress.XtraCharts.Series[]
    {
    series1
    };
            chartGelir.SeriesTemplate.ArgumentDataMember = "Ay";
            chartGelir.SeriesTemplate.ValueDataMembersSerializable = "Toplam";
            chartGelir.Size = new System.Drawing.Size(491, 401);
            chartGelir.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(panelControl2, 2, 0);
            tableLayoutPanel1.Controls.Add(panelControl3, 0, 0);
            tableLayoutPanel1.Controls.Add(panelControl4, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1005, 77);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelControl2
            // 
            panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            panelControl2.Appearance.Options.UseBackColor = true;
            panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelControl2.Controls.Add(lblBekleyenOdemeler);
            panelControl2.Controls.Add(labelControl2);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl2.Location = new System.Drawing.Point(673, 3);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(329, 71);
            panelControl2.TabIndex = 6;
            // 
            // lblBekleyenOdemeler
            // 
            lblBekleyenOdemeler.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            lblBekleyenOdemeler.Appearance.ForeColor = System.Drawing.Color.Black;
            lblBekleyenOdemeler.Appearance.Options.UseFont = true;
            lblBekleyenOdemeler.Appearance.Options.UseForeColor = true;
            lblBekleyenOdemeler.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            lblBekleyenOdemeler.Location = new System.Drawing.Point(128, 35);
            lblBekleyenOdemeler.Name = "lblBekleyenOdemeler";
            lblBekleyenOdemeler.Size = new System.Drawing.Size(90, 39);
            lblBekleyenOdemeler.TabIndex = 2;
            lblBekleyenOdemeler.Text = "3.200";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            labelControl2.Appearance.ForeColor = System.Drawing.Color.Gray;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new System.Drawing.Point(119, 13);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(110, 16);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "Bekleyen Ödemeler";
            // 
            // panelControl3
            // 
            panelControl3.Appearance.BackColor = System.Drawing.Color.White;
            panelControl3.Appearance.Options.UseBackColor = true;
            panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelControl3.Controls.Add(lblBugunkuRandevu);
            panelControl3.Controls.Add(labelControl5);
            panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl3.Location = new System.Drawing.Point(3, 3);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new System.Drawing.Size(329, 71);
            panelControl3.TabIndex = 7;
            // 
            // lblBugunkuRandevu
            // 
            lblBugunkuRandevu.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            lblBugunkuRandevu.Appearance.ForeColor = System.Drawing.Color.Black;
            lblBugunkuRandevu.Appearance.Options.UseFont = true;
            lblBugunkuRandevu.Appearance.Options.UseForeColor = true;
            lblBugunkuRandevu.Appearance.Options.UseTextOptions = true;
            lblBugunkuRandevu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblBugunkuRandevu.Location = new System.Drawing.Point(138, 27);
            lblBugunkuRandevu.Name = "lblBugunkuRandevu";
            lblBugunkuRandevu.Size = new System.Drawing.Size(40, 39);
            lblBugunkuRandevu.TabIndex = 2;
            lblBugunkuRandevu.Text = "12";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            labelControl5.Appearance.ForeColor = System.Drawing.Color.Gray;
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Appearance.Options.UseForeColor = true;
            labelControl5.Appearance.Options.UseTextOptions = true;
            labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl5.Location = new System.Drawing.Point(105, 5);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(116, 16);
            labelControl5.TabIndex = 1;
            labelControl5.Text = "Bugünkü Randevular";
            // 
            // panelControl4
            // 
            panelControl4.Appearance.BackColor = System.Drawing.Color.White;
            panelControl4.Appearance.Options.UseBackColor = true;
            panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelControl4.Controls.Add(lblBugunkuKazanc);
            panelControl4.Controls.Add(labelControl7);
            panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl4.Location = new System.Drawing.Point(338, 3);
            panelControl4.Name = "panelControl4";
            panelControl4.Size = new System.Drawing.Size(329, 71);
            panelControl4.TabIndex = 8;
            // 
            // lblBugunkuKazanc
            // 
            lblBugunkuKazanc.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            lblBugunkuKazanc.Appearance.ForeColor = System.Drawing.Color.Black;
            lblBugunkuKazanc.Appearance.Options.UseFont = true;
            lblBugunkuKazanc.Appearance.Options.UseForeColor = true;
            lblBugunkuKazanc.Location = new System.Drawing.Point(126, 27);
            lblBugunkuKazanc.Name = "lblBugunkuKazanc";
            lblBugunkuKazanc.Size = new System.Drawing.Size(90, 39);
            lblBugunkuKazanc.TabIndex = 2;
            lblBugunkuKazanc.Text = "7.600";
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            labelControl7.Appearance.ForeColor = System.Drawing.Color.Gray;
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Appearance.Options.UseForeColor = true;
            labelControl7.Location = new System.Drawing.Point(124, 5);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new System.Drawing.Size(92, 16);
            labelControl7.TabIndex = 1;
            labelControl7.Text = "Bugünkü Kazanç";
            // 
            // YoneticiPanelForm
            // 
            Appearance.ForeColor = System.Drawing.Color.White;
            Appearance.Options.UseFont = true;
            Appearance.Options.UseForeColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1005, 589);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(splitContainerControl1);
            Controls.Add(panelControl1);
            Font = new System.Drawing.Font("Segoe UI", 8.25F);
            Name = "YoneticiPanelForm";
            Text = "YoneticiPanelForm";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += YoneticiPanelForm_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridYaklasanRandevular).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)xyDiagram1).EndInit();
            ((System.ComponentModel.ISupportInitialize)legend1).EndInit();
            ((System.ComponentModel.ISupportInitialize)splineAreaSeriesView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)series1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartGelir).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
            panelControl3.ResumeLayout(false);
            panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl4).EndInit();
            panelControl4.ResumeLayout(false);
            panelControl4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridYaklasanRandevular;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraCharts.ChartControl chartGelir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lblBekleyenOdemeler;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl lblBugunkuRandevu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl lblBugunkuKazanc;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}