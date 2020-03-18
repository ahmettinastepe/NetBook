using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetBook.Business.Servisler;
using NetBook.Business.Yonetim;
using NetBook.Winform.Uye;

namespace NetBook.Winform.Sinif
{
    public partial class FrmSinif : DevExpress.XtraEditors.XtraForm
    {
        ISinifService sinifService = new SinifManager();
        IUyeService uyeService = new UyeManager();
        private List<Entities.Sinif> sinifListe;
        public FrmSinif()
        {
            InitializeComponent();
            Listele();
        }
        private void Listele()
        {
            sinifService.OrnekOlustur(true);
            uyeService.OrnegeBagla(sinifService.OrnekOlustur(false));
            sinifListe = sinifService.Listele();
            gridContSinif.DataSource = sinifListe;
        }

        private void gridSinif_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridContUye.DataSource = sinifListe[gridSinif.FocusedRowHandle].Uyeler;
        }

        private void btnSinifEkle_Click(object sender, EventArgs e)
        {
            FrmSinifIslem form = new FrmSinifIslem(new Entities.Sinif());
            form.ShowDialog();
            if (form.kaydedildi)
            {
                Listele();
            }
        }

        private void btnSinifDuzenle_Click(object sender, EventArgs e)
        {
            Entities.Sinif sinifEntity = (Entities.Sinif)gridSinif.GetFocusedRow();
            FrmSinifIslem form = new FrmSinifIslem(sinifEntity);
            form.ShowDialog();
            if (form.kaydedildi)
            {
                Listele();
            }
        }

        private void btnSinifSil_Click(object sender, EventArgs e)
        {
            Entities.Sinif sinifEntity = (Entities.Sinif)gridSinif.GetFocusedRow();
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sinifService.Sil(sinifEntity);
                sinifService.Kaydet();
                Listele();
            }
        }

        private void btnSinifGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            FrmUyeIslem form = new FrmUyeIslem(new Entities.Uye());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void btnUyeDuzenle_Click(object sender, EventArgs e)
        {
            Entities.Uye uyeEntity = (Entities.Uye)layoutViewUye.GetFocusedRow();
            FrmUyeIslem form = new FrmUyeIslem(uyeEntity);
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            Entities.Uye uyeEntity = (Entities.Uye)layoutViewUye.GetFocusedRow();
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                uyeService.Sil(uyeEntity);
                uyeService.Kaydet();
                Listele();
            }
        }

        private void btnUyeGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}