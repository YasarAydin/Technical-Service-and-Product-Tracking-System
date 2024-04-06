namespace TeknikServis.Formlar
{
    partial class FrmYeniKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniKategori));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit7 = new DevExpress.XtraEditors.PictureEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtKategoriAd = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.ButtonKategoriVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonUrunKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKategoriAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(155, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(205, 25);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "YENİ KATEGORİ EKLE";
            // 
            // pictureEdit7
            // 
            this.pictureEdit7.EditValue = ((object)(resources.GetObject("pictureEdit7.EditValue")));
            this.pictureEdit7.Location = new System.Drawing.Point(50, 25);
            this.pictureEdit7.Name = "pictureEdit7";
            this.pictureEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit7.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit7.Size = new System.Drawing.Size(86, 96);
            this.pictureEdit7.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(98, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 3);
            this.panel1.TabIndex = 24;
            // 
            // TxtKategoriAd
            // 
            this.TxtKategoriAd.EditValue = "Kategori Adı";
            this.TxtKategoriAd.Location = new System.Drawing.Point(98, 161);
            this.TxtKategoriAd.Name = "TxtKategoriAd";
            this.TxtKategoriAd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtKategoriAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKategoriAd.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtKategoriAd.Properties.Appearance.Options.UseBackColor = true;
            this.TxtKategoriAd.Properties.Appearance.Options.UseFont = true;
            this.TxtKategoriAd.Properties.Appearance.Options.UseForeColor = true;
            this.TxtKategoriAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtKategoriAd.Size = new System.Drawing.Size(165, 24);
            this.TxtKategoriAd.TabIndex = 23;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(50, 152);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(42, 42);
            this.pictureEdit1.TabIndex = 22;
            // 
            // ButtonKategoriVazgec
            // 
            this.ButtonKategoriVazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonKategoriVazgec.ImageOptions.Image")));
            this.ButtonKategoriVazgec.Location = new System.Drawing.Point(210, 227);
            this.ButtonKategoriVazgec.Name = "ButtonKategoriVazgec";
            this.ButtonKategoriVazgec.Size = new System.Drawing.Size(128, 43);
            this.ButtonKategoriVazgec.TabIndex = 26;
            this.ButtonKategoriVazgec.Text = "VAZGEÇ";
            this.ButtonKategoriVazgec.Click += new System.EventHandler(this.ButtonUrunVazgec_Click);
            // 
            // ButtonUrunKaydet
            // 
            this.ButtonUrunKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonUrunKaydet.ImageOptions.Image")));
            this.ButtonUrunKaydet.Location = new System.Drawing.Point(50, 227);
            this.ButtonUrunKaydet.Name = "ButtonUrunKaydet";
            this.ButtonUrunKaydet.Size = new System.Drawing.Size(128, 43);
            this.ButtonUrunKaydet.TabIndex = 25;
            this.ButtonUrunKaydet.Text = "KAYDET";
            this.ButtonUrunKaydet.Click += new System.EventHandler(this.ButtonUrunKaydet_Click);
            // 
            // FrmYeniKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(427, 306);
            this.Controls.Add(this.ButtonKategoriVazgec);
            this.Controls.Add(this.ButtonUrunKaydet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtKategoriAd);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmYeniKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYeniKategori";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKategoriAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit7;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit TxtKategoriAd;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton ButtonKategoriVazgec;
        private DevExpress.XtraEditors.SimpleButton ButtonUrunKaydet;
    }
}