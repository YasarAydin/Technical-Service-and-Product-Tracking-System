namespace TeknikServis.Formlar
{
    partial class FrmArizaliUrunDetayListesi
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
            this.gridControlArizaliUrunDetay = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlArizaliUrunDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlArizaliUrunDetay
            // 
            this.gridControlArizaliUrunDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlArizaliUrunDetay.Location = new System.Drawing.Point(0, 0);
            this.gridControlArizaliUrunDetay.MainView = this.gridView1;
            this.gridControlArizaliUrunDetay.Name = "gridControlArizaliUrunDetay";
            this.gridControlArizaliUrunDetay.Size = new System.Drawing.Size(1370, 450);
            this.gridControlArizaliUrunDetay.TabIndex = 0;
            this.gridControlArizaliUrunDetay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlArizaliUrunDetay;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // FrmArizaliUrunDetayListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.gridControlArizaliUrunDetay);
            this.Name = "FrmArizaliUrunDetayListesi";
            this.Text = "Arızalı Ürün Detay Listesi";
            this.Load += new System.EventHandler(this.ArizaliUrunDetayListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlArizaliUrunDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlArizaliUrunDetay;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}