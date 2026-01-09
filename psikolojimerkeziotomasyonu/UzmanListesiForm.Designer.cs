namespace psikolojimerkeziotomasyonu
{
    partial class UzmanListesiForm
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
            gridControlUzmanlar = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            btnYenile = new DevExpress.XtraEditors.SimpleButton();
            btnSil = new DevExpress.XtraEditors.SimpleButton();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)gridControlUzmanlar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            SuspendLayout();
            // 
            // gridControlUzmanlar
            // 
            gridControlUzmanlar.Dock = System.Windows.Forms.DockStyle.Top;
            gridControlUzmanlar.Location = new System.Drawing.Point(0, 0);
            gridControlUzmanlar.MainView = gridView1;
            gridControlUzmanlar.Name = "gridControlUzmanlar";
            gridControlUzmanlar.Size = new System.Drawing.Size(781, 441);
            gridControlUzmanlar.TabIndex = 0;
            gridControlUzmanlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControlUzmanlar;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnGuncelle);
            layoutControl1.Controls.Add(btnYenile);
            layoutControl1.Controls.Add(btnSil);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 441);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(781, 58);
            layoutControl1.TabIndex = 1;
            layoutControl1.Text = "layoutControl1";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new System.Drawing.Point(516, 16);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new System.Drawing.Size(232, 28);
            btnGuncelle.StyleController = layoutControl1;
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Kişiyi Güncelle";
            btnGuncelle.Click += btnGuncelle_Click_1;
            // 
            // btnYenile
            // 
            btnYenile.Location = new System.Drawing.Point(252, 16);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new System.Drawing.Size(258, 28);
            btnYenile.StyleController = layoutControl1;
            btnYenile.TabIndex = 5;
            btnYenile.Text = "Yenile";
            btnYenile.Click += btnYenile_Click_1;
            // 
            // btnSil
            // 
            btnSil.Location = new System.Drawing.Point(16, 16);
            btnSil.Name = "btnSil";
            btnSil.Size = new System.Drawing.Size(230, 28);
            btnSil.StyleController = layoutControl1;
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click_1;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(764, 60);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = btnSil;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(236, 34);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = btnYenile;
            layoutControlItem2.Location = new System.Drawing.Point(236, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(264, 34);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = btnGuncelle;
            layoutControlItem3.Location = new System.Drawing.Point(500, 0);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(238, 34);
            layoutControlItem3.TextVisible = false;
            // 
            // UzmanListesiForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(781, 499);
            Controls.Add(layoutControl1);
            Controls.Add(gridControlUzmanlar);
            Name = "UzmanListesiForm";
            Text = "UzmanListesiForm";
            Load += UzmanListesiForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridControlUzmanlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlUzmanlar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}