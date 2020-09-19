namespace UngDungSongSong
{
    partial class UngDung1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.listUngDung = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1097, 78);
            this.panelControl1.TabIndex = 0;
            // 
            // listUngDung
            // 
            this.listUngDung.BackColor = System.Drawing.Color.White;
            this.listUngDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUngDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUngDung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listUngDung.Location = new System.Drawing.Point(0, 78);
            this.listUngDung.Name = "listUngDung";
            this.listUngDung.Size = new System.Drawing.Size(900, 853);
            this.listUngDung.TabIndex = 1;
            this.listUngDung.UseCompatibleStateImageBehavior = false;
            this.listUngDung.SelectedIndexChanged += new System.EventHandler(this.listUngDung_SelectedIndexChanged);
            this.listUngDung.Click += new System.EventHandler(this.listUngDung_Click);
            // 
            // UngDung1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listUngDung);
            this.Controls.Add(this.panelControl1);
            this.Name = "UngDung1";
            this.Size = new System.Drawing.Size(1097, 931);
            this.Load += new System.EventHandler(this.UndDung1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ListView listUngDung;
    }
}
