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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void Listele()
        {
            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               CARIAD = u.TBLCARI.AD + u.TBLCARI.SOYAD,
                               PERSONELAD = u.TBLPERSONEL.AD + u.TBLPERSONEL.SOYAD
                           };

            //lookUpPersonelDepartman.Properties.DataSource = db.TBLDEPARTMAN.ToList();
            lookUpFaturaCari.Properties.DataSource = (from x in db.TBLCARI
                                                    select new
                                                    {
                                                        x.ID,
                                                        AD = x.AD + " " + x.SOYAD
                                                    }).ToList();

            lookUpFaturaPersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                                    select new
                                                    {
                                                        x.ID,
                                                        AD = x.AD + " " + x.SOYAD
                                                    }).ToList(); ;

            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            Listele();            
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURABILGI t = new TBLFATURABILGI();
            t.SERI = TxtFaturaSeriNo.Text;
            t.SIRANO = TxtFaturaSiraNo.Text;
            t.TARIH = Convert.ToDateTime(TxtFaturaTarih.Text);
            t.SAAT = TxtFaturaSaat.Text;
            t.VERGIDAIRE = TxtFaturaVergiDairesi.Text;
            t.PERSONEL = short.Parse(lookUpFaturaPersonel.EditValue.ToString());
            t.CARI = int.Parse(lookUpFaturaCari.EditValue.ToString());
            db.TBLFATURABILGI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Sisteme Kaydedilmiştir, Kalem Girişi Yapabilirsiniz");
        }

     

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemPopup fr = new FrmFaturaKalemPopup();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
