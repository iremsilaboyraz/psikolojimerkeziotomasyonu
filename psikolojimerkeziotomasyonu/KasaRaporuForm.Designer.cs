namespace psikolojimerkeziotomasyonu
{
    partial class KasaRaporuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasaRaporuForm));
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            btnSorgula = new DevExpress.XtraEditors.SimpleButton();
            deBitis = new DevExpress.XtraEditors.DateEdit();
            deBaslangic = new DevExpress.XtraEditors.DateEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            gcKasaRaporu = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            coltutar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)deBitis.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deBitis.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deBaslangic.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deBaslangic.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcKasaRaporu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(layoutControl1);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            groupControl1.Location = new System.Drawing.Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(734, 189);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "Gelir Sorgulama";
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnSorgula);
            layoutControl1.Controls.Add(deBitis);
            layoutControl1.Controls.Add(deBaslangic);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(2, 29);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(730, 158);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // btnSorgula
            // 
            btnSorgula.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSorgula.ImageOptions.Image");
            btnSorgula.Location = new System.Drawing.Point(16, 104);
            btnSorgula.Name = "btnSorgula";
            btnSorgula.Size = new System.Drawing.Size(698, 38);
            btnSorgula.StyleController = layoutControl1;
            btnSorgula.TabIndex = 3;
            btnSorgula.Text = "Sorgula";
            btnSorgula.Click += btnSorgula_Click;
            // 
            // deBitis
            // 
            deBitis.EditValue = null;
            deBitis.Location = new System.Drawing.Point(118, 50);
            deBitis.Name = "deBitis";
            deBitis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deBitis.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deBitis.Size = new System.Drawing.Size(596, 28);
            deBitis.StyleController = layoutControl1;
            deBitis.TabIndex = 2;
            // 
            // deBaslangic
            // 
            deBaslangic.EditValue = null;
            deBaslangic.Location = new System.Drawing.Point(118, 16);
            deBaslangic.Name = "deBaslangic";
            deBaslangic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deBaslangic.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deBaslangic.Size = new System.Drawing.Size(596, 28);
            deBaslangic.StyleController = layoutControl1;
            deBaslangic.TabIndex = 0;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, emptySpaceItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(730, 158);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = deBaslangic;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(704, 34);
            layoutControlItem1.Text = "Başlangıç Tarihi :";
            layoutControlItem1.TextSize = new System.Drawing.Size(86, 13);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = deBitis;
            layoutControlItem2.Location = new System.Drawing.Point(0, 34);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(704, 34);
            layoutControlItem2.Text = "Bitiş Tarihi : ";
            layoutControlItem2.TextSize = new System.Drawing.Size(86, 13);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = btnSorgula;
            layoutControlItem3.Location = new System.Drawing.Point(0, 88);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(704, 44);
            layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new System.Drawing.Point(0, 68);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(704, 20);
            // 
            // gcKasaRaporu
            // 
            gcKasaRaporu.Dock = System.Windows.Forms.DockStyle.Bottom;
            gcKasaRaporu.Location = new System.Drawing.Point(0, 187);
            gcKasaRaporu.MainView = gridView1;
            gcKasaRaporu.Name = "gcKasaRaporu";
            gcKasaRaporu.Size = new System.Drawing.Size(734, 275);
            gcKasaRaporu.TabIndex = 1;
            gcKasaRaporu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { coltutar });
            gridView1.GridControl = gcKasaRaporu;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowFooter = true;
            // 
            // coltutar
            // 
            coltutar.Caption = "Tutar";
            coltutar.FieldName = "tutar";
            coltutar.Name = "coltutar";
            coltutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tutar", "{0:c2}") });
            coltutar.Visible = true;
            coltutar.VisibleIndex = 0;
            // 
            // KasaRaporuForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(734, 462);
            Controls.Add(gcKasaRaporu);
            Controls.Add(groupControl1);
            Name = "KasaRaporuForm";
            Text = "KasaRaporuForm";
            Load += KasaRaporuForm_Load;
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)deBitis.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deBitis.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deBaslangic.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deBaslangic.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcKasaRaporu).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcKasaRaporu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coltutar;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnSorgula;
        private DevExpress.XtraEditors.DateEdit deBitis;
        private DevExpress.XtraEditors.DateEdit deBaslangic;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}