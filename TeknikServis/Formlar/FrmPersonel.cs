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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void Listele()
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL,
                               u.TELEFON
                           };
            gridControl1.DataSource = degerler.ToList();

            //lookUpPersonelDepartman.Properties.DataSource = db.TBLDEPARTMAN.ToList();
            lookUpPersonelDepartman.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                             select new
                                                             {
                                                                 x.ID,
                                                                 x.AD
                                                             }).ToList(); ;
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            Listele();

            // 1. personel
            string ad1, soyad1, ad2, soyad2, ad3, soyad3, ad4, soyad4;
            ad1 = db.TBLPERSONEL.First(x => x.ID == 1).AD;
            soyad1 = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            LblAdSoyad1.Text = ad1 + " " + soyad1;
            LblMail1.Text = db.TBLPERSONEL.First(x => x.ID == 1).MAIL;
            LblDepartman1.Text = db.TBLPERSONEL.First(X => X.ID == 1).TBLDEPARTMAN.AD;

            // 2. personel
            ad2 = db.TBLPERSONEL.First(x => x.ID == 2).AD;
            soyad2 = db.TBLPERSONEL.First(x => x.ID == 2).SOYAD;
            LblAdSoyad2.Text = ad2 + " " + soyad2;
            LblMail2.Text = db.TBLPERSONEL.First(x => x.ID == 2).MAIL;
            LblDepartman2.Text = db.TBLPERSONEL.First(X => X.ID == 2).TBLDEPARTMAN.AD;


            // 3. personel
            ad3 = db.TBLPERSONEL.First(x => x.ID == 3).AD;
            soyad3 = db.TBLPERSONEL.First(x => x.ID == 3).SOYAD;
            LblAdSoyad3.Text = ad3 + " " + soyad3;
            LblMail3.Text = db.TBLPERSONEL.First(x => x.ID == 3).MAIL;
            LblDepartman3.Text = db.TBLPERSONEL.First(X => X.ID == 3).TBLDEPARTMAN.AD;

            // 4. personel
            ad4 = db.TBLPERSONEL.First(x => x.ID == 4).AD;
            soyad4 = db.TBLPERSONEL.First(x => x.ID == 4).SOYAD;
            LblAdSoyad4.Text = ad4 + " " + soyad4;
            LblMail4.Text = db.TBLPERSONEL.First(x => x.ID == 4).MAIL;
            LblDepartman4.Text = db.TBLPERSONEL.First(X => X.ID == 4).TBLDEPARTMAN.AD;

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLPERSONEL t = new TBLPERSONEL();
            t.AD = TxtPersonelAd.Text;
            t.SOYAD = TxtPersonelSoyad.Text;
            t.DEPARTMAN = byte.Parse(lookUpPersonelDepartman.EditValue.ToString());
            db.TBLPERSONEL.Add(t);
            db.SaveChanges();
            MessageBox.Show("PERSONEL SİSTEME EKLENDİ");
            Listele();
        }
    }
}
