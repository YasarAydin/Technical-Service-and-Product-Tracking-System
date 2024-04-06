using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.İletişim
{
    public partial class GelenMesajlar : Form
    {
        public GelenMesajlar()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void GelenMesajlar_Load(object sender, EventArgs e)
        {
            LblToplamMesajSayisi.Text = db.TBLILETISIM.Count().ToString();
            LblToplamTesekkurSayisi.Text = db.TBLILETISIM.Where(x => x.KONU == "Teşekkür").Count().ToString();
            LblToplamRicaSayisi.Text = db.TBLILETISIM.Where(x => x.KONU == "Rica").Count().ToString();
            LblToplamSikayetSayisi.Text = db.TBLILETISIM.Where(x => x.KONU == "Şikayet").Count().ToString();

            LblToplamPersonelSayisi.Text = db.TBLPERSONEL.Count().ToString();
            LblToplamCariSayisi.Text = db.TBLCARI.Count().ToString();
            LblToplamKategoriSayisi.Text = db.TBLKATEGORI.Count().ToString();
            LblToplamUrunSayisi.Text = db.TBLURUN.Count().ToString();

            var degerler = from x in db.TBLILETISIM
                           select new
                           {
                               x.ID,
                               x.ADSOYAD,
                               x.MAIL,
                               x.KONU,
                               x.MESAJ
                           };
            gridControl1.DataSource = degerler.ToList();

        }
    }
}
