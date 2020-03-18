namespace NetBook.Winform.KitapHareket
{
    partial class FrmKitapAlisveris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitapAlisveris));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUyeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerilisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerilisSuresi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeslimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOkulNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUyeBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUyeAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUyeSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeslimEdilmesiGerekenTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKacGunGecikti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "refresh.png");
            this.ımageList1.Images.SetKeyName(2, "Cari Düzenle.png");
            this.ımageList1.Images.SetKeyName(3, "Cari Ekle.png");
            this.ımageList1.Images.SetKeyName(4, "Cari Sil.png");
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
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(1305, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(103, 44);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 1;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(332, 23);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(103, 44);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 4;
            this.btnSil.ImageOptions.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(223, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(103, 44);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.ImageIndex = 2;
            this.btnDuzenle.ImageOptions.ImageList = this.ımageList1;
            this.btnDuzenle.Location = new System.Drawing.Point(114, 23);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(103, 44);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 3;
            this.btnEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(5, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(103, 44);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
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
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Üyeler";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 52);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1420, 639);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKitapId,
            this.colUyeId,
            this.colVerilisTarihi,
            this.colVerilisSuresi,
            this.colTeslimTarihi,
            this.colAciklama,
            this.colKitapKodu,
            this.colKitapAdi,
            this.colOkulNo,
            this.colUyeBarkod,
            this.colUyeAdi,
            this.colUyeSoyadi,
            this.colTeslimEdilmesiGerekenTarih,
            this.colKacGunGecikti,
            this.colDurumu,
            this.colKitapBarkod});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.FixedWidth = true;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colKitapId
            // 
            this.colKitapId.Caption = "KitapId";
            this.colKitapId.FieldName = "KitapId";
            this.colKitapId.Name = "colKitapId";
            this.colKitapId.OptionsColumn.AllowEdit = false;
            this.colKitapId.OptionsColumn.FixedWidth = true;
            this.colKitapId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colUyeId
            // 
            this.colUyeId.Caption = "UyeId";
            this.colUyeId.FieldName = "UyeId";
            this.colUyeId.Name = "colUyeId";
            this.colUyeId.OptionsColumn.AllowEdit = false;
            this.colUyeId.OptionsColumn.FixedWidth = true;
            this.colUyeId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colVerilisTarihi
            // 
            this.colVerilisTarihi.Caption = "Veriliş Tarihi";
            this.colVerilisTarihi.FieldName = "VerilisTarihi";
            this.colVerilisTarihi.Name = "colVerilisTarihi";
            this.colVerilisTarihi.OptionsColumn.AllowEdit = false;
            this.colVerilisTarihi.OptionsColumn.FixedWidth = true;
            this.colVerilisTarihi.Visible = true;
            this.colVerilisTarihi.VisibleIndex = 8;
            this.colVerilisTarihi.Width = 74;
            // 
            // colVerilisSuresi
            // 
            this.colVerilisSuresi.Caption = "Veriliş Süresi";
            this.colVerilisSuresi.FieldName = "VerilisSuresi";
            this.colVerilisSuresi.Name = "colVerilisSuresi";
            this.colVerilisSuresi.OptionsColumn.AllowEdit = false;
            this.colVerilisSuresi.OptionsColumn.FixedWidth = true;
            this.colVerilisSuresi.Visible = true;
            this.colVerilisSuresi.VisibleIndex = 9;
            this.colVerilisSuresi.Width = 73;
            // 
            // colTeslimTarihi
            // 
            this.colTeslimTarihi.Caption = "Teslim Tarihi";
            this.colTeslimTarihi.FieldName = "TeslimTarihi";
            this.colTeslimTarihi.Name = "colTeslimTarihi";
            this.colTeslimTarihi.OptionsColumn.AllowEdit = false;
            this.colTeslimTarihi.OptionsColumn.FixedWidth = true;
            this.colTeslimTarihi.Visible = true;
            this.colTeslimTarihi.VisibleIndex = 11;
            this.colTeslimTarihi.Width = 71;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.OptionsColumn.FixedWidth = true;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 12;
            this.colAciklama.Width = 197;
            // 
            // colKitapKodu
            // 
            this.colKitapKodu.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colKitapKodu.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colKitapKodu.AppearanceCell.Options.UseBackColor = true;
            this.colKitapKodu.Caption = "Kitap Kodu";
            this.colKitapKodu.FieldName = "Kitap.KitapKodu";
            this.colKitapKodu.Name = "colKitapKodu";
            this.colKitapKodu.OptionsColumn.AllowEdit = false;
            this.colKitapKodu.OptionsColumn.FixedWidth = true;
            this.colKitapKodu.Visible = true;
            this.colKitapKodu.VisibleIndex = 2;
            this.colKitapKodu.Width = 79;
            // 
            // colKitapAdi
            // 
            this.colKitapAdi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colKitapAdi.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colKitapAdi.AppearanceCell.Options.UseBackColor = true;
            this.colKitapAdi.Caption = "Kitap Adı";
            this.colKitapAdi.FieldName = "Kitap.KitapAdi";
            this.colKitapAdi.Name = "colKitapAdi";
            this.colKitapAdi.OptionsColumn.AllowEdit = false;
            this.colKitapAdi.OptionsColumn.FixedWidth = true;
            this.colKitapAdi.Visible = true;
            this.colKitapAdi.VisibleIndex = 3;
            this.colKitapAdi.Width = 274;
            // 
            // colOkulNo
            // 
            this.colOkulNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colOkulNo.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.colOkulNo.AppearanceCell.Options.UseBackColor = true;
            this.colOkulNo.Caption = "Okul No";
            this.colOkulNo.FieldName = "Uye.OkulNo";
            this.colOkulNo.Name = "colOkulNo";
            this.colOkulNo.OptionsColumn.AllowEdit = false;
            this.colOkulNo.OptionsColumn.FixedWidth = true;
            this.colOkulNo.Visible = true;
            this.colOkulNo.VisibleIndex = 5;
            this.colOkulNo.Width = 54;
            // 
            // colUyeBarkod
            // 
            this.colUyeBarkod.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colUyeBarkod.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.colUyeBarkod.AppearanceCell.Options.UseBackColor = true;
            this.colUyeBarkod.Caption = "Üye Barkodu";
            this.colUyeBarkod.FieldName = "Uye.Barkod";
            this.colUyeBarkod.Name = "colUyeBarkod";
            this.colUyeBarkod.OptionsColumn.AllowEdit = false;
            this.colUyeBarkod.OptionsColumn.FixedWidth = true;
            this.colUyeBarkod.Visible = true;
            this.colUyeBarkod.VisibleIndex = 4;
            this.colUyeBarkod.Width = 71;
            // 
            // colUyeAdi
            // 
            this.colUyeAdi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colUyeAdi.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.colUyeAdi.AppearanceCell.Options.UseBackColor = true;
            this.colUyeAdi.Caption = "Adı";
            this.colUyeAdi.FieldName = "Uye.Adi";
            this.colUyeAdi.Name = "colUyeAdi";
            this.colUyeAdi.OptionsColumn.AllowEdit = false;
            this.colUyeAdi.OptionsColumn.FixedWidth = true;
            this.colUyeAdi.Visible = true;
            this.colUyeAdi.VisibleIndex = 6;
            this.colUyeAdi.Width = 107;
            // 
            // colUyeSoyadi
            // 
            this.colUyeSoyadi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colUyeSoyadi.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.colUyeSoyadi.AppearanceCell.Options.UseBackColor = true;
            this.colUyeSoyadi.Caption = "Soyadı";
            this.colUyeSoyadi.FieldName = "Uye.Soyadi";
            this.colUyeSoyadi.Name = "colUyeSoyadi";
            this.colUyeSoyadi.OptionsColumn.AllowEdit = false;
            this.colUyeSoyadi.OptionsColumn.FixedWidth = true;
            this.colUyeSoyadi.Visible = true;
            this.colUyeSoyadi.VisibleIndex = 7;
            this.colUyeSoyadi.Width = 114;
            // 
            // colTeslimEdilmesiGerekenTarih
            // 
            this.colTeslimEdilmesiGerekenTarih.Caption = "Teslim Edilmesi Gereken Tarih";
            this.colTeslimEdilmesiGerekenTarih.FieldName = "colTeslimEdilmesiGerekenTarih";
            this.colTeslimEdilmesiGerekenTarih.Name = "colTeslimEdilmesiGerekenTarih";
            this.colTeslimEdilmesiGerekenTarih.OptionsColumn.AllowEdit = false;
            this.colTeslimEdilmesiGerekenTarih.OptionsColumn.FixedWidth = true;
            this.colTeslimEdilmesiGerekenTarih.UnboundExpression = "AddDays([VerilisTarihi], [VerilisSuresi])";
            this.colTeslimEdilmesiGerekenTarih.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.colTeslimEdilmesiGerekenTarih.Visible = true;
            this.colTeslimEdilmesiGerekenTarih.VisibleIndex = 10;
            this.colTeslimEdilmesiGerekenTarih.Width = 89;
            // 
            // colKacGunGecikti
            // 
            this.colKacGunGecikti.Caption = "Kaç Gün Gecikti";
            this.colKacGunGecikti.FieldName = "colKacGunGecikti";
            this.colKacGunGecikti.Name = "colKacGunGecikti";
            this.colKacGunGecikti.OptionsColumn.AllowEdit = false;
            this.colKacGunGecikti.OptionsColumn.FixedWidth = true;
            this.colKacGunGecikti.UnboundExpression = "Abs(DateDiffDay([colTeslimEdilmesiGerekenTarih], Today()))";
            this.colKacGunGecikti.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // colDurumu
            // 
            this.colDurumu.Caption = "Durum";
            this.colDurumu.FieldName = "colDurumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.OptionsColumn.AllowEdit = false;
            this.colDurumu.OptionsColumn.FixedWidth = true;
            this.colDurumu.UnboundExpression = "Iif([colKacGunGecikti] > 0, [colKacGunGecikti] + \' Gün Gecikti\', Iif([colKacGunGe" +
    "cikti] = 0, \'Bugün Teslim Edilecek\', Abs([colKacGunGecikti]) + \' Gün İçinde Tesl" +
    "im Edilecek\'))";
            this.colDurumu.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 0;
            this.colDurumu.Width = 126;
            // 
            // colKitapBarkod
            // 
            this.colKitapBarkod.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colKitapBarkod.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colKitapBarkod.AppearanceCell.Options.UseBackColor = true;
            this.colKitapBarkod.Caption = "Kitap Barkodu";
            this.colKitapBarkod.FieldName = "Barkod.Barkodu";
            this.colKitapBarkod.Name = "colKitapBarkod";
            this.colKitapBarkod.OptionsColumn.AllowEdit = false;
            this.colKitapBarkod.OptionsColumn.FixedWidth = true;
            this.colKitapBarkod.Visible = true;
            this.colKitapBarkod.VisibleIndex = 1;
            this.colKitapBarkod.Width = 73;
            // 
            // FrmKitapAlisveris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 765);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmKitapAlisveris";
            this.Text = "FrmKitapAlisveris";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapId;
        private DevExpress.XtraGrid.Columns.GridColumn colUyeId;
        private DevExpress.XtraGrid.Columns.GridColumn colVerilisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colVerilisSuresi;
        private DevExpress.XtraGrid.Columns.GridColumn colTeslimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colOkulNo;
        private DevExpress.XtraGrid.Columns.GridColumn colUyeBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colUyeAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colUyeSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colTeslimEdilmesiGerekenTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colKacGunGecikti;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapBarkod;
    }
}