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

namespace NetBook.Winform.Kitap
{
    public partial class FrmKitap : DevExpress.XtraEditors.XtraForm
    {
        private IKitapService kitapService = new KitapManager();
        public FrmKitap()
        {
            InitializeComponent();
            kitapService.OrnekOlustur(true);
            Listele();
        }

        private void Listele()
        {
            gridContKitap.DataSource = kitapService.Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmKitapIslem form = new FrmKitapIslem(new Entities.Kitap());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int kitapId = Convert.ToInt32(gridKitap.GetFocusedRowCellValue(colId));
            FrmKitapIslem form = new FrmKitapIslem(kitapService.Getir(c => c.Id == kitapId));
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Entities.Kitap Silinecek = (Entities.Kitap) gridKitap.GetFocusedRow();
            if (MessageBox.Show("Seiçi olan veriyi silmek istediğinize emin misniz?", "Uyarı", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                kitapService.Sil(c => c.Id == Silinecek.Id);
                kitapService.Kaydet();
                Listele();
            }
        }
    }
}