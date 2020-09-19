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

namespace UngDungSongSong
{
    public partial class ChiTietUngDung : DevExpress.XtraEditors.XtraForm
    {
        string hinhanh;
        ImageList lstviewItemImageList = new ImageList();
        List<Button> btn;
        string ten;
        int loai;
             
        public ChiTietUngDung(string hinhanh,string ten,int loai)
        {
            InitializeComponent();
            this.hinhanh = hinhanh;
            this.ten = ten;
            this.loai = loai;
        }

        private void ChiTietUngDung_Load(object sender, EventArgs e)
        {
            listChiTiet.View = View.Details;
            listChiTiet.Columns.Add("Hình ảnh");
            listChiTiet.Columns.Add("Mã");
            listChiTiet.Columns.Add("Tên");
            listChiTiet.Columns.Add("Số lượt đánh giá");
            listChiTiet.Columns.Add("Số lượt tải");
            listChiTiet.Columns.Add("Tổng điểm đánh giá");
            listChiTiet.Columns.Add("Trung bình đánh giá");

            listChiTiet.Columns.Add("MÃ Loại");
            listChiTiet.Columns[0].Width = 150;
           

            listChiTiet.Columns[1].Width = 120;
            listChiTiet.Columns[2].Width = 120;
            listChiTiet.Columns[3].Width = 150;
            listChiTiet.Columns[4].Width = 150;
            listChiTiet.Columns[5].Width = 190;
            listChiTiet.Columns[6].Width = 190;
            listChiTiet.Columns[7].Width = 120;
            
            loadlistview();
            if (loai == 1)
            {
                lblten.Text ="Game  "+ten;
            }
            if (loai == 2)
            {
                lblten.Text = "App  " + ten;
            }
            if(loai==3)
            {
                lblten.Text = "Sách  " + ten;
            }
            if (loai == 4)
            {
                lblten.Text = "Phim  " + ten;
            }
            btnDanhGia.Enabled = false;
       
        }
        public void loadlistview()
        {
            listChiTiet.Items.Clear();
            string sql = "SELECT * FROM UNGDUNG WHERE UNGDUNG.TENUD LIKE N'%" + hinhanh + "%'";


      
            DataTable data = Dataprovider.Instance.laydulieutubang(sql);
            foreach (DataRow item in data.Rows)
            {
                string maud = item["MAUD"].ToString();
                string tenud =item["TENUD"].ToString();
                string ha = item["HINHANH"].ToString();
                string sldg = item["SOLUOTDG"].ToString();
                string luotdowwn = item["LUOTDOWN"].ToString();
                string tddg = item["TONGDG"].ToString();
                string danhgia = item["DANHGIA"].ToString();
                string maloai = item["MALOAI"].ToString();
                if (int.Parse(sldg) != 0)
                {
                    double tb = double.Parse(tddg) / double.Parse(sldg);
                    ListViewItem item2 = new ListViewItem(new[] { ha, maud, tenud, sldg, luotdowwn, tddg, tb.ToString("0.00"), maloai });

                    lstviewItemImageList.ImageSize = new Size(150, 256);
                    string path2 = Application.StartupPath + "\\Images\\ungdung\\" + ha;
                    string path = @"C:\Lap Trinh HUFI\khaithacdulieu\UngDungSongSong\UngDungSongSong\Images\ungdung\" + ha;
                    listChiTiet.SmallImageList = lstviewItemImageList;
                    item2.ImageIndex = lstviewItemImageList.Images.Add(Image.FromFile(path2), Color.Transparent);
                    listChiTiet.Items.Add(item2);
                }
                else
                {
                    ListViewItem item2 = new ListViewItem(new[] { ha, maud, tenud, sldg, luotdowwn, tddg, "0", maloai });

                    lstviewItemImageList.ImageSize = new Size(150, 256);

                    string path = @"C:\Lap Trinh HUFI\khaithacdulieu\UngDungSongSong\UngDungSongSong\Images\ungdung\" + ha;
                    listChiTiet.SmallImageList = lstviewItemImageList;
                    item2.ImageIndex = lstviewItemImageList.Images.Add(Image.FromFile(path), Color.Transparent);
                    listChiTiet.Items.Add(item2);
                }
            }
            }

        public void xuliDanhGia()
        {
            btn = new List<Button>();
            btn.Add(btnSao1);
            btn.Add(btnSao2);
            btn.Add(btnSao3);
            btn.Add(btnSao4);
            btn.Add(btnSao5);

        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.BackColor == Color.Black)
            {
                bt.BackColor = Color.Yellow;
            }
            else
            {
                bt.BackColor = Color.Black;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            xuliDanhGia();
            for (int i = 0; i < btn.Count; i++)
            {
                if (btn[i].BackColor == Color.Yellow)
                {
                    listChiTiet.Items[0].SubItems[5].Text = (int.Parse(listChiTiet.Items[0].SubItems[5].Text) + 1).ToString();
                }
            }
            listChiTiet.Items[0].SubItems[3].Text = (int.Parse(listChiTiet.Items[0].SubItems[3].Text) + 1).ToString();
            listChiTiet.Items[0].SubItems[6].Text = (double.Parse(listChiTiet.Items[0].SubItems[5].Text) / double.Parse(listChiTiet.Items[0].SubItems[3].Text)).ToString("0.00");
            string sql = "update UNGDUNG set SOLUOTDG= '" + listChiTiet.Items[0].SubItems[3].Text + "', TONGDG='" + listChiTiet.Items[0].SubItems[5].Text + "' where MAUD='" + listChiTiet.Items[0].SubItems[1].Text + "'";
            if(Dataprovider.Instance.thucthicaulenhsql(sql))
            {
                XtraMessageBox.Show("Đánh Giá Thành Công");
                btnDanhGia.Enabled = false;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
           listChiTiet.Items[0].SubItems[4].Text = (int.Parse(listChiTiet.Items[0].SubItems[4].Text) + 1).ToString();
            string s = listChiTiet.Items[0].SubItems[4].Text;
            string sql = "update UNGDUNG set LUOTDOWN="+int.Parse(s)+" where MAUD='"+listChiTiet.Items[0].SubItems[1].Text+"'";
           if( Dataprovider.Instance.thucthicaulenhsql(sql))
            {
                XtraMessageBox.Show("Tải OK!!");
                btnDanhGia.Enabled = true;
                
            }
        }
    }
    
}