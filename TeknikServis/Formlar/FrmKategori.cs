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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void kategoriListele()
        {
            var degerler = from k in db.TBLKATEGORI
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmKategori_Load(object sender, EventArgs e)
        {
            kategoriListele();
        }

        private void BtnKategoriKaydet_Click(object sender, EventArgs e)
        {
            if (TxtKategoriAd.Text != "" && TxtKategoriAd.Text.Length <= 30)
            {
                TBLKATEGORI k = new TBLKATEGORI();
                k.AD = TxtKategoriAd.Text;
                db.TBLKATEGORI.Add(k);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Kaydedildi", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                kategoriListele();
                TxtKategoriAd.Clear();
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez ve Kategori Adı 30 Karakterden Fazla Olamaz", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtKategoriId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtKategoriAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void BtnKategoriSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtKategoriId.Text);
            var deger = db.TBLKATEGORI.Find(id);
            db.TBLKATEGORI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Silindi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            kategoriListele();
        }

        private void BtnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtKategoriId.Text);
            var deger = db.TBLKATEGORI.Find(id);
            deger.AD = TxtKategoriAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Güncellendi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            kategoriListele();
        }

        private void BtnKategoriListele_Click(object sender, EventArgs e)
        {
            kategoriListele();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtKategoriAd.Clear();
            TxtKategoriId.Clear();
        }
    }
}
