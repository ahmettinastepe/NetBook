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
using NetBook.Winform.Tanım;

namespace NetBook.Winform.Sinif
{
    public partial class FrmSinifIslem : DevExpress.XtraEditors.XtraForm
    {
        ISinifService sinifService = new SinifManager();
        private Entities.Sinif _sinifEntity;
        public bool kaydedildi = false;
        public FrmSinifIslem(Entities.Sinif sinifEntity)
        {
            InitializeComponent();
            _sinifEntity = sinifEntity;
            sinifService.OrnekOlustur(true);

            txtOkulturu.DataBindings.Add("Text", _sinifEntity, "OkulTuru", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSinif.DataBindings.Add("Text", _sinifEntity, "Sinifi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSube.DataBindings.Add("Text", _sinifEntity, "Sube", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBolum.DataBindings.Add("Text", _sinifEntity, "Bolumu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSinifAciklama.DataBindings.Add("Text", _sinifEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void txtOkulturu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim form = new FrmTanim(FrmTanim.Turu.OkulTuru);
            form.ShowDialog();
            if (form.secildi)
            {
                txtOkulturu.Text = form._tanimEntity.Tanimi;
            }
        }

        private void txtBolum_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim form = new FrmTanim(FrmTanim.Turu.Bolum);
            form.ShowDialog();
            if (form.secildi)
            {
                txtBolum.Text = form._tanimEntity.Tanimi;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (sinifService.EkleveyaGuncelle(_sinifEntity) != null)
            {
                kaydedildi = true;
                sinifService.Kaydet();
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}