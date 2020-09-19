namespace UngDungSongSong
{
    partial class UngDungSapXep
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblloaisapxep = new DevExpress.XtraEditors.LabelControl();
            this.txtThoiGian = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lstUngdung = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hiểnThịChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGian.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblloaisapxep);
            this.panelControl1.Controls.Add(this.txtThoiGian);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1184, 128);
            this.panelControl1.TabIndex = 0;
            // 
            // lblloaisapxep
            // 
            this.lblloaisapxep.Appearance.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloaisapxep.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblloaisapxep.Appearance.Options.UseFont = true;
            this.lblloaisapxep.Appearance.Options.UseForeColor = true;
            this.lblloaisapxep.Location = new System.Drawing.Point(557, 12);
            this.lblloaisapxep.Name = "lblloaisapxep";
            this.lblloaisapxep.Size = new System.Drawing.Size(188, 37);
            this.lblloaisapxep.TabIndex = 3;
            this.lblloaisapxep.Text = "lblloaiSapxep";
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Location = new System.Drawing.Point(787, 74);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGian.Properties.Appearance.Options.UseFont = true;
            this.txtThoiGian.Size = new System.Drawing.Size(266, 30);
            this.txtThoiGian.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(639, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(124, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Thời Gian Xử Lý";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(307, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(232, 37);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Sau Khi Sắp Sếp";
            // 
            // lstUngdung
            // 
            this.lstUngdung.BackColor = System.Drawing.Color.Black;
            this.lstUngdung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUngdung.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUngdung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lstUngdung.Location = new System.Drawing.Point(0, 128);
            this.lstUngdung.Name = "lstUngdung";
            this.lstUngdung.Size = new System.Drawing.Size(1184, 570);
            this.lstUngdung.TabIndex = 1;
            this.lstUngdung.UseCompatibleStateImageBehavior = false;
            this.lstUngdung.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiểnThịChiTiếtToolStripMenuItem,
            this.hiểnThịDanhSáchToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(208, 52);
            // 
            // hiểnThịChiTiếtToolStripMenuItem
            // 
            this.hiểnThịChiTiếtToolStripMenuItem.Name = "hiểnThịChiTiếtToolStripMenuItem";
            this.hiểnThịChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.hiểnThịChiTiếtToolStripMenuItem.Text = "Hiển Thị Chi Tiết";
            this.hiểnThịChiTiếtToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịChiTiếtToolStripMenuItem_Click);
            // 
            // hiểnThịDanhSáchToolStripMenuItem
            // 
            this.hiểnThịDanhSáchToolStripMenuItem.Name = "hiểnThịDanhSáchToolStripMenuItem";
            this.hiểnThịDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.hiểnThịDanhSáchToolStripMenuItem.Text = "Hiển Thị Danh Sách";
            this.hiểnThịDanhSáchToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịDanhSáchToolStripMenuItem_Click);
            // 
            // UngDungSapXep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 698);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lstUngdung);
            this.Controls.Add(this.panelControl1);
            this.Name = "UngDungSapXep";
            this.Text = "UngDungSapXep";
            this.Load += new System.EventHandler(this.UngDungSapXep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGian.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtThoiGian;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ListView lstUngdung;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịChiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịDanhSáchToolStripMenuItem;
        private DevExpress.XtraEditors.LabelControl lblloaisapxep;
    }
}