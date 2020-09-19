using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungSongSong
{
    public partial class UngDung1 : UserControl
    {
        ImageList imglist = new ImageList();
        string tenloai;
        int loai;
        public UngDung1(string tenloai,int loai)
        {
            InitializeComponent();
            this.tenloai = tenloai;
            this.loai = loai;
        }
        public void UndDung1_Load(object sender,EventArgs e)
        {
            loadlistview();
        }
        public void loadlistview()
            
        {
            
            string sql = "SELECT HINHANH, TENUD, MAUD,SOLUOTDG FROM LOAI, UNGDUNG WHERE LOAI.MALOAI = UNGDUNG.MALOAI AND LOAI.MALOAI='"+tenloai+"'";
            DataTable data = Dataprovider.Instance.laydulieutubang(sql);
            foreach (DataRow item in data.Rows)
            {
                string ha = item["HINHANH"].ToString();

                imglist.ImageSize = new Size(100, 100);
                ListViewItem item2 = new ListViewItem(new[] { ha });
                item2.Text = item["TENUD"].ToString();
                string path2 = Application.StartupPath+"\\Images\\ungdung\\"+ha;
                string path = @"C:\Lap Trinh HUFI\khaithacdulieu\UngDungSongSong\UngDungSongSong\Images\ungdung\" + ha;
                listUngDung.LargeImageList = imglist;
                item2.ImageIndex = imglist.Images.Add(Image.FromFile(path2), Color.Transparent);
                listUngDung.Items.Add(item2);
            }


        }

        private void listUngDung_SelectedIndexChanged(object sender, EventArgs e)
        {

            //string s = listUngDung.SelectedItems[0].Text;
            //ChiTietUngDung dt = new ChiTietUngDung(s);
            //dt.ShowDialog();
        }

        private void listUngDung_Click(object sender, EventArgs e)
        {
            string s = listUngDung.SelectedItems[0].Text;
            string t = listUngDung.SelectedItems[0].SubItems[0].Text;
                 
            ChiTietUngDung dt = new ChiTietUngDung(s,t,loai);
            dt.Show();
        }

     

     
    }
}
