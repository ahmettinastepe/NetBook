using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetBook.Winform.Kitap;
using NetBook.Winform.KitapHareket;
using NetBook.Winform.Sinif;
using NetBook.Winform.Uye;

namespace NetBook.Winform
{
    public partial class FrmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void barBtnKitaplar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKitap form=new FrmKitap();
            form.MdiParent = this;
            form.Show();
        }

        private void barBtnUyeler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUye form = new FrmUye();
            form.MdiParent = this;
            form.Show();
        }

        private void barBtnSiniflar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSinif form=new FrmSinif();
            form.MdiParent = this;
            form.Show();
        }

        private void barBtnKitapAlisverisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKitapAlisveris form=new FrmKitapAlisveris();
            form.MdiParent = this;
            form.Show();
        }
    }
}
