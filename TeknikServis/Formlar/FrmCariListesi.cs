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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        int secilen_il;

        private void carileriListele()
        {
            gridControlCariListesi.DataSource = (from x in db.TBLCARI
                                       select new
                                       {
                                           x.ID,
                                           AD = x.AD + " " + x.SOYAD,
                                           x.IL,
                                           x.ILCE
                                       }).ToList();

            LblToplamCariSayisi.Text = db.TBLCARI.Count().ToString();
            LblToplamilSayisi.Text = db.TBLCARI.Select(x => x.IL).Distinct().Count().ToString();
            LblToplamilceSayisi.Text = db.TBLCARI.Select(x => x.ILCE).Distinct().Count().ToString();
            LblMerkezSube.Text = db.enfazlacarisiolanil().FirstOrDefault();
        }

        private void illeriListele()
        {
            lookUpEditil.Properties.DataSource = (from x in db.TBLILLER
                                                  select new
                                                  {
                                                      x.id,
                                                      x.sehir
                                                  }).ToList();
        }

        private void BtnUrunListele_Click(object sender, EventArgs e)
        {
            carileriListele();
        }

        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            carileriListele();
            illeriListele();            
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

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();
            t.AD = TxtCariAd.Text;
            t.SOYAD = TxtCariSoyad.Text;
            t.IL = lookUpEditil.Text;
            t.ILCE = lookUpEditilce.Text;
            db.TBLCARI.Add(t);
            db.SaveChanges();
            MessageBox.Show("CARİ BAŞARIYLA EKLENDİ");
            carileriListele();
        }
    }
}
