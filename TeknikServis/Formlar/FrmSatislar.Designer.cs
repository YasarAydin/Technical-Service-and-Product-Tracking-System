namespace TeknikServis.Formlar
{
    partial class FrmSatislar
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
            this.gridControlSatisListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSatisListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlSatisListesi
            // 
            this.gridControlSatisListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSatisListesi.Location = new System.Drawing.Point(0, 0);
            this.gridControlSatisListesi.MainView = this.gridView1;
            this.gridControlSatisListesi.Name = "gridControlSatisListesi";
            this.gridControlSatisListesi.Size = new System.Drawing.Size(1370, 450);
            this.gridControlSatisListesi.TabIndex = 0;
            this.gridControlSatisListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlSatisListesi;
            this.gridView1.Name = "gridView1";
            // 
            // FrmSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.gridControlSatisListesi);
            this.Name = "FrmSatislar";
            this.Text = "Satışlar";
            this.Load += new System.EventHandler(this.FrmSatislar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSatisListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlSatisListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}