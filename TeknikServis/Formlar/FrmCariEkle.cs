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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        int secilen_il;

        private void ButtonCariVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonCariKaydet_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();
            t.AD = TxtCariAd.Text;
            t.SOYAD = TxtCariSoyad.Text;
            t.TELEFON = TxtCariTelefon.Text;
            t.MAIL = TxtCariMail.Text;
            t.BANKA = TxtCariBanka.Text;
            t.VERGIDAIRESI = TxtCariVergiDairesi.Text;
            t.VERGINO = TxtCariVergiNo.Text;
            t.STATU = TxtCariStatu.Text;
            t.ADRES = TxtCariAdres.Text;
            t.IL = lookUpEditil.Text;
            t.ILCE = lookUpEditilce.Text;
            db.TBLCARI.Add(t);
            db.SaveChanges();
            MessageBox.Show("YENİ CARİ SİSTEME BAŞARI BİR ŞEKİLDE EKLENDİ", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmCariEkle_Load(object sender, EventArgs e)
        {
            il_listele();
        }

        void il_listele()
        {
            lookUpEditil.Properties.DataSource = (from x in db.TBLILLER
                                                  select new
                                                  {
                                                      x.id,
                                                      x.sehir
                                                  }).ToList();
        }

        private void lookUpEditil_EditValueChanged(object sender, EventArgs e)
        {
            secilen_il = int.Parse(lookUpEditil.EditValue.ToString());
            lookUpEditilce.Properties.DataSource = (from y in db.TBLILCELER
                                                    select new
                                                    {
                                                        y.id,
                                                        y.ilce,
                                                        y.sehir
                                                    }).Where(z => z.sehir == secilen_il).ToList();
        }
    }
}
