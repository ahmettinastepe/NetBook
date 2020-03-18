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

namespace NetBook.Winform.KitapHareket
{
    public partial class FrmKitapAlisveris : DevExpress.XtraEditors.XtraForm
    {
        IKitapHareketService kitapHareketService = new KitapHareketManager();
        public FrmKitapAlisveris()
        {
            InitializeComponent();
            kitapHareketService.OrnekOlustur(true);
            gridControl1.DataSource = kitapHareketService.Listele();
        }
    }
}