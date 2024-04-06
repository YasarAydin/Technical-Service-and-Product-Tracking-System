namespace TeknikServis.Formlar
{
    partial class FrmYeniDepartman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniDepartman));
            this.ButtonDepartmanVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDepartmanKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtDepartmanAd = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit7 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDepartmanAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonDepartmanVazgec
            // 
            this.ButtonDepartmanVazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDepartmanVazgec.ImageOptions.Image")));
            this.ButtonDepartmanVazgec.Location = new System.Drawing.Point(210, 213);
            this.ButtonDepartmanVazgec.Name = "ButtonDepartmanVazgec";
            this.ButtonDepartmanVazgec.Size = new System.Drawing.Size(128, 43);
            this.ButtonDepartmanVazgec.TabIndex = 33;
            this.ButtonDepartmanVazgec.Text = "VAZGEÇ";
            this.ButtonDepartmanVazgec.Click += new System.EventHandler(this.ButtonDepartmanVazgec_Click);
            // 
            // ButtonDepartmanKaydet
            // 
            this.ButtonDepartmanKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDepartmanKaydet.ImageOptions.Image")));
            this.ButtonDepartmanKaydet.Location = new System.Drawing.Point(50, 213);
            this.ButtonDepartmanKaydet.Name = "ButtonDepartmanKaydet";
            this.ButtonDepartmanKaydet.Size = new System.Drawing.Size(128, 43);
            this.ButtonDepartmanKaydet.TabIndex = 32;
            this.ButtonDepartmanKaydet.Text = "KAYDET";
            this.ButtonDepartmanKaydet.Click += new System.EventHandler(this.ButtonDepartmanKaydet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(98, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 3);
            this.panel1.TabIndex = 31;
            // 
            // TxtDepartmanAd
            // 
            this.TxtDepartmanAd.EditValue = "Kategori Adı";
            this.TxtDepartmanAd.Location = new System.Drawing.Point(98, 147);
            this.TxtDepartmanAd.Name = "TxtDepartmanAd";
            this.TxtDepartmanAd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtDepartmanAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDepartmanAd.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtDepartmanAd.Properties.Appearance.Options.UseBackColor = true;
            this.TxtDepartmanAd.Properties.Appearance.Options.UseFont = true;
            this.TxtDepartmanAd.Properties.Appearance.Options.UseForeColor = true;
            this.TxtDepartmanAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtDepartmanAd.Size = new System.Drawing.Size(165, 24);
            this.TxtDepartmanAd.TabIndex = 30;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(50, 138);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(42, 42);
            this.pictureEdit1.TabIndex = 29;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(155, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(225, 25);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "YENİ DEPARTMAN EKLE";
            // 
            // pictureEdit7
            // 
            this.pictureEdit7.EditValue = ((object)(resources.GetObject("pictureEdit7.EditValue")));
            this.pictureEdit7.Location = new System.Drawing.Point(50, 11);
            this.pictureEdit7.Name = "pictureEdit7";
            this.pictureEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit7.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit7.Size = new System.Drawing.Size(86, 96);
            this.pictureEdit7.TabIndex = 27;
            // 
            // FrmYeniDepartman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(411, 267);
            this.Controls.Add(this.ButtonDepartmanVazgec);
            this.Controls.Add(this.ButtonDepartmanKaydet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtDepartmanAd);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmYeniDepartman";
            this.Text = "FrmYeniDepartman";
            ((System.ComponentModel.ISupportInitialize)(this.TxtDepartmanAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton ButtonDepartmanVazgec;
        private DevExpress.XtraEditors.SimpleButton ButtonDepartmanKaydet;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit TxtDepartmanAd;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit7;
    }
}