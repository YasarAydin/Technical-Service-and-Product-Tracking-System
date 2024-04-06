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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void urunleriListele()
        {
            //var degerler = db.TBLURUN.ToList();
            var degerler = from urun in db.TBLURUN
                           select new
                           {
                               urun.ID,
                               urun.AD,
                               urun.MARKA,
                               urun.ALISFIYAT,
                               urun.SATISFIYAT,
                               urun.STOK,
                               KATEGORI = urun.TBLKATEGORI.AD
                           };
            gridControlUrunListesi.DataSource = degerler.ToList();
        }

        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            urunleriListele();

            // Kategorileri Listeleme
            lookUpEdit1.Properties.DataSource = (from x in db.TBLKATEGORI
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();
        }


        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.AD = TxtUrunAd.Text;
            t.MARKA = TxtMarka.Text;
            t.ALISFIYAT = decimal.Parse(TxtAlisFiyat.Text);
            t.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
            t.STOK = short.Parse(TxtStok.Text);
            t.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunleriListele();
        }

        private void BtnUrunListele_Click(object sender, EventArgs e)
        {
            urunleriListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                TxtUrunId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                TxtUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                TxtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
                TxtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
                TxtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
                TxtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
                lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("KATEGORI").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtUrunId.Text);
            var deger = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Silindi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunleriListele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtUrunId.Text);
            var deger = db.TBLURUN.Find(id);
            deger.AD = TxtUrunAd.Text;
            deger.MARKA = TxtMarka.Text;
            deger.ALISFIYAT = decimal.Parse(TxtAlisFiyat.Text);
            deger.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
            deger.STOK = short.Parse(TxtStok.Text);
            deger.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunleriListele();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtUrunId.Clear();
            TxtUrunAd.Clear();
            TxtMarka.Clear();
            TxtAlisFiyat.Clear();
            TxtSatisFiyat.Clear();
            TxtStok.Clear();
            lookUpEdit1.Clear();
        }
    }
}
