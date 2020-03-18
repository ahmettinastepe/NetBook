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
using NetBook.Entities;
using NetBook.Winform.Sinif;
using NetBook.Winform.Tanım;

namespace NetBook.Winform.Uye
{
    public partial class FrmUyeIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Uye _uyeEntity;
        private Telefon _telefonEntity;
        private Adres _adresEntity;

        IUyeService uyeService = new UyeManager();
        ISinifService sinifService = new SinifManager();
        ITelefonService telefonService = new TelefonManager();
        IAdresService adresService = new AdresManager();

        public bool Kaydedildi = false;
        public FrmUyeIslem(Entities.Uye uyeEntity)
        {
            InitializeComponent();
            uyeService.OrnekOlustur(true);
            sinifService.OrnegeBagla(uyeService.OrnekOlustur(false));
            telefonService.OrnegeBagla(uyeService.OrnekOlustur(false));
            adresService.OrnegeBagla(uyeService.OrnekOlustur(false));

            _uyeEntity = uyeEntity;
            toggleDurum.DataBindings.Add("EditValue", _uyeEntity, "Durum", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTcKimlikNo.DataBindings.Add("Text", _uyeEntity, "TcKimlikNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtOkulNo.DataBindings.Add("Text", _uyeEntity, "OkulNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBarkodu.DataBindings.Add("Text", _uyeEntity, "Barkod", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdi.DataBindings.Add("Text", _uyeEntity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSoyadi.DataBindings.Add("Text", _uyeEntity, "Soyadi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtYabanciDil.DataBindings.Add("Text", _uyeEntity, "YabanciDil", false, DataSourceUpdateMode.OnPropertyChanged);
            txtKayitTarihi.DataBindings.Add("EditValue", _uyeEntity, "KayitTarihi", true, DataSourceUpdateMode.OnPropertyChanged, DateTime.Now);
            txtAdresAciklama.DataBindings.Add("Text", _uyeEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);

            gridContTelefon.DataSource = telefonService.BaglantiNesnesi(c => c.UyeId == _uyeEntity.Id);
            gridContAdres.DataSource = adresService.BaglantiNesnesi(c => c.UyeId == _uyeEntity.Id);
            SinifListele();
        }

        private void TelefonBinding()
        {
            txtTelefon.DataBindings.Clear();
            txtTelefonAdiSoyadi.DataBindings.Clear();
            txtTelefonYakinlik.DataBindings.Clear();
            txtTelefonAciklama.DataBindings.Clear();
            txtTelefon.DataBindings.Add("Text", _telefonEntity, "Telefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTelefonAdiSoyadi.DataBindings.Add("Text", _telefonEntity, "AdiSoyadi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTelefonYakinlik.DataBindings.Add("Text", _telefonEntity, "Yakinlik", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTelefonAciklama.DataBindings.Add("Text", _telefonEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void AdresBinding()
        {
            txtIl.DataBindings.Clear();
            txtIlce.DataBindings.Clear();
            txtSemt.DataBindings.Clear();
            txtAdres.DataBindings.Clear();
            txtAdresAciklama.DataBindings.Clear();
            txtIl.DataBindings.Add("Text", _adresEntity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _adresEntity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _adresEntity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _adresEntity, "Adresi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdresAciklama.DataBindings.Add("Text", _adresEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void SinifListele()
        {
            searchSinif.Properties.DataSource = sinifService.Listele();
            searchSinif.Properties.DisplayMember = "OkulTuru";
            searchSinif.Properties.ValueMember = "Id";
            if (_uyeEntity.SinifId != 0)
            {
                SinifYukle(_uyeEntity.SinifId);
            }
        }
        private void SinifYukle(int id)
        {
            _uyeEntity.SinifId = id;
            var sinifEntity = sinifService.Getir(c => c.Id == id);
            searchSinif.EditValue = sinifEntity.Id;
            txtSinif.Text = sinifEntity.Sinifi;
            txtSubesi.Text = sinifEntity.Sube;
            txtBolumu.Text = sinifEntity.Bolumu;
            txtSinifAciklama.Text = sinifEntity.Aciklama;
            gridContSinifListesi.DataSource = uyeService.Listele(c => c.SinifId == id);
        }
        private void TelefonKayitAc()
        {
            btnTelefonEkle.Enabled = false;
            btnTelefonDuzenle.Enabled = false;
            btnTelefonSil.Enabled = false;
            btnTelefonKaydet.Enabled = true;
            btnTelefonVazgec.Enabled = true;
            groupTelefonBilgi.Visible = true;
            groupMenu.Enabled = false;
            gridContTelefon.Enabled = false;
        }

        private void TelfonKayitKapat()
        {
            btnTelefonEkle.Enabled = true;
            btnTelefonDuzenle.Enabled = true;
            btnTelefonSil.Enabled = true;
            btnTelefonKaydet.Enabled = false;
            btnTelefonVazgec.Enabled = false;
            groupTelefonBilgi.Visible = false;
            groupMenu.Enabled = true;
            gridContTelefon.Enabled = true;
        }
        private void AdresKayitAc()
        {
            btnAdresEkle.Enabled = false;
            btnAdresDuzenle.Enabled = false;
            btnAdresSil.Enabled = false;
            btnAdresKaydet.Enabled = true;
            btnAdresVazgec.Enabled = true;
            groupAdresBilgi.Visible = true;
            groupMenu.Enabled = false;
            gridContAdres.Enabled = false;
        }

        private void AdresKayitKapat()
        {
            btnAdresEkle.Enabled = true;
            btnAdresDuzenle.Enabled = true;
            btnAdresSil.Enabled = true;
            btnAdresKaydet.Enabled = false;
            btnAdresVazgec.Enabled = false;
            groupAdresBilgi.Visible = false;
            groupMenu.Enabled = true;
            gridContAdres.Enabled = true;
        }

        private void btnTelefonEkle_Click(object sender, EventArgs e)
        {
            TelefonKayitAc();
            _telefonEntity = new Telefon();
            TelefonBinding();
        }

        private void btnTelefonDuzenle_Click(object sender, EventArgs e)
        {
            TelefonKayitAc();
            _telefonEntity = (Telefon)layoutViewTelefon.GetFocusedRow();
            TelefonBinding();
        }

        private void btnTelefonSil_Click(object sender, EventArgs e)
        {
            Telefon Silinecek = (Telefon)layoutViewTelefon.GetFocusedRow();
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                telefonService.Sil(Silinecek);
            }
        }

        private void btnTelefonKaydet_Click(object sender, EventArgs e)
        {
            _telefonEntity.UyeId = _uyeEntity.Id;
            if (telefonService.EkleveyaGuncelle(_telefonEntity) != null)
            {
                TelfonKayitKapat();
            }
        }

        private void btnTelefonVazgec_Click(object sender, EventArgs e)
        {
            TelfonKayitKapat();
            _telefonEntity = null;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (uyeService.EkleveyaGuncelle(_uyeEntity) != null)
            {
                Kaydedildi = true;
                uyeService.Kaydet();
                this.Close();
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPane1_SelectedPageChanging(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangingEventArgs e)
        {
            if (groupMenu.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void btnAdresEkle_Click(object sender, EventArgs e)
        {
            AdresKayitAc();
            _adresEntity = new Adres();
            AdresBinding();
        }

        private void btnAdresDuzenle_Click(object sender, EventArgs e)
        {
            AdresKayitAc();
            _adresEntity = (Adres)layoutViewAdres.GetFocusedRow();
            AdresBinding();
        }

        private void btnAdresKaydet_Click(object sender, EventArgs e)
        {
            _adresEntity.UyeId = _uyeEntity.Id;
            if (adresService.EkleveyaGuncelle(_adresEntity) != null)
            {
                AdresKayitKapat();
            }
        }

        private void btnAdresVazgec_Click(object sender, EventArgs e)
        {
            AdresKayitKapat();
        }

        private void btnAdresSil_Click(object sender, EventArgs e)
        {
            Adres Silinecek = (Adres)layoutViewAdres.GetFocusedRow();
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                adresService.Sil(Silinecek);
            }
        }

        private void searchSinif_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (searchSinif.Properties.View.SelectedRowsCount != 0)
            {
                var id = (int)searchSinif.Properties.View.GetFocusedRowCellValue(colSinifId);
                SinifYukle(id);
            }
        }

        private void txtYabanciDil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim form=new FrmTanim(FrmTanim.Turu.YabanciDil);
            form.ShowDialog();
            if (form.secildi)
            {
                txtYabanciDil.Text = form._tanimEntity.Tanimi;
            }
        }

        private void searchSinif_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                FrmSinifIslem form=new FrmSinifIslem(new Entities.Sinif());
                form.ShowDialog();
                if (form.kaydedildi)
                {
                    SinifListele();
                }
            }
        }
    }
}