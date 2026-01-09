namespace psikolojimerkeziotomasyonu
{
    partial class OdemeForm
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
            btnOdemeTamamla = new DevExpress.XtraEditors.SimpleButton();
            txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            cmbOdemeYontemi = new DevExpress.XtraEditors.ComboBoxEdit();
            txtTutar = new DevExpress.XtraEditors.TextEdit();
            glueRandevu = new DevExpress.XtraEditors.GridLookUpEdit();
            gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAciklama.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbOdemeYontemi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTutar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)glueRandevu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnOdemeTamamla);
            layoutControl1.Controls.Add(txtAciklama);
            layoutControl1.Controls.Add(cmbOdemeYontemi);
            layoutControl1.Controls.Add(txtTutar);
            layoutControl1.Controls.Add(glueRandevu);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(668, 254, 650, 400);
            layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(655, 375);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // btnOdemeTamamla
            // 
            btnOdemeTamamla.Location = new System.Drawing.Point(259, 331);
            btnOdemeTamamla.Name = "btnOdemeTamamla";
            btnOdemeTamamla.Size = new System.Drawing.Size(148, 28);
            btnOdemeTamamla.StyleController = layoutControl1;
            btnOdemeTamamla.TabIndex = 5;
            btnOdemeTamamla.Text = "Ödemeyi Tamamla";
            btnOdemeTamamla.Click += btnOdemeTamamla_Click;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new System.Drawing.Point(220, 118);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new System.Drawing.Size(211, 207);
            txtAciklama.StyleController = layoutControl1;
            txtAciklama.TabIndex = 4;
            // 
            // cmbOdemeYontemi
            // 
            cmbOdemeYontemi.EditValue = "Lütfen seçiniz...";
            cmbOdemeYontemi.Location = new System.Drawing.Point(220, 84);
            cmbOdemeYontemi.Name = "cmbOdemeYontemi";
            cmbOdemeYontemi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbOdemeYontemi.Size = new System.Drawing.Size(321, 28);
            cmbOdemeYontemi.StyleController = layoutControl1;
            cmbOdemeYontemi.TabIndex = 3;
            // 
            // txtTutar
            // 
            txtTutar.Location = new System.Drawing.Point(220, 50);
            txtTutar.Name = "txtTutar";
            txtTutar.Properties.ReadOnly = true;
            txtTutar.Size = new System.Drawing.Size(321, 28);
            txtTutar.StyleController = layoutControl1;
            txtTutar.TabIndex = 2;
            // 
            // glueRandevu
            // 
            glueRandevu.Location = new System.Drawing.Point(220, 16);
            glueRandevu.Name = "glueRandevu";
            glueRandevu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            glueRandevu.Properties.NullText = "Lütfen seçiniz...";
            glueRandevu.Properties.PopupView = gridLookUpEdit1View;
            glueRandevu.Size = new System.Drawing.Size(321, 28);
            glueRandevu.StyleController = layoutControl1;
            glueRandevu.TabIndex = 0;
            glueRandevu.EditValueChanged += glueRandevu_EditValueChanged;
            glueRandevu.Click += glueRandevu_EditValueChanged;
            // 
            // gridLookUpEdit1View
            // 
            gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, emptySpaceItem2, emptySpaceItem3, emptySpaceItem4, emptySpaceItem5 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(655, 375);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = glueRandevu;
            layoutControlItem1.Location = new System.Drawing.Point(99, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(432, 34);
            layoutControlItem1.Text = "Randevu Seçimi : ";
            layoutControlItem1.TextSize = new System.Drawing.Size(89, 13);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new System.Drawing.Point(397, 315);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(134, 34);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = txtTutar;
            layoutControlItem2.Location = new System.Drawing.Point(99, 34);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(432, 34);
            layoutControlItem2.Text = "Tutar : ";
            layoutControlItem2.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = cmbOdemeYontemi;
            layoutControlItem3.Location = new System.Drawing.Point(99, 68);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(432, 34);
            layoutControlItem3.Text = "Ödeme Yöntemi :";
            layoutControlItem3.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = txtAciklama;
            layoutControlItem4.Location = new System.Drawing.Point(99, 102);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(322, 213);
            layoutControlItem4.Text = "Açıklama : ";
            layoutControlItem4.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = btnOdemeTamamla;
            layoutControlItem5.Location = new System.Drawing.Point(243, 315);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(154, 34);
            layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new System.Drawing.Size(99, 349);
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.Location = new System.Drawing.Point(531, 0);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new System.Drawing.Size(98, 349);
            // 
            // emptySpaceItem4
            // 
            emptySpaceItem4.Location = new System.Drawing.Point(421, 102);
            emptySpaceItem4.Name = "emptySpaceItem4";
            emptySpaceItem4.Size = new System.Drawing.Size(110, 213);
            // 
            // emptySpaceItem5
            // 
            emptySpaceItem5.Location = new System.Drawing.Point(99, 315);
            emptySpaceItem5.Name = "emptySpaceItem5";
            emptySpaceItem5.Size = new System.Drawing.Size(144, 34);
            // 
            // OdemeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(655, 375);
            Controls.Add(layoutControl1);
            Name = "OdemeForm";
            Text = "OdemeForm";
            Load += OdemeForm_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtAciklama.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbOdemeYontemi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTutar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)glueRandevu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnOdemeTamamla;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.ComboBoxEdit cmbOdemeYontemi;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.GridLookUpEdit glueRandevu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
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
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
    }
}