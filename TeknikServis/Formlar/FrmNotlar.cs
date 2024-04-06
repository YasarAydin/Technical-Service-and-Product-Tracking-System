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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void listele()
        {
            gridControlOkunmayanNotlar.DataSource = db.TBLNOTLARIM.Where(x => x.OKUMA == false).ToList();
            gridControlOkunanNotlar.DataSource = db.TBLNOTLARIM.Where(x => x.OKUMA == true).ToList();
        }

        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLNOTLARIM t = new TBLNOTLARIM();
            t.BASLIK = TxtNotBaslik.Text;
            t.ICERIK = TxtNotIcerik.Text;
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            t.OKUMA = false;
            db.TBLNOTLARIM.Add(t);
            db.SaveChanges();
            MessageBox.Show("Not başarıyla kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtNotId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (checkEditNotOkundu.Checked == true)
            {
                int id = int.Parse(TxtNotId.Text);
                var deger = db.TBLNOTLARIM.Find(id);
                deger.OKUMA = true;
                db.SaveChanges();
                MessageBox.Show("Not durumu değiştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
