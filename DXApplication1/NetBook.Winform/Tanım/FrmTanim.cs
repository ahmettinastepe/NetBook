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

namespace NetBook.Winform.Tanım
{
    public partial class FrmTanim : DevExpress.XtraEditors.XtraForm
    {
        ITanimService tanimService = new TanimManager();
        public Tanim _tanimEntity;
        public bool secildi = false;
        private Turu _tur;
        public FrmTanim(Turu tur)
        {
            InitializeComponent();
            _tur = tur;
            tanimService.OrnekOlustur(true);
            gridContTanim.DataSource = tanimService.BaglantiNesnesi(c => c.Turu == tur.ToString());
            BaslikBilgi();
        }

        private void BaslikBilgi()
        {
            switch (_tur)
            {
                case Turu.KitapTuru:
                    lblBaslik.Text = "Kitap Türleri";
                    break;
                case Turu.YabanciDil:
                    lblBaslik.Text = "Yabancı Dil Seçimi";
                    break;
                case Turu.OkulTuru:
                    lblBaslik.Text = "Okul Türleri";
                    break;
                case Turu.Bolum:
                    lblBaslik.Text = "Bölüm Seçimi";
                    break;
            }
        }
        public enum Turu
        {
            KitapTuru,
            YabanciDil,
            OkulTuru,
            Bolum
        }

        private void TanimBinding()
        {
            txtTanimi.DataBindings.Clear();
            txtAciklama.DataBindings.Clear();
            txtTanimi.DataBindings.Add("Text", _tanimEntity, "Tanimi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _tanimEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void KayitAc()
        {
            btnEkle.Enabled = false;
            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            groupTanimBilgisi.Visible = true;
            btnSec.Enabled = false;
            gridContTanim.Enabled = false;
        }
        private void KayitKapat()
        {
            btnEkle.Enabled = true;
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            groupTanimBilgisi.Visible = false;
            btnSec.Enabled = true;
            gridContTanim.Enabled = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            KayitAc();
            _tanimEntity = new Tanim();
            TanimBinding();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            KayitAc();
            _tanimEntity = (Tanim)gridTanim.GetFocusedRow();
            TanimBinding();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _tanimEntity.Turu = _tur.ToString();
            if (tanimService.EkleveyaGuncelle(_tanimEntity) != null)
            {
                tanimService.Kaydet();
                KayitKapat();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            _tanimEntity = null;
            KayitKapat();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            secildi = true;
            _tanimEntity = (Tanim)gridTanim.GetFocusedRow();
            this.Close();
        }
    }
}