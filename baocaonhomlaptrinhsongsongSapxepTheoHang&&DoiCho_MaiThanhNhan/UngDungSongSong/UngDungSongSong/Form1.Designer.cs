namespace UngDungSongSong
{
    partial class Form1
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnTroChoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnUngDung = new DevExpress.XtraBars.BarButtonItem();
            this.btnSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhim = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTuanTu = new DevExpress.XtraBars.BarButtonItem();
            this.btnSongSong = new DevExpress.XtraBars.BarButtonItem();
            this.btnTuantu2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSongSong2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnTroChoi,
            this.btnUngDung,
            this.btnSach,
            this.btnPhim,
            this.barButtonItem1,
            this.btnTuanTu,
            this.btnSongSong,
            this.btnTuantu2,
            this.btnSongSong2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1300, 193);
            // 
            // btnTroChoi
            // 
            this.btnTroChoi.Caption = "Trò chơi";
            this.btnTroChoi.Id = 1;
            this.btnTroChoi.ImageOptions.Image = global::UngDungSongSong.Properties.Resources.game_console;
            this.btnTroChoi.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroChoi.ItemAppearance.Normal.Options.UseFont = true;
            this.btnTroChoi.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroChoi.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnTroChoi.Name = "btnTroChoi";
            this.btnTroChoi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTroChoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnUngDung
            // 
            this.btnUngDung.Caption = "Ứng Dụng";
            this.btnUngDung.Id = 2;
            this.btnUngDung.ImageOptions.Image = global::UngDungSongSong.Properties.Resources.app_store;
            this.btnUngDung.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUngDung.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnUngDung.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUngDung.ItemAppearance.Normal.Options.UseFont = true;
            this.btnUngDung.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUngDung.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnUngDung.LargeWidth = 140;
            this.btnUngDung.Name = "btnUngDung";
            this.btnUngDung.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnUngDung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnSach
            // 
            this.btnSach.Caption = "Sách";
            this.btnSach.Id = 3;
            this.btnSach.ImageOptions.Image = global::UngDungSongSong.Properties.Resources.book;
            this.btnSach.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSach.LargeWidth = 140;
            this.btnSach.Name = "btnSach";
            this.btnSach.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSach_ItemClick);
            // 
            // btnPhim
            // 
            this.btnPhim.Caption = "Phim";
            this.btnPhim.Id = 4;
            this.btnPhim.ImageOptions.Image = global::UngDungSongSong.Properties.Resources.video_player;
            this.btnPhim.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhim.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPhim.LargeWidth = 140;
            this.btnPhim.Name = "btnPhim";
            this.btnPhim.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.btnPhim.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhim_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnTuanTu
            // 
            this.btnTuanTu.Caption = "Sắp Xếp Theo Hạng Tuần Tự";
            this.btnTuanTu.Id = 10;
            this.btnTuanTu.ImageOptions.Image = global::UngDungSongSong.Properties.Resources.transfer;
            this.btnTuanTu.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuanTu.ItemAppearance.Normal.Options.UseFont = true;
            this.btnTuanTu.Name = "btnTuanTu";
            this.btnTuanTu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTuanTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTuanTu_ItemClick);
            // 
            // btnSongSong
            // 
            this.btnSongSong.Caption = "Sắp Xếp Theo  Hạng Song Song";
            this.btnSongSong.Id = 11;
            this.btnSongSong.ImageOptions.Image = global::UngDungSongSong.Properties.Resources.sort;
            this.btnSongSong.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSongSong.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSongSong.Name = "btnSongSong";
            this.btnSongSong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSongSong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSongSong_ItemClick);
            // 
            // btnTuantu2
            // 
            this.btnTuantu2.Caption = "Sắp Xếp Đổi Chổ Tuần Tự";
            this.btnTuantu2.Id = 12;
            this.btnTuantu2.ImageOptions.Image = global::UngDungSongSong.Properties.Resources.sorttt;
            this.btnTuantu2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuantu2.ItemAppearance.Normal.Options.UseFont = true;
            this.btnTuantu2.Name = "btnTuantu2";
            this.btnTuantu2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTuantu2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTuantu2_ItemClick);
            // 
            // btnSongSong2
            // 
            this.btnSongSong2.Caption = "Sắp Xếp Đổi Chổ Song Song";
            this.btnSongSong2.Id = 13;
            this.btnSongSong2.ImageOptions.Image = global::UngDungSongSong.Properties.Resources.sorttt3;
            this.btnSongSong2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSongSong2.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSongSong2.Name = "btnSongSong2";
            this.btnSongSong2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSongSong2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSongSong2_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ứng Dụng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTroChoi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUngDung);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSach);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnPhim);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8,
            this.ribbonPageGroup9});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Chức Năng";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTuanTu);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnSongSong);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnTuantu2);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnSongSong2);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.ContentImage = global::UngDungSongSong.Properties.Resources.background_bien_tuyet_dep_cho_ghep_anh_17;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 193);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1300, 760);
            this.panelControl1.TabIndex = 3;
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 953);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnTroChoi;
        private DevExpress.XtraBars.BarButtonItem btnUngDung;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnSach;
        private DevExpress.XtraBars.BarButtonItem btnPhim;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnTuanTu;
        private DevExpress.XtraBars.BarButtonItem btnSongSong;
        private DevExpress.XtraBars.BarButtonItem btnTuantu2;
        private DevExpress.XtraBars.BarButtonItem btnSongSong2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}

