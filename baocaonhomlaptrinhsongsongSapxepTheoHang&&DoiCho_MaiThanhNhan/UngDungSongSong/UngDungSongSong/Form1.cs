using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UngDungSongSong
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
         int  loai;
        public Form1()
        {
            InitializeComponent();
            skins();
        }

        public void skins()


        {
            DevExpress.LookAndFeel.DefaultLookAndFeel thems = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            thems.LookAndFeel.SkinName = "Xmas 2008 Blue";

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            panelControl1.Dock = DockStyle.Fill;

            UngDung1 frm = new UngDung1("ML02", 1);
           frm.Show();
            frm.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(frm);



        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            panelControl1.Dock = DockStyle.Fill;

            UngDung1 frm = new UngDung1("ML01", 2);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(frm);
        }

        private void btnSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            panelControl1.Dock = DockStyle.Fill;

            UngDung1 frm = new UngDung1("ML03", 3);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(frm);
        }

        private void btnPhim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
         panelControl1.Controls.Clear();
            panelControl1.Dock = DockStyle.Fill;

            UngDung1 frm = new UngDung1("ML04", 4);
        frm.Show();
            frm.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(frm);

        }

   

    

        private void btnTuanTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LuaChonSapXep frm1 = new LuaChonSapXep(1);
            this.Hide();
            frm1.ShowDialog();
        }

        private void btnSongSong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            LuaChonSapXep frm1 = new LuaChonSapXep(2);
            this.Hide();
            frm1.ShowDialog();
        }

        private void btnTuantu2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LuaChonSapXep frm1 = new LuaChonSapXep(3);
            this.Hide();
            frm1.ShowDialog();
        }

        private void btnSongSong2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            LuaChonSapXep frm1 = new LuaChonSapXep(4);
            this.Hide();
            frm1.ShowDialog();
        }
    }
}
