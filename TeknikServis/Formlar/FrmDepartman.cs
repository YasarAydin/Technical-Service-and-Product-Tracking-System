using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void departmanListele()
        {
            var degerler = from urun in db.TBLDEPARTMAN
                           select new
                           {
                               urun.ID,
                               urun.AD,
                               urun.ACIKLAMA
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN t = new TBLDEPARTMAN();
            if (TxtDepartmanAd.Text.Length <= 50)
            {
                t.AD = TxtDepartmanAd.Text;
                t.ACIKLAMA = TxtDepartmanAciklama.Text;
                db.TBLDEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Departman Kaydedilirken Hata!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            departmanListele();
            
        }

        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            departmanListele();
            LblToplamDepartmanSayisi.Text = db.TBLDEPARTMAN.Count().ToString();
            LblToplamPersonelSayisi.Text = db.TBLPERSONEL.Count().ToString();            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtDepartmanID.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            db.TBLDEPARTMAN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Silindi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            departmanListele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtDepartmanID.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            deger.AD = TxtDepartmanAd.Text;
            deger.ACIKLAMA = TxtDepartmanAciklama.Text;
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Güncellendi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            departmanListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtDepartmanID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtDepartmanAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtDepartmanAciklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
        }

    }
}
