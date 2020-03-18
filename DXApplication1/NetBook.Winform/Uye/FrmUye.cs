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

namespace NetBook.Winform.Uye
{
    public partial class FrmUye : DevExpress.XtraEditors.XtraForm
    {
        IUyeService uyeService = new UyeManager();
        public FrmUye()
        {
            InitializeComponent();
            uyeService.OrnekOlustur(true);
            Listele();
        }

        private void Listele()
        {
            gridContUye.DataSource = uyeService.Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmUyeIslem form = new FrmUyeIslem(new Entities.Uye());
            form.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Entities.Uye uyeEntity = (Entities.Uye)gridUye.GetFocusedRow();
            FrmUyeIslem form = new FrmUyeIslem(uyeEntity);
            form.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}