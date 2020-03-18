namespace NetBook.Winform.Kitap
{
    partial class FrmKitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitap));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.gridContKitap = new DevExpress.XtraGrid.GridControl();
            this.gridKitap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOduncVerilebilir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYazarId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTuruId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYayinEvi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBasimYili = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaskiSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCiltSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSayfaSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBasimYeri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDemirbasNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYazar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTurTanim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodlar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapHareketleri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Roboto Bk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.Image")));
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseImage = true;
            this.labelControl1.Appearance.Options.UseImageAlign = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1420, 52);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kitaplar";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnDuzenle);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 691);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1420, 74);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Menü";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 2;
            this.btnSil.ImageOptions.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(223, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(103, 44);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.ImageIndex = 0;
            this.btnDuzenle.ImageOptions.ImageList = this.ımageList1;
            this.btnDuzenle.Location = new System.Drawing.Point(114, 23);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(103, 44);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 1;
            this.btnEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(5, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(103, 44);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // gridContKitap
            // 
            this.gridContKitap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContKitap.Location = new System.Drawing.Point(0, 52);
            this.gridContKitap.MainView = this.gridKitap;
            this.gridContKitap.Name = "gridContKitap";
            this.gridContKitap.Size = new System.Drawing.Size(1420, 639);
            this.gridContKitap.TabIndex = 2;
            this.gridContKitap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKitap});
            // 
            // gridKitap
            // 
            this.gridKitap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDurum,
            this.colOduncVerilebilir,
            this.colBarkodId,
            this.colKitapKodu,
            this.colISBN,
            this.colKitapAdi,
            this.colYazarId,
            this.colTuruId,
            this.colYayinEvi,
            this.colBasimYili,
            this.colBaskiSayisi,
            this.colCiltSayisi,
            this.colSayfaSayisi,
            this.colBasimYeri,
            this.colDemirbasNo,
            this.colAciklama,
            this.colYazar,
            this.colTurTanim,
            this.colBarkodlar,
            this.colKitapHareketleri});
            this.gridKitap.GridControl = this.gridContKitap;
            this.gridKitap.Name = "gridKitap";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colDurum
            // 
            this.colDurum.Caption = "Durumu";
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.OptionsColumn.AllowEdit = false;
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 0;
            this.colDurum.Width = 46;
            // 
            // colOduncVerilebilir
            // 
            this.colOduncVerilebilir.Caption = "Ödünç Verilebilir";
            this.colOduncVerilebilir.FieldName = "OduncVerilebilir";
            this.colOduncVerilebilir.Name = "colOduncVerilebilir";
            this.colOduncVerilebilir.OptionsColumn.AllowEdit = false;
            this.colOduncVerilebilir.Visible = true;
            this.colOduncVerilebilir.VisibleIndex = 1;
            this.colOduncVerilebilir.Width = 89;
            // 
            // colBarkodId
            // 
            this.colBarkodId.Caption = "BarkodId";
            this.colBarkodId.FieldName = "BarkodId";
            this.colBarkodId.Name = "colBarkodId";
            this.colBarkodId.OptionsColumn.AllowEdit = false;
            this.colBarkodId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colKitapKodu
            // 
            this.colKitapKodu.Caption = "Kitap Kodu";
            this.colKitapKodu.FieldName = "KitapKodu";
            this.colKitapKodu.Name = "colKitapKodu";
            this.colKitapKodu.OptionsColumn.AllowEdit = false;
            this.colKitapKodu.Visible = true;
            this.colKitapKodu.VisibleIndex = 2;
            this.colKitapKodu.Width = 104;
            // 
            // colISBN
            // 
            this.colISBN.Caption = "ISBN";
            this.colISBN.FieldName = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.OptionsColumn.AllowEdit = false;
            this.colISBN.Visible = true;
            this.colISBN.VisibleIndex = 3;
            this.colISBN.Width = 125;
            // 
            // colKitapAdi
            // 
            this.colKitapAdi.Caption = "Kitap Adı";
            this.colKitapAdi.FieldName = "KitapAdi";
            this.colKitapAdi.Name = "colKitapAdi";
            this.colKitapAdi.OptionsColumn.AllowEdit = false;
            this.colKitapAdi.Visible = true;
            this.colKitapAdi.VisibleIndex = 4;
            this.colKitapAdi.Width = 338;
            // 
            // colYazarId
            // 
            this.colYazarId.Caption = "Yazar Id";
            this.colYazarId.FieldName = "YazarId";
            this.colYazarId.Name = "colYazarId";
            this.colYazarId.OptionsColumn.AllowEdit = false;
            this.colYazarId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colTuruId
            // 
            this.colTuruId.Caption = "Türü Id";
            this.colTuruId.FieldName = "TuruId";
            this.colTuruId.Name = "colTuruId";
            this.colTuruId.OptionsColumn.AllowEdit = false;
            this.colTuruId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colYayinEvi
            // 
            this.colYayinEvi.Caption = "Yayın Evi";
            this.colYayinEvi.FieldName = "YayinEvi";
            this.colYayinEvi.Name = "colYayinEvi";
            this.colYayinEvi.OptionsColumn.AllowEdit = false;
            this.colYayinEvi.Visible = true;
            this.colYayinEvi.VisibleIndex = 5;
            this.colYayinEvi.Width = 140;
            // 
            // colBasimYili
            // 
            this.colBasimYili.Caption = "Basim Yılı";
            this.colBasimYili.DisplayFormat.FormatString = "d";
            this.colBasimYili.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colBasimYili.FieldName = "BasimYili";
            this.colBasimYili.Name = "colBasimYili";
            this.colBasimYili.OptionsColumn.AllowEdit = false;
            this.colBasimYili.Visible = true;
            this.colBasimYili.VisibleIndex = 6;
            // 
            // colBaskiSayisi
            // 
            this.colBaskiSayisi.Caption = "Baskı Sayısı";
            this.colBaskiSayisi.FieldName = "BaskiSayisi";
            this.colBaskiSayisi.Name = "colBaskiSayisi";
            this.colBaskiSayisi.OptionsColumn.AllowEdit = false;
            this.colBaskiSayisi.Visible = true;
            this.colBaskiSayisi.VisibleIndex = 7;
            // 
            // colCiltSayisi
            // 
            this.colCiltSayisi.Caption = "Cilt Sayısı";
            this.colCiltSayisi.FieldName = "CiltSayisi";
            this.colCiltSayisi.Name = "colCiltSayisi";
            this.colCiltSayisi.OptionsColumn.AllowEdit = false;
            this.colCiltSayisi.Visible = true;
            this.colCiltSayisi.VisibleIndex = 8;
            this.colCiltSayisi.Width = 67;
            // 
            // colSayfaSayisi
            // 
            this.colSayfaSayisi.Caption = "Sayfa Sayısı";
            this.colSayfaSayisi.FieldName = "SayfaSayisi";
            this.colSayfaSayisi.Name = "colSayfaSayisi";
            this.colSayfaSayisi.OptionsColumn.AllowEdit = false;
            this.colSayfaSayisi.Visible = true;
            this.colSayfaSayisi.VisibleIndex = 9;
            // 
            // colBasimYeri
            // 
            this.colBasimYeri.Caption = "Basım Yeri";
            this.colBasimYeri.FieldName = "BasimYeri";
            this.colBasimYeri.Name = "colBasimYeri";
            this.colBasimYeri.OptionsColumn.AllowEdit = false;
            // 
            // colDemirbasNo
            // 
            this.colDemirbasNo.Caption = "Demirbaş No";
            this.colDemirbasNo.FieldName = "DemirbasNo";
            this.colDemirbasNo.Name = "colDemirbasNo";
            this.colDemirbasNo.OptionsColumn.AllowEdit = false;
            this.colDemirbasNo.Visible = true;
            this.colDemirbasNo.VisibleIndex = 10;
            this.colDemirbasNo.Width = 74;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 11;
            this.colAciklama.Width = 194;
            // 
            // colYazar
            // 
            this.colYazar.Caption = "Yazar";
            this.colYazar.FieldName = "Yazar";
            this.colYazar.Name = "colYazar";
            this.colYazar.OptionsColumn.AllowEdit = false;
            // 
            // colTurTanim
            // 
            this.colTurTanim.Caption = "Tür Tanımı";
            this.colTurTanim.FieldName = "TurTanim";
            this.colTurTanim.Name = "colTurTanim";
            this.colTurTanim.OptionsColumn.AllowEdit = false;
            // 
            // colBarkodlar
            // 
            this.colBarkodlar.Caption = "Barkodlar";
            this.colBarkodlar.FieldName = "Barkodlar";
            this.colBarkodlar.Name = "colBarkodlar";
            this.colBarkodlar.OptionsColumn.AllowEdit = false;
            // 
            // colKitapHareketleri
            // 
            this.colKitapHareketleri.Caption = "Kitap Hareketleri";
            this.colKitapHareketleri.FieldName = "KitapHareketleri";
            this.colKitapHareketleri.Name = "colKitapHareketleri";
            this.colKitapHareketleri.OptionsColumn.AllowEdit = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 4;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(332, 23);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(103, 44);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 3;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(1305, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(103, 44);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "düzenle.png");
            this.ımageList1.Images.SetKeyName(1, "Ekle.png");
            this.ımageList1.Images.SetKeyName(2, "sil.png");
            this.ımageList1.Images.SetKeyName(3, "folder_out.png");
            this.ımageList1.Images.SetKeyName(4, "refresh.png");
            // 
            // FrmKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 765);
            this.Controls.Add(this.gridContKitap);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmKitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitaplar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraGrid.GridControl gridContKitap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKitap;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colOduncVerilebilir;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodId;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colISBN;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colYazarId;
        private DevExpress.XtraGrid.Columns.GridColumn colTuruId;
        private DevExpress.XtraGrid.Columns.GridColumn colYayinEvi;
        private DevExpress.XtraGrid.Columns.GridColumn colBasimYili;
        private DevExpress.XtraGrid.Columns.GridColumn colBaskiSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colCiltSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colSayfaSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colBasimYeri;
        private DevExpress.XtraGrid.Columns.GridColumn colDemirbasNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colYazar;
        private DevExpress.XtraGrid.Columns.GridColumn colTurTanim;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodlar;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapHareketleri;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
    }
}