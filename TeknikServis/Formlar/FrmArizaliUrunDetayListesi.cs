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
    public partial class FrmArizaliUrunDetayListesi : Form
    {
        public FrmArizaliUrunDetayListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void ArizaliUrunDetayListesi_Load(object sender, EventArgs e)
        {
            gridControlArizaliUrunDetay.DataSource = (from x in db.TBLURUNTAKIP
                                      select new
                                      {
                                          x.TAKIPID,
                                          x.TARIH,
                                          x.SERINO,
                                          x.ACIKLAMA
                                      }).ToList();
        }
    }
}
