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
    public partial class FrmArizaliUrunKaydi : Form
    {
        public FrmArizaliUrunKaydi()
        {
            InitializeComponent();
        }


        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void BtnArizaliUrunKaydet_Click(object sender, EventArgs e)
        {
            TBLURUNKABUL t = new TBLURUNKABUL();
            t.CARI = int.Parse(lookUpEditCari.EditValue.ToString());
            t.GELISTARIH = DateTime.Parse(TxtTarih.Text);
            t.PERSONEL = byte.Parse(lookUpEditPersonel.EditValue.ToString());
            t.URUNSERINO = TxtSeriNo.Text;
            t.URUNDURUMDETAY = "Ürün Kaydedildi";
            db.TBLURUNKABUL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Arıza Kaydı Girişi Yapıldı");
        }

        private void BtnArizaliUrunVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmArizaliUrunKaydi_Load(object sender, EventArgs e)
        {
            lookUpEditCari.Properties.DataSource = (from x in db.TBLCARI
                                                    select new
                                                    {
                                                        x.ID,
                                                        AD = x.AD + " " + x.SOYAD
                                                    }).ToList();

            lookUpEditPersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                                        select new
                                                        {
                                                            x.ID,
                                                            AD = x.AD + " " + x.SOYAD
                                                        }).ToList();
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}
