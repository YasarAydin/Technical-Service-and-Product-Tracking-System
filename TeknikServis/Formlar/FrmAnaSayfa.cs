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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            gridControlKritikSeviye.DataSource = (from x in db.TBLURUN
                                                  select new
                                                  {
                                                      x.AD,
                                                      x.STOK
                                                  }).Where(x => x.STOK < 30).ToList();

            gridControlFihrist.DataSource = (from y in db.TBLCARI
                                             select new
                                             {
                                                 AD = y.AD + " " + y.SOYAD,
                                                 y.IL
                                             }).ToList();

            gridControlKategoriUrun.DataSource = db.urunkategori().ToList();

            DateTime bugun = DateTime.Today;
            var degerler = (from x in db.TBLNOTLARIM.OrderBy(y => y.ID)
                            where (x.TARIH == bugun)
                            select new
                            {
                                x.BASLIK,
                                x.ICERIK
                            });
            gridControlBugunYapilacaklar.DataSource = degerler.ToList();

            // Örnek olarak 5 etiket kontrolü oluşturuyoruz.
            LabelControl[] labelControls = { labelControl1, labelControl2, labelControl3, labelControl4, labelControl5 };

            // İletişim veritabanından konu ve adları almak için döngü kullanarak işlemi tekrar ediyoruz.
            for (int i = 0; i < labelControls.Length; i++)
            {
                // İletişim veritabanından belirli bir ID'ye sahip kaydı alıyoruz.
                var iletişim = db.TBLILETISIM.FirstOrDefault(x => x.ID == i + 1);

                // Eğer iletişim bilgisi varsa, etiketin metnini güncelliyoruz.
                if (iletişim != null)
                {
                    // Konu ve ad bilgilerini alıyoruz.
                    string konu = iletişim.KONU;
                    string ad = iletişim.ADSOYAD;

                    // Etiketin metnini güncelliyoruz.
                    labelControls[i].Text = $"{konu} - {ad}";
                }
                else
                {
                    // Eğer iletişim bilgisi bulunamazsa, etiketin metnini boş bırakabiliriz.
                    labelControls[i].Text = string.Empty;
                }
            }

        }
    }
}
