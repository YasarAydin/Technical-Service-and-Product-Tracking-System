namespace TeknikServis.Formlar
{
    partial class FrmQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQRCode));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEditSeriNıo = new DevExpress.XtraEditors.TextEdit();
            this.pictureEditQRCode = new DevExpress.XtraEditors.PictureEdit();
            this.BtnQRKodOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditSeriNıo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditQRCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(49, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(304, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "SERİ NO İÇİN QR KOD OLUŞTURMA";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(66, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "SERİ NO :";
            // 
            // TxtEditSeriNıo
            // 
            this.TxtEditSeriNıo.Location = new System.Drawing.Point(139, 62);
            this.TxtEditSeriNıo.Name = "TxtEditSeriNıo";
            this.TxtEditSeriNıo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEditSeriNıo.Properties.Appearance.Options.UseFont = true;
            this.TxtEditSeriNıo.Size = new System.Drawing.Size(194, 24);
            this.TxtEditSeriNıo.TabIndex = 2;
            // 
            // pictureEditQRCode
            // 
            this.pictureEditQRCode.Location = new System.Drawing.Point(139, 140);
            this.pictureEditQRCode.Name = "pictureEditQRCode";
            this.pictureEditQRCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pictureEditQRCode.Properties.Appearance.Options.UseFont = true;
            this.pictureEditQRCode.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditQRCode.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEditQRCode.Size = new System.Drawing.Size(194, 160);
            this.pictureEditQRCode.TabIndex = 3;
            // 
            // BtnQRKodOlustur
            // 
            this.BtnQRKodOlustur.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnQRKodOlustur.Appearance.Options.UseFont = true;
            this.BtnQRKodOlustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnQRKodOlustur.ImageOptions.Image")));
            this.BtnQRKodOlustur.Location = new System.Drawing.Point(139, 92);
            this.BtnQRKodOlustur.Name = "BtnQRKodOlustur";
            this.BtnQRKodOlustur.Size = new System.Drawing.Size(194, 42);
            this.BtnQRKodOlustur.TabIndex = 4;
            this.BtnQRKodOlustur.Text = "QR Kod Oluştur";
            this.BtnQRKodOlustur.Click += new System.EventHandler(this.BtnQRKodOlustur_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(139, 306);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(194, 42);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "KAPAT";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(405, 369);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.BtnQRKodOlustur);
            this.Controls.Add(this.pictureEditQRCode);
            this.Controls.Add(this.TxtEditSeriNıo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQRCode";
            this.Text = "FrmQRCode";
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditSeriNıo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditQRCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtEditSeriNıo;
        private DevExpress.XtraEditors.PictureEdit pictureEditQRCode;
        private DevExpress.XtraEditors.SimpleButton BtnQRKodOlustur;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}