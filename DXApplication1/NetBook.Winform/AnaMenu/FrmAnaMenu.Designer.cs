namespace NetBook.Winform
{
    partial class FrmAnaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaMenu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnKitaplar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUyeler = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSiniflar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnKitapAlisverisi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnKitapHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnKitaplar,
            this.barBtnUyeler,
            this.barButtonItem3,
            this.barBtnSiniflar,
            this.barBtnKitapAlisverisi,
            this.barBtnKitapHareketleri});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1388, 143);
            // 
            // barBtnKitaplar
            // 
            this.barBtnKitaplar.Caption = "Kitaplar";
            this.barBtnKitaplar.Id = 1;
            this.barBtnKitaplar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnKitaplar.ImageOptions.LargeImage")));
            this.barBtnKitaplar.Name = "barBtnKitaplar";
            this.barBtnKitaplar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnKitaplar_ItemClick);
            // 
            // barBtnUyeler
            // 
            this.barBtnUyeler.Caption = "Üyeler";
            this.barBtnUyeler.Id = 2;
            this.barBtnUyeler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnUyeler.ImageOptions.LargeImage")));
            this.barBtnUyeler.Name = "barBtnUyeler";
            this.barBtnUyeler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUyeler_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Sınıflar";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barBtnSiniflar
            // 
            this.barBtnSiniflar.Caption = "Sınıflar";
            this.barBtnSiniflar.Id = 4;
            this.barBtnSiniflar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSiniflar.ImageOptions.LargeImage")));
            this.barBtnSiniflar.Name = "barBtnSiniflar";
            this.barBtnSiniflar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSiniflar_ItemClick);
            // 
            // barBtnKitapAlisverisi
            // 
            this.barBtnKitapAlisverisi.Caption = "Kitap Alışverişi";
            this.barBtnKitapAlisverisi.Id = 5;
            this.barBtnKitapAlisverisi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnKitapAlisverisi.ImageOptions.LargeImage")));
            this.barBtnKitapAlisverisi.Name = "barBtnKitapAlisverisi";
            this.barBtnKitapAlisverisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnKitapAlisverisi_ItemClick);
            // 
            // barBtnKitapHareketleri
            // 
            this.barBtnKitapHareketleri.Caption = "Kitap Hareketleri";
            this.barBtnKitapHareketleri.Id = 6;
            this.barBtnKitapHareketleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnKitapHareketleri.ImageOptions.LargeImage")));
            this.barBtnKitapHareketleri.Name = "barBtnKitapHareketleri";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Genel İşlemler";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnKitaplar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnUyeler);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnSiniflar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Kayıtlar";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnKitapAlisverisi);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnKitapHareketleri);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "İşlemler";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmAnaMenu
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 789);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmAnaMenu";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barBtnKitaplar;
        private DevExpress.XtraBars.BarButtonItem barBtnUyeler;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barBtnSiniflar;
        private DevExpress.XtraBars.BarButtonItem barBtnKitapAlisverisi;
        private DevExpress.XtraBars.BarButtonItem barBtnKitapHareketleri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

