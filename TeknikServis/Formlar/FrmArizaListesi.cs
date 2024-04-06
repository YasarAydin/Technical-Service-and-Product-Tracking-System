using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmArizaListesi : Form
    {
        public FrmArizaListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FrmArizaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.ISLEMID,
                               CARIAD = x.TBLCARI.AD,
                               CARISOYAD = x.TBLCARI.SOYAD,
                               PERSONELAD = x.TBLPERSONEL.AD,
                               PERSONELSOYAD = x.TBLPERSONEL.SOYAD,
                               x.GELISTARIH,
                               x.CIKISTARIH,
                               x.URUNSERINO,
                               x.URUNDURUMDETAY
                           };
            gridControlArizaListesi.DataSource = degerler.ToList();

            LblToplamMarkaSayisi.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == true).ToString();
            LblTadilatiBitmisUrunSayisi.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == false).ToString();
            LblToplamUrunSayisi.Text = db.TBLURUNKABUL.Count().ToString();
            LblParcaBekleyenUrunSayisi.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Parça Bekliyor").ToString();
            LblMesajBeklenenMusteriler.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Mesaj Bekliyor").ToString();
            LblIptalEdilenIslemler.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "İptal Bekliyor").ToString();
            LblToplamUrunSayisi.Text = db.TBLURUNKABUL.Count().ToString();

            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-694144I\SQLEXPRESS;Initial Catalog=DbTeknikServis;Integrated Security=True;");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT URUNDURUMDETAY,COUNT(*) FROM TBLURUNKABUL GROUP BY URUNDURUMDETAY", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmArizaDetaylar fr = new FrmArizaDetaylar();
            fr.id = gridView1.GetFocusedRowCellValue("ISLEMID").ToString();
            fr.serino = gridView1.GetFocusedRowCellValue("URUNSERINO").ToString();
            fr.Show();
        }
    }
}
